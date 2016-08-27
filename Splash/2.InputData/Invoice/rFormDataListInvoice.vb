Imports System, System.Threading
Imports MySql.Data.MySqlClient
Imports System.Data, System.Data.OleDb
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic, Microsoft.VisualBasic.CompilerServices
Imports Telerik.WinControls

Public Class rFormDataListInvoice
    Private isEdit As Boolean
    Private idUser As String
    Private idUserEdit As String
    Private IntCol As Integer
    Public Shared LastInvoiceCount As Integer

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
                    Me.idUserEdit = Conversions.ToString(Me.dg.Rows(index).Cells(2).Value)
                    If num1 > 1 Then
                        Exit While
                    End If
                End If
                System.Threading.Interlocked.Increment(index)
            End While
            Select Case num1
                Case 0
                    Me.btnEdit.Enabled = False
                    Me.btnPDF.Enabled = False
                    Me.btnErase.Enabled = False
                    Me.idUserEdit = "-1"
                    Exit Select
                Case 1
                    Me.btnEdit.Enabled = True
                    Me.btnPDF.Enabled = True
                    Me.btnErase.Enabled = True
                    Exit Select
                Case Else
                    Me.btnEdit.Enabled = False
                    Me.btnPDF.Enabled = False
                    Me.btnErase.Enabled = True
                    Me.idUserEdit = "-1"
                    Exit Select
            End Select
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim exception As Exception = ex
            mdlcom.ShowError("Failed (edit_delete). Message : " + exception.Message)
            mdlCom.INSERTLOG("Failed (edit_delete). Message : " + exception.Message, "")
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub LoadListInvoice(Optional ByVal opsi As String = "")
        Dim sqlreader As MySqlDataReader

        Try
            dg.Rows.Clear()
            BtnEditDeleteEnable()
            If mdlCom.vConn.State = ConnectionState.Closed Then
                mdlCom.BukaKoneksi()
            End If
            Dim command As MySqlCommand = New MySqlCommand(("SELECT `RecordNo`, `InvoiceNo`, `InvoiceDate`, `InvoiceType`, `InvoiceClient`" & _
                                                                 ", `InvoiceWorkOrderSPK`, `InvoiceLisence`, `InvoiceProgress`, `InvoiceTerm`, `InvoiceItemsRecords`" & _
                                                                 ", `InvoiceTotalItems`, `InvoicePaymentsRecord`, `InvoiceAfterTermyn`, `InvoiceTaxPrice`, `InvoiceTerbilang`" & _
                                                                 ", `IndexProject`, `UserPerekam`, `TanggalRekam`, `UserUpdate`, `TanggalUpdate` FROM `invoicedata`" & _
                                                                 opsi & " ORDER BY `RecordNo` ASC"), mdlCom.vConn)
            Dim values As String() = New String((20 + 1) - 1) {}
            sqlreader = command.ExecuteReader
            Do While sqlreader.Read
                values(0) = Conversions.ToString(False)
                values(1) = Conversions.ToString(sqlreader.Item("RecordNo"))
                values(2) = Conversions.ToString(sqlreader.Item("InvoiceNo"))
                values(3) = Format(sqlreader.Item("InvoiceDate"), "dd/MM/yyyy")
                values(4) = Conversions.ToString(sqlreader.Item("InvoiceType"))
                values(5) = Conversions.ToString(sqlreader.Item("InvoiceClient"))
                values(6) = Conversions.ToString(sqlreader.Item("InvoiceWorkOrderSPK"))
                values(7) = Conversions.ToString(sqlreader.Item("InvoiceLisence"))
                values(8) = FormatNumber(sqlreader.Item("InvoiceProgress"), 2)
                values(9) = FormatNumber(sqlreader.Item("InvoiceTerm"), 2)
                values(10) = Conversions.ToString(sqlreader.Item("InvoiceItemsRecords"))
                values(11) = FormatNumber(sqlreader.Item("InvoiceTotalItems"), 2, TriState.True, TriState.True, TriState.True)
                values(12) = FormatNumber(sqlreader.Item("InvoicePaymentsRecord"), 2, TriState.True, TriState.True, TriState.True)
                values(13) = FormatNumber(sqlreader.Item("InvoiceAfterTermyn"), 2, TriState.True, TriState.True, TriState.True)
                values(14) = FormatNumber(sqlreader.Item("InvoiceTaxPrice"), 2, TriState.True, TriState.True, TriState.True)
                values(15) = Conversions.ToString(sqlreader.Item("InvoiceTerbilang"))
                values(16) = Conversions.ToString(sqlreader.Item("IndexProject"))
                values(17) = Conversions.ToString(sqlreader.Item("UserPerekam"))
                values(18) = Conversions.ToString(sqlreader.Item("TanggalRekam"))
                values(19) = Conversions.ToString(sqlreader.Item("UserUpdate"))
                values(20) = Conversions.ToString(sqlreader.Item("TanggalUpdate"))
                dg.Rows.Add(values)
            Loop

            sqlreader.Close()

            Label1.Text = String.Format("Total Record : {0}", dg.Rows.Count)
            RadDropDownList1.SelectedIndex = 0

            If dg.Rows.Count > 0 Then
                Dim stringInvoice As String() = Strings.Split(dg.Rows(dg.Rows.Count - 1).Cells(2).Value, "/", -1, CompareMethod.Binary)
                LastInvoiceCount = CInt(Strings.Left(stringInvoice(0), stringInvoice(0).Length))
            End If

        Catch ex As Exception
            ProjectData.SetProjectError(ex)

            RadMessageBox.Show("Error, failed_getlistInvoice : " & ex.Source & vbNewLine & _
                               "Cek &Details Untuk Info Lengkap Error", "Get List Invoice", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message)

            ProjectData.ClearProjectError()
        End Try
        
    End Sub

    Private Sub FrmListInvoiceKeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        'rFormMain.UpdateCAPSLock()
        'rFormMain.UpdateInsert()
        'rFormMain.UpdateNUMLock()
    End Sub

    Private Sub FrmListInvoiceLoad(sender As Object, e As EventArgs) Handles Me.Load
        Telerik.WinControls.RadMessageBox.Instance.AllowTheming = True
        Telerik.WinControls.RadMessageBox.Instance.BringToFront()
        Telerik.WinControls.RadMessageBox.ShowInTaskbar = True
        Telerik.WinControls.RadMessageBox.ThemeName = rFormMain.Office2010BlackTheme1.ThemeName
        Dim strTheme As String = rFormMain.Office2010BlackTheme1.ThemeName
        rFormMain.SetTheme(Me, strTheme)
        'Me.ShowIcon = True
        'Me.Icon = New Icon(My.Application.Info.DirectoryPath & "\Image\Icons\Invoice.ico")
        BufferMethod.DoubleBuffered(dg, True)
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim ColumnValues As String() = New String((17 + 1) - 1) {}
        ColumnValues(0) = "Invoice Date"
        ColumnValues(1) = "Invoice Type"
        ColumnValues(2) = "Client Name"
        ColumnValues(3) = "Work Order/SPK"
        ColumnValues(4) = "Work Order Terms"
        ColumnValues(5) = "Progress (%)"
        ColumnValues(6) = "Termyn (%)"
        ColumnValues(7) = "Items Records"
        ColumnValues(8) = "Total Items Summary"
        ColumnValues(9) = "Payments Record"
        ColumnValues(10) = "Sub Total"
        ColumnValues(11) = "PPn (10%)"
        ColumnValues(12) = "Terbilang"
        ColumnValues(13) = "Project"
        ColumnValues(14) = "User Input"
        ColumnValues(15) = "Create Date"
        ColumnValues(16) = "User Edit"
        ColumnValues(17) = "Date Update"
        Dim num1 As Integer = 0
        Dim num2 As Integer = (ColumnValues.Length)
        Dim num3 As Integer = num1

        While Not (num3 = num2)
            Dim strColName As String = "xCol" & Conversions.ToString(num3)
            Dim strColHeader As String = ColumnValues(num3)
            With dg
                .Columns.Add(strColName, strColHeader)
                .Columns(num3).DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
                .Columns(1).Width = 65
                .Columns(num3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                .ColumnHeadersHeight = 35
                .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
                .RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With
            Interlocked.Increment(num3)

            For Each dtCol As DataGridViewColumn In Me.dg.Columns
                If dtCol.HeaderText.Contains("InvoiceDate") Then
                    dtCol.DefaultCellStyle.Format = "d"
                    dtCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                End If
                If dtCol.HeaderText.Contains("Items Records") Then
                    dtCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                End If
                If dtCol.HeaderText.Contains("Total Items Summary") Then
                    dtCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dtCol.DefaultCellStyle.Format = "N2"
                End If
                If dtCol.HeaderText.Contains("Payments Record") Then
                    dtCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dtCol.DefaultCellStyle.Format = "N2"
                End If
                If dtCol.HeaderText.Contains("Sub Total") Then
                    dtCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dtCol.DefaultCellStyle.Format = "N2"
                End If
                If dtCol.HeaderText.Contains("PPn (10%)") Then
                    dtCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dtCol.DefaultCellStyle.Format = "N2"
                End If
                If dtCol.HeaderText.Contains("Progress (%)") Then
                    dtCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dtCol.DefaultCellStyle.Format = "N2"
                End If
                If dtCol.HeaderText.Contains("Termyn (%)") Then
                    dtCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    dtCol.DefaultCellStyle.Format = "N2"
                End If
            Next
            dg.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
            dg.Update()
        End While

        Dim d As Double = 1 / 100
        dg.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg.Columns(0).Width = 35
        dg.Columns(1).Width = 2
        dg.Columns(8).CellTemplate.Value = d.ToString("0.00\&")
        dg.Refresh()

        Me.LoadListInvoice()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'rFormInvoice.ShowDialog()
        FormTambahInvoice.ShowDialog()
    End Sub

    Private Sub btnColumn_Click(sender As Object, e As EventArgs)
        'RadMessageBox.Show(vbNewLine & "This Menu Button are under development" & vbNewLine, "AUTHOR - MESSAGE", MessageBoxButtons.OK, RadMessageIcon.Info)
        'Return
        'FrmArrangeColumns.ShowDialog()
        FrmCustomFilter.ShowDialog()
    End Sub

    Private Sub hitung()
        Dim num As Integer = 0
        Dim num1 As Integer = dg.Rows.Count - 1
        Do While num <= num1

            Interlocked.Increment(num)
        Loop
        LoadListInvoice("")
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Try
            Dim StrOpsi As String = ""
            Dim strFilterType As String
            Dim strFilterDate As String
            Dim strFilterClient As String
            Dim strFilterProject As String
            Dim strFilterCustom As String
            If RadDropDownList1.SelectedIndex = 0 Then
                strFilterType = "INVOICETYPE LIKE '%" & txFilter.Text & "%'"
                StrOpsi = " WHERE " & strFilterType
                txFilter.NullText = "Filter Invoice Type"
            ElseIf RadDropDownList1.SelectedIndex = 1 Then
                strFilterDate = "INVOICEDATE LIKE '%" & txFilter.Text & "%'"
                StrOpsi = " WHERE " & strFilterDate
                txFilter.NullText = "Filter Invoice Date"
            ElseIf RadDropDownList1.SelectedIndex = 2 Then
                strFilterClient = "INVOICECLIENT LIKE '%" & txFilter.Text & "%'"
                StrOpsi = " WHERE " & strFilterClient
                txFilter.NullText = "Filter Invoice Client"
            ElseIf RadDropDownList1.SelectedIndex = 3 Then
                strFilterProject = "IndexProject LIKE '%" & txFilter.Text & "%'"
                StrOpsi = " WHERE " & strFilterProject
                txFilter.NullText = "Filter Invoice Project"
            ElseIf RadDropDownList1.SelectedIndex = 4 Then
                strFilterCustom = " WHERE RecordNo Like '%" & String.Empty & "%'" & " " & txFilter.Text
                StrOpsi = strFilterCustom
                txFilter.NullText = "Filter Invoice Custom"
            End If
            Me.LoadListInvoice(StrOpsi)
        Catch ex As Exception
            RadMessageBox.Show("Could not filter!, " & _
                               ex.Source & "." & ex.Message, "FILTER INVOICE", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End Try
    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick
        dg.MultiSelect = False
        Me.dg.Rows(Me.dg.CurrentRow.Index).Selected = True
        Me.dg.CurrentRow.Cells(0).Value = RuntimeHelpers.GetObjectValue _
        (Interaction.IIf(Conversions.ToBoolean(Me.dg.CurrentRow.Cells(0).Value), _
        DirectCast(False, Object), DirectCast(True, Object)))
        BtnEditDeleteEnable()
    End Sub

    Private Sub dg_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dg.CellFormatting
        'If dg.Columns(e.ColumnIndex).HeaderText.Equals("Tax Price") AndAlso dg.NewRowIndex Then
        '    If CInt(e.Value) < 0 Then
        '        e.CellStyle.BackColor = Color.Red
        '        e.CellStyle.SelectionBackColor = Color.DarkRed
        '    Else
        '        'e.CellStyle.Format = "N2"
        '        e.FormattingApplied = True
        '        With dg
        '            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '            .Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '            .Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '            .Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '            .Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '            .Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '            .Columns(8).DefaultCellStyle.WrapMode = DataGridViewTriState.True
        '            .Columns(10).DefaultCellStyle.WrapMode = DataGridViewTriState.True
        '            .Columns(11).DefaultCellStyle.WrapMode = DataGridViewTriState.True
        '            .Columns(12).DefaultCellStyle.WrapMode = DataGridViewTriState.True
        '            .Columns(13).DefaultCellStyle.WrapMode = DataGridViewTriState.True
        '            .Columns(14).DefaultCellStyle.WrapMode = DataGridViewTriState.True
        '            'Dim num As [String] = "29%"
        '            'Dim nums As Double = Double.Parse(num.Substring(0, num.IndexOf("%"c))) / 100.0
        '            'Dim d As Double = 1 / 100 
        '            '.Columns(9).DefaultCellStyle.Format = "P0" 'd.ToString("0.00\%")
        '            .Columns(8).ValueType = GetType(Double)
        '            .Columns.Item(8).DefaultCellStyle.Format = "p0"
        '            .Columns(9).ValueType = GetType(Double)
        '            .Columns.Item(8).DefaultCellStyle.Format = "p0"
        '            .Columns(11).ValueType = GetType(Decimal)
        '            .Columns(11).DefaultCellStyle.Format = "N3"
        '            .Columns(13).ValueType = GetType(Decimal)
        '            .Columns(13).DefaultCellStyle.Format = "N3"
        '            '.Columns(12).DefaultCellStyle.Format = "#.###0,00"
        '            '.Columns(13).DefaultCellStyle.Format = "#.###0,00"
        '            .Columns(13).ValueType = GetType(Decimal)
        '            .Columns(13).DefaultCellStyle.Format = "N3"
        '        End With
        '    End If
        'End If
    End Sub

    Private Sub btnPDF_Click(sender As Object, e As EventArgs) Handles btnPDF.Click
        'Dim frmReport As New frmReportViewInvoice
        'frmReport.ShowDialog()
    End Sub

    Private Sub RadDropDownList1_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles RadDropDownList1.SelectedIndexChanged
        If RadDropDownList1.SelectedIndex = 0 Then
            txFilter.Text = ""
            txFilter.Enabled = True
            txFilter.NullText = "Filter Invoice Type"
        ElseIf RadDropDownList1.SelectedIndex = 1 Then
            txFilter.Text = ""
            txFilter.Enabled = True
            txFilter.NullText = "Filter Invoice Date"
        ElseIf RadDropDownList1.SelectedIndex = 2 Then
            txFilter.Text = ""
            txFilter.Enabled = True
            txFilter.NullText = "Filter Invoice Client"
        ElseIf RadDropDownList1.SelectedIndex = 3 Then
            txFilter.Text = ""
            txFilter.Enabled = True
            txFilter.NullText = "Filter Invoice Project"
        ElseIf RadDropDownList1.SelectedIndex = 4 Then
            txFilter.Text = ""
            txFilter.Enabled = False
            txFilter.NullText = "Filter Invoice Custom"
            FrmCustomFilter.ShowDialog()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

    End Sub

    Public Sub SelAllRow(ByVal GridView As DataGridView, ByVal ColumnName As String)
        Dim UnCheckedItems = From Rows In GridView.Rows.Cast(Of DataGridViewRow)() _
                    Where CBool(Rows.Cells(ColumnName).Value) = False
        For Each item In UnCheckedItems
            item.Cells(ColumnName).Value = True
        Next
    End Sub

    Public Sub ClearAllRow(ByVal GridView As DataGridView, ByVal ColumnName As String)
        Dim UnCheckedItems = From Rows In GridView.Rows.Cast(Of DataGridViewRow)() _
                    Where CBool(Rows.Cells(ColumnName).Value) = True
        For Each item In UnCheckedItems
            item.Cells(ColumnName).Value = False
        Next
    End Sub

    Private Sub RadCheckBox1_ToggleStateChanged(sender As Object, args As UI.StateChangedEventArgs) Handles RadCheckBox1.ToggleStateChanged
        If args.ToggleState = Enumerations.ToggleState.On Then
            SelAllRow(dg, "Col1")
            RadCheckBox1.Text = "Clear Selection"
            BtnEditDeleteEnable()
        Else
            RadCheckBox1.Text = "Select All"
            BtnEditDeleteEnable()
            ClearAllRow(dg, "Col1")
        End If
    End Sub
End Class