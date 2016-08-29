Imports System, System.Threading
Imports MySql.Data.MySqlClient
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic, Microsoft.VisualBasic.CompilerServices
Imports Telerik.WinControls
Imports Splash.mdlstring


Public Class rFormAddWorkorderRecord

    Private idUser As String
    Private EditMode As Boolean
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Telerik.WinControls.RadMessageBox.Instance.AllowTheming = True
        Telerik.WinControls.RadMessageBox.Instance.ControlBox = False
        Telerik.WinControls.RadMessageBox.ShowInTaskbar = False
        Telerik.WinControls.RadMessageBox.ThemeName = rFormMain.Office2010BlackTheme1.ThemeName
        Dim strTheme As String = rFormMain.Office2010BlackTheme1.ThemeName
        rFormMain.SetTheme(Me, strTheme)
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Function Showdlg(Optional ByVal isedit As Boolean = False, Optional ByVal UserEdit As String = "-1") As System.Windows.Forms.DialogResult
        Dim Result As System.Windows.Forms.DialogResult
        Try
            Me.EditMode = isedit
            Me.idUser = UserEdit
            Result = MyBase.ShowDialog
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim Excep As Exception = ex
            mdlCom.ShowError("Failed to show form.")
            ProjectData.ClearProjectError()
        End Try
        Return Result
    End Function

    Private Sub rFormAddWorkorderRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rFormMain.SetTheme(Me, rFormMain.Office2010BlackTheme1.ThemeName.ToString)
        rFormMain.LoadIcon(True, Me)

        If Me.EditMode Then
            Me.Text = "Ubah Record"
            Dim cmn As New common
            Dim dt As New DataTable
            Dim errMsg As String = Nothing
            If cmn.getListWO(errMsg, dt, ("WHERE `WO_NO`='" & Me.idUser & "'")) Then
                Dim row As DataRow = dt.Rows.Item(0)
                Me.rTxID.Text = Conversions.ToString(row.Item("ID"))
                Me.rCbClient.Text = Conversions.ToString(row.Item("WO_CLIENTNAME"))
                Me.rWONum.Text = Conversions.ToString(row.Item("WO_NO"))
                Me.rTxMaskDate.Text = Conversions.ToString(row.Item("WO_DATE"))
            Else
                mdlCom.ShowError(errMsg)
            End If
        Else
            Dim norekam As Integer
            norekam = rFormListWorkOrder.dg.Rows.Count + 1
            rTxID.Text = norekam
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Me.cekValue Then
            Me.SavetoDB()
        End If
    End Sub

    Private Function cekValue() As Boolean
        Dim cmn As New common
        If rCbClient.Text = "" Then
            RadMessageBox.Show("Client Belum dipilih!", "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            rCbClient.Focus()
            rCbClient.ShowDropDown()
            Return False
        ElseIf rWONum.Text.Trim() = "" Then
            RadMessageBox.Show("Kolom Nomor Workorder belum isi!", "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            rWONum.Focus()
            rWONum.SelectAll()
            Return False
        ElseIf Not cmn.ValidasiTanggal(rTxMaskDate.Text) Then
            RadMessageBox.Show("Format tanggal salah!" & vbNewLine & _
                               "input tanggal dengan format" & Chr(34) & "DD/MM/YYYY" & Chr(34), "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            rWONum.Focus()
            rWONum.SelectAll()
            Return False
        End If
        Return True
    End Function

    Private Sub SavetoDB()
        Try
            If Me.EditMode Then
                If Conversions.ToBoolean(Me.SaveWorkorder(rTxID.Text.Trim, rCbClient.Text.Trim, rWONum.Text.Trim, rTxMaskDate.Text.Trim)) Then
                    rFormListWorkOrder.LoadWorkorder()
                    rFormListWorkOrder.Refresh()
                    RadMessageBox.Show("Record berhasil disimpan!.", "Edit Workorder", MessageBoxButtons.OK, RadMessageIcon.Info)
                    Me.Close()
                Else
                    RadMessageBox.Show("Tidak ada data yang disimpan.", "Workorder", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
                End If
                Exit Sub
            End If
            If Conversions.ToBoolean(Me.SaveWorkorder(rTxID.Text.Trim, rCbClient.Text.Trim, rWONum.Text.Trim, rTxMaskDate.Text.Trim)) Then
                rFormListWorkOrder.LoadWorkorder()
                rFormListWorkOrder.Refresh()
                Beep()
                Dim resul As DialogResult = RadMessageBox.Show("Record berhasil disimpan!." & vbNewLine & "Apakah Anda ingin membuat workorder baru?", "Tambah Workorder", MessageBoxButtons.YesNo, RadMessageIcon.Question)
                If resul = Windows.Forms.DialogResult.Yes Then
                    Dim norekam As Integer
                    norekam = rFormListWorkOrder.dg.Rows.Count + 1
                    rTxID.Text = norekam
                    Me.rTxMaskDate.Text = String.Empty
                    Me.rWONum.Text = ""
                    rCbClient.Text = ""
                    Return
                Else
                    rFormListWorkOrder.LoadWorkorder()
                    Me.Close()
                End If
            Else
                RadMessageBox.Show("Tidak ada data yang disimpan.", "Workorder", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            End If
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim excep As Exception = ex
            mdlCom.ShowError("Save Failed.Message:" & excep.Message)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Public Function SaveWorkorder(ByVal ID As String, _
                                   ByVal Client As String, _
                                   ByVal Nomor As String, _
                                   ByVal Tanggal As String _
                                   ) As Boolean
        Dim obj As Boolean

        Try
            Dim strCommand As String

            Dim sqlCmd As New MySqlCommand With {.Connection = mdlCom.vConn}

            If EditMode Then
                strCommand = String.Concat(New String() {"UPDATE `listworkorder` SET `WO_NO` = '", ADD_QUOTE_ON_SQL(rWONum.Text.Trim()), "', `WO_CLIENTNAME` = '", Client, "', `WO_DATE` = '", Tanggal, "', `UserUpdated` = '", mdlCom.UserLogin, "', `RecordUpdated` = '" & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), "' WHERE `ID` = '", ADD_QUOTE_ON_SQL(ID), "'"})
            Else
                strCommand = String.Concat(New String() {"INSERT INTO `listworkorder` (`ID`, `WO_CLIENTNAME`, `WO_NO`, `WO_DATE`, `UserRecorder`, `DateRecorded`, `UserUpdated`, `RecordUpdated`) " &
                            "VALUES ('", ADD_QUOTE_ON_SQL(ID), "', '",
                            ADD_QUOTE_ON_SQL(Client), "', '",
                            ADD_QUOTE_ON_SQL(Nomor), "', '",
                            ADD_QUOTE_ON_SQL(Tanggal), "', '",
                            ADD_QUOTE_ON_SQL(mdlCom.UserLogin), "', '",
                            ADD_QUOTE_ON_SQL(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")), "', '",
                            ADD_QUOTE_ON_SQL(mdlCom.UserLogin), "', '", ADD_QUOTE_ON_SQL(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")), "');"})
            End If
            sqlCmd.CommandText = strCommand
            If (sqlCmd.ExecuteNonQuery > 0) Then
                Return True
            End If
            obj = False
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim excep As Exception = ex
            mdlCom.ShowError("Save Failed.Message:" & excep.Message)
            obj = False
            ProjectData.ClearProjectError()
            Return obj
            ProjectData.ClearProjectError()
        End Try
        Return obj
    End Function

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Me.Close()
        rFormListWorkOrder.LoadWorkorder()
    End Sub
End Class