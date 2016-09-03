Imports MySql.Data.MySqlClient
Imports Telerik, Telerik.WinControls, Telerik.WinControls.UI
Imports Microsoft.VisualBasic.CompilerServices
Imports Splash.Konektor

Public Class rFormPermission

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Telerik.WinControls.RadMessageBox.Instance.AllowTheming = True
        Telerik.WinControls.RadMessageBox.Instance.ControlBox = False
        Telerik.WinControls.RadMessageBox.ShowInTaskbar = False
        Telerik.WinControls.RadMessageBox.ThemeName = rFormMain.Office2010BlackTheme1.ThemeName
        rFormMain.SetTheme(Me, rFormMain.Office2010BlackTheme1.ThemeName.ToString)
    End Sub
    Private Sub KonfirmasiPermission(ByVal rForm As Form)
        Try
            mdlCom.BukaKoneksi()
            Dim sqlreader As MySqlDataReader = New MySqlCommand("SELECT `Password`, `KdGroup`, `JobTitle` FROM `user` WHERE `Kdgroup` = '" &
                                                                mdlstring.ADD_QUOTE_ON_SQL("00") & "' AND `Password` = '" &
                                                                rTxPassword.Text & "'", mdlCom.vConn).ExecuteReader
            If sqlreader.HasRows Then
                sqlreader.Read()
                If Operators.CompareObjectEqual(rTxPassword.Text.Trim(), sqlreader.Item("Password").ToString, False) Then
                    Me.Dispose()
                    RadMessageBox.Show("Hak akses sukses telah diberikan!", "Terima Kasih." & sqlreader.Item("JobTitle").ToString, MessageBoxButtons.OK, RadMessageIcon.Info)
                    rFormMain.BukaFormChild(rForm)
                Else
                    Beep()
                    Dim Result As DialogResult = RadMessageBox.Show("Password Administrator Anda Salah!                 " & vbNewLine &
                    "Apakah anda ingin mengulang lagi?                 ", "Perhatian", MessageBoxButtons.YesNo, RadMessageIcon.Question)
                    If Result = System.Windows.Forms.DialogResult.Yes Then
                        rTxPassword.Focus()
                        rTxPassword.SelectAll()
                        sqlreader.Close()
                        Return
                    Else
                        sqlreader.Close()
                        Me.Close()
                    End If
                End If
            Else
                RadMessageBox.Show("Password tidak ditemukan!" & vbNewLine &
                "UserRole Nothing!", "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
                sqlreader.Close()
                rTxPassword.Focus()
                Return
            End If
            sqlreader.Close()
            Me.Close()
        Catch ex As Exception
            RadMessageBox.Show("(Failed get permission).Message: " & ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rform As New Form
        rform = rFormMain.tempForm
        KonfirmasiPermission(rform)
    End Sub

    Private Sub rTxPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rTxPassword.KeyPress
        Select Case e.KeyChar
            Case Chr(13)
                Button1.Focus()
        End Select
    End Sub

    Private Sub rFormPermission_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.TaskManagerClosing Then
            e.Cancel = True
        End If
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
        End If
    End Sub

    Private Sub rFormPermission_Load(sender As Object, e As EventArgs) Handles Me.Load
        rFormMain.SetTheme(Me, rFormMain.Office2010BlackTheme1.ThemeName.ToString)
        rFormMain.LoadIcon(True, Me)

        rTxPassword.Focus()
        rTxPassword.SelectAll()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
End Class