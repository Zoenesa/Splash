Imports MySql.Data.MySqlClient, Microsoft.VisualBasic.CompilerServices
Imports System.Windows.Forms
Imports Telerik, Telerik.WinControls, Telerik.WinControls.UI
Imports Splash.Konektor.stringSQL

Namespace Splash.Konektor

    Public NotInheritable Class mdlSQL

        Public Shared isDev As Boolean
        Private Shared logpath As String = My.Application.Info.DirectoryPath & "\LogsError"
        Public Shared vConn As MySqlConnection
        Public Shared DbFile As String
        Public Shared UserRole As String
        Public Shared V_Role As String() = New String(11 - 1) {}
        Public Shared UserLogin As String
        Public Shared GrantAccess As String
        Public Shared UserFName As String
        Public Shared UserLName As String
        Public Shared UserJobTitle As String
        Public Shared TempAkses As String
        Public Shared JobDesk As String
        Public Shared IsLogin As Boolean = False
        Public Shared ProfileName As String
        Public Shared ProfileIdTax As String
        Public Shared ProfileState As String
        Public Shared ProfileCity As String

        Public Shared uhost As String
        Public Shared cName As String
        Public Shared cPort As String
        Public Shared cPass As String
        Public Shared cDbname As String

        Public Shared DefaultFolderName As String

        Shared Sub New()
            mdlSQL.isDev = False
            mdlSQL.IsLogin = False
            mdlSQL.V_Role = New String(11 - 1) {}
            mdlSQL.DefaultFolderName = ""
            mdlSQL.targetFile = ""
        End Sub

        Public Sub New()

            Telerik.WinControls.RadMessageBox.Instance.AllowTheming = True
            RadMessageBox.Instance.ControlBox = False
            RadMessageBox.Instance.ThemeName = office2010BlackTheme1.ThemeName
            RadMessageBox.Instance.ShowInTaskbar = False
            RadMessageBox.Instance.StartPosition = FormStartPosition.CenterScreen
        End Sub

        Public Shared WithEvents office2010BlackTheme1 As Telerik.WinControls.Themes.Office2010BlackTheme

        Public Shared Function KoneksiString() As String
            Dim str As String = Nothing
            Dim strConn As String
            Dim tempPass As String = cPass.Trim() '.CodeMethod.Encrypt_TRIPLEDES(cPass.Trim(), mdlstring.defaultKey)
            strConn = "server=" & uhost.Trim() &
            ";userid=" & cName.Trim() &
            ";password=" & cPass.Trim() &
            ";Database=" & cDbname.Trim() &
            ";port=" & cPort.Trim() & ";"
            If mdlSQL.vConn Is Nothing Then
                mdlSQL.vConn = New MySqlConnection()
                mdlSQL.vConn.ConnectionString = strConn
            End If
            If mdlSQL.vConn.State <> ConnectionState.Open Then
                mdlSQL.vConn.ConnectionString = strConn
                vConn.Open()
            ElseIf mdlSQL.vConn.State = ConnectionState.Open Then
                mdlSQL.vConn.Close()
                mdlSQL.vConn.ConnectionString = strConn
                mdlSQL.vConn.Open()
            End If
            str = strConn
            Return str
        End Function

        Public Shared Function CekKoneksiSql() As Boolean
            Dim flag As Boolean = False
            Try
                Dim strConn As String
                Dim tempPass As String = cPass.Trim() '.CodeMethod.Encrypt_TRIPLEDES(cPass.Trim(), mdlstring.defaultKey)
                strConn = "server=" & uhost.Trim() &
                ";userid=" & cName.Trim() &
                ";password=" & cPass.Trim() &
                ";Database=" & cDbname.Trim() &
                ";port=" & cPort.Trim() & ";"
                If mdlSQL.vConn Is Nothing Then
                    mdlSQL.vConn = New MySqlConnection()
                    mdlSQL.vConn.ConnectionString = strConn
                End If
                If mdlSQL.vConn.State <> ConnectionState.Open Then
                    mdlSQL.vConn.ConnectionString = strConn
                    vConn.Open()
                    Return True
                ElseIf mdlSQL.vConn.State = ConnectionState.Open Then
                    mdlSQL.vConn.Close()
                    mdlSQL.vConn.ConnectionString = strConn
                    mdlSQL.vConn.Open()
                    Return True
                End If
            Catch ex As Exception
                flag = False
                RadMessageBox.Show("Connection Failed, " &
                            ex.Message, "Database Connection",
                            MessageBoxButtons.OK, RadMessageIcon.Error)
            End Try
            Return flag
        End Function

        Public Shared Sub BukaKoneksi()
            Try
                Dim strConn As String
                Dim tempPass As String = cPass.Trim() '.CodeMethod.Encrypt_TRIPLEDES(cPass.Trim(), mdlstring.defaultKey)
                strConn = "server=" & uhost.Trim() &
                ";userid=" & cName.Trim() &
                ";password=" & tempPass.Trim() &
                ";Database=" & cDbname.Trim() &
                ";port=" & cPort.Trim() & ";"
                If mdlSQL.vConn Is Nothing Then
                    mdlSQL.vConn = New MySqlConnection()
                    mdlSQL.vConn.ConnectionString = strConn
                End If
                If mdlSQL.vConn.State <> ConnectionState.Open Then
                    mdlSQL.vConn.ConnectionString = strConn
                    vConn.Open()
                ElseIf mdlSQL.vConn.State = ConnectionState.Open Then
                    mdlSQL.vConn.Close()
                    mdlSQL.vConn.ConnectionString = strConn
                    mdlSQL.vConn.Open()
                End If
            Catch ex As Exception
                RadMessageBox.Show("error at, " & ex.Message,
                            "Database Connection",
                            MessageBoxButtons.OK,
                            RadMessageIcon.Error)
            End Try
        End Sub

        Public Shared Function ConnectDb(ByRef errMsg As String) As Boolean
            Dim flag1 As Boolean = True
            Dim flag2 As Boolean
            Try
                Dim strConn As String
                Dim tempPass As String = cPass.Trim() '.CodeMethod.Encrypt_TRIPLEDES(cPass.Trim(), mdlstring.defaultKey)
                strConn = "server=" & uhost.Trim() &
                ";userid=" & cName.Trim() &
                ";password=" & cPass.Trim() &
                ";Database=" & cDbname.Trim() &
                ";port=" & cPort.Trim() & ";"
                If mdlSQL.vConn Is Nothing Then
                    mdlSQL.vConn = New MySqlConnection()
                    mdlSQL.vConn.ConnectionString = strConn
                End If
                If mdlSQL.vConn.State <> ConnectionState.Open Then
                    mdlSQL.vConn.ConnectionString = strConn
                    vConn.Open()
                ElseIf mdlSQL.vConn.State = ConnectionState.Open Then
                    mdlSQL.vConn.Close()
                    mdlSQL.vConn.ConnectionString = strConn
                    mdlSQL.vConn.Open()
                End If
                Dim sqlcommand As New MySqlCommand("SELECT * FROM `datatemp`;", mdlSQL.vConn)
                Dim sqlreader As MySqlDataReader = sqlcommand.ExecuteReader()
                sqlreader.Read()
                sqlreader.Close()
                sqlcommand.CommandText = "SELECT `counter` FROM `patch` WHERE `ide` = '3'"
                Dim sqlreader2 As MySqlDataReader = sqlcommand.ExecuteReader()
                sqlreader2.Close()
                flag2 = flag1
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim excep As Exception = ex
                errMsg = "Tidak dapat tersambung ke database.Message: " & excep.Message
                mdlSQL.INSERTLOG(errMsg, "")
                flag2 = False
                ProjectData.ClearProjectError()
                Return flag2
                ProjectData.ClearProjectError()
            End Try
            Return flag2
        End Function

        Public Shared Function DataLogin(ByVal uname As String, upwd As String, ByRef retMsg As String, ByRef errMsg As String, Optional ByVal loginFromProfile As Boolean = False) As Boolean
            Dim flag1 As Boolean
            Try
                errMsg = "0"
                Dim sqlcommand As New MySqlCommand With {
             .Connection = mdlSQL.vConn,
             .CommandText = "SELECT `Password`, `UserRole`, `JobTitle`, `UserFname`, `kdgroup`, " &
             "`nip_user`, `Uaktif`, `JobDesk` FROM `user` WHERE `Username` = '" & stringSQL.ADD_QUOTE_ON_SQL(uname) & "'"}
                Dim sqlreader As MySqlDataReader = sqlcommand.ExecuteReader()
                Dim flag2 As Boolean
                If sqlreader.HasRows Then
                    sqlreader.Read()
                    If (sqlreader.Item(0).ToString = ADD_QUOTE_ON_SQL(upwd)) Or loginFromProfile Then
                        Dim num As Integer
                        mdlSQL.UserLogin = ADD_QUOTE_ON_SQL(uname)
                        mdlSQL.JobDesk = Conversions.ToString(sqlreader.Item("JobDesk"))
                        mdlSQL.UserRole = Conversions.ToString(sqlreader.Item("JobTitle"))
                        mdlSQL.UserFName = Conversions.ToString(sqlreader.Item("UserFname"))
                        If Operators.ConditionalCompareObjectEqual(sqlreader.Item("nip_user"), "000000000", False) Then
                            mdlSQL.V_Role(0) = Conversions.ToString(sqlreader.Item("kdgroup"))

                            Dim index As Integer = 1
                            Do
                                mdlSQL.V_Role(index) = Conversions.ToString(
                                Interaction.IIf(Operators.ConditionalCompareObjectEqual _
                                                (sqlreader.Item("kdgroup"), "01", False), "0", "1"))
                                index += 1
                                num = 9
                            Loop While (index <= num)
                        Else
                            Dim strArr As String() = Strings.Split(Conversions.ToString(sqlreader.Item("nip_user")),
                                                               ";", -1, CompareMethod.Binary)
                            Dim num1 As Integer = 0
                            Do
                                mdlSQL.V_Role(num1) = strArr(num1)
                                num1 += 1
                                num = 9
                            Loop While (num1 <= num)
                        End If
                        sqlreader.Close()
                        sqlcommand.CommandText = "SELECT * FROM `ref_profile`"
                        sqlreader = sqlcommand.ExecuteReader()
                        If sqlreader.HasRows Then
                            sqlreader.Read()
                            mdlSQL.ProfileName = Conversions.ToString(sqlreader.Item("NAMA_WP_PROFILE"))
                            mdlSQL.ProfileIdTax = Conversions.ToString(sqlreader.Item("NPWP"))
                            mdlSQL.ProfileState = Conversions.ToString(sqlreader.Item("PROPINSI"))
                            mdlSQL.ProfileCity = Conversions.ToString(sqlreader.Item("KOTA"))
                            flag2 = True
                        Else
                            retMsg = "ProfileNull"
                            mdlSQL.ProfileName = ""
                            mdlSQL.ProfileName = ""
                            mdlSQL.ProfileState = ""
                            mdlSQL.ProfileCity = ""
                            flag2 = False
                        End If
                    Else
                        retMsg = "Password tidak sesuai."
                        flag2 = False
                    End If
                Else
                    retMsg = "Username tidak ditemukan pada database."
                    flag2 = False
                End If
                sqlreader.Close()
                flag1 = flag2
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim excep As Exception = ex
                errMsg = ("db command failed. Message: " & excep.Message)
                flag1 = False
                MessageBox.Show("Error." & ex.Source & "Message : " & excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return flag1
                ProjectData.ClearProjectError()
            End Try
            Return flag1
        End Function

        Public Shared Function CloseDb(ByVal errmsg As String) As Boolean
            Dim flag As Boolean
            Try
                If mdlSQL.vConn Is Nothing Then
                    mdlSQL.vConn = New MySqlConnection()
                End If

                If mdlSQL.vConn.State = ConnectionState.Open Then
                    mdlSQL.vConn.Close()
                    mdlSQL.IsLogin = False
                    mdlSQL.vConn = DirectCast(Nothing, MySqlConnection)
                    mdlSQL.UserLogin = DirectCast(Nothing, String)
                    mdlSQL.cName = DirectCast(Nothing, String)
                    mdlSQL.uhost = DirectCast(Nothing, String)
                    mdlSQL.cPort = DirectCast(Nothing, String)
                    mdlSQL.cDbname = DirectCast(Nothing, String)
                    mdlSQL.cPass = DirectCast(Nothing, String)
                End If
                flag = True
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim excep As Exception = ex
                errmsg = "Tidak dapat menutup database.Message: " & excep.Message
                mdlSQL.INSERTLOG(errmsg, "")
                flag = False
                ProjectData.ClearProjectError()
                Return flag
                ProjectData.ClearProjectError()
            End Try
            Return flag
        End Function

        Public Overloads Shared Sub ShowWarning(ByVal Pesan As String)
            RadMessageBox.Show(Pesan, "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Sub

        Public Overloads Shared Sub ShowWarning(ByVal Pesan As String, ByVal Detail As String)
            RadMessageBox.Show(Pesan & vbNewLine &
                               "Pilih Tombol &Detail untuk Informasi Lengkap", "Perhatian",
                               MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1, Detail)
        End Sub

        Public Overloads Shared Sub ShowError(ByVal Pesan As String)
            RadMessageBox.Show(Pesan, "Error", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1)
        End Sub

        Public Overloads Shared Sub ShowError(ByVal Pesan As String, ByVal Detail As String)
            RadMessageBox.Show(Pesan & vbNewLine &
                               "Pilih Tombol &Detail untuk Informasi Lengkap", "Error",
                               MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1, Detail)
        End Sub

        Public Shared Sub ShowInfo(ByVal Pesan As String)
            RadMessageBox.Show(Pesan, "Informasi", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1)
        End Sub

        Public Shared Sub INSERTLOG(ByVal msg As String, Optional ByVal JnsLog As String = "")
            Try
                If Not My.Computer.FileSystem.DirectoryExists(mdlSQL.logpath) Then
                    My.Computer.FileSystem.CreateDirectory(mdlSQL.logpath)
                End If
                Dim writer As New IO.StreamWriter(String.Concat(New String() {mdlSQL.logpath, "\", DateAndTime.Today.ToString("yyyy-MM-dd"), JnsLog, ".log"}), True)
                writer.WriteLine(("[" & DateAndTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "]" & msg))
                writer.WriteLine()
                writer.Flush()
                writer.Close()
                writer.Dispose()
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim excep As Exception = ex
                ProjectData.ClearProjectError()
            End Try
        End Sub

        Public Shared Sub CreateBackup()
            Try
                Dim mysqldumpPath As String = My.Application.Info.DirectoryPath & "\Libs\mysqldumpx86.exe"
                Dim command As String = String.Format("--host={0} --user={1} --password={2} {3} -r", mdlSQL.uhost, mdlSQL.cName, mdlSQL.cPass, mdlSQL.cDbname)
                Dim filepath As String = My.Application.Info.DirectoryPath & "\backups\dbbackup_" & DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") & ".sql"

                mdlSQL.OutputStream = New System.IO.StreamWriter(filepath, False, System.Text.Encoding.UTF8)

                Dim sInfo As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo()

                With sInfo
                    .FileName = mysqldumpPath
                    .Arguments = command
                    .RedirectStandardError = True
                    .RedirectStandardInput = False
                    .RedirectStandardOutput = True
                    .UseShellExecute = False
                    .CreateNoWindow = True
                    .ErrorDialog = False
                End With

                Dim proc As System.Diagnostics.Process = New Process()
                proc.StartInfo = sInfo
                AddHandler proc.OutputDataReceived, AddressOf mdlSQL.OnDataReceived
                proc.Start()
                proc.BeginOutputReadLine()
                proc.WaitForExit()

                OutputStream.Flush()
                OutputStream.Close()

                proc.Close()

            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim Excep As Exception = ex
                mdlSQL.ShowError("Error." & Excep.Message)
                ProjectData.ClearProjectError()
            End Try
        End Sub

        Private Shared OutputStream As System.IO.StreamWriter

        Private Shared Sub OnDataReceived(ByVal sender As Object, ByVal e As System.Diagnostics.DataReceivedEventArgs)
            Try
                If e.Data IsNot Nothing Then
                    Dim text As String = e.Data
                    Dim bytes As Byte() = System.Text.Encoding.Default.GetBytes(text)
                    text = System.Text.Encoding.Default.GetString(bytes)
                    mdlSQL.OutputStream.WriteLine(text)
                End If
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim Excep As Exception = ex
                mdlSQL.ShowError("Error." & Excep.Message)
                ProjectData.ClearProjectError()
            End Try
        End Sub

        Public Shared targetFile As String
        Public Shared Function TargetDirIsValid() As Boolean
            Try
                Dim dirname As String = IO.Path.GetDirectoryName(mdlSQL.targetFile)
                If Not IO.Directory.Exists(dirname) Then
                    IO.Directory.CreateDirectory(dirname)
                End If
                Return True
            Catch ex As Exception
                RadMessageBox.Show(("Specify path is not valid. Press [Export As] to specify a valid file path." & Environment.NewLine & Environment.NewLine & ex.Message), "Invalid Directory", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
                Return False
            End Try
        End Function

        Public Shared Function SourceFileExists() As Boolean
            If Not IO.File.Exists(mdlSQL.targetFile) Then
                RadMessageBox.Show(("File is not exists. Press [Select File] to choose a SQL Dump file." _
                               & Environment.NewLine & Environment.NewLine & mdlSQL.targetFile), "Import", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
                Return False
            End If
            Return True
        End Function

        Private Shared _connectionString As String

        Public Shared Property backupKoneksiString() As String
            Get
                If String.IsNullOrEmpty(mdlSQL._connectionString) Then
                    Throw New Exception("Connection string is empty.")
                End If
                Return mdlSQL._connectionString
            End Get
            Set(ByVal value As String)
                mdlSQL._connectionString = value
            End Set
        End Property

    End Class


End Namespace