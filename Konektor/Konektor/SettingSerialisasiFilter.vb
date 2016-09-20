Imports System
Imports System.Runtime.InteropServices
Imports System.Text

Namespace Splash.Konektor.Setting
    Public Class SettingSerialisasiFilter

        Public Property Path As String

        Public Sub New(ByVal FilePath As String)
            Me.Path = FilePath
        End Sub

        <DllImport("kernel32.dll", CharSet:=CharSet.[Ansi], EntryPoint:="GetPrivateProfileStringA", ExactSpelling:=True, SetLastError:=True)>
        Private Shared Function GetPrivateProfileString(ByRef lpApplicationName As String, ByRef lpKeyName As String, ByRef lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByRef lpFileName As String) As Integer
        End Function

        Public Function ReadValue(ByVal Section As String, ByVal Key As String) As String
            Dim sb As StringBuilder = New StringBuilder(255)
            Dim str As String = ""
            Dim Path As String = Me.Path
            Me.Path = Path
            SettingSerialisasiFilter.GetPrivateProfileString(Section, Key, str, sb, 255, Path)
            Return sb.ToString()
        End Function

        <DllImport("kernel32.dll", CharSet:=CharSet.[Ansi], EntryPoint:="WritePrivateProfileStringA", ExactSpelling:=True, SetLastError:=True)>
        Private Shared Function WritePrivateProfileString(ByRef lpApplicationName As String, ByRef lpKeyName As String, ByRef lpString As String, ByRef lpFileName As String) As Integer
        End Function

        Public Sub WriteValue(ByVal section As String, ByVal key As String, ByVal value As String)
            Dim path As String = Me.Path
            SettingSerialisasiFilter.WritePrivateProfileString(section, key, value, path)
            Me.Path = path
        End Sub
    End Class
End Namespace