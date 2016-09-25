Imports Splash.Konektor.mdlCom
Imports MySql.Data.MySqlClient
Imports System.IO, Microsoft.VisualBasic.CompilerServices
Imports Setting.Config.Profile
Imports System.Windows.Forms
Imports Telerik, Telerik.WinControls, Telerik.WinControls.UI
Imports Splash.Konektor

Public Class rFormDatabaseSetup

    Public Sub New()

        InitializeComponent()

        Telerik.WinControls.RadMessageBox.Instance.AllowTheming = True
        Telerik.WinControls.RadMessageBox.Instance.ControlBox = False
        Telerik.WinControls.RadMessageBox.ShowInTaskbar = False
        Telerik.WinControls.RadMessageBox.ThemeName = rFormMain.Office2010BlackTheme1.ThemeName
        rFormMain.SetTheme(Me, rFormMain.Office2010BlackTheme1.ThemeName.ToString)

    End Sub

    'Dim settingaplikasi As New Setting.IniFile(My.Application.Info.DirectoryPath & "\Config.ini")
    'Dim configFile As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim flag As Boolean = mdlCom.CekKoneksiSql
        If flag = True Then
            RadMessageBox.Show("Koneksi ke database Sukses." & vbNewLine &
                                "Informasi Koneksi :" & vbNewLine &
                                "Server: " & mdlCom.uhost & vbNewLine &
                                "Database: " & mdlCom.cDbname,
                                "Database Connection", MessageBoxButtons.OK, RadMessageIcon.Info)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Me.SelectedProfile.SetValue(cbSection.Text, "ConnectionName", txConStr.Text.Trim())
            Me.SelectedProfile.SetValue(cbSection.Text, "DatabaseName", txdbname.Text.Trim())
            Me.SelectedProfile.SetValue(cbSection.Text, "Server", txHost.Text.Trim())
            Me.SelectedProfile.SetValue(cbSection.Text, "User", txUser.Text.Trim())
            Me.SelectedProfile.SetValue(cbSection.Text, "Port", txPort.Text.Trim())
            Dim convertPassword As String = CodeLibs.CodeMethod.Encrypt_TRIPLEDES(txPass.Text.Trim(), mdlstring.defaultKey)
            Me.SelectedProfile.SetValue(cbSection.Text, "Password", convertPassword)
            Me.SelectedProfile.SetValue("General", "BackupLocation", txBackupFolderPath.Text.Trim())

            If RadCheckBox1.Checked Then
                Me.SelectedProfile.SetValue("General", "defaultsetting", RadCheckBox1.Checked)
                Me.SelectedProfile.SetValue("General", "SettingName", cbSection.SelectedIndex)
                Me.SelectedProfile.SetValue("General", "SectionName", cbSection.Text)
                Me.SelectedProfile.SetValue("General", "BackupLocation", txBackupFolderPath.Text.Trim())
            End If

            RadMessageBox.Show("Setting database berhasil disimpan", "Save Database Information", MessageBoxButtons.OK, RadMessageIcon.Info)
        Catch ex As Exception
            RadMessageBox.Show("(failed save_setting)" & ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Private Sub ReadConfig()
        Dim tempPass As String = Me.SelectedProfile.GetValue(Me.cbSection.SelectedItem.Text, "Password")

        Dim ImportPassword As String = CodeLibs.CodeMethod.Decrypt_TRIPLEDES(tempPass, mdlstring.defaultKey)

        txConStr.Text = Me.SelectedProfile.GetValue(Me.cbSection.SelectedItem.Text, "ConnectionName")
        txdbname.Text = Me.SelectedProfile.GetValue(Me.cbSection.SelectedItem.Text, "DatabaseName")
        txHost.Text = Me.SelectedProfile.GetValue(Me.cbSection.SelectedItem.Text, "Server")
        txUser.Text = Me.SelectedProfile.GetValue(Me.cbSection.SelectedItem.Text, "User")
        'txPass.Text = Me.SelectedProfile.GetValue(Me.cbSection.SelectedItem.Text, "Password")
        txPass.Text = ImportPassword
        txBackupFolderPath.Text = Me.SelectedProfile.GetValue("General", "BackupLocation")

    End Sub

    Private Sub rFormDatabaseSetup_Load(sender As Object, e As EventArgs) Handles Me.Load
        rFormMain.SetTheme(Me, rFormMain.Office2010BlackTheme1.ThemeName.ToString)
        rFormMain.UserSettingIcon(True, Me)
        Try

            If Not (IO.File.Exists(IO.Path.Combine(Environment.CurrentDirectory, "backup", "backup.sql"))) Then

                IO.Directory.CreateDirectory(IO.Path.Combine(Environment.CurrentDirectory, "backup"))

                Dim FilePath As String = IO.Path.GetFullPath(IO.Path.Combine(Environment.CurrentDirectory, "backup", "backup.sql"))

                rFormMain.SaveResource("backup.sql", FilePath)

            End If

        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim Excep As Exception = ex
            mdlCom.ShowError("Error." & Excep.Message)
            ProjectData.ClearProjectError()
        End Try

        Me.RadPageView1.SelectedPage = RadPageView1.Pages.Item(0)

        Me.MProfiles = New Setting.Config.Profile.Profile(1 - 1) {}

        Me.MProfiles(0) = New Setting.Config.Profile.Ini()

        cbProfile.Items.Add("INI--" & Me.MProfiles(0).Name)

        rFormDatabaseSetup.StrProfile = 0

        Dim strpro As String = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile
        Dim nFile As New FileInfo(strpro)
        Dim strname As String = nFile.FullName
        Dim strParent As String = Directory.GetParent(strpro).Name
        Dim strRep As String = Strings.Replace(strname, nFile.DirectoryName.ToString, "")
        Me.Text = String.Concat(New String() {strParent, strRep.Substring(0, strRep.LastIndexOf("."c)), ".ini"})

        cbProfile.SelectedIndex = 0

        Dim strBool As String = Me.SelectedProfile.GetValue("General", "defaultsetting")
        RadCheckBox1.Checked = Conversions.ToBoolean(strBool)
        cbSection.SelectedIndex = Me.SelectedProfile.GetValue("General", "SettingName")
        Me.txBackupFolderPath.Text = Me.SelectedProfile.GetValue("General", "BackupLocation")
        UpdateSettings()

    End Sub

    Private MProfiles As Setting.Config.Profile.Profile()
    Public Shared StrProfile As Integer

    Private ReadOnly Property SelectedProfile As Setting.Config.Profile.Profile
        Get
            Return Me.MProfiles(Me.cbProfile.SelectedIndex)
        End Get
    End Property

    Private Sub UpdateSettings()
        Dim flag As Boolean = (Me.cbSection.Text <> "")
        Dim flag2 As Boolean = (flag AndAlso Me.SelectedProfile.HasSection(Me.cbSection.Text))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Dispose()
    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles cbDropDbFile.Click
        cbDropDbFile.ShowDropDown()
    End Sub

    Private Sub SetEnv()
        Try
            Dim envSqlDumpName As String = "sql_Dir"
            Dim envBackupName As String = "splash_backup_path"
            Dim envSqlDumpValue As String = My.Application.Info.DirectoryPath & "\Libs\"
            Dim envBackupPathValue As String = txBackupFolderPath.Text.Trim() & "\"

            If (Environment.GetEnvironmentVariable(envSqlDumpName, EnvironmentVariableTarget.User) IsNot (envSqlDumpValue)) Then
                Environment.SetEnvironmentVariable(envSqlDumpName, envSqlDumpValue, EnvironmentVariableTarget.User)
            Else
                Environment.SetEnvironmentVariable(envSqlDumpName, envSqlDumpValue, EnvironmentVariableTarget.User)
            End If
            If (Environment.GetEnvironmentVariable(envBackupName, EnvironmentVariableTarget.User) IsNot (envBackupPathValue)) Then
                Environment.SetEnvironmentVariable(envBackupName, envBackupPathValue, EnvironmentVariableTarget.User)
            Else
                Environment.SetEnvironmentVariable(envBackupName, envBackupPathValue, EnvironmentVariableTarget.User)
            End If
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim Excep As Exception = ex
            mdlCom.ShowError("Error." & Excep.Message)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub BuatBackupdatabase()

        Dim strbackupdir As String = Environment.GetEnvironmentVariable("splash_backup_path", EnvironmentVariableTarget.User)
        Dim strWorkdir As String = Environment.GetEnvironmentVariable("sql_Dir", EnvironmentVariableTarget.User)

        Using myProcess As New Process()
            Dim newfiledb As String = strbackupdir & Format(Now(), "dd-MMM-yyyy@HH-mm-ss").ToString & "_local.sql"
            Try
                myProcess.StartInfo.FileName = "mysqldumpx86.exe"
                myProcess.StartInfo.WorkingDirectory = strWorkdir
                myProcess.StartInfo.Arguments = "--host=" & mdlCom.uhost & " --user=" & mdlCom.cName & " --password=" & mdlCom.cPass & " " & mdlCom.cDbname & " -r " & newfiledb
                myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                myProcess.Start()
                myProcess.WaitForExit()

                RadMessageBox.Show("Sukses membackup database." & vbNewLine & newfiledb &
                               vbNewLine & "Pada:" & vbNewLine &
                               "Server: " & mdlCom.uhost & vbNewLine &
                                 vbNewLine & "Database: " & cbDropDbFile.Text.Trim(), "Backup Database", MessageBoxButtons.OK, RadMessageIcon.Info)

            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                mdlCom.INSERTLOG(ex.Message, "")
                RadMessageBox.Show("Error." & ex.Source & newfiledb, "ERROR", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message)
                ProjectData.ClearProjectError()
            Finally
                myProcess.Close()
            End Try
        End Using
    End Sub

    Private Sub Restordatabase()
        Dim strbackupdir As String = Environment.GetEnvironmentVariable("splash_backup_path", EnvironmentVariableTarget.User)
        Dim strWorkdir As String = Environment.GetEnvironmentVariable("sql_Dir", EnvironmentVariableTarget.User)
        Dim OpenFile As New OpenFileDialog
        OpenFile.Filter = ""
        OpenFile.Title = "Pilih Database"
        OpenFile.RestoreDirectory = True
        OpenFile.Multiselect = False
        OpenFile.InitialDirectory = My.Application.Info.DirectoryPath & "\backups\"
        Dim newfiledb As String

        If OpenFile.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            newfiledb = OpenFile.FileName
            Environment.SetEnvironmentVariable("sql_Res", newfiledb, EnvironmentVariableTarget.User)
        End If

        Using myProcess As New Process()
            'Dim newfiledb As String = strbackupdir & Format(Now(), "dd-MMM-yyyy@HH-mm-ss").ToString & "_local.sql"
            Dim getEnvFile As String = Environment.GetEnvironmentVariable("sql_Res", EnvironmentVariableTarget.User)
            Try
                myProcess.StartInfo.FileName = "mysqldumpx86.exe"
                myProcess.StartInfo.WorkingDirectory = strWorkdir
                myProcess.StartInfo.Arguments = "--user=" & mdlCom.cName & "--password=" & mdlCom.cPass & " -h" & mdlCom.uhost & " " & mdlCom.cDbname & " < """ & getEnvFile & """"
                myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                myProcess.Start()
                myProcess.WaitForExit()

                RadMessageBox.Show("Restore database sukses." & vbNewLine & getEnvFile &
                                   vbNewLine & "Pada:" & vbNewLine _
                                   & "Server: " & mdlCom.uhost & vbNewLine &
                                   "Database: " & cbDropDbFile.Text.Trim(), "Restore Database", MessageBoxButtons.OK, RadMessageIcon.Info)

            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                mdlCom.INSERTLOG(ex.Message, "")
                RadMessageBox.Show("Error." & ex.Source, "ERROR", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message)
                ProjectData.ClearProjectError()
            Finally
                myProcess.Close()
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        If Directory.Exists(txBackupFolderPath.Text) Then
            If cbDropDbFile.SelectedIndex < 0 Then
                RadMessageBox.Show("Pilih database pada dropdown!", "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            End If
            SetEnv()
            BuatBackupdatabase()
        Else
            RadMessageBox.Show("Direktori?", "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Return
        End If
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        Restordatabase()
    End Sub

    Private Sub cbDropDbFile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDropDbFile.SelectedIndexChanged
        listTbl.Items.Clear()
        If cbDropDbFile.Text <> "" Then
            mdlCom.BukaKoneksi()
            Dim sqlCmdTable As New MySqlCommand("SHOW TABLES", mdlCom.vConn)
            Dim drTables As MySqlDataReader
            drTables = sqlCmdTable.ExecuteReader
            Do While drTables.Read
                listTbl.Items.Add(drTables.GetString(0))
            Loop
        End If
    End Sub

    Private Sub cbProfile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProfile.SelectedIndexChanged
        Me.cbSection.Items.Clear()
        If (Not sender Is Nothing) Then
            cbSection.Text = ""
        End If
        Try
            Dim SecNames As String() = Me.SelectedProfile.GetSectionNames
            If (Not SecNames Is Nothing) Then
                Me.cbSection.Items.AddRange(SecNames)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub cbSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSection.SelectedIndexChanged
        Try
            txConStr.Text = Me.SelectedProfile.GetValue(Me.cbSection.SelectedItem.Text, "ConnectionName")
            txdbname.Text = Me.SelectedProfile.GetValue(Me.cbSection.SelectedItem.Text, "DatabaseName")
            txHost.Text = Me.SelectedProfile.GetValue(Me.cbSection.SelectedItem.Text, "Server")
            txUser.Text = Me.SelectedProfile.GetValue(Me.cbSection.SelectedItem.Text, "User")
            Dim tempPass As String = Me.SelectedProfile.GetValue(Me.cbSection.SelectedItem.Text, "Password")

            Dim ImportPassword As String = CodeLibs.CodeMethod.Decrypt_TRIPLEDES(tempPass, mdlstring.defaultKey)

            'txPass.Text = Me.SelectedProfile.GetValue(Me.cbSection.SelectedItem.Text, "Password")
            txPass.Text = ImportPassword
            txBackupFolderPath.Text = Me.SelectedProfile.GetValue("General", "BackupLocation")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub RadPageView1_SelectedPageChanging(sender As Object, e As RadPageViewCancelEventArgs) Handles RadPageView1.SelectedPageChanging
        If e.Page Is RadPageViewPage2 Then
            Try
                mdlCom.BukaKoneksi()
                Dim command As String
                Dim tblCount As Integer
                command = "Select Distinct Table_Schema From information_schema.tables"
                Dim adapter As MySqlDataAdapter
                adapter = New MySqlDataAdapter(command, mdlCom.vConn)
                Dim dt As New DataTable
                adapter.Fill(dt)
                tblCount = 0
                cbDropDbFile.Items.Clear()
                While tblCount < dt.Rows.Count
                    cbDropDbFile.Items.Add(dt.Rows(tblCount)(0).ToString)
                    Threading.Interlocked.Increment(tblCount)
                End While
                'cbDropDbFile.SelectedIndex = 0
                mdlCom.vConn.Close()
                dt.Dispose()
                adapter.Dispose()
            Catch ex As Exception
                RadMessageBox.Show("Error. " & ex.Message, "Collecting Database", MessageBoxButtons.OK, RadMessageIcon.Error)
            End Try
        End If
    End Sub

    Private Sub RadToggleSwitch1_ValueChanged(sender As Object, e As EventArgs) Handles RadToggleSwitch1.ValueChanged
        If RadToggleSwitch1.Value = True Then
            txPass.UseSystemPasswordChar = True
        Else
            txPass.UseSystemPasswordChar = False
            txPass.PasswordChar = ""
        End If
    End Sub

    Private Sub btnSetFolder_Click(sender As Object, e As EventArgs) Handles btnSetFolder.Click
        Dim nOFDialog As New FolderBrowserDialog
        nOFDialog.Description = "Pilih Folder backup"
        nOFDialog.ShowNewFolderButton = True

        If nOFDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            txBackupFolderPath.Text = nOFDialog.SelectedPath
        End If

    End Sub

    Private Sub btnNewBackupSystem_Click(sender As Object, e As EventArgs) Handles btnNewBackupSystem.Click
        rFormMain.BukaFormChild(FormDataBackup)
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        If Not mdlCom.UserLogin <> "Administrator" Then
            RadMessageBox.Show("Anda Tidak Berhak Mengakses Menu ini.", "Akses", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1)
        Else
            Dim EncForm As New CodeLibs.FrmEncryptDecrypt
            EncForm.MdiParent = rFormMain
            EncForm.Show()
        End If
    End Sub
End Class
