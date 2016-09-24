Imports Telerik, Telerik.WinControls, Telerik.WinControls.UI
Imports Microsoft.VisualBasic.CompilerServices
Imports MySql.Data.MySqlClient
Imports System.Threading, System.Reflection
Imports System.Text
Imports System.IO
Imports Splash.Konektor


Public Class rFormMain

    Public Shared tempForm As Form

    Public Shared ModulSetting As Setting.Config.Profile.Profile

    Private Const FileiniSetting As String = "Config.ini"

    Public Shared ImageFolder As String = (IO.Path.Combine(Environment.CurrentDirectory, "Images"))

    Public Sub New()

        MyBase.New()

        m_bLayoutCall = False



        ImageFolder = (IO.Path.Combine(Environment.CurrentDirectory, "Images"))
        AddHandler MyBase.Layout, New LayoutEventHandler(AddressOf Me.CallLayout)

        InitializeComponent()

        Telerik.WinControls.RadMessageBox.Instance.AllowTheming = True
        Telerik.WinControls.RadMessageBox.Instance.ControlBox = False
        Telerik.WinControls.RadMessageBox.ShowInTaskbar = False
        Telerik.WinControls.RadMessageBox.ThemeName = Me.Office2010BlackTheme1.ThemeName

        Me.Logout()

        ModulSetting = New Setting.Config.Profile.Ini(IO.Path.Combine(Environment.CurrentDirectory, "Config", FileiniSetting))

        CallLayout()

        InisialShorcutMenu()
    End Sub

    Public Shared MainSectionSetting As String = "Splash"
    Public Shared MainEntryAplikasiName As String = "NamaAplikasi"
    Public Shared MainEntryVersiName As String = "Versi"
    Public Shared MainEntryDeskripsiName As String = "Deskripsi"

    <STAThread>
    Public Shared Sub InisialisasiStartUp()

    End Sub

    Public Shared Function ValidasiFileSetting() As Boolean
        Try
            If IO.File.Exists(IO.Path.Combine(Environment.CurrentDirectory, "Config", FileiniSetting)) Then

            Else
                If Not IO.Directory.Exists(IO.Path.Combine(Environment.CurrentDirectory, "Config")) Then
                    IO.Directory.CreateDirectory(IO.Path.Combine(Environment.CurrentDirectory, "Config"))
                End If

                Dim sw As New IO.StreamWriter(IO.Path.Combine(Environment.CurrentDirectory, "Config", FileiniSetting))
                sw.WriteLine("\\PROGRAM SPLASH DATA PROJECT")
                sw.WriteLine("\\DO NOT DELETE OR CHANGE CONTENT ON THIS CONFIG FILE")
                sw.WriteLine("\\RISK CHANGING OR DELETING WILL CAUSE DAMAGE OR CORRUPTION DATA")
                sw.WriteLine("\\DILARANG MERUBAH ATAUPUN MENGHAPUS KONTEN DI FILE CONFIG INI")
                sw.WriteLine("\\RESIKO MENGUBAH ATAUPUN MENGHAPUS KONTEN DI FILE INI AKAN MENYEBABKAN KERUSAKAN ATAUPUN")
                sw.WriteLine("Aplikasi " & My.Application.Info.AssemblyName)
                sw.WriteLine("Versi " & My.Application.Info.Version.ToString)
                sw.WriteLine("OS " & If(Environment.Is64BitOperatingSystem, "X64", "X86") & " " & Environment.OSVersion.ToString)
                sw.WriteLine("Machine " & Environment.MachineName.ToString)
                sw.Flush()
                sw.Close()

                ModulSetting.SetValue(MainSectionSetting, "Setting", "myIco")

            End If

        Catch ex As Exception
            RadMessageBox.Show("Gagal Validasi Setting, Error: " & ex.Message, "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return False
        End Try
        Return True
    End Function

    Private Sub CekFolderAplikasi()
        Dim flag1 As Boolean

        flag1 = IO.Directory.Exists(IO.Path.Combine(Environment.CurrentDirectory, "Config"))

        If Not flag1 Then
            GoTo LabelFolderConfig
        End If

        Dim flag2 As Boolean

        flag2 = IO.Directory.Exists(IO.Path.Combine(Environment.CurrentDirectory, "Images"))

        If Not flag2 Then
            GoTo LabelFolderImage
        End If

        Dim flag3 As Boolean

        flag3 = IO.Directory.Exists(IO.Path.Combine(Environment.CurrentDirectory, "Libs"))

        If Not flag3 Then
            GoTo LabelFolderImage
        End If

        Dim flag4 As Boolean

        If Not flag4 Then

        End If

LabelFolderConfig:
        IO.Directory.CreateDirectory(IO.Path.Combine(Environment.CurrentDirectory, "Config"))
        ValidasiConfigPertama()
        Return
LabelFolderImage:
        IO.Directory.CreateDirectory(IO.Path.Combine(Environment.CurrentDirectory, "Images"))

        Return
LabelFolderLibs:
        IO.Directory.CreateDirectory(IO.Path.Combine(Environment.CurrentDirectory, "Libs"))
        Return
LabelFolderBackup:
        IO.Directory.CreateDirectory(IO.Path.Combine(Environment.CurrentDirectory, "backups"))

        Return
    End Sub

    Private Sub ValidasiConfigPertama()
        Try
            Dim sw As New IO.StreamWriter(IO.Path.Combine(Environment.CurrentDirectory, "Config"))
            sw.WriteLine("\\PROGRAM SPLASH DATA PROJECT")
            sw.WriteLine("\\DO NOT DELETE OR CHANGE CONTENT ON THIS CONFIG FILE")
            sw.WriteLine("\\RISK CHANGING OR DELETING WILL CAUSE DAMAGE OR CORRUPTION DATA")
            sw.WriteLine("\\DILARANG MERUBAH ATAUPUN MENGHAPUS KONTEN DI FILE CONFIG INI")
            sw.WriteLine("\\RESIKO MENGUBAH ATAUPUN MENGHAPUS KONTEN DI FILE INI AKAN MENYEBABKAN KERUSAKAN ATAUPUN")
            sw.WriteLine("Aplikasi " & My.Application.Info.AssemblyName)
            sw.WriteLine("Versi " & My.Application.Info.Version.ToString)
            sw.WriteLine("OS " & If(Environment.Is64BitOperatingSystem, "X64", "X86") & " " & Environment.OSVersion.ToString)
            sw.WriteLine("Machine " & Environment.MachineName.ToString)
            sw.Flush()
            sw.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ValidasiImagePertama()
        Try
            SaveResource("Splash.My.Resources.Resource.myIco", (IO.Path.Combine(Environment.CurrentDirectory, "myIco.ico")))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ValidasiLibsPertama()
        Try
            SaveResource("Splash", (IO.Path.Combine(Environment.CurrentDirectory, "myIco.ico")))
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub LoadIcon(ByVal flagIcon As Boolean, ByVal form As RadForm)

        Dim FilePath As String = IO.Path.GetFullPath(IO.Path.Combine(ImageFolder, "myIco.ico"))
        Dim ImgIcon As Icon = Nothing
        Dim mprofile As Setting.Config.Profile.Ini = New Setting.Config.Profile.Ini
        Dim Entry As String = "Icons"
        Dim settingValue As String = "myico.ico"

        If flagIcon Then
            form.ShowIcon = True
            If Not (IO.File.Exists(FilePath)) Then
                If Not IO.Directory.Exists(ImageFolder) Then
                    IO.Directory.CreateDirectory(ImageFolder)
                End If
                SaveResource("myIco.ico", FilePath)
                ModulSetting.SetValue("General", "Icons", "myIco.ico")
                ImgIcon = GetEmbedIconResource("Splash.My.Resources.Resources.myIco")
            Else
                Dim FileIcon As String = ModulSetting.GetValue("General", "Icons")
                If ModulSetting.HasEntry("General", "Icons") Then
                    If Not String.IsNullOrWhiteSpace(FileIcon) Then
                        ImgIcon = New Icon(IO.Path.Combine(ImageFolder, FileIcon))
                    End If
                Else
                    ImgIcon = GetEmbedIconResource("myIco.ico")
                End If
            End If
            form.Icon = ImgIcon
            Dim strArray As Array = GetEmbedResource("Splash.My.Resources")
        Else
            form.ShowIcon = False
        End If
    End Sub

    Private Shared Function GetEmbedResource(ByVal ResourceName As String) As Array
        Return System.Reflection.Assembly.GetExecutingAssembly.GetManifestResourceNames
    End Function

    Private Shared Function GetEmbedIconResource(ByVal IconName As String) As Icon
        Return New Icon(System.Reflection.Assembly.
                        GetExecutingAssembly.
                        GetManifestResourceStream(IconName))
    End Function

    Public Shared Sub SaveResource(ByVal resName As String, filename As String)
        ' Get a reference to the running application.
        Dim assy As [Assembly] = [Assembly].GetExecutingAssembly()
        ' Loop through each resource, looking for the image name (case-insensitive).
        For Each resource As String In assy.GetManifestResourceNames()
            If resource.ToLower().IndexOf(resName.ToLower) <> -1 Then
                ' Get the embedded file from the assembly as a MemoryStream.
                Using resourceStream As System.IO.Stream = assy.GetManifestResourceStream(resource)
                    If resourceStream IsNot Nothing Then
                        Using reader As New BinaryReader(resourceStream)
                            ' Read the bytes from the input stream.
                            Dim buffer() As Byte = reader.ReadBytes(CInt(resourceStream.Length))
                            Using outputStream As New FileStream(filename, FileMode.Create)
                                Using writer As New BinaryWriter(outputStream)
                                    ' Write the bytes to the output stream.
                                    writer.Write(buffer)
                                End Using
                            End Using
                        End Using
                    End If
                End Using
                Exit For
            End If
        Next resource
        'Subrutin / Caller
        'SaveToDisk([Resource Name with Extension-use the same case as used in the filename], [Output path with FileName & extension])
    End Sub

    Public Sub KeluarAplikasi()
        Dim errMsg As String = ""
        Try
            If Konektor.mdlCom.CloseDb(errMsg) Then
                KeluarAplikasi()
            ElseIf RadMessageBox.Show("Gagal menutup koneksi database." & errMsg & vbNewLine & "Apakah anda tetap keluar?", "Konfirmasi", MessageBoxButtons.OKCancel, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) <> System.Windows.Forms.DialogResult.OK Then
                KeluarAplikasi()
            End If
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim num As Integer = DirectCast(RadMessageBox.Show("Error." & ex.Source, "Error", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1, ex.Message), Integer)
        End Try
    End Sub

    Public Sub BukaPilihanKoneksi()
        If Konektor.mdlCom.IsLogin Then
            Beep()
            If (RadMessageBox.Show("Dengan Memilih database lain, session ini akan otomatis logout," & vbNewLine & "Apakah anda ingin logout?", "Perhatian", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes) AndAlso Me.Logout Then
                Dim formPilih As New rFormInisialisasiKoneksi
                If (formPilih.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
                    Me.SetMenu()
                End If
                formPilih.Dispose()
                formPilih = Nothing
            End If
        ElseIf (My.Forms.rFormInisialisasiKoneksi.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            Me.SetMenu()
        End If
    End Sub

    Private Sub SetMenu()
        Dim FormLogin As New rFormLogin
        Dim num As Integer = CInt(FormLogin.ShowDialog())
        FormLogin.Dispose()
        FormLogin = Nothing
        If (num = 1) Then
            Me.EnableMenu(True, False)
        ElseIf (num = 6) Then
            Me.EnableMenu(True, True)
        Else
            Me.EnableMenu(False, False)
        End If
    End Sub

    Private Sub EnableMenu(ByVal flag As Boolean, Optional ByVal noProfile As Boolean = False)
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
        Konektor.mdlCom.IsLogin = flag
    End Sub

    Private Function Logout() As Boolean
        If Me.MdiChildren.Length > 0 Then
            RadMessageBox.Show("Masih ada Form terbuka!", "Logout", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return False
        End If
        Dim errMsg As String = ""
        If Konektor.mdlCom.CloseDb(errMsg) Then
            Me.EnableMenu(False, False)
            Return True
        End If
        Dim num As Integer = DirectCast(RadMessageBox.Show("Gagal menutup koneksi database" & errMsg, "Logout", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1), Integer)
        Return False
    End Function

    Public Shared Sub BukaFormChild(ByVal ChildForm As Form)
        With ChildForm
            .MdiParent = rFormMain
            .Show()
        End With
    End Sub

    Public Shared Sub BukaFormDialog(ByRef rForm As Form)
        rForm = New Form
        With rForm
            .ShowDialog()
        End With
    End Sub

    Public Shared Sub SetTheme(ByVal sControl As Control, ByVal sTheme As String)
        Try
            sTheme = rFormMain.Office2010BlackTheme1.ThemeName
            Dim iRadControl As IComponentTreeHandler =
                TryCast(sControl, IComponentTreeHandler)
            If iRadControl IsNot Nothing Then
                iRadControl.ThemeName = sTheme
            End If
            For Each sChild As Control In sControl.Controls
                SetTheme(sChild, sTheme)
            Next
        Catch ex As Exception
            RadMessageBox.Show("Could not load setup theme :" & vbNewLine _
                                               & ex.Source & vbNewLine & "Click &Details for more Information",
                                               "Error", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message)
        End Try
    End Sub

    Private m_bLayoutCall As Boolean
    Private m_dt As DateTime

    Private Sub CallLayout()
        If Not Me.m_bLayoutCall Then
            Me.m_bLayoutCall = True
            Me.m_dt = DateTime.Now
            FormStartUp.CloseForm()
        End If
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.SuspendLayout()
        If ValidasiFileSetting() Then
            LoadIcon(True, Me)
        End If
        Me.ResumeLayout()
        StatusVersi.Text = ""
        StatusVersi.Text = My.Application.Info.Title.ToString & " V" & My.Application.Info.Version.ToString
        RadDateAndTimeStatus.Text = DateTime.Now.ToString("dddd, dd-MM-yy")

        Call rMenuKoneksiDb_Click(Me, e)
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Web_Update.Main()
    End Sub

    Private Sub rMenuKoneksiDb_Click(sender As Object, e As EventArgs) Handles rMenuKoneksiDb.Click
        BukaPilihanKoneksi()
    End Sub

    Private Sub rMenuSetingdb_Click(sender As Object, e As EventArgs) Handles rMenuSetingdb.Click
        rFormMain.tempForm = rFormDatabaseSetup
        If (Konektor.mdlCom.V_Role(3) <> "1") Then
            If (Not Konektor.mdlCom.UserRole = "Administrator") Then
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
            rFormMain.BukaFormChild(rFormDatabaseSetup)
        End If
    End Sub

    Private Sub rMenuExit_Click(sender As Object, e As EventArgs) Handles rMenuExit.Click
        Application.Exit()
    End Sub

    Private Sub rMenuInvoiceItem_Click(sender As Object, e As EventArgs) Handles rMenuInvoiceItem.Click
        If (Konektor.mdlCom.JobDesk = "Administrator") Or (Konektor.mdlCom.JobDesk = "Pemasaran") Or (Konektor.mdlCom.JobDesk = "Superuser") Or (Konektor.mdlCom.UserRole = "Administrator") Then
            BukaFormChild(rFormDataListInvoice)
        Else
            RadMessageBox.Show("Anda tidak berhak mengakses Menu ini!", "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If
    End Sub

    Private Sub rUpdate_Click(sender As Object, e As EventArgs) Handles rUpdate.Click
        Web_Update.Main()
    End Sub

    Private Sub rMenuLogout_Click(sender As Object, e As EventArgs) Handles rMenuLogout.Click
        If Me.Logout Then
            Me.IsMdiContainer = False
        End If
    End Sub

    Private Sub rMenuImportInvoiceItem_Click(sender As Object, e As EventArgs) Handles rMenuImportInvoiceItem.Click
        rFormMain.tempForm = rFormImport
        If Not (Konektor.mdlCom.UserRole = "Administrator") Then
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
            BukaFormChild(rFormImport)
        End If
    End Sub

    Private Sub rMenuExportInvoiceItem_Click(sender As Object, e As EventArgs) Handles rMenuExportInvoiceItem.Click
        Try
            Dim rformexport As New rFormExportCSV
            rformexport.ShowDialog()

        Catch ex As Exception
            RadMessageBox.Show(ex.ToString, "Error Export", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End Try
    End Sub

    Private Sub rMenuCustomerListItem_Click(sender As Object, e As EventArgs) Handles rMenuCustomerListItem.Click
        'BukaFormChild(FrmCustomerReference)
        'BukaFormChild(rFormListPelanggan)
        Dim dataPelanggan As New rFormListPelanggan
        Dim num As Integer = DirectCast(dataPelanggan.BukaDialogDataPelanggan(False, "Pilih Data Pelanggan"), Integer)
        dataPelanggan.Dispose()
        dataPelanggan = Nothing
    End Sub

    Private Sub rMenuImportCustomerItem_Click(sender As Object, e As EventArgs) Handles rMenuImportCustomerItem.Click

    End Sub

    Private Sub rMenuExportCustomerItem_Click(sender As Object, e As EventArgs) Handles rMenuExportCustomerItem.Click

    End Sub

    Private Sub rMenuPurchaseOrderItem_Click(sender As Object, e As EventArgs) Handles rMenuPurchaseOrderItem.Click

    End Sub

    Private Sub rMenuPurchase_Click(sender As Object, e As EventArgs) Handles rMenuPurchase.Click

    End Sub

    Private Sub rMenuImportPurchaseItem_Click(sender As Object, e As EventArgs) Handles rMenuImportPurchaseItem.Click

    End Sub

    Private Sub rMenuExportPurchaseItem_Click(sender As Object, e As EventArgs) Handles rMenuExportPurchaseItem.Click

    End Sub

    Private Sub rMenuWODataItem_Click(sender As Object, e As EventArgs) Handles rMenuSalesOrderItem.Click
        BukaFormChild(rFormListWorkOrder)
    End Sub

    Private Sub rMenuImportWOSPKItem_Click(sender As Object, e As EventArgs) Handles rMenuImportWOSPKItem.Click

    End Sub

    Private Sub rMenuExportWOSPKItem_Click(sender As Object, e As EventArgs) Handles rMenuExportWOSPKItem.Click

    End Sub

    Private Sub rMenuDaftarProjectItem_Click(sender As Object, e As EventArgs) Handles rMenuDaftarProjectItem.Click

    End Sub

    Private Sub rMenuSwitchProjectItem_Click(sender As Object, e As EventArgs) Handles rMenuSwitchProjectItem.Click

    End Sub

    Private Sub rMenuCreatePenawaranItem_Click(sender As Object, e As EventArgs) Handles rMenuCreatePenawaranItem.Click

    End Sub

    Private Sub rMenuItemBarang_Click(sender As Object, e As EventArgs) Handles rMenuItemBarang.Click
        Dim formDaftarBarang As New rFormDaftarBarang
        rFormMain.BukaFormChild(formDaftarBarang)
    End Sub

    Private Sub rMenuRefCustomer_Click(sender As Object, e As EventArgs) Handles rMenuRefCustomer.Click

    End Sub

    Private Sub rMenuUserDataItem_Click(sender As Object, e As EventArgs) Handles rMenuUserDataItem.Click
        If (Not Konektor.mdlCom.V_Role(0) = "00") Then
            If (Not Konektor.mdlCom.UserRole = "Administrator") Then
                RadMessageBox.Show("Hanya ADMINISTRATOR yang berhak mengakses menu ini.", "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
                Exit Sub
            End If
        End If
        BukaFormChild(rFormUsersList)
    End Sub

    Private Sub rMenuChangePassword_Click(sender As Object, e As EventArgs) Handles rMenuChangePassword.Click
        Dim FormUbahPass As New rFormGantiPassword
        FormUbahPass.ShowDialog()
    End Sub

    Private Sub rHelp_Click(sender As Object, e As EventArgs) Handles rHelp.Click

    End Sub

    Private Sub rAppInfo_Click(sender As Object, e As EventArgs) Handles rAppInfo.Click

    End Sub

    Private Sub rMenuDataProject_Click(sender As Object, e As EventArgs) Handles rMenuDataProject.Click

    End Sub

    Private Sub rBackupDatabaseMenuItem_Click(sender As Object, e As EventArgs)
        Dim rFormBackup As New rFormBackupdb
        rFormBackup.ShowDialog()
    End Sub

    Private Sub RadMenuItem1_Click_1(sender As Object, e As EventArgs)
        BukaFormChild(frmImportPartner)
    End Sub

    Private Sub rMenuPembayaran_Click(sender As Object, e As EventArgs) Handles rMenuPembayaran.Click
        If (Not Konektor.mdlCom.V_Role(0) = "00") Then
            If (Not Konektor.mdlCom.UserRole = "Administrator") Then
                RadMessageBox.Show("Hanya ADMINISTRATOR yang berhak mengakses menu ini.", "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
                Exit Sub
            End If
        End If
        BukaFormChild(rFormKonfirmasiPembayaran)
    End Sub

    Private Sub RadMenuItemBAST_Click(sender As Object, e As EventArgs) Handles RadMenuItemBAST.Click
        BukaFormChild(FormBAST)
    End Sub

    Private Sub Countersql(ByVal NamaField As String, ByVal tableName As String, Optional ByVal Opsi As String = "")
        Dim sqlCommand As New MySqlCommand
        sqlCommand.CommandText = String.Format("SELECT TABLE_NAME, TABLE_ROWS, CREATE_TIME,  FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = " & Opsi)
        sqlCommand.Connection = Konektor.mdlCom.vConn
        Dim sqlreader As MySqlDataReader
        sqlreader = sqlCommand.ExecuteReader
        Dim fieldNames As String() = New String(3 - 1) {}
        RadGridView1.Rows.Clear()
        Dim dt As New DataTable
        Do While sqlreader.Read
            fieldNames(0) = sqlreader.Item("TABLE_NAME")
            fieldNames(1) = sqlreader.Item("TABLE_ROWS")
            RadGridView1.Rows.Add(fieldNames)
        Loop
        sqlreader.Close()
    End Sub

    Private Sub getTableSchema(ByVal NamaSchema As String, Optional ByVal Opsi As String = "")
        Dim errmsg As String = Nothing
        Try
            RadGridView1.Rows.Clear()
            Dim dt As New DataTable
            Dim common As New common
            If common.LoadTableSchema(errmsg, dt, NamaSchema, Opsi) Then
                Dim values As String() = New String(2 - 1) {}
                Dim num As Integer = (dt.Rows.Count - 1)
                Dim i As Integer = 0

                Do While (i <= num)
                    Dim row As DataRow = dt.Rows.Item(i)
                    values(0) = Conversions.ToString(row.Item("TABLE_NAME"))
                    values(1) = Conversions.ToString(row.Item("TABLE_ROWS"))
                    Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM " & dt.Rows.Count, Konektor.mdlCom.vConn)
                    Dim sqlreader As MySqlDataReader
                    sqlreader = cmd.ExecuteReader
                    sqlreader.Read()
                    values(2) = sqlreader.Item("")
                    Interlocked.Increment(i)
                    RadGridView1.Rows.Add(values)
                Loop
            Else
                Konektor.mdlCom.ShowError(errmsg)
            End If
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private sList As New List(Of String)

    Private sBuilderString As String
    Private Sub StrBuilder()
        If sList.Count > 0 Then
            Dim sb As New StringBuilder
            For Each sTemp As String In sList
                sb.Append(sTemp).Append(" ")
            Next
            sBuilderString = sb.ToString
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadMenuItemCompanyProfile_Click(sender As Object, e As EventArgs) Handles RadMenuItemCompanyProfile.Click
        Dim formCompany As New FormProfilPerusahaan
        formCompany.ModeBuka(False)
        formCompany.Dispose()
        formCompany = Nothing
    End Sub

    Private Sub rMenudbUtility_Click(sender As Object, e As EventArgs) Handles rMenudbUtility.Click
        Dim advDBbackup As New FormAdvancedSqlBackup
        BukaFormChild(advDBbackup)
    End Sub

    Private Sub rMenuCloseAllmdiClient_Click(sender As Object, e As EventArgs) Handles rMenuCloseAllmdiClient.Click
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next frm
    End Sub

    Private Sub InisialShorcutMenu()
        rMenuKoneksiDb.Shortcuts.Add(New RadShortcut(Keys.Control, Keys.K))
        rMenuSetingdb.Shortcuts.Add(New RadShortcut(Keys.Control, Keys.A))
        rMenuExit.Shortcuts.Add(New RadShortcut(Keys.Alt, Keys.F4))
        rMenuInvoiceItem.Shortcuts.Add(New RadShortcut(Keys.Control, Keys.Shift, Keys.C))
    End Sub
End Class