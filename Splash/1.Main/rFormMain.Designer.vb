<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rFormMain
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rFormMain))
        Me.rMainMenu = New Telerik.WinControls.UI.RadMenuItem()
        Me.rMenuKoneksiDb = New Telerik.WinControls.UI.RadMenuItem()
        Me.rMenuLogout = New Telerik.WinControls.UI.RadMenuItem()
        Me.rMenuSetingdb = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
        Me.rMenuExit = New Telerik.WinControls.UI.RadMenuItem()
        Me.Office2010BlackTheme1 = New Telerik.WinControls.Themes.Office2010BlackTheme()
        Me.rMenuPurchase = New Telerik.WinControls.UI.RadMenuItem()
        Me.rMenuPurchaseOrderItem = New Telerik.WinControls.UI.RadMenuItem()
        Me.rMenuImportPurchaseItem = New Telerik.WinControls.UI.RadMenuItem()
        Me.rMenuExportPurchaseItem = New Telerik.WinControls.UI.RadMenuItem()
        Me.rMenuWorkSalesOrder = New Telerik.WinControls.UI.RadMenuItem()
        Me.rMenuSalesOrderItem = New Telerik.WinControls.UI.RadMenuItem()
        Me.rMenuWorkOrderItem = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItemBAST = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuSeparatorItem4 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
        Me.rMenuImportWOSPKItem = New Telerik.WinControls.UI.RadMenuItem()
        Me.rMenuExportWOSPKItem = New Telerik.WinControls.UI.RadMenuItem()
        Me.rMenuInputData = New Telerik.WinControls.UI.RadMenuItem()
        Me.rMenuInvoiceData = New Telerik.WinControls.UI.RadMenuItem()
        Me.rMenuInvoiceItem = New Telerik.WinControls.UI.RadMenuItem()
        Me.rMenuPembayaran = New Telerik.WinControls.UI.RadMenuItem()
        Me.rMenuImportInvoiceItem = New Telerik.WinControls.UI.RadMenuItem()
        Me.rMenuExportInvoiceItem = New Telerik.WinControls.UI.RadMenuItem()
        Me.rMenuCustomer = New Telerik.WinControls.UI.RadMenuItem()
        Me.rMenuCustomerListItem = New Telerik.WinControls.UI.RadMenuItem()
        Me.rMenuImportCustomerItem = New Telerik.WinControls.UI.RadMenuItem()
        Me.rMenuExportCustomerItem = New Telerik.WinControls.UI.RadMenuItem()
        Me.rDataTeknis = New Telerik.WinControls.UI.RadMenuItem()
        Me.rMenuDataProject = New Telerik.WinControls.UI.RadMenuItem()
        Me.rMenuDaftarProjectItem = New Telerik.WinControls.UI.RadMenuItem()
        Me.rMenuSwitchProjectItem = New Telerik.WinControls.UI.RadMenuItem()
        Me.rMenuResumeOrder = New Telerik.WinControls.UI.RadMenuItem()
        Me.rMenuCreatePenawaranItem = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
        Me.rMenuAdministrasi = New Telerik.WinControls.UI.RadMenuItem()
        Me.rMenuItemBarang = New Telerik.WinControls.UI.RadMenuItem()
        Me.rMenuRefCustomer = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuSeparatorItem3 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
        Me.rMenuAdmUser = New Telerik.WinControls.UI.RadMenuItem()
        Me.rMenuUserDataItem = New Telerik.WinControls.UI.RadMenuItem()
        Me.rMenuChangePassword = New Telerik.WinControls.UI.RadMenuItem()
        Me.rMenudbUtility = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItemCompanyProfile = New Telerik.WinControls.UI.RadMenuItem()
        Me.rAbout = New Telerik.WinControls.UI.RadMenuItem()
        Me.rHelp = New Telerik.WinControls.UI.RadMenuItem()
        Me.rUpdate = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuSeparatorItem2 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
        Me.rAppInfo = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.StatusVersi = New Telerik.WinControls.UI.RadLabelElement()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.RadStatusDeskripsi = New Telerik.WinControls.UI.RadLabelElement()
        Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.RadDateAndTimeStatus = New Telerik.WinControls.UI.RadLabelElement()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.rMenuWindowItm = New Telerik.WinControls.UI.RadMenuItem()
        Me.rMenuCloseAllmdiClient = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuSeparatorItem5 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
        Me.RadMenu1 = New Telerik.WinControls.UI.RadMenu()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rMainMenu
        '
        Me.rMainMenu.Items.AddRange(New Telerik.WinControls.RadItem() {Me.rMenuKoneksiDb, Me.rMenuLogout, Me.rMenuSetingdb, Me.RadMenuSeparatorItem1, Me.rMenuExit})
        Me.rMainMenu.Name = "rMainMenu"
        Me.rMainMenu.Padding = New System.Windows.Forms.Padding(18, 1, 8, 1)
        Me.rMainMenu.Text = "&Menu Utama"
        '
        'rMenuKoneksiDb
        '
        Me.rMenuKoneksiDb.AccessibleDescription = "RadMenuItem2"
        Me.rMenuKoneksiDb.AccessibleName = "RadMenuItem2"
        Me.rMenuKoneksiDb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rMenuKoneksiDb.Name = "rMenuKoneksiDb"
        Me.rMenuKoneksiDb.Text = "&Koneksi Database"
        '
        'rMenuLogout
        '
        Me.rMenuLogout.Enabled = False
        Me.rMenuLogout.Name = "rMenuLogout"
        Me.rMenuLogout.Text = "&Sign Out"
        '
        'rMenuSetingdb
        '
        Me.rMenuSetingdb.AccessibleDescription = "RadMenuItem3"
        Me.rMenuSetingdb.AccessibleName = "RadMenuItem3"
        Me.rMenuSetingdb.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rMenuSetingdb.Name = "rMenuSetingdb"
        Me.rMenuSetingdb.Text = "&Administrasi Database"
        '
        'RadMenuSeparatorItem1
        '
        Me.RadMenuSeparatorItem1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadMenuSeparatorItem1.Name = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.Text = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rMenuExit
        '
        Me.rMenuExit.AccessibleDescription = "RadMenuItem4"
        Me.rMenuExit.AccessibleName = "RadMenuItem4"
        Me.rMenuExit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rMenuExit.Name = "rMenuExit"
        Me.rMenuExit.Text = "E&xit"
        '
        'rMenuPurchase
        '
        Me.rMenuPurchase.AccessibleDescription = "RadMenuItem5"
        Me.rMenuPurchase.AccessibleName = "RadMenuItem5"
        Me.rMenuPurchase.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rMenuPurchase.Items.AddRange(New Telerik.WinControls.RadItem() {Me.rMenuPurchaseOrderItem, Me.rMenuImportPurchaseItem, Me.rMenuExportPurchaseItem})
        Me.rMenuPurchase.Name = "rMenuPurchase"
        Me.rMenuPurchase.Text = "&Purchasing / Pemesanan Barang"
        '
        'rMenuPurchaseOrderItem
        '
        Me.rMenuPurchaseOrderItem.AccessibleDescription = "RadMenuItem8"
        Me.rMenuPurchaseOrderItem.AccessibleName = "RadMenuItem8"
        Me.rMenuPurchaseOrderItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rMenuPurchaseOrderItem.Name = "rMenuPurchaseOrderItem"
        Me.rMenuPurchaseOrderItem.Text = "Purchase &Order"
        '
        'rMenuImportPurchaseItem
        '
        Me.rMenuImportPurchaseItem.AccessibleDescription = "RadMenuItem9"
        Me.rMenuImportPurchaseItem.AccessibleName = "RadMenuItem9"
        Me.rMenuImportPurchaseItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rMenuImportPurchaseItem.Name = "rMenuImportPurchaseItem"
        Me.rMenuImportPurchaseItem.Text = "&Import Data"
        '
        'rMenuExportPurchaseItem
        '
        Me.rMenuExportPurchaseItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rMenuExportPurchaseItem.Name = "rMenuExportPurchaseItem"
        Me.rMenuExportPurchaseItem.Text = "&Export CSV"
        '
        'rMenuWorkSalesOrder
        '
        Me.rMenuWorkSalesOrder.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rMenuWorkSalesOrder.Items.AddRange(New Telerik.WinControls.RadItem() {Me.rMenuSalesOrderItem, Me.rMenuWorkOrderItem, Me.RadMenuItemBAST, Me.RadMenuSeparatorItem4, Me.rMenuImportWOSPKItem, Me.rMenuExportWOSPKItem})
        Me.rMenuWorkSalesOrder.Name = "rMenuWorkSalesOrder"
        Me.rMenuWorkSalesOrder.Text = "&Work Order/Sales Order/SPK"
        '
        'rMenuSalesOrderItem
        '
        Me.rMenuSalesOrderItem.AccessibleDescription = "RadMenuItem11"
        Me.rMenuSalesOrderItem.AccessibleName = "RadMenuItem11"
        Me.rMenuSalesOrderItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rMenuSalesOrderItem.Name = "rMenuSalesOrderItem"
        Me.rMenuSalesOrderItem.Text = "&Sales Order"
        '
        'rMenuWorkOrderItem
        '
        Me.rMenuWorkOrderItem.AccessibleDescription = "&WOrk Order"
        Me.rMenuWorkOrderItem.AccessibleName = "&WOrk Order"
        Me.rMenuWorkOrderItem.Name = "rMenuWorkOrderItem"
        Me.rMenuWorkOrderItem.Text = "&Work Order"
        '
        'RadMenuItemBAST
        '
        Me.RadMenuItemBAST.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadMenuItemBAST.Name = "RadMenuItemBAST"
        Me.RadMenuItemBAST.Text = "BA&ST"
        '
        'RadMenuSeparatorItem4
        '
        Me.RadMenuSeparatorItem4.Name = "RadMenuSeparatorItem4"
        Me.RadMenuSeparatorItem4.Text = "RadMenuSeparatorItem4"
        Me.RadMenuSeparatorItem4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rMenuImportWOSPKItem
        '
        Me.rMenuImportWOSPKItem.AccessibleDescription = "RadMenuItem12"
        Me.rMenuImportWOSPKItem.AccessibleName = "RadMenuItem12"
        Me.rMenuImportWOSPKItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rMenuImportWOSPKItem.Name = "rMenuImportWOSPKItem"
        Me.rMenuImportWOSPKItem.Text = "&Import Data"
        '
        'rMenuExportWOSPKItem
        '
        Me.rMenuExportWOSPKItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rMenuExportWOSPKItem.Name = "rMenuExportWOSPKItem"
        Me.rMenuExportWOSPKItem.Text = "&Export CSV"
        '
        'rMenuInputData
        '
        Me.rMenuInputData.Items.AddRange(New Telerik.WinControls.RadItem() {Me.rMenuInvoiceData, Me.rMenuCustomer, Me.rMenuPurchase, Me.rMenuWorkSalesOrder})
        Me.rMenuInputData.Name = "rMenuInputData"
        Me.rMenuInputData.Padding = New System.Windows.Forms.Padding(8, 1, 8, 1)
        Me.rMenuInputData.Text = "&Input Data"
        '
        'rMenuInvoiceData
        '
        Me.rMenuInvoiceData.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rMenuInvoiceData.Items.AddRange(New Telerik.WinControls.RadItem() {Me.rMenuInvoiceItem, Me.rMenuPembayaran, Me.rMenuImportInvoiceItem, Me.rMenuExportInvoiceItem})
        Me.rMenuInvoiceData.Name = "rMenuInvoiceData"
        Me.rMenuInvoiceData.Text = "Data &Invoice"
        '
        'rMenuInvoiceItem
        '
        Me.rMenuInvoiceItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rMenuInvoiceItem.Name = "rMenuInvoiceItem"
        Me.rMenuInvoiceItem.Text = "&Daftar Invoice"
        '
        'rMenuPembayaran
        '
        Me.rMenuPembayaran.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rMenuPembayaran.Name = "rMenuPembayaran"
        Me.rMenuPembayaran.Text = "&Pembayaran"
        '
        'rMenuImportInvoiceItem
        '
        Me.rMenuImportInvoiceItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rMenuImportInvoiceItem.Name = "rMenuImportInvoiceItem"
        Me.rMenuImportInvoiceItem.Text = "&Import Data"
        '
        'rMenuExportInvoiceItem
        '
        Me.rMenuExportInvoiceItem.AccessibleDescription = "RadMenuItem14"
        Me.rMenuExportInvoiceItem.AccessibleName = "RadMenuItem14"
        Me.rMenuExportInvoiceItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rMenuExportInvoiceItem.Name = "rMenuExportInvoiceItem"
        Me.rMenuExportInvoiceItem.Text = "&Export CSV"
        '
        'rMenuCustomer
        '
        Me.rMenuCustomer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rMenuCustomer.Items.AddRange(New Telerik.WinControls.RadItem() {Me.rMenuCustomerListItem, Me.rMenuImportCustomerItem, Me.rMenuExportCustomerItem})
        Me.rMenuCustomer.Name = "rMenuCustomer"
        Me.rMenuCustomer.Text = "Data &Customer / Pelanggan"
        '
        'rMenuCustomerListItem
        '
        Me.rMenuCustomerListItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rMenuCustomerListItem.Name = "rMenuCustomerListItem"
        Me.rMenuCustomerListItem.Text = "Daftar &Customer"
        '
        'rMenuImportCustomerItem
        '
        Me.rMenuImportCustomerItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rMenuImportCustomerItem.Name = "rMenuImportCustomerItem"
        Me.rMenuImportCustomerItem.Text = "&Import Customer"
        '
        'rMenuExportCustomerItem
        '
        Me.rMenuExportCustomerItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rMenuExportCustomerItem.Name = "rMenuExportCustomerItem"
        Me.rMenuExportCustomerItem.Text = "&Export CSV"
        '
        'rDataTeknis
        '
        Me.rDataTeknis.Items.AddRange(New Telerik.WinControls.RadItem() {Me.rMenuDataProject, Me.rMenuResumeOrder, Me.RadMenuItem1})
        Me.rDataTeknis.Name = "rDataTeknis"
        Me.rDataTeknis.Padding = New System.Windows.Forms.Padding(8, 1, 8, 1)
        Me.rDataTeknis.Text = "&Data Teknis"
        '
        'rMenuDataProject
        '
        Me.rMenuDataProject.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rMenuDataProject.Items.AddRange(New Telerik.WinControls.RadItem() {Me.rMenuDaftarProjectItem, Me.rMenuSwitchProjectItem})
        Me.rMenuDataProject.Name = "rMenuDataProject"
        Me.rMenuDataProject.Text = "Data &Project"
        '
        'rMenuDaftarProjectItem
        '
        Me.rMenuDaftarProjectItem.AccessibleDescription = "RadMenuItem1"
        Me.rMenuDaftarProjectItem.AccessibleName = "RadMenuItem1"
        Me.rMenuDaftarProjectItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rMenuDaftarProjectItem.Name = "rMenuDaftarProjectItem"
        Me.rMenuDaftarProjectItem.Text = "Daftar &Project"
        '
        'rMenuSwitchProjectItem
        '
        Me.rMenuSwitchProjectItem.AccessibleDescription = "RadMenuItem5"
        Me.rMenuSwitchProjectItem.AccessibleName = "RadMenuItem5"
        Me.rMenuSwitchProjectItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rMenuSwitchProjectItem.Name = "rMenuSwitchProjectItem"
        Me.rMenuSwitchProjectItem.Text = "Pilih &Data Project"
        '
        'rMenuResumeOrder
        '
        Me.rMenuResumeOrder.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rMenuResumeOrder.Items.AddRange(New Telerik.WinControls.RadItem() {Me.rMenuCreatePenawaranItem})
        Me.rMenuResumeOrder.Name = "rMenuResumeOrder"
        Me.rMenuResumeOrder.Text = "&Resume Order / Penawaran"
        '
        'rMenuCreatePenawaranItem
        '
        Me.rMenuCreatePenawaranItem.AccessibleDescription = "RadMenuItem10"
        Me.rMenuCreatePenawaranItem.AccessibleName = "RadMenuItem10"
        Me.rMenuCreatePenawaranItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rMenuCreatePenawaranItem.Name = "rMenuCreatePenawaranItem"
        Me.rMenuCreatePenawaranItem.Text = "Buat &Penawaran"
        '
        'RadMenuItem1
        '
        Me.RadMenuItem1.Name = "RadMenuItem1"
        Me.RadMenuItem1.Text = "&Hitung Volume"
        '
        'rMenuAdministrasi
        '
        Me.rMenuAdministrasi.Items.AddRange(New Telerik.WinControls.RadItem() {Me.rMenuItemBarang, Me.rMenuRefCustomer, Me.RadMenuSeparatorItem3, Me.rMenuAdmUser, Me.rMenudbUtility, Me.RadMenuItemCompanyProfile})
        Me.rMenuAdministrasi.Name = "rMenuAdministrasi"
        Me.rMenuAdministrasi.Padding = New System.Windows.Forms.Padding(8, 1, 8, 1)
        Me.rMenuAdministrasi.Text = "&Administrasi"
        '
        'rMenuItemBarang
        '
        Me.rMenuItemBarang.AccessibleDescription = "RadMenuItem2"
        Me.rMenuItemBarang.AccessibleName = "RadMenuItem2"
        Me.rMenuItemBarang.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rMenuItemBarang.Name = "rMenuItemBarang"
        Me.rMenuItemBarang.Text = "Item &Barang"
        '
        'rMenuRefCustomer
        '
        Me.rMenuRefCustomer.AccessibleDescription = "RadMenuItem3"
        Me.rMenuRefCustomer.AccessibleName = "RadMenuItem3"
        Me.rMenuRefCustomer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rMenuRefCustomer.Name = "rMenuRefCustomer"
        Me.rMenuRefCustomer.Text = "Referensi &Customer"
        '
        'RadMenuSeparatorItem3
        '
        Me.RadMenuSeparatorItem3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadMenuSeparatorItem3.Name = "RadMenuSeparatorItem3"
        Me.RadMenuSeparatorItem3.Text = "RadMenuSeparatorItem3"
        Me.RadMenuSeparatorItem3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rMenuAdmUser
        '
        Me.rMenuAdmUser.AccessibleDescription = "RadMenuItem8"
        Me.rMenuAdmUser.AccessibleName = "RadMenuItem8"
        Me.rMenuAdmUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rMenuAdmUser.Items.AddRange(New Telerik.WinControls.RadItem() {Me.rMenuUserDataItem, Me.rMenuChangePassword})
        Me.rMenuAdmUser.Name = "rMenuAdmUser"
        Me.rMenuAdmUser.Text = "A&dministrasi User"
        '
        'rMenuUserDataItem
        '
        Me.rMenuUserDataItem.AccessibleDescription = "User &Data"
        Me.rMenuUserDataItem.AccessibleName = "User &Data"
        Me.rMenuUserDataItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rMenuUserDataItem.Name = "rMenuUserDataItem"
        Me.rMenuUserDataItem.Text = "&User Data"
        '
        'rMenuChangePassword
        '
        Me.rMenuChangePassword.AccessibleDescription = "Tambah &User"
        Me.rMenuChangePassword.AccessibleName = "Tambah &User"
        Me.rMenuChangePassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rMenuChangePassword.Name = "rMenuChangePassword"
        Me.rMenuChangePassword.Text = "Ganti &Password"
        '
        'rMenudbUtility
        '
        Me.rMenudbUtility.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rMenudbUtility.Name = "rMenudbUtility"
        Me.rMenudbUtility.Text = "Database &Utility"
        '
        'RadMenuItemCompanyProfile
        '
        Me.RadMenuItemCompanyProfile.Name = "RadMenuItemCompanyProfile"
        Me.RadMenuItemCompanyProfile.Text = "&Profile Perusahaan"
        '
        'rAbout
        '
        Me.rAbout.AccessibleDescription = "&About"
        Me.rAbout.AccessibleName = "&About"
        Me.rAbout.Items.AddRange(New Telerik.WinControls.RadItem() {Me.rHelp, Me.rUpdate, Me.RadMenuSeparatorItem2, Me.rAppInfo})
        Me.rAbout.Name = "rAbout"
        Me.rAbout.Padding = New System.Windows.Forms.Padding(8, 1, 8, 1)
        Me.rAbout.Text = "&Help"
        '
        'rHelp
        '
        Me.rHelp.AccessibleDescription = "RadMenuItem4"
        Me.rHelp.AccessibleName = "RadMenuItem4"
        Me.rHelp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rHelp.Name = "rHelp"
        Me.rHelp.Text = "&Bantuan ?"
        '
        'rUpdate
        '
        Me.rUpdate.AccessibleDescription = "RadMenuItem6"
        Me.rUpdate.AccessibleName = "RadMenuItem6"
        Me.rUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rUpdate.Name = "rUpdate"
        Me.rUpdate.Text = "&Update"
        '
        'RadMenuSeparatorItem2
        '
        Me.RadMenuSeparatorItem2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadMenuSeparatorItem2.Name = "RadMenuSeparatorItem2"
        Me.RadMenuSeparatorItem2.Text = "RadMenuSeparatorItem2"
        Me.RadMenuSeparatorItem2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rAppInfo
        '
        Me.rAppInfo.AccessibleDescription = "RadMenuItem7"
        Me.rAppInfo.AccessibleName = "RadMenuItem7"
        Me.rAppInfo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rAppInfo.Name = "rAppInfo"
        Me.rAppInfo.Text = "&Info Aplikasi"
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.StatusVersi, Me.CommandBarSeparator1, Me.RadStatusDeskripsi, Me.CommandBarSeparator2, Me.RadDateAndTimeStatus})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 322)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(804, 22)
        Me.RadStatusStrip1.TabIndex = 5
        Me.RadStatusStrip1.Text = "RadStatusStrip1"
        Me.RadStatusStrip1.ThemeName = "Office2010Black"
        '
        'StatusVersi
        '
        Me.StatusVersi.Name = "StatusVersi"
        Me.StatusVersi.Padding = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.RadStatusStrip1.SetSpring(Me.StatusVersi, False)
        Me.StatusVersi.Text = "Status"
        Me.StatusVersi.TextWrap = True
        '
        'CommandBarSeparator1
        '
        Me.CommandBarSeparator1.AccessibleDescription = "CommandBarSeparator1"
        Me.CommandBarSeparator1.AccessibleName = "CommandBarSeparator1"
        Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
        Me.RadStatusStrip1.SetSpring(Me.CommandBarSeparator1, False)
        Me.CommandBarSeparator1.VisibleInOverflowMenu = False
        '
        'RadStatusDeskripsi
        '
        Me.RadStatusDeskripsi.Name = "RadStatusDeskripsi"
        Me.RadStatusDeskripsi.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.RadStatusStrip1.SetSpring(Me.RadStatusDeskripsi, True)
        Me.RadStatusDeskripsi.Text = "Deskripsi"
        Me.RadStatusDeskripsi.TextWrap = True
        '
        'CommandBarSeparator2
        '
        Me.CommandBarSeparator2.AccessibleDescription = "CommandBarSeparator2"
        Me.CommandBarSeparator2.AccessibleName = "CommandBarSeparator2"
        Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
        Me.RadStatusStrip1.SetSpring(Me.CommandBarSeparator2, False)
        Me.CommandBarSeparator2.VisibleInOverflowMenu = False
        '
        'RadDateAndTimeStatus
        '
        Me.RadDateAndTimeStatus.Name = "RadDateAndTimeStatus"
        Me.RadStatusStrip1.SetSpring(Me.RadDateAndTimeStatus, False)
        Me.RadDateAndTimeStatus.Text = "DateAndTime"
        Me.RadDateAndTimeStatus.TextWrap = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 120
        '
        'rMenuWindowItm
        '
        Me.rMenuWindowItm.Items.AddRange(New Telerik.WinControls.RadItem() {Me.rMenuCloseAllmdiClient, Me.RadMenuSeparatorItem5})
        Me.rMenuWindowItm.MdiList = True
        Me.rMenuWindowItm.Name = "rMenuWindowItm"
        Me.rMenuWindowItm.Padding = New System.Windows.Forms.Padding(8, 1, 8, 1)
        Me.rMenuWindowItm.Text = "Windows"
        '
        'rMenuCloseAllmdiClient
        '
        Me.rMenuCloseAllmdiClient.MdiList = True
        Me.rMenuCloseAllmdiClient.MergeIndex = 45
        Me.rMenuCloseAllmdiClient.MergeOrder = 45
        Me.rMenuCloseAllmdiClient.MergeType = System.Windows.Forms.MenuMerge.MergeItems
        Me.rMenuCloseAllmdiClient.Name = "rMenuCloseAllmdiClient"
        Me.rMenuCloseAllmdiClient.Text = "Tutup Seluruh &Form"
        '
        'RadMenuSeparatorItem5
        '
        Me.RadMenuSeparatorItem5.MergeOrder = 34
        Me.RadMenuSeparatorItem5.MergeType = System.Windows.Forms.MenuMerge.MergeItems
        Me.RadMenuSeparatorItem5.Name = "RadMenuSeparatorItem5"
        Me.RadMenuSeparatorItem5.Text = "RadMenuSeparatorItem5"
        Me.RadMenuSeparatorItem5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadMenu1
        '
        Me.RadMenu1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadMenu1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.rMainMenu, Me.rMenuInputData, Me.rDataTeknis, Me.rMenuAdministrasi, Me.rMenuWindowItm, Me.rAbout})
        Me.RadMenu1.Location = New System.Drawing.Point(0, 0)
        Me.RadMenu1.Name = "RadMenu1"
        Me.RadMenu1.Size = New System.Drawing.Size(804, 22)
        Me.RadMenu1.TabIndex = 3
        Me.RadMenu1.Text = "RadMenu1"
        Me.RadMenu1.ThemeName = "Office2010Black"
        '
        'rFormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 344)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.RadMenu1)
        Me.EnableKeyMap = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "rFormMain"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Splash Database"
        Me.ThemeName = "Office2010Black"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rMainMenu As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rMenuKoneksiDb As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rMenuSetingdb As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
    Friend WithEvents rMenuExit As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents Office2010BlackTheme1 As Telerik.WinControls.Themes.Office2010BlackTheme
    Friend WithEvents rMenuPurchase As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rMenuInputData As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rMenuInvoiceData As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rMenuCustomer As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rDataTeknis As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rMenuAdministrasi As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rAbout As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rMenuInvoiceItem As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rMenuImportInvoiceItem As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rMenuCustomerListItem As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rMenuImportCustomerItem As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rMenuPurchaseOrderItem As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rMenuImportPurchaseItem As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rMenuWorkSalesOrder As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rMenuSalesOrderItem As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rMenuImportWOSPKItem As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rMenuDataProject As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rMenuResumeOrder As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rMenuItemBarang As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rMenuRefCustomer As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rHelp As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rUpdate As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuSeparatorItem2 As Telerik.WinControls.UI.RadMenuSeparatorItem
    Friend WithEvents rAppInfo As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rMenuDaftarProjectItem As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rMenuSwitchProjectItem As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rMenuCreatePenawaranItem As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rMenuExportInvoiceItem As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuSeparatorItem3 As Telerik.WinControls.UI.RadMenuSeparatorItem
    Friend WithEvents rMenuAdmUser As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rMenuExportCustomerItem As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rMenuExportPurchaseItem As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rMenuExportWOSPKItem As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rMenuUserDataItem As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rMenuChangePassword As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents StatusVersi As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents RadStatusDeskripsi As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents RadDateAndTimeStatus As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents rMenuLogout As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rMenudbUtility As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rMenuPembayaran As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rMenuWorkOrderItem As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuSeparatorItem4 As Telerik.WinControls.UI.RadMenuSeparatorItem
    Friend WithEvents RadMenuItemBAST As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadMenuItemCompanyProfile As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItem1 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rMenuWindowItm As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents rMenuCloseAllmdiClient As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuSeparatorItem5 As Telerik.WinControls.UI.RadMenuSeparatorItem
    Friend WithEvents RadMenu1 As Telerik.WinControls.UI.RadMenu
End Class
