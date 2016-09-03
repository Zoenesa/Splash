Imports System, System.IO, System.Text, System.Windows.Forms, _
    System.Threading, Microsoft.VisualBasic.CompilerServices, _
     Telerik, Telerik.WinControls, Telerik.WinControls.UI, MySql.Data.MySqlClient
Imports MySql.Data.MySqlClient.MySqlBackup
Imports System.Data.Odbc
Imports Splash.Konektor

Public Class rFormImport

    Private Shared CSVFolder As String
    Private Shared CSVFilename As String

    Public Sub New()

        InitializeComponent()

        Telerik.WinControls.RadMessageBox.Instance.AllowTheming = True
        Telerik.WinControls.RadMessageBox.Instance.ControlBox = False
        Telerik.WinControls.RadMessageBox.ShowInTaskbar = False
        Telerik.WinControls.RadMessageBox.ThemeName = rFormMain.Office2010BlackTheme1.ThemeName
        rFormMain.SetTheme(Me, rFormMain.Office2010BlackTheme1.ThemeName.ToString)

    End Sub
    Private Sub OpenFile(ByVal nfile As String)
        If (nfile = "") Then
            Me.RadTextBox3.Text = ""
        ElseIf (Not (IO.File.Exists(nfile))) Then
            RadMessageBox.Show("File tidak ditemukan / kosong!." & vbNewLine &
                               nfile, "Preview CSV", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        Else
            Try
                Me.Refresh()
                MyBase.SuspendLayout()
                Me.RadTextBox3.Text = IO.File.ReadAllText(nfile)
                MyBase.ResumeLayout()
            Catch ex As Exception
                RadMessageBox.Show("Error." & ex.Source & vbNewLine &
                                   "Message : ", "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
            End Try
        End If
    End Sub

    Public Sub OpenTargetFile()

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Me.OpenFile(IO.Path.Combine(CSVFilename))
    End Sub

    Private Sub btnSelectFile_Click(sender As Object, e As EventArgs) Handles btnSelectFile.Click
        Dim dialog As New OpenFileDialog
        If (mdlCom.DefaultFolderName <> "") Then
            dialog.InitialDirectory = mdlCom.DefaultFolderName
        End If
        If dialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            CSVFolder = IO.Path.GetDirectoryName(dialog.FileName)
            CSVFilename = dialog.FileName
            Dim strFileName As String = IO.Path.GetFileName(CSVFilename)
            Dim filenameFullPath As String = IO.Path.GetFullPath(dialog.FileName)
            RadTextBox1.Text = filenameFullPath
            'Me.OpenFile(dialog.FileName)
        End If
    End Sub

    Private Sub rFormImport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rFormMain.SetTheme(Me, rFormMain.Office2010BlackTheme1.ThemeName.ToString)
        rFormMain.LoadIcon(True, Me)
    End Sub

    Private Sub RadTextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles RadTextBox3.KeyDown
        If (e.Control AndAlso (e.KeyCode = Keys.A)) Then
            Me.RadTextBox3.SelectAll()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub RadTextBox3_TextChanged(sender As Object, e As EventArgs) Handles RadTextBox3.TextChanged

    End Sub

    Private Function valDelimiterQuote() As Boolean
        If RadTextBox2.Text.Trim() = "" AndAlso rOther.IsChecked Then
            RadMessageBox.Show("Harap masukan Spesial Karakter pada Kolom Lainnya!", "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            RadTextBox2.Focus()
            RadTextBox2.SelectAll()
            Return False
        End If
        If rDropInvoiceType.Text.Trim() = "" Then
            RadMessageBox.Show("Harap pilih Qualifier tersedia!", "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            rDropInvoiceType.Focus()
            Return False
        End If
        If RadTextBox1.Text.Trim() = "" Then
            RadMessageBox.Show("Anda belum Memilih file CSV!", "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            btnSelectFile.Focus()
            Return False
        End If
        Return True
    End Function

    Public Sub GetCSVData()
        Try

            Dim TextFileReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(CSVFilename)

            TextFileReader.TextFieldType = FileIO.FieldType.Delimited
            TextFileReader.SetDelimiters(";")

            Dim TextFileTable As DataTable = Nothing

            ' Declare variables for DataColumn and DataRow objects.
            Dim Column As DataColumn
            Dim Row As DataRow
            Dim UpperBound As Int32
            Dim ColumnCount As Int32
            Dim CurrentRow As String()
            TextFileReader.SetDelimiters(New String() {";"})
            While Not TextFileReader.EndOfData
                Try
                    CurrentRow = TextFileReader.ReadFields()
                    If Not CurrentRow Is Nothing Then
                        'Check if DataTable has been created
                        If TextFileTable Is Nothing Then
                            TextFileTable = New DataTable("TextFileTable")
                            'Get number of columns
                            UpperBound = CurrentRow.GetUpperBound(0)
                            'Create new DataTable
                            For ColumnCount = 0 To UpperBound
                                Column = New DataColumn()
                                Column.DataType = System.Type.GetType("System.String")
                                Column.ColumnName = "Column" & ColumnCount
                                Column.Caption = "Column" & ColumnCount
                                Column.ReadOnly = True
                                Column.Unique = False
                                TextFileTable.Columns.Add(Column)
                            Next
                        End If
                        Row = TextFileTable.NewRow
                        For ColumnCount = 0 To UpperBound
                            Row("Column" & ColumnCount) = CurrentRow(ColumnCount).ToString
                        Next
                        TextFileTable.Rows.Add(Row)
                    End If
                Catch ex As _
                Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & _
                    "is not valid and will be skipped.")
                End Try
            End While
            TextFileReader.Dispose()
            dgPreview.DataSource = TextFileTable
            With dgPreview
                .AutoGenerateColumns = True
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            End With
            RadPageView1.SelectedPage = RadPageView1.Pages.Item(1)
        Catch ex As Exception
            RadMessageBox.Show("Error." & ex.Source & vbNewLine & _
                                "Message: ", "Error Load Datatable", _
                                MessageBoxButtons.OK, RadMessageIcon.Error, _
                                ex.Message)
        End Try
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        GetCSVData()
    End Sub
End Class