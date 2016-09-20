Public NotInheritable Class mdlGlobal

    Public Shared ModulSetting As Setting.Config.Profile.Profile

    Public Shared ModulImageFolder As String = IO.Path.Combine(Environment.CurrentDirectory, "Images")
    Public Shared ModulConfigFolder As String = IO.Path.Combine(Environment.CurrentDirectory, "Config")
    Public Shared ModulLibsFolder As String = IO.Path.Combine(Environment.CurrentDirectory, "Libs")
    Public Shared ModulBackupFolder As String = IO.Path.Combine(Environment.CurrentDirectory, "Backups.")

    Public Shared ModulConfigKonektorFile As String = IO.Path.Combine(mdlGlobal.ModulConfigFolder, "Konektor.ini")
    Public Shared ModulConfigAplikasiFile As String = IO.Path.Combine(mdlGlobal.ModulConfigFolder, "Main Setting.ini")

    Public Shared DefaultIcon As String = "myico.ico"

    Shared Sub New()

    End Sub

    Public Overloads Shared Sub SimpanSetting(ByVal NamaProfile As PilihanProfile, ByVal Section As String, ByVal Entry As String, ByVal Value As String)
        Select Case NamaProfile
            Case 1
                mdlGlobal.ModulSetting = New Setting.Config.Profile.Ini(IO.Path.Combine(Environment.CurrentDirectory, "Config", "Konektor.ini"))
                Exit Select
            Case 0
                mdlGlobal.ModulSetting = New Setting.Config.Profile.Ini(IO.Path.Combine(Environment.CurrentDirectory, "Config", "Config.ini"))
                Exit Select
        End Select
        mdlGlobal.ModulSetting.SetValue(Section, Entry, Value)
    End Sub

    Enum PilihanProfile As Integer
        Aplikasi = 0
        Konektor = 1
    End Enum

    Public Overloads Shared Sub SimpanSetting(ByVal NamaProfile As PilihanProfile, ByVal Entry As String, ByVal Value As String)
        Select Case NamaProfile
            Case 1
                mdlGlobal.ModulSetting = New Setting.Config.Profile.Ini(IO.Path.Combine(Environment.CurrentDirectory, "Config", "Konektor.ini"))
                Exit Select
            Case 0
                mdlGlobal.ModulSetting = New Setting.Config.Profile.Ini(IO.Path.Combine(Environment.CurrentDirectory, "Config", "Config.ini"))
                Exit Select
        End Select
        mdlGlobal.ModulSetting.SetValue(My.Application.Info.AssemblyName, Entry, Value)
    End Sub

    Public Overloads Shared Function GetDataSetting(ByVal NamaProfile As PilihanProfile, ByVal Section As String, ByVal Entry As String) As String
        Dim DataSetting As String = Nothing
        Select Case NamaProfile
            Case 1
                mdlGlobal.ModulSetting = New Setting.Config.Profile.Ini(IO.Path.Combine(Environment.CurrentDirectory, "Config", "Konektor.ini"))
                Exit Select
            Case 0
                mdlGlobal.ModulSetting = New Setting.Config.Profile.Ini(IO.Path.Combine(Environment.CurrentDirectory, "Config", "Config.ini"))
                Exit Select
        End Select
        DataSetting = mdlGlobal.ModulSetting.GetValue(Section, Entry)
        Return DataSetting
    End Function

    Public Overloads Shared Function GetDataSetting(ByVal NamaProfile As PilihanProfile, ByVal Entry As String) As String
        Dim DataSetting As String = Nothing
        Select Case NamaProfile
            Case 1
                mdlGlobal.ModulSetting = New Setting.Config.Profile.Ini(IO.Path.Combine(Environment.CurrentDirectory, "Config", "Konektor.ini"))
                Exit Select
            Case 0
                mdlGlobal.ModulSetting = New Setting.Config.Profile.Ini(IO.Path.Combine(Environment.CurrentDirectory, "Config", "Config.ini"))
                Exit Select
        End Select
        DataSetting = mdlGlobal.ModulSetting.GetValue(My.Application.Info.AssemblyName, Entry)
        Return DataSetting
    End Function

End Class
