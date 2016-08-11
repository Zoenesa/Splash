Imports Telerik, Telerik.WinControls
Imports System, System.Threading, System.Runtime, System.Runtime.InteropServices, System.Runtime.CompilerServices
Imports Microsoft, Microsoft.VisualBasic, Microsoft.VisualBasic.CompilerServices
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Imports Splash.mdlstring


Public Class rFormInvoice

    Public Sub New()

        InitializeComponent()

        Telerik.WinControls.RadMessageBox.Instance.AllowTheming = True
        Telerik.WinControls.RadMessageBox.Instance.ControlBox = False
        Telerik.WinControls.RadMessageBox.ShowInTaskbar = False
        Telerik.WinControls.RadMessageBox.ThemeName = rFormMain.Office2010BlackTheme1.ThemeName

        rFormMain.SetTheme(Me, rFormMain.Office2010BlackTheme1.ThemeName.ToString)

    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub frmInvoice_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyData
            Case 133
                Call btnFind_Click(btnFind, e)
        End Select
    End Sub

    Private Sub frmInvoice_Load(sender As Object, e As EventArgs) Handles Me.Load
        RadMessageBox.Instance.AllowTheming = True
        Dim strTheme As String = ""
        strTheme = rFormMain.Office2010BlackTheme1.ThemeName
        RadMessageBox.Instance.ThemeName = strTheme
        rFormMain.SetTheme(Me, strTheme)
        ' Me.Size = New Size(662, 577)

        btnNext.Parent = RadPageView1.Pages.Item(0)
        btnBack.Parent = RadPageView1.Pages.Item(0)

        rTxMaskDate.Mask = "00/00/0000"
        rTxMaskDate.CausesValidation = True

        'LoadWorkOrder()

        With RadPageView1
            .SelectedPage = RadPageViewPage1
            .Pages(1).Enabled = False
            .Pages(2).Enabled = False
            .Pages(3).Enabled = False
        End With

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs)
        'frmInputItemReference.ShowDialog()
    End Sub

    Private Function CheckValPage1() As Boolean
        If (Not RadRadioButton1.IsChecked AndAlso Not RadRadioButton2.IsChecked) Then
            RadMessageBox.Show("Kolom Nama Invoice Kosong", "Invoice Detail", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            RadRadioButton1.Focus()
            Return False
        End If
        If (rDropInvoiceType.SelectedItem.Text.ToString.Trim = "") Then
            RadMessageBox.Show("Pilih salah satu pada kolom Invoice Type", "Invoice Detail", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            'rDropInvoiceType.Focus()
            Return False
        End If
        If (txInvoiceNum.Text.ToString.Trim = "") Then
            RadMessageBox.Show("Kolom Nomor Invoice Kosong", "Invoice Detail", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            txInvoiceNum.Focus()
            Return False
        End If
        If rTxMaskDate.Text = "__/__/____" Then
            RadMessageBox.Show("Kolom Tanggal Kosong", "Invoice Detail", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            rTxMaskDate.Focus()
            Return False
        End If
        If (rTxProgress.Text.ToString.Trim = "") Then
            RadMessageBox.Show("Kolom Progress Kosong", "Invoice Detail", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            rTxProgress.Focus()
            Return False
        End If
        If (rTxTermyn.Text.ToString.Trim = "") Then
            RadMessageBox.Show("Kolom Termyn Kosong", "Invoice Detail", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            rTxTermyn.Focus()
            Return False
        End If
        RadPageView1.Pages(1).Enabled = True
        Return True
    End Function

    Private Function CheckValPage2() As Boolean
        If rTxMaskID.Text.ToString.Trim = "" Then
            RadMessageBox.Show("Kolom Client NPWP Kosong", "Invoice Client Detail", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Return False
        End If
        If txClientName.Text.ToString.Trim = "" Then
            RadMessageBox.Show("Kolom Nama Client Kosong", "Invoice Client Detail", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Return False
        End If
        If txClientAddr.Text.ToString.Trim = "" Then
            RadMessageBox.Show("Kolom Alamat Client Kosong", "Invoice Client Detail", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Return False
        End If
        RadPageView1.Pages(2).Enabled = True

        Return True
    End Function

    Private Function CheckValPage3() As Boolean
        If txWo.Text.Trim = "" Then
            RadMessageBox.Show("Kolom Workorder Kosong", "Invoice Client WorkOrder", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Return False
        End If
        If dgWo.Rows.Count < 0 Then
            RadMessageBox.Show("Anda Belum input Workorder/Spk/Sales Order", "Invoice Client WorkOrder", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Return False
        End If
        RadPageView1.Pages(3).Enabled = True
        LoadWorkOrder()
        RadLabel16.Text = ""
        RadLabel16.Text = "Nominal Termyn" & " (" & rTxTermyn.Text.Trim() & ")"
        Return True
    End Function
    Private Sub rDropInvoiceType_Click(sender As Object, e As EventArgs) Handles rDropInvoiceType.Click
        rDropInvoiceType.ShowDropDown()
    End Sub

    Private Sub rDropInvoiceType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rDropInvoiceType.KeyPress
        If e.KeyChar = Chr(Keys.Return) Then
            'txInvoiceNum.Focus()
            txBAST.Focus()
            txBAST.SelectAll()
        End If
    End Sub

    Private Sub txInvoiceNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txInvoiceNum.KeyPress
        If e.KeyChar = Chr(Keys.Return) Then

        End If
    End Sub

    Private Sub rTxMask_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rTxMaskDate.KeyPress
        If e.KeyChar = Chr(Keys.Return) Then
            rDropInvoiceType.ShowDropDown()
            rDropInvoiceType.Focus()
        End If
    End Sub

    Private Sub rTxProgress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rTxProgress.KeyPress, txBAST.KeyPress
        Select Case e.KeyChar
            Case Chr(13)
                rTxTermyn.Focus()
        End Select
        If e.KeyChar = Chr(Keys.Return) Then
            rTxTermyn.Focus()
        End If
    End Sub

    Private Sub rTxTermyn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rTxTermyn.KeyPress
        Select Case e.KeyChar
            Case Chr(13)
                If e.KeyChar = Chr(Keys.Return) AndAlso CheckValPage1() = True Then
                    btnNext.Enabled = True
                End If
                btnNext.Focus()
        End Select
    End Sub

    Private Sub LoadWorkOrder(Optional ByVal Opsi As String = "")
        Try
            dgWo.Rows.Clear()
            mdlCom.BukaKoneksi()
            Dim command As String = "SELECT `WO_INVOICE`, `WO_NO`, `WO_DATE` FROM `temp_workorder` " & Opsi & " ORDER BY `ID`;"

            Dim reader As MySqlDataReader = New MySqlCommand((command), mdlCom.vConn).ExecuteReader
            Dim sqlCmd As New MySqlCommand
            sqlCmd.CommandText = command
            sqlCmd.Connection = mdlCom.vConn

            reader.Read()
            Dim fieldNames As String() = New String(2) {}
            Do While reader.Read
                fieldNames(0) = Conversions.ToString(reader.Item("WO_INVOICE"))
                fieldNames(1) = Conversions.ToString(reader.Item("WO_NO"))
                fieldNames(2) = Conversions.ToString(reader.Item("WO_DATE"))
                dgWo.Rows.Add(fieldNames)
            Loop
        Catch ex As Exception
            RadMessageBox.Show("Error" & "Load WorkOrderdata. " & ex.Source, "Invoice WorkOrder", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message)
        End Try
    End Sub
    Private Sub rTxTermyn_Leave(sender As Object, e As EventArgs) Handles rTxTermyn.Leave
        If Me.CheckValPage1() Then
            btnNext.Enabled = True
            btnNext.Focus()
        End If
    End Sub

    Private Sub RadPageView1_SelectedPageChanged(sender As Object, e As EventArgs) Handles RadPageView1.SelectedPageChanged
        If RadPageView1.SelectedPage Is RadPageViewPage1 Then
            btnNext.Parent = RadPageView1.SelectedPage
            btnBack.Parent = RadPageView1.SelectedPage
        ElseIf RadPageView1.SelectedPage Is RadPageViewPage2 Then
            btnNext.Parent = RadPageView1.SelectedPage
            btnBack.Parent = RadPageView1.SelectedPage
        ElseIf RadPageView1.SelectedPage Is RadPageViewPage3 Then
            btnNext.Parent = RadPageView1.SelectedPage
            btnBack.Parent = RadPageView1.SelectedPage
        End If
    End Sub

    Private Sub RadPageView1_SelectedPageChanging(sender As Object, e As UI.RadPageViewCancelEventArgs) Handles RadPageView1.SelectedPageChanging
        e.Cancel = Not e.Page.Enabled
        If e.Page Is RadPageViewPage1 Then
            btnNext.Parent = RadPageView1.SelectedPage
            btnBack.Parent = RadPageView1.SelectedPage
        ElseIf e.Page Is RadPageViewPage2 Then
            btnNext.Parent = RadPageView1.SelectedPage
            btnBack.Parent = RadPageView1.SelectedPage
        ElseIf e.Page Is RadPageViewPage3 Then
            btnNext.Parent = RadPageView1.SelectedPage
            btnBack.Parent = RadPageView1.SelectedPage
        ElseIf e.Page Is RadPageViewPage4 Then
            btnNext.Parent = RadPageView1.SelectedPage
            btnBack.Parent = RadPageView1.SelectedPage
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If (RadPageView1.SelectedPage Is RadPageViewPage1) AndAlso Me.CheckValPage1 Then
            RadPageView1.SelectedPage = RadPageViewPage2
            btnNext.Parent = RadPageView1.SelectedPage
            btnBack.Parent = RadPageView1.SelectedPage
        ElseIf (RadPageView1.SelectedPage Is RadPageViewPage2) AndAlso Me.CheckValPage2 Then
            RadPageView1.SelectedPage = RadPageViewPage3
            LoadWorkOrder("WHERE `WO_INVOICE` = '" & ADD_QUOTE_ON_SQL(txInvoiceNum.Text) & "'")
            btnNext.Parent = RadPageView1.SelectedPage
            btnBack.Parent = RadPageView1.SelectedPage
        ElseIf (RadPageView1.SelectedPage Is RadPageViewPage3) AndAlso Me.CheckValPage3 Then
            RadPageView1.SelectedPage = RadPageViewPage4
            btnNext.Parent = RadPageView1.SelectedPage
            btnBack.Parent = RadPageView1.SelectedPage
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click, btnBack.KeyPress
        If RadPageView1.SelectedPage Is RadPageViewPage4 Then
            RadPageView1.SelectedPage = RadPageViewPage3
            btnNext.Parent = RadPageView1.SelectedPage
            btnBack.Parent = RadPageView1.SelectedPage
        ElseIf RadPageView1.SelectedPage Is RadPageViewPage3 Then
            RadPageView1.SelectedPage = RadPageViewPage2
            btnNext.Parent = RadPageView1.SelectedPage
            btnBack.Parent = RadPageView1.SelectedPage
        ElseIf RadPageView1.SelectedPage Is RadPageViewPage2 Then
            RadPageView1.SelectedPage = RadPageViewPage1
            btnNext.Parent = RadPageView1.SelectedPage
            btnBack.Parent = RadPageView1.SelectedPage
        End If
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        FrmCustomerReference.btnSave.Visible = False
        FrmCustomerReference.btnSelect.Visible = True
        FrmCustomerReference.btnSelect.Location = New Point(12, 341)
        FrmCustomerReference.ShowDialog()
    End Sub

    Private Sub txClientAddr_Leave(sender As Object, e As EventArgs) Handles txClientAddr.Leave
        If Me.CheckValPage2 Then
            btnNext.Enabled = True
            btnNext.Focus()
        End If
    End Sub

    Private Sub InsertDataWO()
        Dim StrInsert As String = String.Concat(New String() {"INSERT INTO `temp_workorder` (`WO_INVOICE`, `WO_NO`, `WO_DATE`)" & _
                                                       " VALUES ('" & mdlstring.ADD_QUOTE_ON_SQL( _
                                                       txInvoiceNum.Text.Trim()) & _
                                                       "', '" & mdlstring.ADD_QUOTE_ON_SQL( _
                                                       txWo.Text.Trim()) & _
                                                       "', '" & mdlstring.ADD_QUOTE_ON_SQL( _
                                                       woDate.Text.Trim().ToString) & "')"})

        Dim command As New MySqlCommand With { _
            .Connection = mdlCom.vConn}
        command.CommandText = StrInsert
        command.ExecuteNonQuery()
    End Sub

    Private Sub InsertDataInvoice()
        Dim intNum As Integer = rFormDataListInvoice.dg.Rows.Count
        Dim valType As String = If(RadRadioButton1.IsChecked, "Pengadaan", "Jasa")
        Dim woVal As String = dgWo.Rows(1).Cells("Col2").Value
        Dim itmCount As String = dgItem.Rows.Count
        Dim cmdDataInvoice As String =
            String.Concat(New String() _
                        {"INSERT INTO `invoicedata` (`RecordNo`, `InvoiceNo`, " &
                        "`InvoiceDate`, `InvoiceType`, `InvoiceClient`, `InvoiceClientAddress`, " &
                        "`InvoiceWorkOrderSPK`, `InvoiceLisence`, `InvoiceProgress`, " &
                        "`InvoiceTerm`, `InvoiceItemRecords`, `InvoiceTotalItems`, " &
                        "`InvoicePaymentsRecord`, `InvoiceAfterTermyn`, `InvoiceTaxPrice`, " &
                        "`InvoiceTerbilang`, `IndexProject`, `UserInput`, `CreateDate`, " &
                        "`UserEdit`, `DateUpdate`) VALUES ('" & intNum + 1 &
                        "', '" & txInvoiceNum.Text.Trim() & "', '" & rTxMaskDate.Text.ToString &
                        "', '" & valType & "', '" & txClientName.Text.Trim() &
                        "', '" & txClientAddr.Text.Trim() & "','" & woVal &
                        "', '" & txBAST.Text.Trim() & "', '" & rTxProgress.Text.Trim() &
                        "', '" & rTxTermyn.Text.Trim() & "', '" & itmCount &
                        "', '" & "')"})
        Dim cmd As New MySqlCommand With {
            .Connection = mdlCom.vConn}
        cmd.CommandText = cmdDataInvoice
        cmd.ExecuteNonQuery()
    End Sub


    Private Sub InsertDataInvoiceItem()
        Dim SqlAdapter As New MySqlDataAdapter("SELECT * FROM `items_invoice`", mdlCom.vConn)
        Dim dt As New DataTable()
        dt.BeginLoadData()
        SqlAdapter.Fill(dt)
        dt.EndLoadData()
        Dim rwCount As Integer = dt.Rows.Count
        Dim cmdDataItems As String = String.Format("INSERT INTO ITEMS_INVOICE (RecordId, InvoiceNo, Items, Quantity, Price, TotalPrice)" &
                                                   " VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", rwCount + 1, "", "")
        Dim cmd As New MySqlCommand With {.Connection = mdlCom.vConn}
        cmd.CommandText = cmdDataItems
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Dim StrInsert As String = String.Concat(New String() {"INSERT INTO TEMP_WORKORDER (WO_INVOICE, WO_NO, WO_DATE)" & _
                                                " VALUES ('" & mdlstring.ADD_QUOTE_ON_SQL( _
                                                txInvoiceNum.Text.Trim()) & _
                                                "', '" & mdlstring.ADD_QUOTE_ON_SQL( _
                                                txWo.Text.Trim()) & _
                                                "', '" & mdlstring.ADD_QUOTE_ON_SQL( _
                                                woDate.Text.Trim().ToString) & "')"})

        Dim command As New MySqlCommand With { _
            .Connection = mdlCom.vConn}
        command.CommandText = StrInsert
        command.ExecuteNonQuery()
        LoadWorkOrder()

    End Sub

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click
        'FrmItemReferences.ShowDialog()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub

    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        On Error GoTo errhandle
        'Return
        If dgItem.Rows.Count > 0 Then

            RadTextBox5.Text = FormatNumber(mdlstring.CountSumTotalPrice(dgItem, "ItemCol4"), 2)
            RadTextBox6.Text = FormatNumber((RadTextBox5.Text * Val(rTxTermyn.Text) / 100), 2)
            RadTextBox1.Text = FormatNumber((RadTextBox6.Text - RadTextBox7.Text), 2)
            RadTextBox3.Text = FormatNumber(mdlstring.MathRoundUp((RadTextBox1.Text * 0.1), 0), 2)
            Dim d1 As Double = RadTextBox1.Text
            Dim d2 As Double = RadTextBox3.Text
            RadTextBox4.Text = FormatNumber((d1 + d2), 2)
            Return
        Else
            Dim d As Double = 0.0
            RadTextBox5.Text = FormatNumber(d, 2)
            RadTextBox6.Text = RadTextBox5.Text * Val(rTxTermyn.Text)
            RadTextBox1.Text = FormatNumber((RadTextBox6.Text - RadTextBox7.Text), 2)
            RadTextBox3.Text = FormatNumber(mdlstring.MathRoundUp((RadTextBox1.Text * 0.1), 0), 2)
            RadTextBox5.Text = FormatNumber(Val(RadTextBox1.Text + RadTextBox4.Text), 2)
            Return
        End If

errhandle:
        RadMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        Return
    End Sub

    Private Sub RadTextBox7_Leave(sender As Object, e As EventArgs) Handles RadTextBox7.Leave
        Dim d As Double = RadTextBox7.Text
        RadTextBox7.Text = FormatNumber(d, 2)

    End Sub

    Private Sub rTxMaskDate_Leave(sender As Object, e As EventArgs) Handles rTxMaskDate.Leave
        Dim numbers() As String = {"I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X", "XI", "XII"}
        Dim Number As Integer = 0

        Dim strDate As String = rTxMaskDate.Text

        Dim parsebulan As String() = Strings.Split(rTxMaskDate.Text, "/", -1, CompareMethod.Binary)

        Integer.TryParse(parsebulan(1), Number)

        Dim bulan As String

        If Number >= 1 And Number <= 12 Then
            bulan = numbers(Number - 1)
            Dim strAutoInvoiceTemp As String = CStr(rFormDataListInvoice.LastInvoiceCount)
            Dim AutoIncrementInvoiceNo As String = ""
            AutoIncrementInvoiceNo = Val(strAutoInvoiceTemp + 1)
            txInvoiceNum.Text = String.Concat(New String() {(Format(Conversions.ToLong(AutoIncrementInvoiceNo), "0000")),
                                                            "/", "SIP", ".", If(RadRadioButton1.IsChecked, "INV", "INV-J"), "/", bulan, "/", parsebulan(2)})
        Else
            RadMessageBox.Show("Format Tanggal = ?", "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Return
        End If
    End Sub

    Private Sub rTxMaskDate_Validating(sender As Object, e As ComponentModel.CancelEventArgs) Handles rTxMaskDate.Validating

    End Sub

    Private Sub btnCariBAST_Click(sender As Object, e As EventArgs) Handles btnCariBAST.Click

    End Sub
End Class