
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

End Class
