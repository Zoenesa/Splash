Imports Telerik, Telerik.WinControls, Telerik.WinControls.UI
Imports Microsoft.VisualBasic.CompilerServices, MySql.Data.MySqlClient
Imports System.Threading
Imports Splash.Konektor.mdlstring
Imports System.Runtime.CompilerServices
Imports Splash.Konektor

Public Class rFormListWorkOrder
    Private iduserEdit As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Telerik.WinControls.RadMessageBox.Instance.AllowTheming = True
        Telerik.WinControls.RadMessageBox.Instance.ControlBox = False
        Telerik.WinControls.RadMessageBox.ShowInTaskbar = False
        Telerik.WinControls.RadMessageBox.ThemeName = rFormMain.Office2010BlackTheme1.ThemeName
        Dim strTheme As String = rFormMain.Office2010BlackTheme1.ThemeName
        rFormMain.SetTheme(Me, strTheme)


    End Sub

    Private Sub BtnEditDeleteEnable()
        Dim num1 As Integer = 0
        Try
            Me.btnEdit.Enabled = False
            Me.btnErase.Enabled = False
            Dim num2 As Integer = 0
            Dim num3 As Integer = Me.dg.Rows.Count - 1
            Dim index As Integer = num2
            While index <= num3
                If Conversions.ToBoolean(Me.dg.Rows(index).Cells(0).Value) Then
                    System.Threading.Interlocked.Increment(num1)
                    Me.iduserEdit = Conversions.ToString(Me.dg.Rows(index).Cells(2).Value)
                    If num1 > 1 Then
                        Exit While
                    End If
                End If
                System.Threading.Interlocked.Increment(index)
            End While
            Select Case num1
                Case 0
                    Me.btnEdit.Enabled = False
                    'Me.btnPDF.Enabled = False
                    Me.btnErase.Enabled = False
                    Me.iduserEdit = "-1"
                    Exit Select
                Case 1
                    Me.btnEdit.Enabled = True
                    'Me.btnPDF.Enabled = True
                    Me.btnErase.Enabled = True
                    Exit Select
                Case Else
                    Me.btnEdit.Enabled = False
                    'Me.btnPDF.Enabled = False
                    Me.btnErase.Enabled = True
                    Me.iduserEdit = "-1"
                    Exit Select
            End Select
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim exception As Exception = ex
            mdlCom.ShowError("Failed (edit_delete). Message : " + exception.Message)
            mdlCom.INSERTLOG("Failed (edit_delete). Message : " + exception.Message, "")
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Public Sub LoadWorkorder(Optional ByVal Opsi As String = "")
        Dim sqlreaderWO As MySqlDataReader = Nothing
        Dim mysqlcommand As MySqlCommand = New MySqlCommand
        Try
            dg.Rows.Clear()
            Dim strCommand As String = "SELECT * FROM `listworkorder` " & Opsi & " ORDER BY `ID`;"
            'mdlCom.BukaKoneksi()
            mysqlcommand.CommandText = strCommand
            mysqlcommand.Connection = Konektor.mdlCom.vConn
            sqlreaderWO = mysqlcommand.ExecuteReader
            'If sqlreaderWO.HasRows Then
            Dim strField As String() = New String(9 - 1) {}
            Do While sqlreaderWO.Read
                strField(0) = Conversions.ToString(False)
                strField(1) = Conversions.ToString(sqlreaderWO.Item("ID"))
                strField(2) = Conversions.ToString(sqlreaderWO.Item("WO_CLIENTNAME"))
                strField(3) = Conversions.ToString(sqlreaderWO.Item("WO_NO"))
                strField(4) = Conversions.ToString(sqlreaderWO.Item("WO_DATE"))
                strField(5) = Conversions.ToString(sqlreaderWO.Item("UserPerekam"))
                strField(6) = Conversions.ToString(sqlreaderWO.Item("TanggalRekam"))
                strField(7) = Conversions.ToString(sqlreaderWO.Item("UserUpdate"))
                strField(8) = Conversions.ToString(sqlreaderWO.Item("TanggalUpdate"))
                dg.Rows.Add(strField)
            Loop
            sqlreaderWO.Close()
            'mysqlcommand.Connection.Dispose()
            RadDropDownList1.SelectedIndex = 0
            'Else
            'RadMessageBox.Show("Belum ada Data WorkOrder " & _
            '"pada Database!", "Informasi", MessageBoxButtons.OK, RadMessageIcon.Info)
            'End If
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            sqlreaderWO = Nothing
            mysqlcommand = Nothing
            RadMessageBox.Show("Error, Failed GetLoadWorkorder:" & ex.Source & vbNewLine &
                               "Cek &Details Untuk Info Lengkap Error", "db LoadWorkorder", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message)
            ProjectData.ClearProjectError()
        Finally
            sqlreaderWO = Nothing
            mysqlcommand = Nothing
        End Try
    End Sub

    Private Sub ParseDataColumn()

        Dim StrColName As String() = New String(6) {}

        Dim num1 As Integer
        Dim num2 As Integer = StrColName.Length
        Dim num3 As Integer = num1

        StrColName(0) = "Nama Customer"
        StrColName(1) = "WorkOrder No."
        StrColName(2) = "Tanggal Workorder"
        StrColName(3) = "User Perekam"
        StrColName(4) = "Tanggal Rekam"
        StrColName(5) = "User Update"
        StrColName(6) = "Tanggal Update"

        While Not (num3 = num2)
            Dim NamaField As String = "xField" & Conversions.ToString(num3)
            Dim NamaHeader As String = StrColName(num3)
            With dg
                .Columns.Add(NamaField, NamaHeader)

            End With
            Interlocked.Increment(num3)
        End While
        Me.LoadWorkorder()
    End Sub

    Private Sub rFormListWorkOrder_Load(sender As Object, e As EventArgs) Handles Me.Load
        rFormMain.SetTheme(Me, rFormMain.Office2010BlackTheme1.ThemeName.ToString)
        rFormMain.LoadIcon(True, Me)

        'btnPDF.Visible = False

        ControlEkstensi.DoubleBuffered(dg, True)
        ParseDataColumn()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim tambahWO As New rFormAddWorkorderRecord
        tambahWO.Showdlg()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim EditWo As New rFormAddWorkorderRecord
        Dim strEdit As String = dg.CurrentRow.Cells(3).Value
        EditWo.Showdlg(True, ADD_QUOTE_ON_SQL(strEdit))
    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick
        dg.MultiSelect = False
        Me.dg.Rows(Me.dg.CurrentRow.Index).Selected = True
        Me.dg.CurrentRow.Cells(0).Value = RuntimeHelpers.GetObjectValue _
        (Interaction.IIf(Conversions.ToBoolean(Me.dg.CurrentRow.Cells(0).Value), _
        DirectCast(False, Object), DirectCast(True, Object)))
        BtnEditDeleteEnable()
    End Sub

    Private Sub btnErase_Click(sender As Object, e As EventArgs) Handles btnErase.Click
        Dim Num1 As Integer = 0
        Dim Num2 As Integer = dg.Rows.Count - 1
        Dim Index As Integer = Num1
        Dim StrCells As String = Conversions.ToString(Me.dg.CurrentRow.Cells("xfield0").Value)
        If RadMessageBox.Show("Anda yakin akan menghapus " & vbNewLine & StrCells & " dari database?", "HAPUS RECORD", MessageBoxButtons.YesNo, RadMessageIcon.Question) <> System.Windows.Forms.DialogResult.Yes Then
            Return
        End If
        Dim Num3 As Integer = 0
        Try
            Dim sqlcommand As New MySqlCommand()
            sqlcommand.Connection = mdlCom.vConn
            Dim Num4 As Integer = dg.Rows.Count - 1
            Dim Index2 As Integer = Num3
            While Index2 <= Num4
                If Conversions.ToBoolean(dg.Rows(Index2).Cells(0).Value) Then
                    Dim StrRow As String = Conversions.ToString(dg.Rows(Index2).Cells(3).Value)
                    sqlcommand.CommandText = "DELETE FROM `listworkorder` WHERE `wo_clientname` = '" & StrCells & "'"
                    Num3 += sqlcommand.ExecuteNonQuery()
                End If
                Interlocked.Increment(Index2)
            End While
            Dim Num5 As Integer = DirectCast(RadMessageBox.Show("(" & Num3.ToString & ")" & " Records " & vbNewLine & "berhasil di hapus dari database!", "UPDATE DATABASE", MessageBoxButtons.OK, RadMessageIcon.Info), Integer)
            Me.LoadWorkorder()
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim exception As Exception = ex
            RadMessageBox.Show("Failed (delete_Client data). Message : " + exception.Message)
            mdlCom.INSERTLOG("Failed (delete_Client data). Message : " + exception.Message, "")
            ProjectData.ClearProjectError()
        End Try
    End Sub
End Class