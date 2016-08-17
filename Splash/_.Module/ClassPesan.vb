Imports Telerik, Telerik.WinControls
Imports System, System.Threading, System.Runtime, System.Runtime.InteropServices, System.Runtime.CompilerServices
Imports Microsoft, Microsoft.VisualBasic, Microsoft.VisualBasic.CompilerServices

Public Class ClassPesan

    Shared Sub New()

        Telerik.WinControls.RadMessageBox.Instance.AllowTheming = True
        Telerik.WinControls.RadMessageBox.Instance.ControlBox = False
        Telerik.WinControls.RadMessageBox.ShowInTaskbar = False
        Telerik.WinControls.RadMessageBox.ThemeName = rFormMain.Office2010BlackTheme1.ThemeName
         
    End Sub

    Public Sub New()

        Telerik.WinControls.RadMessageBox.Instance.AllowTheming = True
        Telerik.WinControls.RadMessageBox.Instance.ControlBox = False
        Telerik.WinControls.RadMessageBox.ShowInTaskbar = False
        Telerik.WinControls.RadMessageBox.ThemeName = rFormMain.Office2010BlackTheme1.ThemeName
         
    End Sub

    Public Shared Sub ShowExclException(ByVal errMsg As String, ByVal useDetailed As Boolean, Optional ByVal detail As String = "")
        Dim result As DialogResult
        If useDetailed Then
            result = RadMessageBox.Show(errMsg, "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1, detail)
        Else
            result = RadMessageBox.Show(errMsg & detail, "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Public Shared Sub ShowErrorExceptio(ByVal errMsg As String, ByVal useDetailed As Boolean, Optional ByVal detail As String = "")
        Dim result As DialogResult
        If useDetailed Then
            result = RadMessageBox.Show(errMsg, "Error", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1, detail)
        Else
            result = RadMessageBox.Show(errMsg & detail, "Error", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Sub
End Class
