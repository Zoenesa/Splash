Imports System, System.IO, System.Text, System.Windows.Forms, _
    System.Threading, Microsoft.VisualBasic.CompilerServices, _
     Telerik, Telerik.WinControls, Telerik.WinControls.UI

Public Class clsExportToCSV
    Public Shared Function wrapValue(value As String, group As String, separator As String) As String
        If value.Contains(separator) Then
            If value.Contains(group) Then
                value = value.Replace(group, group + group)
            End If
            value = group & value & group
        End If
        Return value
    End Function

    Public Shared Function ExportToCSV(dtable As DataTable, fileName As String) As Boolean
        Dim result As Boolean = True
        Try
            Dim sb As New StringBuilder()
            Dim separator As String = ";"
            Dim group As String = """"
            Dim newLine As String = Environment.NewLine

            For Each column As DataColumn In dtable.Columns
                sb.Append(wrapValue(column.ColumnName, group, separator) & separator)
            Next
            ' here you could add the column for the username
            sb.Append(newLine)

            For Each row As DataRow In dtable.Rows
                For Each col As DataColumn In dtable.Columns
                    sb.Append(wrapValue(row(col).ToString(), group, separator) & separator)
                Next
                ' here you could extract the password for the username
                sb.Append(newLine)
            Next
            Using fs As New StreamWriter(fileName)
                fs.Write(sb.ToString())
            End Using
        Catch ex As Exception
            RadMessageBox.Show("Error." & ex.Source & _
                               vbNewLine & ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
            result = False
        End Try
        Return result
    End Function

    Public Shared Sub TesExport()
        Try
            Dim dt As New DataTable
            dt.Columns.Add("String Column", GetType(String))
            dt.Columns.Add("Integer Column", GetType(Integer))
            dt.Columns.Add("Boolean Column", GetType(Boolean))
            dt.Columns.Add("Double Column", GetType(Double))

            For i As Integer = 0 To 10
                dt.Rows.Add("string "";value " & i, i, IIf(i Mod 2, True, False), Math.Sqrt(i))
            Next

            Dim dirpath As String = Environment.CurrentDirectory

            If ExportToCSV(dt, Path.Combine(dirpath, "Sample.csv")) Then
                RadMessageBox.Show("sukses membuat csv.", "Export", MessageBoxButtons.OK, RadMessageIcon.Info)
            End If
        Catch ex As Exception
            RadMessageBox.Show("Error." & ex.Source & _
                               vbNewLine & ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
    End Sub

End Class
