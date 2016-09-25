
Public NotInheritable Class spControl

    Public Shared ControlSettingAplikasi As Setting.Config.Profile.Profile = New Setting.Config.Profile.Ini(IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config.ini"))

    Public Shared ControlSettingKonektor As Setting.Config.Profile.Profile = New Setting.Config.Profile.Ini(IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Konektor.ini"))

    Public Shared ModulSetting As Setting.Config.Profile.Profile

    Public Shared SettingDefaultImageFolder As String = IO.Path.Combine(Environment.CurrentDirectory, "Images")
    Public Shared SettingDefaultConfigFolder As String = IO.Path.Combine(Environment.CurrentDirectory, "Config")
    Public Shared SettingDefaultLibsFolder As String = IO.Path.Combine(Environment.CurrentDirectory, "Libs")
    Public Shared SettingDefaultBackupFolder As String = IO.Path.Combine(Environment.CurrentDirectory, "Backups.")

    Public Shared SettingKonektor_iniFile As String = IO.Path.Combine(SettingDefaultConfigFolder, "Konektor.ini")
    Public Shared SettingConfig_iniFile As String = IO.Path.Combine(SettingDefaultConfigFolder, "Main Setting.ini")

    Public Shared DefaultIcon As String = "myico.ico"

    Shared Sub New()

    End Sub

    Public Overloads Shared Sub SimpanSetting(ByVal NamaProfile As PilihanProfile, ByVal Section As String, ByVal Entry As String, ByVal Value As String)
        Select Case NamaProfile
            Case 1
                ModulSetting = New Setting.Config.Profile.Ini(IO.Path.Combine(Environment.CurrentDirectory, "Config", "Konektor.ini"))
                Exit Select
            Case 0
                ModulSetting = New Setting.Config.Profile.Ini(IO.Path.Combine(Environment.CurrentDirectory, "Config", "Config.ini"))
                Exit Select
        End Select
        ModulSetting.SetValue(Section, Entry, Value)
    End Sub

    Enum PilihanProfile As Integer
        Aplikasi = 0
        Konektor = 1
    End Enum

    Public Overloads Shared Sub SimpanSetting(ByVal NamaProfile As PilihanProfile, ByVal Entry As String, ByVal Value As String)
        Select Case NamaProfile
            Case 1
                ModulSetting = New Setting.Config.Profile.Ini(IO.Path.Combine(Environment.CurrentDirectory, "Config", "Konektor.ini"))
                Exit Select
            Case 0
                ModulSetting = New Setting.Config.Profile.Ini(IO.Path.Combine(Environment.CurrentDirectory, "Config", "Config.ini"))
                Exit Select
        End Select
        ModulSetting.SetValue(My.Application.Info.AssemblyName, Entry, Value)
    End Sub

    Public Overloads Shared Function GetDataSetting(ByVal NamaProfile As PilihanProfile, ByVal Section As String, ByVal Entry As String) As String
        Dim DataSetting As String = Nothing
        Select Case NamaProfile
            Case 1
                ModulSetting = New Setting.Config.Profile.Ini(IO.Path.Combine(Environment.CurrentDirectory, "Config", "Konektor.ini"))
                Exit Select
            Case 0
                ModulSetting = New Setting.Config.Profile.Ini(IO.Path.Combine(Environment.CurrentDirectory, "Config", "Config.ini"))
                Exit Select
        End Select
        DataSetting = ModulSetting.GetValue(Section, Entry)
        Return DataSetting
    End Function

    Public Overloads Shared Function GetDataSetting(ByVal NamaProfile As PilihanProfile, ByVal Entry As String) As String
        Dim DataSetting As String = Nothing
        Select Case NamaProfile
            Case 1
                ModulSetting = New Setting.Config.Profile.Ini(IO.Path.Combine(Environment.CurrentDirectory, "Config", "Konektor.ini"))
                Exit Select
            Case 0
                ModulSetting = New Setting.Config.Profile.Ini(IO.Path.Combine(Environment.CurrentDirectory, "Config", "Config.ini"))
                Exit Select
        End Select
        DataSetting = ModulSetting.GetValue(My.Application.Info.AssemblyName, Entry)
        Return DataSetting
    End Function

    Public Shared Function CekSettingAplikasi() As Boolean
        Dim flag As Boolean, flag1 As Boolean, flag2 As Boolean, flag3 As Boolean
        Dim BasePath As String = IO.Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory)
        Dim ConfigFolder As String = IO.Path.Combine(BasePath, "Config")
        Dim KonektorFolder As String = IO.Path.Combine(BasePath, "Config")
        Dim LibFolder As String = IO.Path.Combine(BasePath, "Libs")
        Dim ImageFolder As String = IO.Path.Combine(BasePath, "Images")

        Dim ConfigFile As String = "Config.ini"
        Dim konektorFile As String = "Konektor.ini"


        flag1 = IO.Directory.Exists(ConfigFolder)
        flag2 = IO.Directory.Exists(LibFolder)
        flag3 = IO.Directory.Exists(ImageFolder)

        If flag1 Then
            flag = flag1
        Else
            'buat config file
            Using sw As IO.StreamWriter = New IO.StreamWriter(IO.Path.Combine(BasePath, "Config"))
                sw.WriteLine("")

            End Using
        End If




        Return flag
    End Function

    Public Shared Function SettingLogoIconName(ByVal IconFileName As String) As String
        Dim IconPath As String
        Dim BaseImagesPath As String = IO.Path.Combine(Environment.CurrentDirectory, "Images")
        Dim AppPAth As String = Environment.CurrentDirectory

        Dim strRelative As String = spGlobal.AppsGetRelativePath(AppPAth, IO.Path.Combine(BaseImagesPath)) & "\" & IconFileName
        If String.Compare(GetDataSetting(PilihanProfile.Aplikasi, "General", "Icons"), strRelative) Then
            IconPath = IO.Path.Combine(AppPAth, BaseImagesPath, IconFileName)
        Else
            IconPath = IO.Path.Combine(AppPAth, BaseImagesPath, "myIco.Ico")
        End If
        Return IconPath
    End Function

End Class
