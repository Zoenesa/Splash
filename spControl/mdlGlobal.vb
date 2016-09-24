Imports System.IO
Imports System.Reflection
Imports System.Threading
Imports Setting.Config.Profile

Public Class spGlobal

    Public Shared Function GetLokasiorPath(ByVal Direktori As String) As String
        Return IO.Path.GetFullPath(IO.Path.GetDirectoryName(Direktori))
    End Function

    Public Shared Function GetLokasiorPath(ByVal Direktori As String, ByVal NamaFile As String) As String
        Return IO.Path.GetFullPath(IO.Path.GetFileName(IO.Path.Combine(Direktori, NamaFile)))
    End Function

    Public Shared FileReadOnlyLibrari As New List(Of String) From {"CodeLibs.dll", "FastColoredTextBox.dll", "Konektor.dll",
            "MySql.Data.dll", "MySqlBackup.dll", "PasswordMeter.dll", "Setting.Config.Profile.dll",
            "spControl.dll", "Telerik.WinControls.dll", "Telerik.WinControls.UI.dll"}

    Public Shared FileReadOnlyKonfig As New List(Of String) From {"Config.ini", "Konektor.ini"}

    Public Shared Function GetLibrariFile(ByVal Direktori As String, ByVal Files As List(Of String)) As List(Of String)
        Dim ListFile As New List(Of String)
        Dim num As Integer = 0
        Dim numm As Integer = Files.Count - 1
        Dim nummm As Integer = num
        Do While (num <= numm)
            ListFile.Add(IO.Path.Combine(Direktori, Files(num)))
            Interlocked.Increment(num)
        Loop
        'For Each NamaFile In IO.Directory.GetFiles(Direktori)
        '    ListFile.Add(IO.Path.GetFullPath(IO.Path.Combine(Direktori, IO.Path.GetFileName(NamaFile))))
        'Next NamaFile
        Return ListFile
    End Function

    Public Shared ListOfFileLibrari As Integer

    Public Shared Function ToRelativePath(ByRef filePath As String, ByRef refPath As String) As String
        Dim pathNormalized As String = Nothing
        Dim refNormalized As String = Nothing
        Dim res As String = Nothing
        pathNormalized = Path.GetFullPath(filePath)
        refNormalized = Path.GetFullPath(refPath)
        refNormalized = refNormalized.TrimEnd("\"c, "/"c)
        If Not pathNormalized.StartsWith(refNormalized) Then
            Throw New ArgumentException()
        End If
        res = pathNormalized.Substring(refNormalized.Length + 1)
        Return res
    End Function

    Public Shared Function AppsGetRelativePath(BasePath As String, AbsolutePath As String) As String
        Dim ReturnPath = ""
        Dim CommonPart = ""
        Try
            Dim Separator As Char = Path.DirectorySeparatorChar
            If String.IsNullOrWhiteSpace(BasePath) Then
                BasePath = Directory.GetCurrentDirectory()
            End If

            Dim BasePathFolders = BasePath.Split(Separator)
            Dim AbsolutePathFolders = AbsolutePath.Split(Separator)
            Dim i = 0
            While i < BasePathFolders.Length And i < AbsolutePathFolders.Length
                If BasePathFolders(i).ToLower() = AbsolutePathFolders(i).ToLower() Then
                    CommonPart += BasePathFolders(i) + Separator
                Else
                    Exit While
                End If
                i += 1
            End While
            If CommonPart.Length > 0 Then
                Dim parents = BasePath.Substring(CommonPart.Length - 1).Split(Separator)
                For Each ParentDir In parents
                    'For Each ParentDir As String In parents
                    If Not String.IsNullOrEmpty(ParentDir) Then
                        ReturnPath += ".." + Separator
                    End If
                Next
            End If
            ReturnPath += AbsolutePath.Substring(CommonPart.Length)
        Catch ex As Exception
            Throw New NotImplementedException(ex.Message)
        End Try
        Return ReturnPath
    End Function

    Public Shared Function ParseDirektoriString(ByVal Value As String, ByVal Inisial As String, ByVal status As String) As String
        Return String.Format("{0} {1} {2}", Value, Inisial, status)
    End Function

    Private Shared _ResList As New List(Of String)

    Public Shared Property EnumerateResx As List(Of String)
        Get
            Dim resname As String = "CodeLibs.dll"
            ' Get a reference to the running application.
            Dim assy As [Assembly] = [Assembly].GetEntryAssembly()
            ' Loop through each resource, looking for the image name (case-insensitive).
            For Each resource As String In assy.GetManifestResourceNames()
                If resource.ToLower().IndexOf(resname.ToLower) <> -1 Then
                    ' Get the embedded file from the assembly as a MemoryStream.
                    Using resourceStream As System.IO.Stream = assy.GetManifestResourceStream(resource)
                        If resourceStream IsNot Nothing Then
                            Using reader As New BinaryReader(resourceStream)
                                ' Read the bytes from the input stream.
                                Dim buffer() As Byte = reader.ReadBytes(CInt(resourceStream.Length))
                                _ResList.Add(resource)
                            End Using
                        End If
                    End Using
                    Exit For
                End If
            Next resource
            Return _ResList
        End Get
        Set(value As List(Of String))
            value = _ResList
        End Set
    End Property

End Class

Public Class spControl_ini


End Class