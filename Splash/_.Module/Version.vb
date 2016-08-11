Imports System.IO, System.Net, System.Text
Imports Telerik, Telerik.WinControls, Telerik.WinControls.UI
Imports Microsoft.VisualBasic.CompilerServices

Public Class Web_Update
    Dim version As String

    Public Shared Downuri As String

    Public Shared Sub Main()
        Try
            Dim uri As String
            uri = "http://zoenesaweb.twomini.com/Version.html"
            Downuri = "http://zoenesaweb.twomini.com/App/SqlTool/updates/updates.zip"
            Dim wr As HttpWebRequest = CType(WebRequest.Create(uri.ToString), HttpWebRequest)
            Dim ws As HttpWebResponse = CType(wr.GetResponse(), HttpWebResponse)
            Dim str As Stream = ws.GetResponseStream()
            Dim inBuf(100000) As Byte
            Dim bytesToRead As Integer = CInt(inBuf.Length)
            Dim bytesRead As Integer = 0
            While bytesToRead > 0
                Dim n As Integer = str.Read(inBuf, bytesRead, bytesToRead)
                If n = 0 Then
                    Exit While
                End If
                bytesRead += n
                bytesToRead -= n
            End While
            Dim fstr As New FileStream("version.txt", FileMode.OpenOrCreate, FileAccess.Write)
            fstr.Write(inBuf, 0, bytesRead)
            str.Close()
            fstr.Close()
            Dim sr As StreamReader = New System.IO.StreamReader("version.txt")
            Dim version As Integer = CInt(sr.ReadToEnd.Replace(".", "").Substring(0, 4))
            sr.Close()
            If version > CInt(Application.ProductVersion.Replace(".", "")) Then
                'Dialog1.ShowDialog()
                RadMessageBox.Show("On Updating, Application Will Close!", "Updating", MessageBoxButtons.OK, RadMessageIcon.Info)
                Process.Start(My.Application.Info.DirectoryPath & "\Updater.exe")
                Application.Exit()
            Else
                RadMessageBox.Show("There is no new updates.", "Update", MessageBoxButtons.OK, RadMessageIcon.Info)
            End If
        Catch ex As Exception
            RadMessageBox.Show("Error." & ex.Source & vbNewLine & ex.Message, "Update Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
    End Sub
End Class
