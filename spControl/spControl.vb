
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports Microsoft.VisualBasic.CompilerServices

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

    Public Shared DefaultIconFileName As System.Drawing.Icon

    Public Shared BaseAppFolder As String

    Public Shared Function SettingLogoIconName(ByVal IconFileName As String) As Boolean
        Dim flag As Boolean = False
        Dim FolderParent As String = IO.Path.GetDirectoryName(IO.Path.Combine(Environment.CurrentDirectory, IconFileName))

        Dim flag2 As Boolean = Conversions.ToBoolean(IO.File.Exists(IO.Path.Combine(SettingDefaultImageFolder, FolderParent)))
        If flag2 Then
            flag = flag2
            DefaultIconFileName = New Icon(IO.Path.Combine(Environment.CurrentDirectory, GetDataSetting(PilihanProfile.Aplikasi, "General", "Icons")))
        Else
            DefaultIconFileName = New Icon(System.Reflection.Assembly.
                        GetExecutingAssembly.
                        GetManifestResourceStream("DefaultLogo.ico"))
            flag = False
        End If
        Return flag
    End Function

    Public Shared Function GetImageFromFolder(ByVal ImageName As String) As System.Drawing.Image
        Dim Img As System.Drawing.Image

        If Not IO.File.Exists(IO.Path.Combine(Environment.CurrentDirectory, "Images", ImageName)) Then
            SaveResource(ImageName, IO.Path.Combine(Environment.CurrentDirectory, "Images", ImageName))
        End If

        Img = Image.FromFile(IO.Path.Combine(Environment.CurrentDirectory, "Images", ImageName))

        Return Img
    End Function

    Public Shared Sub SaveResource(ByVal resName As String, filename As String)
        ' Get a reference to the running application.
        Dim assy As [Assembly] = [Assembly].GetExecutingAssembly()
        ' Loop through each resource, looking for the image name (case-insensitive).
        For Each resource As String In assy.GetManifestResourceNames()
            If resource.ToLower().IndexOf(resName.ToLower) <> -1 Then
                ' Get the embedded file from the assembly as a MemoryStream.
                Using resourceStream As System.IO.Stream = assy.GetManifestResourceStream(resource)
                    If resourceStream IsNot Nothing Then
                        Using reader As New BinaryReader(resourceStream)
                            ' Read the bytes from the input stream.
                            Dim buffer() As Byte = reader.ReadBytes(CInt(resourceStream.Length))
                            Using outputStream As New FileStream(filename, FileMode.Create)
                                Using writer As New BinaryWriter(outputStream)
                                    ' Write the bytes to the output stream.
                                    writer.Write(buffer)
                                End Using
                            End Using
                        End Using
                    End If
                End Using
                Exit For
            End If
        Next resource
        'Subrutin / Caller
        'SaveToDisk([Resource Name with Extension-use the same case as used in the filename], [Output path with FileName & extension])
    End Sub

End Class
