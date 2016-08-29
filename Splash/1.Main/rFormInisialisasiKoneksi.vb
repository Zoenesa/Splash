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
            Dim num As Integer = DirectCast(RadMessageBox.Show("Error." & errMsg, "Error", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1), Integer)
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

        Try
            If Not IO.File.Exists(IO.Path.Combine(Environment.CurrentDirectory, mprofile.Name)) Then
                SetDefaultSettings(IO.Path.Combine(Environment.CurrentDirectory, mprofile.Name))

                'Dim sw As New IO.StreamWriter(IO.Path.Combine(Environment.CurrentDirectory, mprofile.Name))
                'sw.WriteLine("\\PROGRAM SPLASH DATA PROJECT")
                'sw.WriteLine("\\DO NOT DELETE OR CHANGE CONTENT ON THIS CONFIG FILE")
                'sw.WriteLine("\\RISK CHANGING OR DELETING WILL CAUSE DAMAGE OR CORRUPTION DATA")
                'sw.WriteLine("\\DILARANG MERUBAH ATAUPUN MENGHAPUS KONTEN DI FILE CONFIG INI")
                'sw.WriteLine("\\RESIKO MENGUBAH ATAUPUN MENGHAPUS KONTEN DI FILE INI AKAN MENYEBABKAN KERUSAKAN ATAUPUN DATA KORUP")
                'sw.WriteLine("Aplikasi:" & My.Application.Info.AssemblyName)
                'sw.WriteLine("Versi:" & My.Application.Info.Version.ToString)
                'sw.WriteLine("OS:" & My.Computer.Info.OSFullName)
                'sw.WriteLine("Komputer:" & My.Computer.Name)
                'sw.WriteLine("[General]")
                'sw.WriteLine("ConnectionName=Splash_Connection")
                'sw.WriteLine("DatabaseName=db_apps")
                'sw.WriteLine("Server=localhost")
                'sw.WriteLine("User=SUPERVISOR")
                'sw.WriteLine("Password=di5t0rti0n")
                'sw.WriteLine("Port=3306")
                'sw.WriteLine("defaultsetting=True")
                'sw.WriteLine("SettingName=0")
                'sw.WriteLine("SectionName=General")
                'sw.WriteLine("BackupLocation=\backups")
                'sw.WriteLine("Icons=myico.ico")
                'sw.Flush()
                'sw.Close()

            End If

            Dim strdefault As String = mprofile.GetValue("General", "defaultsetting")

            If strdefault = "True" Then
                strSection = mprofile.GetValue("General", "SectionName")
            End If

            Dim tempPass As String = mprofile.GetValue(strSection, "Password")

            Dim ImportPassword As String = CodeLibs.CodeMethod.Decrypt_TRIPLEDES(tempPass, mdlstring.defaultKey)

            txdbname.Text = mprofile.GetValue(strSection, "DatabaseName")
            txserver.Text = mprofile.GetValue(strSection, "server")
            txPort.Text = mprofile.GetValue(strSection, "port")
            txUser.Text = mprofile.GetValue(strSection, "user")

            'txPass.Text = mprofile.GetValue(strSection, "password")
            txPass.Text = ImportPassword

        Catch ex As Exception
            RadMessageBox.Show("Kesalahan, Kode: " & ex.Source & vbNewLine &
                               ex.Message.ToString, "LOAD SETTING", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Public Shared Sub SetDefaultSettings(ByVal filepath As String)
        Dim fs As IO.FileStream
        fs = IO.File.Create(filepath)
        Try

            mdlstring.WriteGeneralSetting(True, fs, "\\PROGRAM SPLASH DATA PROJECT")
            mdlstring.WriteGeneralSetting(True, fs, "\\DO NOT DELETE OR CHANGE CONTENT ON THIS CONFIG FILE")
            mdlstring.WriteGeneralSetting(True, fs, "\\RISK CHANGING OR DELETING WILL CAUSE DAMAGE OR CORRUPTION DATA")
            mdlstring.WriteGeneralSetting(True, fs, "\\DILARANG MERUBAH ATAUPUN MENGHAPUS KONTEN DI FILE CONFIG INI")
            mdlstring.WriteGeneralSetting(True, fs, "\\RESIKO MENGUBAH ATAUPUN MENGHAPUS KONTEN DI FILE INI AKAN MENYEBABKAN KERUSAKAN ATAUPUN DATA KORUP")
            mdlstring.WriteGeneralSetting(True, fs, "Aplikasi:" & My.Application.Info.AssemblyName)
            mdlstring.WriteGeneralSetting(True, fs, "Versi:" & My.Application.Info.Version.ToString)
            mdlstring.WriteGeneralSetting(True, fs, "OS:" & My.Computer.Info.OSFullName)
            mdlstring.WriteGeneralSetting(True, fs, "Komputer:" & My.Computer.Name)
            mdlstring.WriteGeneralSetting(True, fs, "[General]")
            mdlstring.WriteGeneralSetting(True, fs, "ConnectionName=Splash_Connection")
            mdlstring.WriteGeneralSetting(True, fs, "DatabaseName=db_apps")
            mdlstring.WriteGeneralSetting(True, fs, "Server=localhost")
            mdlstring.WriteGeneralSetting(True, fs, "User=SUPERVISOR")
            mdlstring.WriteGeneralSetting(True, fs, "Password=di5t0rti0n")
            mdlstring.WriteGeneralSetting(True, fs, "Port=3306")
            mdlstring.WriteGeneralSetting(True, fs, "defaultsetting=True")
            mdlstring.WriteGeneralSetting(True, fs, "SettingName=0")
            mdlstring.WriteGeneralSetting(True, fs, "SectionName=General")
            mdlstring.WriteGeneralSetting(True, fs, "BackupLocation=\backups")
            mdlstring.WriteGeneralSetting(True, fs, "Icons=myico.ico")

            fs.Close()

        Catch ex As Exception
            fs.Close()
            RadMessageBox.Show("Kesalahan Fatal!" & vbNewLine & "Error." & ex.Message.ToString, "SET DEFAULT SETTING", MessageBoxButtons.OK,
                               RadMessageIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub FrmInisialisasiKoneksi_Load(sender As Object, e As EventArgs) Handles Me.Load
        rFormMain.SetTheme(Me, rFormMain.Office2010BlackTheme1.ThemeName.ToString)
        rFormMain.LoadIcon(True, Me)
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