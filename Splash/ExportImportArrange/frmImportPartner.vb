Imports System, System.Threading
Imports MySql.Data.MySqlClient
Imports System.Data, System.Data.OleDb
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic, Microsoft.VisualBasic.CompilerServices
Imports Telerik.WinControls

Public Class frmImportPartner

    Private Sub LoadData()
        Dim strArr As String() = New String((18 + 1) - 1) {}
        strArr(0) = "Invoice Date"
        strArr(1) = "Invoice Type"
        strArr(2) = "Client Name"
        strArr(3) = "Client Address"
        strArr(4) = "Work Order/SPK"
        strArr(5) = "Work Order Term"
        strArr(6) = "Progress (%)"
        strArr(7) = "Termyn (%)"
        strArr(8) = "Items Records"
        strArr(9) = "Total Items"
        strArr(10) = "Payments Record"
        strArr(11) = "Sub Total"
        strArr(12) = "Tax Price"
        strArr(13) = "Terbilang"
        strArr(14) = "Project"
        strArr(15) = "User Input"
        strArr(16) = "Create Date"
        strArr(17) = "User Edit"
        strArr(18) = "Date Update"
        Dim num1 As Integer = 0
        Dim num2 As Integer = (strArr.Length)
        Dim num3 As Integer = num1

        While Not (num3 = num2)
            Dim strColName As String = "xCol" & Conversions.ToString(num3)
            Dim strColHeader As String = strArr(num3)
            With dg
                .Columns.Add(strColName, strColHeader)
                .Columns(num3).DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
                .Columns(1).Width = 65
                .Columns(num3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                .ColumnHeadersHeight = 35
                .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
            End With
            Interlocked.Increment(num3)
        End While

        'Dim d As Double = 1 / 100

        'dg.Columns(9).CellTemplate.Value = d.ToString("0.00\&")


    End Sub

    Private Sub InsertDataCSV(ByVal sFilePath As String)
        Try
            Dim errMsg As String = ""
            Dim xValues As String() = New String(4 - 1) {}
            Dim arrSukses As String() = New String(22 - 1) {}
            Dim num As Integer = 0
            Dim num2 As Integer = 0

            Dim List As New List(Of String)
            Dim partner As New common
            Dim errParsing As String = ""
            If partner.ReadCSVImport(errMsg, List, sFilePath) Then
                If ((List.Count - 1) > 65000) Then
                    mdlCom.ShowError("Jumlah Data Melebihi batas maksimal 65.000 baris!.")
                Else
                    mdlCom.ShowInfo(("Jumlah Data : " & Conversions.ToString(CInt((List.Count - 1))) & " Baris."))
                    Me.pBar.Minimum = 0
                    Me.pBar.Maximum = (List.Count - 1)
                    Me.pBar.Value = 0
                    Dim num5 As Integer = (List.Count - 1)
                    Dim i As Integer = 1
                    Do While (i <= num5)
                        If partner.pastingLine(errMsg, List.Item(i), arrSukses, errParsing) Then
                            num2 += 1
                            arrSukses(0) = Conversions.ToInteger(num2)
                            Me.dg.Rows.Add(arrSukses)
                        Else
                            num += 1
                            xValues(0) = Conversions.ToString(num2)
                            xValues(1) = Conversions.ToString(i)
                            xValues(2) = errParsing
                            Me.dgErr.Rows.Add(xValues)
                        End If
                        Me.pBar.Value += 1
                        i += 1
                    Loop
                    Me.btnImport.Enabled = True
                End If
            Else
                mdlCom.ShowError(errMsg)
            End If
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim exception As Exception = ex
            mdlCom.ShowError(("Failed (load_file). Message : " & exception.Message))
            mdlCom.INSERTLOG(("Failed (load_file). Message : " & exception.Message), "")
            ProjectData.ClearProjectError()

        End Try

    End Sub

    Private Sub frmImportPartner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btnSelectFile_Click(sender As Object, e As EventArgs) Handles btnSelectFile.Click
        Dim nFileName As String = ""
        Dim name As String = ""
        Try
            Dim dialog As New OpenFileDialog With {
            .Title = "Pilih File CSV",
            .Filter = "csv/txt Files|*.csv;*.txt",
            .FilterIndex = 1,
            .RestoreDirectory = True,
            .InitialDirectory = My.Application.Info.DirectoryPath & "\"}
            If dialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                nFileName = dialog.FileName
                Dim info As New IO.FileInfo(nFileName)
                name = info.Name
            End If
            Me.RadTextBox1.Text = nFileName
            If nFileName.Trim() <> "" Then
                Me.dg.Rows.Clear()
                Me.dgErr.Rows.Clear()
                Me.InsertDataCSV(nFileName)
            End If
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim exception As Exception = ex
            mdlCom.ShowError(("Failed (browse_file). Message : " & exception.Message))
            mdlCom.INSERTLOG(("Failed (browse_file). Message : " & exception.Message), "")
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Try
            Dim values As String() = New String(4 - 1) {}
            Dim partner As New common
            Dim num As Integer = 0
            Me.dgErr.Rows.Clear()
            Me.pBar.Minimum = 0
            Me.pBar.Maximum = Me.dg.RowCount
            Me.pBar.Value = 0
            Dim num3 As Integer = (Me.dg.RowCount - 1)
            Dim i As Integer = 0
            Do While (i <= num3)
                Dim row As DataGridViewRow = Me.dg.Rows.Item(i)
                Dim invNo As String = Conversions.ToString(row.Cells.Item(1).Value)
                Dim editmode As Boolean = partner.CekNoInvoiceada(invNo, Conversions.ToString(row.Cells.Item(4).Value))
                If Conversions.ToBoolean((
                partner.InsertInvoiceData(row.Cells.Item(0).Value, row.Cells.Item(0).Value,
                                          row.Cells.Item(0).Value, row.Cells.Item(0).Value,
                                          row.Cells.Item(0).Value, row.Cells.Item(0).Value,
                                          row.Cells.Item(0).Value, row.Cells.Item(0).Value,
                                          row.Cells.Item(0).Value, row.Cells.Item(0).Value,
                                          row.Cells.Item(0).Value, row.Cells.Item(0).Value,
                                          row.Cells.Item(0).Value, row.Cells.Item(0).Value,
                                          row.Cells.Item(0).Value, row.Cells.Item(0).Value,
                                          editmode, "exported", DateTime.Now.ToString("dd/MM/YY"),
                                          mdlCom.UserLogin, DateTime.Now.ToString("dd/MM/YY")))) Then
                    num += 1
                    values(0) = Conversions.ToString(num)
                    values(1) = Conversions.ToString(CInt((i + 1)))
                    values(2) = "data tidak tersimpan - "
                    Me.dgErr.Rows.Add(values)
                End If
                row = Nothing
                Me.pBar.Value += 1
                i += 1
            Loop
            mdlCom.ShowInfo(String.Concat(New String() {"Hasil Import CSV Invoice : " & "Jumlah Data = " & Conversions.ToString(Me.dg.Rows.Count), " baris." & vbNewLine & "Berhasil Load = ", Conversions.ToString(CInt(Me.dg.Rows.Count - num)), " Baris." & vbNewLine & "Gagal Load = ", Conversions.ToString(num), " Baris."}))
            Me.btnImport.Enabled = False
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim exception As Exception = ex
            mdlCom.ShowError(("Failed (import). Message : " & exception.Message))
            mdlCom.INSERTLOG(("Failed (import). Message : " & exception.Message), "")
            Me.btnImport.Enabled = False
            ProjectData.ClearProjectError()
        End Try
    End Sub
End Class