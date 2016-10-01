<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rFormDatabaseSetup
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
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rFormDatabaseSetup))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbProfile = New System.Windows.Forms.ComboBox()
        Me.listTbl = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnBackup = New Telerik.WinControls.UI.RadButton()
        Me.btnRestore = New Telerik.WinControls.UI.RadButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button4 = New Telerik.WinControls.UI.RadButton()
        Me.Button2 = New Telerik.WinControls.UI.RadButton()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.RadPageView1 = New Telerik.WinControls.UI.RadPageView()
        Me.RadPageViewPage2 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
        Me.cbSection = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadToggleSwitch1 = New Telerik.WinControls.UI.RadToggleSwitch()
        Me.txPort = New Telerik.WinControls.UI.RadTextBox()
        Me.txPass = New Telerik.WinControls.UI.RadTextBox()
        Me.txUser = New Telerik.WinControls.UI.RadTextBox()
        Me.txHost = New Telerik.WinControls.UI.RadTextBox()
        Me.txdbname = New Telerik.WinControls.UI.RadTextBox()
        Me.txConStr = New Telerik.WinControls.UI.RadTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.RadPageViewPage1 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.cbDropDbFile = New Telerik.WinControls.UI.RadDropDownList()
        Me.btnNewBackupSystem = New Telerik.WinControls.UI.RadButton()
        Me.btnSetFolder = New Telerik.WinControls.UI.RadButton()
        Me.txBackupFolderPath = New Telerik.WinControls.UI.RadTextBox()
        Me.RadPageViewPage3 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.btnBackup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRestore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Button4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageView1.SuspendLayout()
        Me.RadPageViewPage2.SuspendLayout()
        CType(Me.RadCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadToggleSwitch1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txPort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txHost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txdbname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txConStr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageViewPage1.SuspendLayout()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDropDbFile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNewBackupSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSetFolder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txBackupFolderPath, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(78, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Port"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbProfile
        '
        Me.cbProfile.FormattingEnabled = True
        Me.cbProfile.Location = New System.Drawing.Point(325, 94)
        Me.cbProfile.Name = "cbProfile"
        Me.cbProfile.Size = New System.Drawing.Size(153, 21)
        Me.cbProfile.TabIndex = 12
        Me.cbProfile.Visible = False
        '
        'listTbl
        '
        Me.listTbl.FormattingEnabled = True
        Me.listTbl.Location = New System.Drawing.Point(126, 63)
        Me.listTbl.Name = "listTbl"
        Me.listTbl.Size = New System.Drawing.Size(281, 121)
        Me.listTbl.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(35, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 15)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Data Table"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(22, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Database File"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(3, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Backup Location"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnBackup, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnRestore, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 205)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(527, 32)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'btnBackup
        '
        Me.btnBackup.BackColor = System.Drawing.Color.Transparent
        Me.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBackup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBackup.Location = New System.Drawing.Point(3, 3)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(257, 26)
        Me.btnBackup.TabIndex = 12
        Me.btnBackup.Text = "&Backup database"
        Me.btnBackup.ThemeName = "Office2010Black"
        CType(Me.btnBackup.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "&Backup database"
        CType(Me.btnBackup.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.btnBackup.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'btnRestore
        '
        Me.btnRestore.BackColor = System.Drawing.Color.Transparent
        Me.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRestore.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRestore.Location = New System.Drawing.Point(266, 3)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(258, 26)
        Me.btnRestore.TabIndex = 12
        Me.btnRestore.Text = "&Restore database"
        Me.btnRestore.ThemeName = "Office2010Black"
        CType(Me.btnRestore.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "&Restore database"
        CType(Me.btnRestore.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.btnRestore.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Button4, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSave, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 276)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(632, 32)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button4.Location = New System.Drawing.Point(495, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(25, 1, 28, 1)
        Me.Button4.Size = New System.Drawing.Size(134, 26)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "&Keluar"
        Me.Button4.ThemeName = "Office2010Black"
        CType(Me.Button4.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "&Keluar"
        CType(Me.Button4.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Padding = New System.Windows.Forms.Padding(25, 1, 28, 1)
        CType(Me.Button4.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.Button4.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button2.Location = New System.Drawing.Point(3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(20, 1, 8, 1)
        Me.Button2.Size = New System.Drawing.Size(134, 26)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "&Test Koneksi"
        Me.Button2.ThemeName = "Office2010Black"
        CType(Me.Button2.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "&Test Koneksi"
        CType(Me.Button2.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Padding = New System.Windows.Forms.Padding(20, 1, 8, 1)
        CType(Me.Button2.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.Button2.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSave.Location = New System.Drawing.Point(355, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Padding = New System.Windows.Forms.Padding(16, 1, 2, 1)
        Me.btnSave.Size = New System.Drawing.Size(134, 26)
        Me.btnSave.TabIndex = 24
        Me.btnSave.Text = "&Simpan Seting"
        Me.btnSave.ThemeName = "Office2010Black"
        CType(Me.btnSave.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "&Simpan Seting"
        CType(Me.btnSave.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Padding = New System.Windows.Forms.Padding(16, 1, 2, 1)
        CType(Me.btnSave.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.btnSave.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'RadPageView1
        '
        Me.RadPageView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPageView1.Controls.Add(Me.RadPageViewPage2)
        Me.RadPageView1.Controls.Add(Me.RadPageViewPage1)
        Me.RadPageView1.Controls.Add(Me.RadPageViewPage3)
        Me.RadPageView1.DefaultPage = Me.RadPageViewPage2
        Me.RadPageView1.ItemSizeMode = CType((Telerik.WinControls.UI.PageViewItemSizeMode.EqualWidth Or Telerik.WinControls.UI.PageViewItemSizeMode.EqualHeight), Telerik.WinControls.UI.PageViewItemSizeMode)
        Me.RadPageView1.Location = New System.Drawing.Point(2, 2)
        Me.RadPageView1.Name = "RadPageView1"
        Me.RadPageView1.SelectedPage = Me.RadPageViewPage2
        Me.RadPageView1.Size = New System.Drawing.Size(629, 271)
        Me.RadPageView1.TabIndex = 3
        Me.RadPageView1.Text = "RadPageView1"
        Me.RadPageView1.ThemeName = "Office2010Black"
        Me.RadPageView1.ViewMode = Telerik.WinControls.UI.PageViewMode.Stack
        CType(Me.RadPageView1.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStackElement).StackPosition = Telerik.WinControls.UI.StackViewPosition.Left
        '
        'RadPageViewPage2
        '
        Me.RadPageViewPage2.Controls.Add(Me.RadCheckBox1)
        Me.RadPageViewPage2.Controls.Add(Me.cbSection)
        Me.RadPageViewPage2.Controls.Add(Me.RadToggleSwitch1)
        Me.RadPageViewPage2.Controls.Add(Me.txPort)
        Me.RadPageViewPage2.Controls.Add(Me.txPass)
        Me.RadPageViewPage2.Controls.Add(Me.txUser)
        Me.RadPageViewPage2.Controls.Add(Me.txHost)
        Me.RadPageViewPage2.Controls.Add(Me.Label8)
        Me.RadPageViewPage2.Controls.Add(Me.txdbname)
        Me.RadPageViewPage2.Controls.Add(Me.txConStr)
        Me.RadPageViewPage2.Controls.Add(Me.Label10)
        Me.RadPageViewPage2.Controls.Add(Me.Label11)
        Me.RadPageViewPage2.Controls.Add(Me.Label12)
        Me.RadPageViewPage2.Controls.Add(Me.Label13)
        Me.RadPageViewPage2.Controls.Add(Me.Label14)
        Me.RadPageViewPage2.Controls.Add(Me.cbProfile)
        Me.RadPageViewPage2.ItemSize = New System.Drawing.SizeF(27.0!, 239.0!)
        Me.RadPageViewPage2.Location = New System.Drawing.Point(98, 30)
        Me.RadPageViewPage2.Name = "RadPageViewPage2"
        Me.RadPageViewPage2.Size = New System.Drawing.Size(517, 227)
        Me.RadPageViewPage2.Text = "General"
        '
        'RadCheckBox1
        '
        Me.RadCheckBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadCheckBox1.Location = New System.Drawing.Point(299, 181)
        Me.RadCheckBox1.Name = "RadCheckBox1"
        Me.RadCheckBox1.Size = New System.Drawing.Size(97, 19)
        Me.RadCheckBox1.TabIndex = 17
        Me.RadCheckBox1.Text = "Set As &Default"
        Me.RadCheckBox1.ThemeName = "Office2010Black"
        '
        'cbSection
        '
        Me.cbSection.AutoSize = False
        Me.cbSection.BackColor = System.Drawing.Color.Transparent
        Me.cbSection.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RadListDataItem1.Text = "Normal"
        RadListDataItem2.Text = "Revisions"
        Me.cbSection.Items.Add(RadListDataItem1)
        Me.cbSection.Items.Add(RadListDataItem2)
        Me.cbSection.Location = New System.Drawing.Point(112, 179)
        Me.cbSection.Name = "cbSection"
        Me.cbSection.Size = New System.Drawing.Size(178, 23)
        Me.cbSection.TabIndex = 16
        Me.cbSection.ThemeName = "Office2010Black"
        CType(Me.cbSection.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'RadToggleSwitch1
        '
        Me.RadToggleSwitch1.AllowShowFocusCues = True
        Me.RadToggleSwitch1.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.RadToggleSwitch1.Location = New System.Drawing.Point(225, 122)
        Me.RadToggleSwitch1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RadToggleSwitch1.Name = "RadToggleSwitch1"
        Me.RadToggleSwitch1.OffText = "HIDE"
        Me.RadToggleSwitch1.OnText = "SHOW"
        Me.RadToggleSwitch1.Size = New System.Drawing.Size(58, 21)
        Me.RadToggleSwitch1.TabIndex = 23
        Me.RadToggleSwitch1.Text = "Toggle"
        Me.RadToggleSwitch1.ThemeName = "Office2010Black"
        Me.RadToggleSwitch1.ThumbTickness = 25
        CType(Me.RadToggleSwitch1.GetChildAt(0), Telerik.WinControls.UI.RadToggleSwitchElement).ThumbTickness = 25
        CType(Me.RadToggleSwitch1.GetChildAt(0), Telerik.WinControls.UI.RadToggleSwitchElement).ThumbOffset = 33
        CType(Me.RadToggleSwitch1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.ToggleSwitchPartElement).BackColor2 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(48, Byte), Integer))
        CType(Me.RadToggleSwitch1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.ToggleSwitchPartElement).BackColor3 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(151, Byte), Integer))
        CType(Me.RadToggleSwitch1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.ToggleSwitchPartElement).Text = "HIDE"
        CType(Me.RadToggleSwitch1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.ToggleSwitchPartElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        CType(Me.RadToggleSwitch1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.ToggleSwitchPartElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(90, Byte), Integer))
        '
        'txPort
        '
        Me.txPort.AutoSize = False
        Me.txPort.BackColor = System.Drawing.Color.Transparent
        Me.txPort.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txPort.Location = New System.Drawing.Point(112, 150)
        Me.txPort.Name = "txPort"
        Me.txPort.Padding = New System.Windows.Forms.Padding(6, 0, 4, 0)
        Me.txPort.Size = New System.Drawing.Size(66, 23)
        Me.txPort.TabIndex = 20
        Me.txPort.Text = "3306"
        Me.txPort.ThemeName = "Office2010Black"
        CType(Me.txPort.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = "3306"
        CType(Me.txPort.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Padding = New System.Windows.Forms.Padding(6, 0, 4, 0)
        CType(Me.txPort.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txPort.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.txPort.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.SystemColors.Control
        CType(Me.txPort.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.SystemColors.ControlDark
        CType(Me.txPort.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.SystemColors.ControlLightLight
        CType(Me.txPort.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.txPort.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientAngle = 90.0!
        CType(Me.txPort.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage = 1.0!
        CType(Me.txPort.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage2 = 0.666!
        CType(Me.txPort.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'txPass
        '
        Me.txPass.AutoSize = False
        Me.txPass.BackColor = System.Drawing.Color.Transparent
        Me.txPass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txPass.Location = New System.Drawing.Point(112, 121)
        Me.txPass.Margin = New System.Windows.Forms.Padding(3, 3, 60, 3)
        Me.txPass.Name = "txPass"
        Me.txPass.Padding = New System.Windows.Forms.Padding(6, 0, 60, 0)
        Me.txPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txPass.Size = New System.Drawing.Size(172, 23)
        Me.txPass.TabIndex = 19
        Me.txPass.Text = "1234567890000000000"
        Me.txPass.ThemeName = "Office2010Black"
        Me.txPass.UseSystemPasswordChar = True
        CType(Me.txPass.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = "1234567890000000000"
        CType(Me.txPass.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Padding = New System.Windows.Forms.Padding(6, 0, 60, 0)
        CType(Me.txPass.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txPass.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.txPass.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.txPass.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'txUser
        '
        Me.txUser.AutoSize = False
        Me.txUser.BackColor = System.Drawing.Color.Transparent
        Me.txUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txUser.Location = New System.Drawing.Point(112, 92)
        Me.txUser.Name = "txUser"
        Me.txUser.Padding = New System.Windows.Forms.Padding(6, 0, 4, 0)
        Me.txUser.Size = New System.Drawing.Size(172, 23)
        Me.txUser.TabIndex = 18
        Me.txUser.Text = "root"
        Me.txUser.ThemeName = "Office2010Black"
        CType(Me.txUser.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = "root"
        CType(Me.txUser.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Padding = New System.Windows.Forms.Padding(6, 0, 4, 0)
        CType(Me.txUser.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txUser.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.txUser.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.txUser.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'txHost
        '
        Me.txHost.AutoSize = False
        Me.txHost.BackColor = System.Drawing.Color.Transparent
        Me.txHost.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txHost.Location = New System.Drawing.Point(112, 63)
        Me.txHost.Name = "txHost"
        Me.txHost.Padding = New System.Windows.Forms.Padding(6, 0, 4, 0)
        Me.txHost.Size = New System.Drawing.Size(219, 23)
        Me.txHost.TabIndex = 17
        Me.txHost.Text = "localhost"
        Me.txHost.ThemeName = "Office2010Black"
        CType(Me.txHost.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = "localhost"
        CType(Me.txHost.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Padding = New System.Windows.Forms.Padding(6, 0, 4, 0)
        CType(Me.txHost.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txHost.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.txHost.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.txHost.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'txdbname
        '
        Me.txdbname.AutoSize = False
        Me.txdbname.BackColor = System.Drawing.Color.Transparent
        Me.txdbname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txdbname.Location = New System.Drawing.Point(112, 34)
        Me.txdbname.Name = "txdbname"
        Me.txdbname.Padding = New System.Windows.Forms.Padding(6, 0, 4, 0)
        Me.txdbname.Size = New System.Drawing.Size(219, 23)
        Me.txdbname.TabIndex = 8
        Me.txdbname.Text = "db_apps"
        Me.txdbname.ThemeName = "Office2010Black"
        CType(Me.txdbname.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = "db_apps"
        CType(Me.txdbname.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Padding = New System.Windows.Forms.Padding(6, 0, 4, 0)
        CType(Me.txdbname.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txdbname.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.txdbname.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.txdbname.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'txConStr
        '
        Me.txConStr.AutoSize = False
        Me.txConStr.BackColor = System.Drawing.Color.Transparent
        Me.txConStr.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txConStr.Location = New System.Drawing.Point(112, 5)
        Me.txConStr.Name = "txConStr"
        Me.txConStr.Padding = New System.Windows.Forms.Padding(6, 0, 4, 0)
        Me.txConStr.Size = New System.Drawing.Size(219, 23)
        Me.txConStr.TabIndex = 16
        Me.txConStr.Text = "Splash_Connection"
        Me.txConStr.ThemeName = "Office2010Black"
        CType(Me.txConStr.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = "Splash_Connection"
        CType(Me.txConStr.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txConStr.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Padding = New System.Windows.Forms.Padding(6, 0, 4, 0)
        CType(Me.txConStr.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txConStr.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.txConStr.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.SystemColors.Control
        CType(Me.txConStr.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.SystemColors.ControlDarkDark
        CType(Me.txConStr.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.txConStr.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(49, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 15)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Password"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label11.Location = New System.Drawing.Point(46, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 15)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Username"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(51, 38)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 15)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Database"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label13.Location = New System.Drawing.Point(31, 67)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 15)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Server / Host"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label14.Location = New System.Drawing.Point(2, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 15)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Connection Name"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadPageViewPage1
        '
        Me.RadPageViewPage1.Controls.Add(Me.RadButton1)
        Me.RadPageViewPage1.Controls.Add(Me.cbDropDbFile)
        Me.RadPageViewPage1.Controls.Add(Me.TableLayoutPanel2)
        Me.RadPageViewPage1.Controls.Add(Me.btnNewBackupSystem)
        Me.RadPageViewPage1.Controls.Add(Me.btnSetFolder)
        Me.RadPageViewPage1.Controls.Add(Me.txBackupFolderPath)
        Me.RadPageViewPage1.Controls.Add(Me.listTbl)
        Me.RadPageViewPage1.Controls.Add(Me.Label5)
        Me.RadPageViewPage1.Controls.Add(Me.Label9)
        Me.RadPageViewPage1.Controls.Add(Me.Label6)
        Me.RadPageViewPage1.ItemSize = New System.Drawing.SizeF(27.0!, 239.0!)
        Me.RadPageViewPage1.Location = New System.Drawing.Point(97, 29)
        Me.RadPageViewPage1.Name = "RadPageViewPage1"
        Me.RadPageViewPage1.Size = New System.Drawing.Size(527, 237)
        Me.RadPageViewPage1.Text = "Utilities"
        '
        'RadButton1
        '
        Me.RadButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadButton1.Location = New System.Drawing.Point(3, 161)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(117, 23)
        Me.RadButton1.TabIndex = 20
        Me.RadButton1.Text = "Open Form"
        Me.RadButton1.ThemeName = "Office2010Black"
        CType(Me.RadButton1.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Open Form"
        CType(Me.RadButton1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.RadButton1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'cbDropDbFile
        '
        Me.cbDropDbFile.AutoSize = False
        Me.cbDropDbFile.BackColor = System.Drawing.Color.Transparent
        Me.cbDropDbFile.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDropDbFile.Location = New System.Drawing.Point(126, 34)
        Me.cbDropDbFile.Name = "cbDropDbFile"
        Me.cbDropDbFile.NullText = "--Select Database--"
        Me.cbDropDbFile.Size = New System.Drawing.Size(259, 23)
        Me.cbDropDbFile.TabIndex = 19
        Me.cbDropDbFile.ThemeName = "Office2010Black"
        CType(Me.cbDropDbFile.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'btnNewBackupSystem
        '
        Me.btnNewBackupSystem.BackColor = System.Drawing.Color.Transparent
        Me.btnNewBackupSystem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewBackupSystem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnNewBackupSystem.Location = New System.Drawing.Point(3, 130)
        Me.btnNewBackupSystem.Name = "btnNewBackupSystem"
        Me.btnNewBackupSystem.Size = New System.Drawing.Size(117, 23)
        Me.btnNewBackupSystem.TabIndex = 12
        Me.btnNewBackupSystem.Text = "&New Backup System"
        Me.btnNewBackupSystem.ThemeName = "Office2010Black"
        CType(Me.btnNewBackupSystem.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "&New Backup System"
        CType(Me.btnNewBackupSystem.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.btnNewBackupSystem.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'btnSetFolder
        '
        Me.btnSetFolder.BackColor = System.Drawing.Color.Transparent
        Me.btnSetFolder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSetFolder.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSetFolder.Location = New System.Drawing.Point(458, 5)
        Me.btnSetFolder.Name = "btnSetFolder"
        Me.btnSetFolder.Size = New System.Drawing.Size(66, 23)
        Me.btnSetFolder.TabIndex = 12
        Me.btnSetFolder.Text = "&Set Folder"
        Me.btnSetFolder.ThemeName = "Office2010Black"
        CType(Me.btnSetFolder.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "&Set Folder"
        CType(Me.btnSetFolder.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        '
        'txBackupFolderPath
        '
        Me.txBackupFolderPath.AutoSize = False
        Me.txBackupFolderPath.BackColor = System.Drawing.Color.Transparent
        Me.txBackupFolderPath.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txBackupFolderPath.Location = New System.Drawing.Point(126, 5)
        Me.txBackupFolderPath.Name = "txBackupFolderPath"
        Me.txBackupFolderPath.NullText = "/"
        Me.txBackupFolderPath.Padding = New System.Windows.Forms.Padding(6, 0, 4, 0)
        Me.txBackupFolderPath.ReadOnly = True
        Me.txBackupFolderPath.Size = New System.Drawing.Size(326, 23)
        Me.txBackupFolderPath.TabIndex = 18
        Me.txBackupFolderPath.ThemeName = "Office2010Black"
        CType(Me.txBackupFolderPath.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Padding = New System.Windows.Forms.Padding(6, 0, 4, 0)
        CType(Me.txBackupFolderPath.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "/"
        CType(Me.txBackupFolderPath.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txBackupFolderPath.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.txBackupFolderPath.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.txBackupFolderPath.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'RadPageViewPage3
        '
        Me.RadPageViewPage3.ItemSize = New System.Drawing.SizeF(27.0!, 239.0!)
        Me.RadPageViewPage3.Location = New System.Drawing.Point(98, 30)
        Me.RadPageViewPage3.Name = "RadPageViewPage3"
        Me.RadPageViewPage3.Size = New System.Drawing.Size(517, 227)
        Me.RadPageViewPage3.Text = "Other"
        '
        'rFormDatabaseSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 309)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.RadPageView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "rFormDatabaseSetup"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Database Tools                                                                   " &
    "         "
        Me.ThemeName = "Office2010Black"
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.btnBackup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRestore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.Button4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageView1.ResumeLayout(False)
        Me.RadPageViewPage2.ResumeLayout(False)
        Me.RadPageViewPage2.PerformLayout()
        CType(Me.RadCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadToggleSwitch1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txPort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txHost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txdbname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txConStr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageViewPage1.ResumeLayout(False)
        Me.RadPageViewPage1.PerformLayout()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDropDbFile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNewBackupSystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSetFolder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txBackupFolderPath, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfd As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents listTbl As System.Windows.Forms.ListBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbProfile As System.Windows.Forms.ComboBox
    Friend WithEvents RadPageView1 As Telerik.WinControls.UI.RadPageView
    Friend WithEvents RadPageViewPage1 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadPageViewPage2 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txPort As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txPass As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txUser As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txHost As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txdbname As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txConStr As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents cbSection As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadToggleSwitch1 As Telerik.WinControls.UI.RadToggleSwitch
    Friend WithEvents RadCheckBox1 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents Button2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents Button4 As Telerik.WinControls.UI.RadButton
    Friend WithEvents txBackupFolderPath As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnSetFolder As Telerik.WinControls.UI.RadButton
    Friend WithEvents cbDropDbFile As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents btnBackup As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnRestore As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnNewBackupSystem As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadPageViewPage3 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
End Class
