Imports PasswordMeter
Imports Telerik, Telerik.WinControls, Telerik.WinControls.UI
Imports Microsoft.VisualBasic.CompilerServices, MySql.Data.MySqlClient
Public Class rFormGantiPassword

    Public Sub New()
         
        InitializeComponent()
        Telerik.WinControls.RadMessageBox.Instance.AllowTheming = True
        Telerik.WinControls.RadMessageBox.Instance.ControlBox = False
        Telerik.WinControls.RadMessageBox.ShowInTaskbar = False
        RadMessageBox.Instance.StartPosition = FormStartPosition.CenterScreen

    End Sub
    Private Sub rFormGantiPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PasswordStrengthControl1.Visible = False

    End Sub

    Private Sub txPassNext_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txPassNext.KeyPress
        Select Case e.KeyChar
            Case Chr(13)
                btnSave.Focus()
                e.Handled = True
                Exit Select
        End Select
    End Sub
     
    Private Sub txPassNext_TextChanged(sender As Object, e As EventArgs) Handles txPassNext.TextChanged
        'Dim pwdStreng As PasswordMeter.PasswordStrength = New PasswordStrength
        'pwdStreng.SetPassword(txPassNew.Text.Trim())
        If txPassNext.Text.Trim() <> "" Then
            PasswordStrengthControl1.Visible = True
            PasswordStrengthControl1.SetPassword(txPassNext.Text.Trim())
        Else
            PasswordStrengthControl1.Visible = False
        End If
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Beep()
        Dim result As DialogResult = RadMessageBox.Show("Anda akan merubah password lama dengan password baru!" & vbNewLine & _
                                                        "Untuk menyimpan pilih Yes, No untuk mengulang?", "Konfirmasi", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button1)
        If result = System.Windows.Forms.DialogResult.Yes Then
            Dim comon As New common
            Dim errMsg As String = ""
            If comon.passwordOke(errMsg, txoldPass.Text.Trim(), mdlCom.UserLogin) Then
                If (Me.txPassNew.Text.Trim() = Me.txPassNext.Text.Trim()) Then
                    If comon.updatePassword(Me.txPassNew.Text.Trim(), mdlCom.UserLogin) Then
                        mdlCom.ShowInfo("Password berhasil diubah.")
                        Me.Close()
                    Else
                        mdlCom.ShowWarning("Error Update database." & errMsg)
                    End If
                Else
                    mdlCom.ShowWarning("Password Baru dan Konfirmasi harus Sama!.")
                End If
            Else
                mdlCom.ShowWarning("Password Lama Salah!.")
            End If
        Else
            Return
        End If
    End Sub

    Private Sub txoldPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txoldPass.KeyPress
        Select Case e.KeyChar
            Case Chr(13)
                txPassNew.Focus()
                txPassNew.SelectAll()
                e.Handled = True
                Exit Select
        End Select
    End Sub

    Private Sub txPassNew_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txPassNew.KeyPress
        Select Case e.KeyChar
            Case Chr(13)
                txPassNext.Focus()
                txPassNext.SelectAll()
                e.Handled = True
                Exit Select
        End Select
    End Sub
End Class