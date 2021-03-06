﻿Imports System, System.Text, System.Threading
Imports System.Data, System.Data.OleDb
Imports System.Runtime, System.Runtime.CompilerServices, System.Runtime.InteropServices
Imports Microsoft, Microsoft.VisualBasic, Microsoft.VisualBasic.CompilerServices
Imports MySql.Data.MySqlClient
Imports Splash.Konektor
Imports Splash.Konektor.Setting
Imports iniSettings
Imports Telerik, Telerik.WinControls

Public Class FrmCustomFilter

    Public Shared LoadTabel As String = "invoicedata"

    Private Sub FrmCustomFilter_Load(sender As Object, e As EventArgs) Handles Me.Load
        rFormMain.SetTheme(Me, rFormMain.Office2010BlackTheme1.ThemeName.ToString)
        'rFormMain.LoadIcon(True, Me)
        'GetInvData()
        'LoadField(rFormDataListInvoice, rFormDataListInvoice.dg)
        'LoadDataColumn()

        SqlSelectKolom(LoadTabel)

        RadListControl1.Items.AddRange(FieldNamaKolom)

        RadDropDownList1.ReadOnly = False

        Dim strQryLoad As String()
        Dim StrFilter As String
        RadDropDownList1.SelectedIndex = 0
        StrFilter = rFormDataListInvoice.txTemp.Text
        If StrFilter = Nothing Then
            Return
        Else
            strQryLoad = rFormDataListInvoice.txTemp.Text.Split(New String() {";"}, StringSplitOptions.RemoveEmptyEntries)
            RadListControl2.Items.AddRange((IO.File.ReadAllLines(Environment.CurrentDirectory & "\filter.txt")))
        End If
    End Sub

    Private Sub LoadDataColumn()
        RadListControl1.Items.Clear()
        Dim Values As String() = New String((17 + 1) - 1) {}
        Dim Num1 As Integer = 0
        Dim Num2 As Integer = Values.Length
        Dim Num3 As Integer = Num1
        Values(0) = Conversions.ToString(("Tanggal Invoice"))
        Values(1) = Conversions.ToString(("InvoiceType"))
        Values(2) = Conversions.ToString(("InvoiceClient"))
        Values(3) = Conversions.ToString(("InvoiceClientAddress"))
        Values(4) = Conversions.ToString(("InvoiceWorkOrderSPK"))
        Values(5) = Conversions.ToString(("InvoiceLisence"))
        Values(6) = Conversions.ToString(("InvoiceProgress"))
        Values(7) = Conversions.ToString(("InvoiceTerm"))
        Values(8) = Conversions.ToString(("InvoiceItemsRecords"))
        Values(9) = Conversions.ToString("InvoiceTotalItems")
        Values(10) = Conversions.ToString(("InvoicePaymentsRecord"))
        Values(11) = Conversions.ToString(("InvoiceTaxPrice"))
        Values(12) = Conversions.ToString(("InvoiceTerbilang"))
        Values(13) = Conversions.ToString(("IndexProject"))
        Values(14) = Conversions.ToString(("UserPerekam"))
        Values(15) = Conversions.ToString(("Tanggal Rekam"))
        Values(16) = Conversions.ToString(("User Update"))
        Values(17) = Conversions.ToString(("Tanggal Update"))
        While Not Num3 = Num2
            RadListControl1.Items.Add(Values(Num3))
            Interlocked.Increment(Num3)
        End While
    End Sub

    Public Sub LoadField(ByVal frm As Form, ByVal grid As DataGridView)
        RadListControl1.Items.Clear()
        For i As Integer = 2 To grid.Columns.Count - 1
            Me.RadListControl1.Items.Add(grid.Columns(i).HeaderText)
        Next i
        Me.Text = "Query Expression Data" & " " & frm.Text
    End Sub

    Private eList As New List(Of Telerik.WinControls.UI.RadListDataItem)

    Public Sub New()

        Me.datSetingFile = New iniSettings(Environment.CurrentDirectory & "\filter.ini")

        InitializeComponent()

        Telerik.WinControls.RadMessageBox.Instance.AllowTheming = True
        Telerik.WinControls.RadMessageBox.Instance.ControlBox = False
        Telerik.WinControls.RadMessageBox.ShowInTaskbar = False
        Telerik.WinControls.RadMessageBox.ThemeName = rFormMain.Office2010BlackTheme1.ThemeName

    End Sub

    Public Function FormSqlFilter(ByVal tablename As String) As DialogResult
        Dim dlg As DialogResult
        Try

        Catch ex As Exception

        End Try
        Return dlg
    End Function

    Private datSetingFile As iniSettings

    Private Sub SimpanDataFilter(ByVal filepath As String)
        If Not IO.File.Exists(filepath) Then
            Dim sw As New IO.StreamWriter(filepath)
            sw.WriteLine()
            sw.Close()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub RadButton4_Click(sender As Object, e As EventArgs) Handles RadButton4.Click
        Dim StrAdd As String = ""
        Dim strTemp As String = ""
        If RadListControl1.SelectedIndex >= 0 Then
            If txExpresion.Text.Trim() <> "" Then
                If RadDropDownList1.SelectedItem.Text = "Like" Then
                    StrAdd = String.Format("{0} {1} {2} '%{3}%'", "AND", RadListControl1.SelectedItem.Text, RadDropDownList1.SelectedItem.Text, txExpresion.Text)
                    strTemp = String.Format("{0} {1} {2} '%{3}%'", "AND", RadListControl1.SelectedItem.Text, RadDropDownList1.SelectedItem.Text, txExpresion.Text)

                Else
                    StrAdd = String.Format("{0} {1} {2} {3}", "AND", RadListControl1.SelectedItem.Text, RadDropDownList1.SelectedItem.Text, txExpresion.Text)
                    strTemp = String.Format("{0} {1} {2} {3}", "AND", RadListControl1.SelectedItem.Text, RadDropDownList1.SelectedItem.Text, txExpresion.Text)

                End If
                RadListControl2.Items.Add(strTemp)
                Dim i As Integer = RadListControl2.Items.Count
                Dim filepath = (Environment.CurrentDirectory & "\filter.ini")
                If Not IO.File.Exists(filepath) Then
                    Dim sw As New IO.StreamWriter(filepath)
                    sw.WriteLine()
                    sw.Close()

                    Me.datSetingFile.WriteValue("Query" & i, "Function", "AND")
                    Me.datSetingFile.WriteValue("Query" & i, "FieldName", RadListControl1.SelectedItem.Text)
                    Me.datSetingFile.WriteValue("Query" & i, "Qualifier", RadDropDownList1.SelectedItem.Text)
                    Me.datSetingFile.WriteValue("Query" & i, "Value", txExpresion.Text.Trim())
                Else
                    Me.datSetingFile.WriteValue("Query" & i, "Function", "AND")
                    Me.datSetingFile.WriteValue("Query" & i, "FieldName", RadListControl1.SelectedItem.Text)
                    Me.datSetingFile.WriteValue("Query" & i, "Qualifier", RadDropDownList1.SelectedItem.Text)
                    Me.datSetingFile.WriteValue("Query" & i, "Value", txExpresion.Text.Trim())
                End If

            Else
                RadMessageBox.Show("AND Expression NULL", "", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1)
                Return
            End If
        Else
            RadMessageBox.Show("SELECT FIELD NULL", "", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1)
            Return
        End If
        'eList.AddRange(RadListControl2.Items)
    End Sub

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click
        Dim StrAdd As String = ""
        Dim strTemp As String = ""
        If RadListControl1.SelectedIndex >= 0 Then
            If txExpresion.Text.Trim <> "" Then
                If RadDropDownList1.SelectedItem.Text = "Like" Then
                    StrAdd = String.Format("{0} {1} {2} '%{3}%'", "OR", RadListControl1.SelectedItem.Text, RadDropDownList1.SelectedItem.Text, txExpresion.Text)
                    strTemp = String.Format("{0} {1} {2} {3}", "OR", RadListControl1.SelectedItem.Text, RadDropDownList1.SelectedItem.Text, txExpresion.Text)
                Else
                    StrAdd = String.Format("{0} {1} {2} {3}", "OR", RadListControl1.SelectedItem.Text, RadDropDownList1.SelectedItem.Text, txExpresion.Text)
                    strTemp = String.Format("{0} {1} {2} {3}", "OR", RadListControl1.SelectedItem.Text, RadDropDownList1.SelectedItem.Text, txExpresion.Text)
                End If
                RadListControl2.Items.Add(strTemp)
            Else
                RadMessageBox.Show("OR Expression NULL", "", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1)
                Return
            End If
        Else
            RadMessageBox.Show("SELECT FIELD NULL", "", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1)
            Return
        End If
        'eList.AddRange(RadListControl2.Items)
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        RadListControl2.Items.Remove(RadListControl2.SelectedItem)
        'eList.Remove(RadListControl2.SelectedItem)
    End Sub

    Public ListTable As List(Of String)
    Public Sub GetInvData(Optional ByVal Opsi As String = "")
        Dim errMsg As String = ""
        Dim Common As New SQLcommon
        Dim dt As New DataTable
        ListTable = New List(Of String)
        If Common.GetSqlInvoiceData(errMsg, dt, Opsi) Then
            Dim num As Integer = 0
            Dim num1 As Integer = dt.Columns.Count - 1
            Dim num2 As Integer = num
            Do While (num2 <= num1)
                Dim strCol As String = dt.Columns.Item(num2).ColumnName
                'ListTable.Add(strCol)
                ListTable.Add(strCol)
                Interlocked.Increment(num2)
            Loop
        End If
    End Sub

    Public Function querybuildervalue() As String
        Dim Sb As New StringBuilder()
        For Each Str2 As Telerik.WinControls.UI.RadListDataItem In RadListControl2.Items
            Sb.Append(Str2.Text).AppendLine()
        Next
        querybuildervalue = LTrim(RTrim(Replace(Sb.ToString, ";", ";", 1, -1, CompareMethod.Binary)))
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        rFormDataListInvoice.txTemp.Clear()

        rFormDataListInvoice.txTemp.Text = querybuildervalue()

        Dim listquery As Integer = RadListControl2.Items.Count

        Dim item As String() = New String((listquery - 1)) {}

        Dim i As Integer = 0

        Do While Not (i = listquery)
            item(i) = RadListControl2.Items(i).Text.ToString
            Interlocked.Increment(i)
        Loop

        IO.File.WriteAllLines(Environment.CurrentDirectory & "\filter.txt", item)

        'Dim sbFilter As New StringBuilder

        'For Each st As Telerik.WinControls.UI.RadListDataItem In RadListControl2.Items
        '    sbFilter.Append(st).AppendLine()
        'Next

        'mdlstring.SqlFilter(sbFilter.ToString)

        rFormDataListInvoice.txFilter.Clear()
        rFormDataListInvoice.txFilter.Text = IO.File.ReadAllText(Environment.CurrentDirectory & "\filter.txt") 'LTrim(RTrim(Replace(rFormDataListInvoice.txTemp.Text, ";", " ", 1, -1, CompareMethod.Binary)))

        Me.Dispose()
    End Sub

    Dim FieldNamaKolom As New List(Of String)
    Dim FieldKolomKomen As New List(Of String)

    Private Sub SqlSelectKolom(ByVal tableName As String, Optional ByVal Opsi As String = "")
        Dim sqlAdapter As MySqlDataReader = Nothing

        Try

            RadListControl1.Items.Clear()

            Dim comandpilih As String = "SELECT Column_Name, Column_Comment FROM information_schema.Columns WHERE table_name = '" & tableName & "'" & Opsi
            Dim sqlCmd As New MySqlCommand()
            sqlCmd.CommandText = comandpilih
            sqlCmd.Connection = mdlSQL.vConn
            Dim dt As New DataTable()
            sqlAdapter = sqlCmd.ExecuteReader
            FieldNamaKolom.Clear()
            FieldKolomKomen.Clear()

            Do While sqlAdapter.Read
                FieldNamaKolom.Add(sqlAdapter.Item("Column_Name"))
                FieldKolomKomen.Add(sqlAdapter.Item("Column_Comment"))
            Loop

            'RadListControl1.Items.AddRange(FieldNamaKolom)

            sqlAdapter.Close()

        Catch ex As Exception
            sqlAdapter = Nothing
            mdlSQL.ShowError(ex.Message.ToString)
        End Try
    End Sub

    Private Sub RadListControl1_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles RadListControl1.SelectedIndexChanged
        RadTextBox1.Text = FieldKolomKomen.Item(RadListControl1.SelectedIndex)
    End Sub
End Class
