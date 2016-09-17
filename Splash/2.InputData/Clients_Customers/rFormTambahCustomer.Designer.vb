<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rFormTambahCustomer
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
        Me.txName = New Telerik.WinControls.UI.RadTextBox()
        Me.Propinsi = New Telerik.WinControls.UI.RadDropDownList()
        Me.txAlamat = New Telerik.WinControls.UI.RadTextBox()
        Me.txKodePos = New Telerik.WinControls.UI.RadTextBox()
        Me.txEmail = New Telerik.WinControls.UI.RadTextBox()
        Me.txTelpon2 = New Telerik.WinControls.UI.RadTextBox()
        Me.Kecamatan = New Telerik.WinControls.UI.RadDropDownList()
        Me.Kabupaten = New Telerik.WinControls.UI.RadDropDownList()
        Me.txTelpon1 = New Telerik.WinControls.UI.RadTextBox()
        Me.txNPWP = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.btnClose = New Telerik.WinControls.UI.RadButton()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.txNomorRecord = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.txName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Propinsi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txAlamat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txKodePos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txTelpon2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Kecamatan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Kabupaten, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txTelpon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txNPWP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox3.SuspendLayout()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txNomorRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txName
        '
        Me.txName.AllowShowFocusCues = True
        Me.txName.AutoSize = False
        Me.txName.BackColor = System.Drawing.Color.Transparent
        Me.txName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txName.Location = New System.Drawing.Point(11, 54)
        Me.txName.Name = "txName"
        Me.txName.NullText = "Nama Customer / Supplier"
        Me.txName.Size = New System.Drawing.Size(425, 23)
        Me.txName.TabIndex = 10
        Me.txName.ThemeName = "Office2010Black"
        CType(Me.txName.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Nama Customer / Supplier"
        CType(Me.txName.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txName.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.txName.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        CType(Me.txName.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'Propinsi
        '
        Me.Propinsi.AllowShowFocusCues = True
        Me.Propinsi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Propinsi.AutoSize = False
        Me.Propinsi.BackColor = System.Drawing.Color.Transparent
        Me.Propinsi.DisplayMember = "name"
        Me.Propinsi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Propinsi.Location = New System.Drawing.Point(11, 53)
        Me.Propinsi.Name = "Propinsi"
        Me.Propinsi.NullText = "Propinsi"
        Me.Propinsi.Size = New System.Drawing.Size(203, 23)
        Me.Propinsi.TabIndex = 13
        Me.Propinsi.ThemeName = "Office2010Black"
        Me.Propinsi.ValueMember = "id"
        CType(Me.Propinsi.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.Propinsi.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'txAlamat
        '
        Me.txAlamat.AllowShowFocusCues = True
        Me.txAlamat.AutoSize = False
        Me.txAlamat.BackColor = System.Drawing.Color.Transparent
        Me.txAlamat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txAlamat.Location = New System.Drawing.Point(11, 21)
        Me.txAlamat.Name = "txAlamat"
        Me.txAlamat.NullText = "Alamat"
        Me.txAlamat.Size = New System.Drawing.Size(425, 23)
        Me.txAlamat.TabIndex = 10
        Me.txAlamat.ThemeName = "Office2010Black"
        CType(Me.txAlamat.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Alamat"
        CType(Me.txAlamat.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txAlamat.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.txAlamat.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'txKodePos
        '
        Me.txKodePos.AllowShowFocusCues = True
        Me.txKodePos.AutoSize = False
        Me.txKodePos.BackColor = System.Drawing.Color.Transparent
        Me.txKodePos.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txKodePos.Location = New System.Drawing.Point(233, 85)
        Me.txKodePos.MaxLength = 8
        Me.txKodePos.Name = "txKodePos"
        Me.txKodePos.NullText = "Kode Pos"
        Me.txKodePos.Size = New System.Drawing.Size(109, 23)
        Me.txKodePos.TabIndex = 10
        Me.txKodePos.ThemeName = "Office2010Black"
        CType(Me.txKodePos.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Kode Pos"
        CType(Me.txKodePos.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txKodePos.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.txKodePos.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'txEmail
        '
        Me.txEmail.AllowShowFocusCues = True
        Me.txEmail.AutoSize = False
        Me.txEmail.BackColor = System.Drawing.Color.Transparent
        Me.txEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txEmail.Location = New System.Drawing.Point(11, 149)
        Me.txEmail.MaxLength = 800
        Me.txEmail.Name = "txEmail"
        Me.txEmail.NullText = "email"
        Me.txEmail.Size = New System.Drawing.Size(425, 23)
        Me.txEmail.TabIndex = 10
        Me.txEmail.ThemeName = "Office2010Black"
        CType(Me.txEmail.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "email"
        CType(Me.txEmail.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txEmail.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.txEmail.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txEmail.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'txTelpon2
        '
        Me.txTelpon2.AllowShowFocusCues = True
        Me.txTelpon2.AutoSize = False
        Me.txTelpon2.BackColor = System.Drawing.Color.Transparent
        Me.txTelpon2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txTelpon2.Location = New System.Drawing.Point(154, 117)
        Me.txTelpon2.Name = "txTelpon2"
        Me.txTelpon2.NullText = "Telpon 2"
        Me.txTelpon2.Size = New System.Drawing.Size(137, 23)
        Me.txTelpon2.TabIndex = 10
        Me.txTelpon2.ThemeName = "Office2010Black"
        CType(Me.txTelpon2.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Telpon 2"
        CType(Me.txTelpon2.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txTelpon2.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.txTelpon2.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'Kecamatan
        '
        Me.Kecamatan.AllowShowFocusCues = True
        Me.Kecamatan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Kecamatan.AutoSize = False
        Me.Kecamatan.BackColor = System.Drawing.Color.Transparent
        Me.Kecamatan.DisplayMember = "name"
        Me.Kecamatan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kecamatan.Location = New System.Drawing.Point(11, 85)
        Me.Kecamatan.Name = "Kecamatan"
        Me.Kecamatan.NullText = "Kecamatan"
        Me.Kecamatan.Size = New System.Drawing.Size(203, 23)
        Me.Kecamatan.TabIndex = 14
        Me.Kecamatan.ThemeName = "Office2010Black"
        Me.Kecamatan.ValueMember = "id"
        CType(Me.Kecamatan.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        CType(Me.Kecamatan.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'Kabupaten
        '
        Me.Kabupaten.AllowShowFocusCues = True
        Me.Kabupaten.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Kabupaten.AutoSize = False
        Me.Kabupaten.BackColor = System.Drawing.Color.Transparent
        Me.Kabupaten.DisplayMember = "name"
        Me.Kabupaten.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kabupaten.Location = New System.Drawing.Point(233, 53)
        Me.Kabupaten.Name = "Kabupaten"
        Me.Kabupaten.NullText = "Kabupaten"
        Me.Kabupaten.Size = New System.Drawing.Size(203, 23)
        Me.Kabupaten.TabIndex = 15
        Me.Kabupaten.ThemeName = "Office2010Black"
        Me.Kabupaten.ValueMember = "id"
        CType(Me.Kabupaten.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        CType(Me.Kabupaten.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'txTelpon1
        '
        Me.txTelpon1.AllowShowFocusCues = True
        Me.txTelpon1.AutoSize = False
        Me.txTelpon1.BackColor = System.Drawing.Color.Transparent
        Me.txTelpon1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txTelpon1.Location = New System.Drawing.Point(11, 117)
        Me.txTelpon1.Name = "txTelpon1"
        Me.txTelpon1.NullText = "Telpon 1"
        Me.txTelpon1.Size = New System.Drawing.Size(137, 23)
        Me.txTelpon1.TabIndex = 10
        Me.txTelpon1.ThemeName = "Office2010Black"
        CType(Me.txTelpon1.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txTelpon1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'txNPWP
        '
        Me.txNPWP.AcceptsReturn = True
        Me.txNPWP.AllowShowFocusCues = True
        Me.txNPWP.AutoSize = False
        Me.txNPWP.BackColor = System.Drawing.Color.Transparent
        Me.txNPWP.EnableKeyMap = True
        Me.txNPWP.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txNPWP.Location = New System.Drawing.Point(81, 19)
        Me.txNPWP.Mask = "00.000.000.0-000.000"
        Me.txNPWP.MaskType = Telerik.WinControls.UI.MaskType.Standard
        Me.txNPWP.Modified = True
        Me.txNPWP.Name = "txNPWP"
        Me.txNPWP.NullText = "_"
        Me.txNPWP.Size = New System.Drawing.Size(113, 23)
        Me.txNPWP.TabIndex = 16
        Me.txNPWP.TabStop = False
        Me.txNPWP.Text = "__.___.___._-___.___"
        Me.txNPWP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txNPWP.ThemeName = "Office2010Black"
        CType(Me.txNPWP.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = "__.___.___._-___.___"
        CType(Me.txNPWP.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).Padding = New System.Windows.Forms.Padding(2, 2, 2, 3)
        CType(Me.txNPWP.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "_"
        CType(Me.txNPWP.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txNPWP.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.txNPWP.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).PaintUsingParentShape = True
        CType(Me.txNPWP.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadLabel1.ForeColor = System.Drawing.Color.Black
        Me.RadLabel1.Location = New System.Drawing.Point(11, 21)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(64, 19)
        Me.RadLabel1.TabIndex = 9
        Me.RadLabel1.Text = "No. NPWP"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnSave, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnClose, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 291)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(458, 33)
        Me.TableLayoutPanel1.TabIndex = 17
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSave.Location = New System.Drawing.Point(3, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(223, 27)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Simpan Data"
        Me.btnSave.ThemeName = "Office2010Black"
        CType(Me.btnSave.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "&Simpan Data"
        CType(Me.btnSave.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.SystemColors.ControlDark
        CType(Me.btnSave.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.btnSave.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.Location = New System.Drawing.Point(232, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(223, 27)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "&Keluar"
        Me.btnClose.ThemeName = "Office2010Black"
        CType(Me.btnClose.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "&Keluar"
        CType(Me.btnClose.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.btnClose.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.RadGroupBox2.Controls.Add(Me.txAlamat)
        Me.RadGroupBox2.Controls.Add(Me.txTelpon2)
        Me.RadGroupBox2.Controls.Add(Me.Kecamatan)
        Me.RadGroupBox2.Controls.Add(Me.txTelpon1)
        Me.RadGroupBox2.Controls.Add(Me.Kabupaten)
        Me.RadGroupBox2.Controls.Add(Me.txEmail)
        Me.RadGroupBox2.Controls.Add(Me.Propinsi)
        Me.RadGroupBox2.Controls.Add(Me.txKodePos)
        Me.RadGroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadGroupBox2.HeaderText = " Detail Alamat Customer "
        Me.RadGroupBox2.Location = New System.Drawing.Point(3, 98)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(452, 188)
        Me.RadGroupBox2.TabIndex = 1
        Me.RadGroupBox2.Text = " Detail Alamat Customer "
        Me.RadGroupBox2.ThemeName = "Office2010Black"
        CType(Me.RadGroupBox2.GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        '
        'RadGroupBox3
        '
        Me.RadGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.RadGroupBox3.Controls.Add(Me.txName)
        Me.RadGroupBox3.Controls.Add(Me.txNPWP)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox3.Controls.Add(Me.txNomorRecord)
        Me.RadGroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadGroupBox3.HeaderText = " Invoice Name "
        Me.RadGroupBox3.Location = New System.Drawing.Point(3, 4)
        Me.RadGroupBox3.Name = "RadGroupBox3"
        Me.RadGroupBox3.Size = New System.Drawing.Size(452, 88)
        Me.RadGroupBox3.TabIndex = 1
        Me.RadGroupBox3.Text = " Invoice Name "
        Me.RadGroupBox3.ThemeName = "Office2010Black"
        CType(Me.RadGroupBox3.GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        '
        'RadLabel2
        '
        Me.RadLabel2.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadLabel2.ForeColor = System.Drawing.Color.Black
        Me.RadLabel2.Location = New System.Drawing.Point(257, 23)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(67, 19)
        Me.RadLabel2.TabIndex = 9
        Me.RadLabel2.Text = "Record No."
        '
        'txNomorRecord
        '
        Me.txNomorRecord.AllowShowFocusCues = True
        Me.txNomorRecord.AutoSize = False
        Me.txNomorRecord.BackColor = System.Drawing.Color.Transparent
        Me.txNomorRecord.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txNomorRecord.Location = New System.Drawing.Point(327, 21)
        Me.txNomorRecord.MaxLength = 8
        Me.txNomorRecord.Name = "txNomorRecord"
        Me.txNomorRecord.NullText = "Record No."
        Me.txNomorRecord.ReadOnly = True
        Me.txNomorRecord.Size = New System.Drawing.Size(109, 23)
        Me.txNomorRecord.TabIndex = 10
        Me.txNomorRecord.ThemeName = "Office2010Black"
        CType(Me.txNomorRecord.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Record No."
        CType(Me.txNomorRecord.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txNomorRecord.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.txNomorRecord.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        CType(Me.txNomorRecord.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'rFormTambahCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 324)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.RadGroupBox3)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "rFormTambahCustomer"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Customer / Supplier"
        Me.ThemeName = "Office2010Black"
        CType(Me.txName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Propinsi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txAlamat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txKodePos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txTelpon2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Kecamatan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Kabupaten, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txTelpon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txNPWP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox3.ResumeLayout(False)
        Me.RadGroupBox3.PerformLayout()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txNomorRecord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Propinsi As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents txAlamat As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txKodePos As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txEmail As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txTelpon2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Kecamatan As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Kabupaten As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents txTelpon1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txNPWP As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnClose As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGroupBox3 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txNomorRecord As Telerik.WinControls.UI.RadTextBox
End Class
