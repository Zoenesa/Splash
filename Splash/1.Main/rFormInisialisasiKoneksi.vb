Imports Setting.Config.Profile.Profile
Imports Telerik, Telerik.WinControls, Telerik.WinControls.UI

Public Class rFormInisialisasiKoneksi

    Private isOk As Boolean

    Public Sub New()

        InitializeComponent()
        Telerik.WinControls.RadMessageBox.Instance.AllowTheming = True
        Telerik.WinControls.RadMessageBox.Instance.ControlBox = False
        Telerik.WinControls.RadMessageBox.ShowInTaskbar = False
        Telerik.WinControls.RadMessageBox.ThemeName = rFormMain.Office2010BlackTheme1.ThemeName

    End Sub

    Public Sub PilihDb(ByVal inp As Boolean)
        Dim errMsg As String = ""
        mdlCom.cName = txUser.Text
        mdlCom.uhost = txserver.Text
        mdlCom.cPort = txPort.Text
        mdlCom.cDbname = txdbname.Text
        mdlCom.cPass = txPass.Text
        If mdlCom.ConnectDb(errMsg) Then
            Me.isOk = True
            If Not inp Then
                Me.Close()
            End If
        Else
            Dim num As Integer = DirectCast(MessageBox.Show("Error." & errMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1), Integer)
            Me.isOk = False
            txdbname.Focus()
        End If
    End Sub

    Private Sub FrmInisialisasiKoneksi_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If Me.isOk Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub LoadSetting()

        Dim mprofile As Setting.Config.Profile.Ini = New Setting.Config.Profile.Ini

        Dim strSection As String = Nothing

        Dim strdefault As String = mprofile.GetValue("General", "defaultsetting")
        If strdefault = "True" Then
            strSection = mprofile.GetValue("General", "SectionName")
        End If

        txdbname.Text = mprofile.GetValue(strSection, "DatabaseName")
        txserver.Text = mprofile.GetValue(strSection, "server")
        txPort.Text = mprofile.GetValue(strSection, "port")
        txUser.Text = mprofile.GetValue(strSection, "user")
        txPass.Text = mprofile.GetValue(strSection, "password")

    End Sub

    Private Sub FrmInisialisasiKoneksi_Load(sender As Object, e As EventArgs) Handles Me.Load
        rFormMain.SetTheme(Me, rFormMain.Office2010BlackTheme1.ThemeName.ToString)
        LoadSetting()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mdlCom.cName = txUser.Text
        mdlCom.uhost = txserver.Text
        mdlCom.cPort = txPort.Text
        mdlCom.cDbname = txdbname.Text
        mdlCom.cPass = txPass.Text
        Dim flag As Boolean = Splash.mdlCom.CekKoneksiSql
        If flag = True Then
            RadMessageBox.Show("Koneksi ke database Sukses." & vbNewLine & _
                                "Informasi Koneksi :" & vbNewLine &
                                "Server: " & mdlCom.uhost & vbNewLine &
                                "Database: " & mdlCom.cDbname,
                                "Database Connection", MessageBoxButtons.OK, RadMessageIcon.Info)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub txdbname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txdbname.KeyPress
        Select Case e.KeyChar
            Case Chr(13)
                txserver.Focus()
                txserver.SelectAll()
                e.Handled = True
        End Select
    End Sub

    Private Sub txserver_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txserver.KeyPress
        Select Case e.KeyChar
            Case Chr(13)
                txPort.Focus()
                txPort.SelectAll()
                e.Handled = True
        End Select
    End Sub

    Private Sub txPort_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txPort.KeyPress
        Select Case e.KeyChar
            Case Chr(13)
                txUser.Focus()
                txUser.SelectAll()
                e.Handled = True
        End Select
    End Sub

    Private Sub txUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txUser.KeyPress
        Select Case e.KeyChar
            Case Chr(13)
                txPass.Focus()
                txPass.SelectAll()
                e.Handled = True
        End Select
    End Sub

    Private Sub txPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txPass.KeyPress
        Select Case e.KeyChar
            Case Chr(13)
                Button1.Focus()
                e.Handled = True
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PilihDb(True)
    End Sub
End Class