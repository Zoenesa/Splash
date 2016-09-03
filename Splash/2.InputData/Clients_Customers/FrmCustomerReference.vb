Imports Telerik, Telerik.WinControls
Imports System, System.Threading, System.Runtime, System.Runtime.InteropServices, System.Runtime.CompilerServices
Imports Microsoft, Microsoft.VisualBasic, Microsoft.VisualBasic.CompilerServices
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Imports Splash.Konektor

Public Class FrmCustomerReference
    Private isEdit As Boolean
    Private idUser As String
    Private idUserEdit As String
    Private ModeSelect As Boolean

    Public Function frmSelectClient(Optional ByVal SelectMode As Boolean = False) As DialogResult
        Dim dlgResult As System.Windows.Forms.DialogResult
        Try
            Me.ModeSelect = SelectMode
            Me.btnSave.Visible = False
            Me.btnSelect.Visible = SelectMode
            dlgResult = MyBase.ShowDialog()
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            mdlCom.ShowError("Failed to show form.")
            ProjectData.ClearProjectError()
        End Try
        Return dlgResult
    End Function

    Private Sub EditDeleteEnable()
        Dim Num1 As Integer = 0
        Try
            Dim num2 As Integer = 0
            Dim num3 As Integer = Me.dg.Rows.Count - 1
            Dim Index As Integer = num2
            While Index <= num3
                If Conversions.ToBoolean(Me.dg.Rows(Index).Cells(0).Value) Then
                    Interlocked.Increment(Num1)
                    Me.idUserEdit = Conversions.ToString(Me.dg.Rows(Index).Cells(1).Value)
                    If Num1 > 1 Then
                        Exit While
                    End If
                End If
                Interlocked.Increment(Index)
            End While
            Select Case Num1
                Case 0
                    btnEdit.Enabled = False
                    btnErase.Enabled = False
                    Me.idUserEdit = "-1"
                    Exit Select
                Case 1
                    btnEdit.Enabled = True
                    btnErase.Enabled = True
                    Exit Select
                Case Else
                    btnEdit.Enabled = False
                    btnErase.Enabled = True
                    Me.idUserEdit = "-1"
                    Exit Select
            End Select
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim EKsepsi As Exception = ex
            mdlCom.ShowError("Failed (edit or delete)." & EKsepsi.Source _
                               & " : " & EKsepsi.Message)
            mdlCom.INSERTLOG("Failed (edit or delete)." & EKsepsi.Source _
                               & " : " & EKsepsi.Message)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Public Sub LoadClientData(Optional ByVal Opsi As String = "")
        Dim sqldTReader As MySqlDataReader
        Dim sqlcommand As MySqlCommand = New MySqlCommand
        Try
            EditDeleteEnable()
            dg.Rows.Clear()
            mdlCom.BukaKoneksi()
            Dim command As String = "SELECT `ID_NUM`, `CLIENT_IDTAX`, `CLIENT_NAME`, `CLIENT_ADDRESS`, `CLIENT_STATE`," &
                            "`CLIENT_CITY`, `CLIENT_ZIPCODE`, `CLIENT_PHONE`, `CLIENT_MAIL`, `CLIENT_USERINPUT`," &
                            "`CLIENT_INPUTDATE`, `CLIENT_USEREDIT`, `CLIENT_UPDATE` FROM `ref_client`" &
                            Opsi & " ORDER BY `ID_NUM` ASC"

            sqlcommand.CommandText = command
            sqlcommand.Connection = mdlCom.vConn

            sqldTReader = sqlcommand.ExecuteReader

            Dim StrCol As String() = New String((14 + 1) - 1) {}
            Dim num As Integer = 0
            Do While sqldTReader.Read
                Dim strConcat As String

                Dim strST_Addr As String = Conversions.ToString(sqldTReader.Item("CLIENT_ADDRESS"))
                Dim strState As String = Conversions.ToString(sqldTReader.Item("CLIENT_STATE"))
                Dim strCity As String = Conversions.ToString(sqldTReader.Item("CLIENT_CITY"))
                Dim StrZipCode As String = Conversions.ToString(sqldTReader.Item("CLIENT_ZIPCODE"))
                Dim valueAlamat As String
                valueAlamat = String.Format("Jl. {0}; Kota/Kabupaten: {1}; Propinsi: {2};  {3} {4}", 0, 1, 2, 3, 4)
                strConcat = String.Concat(New String() {strST_Addr, " ", "City :", strCity, " ", "State : ", strState, " ", "Zipcode : ", StrZipCode})
                StrCol(0) = Conversions.ToString(False)
                StrCol(1) = Conversions.ToString(sqldTReader.Item("ID_NUM"))
                StrCol(2) = Conversions.ToString(mdlstring.FORMAT_NPWP(sqldTReader.Item("CLIENT_IDTAX")))
                StrCol(3) = Conversions.ToString(sqldTReader.Item("CLIENT_NAME"))
                StrCol(4) = Conversions.ToString(strConcat)
                'StrCol(4) = Conversions.ToString(sqldtReader.Item("CLIENT_ADDRESS"))
                StrCol(5) = Conversions.ToString(sqldTReader.Item("CLIENT_STATE"))
                StrCol(6) = Conversions.ToString(sqldTReader.Item("CLIENT_CITY"))
                StrCol(7) = Conversions.ToString(sqldTReader.Item("CLIENT_ZIPCODE"))
                StrCol(8) = Conversions.ToString(sqldTReader.Item("CLIENT_PHONE"))
                StrCol(9) = Conversions.ToString(sqldTReader.Item("CLIENT_MAIL"))
                StrCol(10) = Conversions.ToString(sqldTReader.Item("CLIENT_USERINPUT"))
                StrCol(11) = Conversions.ToString(sqldTReader.Item("CLIENT_INPUTDATE"))
                StrCol(12) = Conversions.ToString(sqldTReader.Item("CLIENT_USEREDIT"))
                StrCol(13) = Conversions.ToString(sqldTReader.Item("CLIENT_UPDATE"))
                Me.dg.Rows.Add(StrCol)
            Loop
            If num > 0 Then Me.dg.Rows.Item(0).Selected = True
            GetDataRowCount()
            sqldTReader.Close()
            sqldTReader.Dispose()
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            RadMessageBox.Show("failed_getClientList : " & ex.Source & vbNewLine &
                               "See More on Details", "Get List Invoice", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub ParseLoadData(Optional ByVal Opsi As String = "")
        Dim sqlReader As MySqlDataReader
        Dim sqlCommand As MySqlCommand = New MySqlCommand

        Try
            EditDeleteEnable()
            dg.Rows.Clear()
            Dim readerException As Exception = Nothing
            Dim strCommand As String = "SELECT * FROM `ref_Client` " & Opsi

            sqlCommand.CommandText = strCommand
            sqlCommand.Connection = mdlCom.vConn
            sqlReader = sqlCommand.ExecuteReader

            If sqlReader.HasRows Then
                Dim FieldItem As String() = New String() {}
                Do While sqlReader.Read

                Loop
            Else
                RadMessageBox.Show("Data Customer tidak ditemukan", "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If
        Catch ex As Exception
            sqlReader = Nothing

        End Try
    End Sub

    Private Sub ParseSelectData(Optional ByVal Opsi As String = "")

    End Sub

    Private Sub ParseAlamat()

    End Sub

    Private Sub FrmClientsRefrence_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyData
            Case 113
                Call btnFilter_Click(btnFilter, e)
        End Select
    End Sub

    Private Sub FrmClientsRefrence_Load(sender As Object, e As EventArgs) Handles Me.Load
        rFormMain.SetTheme(Me, rFormMain.Office2010BlackTheme1.ThemeName.ToString)
        rFormMain.LoadIcon(True, Me)
        If RadMessageBox.Show("~ REF_CLIENT FIELD ID_NUM SET VALUES ROW BASED ON DATAGRIDVIEW ROWS COUNT" & vbNewLine &
                           vbNewLine & "~ REMOVING FIELD ID_NUM" & vbNewLine &
                           vbNewLine & "~ SET INDEX PRIMARYKEY AS CLIENT_IDTAX", "NEXT DEVELOPMENT", MessageBoxButtons.OK, RadMessageIcon.Exclamation) <> System.Windows.Forms.DialogResult.Yes Then
            Me.ShowIcon = True
            'Me.Icon = New Icon(My.Application.Info.DirectoryPath & "\Image\Icons\Customer.ico")
            Inisialisasi()
            LoadClientData()

        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim frmAddClient As New rFormTambahCustomer
        Dim Num As Integer = DirectCast(frmAddClient.ShowDialog(), Integer)
        frmAddClient.Dispose()
    End Sub

    Private Sub Inisialisasi()
        Dim StrThemeName As String = rFormMain.Office2010BlackTheme1.ThemeName
        rFormMain.SetTheme(Me, StrThemeName)
        RadMessageBox.Instance.AllowTheming = True
        RadMessageBox.Instance.ControlBox = False
        GetDataRowCount()
    End Sub

    Private Sub GetDataRowCount()
        Dim StrInt As Integer, StrTotalRec As String
        StrInt = dg.Rows.Count
        Try
            If dg.Rows.Count < 0 Then
                StripLabelTotalRec.Text = "Total Records :"
                Exit Sub
            Else
                StrTotalRec = "Total Records " & String.Format("{0}", Conversions.ToString(StrInt))
                StripLabelTotalRec.Text = StrTotalRec
            End If
        Catch ex As Exception
            'StrTotalRec = ex.Message
        End Try
    End Sub

    Private Sub BindingNavigatorMovePreviousItem_Click(sender As Object, e As EventArgs)
        For i As Integer = 0 To dg.Rows.Count - 1
            dg.Rows.GetPreviousRow(i, DataGridViewElementStates.Visible)
        Next
    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs)
        For i As Integer = 0 To dg.Rows.Count - 1
            dg.Rows.GetNextRow(i, DataGridViewElementStates.Visible)
            'dg.Rows.GetNextRow(dg.CurrentRow.Cells(i), DataGridViewElementStates.Visible)
        Next
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim frmEditClient As New rFormTambahCustomer
        Dim num As Integer = DirectCast(frmEditClient.OpenDialog(True, Me.idUserEdit), Integer)
        frmEditClient.Dispose()
    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick

    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Dim Opsi As String = ""
        Dim strIdTax As String = "`CLIENT_IDTAX` LIKE '%" & Replace(Replace(Replace(txFilter.Text, ".", "", 1, -1, CompareMethod.Binary), "-", "", 1, -1, CompareMethod.Binary), "_", "", 1, -1, CompareMethod.Binary) & "%'"
        Dim strClientName As String = "`CLIENT_NAME` LIKE '%" & txFilter.Text & "%'"
        Dim strAddress As String = "`CLIENT_ADDRESS` LIKE '%" & txFilter.Text & "%'"
        If rDropInvoiceType.SelectedIndex = 0 Then
            Opsi = " WHERE " & strIdTax
        ElseIf rDropInvoiceType.SelectedIndex = 1 Then
            Opsi = " WHERE " & strClientName
        ElseIf rDropInvoiceType.SelectedIndex = 2 Then
            Opsi = " WHERE " & strAddress
        ElseIf rDropInvoiceType.SelectedIndex < 0 Then
            Opsi = " WHERE " & strClientName
        End If
        Me.LoadClientData(Opsi)
    End Sub

    Private Sub btnErase_Click(sender As Object, e As EventArgs) Handles btnErase.Click
        Dim Num1 As Integer = 0
        Dim Num2 As Integer = dg.Rows.Count - 1
        Dim Index As Integer = Num1
        Dim StrCells As String = Conversions.ToString(Me.dg.CurrentRow.Cells("Coll4").Value)
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
                    sqlcommand.CommandText = "DELETE FROM REF_CLIENT WHERE CLIENT_NAME = '" & StrCells & "'"
                    Num3 += sqlcommand.ExecuteNonQuery()
                End If
                Interlocked.Increment(Index2)
            End While
            Dim Num5 As Integer = DirectCast(RadMessageBox.Show("(" & Num3.ToString & ")" & " Records " & vbNewLine & "berhasil di hapus dari database!", "UPDATE DATABASE", MessageBoxButtons.OK, RadMessageIcon.Info), Integer)
            Me.LoadClientData()
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim exception As Exception = ex
            RadMessageBox.Show("Failed (delete_Client data). Message : " + exception.Message)
            mdlCom.INSERTLOG("Failed (delete_Client data). Message : " + exception.Message, "")
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub rDropInvoiceType_SelectedIndexChanging(sender As Object, e As UI.Data.PositionChangingCancelEventArgs) Handles rDropInvoiceType.SelectedIndexChanging
        If e.Position = 0 Then
            txFilter.Mask = "00.000.000.0-000.000"
            txFilter.Text = "__.___.___._-___.___"
            txFilter.NullText = "_"
            txFilter.MaskType = UI.MaskType.Standard
        ElseIf e.Position = 1 Then
            txFilter.Mask = ""
            txFilter.NullText = "Filter with Client Name"
            txFilter.MaskType = UI.MaskType.None
        ElseIf e.Position = 2 Then
            txFilter.Mask = ""
            txFilter.NullText = "Filter with Client Address"
            txFilter.MaskType = UI.MaskType.None
        Else
            txFilter.Mask = ""
            txFilter.NullText = "Filter with Client Name"
            txFilter.MaskType = UI.MaskType.None
        End If
    End Sub

    Public StrtaxID As String
    Public strClientName As String
    Public strClientAddr As String

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click

        StrtaxID = Me.dg.CurrentRow.Cells(2).Value
        strClientName = Me.dg.CurrentRow.Cells(3).Value
        strClientAddr = Me.dg.CurrentRow.Cells(4).Value

        rFormInvoice.rTxMaskID.Text = StrtaxID
        rFormInvoice.txClientName.Text = strClientName
        rFormInvoice.txClientAddr.Text = strClientAddr

        Me.Dispose()
    End Sub

    Public Sub ChooseClient(ByRef ClientIDTax As String, ByRef ClientName As String, ByRef ClientAddr As String)
        Try
            If Me.dg.CurrentRow.Cells(0).Value = True Then
                ClientIDTax = Me.dg.CurrentRow.Cells(2).Value
                ClientName = Me.dg.CurrentRow.Cells(3).Value
                ClientAddr = Me.dg.CurrentRow.Cells(4).Value
                StrtaxID = mdlstring.FORMAT_NPWP(ClientIDTax)
                strClientName = Conversions.ToString(ClientName)
                strClientAddr = ClientAddr
            End If
            'ChooseClient(StrtaxID, strClientName, strClientAddr)
        Catch ex As Exception
            RadMessageBox.Show("Error." & ex.Source, "Choose Client", MessageBoxButtons.OK, RadMessageIcon.Exclamation, ex.Message)
        End Try
    End Sub


    Private Sub dg_Click(sender As Object, e As EventArgs) Handles dg.Click
        dg.MultiSelect = False
        dg.Rows(Me.dg.CurrentRow.Index).Selected = True
        Me.dg.CurrentRow.Cells(0).Value = RuntimeHelpers.GetObjectValue _
            (Interaction.IIf(Conversions.ToBoolean(Me.dg.CurrentRow.Cells(0).Value),
                            DirectCast(False, Object), DirectCast(True, Object)))
        Me.EditDeleteEnable()
    End Sub


End Class
