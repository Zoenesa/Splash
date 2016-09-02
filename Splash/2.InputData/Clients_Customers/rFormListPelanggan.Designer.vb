<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rFormListPelanggan
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
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.txFilter = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.rDropInvoiceType = New Telerik.WinControls.UI.RadDropDownList()
        Me.btnFilter = New Telerik.WinControls.UI.RadButton()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Coll1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Coll2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRefresh = New Telerik.WinControls.UI.RadButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnBukaFormTambahCustomer = New Telerik.WinControls.UI.RadButton()
        Me.btnEdit = New Telerik.WinControls.UI.RadButton()
        Me.btnErase = New Telerik.WinControls.UI.RadButton()
        Me.btnSelect = New Telerik.WinControls.UI.RadButton()
        Me.btnClose = New Telerik.WinControls.UI.RadButton()
        CType(Me.txFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rDropInvoiceType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.btnBukaFormTambahCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnErase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txFilter
        '
        Me.txFilter.AcceptsReturn = True
        Me.txFilter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txFilter.AutoSize = False
        Me.txFilter.BackColor = System.Drawing.Color.Transparent
        Me.txFilter.Culture = New System.Globalization.CultureInfo("en-US")
        Me.txFilter.EnableKeyMap = True
        Me.txFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txFilter.Location = New System.Drawing.Point(134, 3)
        Me.txFilter.Name = "txFilter"
        Me.txFilter.NullText = "Filter Key"
        Me.txFilter.Size = New System.Drawing.Size(297, 23)
        Me.txFilter.TabIndex = 1
        Me.txFilter.TabStop = False
        Me.txFilter.Text = Nothing
        Me.txFilter.ThemeName = "Office2010Black"
        CType(Me.txFilter.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).Padding = New System.Windows.Forms.Padding(2, 2, 2, 3)
        CType(Me.txFilter.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Filter Key"
        CType(Me.txFilter.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txFilter.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.txFilter.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'rDropInvoiceType
        '
        Me.rDropInvoiceType.AutoSize = False
        Me.rDropInvoiceType.BackColor = System.Drawing.Color.Transparent
        Me.rDropInvoiceType.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RadListDataItem3.Text = "Client ID Tax"
        RadListDataItem4.Text = "Client Name"
        Me.rDropInvoiceType.Items.Add(RadListDataItem3)
        Me.rDropInvoiceType.Items.Add(RadListDataItem4)
        Me.rDropInvoiceType.Location = New System.Drawing.Point(0, 3)
        Me.rDropInvoiceType.Name = "rDropInvoiceType"
        Me.rDropInvoiceType.NullText = "Filter Field"
        Me.rDropInvoiceType.Size = New System.Drawing.Size(128, 23)
        Me.rDropInvoiceType.TabIndex = 0
        Me.rDropInvoiceType.ThemeName = "Office2010Black"
        CType(Me.rDropInvoiceType.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).BackColor = System.Drawing.SystemColors.Control
        CType(Me.rDropInvoiceType.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'btnFilter
        '
        Me.btnFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFilter.BackColor = System.Drawing.Color.Transparent
        Me.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnFilter.Location = New System.Drawing.Point(437, 3)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(87, 23)
        Me.btnFilter.TabIndex = 2
        Me.btnFilter.Text = "[F2] Filter"
        Me.btnFilter.ThemeName = "Office2010Black"
        CType(Me.btnFilter.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "[F2] Filter"
        CType(Me.btnFilter.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.btnFilter.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 347)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Padding = New System.Windows.Forms.Padding(0, 1, 0, 2)
        Me.RadStatusStrip1.Size = New System.Drawing.Size(630, 24)
        Me.RadStatusStrip1.TabIndex = 5
        Me.RadStatusStrip1.Text = "RadStatusStrip1"
        Me.RadStatusStrip1.ThemeName = "Office2010Black"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.dg)
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(630, 281)
        Me.Panel1.TabIndex = 3
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.AllowUserToResizeRows = False
        Me.dg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Coll1, Me.Coll2})
        Me.dg.Location = New System.Drawing.Point(3, 3)
        Me.dg.MultiSelect = False
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.RowHeadersVisible = False
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(620, 271)
        Me.dg.TabIndex = 1
        '
        'Coll1
        '
        Me.Coll1.HeaderText = "Select"
        Me.Coll1.MinimumWidth = 25
        Me.Coll1.Name = "Coll1"
        Me.Coll1.ReadOnly = True
        Me.Coll1.Width = 55
        '
        'Coll2
        '
        Me.Coll2.HeaderText = "Record No."
        Me.Coll2.MinimumWidth = 65
        Me.Coll2.Name = "Coll2"
        Me.Coll2.ReadOnly = True
        Me.Coll2.Width = 65
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.BackColor = System.Drawing.Color.Transparent
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRefresh.Location = New System.Drawing.Point(530, 3)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(100, 23)
        Me.btnRefresh.TabIndex = 0
        Me.btnRefresh.Text = "[F5] Refresh"
        Me.btnRefresh.ThemeName = "Office2010Black"
        CType(Me.btnRefresh.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "[F5] Refresh"
        CType(Me.btnRefresh.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.btnRefresh.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnBukaFormTambahCustomer, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnEdit, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnErase, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSelect, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnClose, 4, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 315)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(630, 32)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'btnBukaFormTambahCustomer
        '
        Me.btnBukaFormTambahCustomer.BackColor = System.Drawing.Color.Transparent
        Me.btnBukaFormTambahCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBukaFormTambahCustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBukaFormTambahCustomer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBukaFormTambahCustomer.Location = New System.Drawing.Point(3, 3)
        Me.btnBukaFormTambahCustomer.Name = "btnBukaFormTambahCustomer"
        Me.btnBukaFormTambahCustomer.Size = New System.Drawing.Size(120, 26)
        Me.btnBukaFormTambahCustomer.TabIndex = 0
        Me.btnBukaFormTambahCustomer.Text = "&Tambah"
        Me.btnBukaFormTambahCustomer.ThemeName = "Office2010Black"
        CType(Me.btnBukaFormTambahCustomer.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "&Tambah"
        CType(Me.btnBukaFormTambahCustomer.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.btnBukaFormTambahCustomer.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEdit.Location = New System.Drawing.Point(129, 3)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(120, 26)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "&Ubah"
        Me.btnEdit.ThemeName = "Office2010Black"
        CType(Me.btnEdit.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "&Ubah"
        CType(Me.btnEdit.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.btnEdit.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'btnErase
        '
        Me.btnErase.BackColor = System.Drawing.Color.Transparent
        Me.btnErase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnErase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnErase.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnErase.Location = New System.Drawing.Point(255, 3)
        Me.btnErase.Name = "btnErase"
        Me.btnErase.Size = New System.Drawing.Size(120, 26)
        Me.btnErase.TabIndex = 2
        Me.btnErase.Text = "&Hapus"
        Me.btnErase.ThemeName = "Office2010Black"
        CType(Me.btnErase.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "&Hapus"
        CType(Me.btnErase.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.btnErase.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.Transparent
        Me.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSelect.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSelect.Location = New System.Drawing.Point(381, 3)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(120, 26)
        Me.btnSelect.TabIndex = 3
        Me.btnSelect.Text = "&Pilih"
        Me.btnSelect.ThemeName = "Office2010Black"
        Me.btnSelect.Visible = False
        CType(Me.btnSelect.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "&Pilih"
        CType(Me.btnSelect.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.btnSelect.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.Location = New System.Drawing.Point(507, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(120, 26)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "&Keluar"
        Me.btnClose.ThemeName = "Office2010Black"
        CType(Me.btnClose.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "&Keluar"
        CType(Me.btnClose.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.btnClose.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'rFormListPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 371)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.txFilter)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.rDropInvoiceType)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "rFormListPelanggan"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daftar Pelanggan"
        Me.ThemeName = "Office2010Black"
        CType(Me.txFilter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rDropInvoiceType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnFilter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.btnBukaFormTambahCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnErase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txFilter As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents rDropInvoiceType As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents btnFilter As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents Coll1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Coll2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnRefresh As Telerik.WinControls.UI.RadButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnBukaFormTambahCustomer As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnEdit As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnErase As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSelect As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnClose As Telerik.WinControls.UI.RadButton
End Class
