Imports Telerik, Telerik.WinControls, Telerik.WinControls.UI
Imports System.Runtime.CompilerServices, System.Windows.Forms, Microsoft.VisualBasic.CompilerServices
Imports System.Threading
Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography, System.Security.Cryptography.CipherMode
Imports System.Text
Imports System.ComponentModel
Imports Splash.Konektor.mdlstring
Imports Splash.Konektor

Public Class FormDataBackup

    Private Shared targetFile As String
    Private Shared defaultFolder As String
    Private KoneksiSettingFile As String
    Private StopWrite As Boolean


    Shared Sub New()

        FormDataBackup.targetFile = ""
        FormDataBackup.defaultFolder = ""

    End Sub

    Public Sub New()
        MyBase.New()
        Me.KoneksiSettingFile = Path.Combine(Environment.CurrentDirectory & "\Libs", "KoneksiString.txt")

        mb = New MySqlBackup()

        AddHandler Me.mb.ExportProgressChanged, New MySqlBackup.exportProgressChange(AddressOf Me.mb_ExportProgressChange)


        InitializeComponent()

        Telerik.WinControls.RadMessageBox.Instance.AllowTheming = True
        Telerik.WinControls.RadMessageBox.Instance.ControlBox = False
        Telerik.WinControls.RadMessageBox.ShowInTaskbar = False
        Telerik.WinControls.RadMessageBox.ThemeName = rFormMain.Office2010BlackTheme1.ThemeName
        rFormMain.SetTheme(Me, rFormMain.Office2010BlackTheme1.ThemeName.ToString)

        Me.RadDropDownList1.ValueMember = "id"
        Me.RadDropDownList1.DisplayMember = "name"

        Dim tabl As New DataTable
        tabl.Columns.Add("id", GetType(RowsDataExportMode))
        tabl.Columns.Add("name")
        Dim mode As RowsDataExportMode
        For Each mode In [Enum].GetValues(GetType(RowsDataExportMode))
            tabl.Rows.Add(New Object() {mode, mode.ToString})
        Next

        Me.RadDropDownList1.DataSource = tabl
        Me.RadDropDownList1.SelectedIndex = 4

        Me.LoadSettings()


        'AddHandler bwExport.DoWork, New DoWorkEventHandler(AddressOf bwExport_DoWrok)
        'AddHandler bwExport.RunWorkerCompleted, New RunWorkerCompletedEventHandler(AddressOf bwExport_RunWorkerCompleted)

        AddHandler Me.Timer1.Tick, New EventHandler(AddressOf Me.Timer1_Tick)
    End Sub

    Private Function WriteSetting(ByVal forceSave As Boolean) As Boolean
        Try
            If Me.StopWrite Then
                Return False
            End If
            If forceSave Then
                File.WriteAllText(Me.KoneksiSettingFile, Me.txSettingKoneksi.Text.Trim())
                mdlstring.EncryptRansText(Me.KoneksiSettingFile, mdlstring.defaultKey)
            ElseIf File.Exists(Me.KoneksiSettingFile) Then
                File.WriteAllText(Me.KoneksiSettingFile, Me.txSettingKoneksi.Text.Trim())
                mdlstring.EncryptRansText(Me.KoneksiSettingFile, mdlstring.defaultKey)
            End If
            Return True
        Catch ex As Exception
            RadMessageBox.Show(("Gagal menyimpan Setting Koneksi String" &
                            Environment.NewLine & Environment.NewLine & ex.Message), "Invalid Directory", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return False
        End Try
    End Function

    Private Sub LoadSettings()
        Try
            mdlstring.DecryptRansText(Me.KoneksiSettingFile, mdlstring.defaultKey)
            If File.Exists(Me.KoneksiSettingFile) Then
                Me.txSettingKoneksi.Text = File.ReadAllText(Me.KoneksiSettingFile)
                Me.chAutoSave.Checked = True
            Else
                Me.chAutoSave.Checked = False
            End If
        Catch ex As Exception
            RadMessageBox.Show(("Gagal Load Setting File" &
                             Environment.NewLine & Environment.NewLine & ex.Message), "Invalid Directory", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub FormDataBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StopWrite = False
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim savedlg As New SaveFileDialog
        If (FormDataBackup.defaultFolder <> "") Then
            savedlg.InitialDirectory = FormDataBackup.defaultFolder
        End If
        savedlg.Filter = "*.sql|*.sql|*.*|*.*"
        savedlg.FileName = ("backup" & DateTime.Now.ToString("dd-MMM-yyyy@HH-mm-ss") & ".sql")
        If (DialogResult.OK = savedlg.ShowDialog) Then
            Me.txPath.Text = savedlg.FileName
            FormDataBackup.defaultFolder = Path.GetDirectoryName(txPath.Text.Trim())
        End If
    End Sub

    Private Shared Function TargetDirectoryIsValid() As Boolean
        Try
            Dim directoryName As String = Path.GetDirectoryName(FormDataBackup.targetFile)
            If Not IO.Directory.Exists(directoryName) Then
                Directory.CreateDirectory(directoryName)
            End If
            Return True
        Catch exception As Exception
            RadMessageBox.Show(("File Path yang di tentukan tidak valid. Tekan [Select SQL] untuk menentukan file sql." &
                             Environment.NewLine & Environment.NewLine & exception.Message), "Invalid Directory", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return False
        End Try
    End Function

    Private Shared Function SourceFileExists() As Boolean
        If Not IO.File.Exists(FormDataBackup.targetFile) Then
            MessageBox.Show(("File is not exists. Press [Select File] to choose a SQL Dump file." & Environment.NewLine & Environment.NewLine & FormDataBackup.targetFile), "Import", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return False
        End If
        Return True
    End Function

    Private Sub btnSelectSQL_Click(sender As Object, e As EventArgs) Handles btnSelectSQL.Click
        Dim dlg As New OpenFileDialog
        If (FormDataBackup.defaultFolder <> "") Then
            dlg.InitialDirectory = FormDataBackup.defaultFolder
        End If
        If (DialogResult.OK = dlg.ShowDialog) Then
            Me.txPath.Text = dlg.FileName
            FormDataBackup.defaultFolder = IO.Path.GetDirectoryName(Me.txPath.Text)
        End If
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        If FormDataBackup.TargetDirectoryIsValid Then
            Me._currentTableName = ""
            Me._totalRowsInCurrentTable = 0
            Me._totalRowsInAllTables = 0
            Me._currentRowIndexInCurrentTable = 0
            Me._currentRowIndexInAllTable = 0
            Me._totalTables = 0
            Me._currentTableIndex = 0
            Me.conns = New MySqlConnection(FormDataBackup.ConnectionsqlString)
            Me.cmd = New MySqlCommand
            Me.cmd.Connection = Me.conns
            Me.conns.Open()
            Me.Timer1.Start()
            Me.mb.ExportInfo.IntervalForProgressReport = 50
            Me.mb.Command = Me.cmd
            Me.bwExport.RunWorkerAsync()

            'Try
            '    Using Koneksi As MySqlConnection = New MySqlConnection(FormDataBackup.ConnectionsqlString)
            '        Using command As MySqlCommand = New MySqlCommand
            '            command.Connection = Koneksi
            '            Koneksi.Open()
            '            Using backup As MySqlBackup = New MySqlBackup(command)
            '                backup.ExportInfo.AddCreateDatabase = Me.chCreatedb.Checked
            '                backup.ExportInfo.ExportTableStructure = Me.chDropCreate.Checked
            '                backup.ExportInfo.ExportRows = Me.chExportRows.Checked
            '                backup.ExportInfo.RecordDumpTime = Me.chDumpTime.Checked
            '                backup.ExportInfo.ResetAutoIncrement = Me.chResetIncrement.Checked
            '                backup.ExportInfo.EnableEncryption = Me.chEncryption.Checked
            '                backup.ExportInfo.EncryptionPassword = Me.txEncryptPass.Text.Trim()
            '                backup.ExportInfo.MaxSqlLength = CInt(Me.numericSQL.Value)
            '                backup.ExportInfo.ExportFunctions = Me.chExportProcedureFunct.Checked
            '                backup.ExportInfo.ExportProcedures = Me.chExportProcedureFunct.Checked
            '                backup.ExportInfo.ExportTriggers = Me.chExportProcedureFunct.Checked
            '                backup.ExportInfo.ExportEvents = Me.chExportProcedureFunct.Checked
            '                backup.ExportInfo.ExportViews = Me.chExportProcedureFunct.Checked
            '                backup.ExportInfo.ExportRoutinesWithoutDefiner = Me.chWrapExportMode.Checked
            '                backup.ExportInfo.RowsExportMode = DirectCast(Me.RadDropDownList1.SelectedValue, RowsDataExportMode)
            '                backup.ExportInfo.WrapWithinTransaction = Me.chWrapExportMode.Checked
            '                'backup.ExportToFile(FormDataBackup.targetFile)
            '            End Using
            '            Koneksi.Close()
            '        End Using
            '    End Using
            '    RadMessageBox.Show(("Sukses Dump database, tersimpan pada:" & vbNewLine & "" & FormDataBackup.targetFile), "Informasi", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1)
            'Catch ex As Exception
            '    RadMessageBox.Show(ex.Message, "Error Backup Database", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1)
            'End Try
        End If
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        If (FormDataBackup.SourceFileExists) Then
            Dim lastError As Exception = Nothing
            Try
                Using Koneksi As MySqlConnection = New MySqlConnection(FormDataBackup.ConnectionsqlString)
                    Using Command As MySqlCommand = New MySqlCommand
                        Command.Connection = Koneksi
                        Using Restore As MySqlBackup = New MySqlBackup(Command)
                            Restore.ImportInfo.EnableEncryption = Me.chDecryption.Checked
                            Restore.ImportInfo.EncryptionPassword = Me.txDecryptPass.Text.Trim()
                            Restore.ImportInfo.IgnoreSqlError = Me.chIgnoreError.Checked
                            Restore.ImportInfo.TargetDatabase = Me.txTargetDb.Text.Trim()
                            Restore.ImportInfo.ErrorLogFile = Me.txErrLogPath.Text.Trim()
                            Restore.ImportFromFile(FormDataBackup.targetFile)
                            lastError = Restore.LastError
                        End Using
                    End Using
                End Using
                If (lastError Is Nothing) Then
                    RadMessageBox.Show("Sukses Import Database.", "Import/Restore Database", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1)
                Else
                    RadMessageBox.Show("Sukses Import Database, terdapat Error." & vbNewLine &
                                       lastError.ToString, "Import/Restore Database", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1)
                End If
            Catch ex As Exception
                RadMessageBox.Show(ex.Message, "Error Import/Restore", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1)
            End Try
        End If
    End Sub

    Private Sub btnSaveLog_Click(sender As Object, e As EventArgs) Handles btnSaveLog.Click
        Dim dialog As New SaveFileDialog With {
            .Filter = "txt|*.txt|*.*|*.*",
            .Title = "Save log File", .FileName = "Restore Error Log.txt"}
        If (dialog.ShowDialog = System.Windows.Forms.DialogResult.OK) Then
            Me.txErrLogPath.Text = dialog.FileName
        End If
    End Sub

    Private Sub chAutoSave_CheckStateChanged(sender As Object, e As EventArgs) Handles chAutoSave.CheckStateChanged
        If Not Me.StopWrite Then
            If Me.chAutoSave.Checked Then

                If Me.WriteSetting(True) Then
                    RadMessageBox.Show((String.Concat(New String() {
                                                  "Automatic save enabled.",
                                                  Environment.NewLine,
                                                  "Connection String saved at",
                                                  Environment.NewLine, Environment.NewLine,
                                                  Me.KoneksiSettingFile})),
                                      "Saving Connection String", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1)
                End If
            Else
                Try
                    File.Delete(Me.KoneksiSettingFile)
                Catch ex As Exception
                    RadMessageBox.Show(ex.Message, "Error Delete", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1)
                End Try
            End If
        End If
    End Sub

    Private Sub txSettingKoneksi_TextChanged(sender As Object, e As EventArgs) Handles txSettingKoneksi.TextChanged
        FormDataBackup.ConnectionsqlString = Me.txSettingKoneksi.Text.Trim()
        Me.WriteSetting(False)
    End Sub

    Private Shared _connString As String
    Private Shared Property ConnectionsqlString As String
        Get
            If String.IsNullOrEmpty(_connString) Then
                Throw New Exception("Koneksi string empty.!")
            End If
            Return _connString
        End Get
        Set(value As String)
            _connString = value
        End Set
    End Property

    Private Sub txPath_TextChanged(sender As Object, e As EventArgs) Handles txPath.TextChanged
        FormDataBackup.targetFile = Me.txPath.Text
    End Sub

    Private _currentRowIndexInAllTable As Integer
    Private _currentRowIndexInCurrentTable As Integer
    Private _currentTableIndex As Integer
    Private _currentTableName As String
    Private _totalRowsInAllTables As Integer
    Private _totalRowsInCurrentTable As Integer
    Private _totalTables As Integer
    Private cancel As Boolean
    Private cmd As MySqlCommand
    Private conns As MySqlConnection
    Private mb As MySqlBackup
    'Private bwExport As BackgroundWorker

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.cancel Then
            Me.Timer1.Stop()
        Else

            Me.pbtable.Maximum = Me._totalTables
            If (Me._currentTableIndex <= Me.pbtable.Maximum) Then
                Me.pbtable.Value1 = Me._currentTableIndex
            End If
            Me.pbRowInCurTable.Maximum = Me._totalRowsInCurrentTable
            If (Me._currentRowIndexInCurrentTable <= Me.pbRowInCurTable.Maximum) Then
                Me.pbRowInCurTable.Value1 = Me._currentRowIndexInCurrentTable
            End If
            Me.pbRowInAllTable.Maximum = Me._totalRowsInAllTables
            Me.pbRowInAllTable.Maximum = Me._totalRowsInAllTables
            If (Me._currentRowIndexInAllTable <= Me.pbRowInAllTable.Maximum) Then
                Me.pbRowInAllTable.Value1 = Me._currentRowIndexInAllTable
            End If

            Me.lbCurrentTableName.Text = ("")
            Me.lbCurrentTableName.Text = ("Current Processing Table = " & Me._currentTableName)
            Me.pbRowInCurTable.Text = (Me.pbRowInCurTable.Value1 & " of " & Me.pbRowInCurTable.Maximum)
            Me.pbRowInAllTable.Text = (Me.pbRowInAllTable.Value1 & " of " & Me.pbRowInAllTable.Maximum)
            Me.pbtable.Text = (Me._currentTableIndex & " of " & Me._totalTables)
            Me.lbTotalRows_Tables.Text = (Me._totalTables & ChrW(13) & ChrW(10) & Me._totalRowsInAllTables)
        End If

    End Sub

    Private Sub CloseKoneksi()
        If (Not Me.conns Is Nothing) Then
            Me.conns.Close()
            Me.conns.Dispose()
        End If
        If (Not Me.cmd Is Nothing) Then
            Me.cmd.Dispose()
        End If
    End Sub

    Private Sub bwExport_DoWrok(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles bwExport.DoWork
        Try

            Me.mb.ExportInfo.AddCreateDatabase = Me.chCreatedb.Checked
            Me.mb.ExportInfo.ExportTableStructure = Me.chDropCreate.Checked
            Me.mb.ExportInfo.ExportRows = Me.chExportRows.Checked
            Me.mb.ExportInfo.RecordDumpTime = Me.chDumpTime.Checked
            Me.mb.ExportInfo.ResetAutoIncrement = Me.chResetIncrement.Checked
            Me.mb.ExportInfo.EnableEncryption = Me.chEncryption.Checked
            Me.mb.ExportInfo.EncryptionPassword = Me.txEncryptPass.Text.Trim()
            Me.mb.ExportInfo.MaxSqlLength = CInt(Me.numericSQL.Value)
            Me.mb.ExportInfo.ExportFunctions = Me.chExportProcedureFunct.Checked
            Me.mb.ExportInfo.ExportProcedures = Me.chExportProcedureFunct.Checked
            Me.mb.ExportInfo.ExportTriggers = Me.chExportProcedureFunct.Checked
            Me.mb.ExportInfo.ExportEvents = Me.chExportProcedureFunct.Checked
            Me.mb.ExportInfo.ExportViews = Me.chExportProcedureFunct.Checked
            Me.mb.ExportInfo.ExportRoutinesWithoutDefiner = Me.chWrapExportMode.Checked
            Me.mb.ExportInfo.RowsExportMode = DirectCast(Me.RadDropDownList1.SelectedValue, RowsDataExportMode)
            Me.mb.ExportInfo.WrapWithinTransaction = Me.chWrapExportMode.Checked
            Me.mb.ExportToFile(FormDataBackup.targetFile)
        Catch ex As Exception
            Me.CloseKoneksi()
            RadMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub bwExport_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles bwExport.RunWorkerCompleted
        Me.CloseKoneksi()
        If Me.cancel Then
            RadMessageBox.Show("Proses dibatalkan oleh user.", "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1)
        ElseIf (Me.mb.LastError Is Nothing) Then
            Me.pbRowInAllTable.Value1 = Me.pbRowInAllTable.Maximum
            Me.pbRowInCurTable.Value1 = Me.pbRowInCurTable.Maximum
            Me.pbtable.Value1 = Me.pbtable.Maximum
            Me.pbRowInCurTable.Text = (Me.pbRowInCurTable.Value1 & " of " & Me.pbRowInCurTable.Maximum)
            Me.pbRowInAllTable.Text = (Me.pbRowInAllTable.Value1 & " of " & Me.pbRowInAllTable.Maximum)
            Me.pbtable.Text = (Me._currentTableIndex & " of " & Me._totalTables)
            Me.Refresh()
            RadMessageBox.Show(("Sukses Dump database, tersimpan pada:" & vbNewLine & "" & FormDataBackup.targetFile), "Informasi",
                               MessageBoxButtons.OK, RadMessageIcon.Info,
                               MessageBoxDefaultButton.Button1)
        Else
            RadMessageBox.Show(("Sukses Dump database dengan error(s). " & Environment.NewLine & Environment.NewLine & Me.mb.LastError.ToString), "Perhatian",
                               MessageBoxButtons.OK, RadMessageIcon.Exclamation,
                               MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Public Event ExecuteProgress As MySqlBackup.exportProgressChange

    Private Sub mb_ExportProgressChange(ByVal sender As Object, ByVal e As ExportProgressArgs)

        If Me.cancel Then
            Me.mb.StopAllProcess()
        Else

            Me._currentRowIndexInAllTable = CInt(e.CurrentRowIndexInAllTables)
            Me._currentRowIndexInCurrentTable = CInt(e.CurrentRowIndexInCurrentTable)
            Me._currentTableIndex = e.CurrentTableIndex
            Me._currentTableName = e.CurrentTableName
            Me._totalRowsInAllTables = CInt(e.TotalRowsInAllTables)
            Me._totalRowsInCurrentTable = CInt(e.TotalRowsInCurrentTable)
            Me._totalTables = e.TotalTables
        End If
    End Sub


End Class