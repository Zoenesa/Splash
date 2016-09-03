Imports Telerik, Telerik.WinControls, Telerik.WinControls.UI
Imports Microsoft.VisualBasic.CompilerServices
Imports MySql.Data.MySqlClient
Imports Splash.Konektor

Public Class rFormLogin
    Public Sub New()

        InitializeComponent()

        Telerik.WinControls.RadMessageBox.Instance.AllowTheming = True
        Telerik.WinControls.RadMessageBox.Instance.ControlBox = False
        Telerik.WinControls.RadMessageBox.ShowInTaskbar = False
        Telerik.WinControls.RadMessageBox.ThemeName = rFormMain.Office2010BlackTheme1.ThemeName

    End Sub

    Private Sub rTxUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rTxUsername.KeyPress
        Select Case e.KeyChar
            Case Chr(13)
                rTxPassword.Focus()
                rTxPassword.SelectAll()
                e.Handled = True
        End Select
    End Sub

    Private Sub rTxPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rTxPassword.KeyPress
        Select Case e.KeyChar
            Case Chr(13)
                Button1.Focus()
                e.Handled = True
        End Select
    End Sub

    Private Shared sUser As String
    Private Shared sPass As String

    Private Sub Login(ByVal user As String, ByVal Pass As String)
        Dim retmsg As String = ""
        Dim errmsg As String = ""
        sUser = user
        sPass = Pass
        If sUser.Trim = "" Then
            RadMessageBox.Show("Kolom username Kosong", "Sign In", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            rTxUsername.Focus()
            rTxUsername.SelectAll()
            Exit Sub
        ElseIf sPass.Trim = "" Then
            RadMessageBox.Show("Kolom Password Kosong", "Sign In", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            rTxPassword.Focus()
            rTxPassword.SelectAll()
            Exit Sub
        End If

        If mdlCom.DataLogin(sUser, sPass, retmsg, errmsg, False) Then
            RadMessageBox.Show(rFormMain, "Welcome " & vbNewLine & mdlCom.UserLogin.ToString.ToUpper & vbNewLine,
                               "Splash DB" & Me.Text, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1)
            '"Current Project are : ", "Splash DB" & Me.Text, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1)
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            rFormMain.IsMdiContainer = True
            rFormMain.RadStatusDeskripsi.Text = String.Concat(New String() {
            "[", "Sign In As: ", Strings.UCase(mdlCom.UserLogin), "; ", "Nama: ", Strings.UCase(mdlCom.UserFName),
            "; Title: ", mdlCom.UserRole, "]",
            "; ", "[Server: ", mdlCom.uhost, "; Database: ", mdlCom.cDbname, "]"
            })
        ElseIf (errmsg = "0") Then
            If (retmsg = "ProfileNull") Then
                Me.DialogResult = System.Windows.Forms.DialogResult.Yes
            Else
                If retmsg = "Password tidak sesuai." Then
                    Dim num As Integer = DirectCast(RadMessageBox.Show(retmsg, "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1), Integer)
                    rTxPassword.Focus()
                    rTxPassword.SelectAll()
                Else
                    Dim num As Integer = DirectCast(RadMessageBox.Show(retmsg, "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1), Integer)
                    rTxUsername.Focus()
                    rTxUsername.SelectAll()
                End If
            End If
        Else
            Dim num1 As Integer = DirectCast(RadMessageBox.Show(retmsg, "Error", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1), Integer)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tempPassword As String = CodeLibs.CodeMethod.Encrypt_TRIPLEDES(rTxPassword.Text.Trim(), mdlstring.defaultKey)

        'Login(rTxUsername.Text.Trim(), rTxPassword.Text.Trim())
        Login(rTxUsername.Text.Trim(), tempPassword)
    End Sub

    Private Sub rFormLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        rFormMain.SetTheme(Me, rFormMain.Office2010BlackTheme1.ThemeName.ToString)
        rFormMain.LoadIcon(True, Me)
        rTxUsername.Focus()
        rTxUsername.SelectAll()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        rFormInisialisasiKoneksi.PilihDb(False)
        Me.Dispose()

        rFormMain.BukaPilihanKoneksi()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Login("Guest", "guest")
    End Sub
End Class