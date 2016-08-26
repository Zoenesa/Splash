
Imports Telerik, Telerik.WinControls, Telerik.WinControls.UI
Imports Microsoft.VisualBasic.CompilerServices
Imports MySql.Data.MySqlClient
Imports System.Threading, System.Reflection
Imports System.Text
Imports System.IO

Public Class CreateNewSQLConn

    Public Sub New()

        InitializeComponent()

        Telerik.WinControls.RadMessageBox.Instance.AllowTheming = True
        Telerik.WinControls.RadMessageBox.Instance.ControlBox = False
        Telerik.WinControls.RadMessageBox.ShowInTaskbar = False
        Telerik.WinControls.RadMessageBox.ThemeName = rFormMain.Office2010BlackTheme1.ThemeName

    End Sub

    Private Sub CreateNewSQLConn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mprofile As Setting.Config.Profile.Ini = New Setting.Config.Profile.Ini

        mprofile.SetValue(txNamaKoneksi.Text.Trim, "ConnectionName", txNamaKoneksi.Text.Trim)
        mprofile.SetValue(txNamaKoneksi.Text.Trim, "userid", txUser.Text.Trim)
        mprofile.SetValue(txNamaKoneksi.Text.Trim, "password", txPassword.Text.Trim)

    End Sub


End Class
