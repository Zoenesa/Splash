Imports System.IO
Imports Microsoft.VisualBasic.CompilerServices
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FormUtama

    Public Sub New()

        InitializeComponent()

        Telerik.WinControls.RadMessageBox.Instance.AllowTheming = True
        Telerik.WinControls.RadMessageBox.Instance.ControlBox = False
        Telerik.WinControls.RadMessageBox.ShowInTaskbar = True
        Telerik.WinControls.RadMessageBox.ThemeName = Me.Office2010BlackTheme1.ThemeName

        Me.LogOut()

        ControlSetting = New Setting.Config.Profile.Ini(IO.Path.Combine(Environment.CurrentDirectory, "Config", "Config.ini"))

    End Sub

    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SuspendLayout()
        StatusVersi.Text = ""
        StatusVersi.Text = My.Application.Info.Title.ToString & " V" & My.Application.Info.Version.ToString
        RadDateAndTimeStatus.Text = DateTime.Now.ToString("dddd, dd-MM-yy")
        Me.ResumeLayout()
        Call MenuKoneksiDatabaseClick(Me, e)
    End Sub

#Region "Deklarasi dan Dim"
    'Deklarasi
    Public Shared ControlSetting As Setting.Config.Profile.Profile
    Public Shared tempForm As Form
    Private Config_iniFile As String = "Config.ini"
    Public Shared DirektoriImages As String = (Path.Combine(Environment.CurrentDirectory, "Images"))
    Public Shared CaptionInfo As String = "I N F O R M A S I"
    Public Shared CaptionEkslamasi As String = "P E R H A T I A N"
    Public Shared CaptionError As String = "K E S A L A H A N"
    Public Shared CaptionTanya As String = "K O N F I R M A S I"

#End Region

#Region "Fungi, Enum Dan Metode"

    Public Enum Batasan
        Administrator = 0
        StandarUser = 1
        Tamu = 2
        Superuser = 3
    End Enum

    Public Sub CommandPilihanKoneksiDatabase()
        If Konektor.mdlSQL.IsLogin Then
            Beep()
            If (RadMessageBox.Show("Dengan Memilih database lain, session ini akan otomatis logout," &
                                   vbNewLine & "Apakah anda ingin logout?", CaptionEkslamasi,
                                   MessageBoxButtons.YesNo, RadMessageIcon.Question,
                                   MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes) AndAlso Me.LogOut Then
                Dim formPilih As New rFormInisialisasiKoneksi
                If (formPilih.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
                    Me.SetelMenu()
                End If
                formPilih.Dispose()
                formPilih = Nothing
            End If
        ElseIf (My.Forms.rFormInisialisasiKoneksi.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            Me.SetelMenu()
        End If
        Me.IsMdiContainer = True
    End Sub

    Public Shared Sub CommandBukaFormMdi(ByVal ChildForm As Form)
        With ChildForm
            .MdiParent = FormUtama
            .Show()
        End With
    End Sub

    Public Shared Sub CommandBukaFormDialog(ByRef DialogForm As Form)
        DialogForm = New Form
        With DialogForm
            .ShowDialog()
        End With
    End Sub

    Public Sub CommandMenuPintas()
        rMenuKoneksiDb.Shortcuts.Add(New RadShortcut(Keys.Control, Keys.K))
    End Sub

    Public Shared Sub CommandSetelMenuPintas(ByVal MenuItem As RadMenuItem, ByVal KeyCode As Keys, Optional ByVal KeyModifier As Keys = Keys.Control)
        MenuItem.Shortcuts.Add(New RadShortcut(KeyModifier, KeyCode))
    End Sub

    Public Shared Sub CommandSetelMenuPintas(ByVal MenuItem As RadMenuItem, ByVal KeyCode1 As Keys, ByVal KeyCode2 As Keys, ByVal KeyCode3 As Keys)
        MenuItem.Shortcuts.Add(New RadShortcut(KeyCode1, KeyCode2, KeyCode3))
    End Sub

    Public Shared Function DeteksiBawaanAplikasi() As Boolean
        Dim flag As Boolean
        Dim UserIcon As Icon
        Try
            Dim SettingValue As String = If(
                ControlSetting.GetValue("General", "LogoIcon") = "1", True, False)
            flag = Conversions.ToBoolean(SettingValue)
            Dim NamaIcon As String = ControlSetting.GetValue("General", "Icons")
            If flag Then
                If Not IO.File.Exists(Path.Combine(Environment.CurrentDirectory, NamaIcon)) Then
                    spControl.SaveResource("DefaultLogo.ico", Path.Combine(
                                           Environment.CurrentDirectory))

                End If
                UserIcon = New Icon(IO.Path.Combine(Environment.CurrentDirectory, NamaIcon))
                flag = True
            Else
LoadLogoBawaan:
                UserIcon = New Icon(IO.Path.Combine(Environment.CurrentDirectory, NamaIcon))
                flag = False
            End If
        Catch ex As Exception
            Beep()
            RadMessageBox.Show(ex.Message, CaptionError, MessageBoxButtons.OK,
                               RadMessageIcon.Error, MessageBoxDefaultButton.Button1)
        Finally
            Dim Result As DialogResult = RadMessageBox.Show("Folder Images tidak terdeteksi" &
                               vbNewLine &
                               "Pilih [Yes] untuk setelan Folder Images, sekarang" &
                               vbNewLine & "[No] Aplikasi akan menggenerasi secara otomatis.",
                               CaptionInfo, MessageBoxButtons.YesNo)
            Dim fd As New FolderBrowserDialog
            If Result = DialogResult.Yes Then
                fd.Description = "Pilih Folder Images"
                fd.ShowNewFolderButton = False
                UserIcon = New Icon(fd.SelectedPath & "DefaultLogo.ico")
            Else

            End If
        End Try
        Return flag
    End Function

    Private Sub FilterEnableMenu(ByVal flag As Boolean, Optional ByVal noProfile As Boolean = False)
        If Not noProfile Then
            Me.Text = "Splash Database"
            rMenuLogout.Enabled = flag
            rMenuSetingdb.Enabled = flag
            rMenuInvoiceItem.Enabled = flag
            rMenuPurchase.Enabled = flag
            rMenuWorkSalesOrder.Enabled = flag
            rMenuDataProject.Enabled = flag
            rMenuResumeOrder.Enabled = flag
            rMenuItemBarang.Enabled = flag
            rMenuRefCustomer.Enabled = flag
            rMenuAdministrasi.Enabled = flag
            rMenuInputData.Enabled = flag
            rDataTeknis.Enabled = flag
        Else
            rMenuLogout.Enabled = flag
        End If
        Konektor.mdlSQL.IsLogin = flag
    End Sub

    Public Sub KeluarAplikasi()
        Dim errMsg As String = ""
        Try
            If Konektor.mdlSQL.CloseDb(errMsg) Then
                Application.Exit()
            ElseIf RadMessageBox.Show("Gagal menutup koneksi database." &
                                      errMsg & vbNewLine & "Apakah anda tetap keluar?",
                                      CaptionTanya, MessageBoxButtons.OKCancel,
                                      RadMessageIcon.Question,
                                      MessageBoxDefaultButton.Button2) <> System.Windows.Forms.DialogResult.OK Then
                Application.Exit()
            End If
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim num As Integer = DirectCast(RadMessageBox.Show("Kesalahan. :" &
             ex.Source, CaptionError, MessageBoxButtons.OK, RadMessageIcon.Error,
             MessageBoxDefaultButton.Button1, ex.Message), Integer)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Function LogOut() As Boolean
        If Me.MdiChildren.Length > 0 Then
            RadMessageBox.Show("Masih ada Form terbuka!",
                               CaptionInfo & " Logout", MessageBoxButtons.OK,
                               RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return False
        End If
        Dim errMsg As String = ""
        If Konektor.mdlSQL.CloseDb(errMsg) Then
            Me.FilterEnableMenu(False, False)
            Return True
        End If
        Dim num As Integer = DirectCast(RadMessageBox.Show("Gagal menutup koneksi database" &
                             errMsg, CaptionError & " Logout", MessageBoxButtons.OK,
                             RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1), Integer)
        Return False
    End Function

    Public Shared Sub SetelanIconUser(ByVal Flag As Boolean, ByRef form As RadForm)
        Dim UserIcon As Icon
        Try
            Dim strFlag As String = If((ControlSetting.GetValue("General", "LogoIcon") = 1), True, False)
            Flag = Conversions.ToBoolean(strFlag)
            If Flag Then
                UserIcon = New Icon(IO.Path.Combine(
                                    Environment.CurrentDirectory, spControl.GetDataSetting(
                                    spControl.PilihanProfile.Aplikasi, "General", "Icons")))
            Else
                UserIcon = New Icon(IO.Path.Combine(Environment.CurrentDirectory,
                                                    "DefaultLogo.ico"))
            End If
            form.Icon = UserIcon
            form.ShowIcon = True
        Catch ex As Exception
            RadMessageBox.Show(ex.Message, CaptionError, MessageBoxButtons.OK,
                               RadMessageIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Public Shared Sub SetelanTema(ByVal Control As System.Windows.Forms.Control, ByVal NamaTema As String)
        Dim radControl As IComponentTreeHandler = TryCast(Control, IComponentTreeHandler)
        If radControl IsNot Nothing Then
            radControl.ThemeName = NamaTema
        End If
        For Each ControlChild As Control In Control.Controls
            SetelanTema(ControlChild, NamaTema)
        Next
    End Sub

    Private Sub SetelTemaDipilih(NamaTema As String)
        ThemeResolutionService.ApplyThemeToControlTree(Me, NamaTema)
    End Sub

    Private Sub SetelMenu()
        Dim FormLogin As New rFormLogin
        Dim num As Integer = CInt(FormLogin.ShowDialog())
        FormLogin.Dispose()
        FormLogin = Nothing
        If (num = 1) Then
            Me.FilterEnableMenu(True, False)
        ElseIf (num = 6) Then
            Me.FilterEnableMenu(True, True)
        Else
            Me.FilterEnableMenu(False, False)
        End If
    End Sub

    Private Sub CommandOpenFormWithPriviliges(ByVal Priviliges As Batasan, ByVal NamaForm As Form)
        Select Case Priviliges
            Case Batasan.Administrator, Batasan.Superuser
                GoTo LabelCekUserLogin
            Case Batasan.StandarUser
                GoTo labelCekUserRole
            Case Batasan.Tamu

        End Select
LabelCekUserLogin:
        Select Case Konektor.mdlSQL.UserRole
            Case "Administrator"
                CommandBukaFormMdi(NamaForm)
            Case Else
                RadMessageBox.Show("Hanya ADMINISTRATOR yang berhak mengakses menu ini.",
                                   CaptionTanya, MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End Select
labelCekUserRole:
        Select Case Konektor.mdlSQL.V_Role(3)
            Case "0"
                RadMessageBox.Show("Anda tidak berhak mengakses menu ini.",
                                                   CaptionEkslamasi, MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Case "1"
                CommandBukaFormMdi(NamaForm)
        End Select
    End Sub
#End Region

    'Perintah Menu
#Region "Perintah Command Menu"

    Private Sub MenuKoneksiDatabaseClick(ByVal sender As Object, ByVal e As EventArgs) Handles rMenuKoneksiDb.Click
        CommandPilihanKoneksiDatabase()
    End Sub

    Private Sub rMenuLogoutClick(ByVal sender As Object, ByVal e As EventArgs) Handles rMenuLogout.Click
        If Me.LogOut Then
            Me.IsMdiContainer = False
        End If
    End Sub

    Private Sub rMenuSettingdbClick(ByVal sender As Object, ByVal e As EventArgs) Handles rMenuSetingdb.Click
        FormUtama.tempForm = rFormDatabaseSetup
        If (Konektor.mdlSQL.V_Role(3) <> "1") Then
            If Not (Konektor.mdlSQL.UserRole = "Administrator") Then
                RadMessageBox.Show("Hanya ADMINISTRATOR yang berhak mengakses menu ini.", "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
                Exit Sub
            End If
            Beep()
            Dim Result As DialogResult = RadMessageBox.Show("Anda memerlukan Permission dari Administrator!" & vbNewLine &
                                                            "Dengan memilih Yes, Silahkan hubungi Administrator untuk input Permission" & vbNewLine _
                                                            & "Pilih No untuk membatalkan", "Perhatian", MessageBoxButtons.OKCancel, RadMessageIcon.Question, MessageBoxDefaultButton.Button2)
            If Result = System.Windows.Forms.DialogResult.Cancel Then
                Return
            Else
                Dim rShowPermission As New rFormPermission
                rShowPermission.ShowDialog()
            End If
        Else
            FormUtama.CommandBukaFormMdi(FormUtama.tempForm)
        End If
    End Sub

    Private Sub rMenuExitClick(ByVal sender As Object, ByVal e As EventArgs) Handles rMenuExit.Click
        'Application.Exit()
        KeluarAplikasi()
    End Sub

    Private Sub CommandBukaFormSebagaiAdministrator(ByVal NamaForm As Form)
        If (Konektor.mdlSQL.UserRole = "Administrator") Then
            CommandBukaFormMdi(NamaForm)
        Else
            RadMessageBox.Show("Hanya ADMINISTRATOR yang berhak mengakses Menu ini!", CaptionEkslamasi,
                               MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If
    End Sub

    Private Sub CommandBukaFormStandarUser(ByVal NamaForm As Form)
        If (Konektor.mdlSQL.V_Role(3) = "1") Then
            CommandBukaFormMdi(NamaForm)
        Else
            RadMessageBox.Show("Anda tidak berhak mengakses Menu ini!", CaptionEkslamasi,
                               MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If
    End Sub

    Private Sub rMenuInvoiceItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles rMenuInvoiceItem.Click
        CommandBukaFormSebagaiAdministrator(rFormDataListInvoice)
    End Sub

    Private Sub rMenuPembayaranClick(ByVal sender As Object, ByVal e As EventArgs) Handles rMenuPembayaran.Click
        If Not (Konektor.mdlSQL.V_Role(0) = "00") Then
            If Not (Konektor.mdlSQL.UserRole = "Administrator") Then
                RadMessageBox.Show("Hanya ADMINISTRATOR yang berhak mengakses menu ini.",
                                  CaptionEkslamasi, MessageBoxButtons.OK,
                                   RadMessageIcon.Exclamation)
                Exit Sub
            End If
        End If
        CommandBukaFormMdi(rFormKonfirmasiPembayaran)
    End Sub

    Private Sub rMenuImportInvoiceItemClick(sender As Object, e As EventArgs) Handles rMenuImportInvoiceItem.Click
        FormUtama.tempForm = rFormImport
        tempForm.ShowDialog()
    End Sub

    Private Sub rMenuPurchaseOrderItemClick(sender As Object, e As EventArgs) Handles rMenuPurchaseOrderItem.Click

    End Sub

    Private Sub rMenuSalesOrderItemClick(sender As Object, e As EventArgs) Handles rMenuSalesOrderItem.Click
        CommandOpenFormWithPriviliges(Batasan.Administrator, rFormListWorkOrder)
    End Sub

    Private Sub rMenuCustomerListItem_Click(sender As Object, e As EventArgs) Handles rMenuCustomerListItem.Click
        CommandBukaFormSebagaiAdministrator(rFormListPelanggan)
    End Sub

    Private Sub rMenuItemBarang_Click(sender As Object, e As EventArgs) Handles rMenuItemBarang.Click
        CommandBukaFormStandarUser(rFormDaftarBarang)
    End Sub


#End Region
End Class