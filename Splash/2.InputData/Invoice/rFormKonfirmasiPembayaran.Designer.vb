<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rFormKonfirmasiPembayaran
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
        Me.RadGroupBox4 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadMaskedEditBox1 = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
        Me.rCustomer = New Telerik.WinControls.UI.RadDropDownList()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.btnClose = New Telerik.WinControls.UI.RadButton()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.txBAST = New Telerik.WinControls.UI.RadTextBox()
        Me.rTxMaskDate = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadRadioButton2 = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadRadioButton1 = New Telerik.WinControls.UI.RadRadioButton()
        Me.rDropWO = New Telerik.WinControls.UI.RadDropDownList()
        CType(Me.RadGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox4.SuspendLayout()
        CType(Me.RadMaskedEditBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.txBAST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rTxMaskDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRadioButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRadioButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rDropWO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox4
        '
        Me.RadGroupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.RadGroupBox4.Controls.Add(Me.RadMaskedEditBox1)
        Me.RadGroupBox4.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox4.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox4.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox4.Controls.Add(Me.RadLabel4)
        Me.RadGroupBox4.Controls.Add(Me.RadTextBox1)
        Me.RadGroupBox4.Controls.Add(Me.rDropWO)
        Me.RadGroupBox4.Controls.Add(Me.rCustomer)
        Me.RadGroupBox4.HeaderText = "Detail Pembayaran"
        Me.RadGroupBox4.Location = New System.Drawing.Point(4, 2)
        Me.RadGroupBox4.Name = "RadGroupBox4"
        Me.RadGroupBox4.Size = New System.Drawing.Size(550, 149)
        Me.RadGroupBox4.TabIndex = 0
        Me.RadGroupBox4.Text = "Detail Pembayaran"
        Me.RadGroupBox4.ThemeName = "Office2010Black"
        CType(Me.RadGroupBox4.GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        '
        'RadMaskedEditBox1
        '
        Me.RadMaskedEditBox1.AcceptsReturn = True
        Me.RadMaskedEditBox1.BackColor = System.Drawing.Color.Transparent
        Me.RadMaskedEditBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadMaskedEditBox1.Location = New System.Drawing.Point(438, 41)
        Me.RadMaskedEditBox1.Mask = "00/00/0000"
        Me.RadMaskedEditBox1.MaskType = Telerik.WinControls.UI.MaskType.Standard
        Me.RadMaskedEditBox1.Name = "RadMaskedEditBox1"
        Me.RadMaskedEditBox1.NullText = "_"
        Me.RadMaskedEditBox1.Padding = New System.Windows.Forms.Padding(4, 2, 4, 3)
        Me.RadMaskedEditBox1.Size = New System.Drawing.Size(102, 23)
        Me.RadMaskedEditBox1.TabIndex = 5
        Me.RadMaskedEditBox1.TabStop = False
        Me.RadMaskedEditBox1.Text = "__/__/____"
        Me.RadMaskedEditBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadMaskedEditBox1.ThemeName = "Office2010Black"
        CType(Me.RadMaskedEditBox1.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = "__/__/____"
        CType(Me.RadMaskedEditBox1.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).Padding = New System.Windows.Forms.Padding(4, 2, 4, 3)
        CType(Me.RadMaskedEditBox1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "_"
        CType(Me.RadMaskedEditBox1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.RadMaskedEditBox1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.RadMaskedEditBox1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).PaintUsingParentShape = True
        CType(Me.RadMaskedEditBox1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'RadLabel2
        '
        Me.RadLabel2.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadLabel2.ForeColor = System.Drawing.Color.Black
        Me.RadLabel2.Location = New System.Drawing.Point(11, 71)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(69, 19)
        Me.RadLabel2.TabIndex = 6
        Me.RadLabel2.Text = "Keterangan"
        Me.RadLabel2.ThemeName = "Office2010Black"
        '
        'RadLabel3
        '
        Me.RadLabel3.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadLabel3.ForeColor = System.Drawing.Color.Black
        Me.RadLabel3.Location = New System.Drawing.Point(438, 21)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(53, 19)
        Me.RadLabel3.TabIndex = 4
        Me.RadLabel3.Text = "Diterima"
        Me.RadLabel3.ThemeName = "Office2010Black"
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadLabel1.ForeColor = System.Drawing.Color.Black
        Me.RadLabel1.Location = New System.Drawing.Point(260, 21)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(81, 19)
        Me.RadLabel1.TabIndex = 2
        Me.RadLabel1.Text = "Untuk Invoice"
        Me.RadLabel1.ThemeName = "Office2010Black"
        '
        'RadLabel4
        '
        Me.RadLabel4.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadLabel4.ForeColor = System.Drawing.Color.Black
        Me.RadLabel4.Location = New System.Drawing.Point(9, 21)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(102, 19)
        Me.RadLabel4.TabIndex = 0
        Me.RadLabel4.Text = "Customer / Client"
        Me.RadLabel4.ThemeName = "Office2010Black"
        '
        'RadTextBox1
        '
        Me.RadTextBox1.AcceptsReturn = True
        Me.RadTextBox1.AcceptsTab = True
        Me.RadTextBox1.AllowShowFocusCues = True
        Me.RadTextBox1.AutoCompleteCustomSource.AddRange(New String() {"10", "20", "30", "40", "50", "60", "70", "80", "90", "100"})
        Me.RadTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.RadTextBox1.AutoSize = False
        Me.RadTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.RadTextBox1.EnableKeyMap = True
        Me.RadTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadTextBox1.Location = New System.Drawing.Point(86, 70)
        Me.RadTextBox1.MaxLength = 8500
        Me.RadTextBox1.Modified = True
        Me.RadTextBox1.Multiline = True
        Me.RadTextBox1.Name = "RadTextBox1"
        Me.RadTextBox1.Size = New System.Drawing.Size(454, 61)
        Me.RadTextBox1.TabIndex = 7
        Me.RadTextBox1.TabStop = False
        Me.RadTextBox1.ThemeName = "Office2010Black"
        Me.RadTextBox1.WordWrap = False
        CType(Me.RadTextBox1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).StretchVertically = True
        CType(Me.RadTextBox1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.RadTextBox1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.RadTextBox1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.RadTextBox1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'rCustomer
        '
        Me.rCustomer.AllowShowFocusCues = True
        Me.rCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.rCustomer.BackColor = System.Drawing.Color.Transparent
        Me.rCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rCustomer.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.rCustomer.EnableAlternatingItemColor = True
        Me.rCustomer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rCustomer.Location = New System.Drawing.Point(11, 41)
        Me.rCustomer.MaxDropDownItems = 8
        Me.rCustomer.Name = "rCustomer"
        Me.rCustomer.NullText = "Nama Pelanggan"
        Me.rCustomer.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        '
        '
        '
        Me.rCustomer.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.rCustomer.Size = New System.Drawing.Size(243, 23)
        Me.rCustomer.TabIndex = 1
        Me.rCustomer.ThemeName = "Office2010Black"
        CType(Me.rCustomer.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        CType(Me.rCustomer.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.rCustomer.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        CType(Me.rCustomer.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        CType(Me.rCustomer.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).Margin = New System.Windows.Forms.Padding(0)
        CType(Me.rCustomer.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadDropDownTextBoxElement).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.rCustomer.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).Margin = New System.Windows.Forms.Padding(0)
        CType(Me.rCustomer.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Margin = New System.Windows.Forms.Padding(0)
        CType(Me.rCustomer.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Margin = New System.Windows.Forms.Padding(-1)
        CType(Me.rCustomer.GetChildAt(0).GetChildAt(3).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Padding = New System.Windows.Forms.Padding(-1)
        CType(Me.rCustomer.GetChildAt(0).GetChildAt(3).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadDropDownListArrowButtonElement).Margin = New System.Windows.Forms.Padding(3)
        CType(Me.rCustomer.GetChildAt(0).GetChildAt(3).GetChildAt(2).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Margin = New System.Windows.Forms.Padding(1)
        CType(Me.rCustomer.GetChildAt(0).GetChildAt(3).GetChildAt(2).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Margin = New System.Windows.Forms.Padding(0)
        CType(Me.rCustomer.GetChildAt(0).GetChildAt(3).GetChildAt(2).GetChildAt(1).GetChildAt(3), Telerik.WinControls.Primitives.OverflowPrimitive).Margin = New System.Windows.Forms.Padding(0)
        CType(Me.rCustomer.GetChildAt(0).GetChildAt(3).GetChildAt(2).GetChildAt(1).GetChildAt(4), Telerik.WinControls.Primitives.ImagePrimitive).Margin = New System.Windows.Forms.Padding(0)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnSave, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnClose, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 223)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(559, 33)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSave.Location = New System.Drawing.Point(3, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(273, 27)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Simpan"
        Me.btnSave.ThemeName = "Office2010Black"
        CType(Me.btnSave.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.btnSave.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.Location = New System.Drawing.Point(282, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(274, 27)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "&Batal"
        Me.btnClose.ThemeName = "Office2010Black"
        CType(Me.btnClose.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.btnClose.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.RadGroupBox1.Controls.Add(Me.txBAST)
        Me.RadGroupBox1.Controls.Add(Me.rTxMaskDate)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel6)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel5)
        Me.RadGroupBox1.Controls.Add(Me.RadRadioButton2)
        Me.RadGroupBox1.Controls.Add(Me.RadRadioButton1)
        Me.RadGroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadGroupBox1.HeaderText = "Jenis Pembayaran"
        Me.RadGroupBox1.Location = New System.Drawing.Point(4, 157)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(550, 60)
        Me.RadGroupBox1.TabIndex = 1
        Me.RadGroupBox1.Text = "Jenis Pembayaran"
        Me.RadGroupBox1.ThemeName = "Office2010Black"
        CType(Me.RadGroupBox1.GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        '
        'txBAST
        '
        Me.txBAST.AcceptsReturn = True
        Me.txBAST.AcceptsTab = True
        Me.txBAST.AllowShowFocusCues = True
        Me.txBAST.AutoCompleteCustomSource.AddRange(New String() {"10", "20", "30", "40", "50", "60", "70", "80", "90", "100"})
        Me.txBAST.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txBAST.AutoSize = False
        Me.txBAST.BackColor = System.Drawing.Color.Transparent
        Me.txBAST.EnableKeyMap = True
        Me.txBAST.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txBAST.Location = New System.Drawing.Point(391, 23)
        Me.txBAST.MaxLength = 50
        Me.txBAST.Modified = True
        Me.txBAST.Name = "txBAST"
        Me.txBAST.NullText = "0.00"
        Me.txBAST.Padding = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txBAST.Size = New System.Drawing.Size(151, 23)
        Me.txBAST.TabIndex = 4
        Me.txBAST.TabStop = False
        Me.txBAST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txBAST.ThemeName = "Office2010Black"
        Me.txBAST.WordWrap = False
        CType(Me.txBAST.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "0.00"
        CType(Me.txBAST.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txBAST.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.txBAST.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.txBAST.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'rTxMaskDate
        '
        Me.rTxMaskDate.AcceptsReturn = True
        Me.rTxMaskDate.BackColor = System.Drawing.Color.Transparent
        Me.rTxMaskDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rTxMaskDate.Location = New System.Drawing.Point(212, 23)
        Me.rTxMaskDate.Mask = "00/00/0000"
        Me.rTxMaskDate.MaskType = Telerik.WinControls.UI.MaskType.Standard
        Me.rTxMaskDate.Name = "rTxMaskDate"
        Me.rTxMaskDate.NullText = "_"
        Me.rTxMaskDate.Padding = New System.Windows.Forms.Padding(4, 2, 4, 3)
        Me.rTxMaskDate.Size = New System.Drawing.Size(102, 23)
        Me.rTxMaskDate.TabIndex = 2
        Me.rTxMaskDate.TabStop = False
        Me.rTxMaskDate.Text = "__/__/____"
        Me.rTxMaskDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.rTxMaskDate.ThemeName = "Office2010Black"
        CType(Me.rTxMaskDate.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = "__/__/____"
        CType(Me.rTxMaskDate.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).Padding = New System.Windows.Forms.Padding(4, 2, 4, 3)
        CType(Me.rTxMaskDate.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "_"
        CType(Me.rTxMaskDate.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.rTxMaskDate.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.rTxMaskDate.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'RadLabel6
        '
        Me.RadLabel6.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadLabel6.ForeColor = System.Drawing.Color.Black
        Me.RadLabel6.Location = New System.Drawing.Point(156, 25)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(50, 19)
        Me.RadLabel6.TabIndex = 3
        Me.RadLabel6.Text = "Tanggal"
        Me.RadLabel6.ThemeName = "Office2010Black"
        '
        'RadLabel5
        '
        Me.RadLabel5.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadLabel5.ForeColor = System.Drawing.Color.Black
        Me.RadLabel5.Location = New System.Drawing.Point(332, 25)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(53, 19)
        Me.RadLabel5.TabIndex = 3
        Me.RadLabel5.Text = "Nominal"
        Me.RadLabel5.ThemeName = "Office2010Black"
        '
        'RadRadioButton2
        '
        Me.RadRadioButton2.AutoSize = False
        Me.RadRadioButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadRadioButton2.ForeColor = System.Drawing.Color.Black
        Me.RadRadioButton2.Location = New System.Drawing.Point(70, 25)
        Me.RadRadioButton2.Name = "RadRadioButton2"
        Me.RadRadioButton2.Size = New System.Drawing.Size(80, 19)
        Me.RadRadioButton2.TabIndex = 1
        Me.RadRadioButton2.Text = "Cek / Giro"
        Me.RadRadioButton2.ThemeName = "Office2010Black"
        '
        'RadRadioButton1
        '
        Me.RadRadioButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadRadioButton1.ForeColor = System.Drawing.Color.Black
        Me.RadRadioButton1.Location = New System.Drawing.Point(11, 25)
        Me.RadRadioButton1.Name = "RadRadioButton1"
        Me.RadRadioButton1.Size = New System.Drawing.Size(50, 19)
        Me.RadRadioButton1.TabIndex = 0
        Me.RadRadioButton1.Text = "Tunai"
        Me.RadRadioButton1.ThemeName = "Office2010Black"
        '
        'rDropWO
        '
        Me.rDropWO.AllowShowFocusCues = True
        Me.rDropWO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.rDropWO.BackColor = System.Drawing.Color.Transparent
        Me.rDropWO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rDropWO.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.rDropWO.EnableAlternatingItemColor = True
        Me.rDropWO.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rDropWO.Location = New System.Drawing.Point(263, 41)
        Me.rDropWO.MaxDropDownItems = 8
        Me.rDropWO.Name = "rDropWO"
        Me.rDropWO.NullText = "Nama Pelanggan"
        Me.rDropWO.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        '
        '
        '
        Me.rDropWO.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.rDropWO.Size = New System.Drawing.Size(169, 23)
        Me.rDropWO.TabIndex = 1
        Me.rDropWO.ThemeName = "Office2010Black"
        CType(Me.rDropWO.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        CType(Me.rDropWO.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.rDropWO.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        CType(Me.rDropWO.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        CType(Me.rDropWO.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).Margin = New System.Windows.Forms.Padding(0)
        CType(Me.rDropWO.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadDropDownTextBoxElement).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.rDropWO.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).Margin = New System.Windows.Forms.Padding(0)
        CType(Me.rDropWO.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Margin = New System.Windows.Forms.Padding(0)
        CType(Me.rDropWO.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Margin = New System.Windows.Forms.Padding(-1)
        CType(Me.rDropWO.GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.RadDropDownListElement).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        CType(Me.rDropWO.GetChildAt(0).GetChildAt(3).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Padding = New System.Windows.Forms.Padding(-1)
        CType(Me.rDropWO.GetChildAt(0).GetChildAt(3).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadDropDownListArrowButtonElement).Margin = New System.Windows.Forms.Padding(3)
        CType(Me.rDropWO.GetChildAt(0).GetChildAt(3).GetChildAt(2).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Margin = New System.Windows.Forms.Padding(1)
        CType(Me.rDropWO.GetChildAt(0).GetChildAt(3).GetChildAt(2).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Margin = New System.Windows.Forms.Padding(0)
        CType(Me.rDropWO.GetChildAt(0).GetChildAt(3).GetChildAt(2).GetChildAt(1).GetChildAt(3), Telerik.WinControls.Primitives.OverflowPrimitive).Margin = New System.Windows.Forms.Padding(0)
        CType(Me.rDropWO.GetChildAt(0).GetChildAt(3).GetChildAt(2).GetChildAt(1).GetChildAt(4), Telerik.WinControls.Primitives.ImagePrimitive).Margin = New System.Windows.Forms.Padding(0)
        '
        'rFormKonfirmasiPembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 256)
        Me.ControlBox = False
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.RadGroupBox4)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "rFormKonfirmasiPembayaran"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Konfirmasi Pembayaran"
        Me.ThemeName = "Office2010Black"
        CType(Me.RadGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox4.ResumeLayout(False)
        Me.RadGroupBox4.PerformLayout()
        CType(Me.RadMaskedEditBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.txBAST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rTxMaskDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRadioButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRadioButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rDropWO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadGroupBox4 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents rCustomer As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnClose As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadRadioButton2 As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadRadioButton1 As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents rTxMaskDate As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadMaskedEditBox1 As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txBAST As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents rDropWO As Telerik.WinControls.UI.RadDropDownList
End Class
