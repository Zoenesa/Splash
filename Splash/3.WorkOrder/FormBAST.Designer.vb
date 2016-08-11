<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPerintahKerja
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RadDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
        Me.txDefaultCharset = New Telerik.WinControls.UI.RadTextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.btnClose = New Telerik.WinControls.UI.RadButton()
        Me.rTxMaskDate = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.dgWo = New System.Windows.Forms.DataGridView()
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadRadioButton2 = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadRadioButton1 = New Telerik.WinControls.UI.RadRadioButton()
        Me.btnBack = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txDefaultCharset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rTxMaskDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgWo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRadioButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRadioButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadDropDownList1
        '
        Me.RadDropDownList1.AutoSize = False
        Me.RadDropDownList1.BackColor = System.Drawing.Color.Transparent
        Me.RadDropDownList1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDropDownList1.Location = New System.Drawing.Point(3, 20)
        Me.RadDropDownList1.Name = "RadDropDownList1"
        Me.RadDropDownList1.NullText = "Customer / Pelanggan"
        Me.RadDropDownList1.Size = New System.Drawing.Size(214, 23)
        Me.RadDropDownList1.TabIndex = 13
        Me.RadDropDownList1.ThemeName = "Office2010Black"
        CType(Me.RadDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        '
        'txDefaultCharset
        '
        Me.txDefaultCharset.AutoSize = False
        Me.txDefaultCharset.BackColor = System.Drawing.Color.Transparent
        Me.txDefaultCharset.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txDefaultCharset.Location = New System.Drawing.Point(238, 20)
        Me.txDefaultCharset.Name = "txDefaultCharset"
        Me.txDefaultCharset.NullText = "No. Pemesanan / Purchase Order"
        Me.txDefaultCharset.Padding = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.txDefaultCharset.Size = New System.Drawing.Size(212, 23)
        Me.txDefaultCharset.TabIndex = 14
        Me.txDefaultCharset.ThemeName = "Office2010Black"
        CType(Me.txDefaultCharset.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        CType(Me.txDefaultCharset.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Padding = New System.Windows.Forms.Padding(6, 0, 6, 0)
        CType(Me.txDefaultCharset.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnSave, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnClose, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 262)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(575, 31)
        Me.TableLayoutPanel1.TabIndex = 18
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSave.Location = New System.Drawing.Point(3, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(281, 25)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Simpan Data"
        Me.btnSave.ThemeName = "Office2010Black"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.Location = New System.Drawing.Point(290, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(282, 25)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "&Keluar"
        Me.btnClose.ThemeName = "Office2010Black"
        '
        'rTxMaskDate
        '
        Me.rTxMaskDate.AcceptsReturn = True
        Me.rTxMaskDate.AutoSize = False
        Me.rTxMaskDate.BackColor = System.Drawing.Color.Transparent
        Me.rTxMaskDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rTxMaskDate.Location = New System.Drawing.Point(461, 20)
        Me.rTxMaskDate.Mask = "00/00/0000"
        Me.rTxMaskDate.MaskType = Telerik.WinControls.UI.MaskType.Standard
        Me.rTxMaskDate.Name = "rTxMaskDate"
        Me.rTxMaskDate.NullText = "_"
        Me.rTxMaskDate.Size = New System.Drawing.Size(102, 23)
        Me.rTxMaskDate.TabIndex = 20
        Me.rTxMaskDate.TabStop = False
        Me.rTxMaskDate.Text = "__/__/____"
        Me.rTxMaskDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.rTxMaskDate.ThemeName = "Office2010Black"
        Me.rTxMaskDate.UseGenericBorderPaint = True
        CType(Me.rTxMaskDate.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = "__/__/____"
        CType(Me.rTxMaskDate.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        CType(Me.rTxMaskDate.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        '
        'RadLabel6
        '
        Me.RadLabel6.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadLabel6.ForeColor = System.Drawing.Color.Black
        Me.RadLabel6.Location = New System.Drawing.Point(461, 2)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(74, 19)
        Me.RadLabel6.TabIndex = 19
        Me.RadLabel6.Text = "Invoice Date"
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadLabel1.ForeColor = System.Drawing.Color.Black
        Me.RadLabel1.Location = New System.Drawing.Point(238, 2)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(74, 19)
        Me.RadLabel1.TabIndex = 19
        Me.RadLabel1.Text = "Invoice Date"
        '
        'dgWo
        '
        Me.dgWo.AllowUserToAddRows = False
        Me.dgWo.AllowUserToDeleteRows = False
        Me.dgWo.AllowUserToResizeRows = False
        Me.dgWo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgWo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgWo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgWo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Col2, Me.Col3, Me.Column2, Me.Column3, Me.Column4})
        Me.dgWo.Location = New System.Drawing.Point(3, 85)
        Me.dgWo.Name = "dgWo"
        Me.dgWo.RowHeadersVisible = False
        Me.dgWo.Size = New System.Drawing.Size(569, 171)
        Me.dgWo.TabIndex = 21
        '
        'RadTextBox1
        '
        Me.RadTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadTextBox1.AutoSize = False
        Me.RadTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.RadTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox1.Location = New System.Drawing.Point(202, 56)
        Me.RadTextBox1.Name = "RadTextBox1"
        Me.RadTextBox1.NullText = "Filter"
        Me.RadTextBox1.Padding = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.RadTextBox1.Size = New System.Drawing.Size(268, 23)
        Me.RadTextBox1.TabIndex = 14
        Me.RadTextBox1.ThemeName = "Office2010Black"
        CType(Me.RadTextBox1.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        CType(Me.RadTextBox1.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Padding = New System.Windows.Forms.Padding(6, 0, 6, 0)
        CType(Me.RadTextBox1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        '
        'RadRadioButton2
        '
        Me.RadRadioButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadRadioButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadRadioButton2.ForeColor = System.Drawing.Color.Black
        Me.RadRadioButton2.Location = New System.Drawing.Point(92, 58)
        Me.RadRadioButton2.Name = "RadRadioButton2"
        Me.RadRadioButton2.Size = New System.Drawing.Size(104, 19)
        Me.RadRadioButton2.TabIndex = 23
        Me.RadRadioButton2.Text = "Filter Customer"
        Me.RadRadioButton2.ThemeName = "Office2010Black"
        '
        'RadRadioButton1
        '
        Me.RadRadioButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadRadioButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadRadioButton1.ForeColor = System.Drawing.Color.Black
        Me.RadRadioButton1.Location = New System.Drawing.Point(3, 58)
        Me.RadRadioButton1.Name = "RadRadioButton1"
        Me.RadRadioButton1.Size = New System.Drawing.Size(83, 19)
        Me.RadRadioButton1.TabIndex = 22
        Me.RadRadioButton1.Text = "Filter Nama"
        Me.RadRadioButton1.ThemeName = "Office2010Black"
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBack.Location = New System.Drawing.Point(476, 56)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(96, 23)
        Me.btnBack.TabIndex = 24
        Me.btnBack.Text = "[F3] Cari"
        Me.btnBack.ThemeName = "Office2010Black"
        '
        'RadLabel2
        '
        Me.RadLabel2.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadLabel2.ForeColor = System.Drawing.Color.Black
        Me.RadLabel2.Location = New System.Drawing.Point(3, 2)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(100, 19)
        Me.RadLabel2.TabIndex = 19
        Me.RadLabel2.Text = "Nama Pelanggan"
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.FillWeight = 45.0!
        Me.Column1.HeaderText = "No"
        Me.Column1.MinimumWidth = 25
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 45
        '
        'Col2
        '
        Me.Col2.FillWeight = 125.0!
        Me.Col2.HeaderText = "No BAST"
        Me.Col2.Name = "Col2"
        '
        'Col3
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = "__/__/____"
        Me.Col3.DefaultCellStyle = DataGridViewCellStyle1
        Me.Col3.FillWeight = 60.0!
        Me.Col3.HeaderText = "Tanggal"
        Me.Col3.Name = "Col3"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nama Pelanggan"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Deskripsi"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Keterangan"
        Me.Column4.Name = "Column4"
        '
        'FormPerintahKerja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 293)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.RadRadioButton2)
        Me.Controls.Add(Me.RadRadioButton1)
        Me.Controls.Add(Me.dgWo)
        Me.Controls.Add(Me.rTxMaskDate)
        Me.Controls.Add(Me.RadLabel6)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.RadTextBox1)
        Me.Controls.Add(Me.txDefaultCharset)
        Me.Controls.Add(Me.RadDropDownList1)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel1)
        Me.Name = "FormPerintahKerja"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Form Perintah Kerja"
        Me.ThemeName = "Office2010Black"
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txDefaultCharset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rTxMaskDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgWo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRadioButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRadioButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadDropDownList1 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents txDefaultCharset As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnClose As Telerik.WinControls.UI.RadButton
    Friend WithEvents rTxMaskDate As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dgWo As System.Windows.Forms.DataGridView
    Friend WithEvents RadTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadRadioButton2 As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadRadioButton1 As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents btnBack As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

