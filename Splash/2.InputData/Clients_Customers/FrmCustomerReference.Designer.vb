
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomerReference
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
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCustomerReference))
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.txFilter = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.rDropInvoiceType = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.btnFilter = New Telerik.WinControls.UI.RadButton()
        Me.btnClose = New Telerik.WinControls.UI.RadButton()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Coll1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Coll2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Coll3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Coll4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Coll5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Coll9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Coll10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Coll11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Coll12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Coll13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEdit = New Telerik.WinControls.UI.RadButton()
        Me.btnErase = New Telerik.WinControls.UI.RadButton()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.StripLabelTotalRec = New System.Windows.Forms.ToolStripLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSelect = New Telerik.WinControls.UI.RadButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.txFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rDropInvoiceType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnErase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.btnSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.RadGroupBox2.Controls.Add(Me.txFilter)
        Me.RadGroupBox2.Controls.Add(Me.rDropInvoiceType)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel5)
        Me.RadGroupBox2.Controls.Add(Me.btnFilter)
        Me.RadGroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadGroupBox2.HeaderText = " Filtering Records "
        Me.RadGroupBox2.Location = New System.Drawing.Point(3, 5)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(752, 57)
        Me.RadGroupBox2.TabIndex = 8
        Me.RadGroupBox2.Text = " Filtering Records "
        Me.RadGroupBox2.ThemeName = "Office2010Black"
        CType(Me.RadGroupBox2.GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        '
        'txFilter
        '
        Me.txFilter.AcceptsReturn = True
        Me.txFilter.AutoSize = False
        Me.txFilter.BackColor = System.Drawing.Color.Transparent
        Me.txFilter.Culture = New System.Globalization.CultureInfo("en-US")
        Me.txFilter.EnableKeyMap = True
        Me.txFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txFilter.Location = New System.Drawing.Point(214, 21)
        Me.txFilter.Name = "txFilter"
        Me.txFilter.NullText = "Filter Key"
        Me.txFilter.Size = New System.Drawing.Size(332, 23)
        Me.txFilter.TabIndex = 12
        Me.txFilter.TabStop = False
        Me.txFilter.Text = Nothing
        Me.txFilter.ThemeName = "Office2010Black"
        Me.txFilter.UseGenericBorderPaint = True
        '
        'rDropInvoiceType
        '
        Me.rDropInvoiceType.AutoSize = False
        Me.rDropInvoiceType.BackColor = System.Drawing.Color.Transparent
        Me.rDropInvoiceType.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RadListDataItem1.Text = "Client ID Tax"
        RadListDataItem2.Text = "Client Name"
        RadListDataItem3.Text = "Address"
        Me.rDropInvoiceType.Items.Add(RadListDataItem1)
        Me.rDropInvoiceType.Items.Add(RadListDataItem2)
        Me.rDropInvoiceType.Items.Add(RadListDataItem3)
        Me.rDropInvoiceType.Location = New System.Drawing.Point(7, 21)
        Me.rDropInvoiceType.Name = "rDropInvoiceType"
        Me.rDropInvoiceType.NullText = "Filter Field"
        Me.rDropInvoiceType.Size = New System.Drawing.Size(162, 23)
        Me.rDropInvoiceType.TabIndex = 11
        Me.rDropInvoiceType.ThemeName = "Office2010Black"
        '
        'RadLabel5
        '
        Me.RadLabel5.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadLabel5.ForeColor = System.Drawing.Color.Black
        Me.RadLabel5.Location = New System.Drawing.Point(175, 22)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(33, 19)
        Me.RadLabel5.TabIndex = 0
        Me.RadLabel5.Text = "Filter"
        Me.RadLabel5.ThemeName = "Office2010Black"
        '
        'btnFilter
        '
        Me.btnFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnFilter.BackColor = System.Drawing.Color.Transparent
        Me.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnFilter.Location = New System.Drawing.Point(552, 21)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(92, 23)
        Me.btnFilter.TabIndex = 9
        Me.btnFilter.Text = "[F2] Filter"
        Me.btnFilter.ThemeName = "Office2010Black"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.Location = New System.Drawing.Point(607, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(148, 26)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "&Close"
        Me.btnClose.ThemeName = "Office2010Black"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSave.Location = New System.Drawing.Point(3, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(145, 26)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Add Client"
        Me.btnSave.ThemeName = "Office2010Black"
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
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Coll1, Me.Coll2, Me.Coll3, Me.Coll4, Me.Coll5, Me.Coll9, Me.Coll10, Me.Coll11, Me.Coll12, Me.Coll13, Me.Col10})
        Me.dg.Location = New System.Drawing.Point(3, 3)
        Me.dg.MultiSelect = False
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.RowHeadersVisible = False
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(742, 223)
        Me.dg.TabIndex = 11
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
        'Coll3
        '
        Me.Coll3.HeaderText = "NPWP Pelanggan"
        Me.Coll3.MinimumWidth = 95
        Me.Coll3.Name = "Coll3"
        Me.Coll3.ReadOnly = True
        Me.Coll3.Width = 125
        '
        'Coll4
        '
        Me.Coll4.HeaderText = "Nama Pelanggan"
        Me.Coll4.MinimumWidth = 95
        Me.Coll4.Name = "Coll4"
        Me.Coll4.ReadOnly = True
        Me.Coll4.Width = 145
        '
        'Coll5
        '
        Me.Coll5.HeaderText = "Alamat Kantor"
        Me.Coll5.MinimumWidth = 95
        Me.Coll5.Name = "Coll5"
        Me.Coll5.ReadOnly = True
        Me.Coll5.Width = 155
        '
        'Coll9
        '
        Me.Coll9.HeaderText = "Telpon"
        Me.Coll9.MinimumWidth = 75
        Me.Coll9.Name = "Coll9"
        Me.Coll9.ReadOnly = True
        Me.Coll9.Width = 75
        '
        'Coll10
        '
        Me.Coll10.HeaderText = "Email"
        Me.Coll10.MinimumWidth = 75
        Me.Coll10.Name = "Coll10"
        Me.Coll10.ReadOnly = True
        Me.Coll10.Width = 135
        '
        'Coll11
        '
        Me.Coll11.HeaderText = "User Record"
        Me.Coll11.MinimumWidth = 75
        Me.Coll11.Name = "Coll11"
        Me.Coll11.ReadOnly = True
        Me.Coll11.Width = 95
        '
        'Coll12
        '
        Me.Coll12.HeaderText = "Tanggal Record"
        Me.Coll12.MinimumWidth = 95
        Me.Coll12.Name = "Coll12"
        Me.Coll12.ReadOnly = True
        '
        'Coll13
        '
        Me.Coll13.HeaderText = "User Update"
        Me.Coll13.Name = "Coll13"
        Me.Coll13.ReadOnly = True
        '
        'Col10
        '
        Me.Col10.HeaderText = "Tanggal Update"
        Me.Col10.Name = "Col10"
        Me.Col10.ReadOnly = True
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEdit.Location = New System.Drawing.Point(154, 3)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(145, 26)
        Me.btnEdit.TabIndex = 9
        Me.btnEdit.Text = "&Edit Client"
        Me.btnEdit.ThemeName = "Office2010Black"
        '
        'btnErase
        '
        Me.btnErase.BackColor = System.Drawing.Color.Transparent
        Me.btnErase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnErase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnErase.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnErase.Location = New System.Drawing.Point(305, 3)
        Me.btnErase.Name = "btnErase"
        Me.btnErase.Size = New System.Drawing.Size(145, 26)
        Me.btnErase.TabIndex = 9
        Me.btnErase.Text = "&Erase"
        Me.btnErase.ThemeName = "Office2010Black"
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 381)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Padding = New System.Windows.Forms.Padding(0, 1, 0, 2)
        Me.RadStatusStrip1.Size = New System.Drawing.Size(758, 24)
        Me.RadStatusStrip1.TabIndex = 12
        Me.RadStatusStrip1.Text = "RadStatusStrip1"
        Me.RadStatusStrip1.ThemeName = "Office2010Black"
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Nothing
        Me.BindingNavigator2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BindingNavigator2.BackColor = System.Drawing.Color.Transparent
        Me.BindingNavigator2.CountItem = Me.StripLabelTotalRec
        Me.BindingNavigator2.CountItemFormat = "{0}"
        Me.BindingNavigator2.DeleteItem = Nothing
        Me.BindingNavigator2.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StripLabelTotalRec})
        Me.BindingNavigator2.Location = New System.Drawing.Point(3, 310)
        Me.BindingNavigator2.MoveFirstItem = Nothing
        Me.BindingNavigator2.MoveLastItem = Nothing
        Me.BindingNavigator2.MoveNextItem = Nothing
        Me.BindingNavigator2.MovePreviousItem = Nothing
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Nothing
        Me.BindingNavigator2.Size = New System.Drawing.Size(44, 25)
        Me.BindingNavigator2.TabIndex = 13
        Me.BindingNavigator2.Text = "BindingNavigator1"
        '
        'StripLabelTotalRec
        '
        Me.StripLabelTotalRec.Name = "StripLabelTotalRec"
        Me.StripLabelTotalRec.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.StripLabelTotalRec.Size = New System.Drawing.Size(41, 22)
        Me.StripLabelTotalRec.Text = "{0}"
        Me.StripLabelTotalRec.ToolTipText = "Total number of items"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.dg)
        Me.Panel1.Location = New System.Drawing.Point(3, 68)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(752, 233)
        Me.Panel1.TabIndex = 14
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.Transparent
        Me.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSelect.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSelect.Location = New System.Drawing.Point(456, 3)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(145, 26)
        Me.btnSelect.TabIndex = 9
        Me.btnSelect.Text = "&Select"
        Me.btnSelect.ThemeName = "Office2010Black"
        Me.btnSelect.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnSave, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnEdit, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnErase, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSelect, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnClose, 4, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 346)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(758, 32)
        Me.TableLayoutPanel1.TabIndex = 15
        '
        'FrmCustomerReference
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 405)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BindingNavigator2)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "FrmCustomerReference"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.Text = "Client References"
        Me.ThemeName = "Office2010Black"
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        Me.RadGroupBox2.PerformLayout()
        CType(Me.txFilter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rDropInvoiceType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnFilter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnErase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnSelect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnClose As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents btnEdit As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnErase As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents btnFilter As Telerik.WinControls.UI.RadButton
    Friend WithEvents BindingNavigator2 As System.Windows.Forms.BindingNavigator
    Friend WithEvents StripLabelTotalRec As System.Windows.Forms.ToolStripLabel
    Friend WithEvents rDropInvoiceType As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents txFilter As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSelect As Telerik.WinControls.UI.RadButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Coll1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Coll2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Coll3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Coll4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Coll5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Coll9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Coll10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Coll11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Coll12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Coll13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col10 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

