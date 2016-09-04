<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rFormDataListInvoice
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
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Col1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Col2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txFilter = New Telerik.WinControls.UI.RadTextBox()
        Me.btnEdit = New Telerik.WinControls.UI.RadButton()
        Me.btnClose = New Telerik.WinControls.UI.RadButton()
        Me.btnPDF = New Telerik.WinControls.UI.RadButton()
        Me.btnAdd = New Telerik.WinControls.UI.RadButton()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.btnFilter = New Telerik.WinControls.UI.RadButton()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.Label1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.btnErase = New Telerik.WinControls.UI.RadButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txTemp = New Telerik.WinControls.UI.RadTextBox()
        Me.RadCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPDF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnErase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.txTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.AllowUserToResizeRows = False
        Me.dg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg.ColumnHeadersHeight = 30
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col1, Me.Col2, Me.Col3})
        Me.dg.Location = New System.Drawing.Point(3, 39)
        Me.dg.MultiSelect = False
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.RowHeadersVisible = False
        Me.dg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(950, 269)
        Me.dg.TabIndex = 0
        '
        'Col1
        '
        Me.Col1.HeaderText = "Select"
        Me.Col1.MinimumWidth = 45
        Me.Col1.Name = "Col1"
        Me.Col1.ReadOnly = True
        Me.Col1.Width = 45
        '
        'Col2
        '
        Me.Col2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Col2.HeaderText = "Record No."
        Me.Col2.MinimumWidth = 45
        Me.Col2.Name = "Col2"
        Me.Col2.ReadOnly = True
        Me.Col2.Width = 50
        '
        'Col3
        '
        Me.Col3.HeaderText = "Invoice No."
        Me.Col3.Name = "Col3"
        Me.Col3.ReadOnly = True
        Me.Col3.Width = 92
        '
        'txFilter
        '
        Me.txFilter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txFilter.AutoSize = False
        Me.txFilter.BackColor = System.Drawing.Color.Transparent
        Me.txFilter.Enabled = False
        Me.txFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txFilter.ForeColor = System.Drawing.Color.Black
        Me.txFilter.Location = New System.Drawing.Point(5, 4)
        Me.txFilter.Name = "txFilter"
        Me.txFilter.NullText = "Filter"
        Me.txFilter.Padding = New System.Windows.Forms.Padding(3, 0, 0, 1)
        Me.txFilter.Size = New System.Drawing.Size(451, 23)
        Me.txFilter.TabIndex = 2
        Me.txFilter.ThemeName = "Office2010Black"
        CType(Me.txFilter.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txFilter.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Padding = New System.Windows.Forms.Padding(3, 0, 0, 1)
        CType(Me.txFilter.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Filter"
        CType(Me.txFilter.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).ForeColor = System.Drawing.Color.Black
        CType(Me.txFilter.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.txFilter.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.txFilter.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEdit.Location = New System.Drawing.Point(196, 3)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(187, 26)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "&Ubah"
        Me.btnEdit.ThemeName = "Office2010Black"
        CType(Me.btnEdit.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "&Ubah"
        CType(Me.btnEdit.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.btnEdit.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.Location = New System.Drawing.Point(775, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(188, 26)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "&Keluar"
        Me.btnClose.ThemeName = "Office2010Black"
        CType(Me.btnClose.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "&Keluar"
        CType(Me.btnClose.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.btnClose.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'btnPDF
        '
        Me.btnPDF.BackColor = System.Drawing.Color.Transparent
        Me.btnPDF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPDF.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPDF.Location = New System.Drawing.Point(582, 3)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(187, 26)
        Me.btnPDF.TabIndex = 3
        Me.btnPDF.Text = "&PDF"
        Me.btnPDF.ThemeName = "Office2010Black"
        CType(Me.btnPDF.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "&PDF"
        CType(Me.btnPDF.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.btnPDF.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAdd.Location = New System.Drawing.Point(3, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(187, 26)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "&Tambah"
        Me.btnAdd.ThemeName = "Office2010Black"
        CType(Me.btnAdd.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "&Tambah"
        CType(Me.btnAdd.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.btnAdd.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'RadPanel1
        '
        Me.RadPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPanel1.BackColor = System.Drawing.Color.Transparent
        Me.RadPanel1.Controls.Add(Me.txFilter)
        Me.RadPanel1.Controls.Add(Me.RadButton1)
        Me.RadPanel1.Controls.Add(Me.btnFilter)
        Me.RadPanel1.Location = New System.Drawing.Point(109, 3)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(655, 32)
        Me.RadPanel1.TabIndex = 0
        Me.RadPanel1.ThemeName = "Office2010Black"
        '
        'RadButton1
        '
        Me.RadButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadButton1.Location = New System.Drawing.Point(555, 4)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(95, 23)
        Me.RadButton1.TabIndex = 3
        Me.RadButton1.Text = "[F5] Refresh"
        Me.RadButton1.ThemeName = "Office2010Black"
        CType(Me.RadButton1.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "[F5] Refresh"
        CType(Me.RadButton1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.RadButton1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'btnFilter
        '
        Me.btnFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFilter.BackColor = System.Drawing.Color.Transparent
        Me.btnFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.Location = New System.Drawing.Point(462, 4)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(87, 23)
        Me.btnFilter.TabIndex = 3
        Me.btnFilter.Text = "[F3] Filter"
        Me.btnFilter.ThemeName = "Office2010Black"
        CType(Me.btnFilter.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "[F3] Filter"
        CType(Me.btnFilter.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.btnFilter.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.Label1})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 372)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(966, 23)
        Me.RadStatusStrip1.TabIndex = 5
        Me.RadStatusStrip1.Text = "RadStatusStrip1"
        Me.RadStatusStrip1.ThemeName = "Office2010Black"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RadStatusStrip1.SetSpring(Me.Label1, True)
        Me.Label1.Text = "Total Records"
        Me.Label1.TextWrap = True
        '
        'btnErase
        '
        Me.btnErase.BackColor = System.Drawing.Color.Transparent
        Me.btnErase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnErase.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnErase.Location = New System.Drawing.Point(389, 3)
        Me.btnErase.Name = "btnErase"
        Me.btnErase.Size = New System.Drawing.Size(187, 26)
        Me.btnErase.TabIndex = 2
        Me.btnErase.Text = "&Hapus"
        Me.btnErase.ThemeName = "Office2010Black"
        CType(Me.btnErase.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "&Hapus"
        CType(Me.btnErase.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.btnErase.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.dg)
        Me.Panel1.Controls.Add(Me.RadCheckBox1)
        Me.Panel1.Controls.Add(Me.RadPanel1)
        Me.Panel1.Controls.Add(Me.txTemp)
        Me.Panel1.Location = New System.Drawing.Point(3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(960, 315)
        Me.Panel1.TabIndex = 1
        '
        'txTemp
        '
        Me.txTemp.AutoSize = False
        Me.txTemp.BackColor = System.Drawing.Color.Transparent
        Me.txTemp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txTemp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.txTemp.Location = New System.Drawing.Point(7, 80)
        Me.txTemp.Name = "txTemp"
        Me.txTemp.NullText = "Filter"
        Me.txTemp.Padding = New System.Windows.Forms.Padding(3, 0, 0, 1)
        Me.txTemp.Size = New System.Drawing.Size(544, 23)
        Me.txTemp.TabIndex = 3
        Me.txTemp.TabStop = False
        Me.txTemp.ThemeName = "Office2010Black"
        '
        'RadCheckBox1
        '
        Me.RadCheckBox1.Location = New System.Drawing.Point(7, 10)
        Me.RadCheckBox1.Name = "RadCheckBox1"
        Me.RadCheckBox1.Size = New System.Drawing.Size(66, 18)
        Me.RadCheckBox1.TabIndex = 6
        Me.RadCheckBox1.Text = "Select All"
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
        Me.TableLayoutPanel1.Controls.Add(Me.btnAdd, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnEdit, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnErase, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnClose, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnPDF, 3, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 334)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(966, 32)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'rFormDataListInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 395)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(822, 425)
        Me.Name = "rFormDataListInvoice"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = ""
        Me.Text = "Data Invoice"
        Me.ThemeName = "Office2010Black"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txFilter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPDF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnFilter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnErase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txFilter As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnEdit As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnClose As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnPDF As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnAdd As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnFilter As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents dg As System.Windows.Forms.DataGridView

    Friend WithEvents btnErase As Telerik.WinControls.UI.RadButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txTemp As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadCheckBox1 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents Col1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Col2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label1 As Telerik.WinControls.UI.RadLabelElement
End Class
