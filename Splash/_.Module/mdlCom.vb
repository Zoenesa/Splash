Imports MySql.Data.MySqlClient, Microsoft.VisualBasic.CompilerServices
Imports Splash.mdlstring
Imports Telerik, Telerik.WinControls, Telerik.WinControls.UI

Public NotInheritable Class mdlCom

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
        mdlCom.isDev = False
        mdlCom.IsLogin = False
        mdlCom.V_Role = New String(11 - 1) {}
        mdlCom.DefaultFolderName = ""
        mdlCom.targetFile = ""
    End Sub

    Public Sub New()
        Telerik.WinControls.RadMessageBox.Instance.AllowTheming = True
        RadMessageBox.Instance.ControlBox = False
        RadMessageBox.Instance.ThemeName = rFormMain.Office2010BlackTheme1.ThemeName
        RadMessageBox.Instance.ShowInTaskbar = False
        RadMessageBox.Instance.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Public Shared Function KoneksiString() As String
        Dim str As String = Nothing
        Dim strConn As String
        Dim tempPass As String = cPass.Trim() '.CodeMethod.Encrypt_TRIPLEDES(cPass.Trim(), mdlstring.defaultKey)
        strConn = "server=" & uhost.Trim() &
            ";userid=" & cName.Trim() &
            ";password=" & cPass.Trim() &
            ";Database=" & cDbname.Trim() &
            ";port=" & cPort.Trim() & ";"
        If mdlCom.vConn Is Nothing Then
            mdlCom.vConn = New MySqlConnection()
            mdlCom.vConn.ConnectionString = strConn
        End If
        If mdlCom.vConn.State <> ConnectionState.Open Then
            mdlCom.vConn.ConnectionString = strConn
            vConn.Open()
        ElseIf mdlCom.vConn.State = ConnectionState.Open Then
            mdlCom.vConn.Close()
            mdlCom.vConn.ConnectionString = strConn
            mdlCom.vConn.Open()
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
            If mdlCom.vConn Is Nothing Then
                mdlCom.vConn = New MySqlConnection()
                mdlCom.vConn.ConnectionString = strConn
            End If
            If mdlCom.vConn.State <> ConnectionState.Open Then
                mdlCom.vConn.ConnectionString = strConn
                vConn.Open()
                Return True
            ElseIf mdlCom.vConn.State = ConnectionState.Open Then
                mdlCom.vConn.Close()
                mdlCom.vConn.ConnectionString = strConn
                mdlCom.vConn.Open()
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
            If mdlCom.vConn Is Nothing Then
                mdlCom.vConn = New MySqlConnection()
                mdlCom.vConn.ConnectionString = strConn
            End If
            If mdlCom.vConn.State <> ConnectionState.Open Then
                mdlCom.vConn.ConnectionString = strConn
                vConn.Open()
            ElseIf mdlCom.vConn.State = ConnectionState.Open Then
                mdlCom.vConn.Close()
                mdlCom.vConn.ConnectionString = strConn
                mdlCom.vConn.Open()
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
            If mdlCom.vConn Is Nothing Then
                mdlCom.vConn = New MySqlConnection()
                mdlCom.vConn.ConnectionString = strConn
            End If
            If mdlCom.vConn.State <> ConnectionState.Open Then
                mdlCom.vConn.ConnectionString = strConn
                vConn.Open()
            ElseIf mdlCom.vConn.State = ConnectionState.Open Then
                mdlCom.vConn.Close()
                mdlCom.vConn.ConnectionString = strConn
                mdlCom.vConn.Open()
            End If
            Dim sqlcommand As New MySqlCommand("SELECT * FROM `datatemp`;", mdlCom.vConn)
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
            mdlCom.INSERTLOG(errMsg, "")
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
             .Connection = mdlCom.vConn,
             .CommandText = "SELECT `Password`, `UserRole`, `JobTitle`, `UserFname`, `kdgroup`, " & _
             "`nip_user`, `Uaktif`, `JobDesk` FROM `user` WHERE `Username` = '" & mdlstring.ADD_QUOTE_ON_SQL(uname) & "'"}
            Dim sqlreader As MySqlDataReader = sqlcommand.ExecuteReader()
            Dim flag2 As Boolean
            If sqlreader.HasRows Then
                sqlreader.Read()
                If (sqlreader.Item(0).ToString = ADD_QUOTE_ON_SQL(upwd)) Or loginFromProfile Then
                    Dim num As Integer
                    mdlCom.UserLogin = ADD_QUOTE_ON_SQL(uname)
                    mdlCom.JobDesk = Conversions.ToString(sqlreader.Item("JobDesk"))
                    mdlCom.UserRole = Conversions.ToString(sqlreader.Item("JobTitle"))
                    mdlCom.UserFName = Conversions.ToString(sqlreader.Item("UserFname"))
                    If Operators.ConditionalCompareObjectEqual(sqlreader.Item("nip_user"), "000000000", False) Then
                        mdlCom.V_Role(0) = Conversions.ToString(sqlreader.Item("kdgroup"))

                        Dim index As Integer = 1
                        Do
                            mdlCom.V_Role(index) = Conversions.ToString(
                                Interaction.IIf(Operators.ConditionalCompareObjectEqual _
                                                (sqlreader.Item("kdgroup"), "01", False), "0", "1"))
                            index += 1
                            num = 9
                        Loop While (index <= num)
                    Else
                        Dim strArr As String() = Strings.Split(Conversions.ToString(sqlreader.Item("nip_user")), _
                                                               ";", -1, CompareMethod.Binary)
                        Dim num1 As Integer = 0
                        Do
                            mdlCom.V_Role(num1) = strArr(num1)
                            num1 += 1
                            num = 9
                        Loop While (num1 <= num)
                    End If
                    sqlreader.Close()
                    sqlcommand.CommandText = "SELECT * FROM `ref_profile`"
                    sqlreader = sqlcommand.ExecuteReader()
                    If sqlreader.HasRows Then
                        sqlreader.Read()
                        mdlCom.ProfileName = Conversions.ToString(sqlreader.Item("NAMA_WP_PROFILE"))
                        mdlCom.ProfileIdTax = Conversions.ToString(sqlreader.Item("NPWP"))
                        mdlCom.ProfileState = Conversions.ToString(sqlreader.Item("PROPINSI"))
                        mdlCom.ProfileCity = Conversions.ToString(sqlreader.Item("KOTA"))
                        flag2 = True
                    Else
                        retMsg = "ProfileNull"
                        mdlCom.ProfileName = ""
                        mdlCom.ProfileName = ""
                        mdlCom.ProfileState = ""
                        mdlCom.ProfileCity = ""
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
            If mdlCom.vConn Is Nothing Then
                mdlCom.vConn = New MySqlConnection()
            End If

            If mdlCom.vConn.State = ConnectionState.Open Then
                mdlCom.vConn.Close()
                mdlCom.IsLogin = False
                mdlCom.vConn = DirectCast(Nothing, MySqlConnection)
                mdlCom.UserLogin = DirectCast(Nothing, String)
                mdlCom.cName = DirectCast(Nothing, String)
                mdlCom.uhost = DirectCast(Nothing, String)
                mdlCom.cPort = DirectCast(Nothing, String)
                mdlCom.cDbname = DirectCast(Nothing, String)
                mdlCom.cPass = DirectCast(Nothing, String)
            End If
            flag = True
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim excep As Exception = ex
            errmsg = "Tidak dapat menutup database.Message: " & excep.Message
            mdlCom.INSERTLOG(errmsg, "")
            flag = False
            ProjectData.ClearProjectError()
            Return flag
            ProjectData.ClearProjectError()
        End Try
        Return flag
    End Function

    Public Shared Sub ShowWarning(ByVal msg As String)
        RadMessageBox.Show(msg, "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1)
    End Sub

    Public Shared Sub ShowError(ByVal msg As String)
        RadMessageBox.Show(msg, "Error", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1)
    End Sub

    Public Shared Sub ShowInfo(ByVal msg As String)
        RadMessageBox.Show(msg, "Informasi", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1)
    End Sub

    Public Shared Sub INSERTLOG(ByVal msg As String, Optional ByVal JnsLog As String = "")
        Try
            If Not My.Computer.FileSystem.DirectoryExists(mdlCom.logpath) Then
                My.Computer.FileSystem.CreateDirectory(mdlCom.logpath)
            End If
            Dim writer As New IO.StreamWriter(String.Concat(New String() {mdlCom.logpath, "\", DateAndTime.Today.ToString("yyyy-MM-dd"), JnsLog, ".log"}), True)
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
            Dim command As String = String.Format("--host={0} --user={1} --password={2} {3} -r", mdlCom.uhost, mdlCom.cName, mdlCom.cPass, mdlCom.cDbname)
            Dim filepath As String = My.Application.Info.DirectoryPath & "\backups\dbbackup_" & DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") & ".sql"

            mdlCom.OutputStream = New System.IO.StreamWriter(filepath, False, System.Text.Encoding.UTF8)

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
            AddHandler proc.OutputDataReceived, AddressOf mdlCom.OnDataReceived
            proc.Start()
            proc.BeginOutputReadLine()
            proc.WaitForExit()

            OutputStream.Flush()
            OutputStream.Close()

            proc.Close()

        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim Excep As Exception = ex
            mdlCom.ShowError("Error." & Excep.Message)
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
                mdlCom.OutputStream.WriteLine(text)
            End If
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim Excep As Exception = ex
            mdlCom.ShowError("Error." & Excep.Message)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Public Shared targetFile As String
    Public Shared Function TargetDirIsValid() As Boolean
        Try
            Dim dirname As String = IO.Path.GetDirectoryName(mdlCom.targetFile)
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
        If Not IO.File.Exists(mdlCom.targetFile) Then
            MessageBox.Show(("File is not exists. Press [Select File] to choose a SQL Dump file." & Environment.NewLine & Environment.NewLine & mdlCom.targetFile), "Import", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return False
        End If
        Return True
    End Function

    Private Shared _connectionString As String

    Public Shared Property backupKoneksiString() As String
        Get
            If String.IsNullOrEmpty(mdlCom._connectionString) Then
                Throw New Exception("Connection string is empty.")
            End If
            Return mdlCom._connectionString
        End Get
        Set(ByVal value As String)
            mdlCom._connectionString = value
        End Set
    End Property

    Private Shared convTempPassword As String
    'Public Shared Property ConvertsqlPassword As String
    '    Get
    '        If String.IsNullOrEmpty(mdlCom.cPass) Then
    '            Throw New Exception("Password no Result.")
    '        End If
    '        convTempPassword = CodeLibs.CodeMethod.Encrypt_TRIPLEDES(mdlCom.cPass, mdlstring.defaultKey)
    '        If CodeLibs.CodeMethod.Encrypt_TRIPLEDES(cPass, mdlstring.defaultKey) = convTempPassword Then

    '        End If
    '        Return mdlCom.cPass
    '    End Get
    '    Set(value As String)
    '        value = CodeLibs.CodeMethod.Encrypt_TRIPLEDES(mdlCom.cPass, mdlstring.defaultKey)
    '        mdlCom.cPass = value
    '    End Set
    'End Property



End Class
