Imports System, System.IO, System.Text, System.Windows.Forms, _
    System.Threading, Microsoft.VisualBasic.CompilerServices, _
     Telerik, Telerik.WinControls, Telerik.WinControls.UI, MySql.Data.MySqlClient
Imports MySql.Data.MySqlClient.MySqlBackup
Imports Splash.Konektor

Public Class rFormExportCSV

    Dim exportDone As Boolean
    Public Event newExportProgress As exportProgressChange
    Private Shared tableName As String
    Private Shared delimiter As String
    Private Shared Qualifier As String

    Public Sub New()
        InitializeComponent()

        Telerik.WinControls.RadMessageBox.Instance.AllowTheming = True
        Telerik.WinControls.RadMessageBox.Instance.ControlBox = False
        Telerik.WinControls.RadMessageBox.ShowInTaskbar = False
        Telerik.WinControls.RadMessageBox.ThemeName = rFormMain.Office2010BlackTheme1.ThemeName
        rFormMain.SetTheme(Me, rFormMain.Office2010BlackTheme1.ThemeName.ToString)
        tableName = Nothing

        Me.Timer1.Interval = 50
        Me.bwExport = New System.ComponentModel.BackgroundWorker

    End Sub

    Private Sub rFormExportCSV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        Select Case e.KeyChar
            Case Chr(27)
                If exportDone Then
                    Dim result As DialogResult = RadMessageBox.Show("Belum memproses export data [CSV]!" & vbNewLine & _
                                                                    "Anda yakin akan keluar?", "Export DATA", MessageBoxButtons.YesNo, RadMessageIcon.Question)
                    If result = Windows.Forms.DialogResult.Yes Then
                        Me.Close()
                    Else
                        Return
                        Exit Select
                    End If
                Else
                    Dim result As DialogResult = RadMessageBox.Show( _
                                                                    "Anda yakin akan Keluar?", "Export DATA", MessageBoxButtons.YesNo, RadMessageIcon.Question)
                    If result = Windows.Forms.DialogResult.Yes Then
                        Me.Close()
                    Else
                        Return
                    End If
                End If
        End Select
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
            rDropInvoiceType.Focus
            Return False
        End If
        If RadTextBox1.Text.Trim() = "" Then
            RadMessageBox.Show("Anda belum menyimpan file CSV!", "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            RadButton2.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub ExporCSV(ByVal dt As DataTable, ByVal filepath As String)
        Dim errMsg As String = ""
        Try
            Dim writer As New StreamWriter(filepath, False)
            Dim iColCount As Integer = dt.Columns.Count
            Dim i As Integer = 0

            For i = 0 To iColCount - 1

                pbar.Maximum = iColCount
                writer.Write(dt.Columns(i).ColumnName)



                If i < (iColCount - 1) Then
                    writer.Write(",")
                End If

                pbar.Value = i

            Next


            pbar.Value = 0
            pbar.PerformStep()

            writer.WriteLine(writer.NewLine)

            Dim intRow As Integer = dt.Rows.Count

            pbar.Maximum = intRow

            For Each dr As DataRow In dt.Rows

                Dim irow As Integer = 0

                For irow = 0 To iColCount - 1

                    If Not Convert.IsDBNull(dr(irow)) Then
                        Dim valu As String = dr(irow).ToString
                        writer.Write(mdlstring.ADD_QUOTE_ON_SQL(valu))
                    End If

                    If irow < iColCount - 1 Then
                        writer.Write(",")
                    End If

                    Application.DoEvents()

                    pbar.Value = CInt(irow)

                Next

                Application.DoEvents()

                pbar.Value = CInt("0")

                writer.Write(writer.NewLine)

            Next

            writer.Close()

            RadMessageBox.Show("File CSV sukses dibuat.", "Export CSV", MessageBoxButtons.OK, RadMessageIcon.Info)

        Catch ex As Exception
            RadMessageBox.Show("Error." & ex.Source & vbNewLine & _
                                 "Message: ", "Error Load Datatable", _
                                 MessageBoxButtons.OK, RadMessageIcon.Error, _
                                 ex.Message)
        End Try
    End Sub

    'Private Sub BindDataTable()
    '    Try
    '        mdlCom.BukaKoneksi()
    '        Dim sqlCmdTable As New MySqlCommand("SHOW TABLES", mdlCom.vConn)
    '        Dim drTables As MySqlDataReader

    '        drTables = sqlCmdTable.ExecuteReader
    '        drTables.Read()
    '        Dim dt As New DataTable

    '        Do While drTables.Read
    '            dg.Rows.Add(drTables.GetString(0))
    '        Loop
    '        Dim strTableName As String
    '        strTableName = drTables.GetValue(CInt("0"))
    '        tableName = strTableName
    '        drTables.Close()


    '    Catch ex As Exception
    '        RadMessageBox.Show("Error." & ex.Source & vbNewLine & _
    '                           "Message: ", "Error Load Datatable", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message)
    '    End Try
    'End Sub

    Private Sub rFormExportCSV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        rFormMain.SetTheme(Me, rFormMain.Office2010BlackTheme1.ThemeName.ToString)
        rFormMain.UserSettingIcon(True, Me)
        Me.Focus()
        rFormMain.SetTheme(Me, rFormMain.Office2010BlackTheme1.ThemeName.ToString)
        rSemicol.IsChecked = True
        rDropInvoiceType.SelectedIndex = 0
        RadTextBox2.MaxLength = 1
        'BindDataTable()
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Dim nFilename As String = ""
        If mdlCom.TargetDirIsValid Then
            If valDelimiterQuote() Then
                Me.NewExpor()
            End If
        End If
    End Sub

    Public Shared Sub WriteDataTable(sourceTable As DataTable, writer As TextWriter, includeHeaders As Boolean)
        If includeHeaders Then
            Dim headerValues As IEnumerable(Of [String]) = sourceTable.Columns.OfType(Of DataColumn)().[Select](Function(column) QuoteValue(column.ColumnName))

            writer.WriteLine([String].Join(delimiter, headerValues))
        End If

        Dim items As IEnumerable(Of [String]) = Nothing

        For Each row As DataRow In sourceTable.Rows
            items = row.ItemArray.[Select](Function(o) QuoteValue(o.ToString()))
            writer.WriteLine([String].Join(delimiter, items))
        Next

        writer.Flush()
    End Sub

    Private Shared Function QuoteValue(value As String) As String
        Dim str As String
        If Qualifier = "{none}" Then
            Dim QuoteNone As String = ""
            str = [String].Concat("", value, QuoteNone)
        Else
            str = [String].Concat(Qualifier, value.Replace(Qualifier, Qualifier), Qualifier)
        End If
        Return str
    End Function

    Private Sub NewExpor()
        tableName = "invoicedata"
        mdlCom.BukaKoneksi()
        'Dim tableName As String = dg.CurrentRow.Cells.Item(0).Value
        Dim da As New MySqlDataAdapter("SELECT * FROM `" & tableName & "`;", mdlCom.vConn)
        Dim ds As New DataSet

        da.Fill(ds, tableName)
        Dim dt As DataTable = ds.Tables(tableName)

        Dim nFilename As String = ""
        nFilename = mdlCom.targetFile
        If Directory.Exists(Path.GetDirectoryName(nFilename)) = False Then
            Directory.CreateDirectory(Path.GetDirectoryName(nFilename))
        End If

        Using writer As New StreamWriter(nFilename)
            rFormExportCSV.WriteDataTable(dt, writer, True)
        End Using

        pbar.Maximum = dt.Columns.Count
        Dim num As Integer = 0
        Dim num1 As Integer = dt.Columns.Count
        Dim num2 As Integer = num

        Do While num2 <= num1
            pbar.Value = num2
            Interlocked.Increment(num2)
            Thread.Sleep(5)
        Loop

        pbar.Value = num
        pbar.Maximum = dt.Rows.Count

        Dim num3 As Integer = 0
        Dim num4 As Integer = dt.Rows.Count
        Dim num5 As Integer = num3

        Do While num5 <= num4
            pbar.Value = num5
            Interlocked.Increment(num5)
            Thread.Sleep(5)
        Loop
        RadMessageBox.Show("File CSV sukses dibuat " & dt.Rows.Count & " datarow berhasil ditambahkan.", "Export CSV", MessageBoxButtons.OK, RadMessageIcon.Info)
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        Dim Dialog As New SaveFileDialog
        If (mdlCom.DefaultFolderName <> "") Then
            Dialog.InitialDirectory = mdlCom.DefaultFolderName
        End If
        Dialog.Filter = "SQL Dump File (*.sql)|*.sql| CSV Comma delimiter (*.csv)|*.csv"
        Dialog.FilterIndex = 2
        Dialog.FileName = (String.Concat(New String() {"exported", "_", "invoicedate", DateTime.Now.ToString("yyyy-MM-dd HHmmss"), ".sql"}))
        If (DialogResult.OK = Dialog.ShowDialog) Then
            Me.RadTextBox1.Text = Dialog.FileName
            mdlCom.DefaultFolderName = Path.GetDirectoryName(Me.RadTextBox1.Text)
            mdlCom.targetFile = Me.RadTextBox1.Text
        End If
    End Sub

    Private Sub RadRadioButton1_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
        If args.ToggleState = Enumerations.ToggleState.On Then
            delimiter = vbTab
        Else
            delimiter = Nothing
        End If
        Me.Text = "Export with delimiter " & "[" & delimiter & "]"
    End Sub

    Private Sub RadRadioButton2_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rSemicol.ToggleStateChanged
        If args.ToggleState Then
            delimiter = Chr(59)
        Else
            delimiter = Nothing
        End If
        Me.Text = "Export with delimiter " & "[" & delimiter & "]"
    End Sub

    Private Sub RadRadioButton3_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rKoma.ToggleStateChanged
        If args.ToggleState Then
            delimiter = Chr(44)
        Else
            delimiter = Nothing
        End If
        Me.Text = "Export with delimiter " & "[" & delimiter & "]"
    End Sub

    Private Sub RadRadioButton4_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rOther.ToggleStateChanged
        If args.ToggleState Then
            delimiter = RadTextBox2.Text.Trim()
        Else
            delimiter = Nothing
        End If
        Me.Text = "Export with delimiter " & "[" & delimiter & "]"
    End Sub

    Private Sub rDropInvoiceType_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles rDropInvoiceType.SelectedIndexChanged
        If e.Position = 0 Then
            Qualifier = Chr(34)
        ElseIf e.Position = 1 Then
            Qualifier = "'"
        ElseIf e.Position = 2 Then
            Qualifier = "{none}"
        End If

        Me.Text = "Export with delimiter " & "[" & delimiter & "]" & "Qualifier [" & Qualifier & "]"

    End Sub
End Class