Imports System.ComponentModel

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportPartner
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Col2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RadGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
        Me.dgErr = New System.Windows.Forms.DataGridView()
        Me.noErr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.baris_ke = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.errMsg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RadGroupBox4 = New Telerik.WinControls.UI.RadGroupBox()
        Me.btnSelectFile = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
        Me.pBar = New System.Windows.Forms.ProgressBar()
        Me.btnImport = New Telerik.WinControls.UI.RadButton()
        Me.btnKeluar = New Telerik.WinControls.UI.RadButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox3.SuspendLayout()
        CType(Me.dgErr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox4.SuspendLayout()
        CType(Me.btnSelectFile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnImport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnKeluar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.SetColumnSpan(Me.RadGroupBox2, 3)
        Me.RadGroupBox2.Controls.Add(Me.dg)
        Me.RadGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadGroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadGroupBox2.HeaderText = "Daftar Data Valid"
        Me.RadGroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.TableLayoutPanel1.SetRowSpan(Me.RadGroupBox2, 2)
        Me.RadGroupBox2.Size = New System.Drawing.Size(429, 374)
        Me.RadGroupBox2.TabIndex = 13
        Me.RadGroupBox2.Text = "Daftar Data Valid"
        Me.RadGroupBox2.ThemeName = "Office2010Black"
        CType(Me.RadGroupBox2.GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
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
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col2, Me.Col3})
        Me.dg.Location = New System.Drawing.Point(5, 21)
        Me.dg.MultiSelect = False
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.RowHeadersVisible = False
        Me.dg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(419, 348)
        Me.dg.TabIndex = 1
        '
        'Col2
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Col2.DefaultCellStyle = DataGridViewCellStyle13
        Me.Col2.HeaderText = "Record No."
        Me.Col2.Name = "Col2"
        Me.Col2.ReadOnly = True
        Me.Col2.Width = 91
        '
        'Col3
        '
        Me.Col3.HeaderText = "Invoice No."
        Me.Col3.Name = "Col3"
        Me.Col3.ReadOnly = True
        Me.Col3.Width = 92
        '
        'RadGroupBox3
        '
        Me.RadGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.SetColumnSpan(Me.RadGroupBox3, 3)
        Me.RadGroupBox3.Controls.Add(Me.dgErr)
        Me.RadGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadGroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadGroupBox3.HeaderText = "Daftar Data Valid"
        Me.RadGroupBox3.Location = New System.Drawing.Point(478, 3)
        Me.RadGroupBox3.Name = "RadGroupBox3"
        Me.TableLayoutPanel1.SetRowSpan(Me.RadGroupBox3, 2)
        Me.RadGroupBox3.Size = New System.Drawing.Size(433, 374)
        Me.RadGroupBox3.TabIndex = 13
        Me.RadGroupBox3.Text = "Daftar Data Valid"
        Me.RadGroupBox3.ThemeName = "Office2010Black"
        CType(Me.RadGroupBox3.GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        '
        'dgErr
        '
        Me.dgErr.AllowUserToAddRows = False
        Me.dgErr.AllowUserToDeleteRows = False
        Me.dgErr.AllowUserToResizeRows = False
        Me.dgErr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgErr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgErr.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgErr.ColumnHeadersHeight = 30
        Me.dgErr.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.noErr, Me.baris_ke, Me.errMsg})
        Me.dgErr.Location = New System.Drawing.Point(5, 21)
        Me.dgErr.MultiSelect = False
        Me.dgErr.Name = "dgErr"
        Me.dgErr.ReadOnly = True
        Me.dgErr.RowHeadersVisible = False
        Me.dgErr.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgErr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgErr.Size = New System.Drawing.Size(407, 348)
        Me.dgErr.TabIndex = 2
        '
        'noErr
        '
        Me.noErr.HeaderText = "Record No."
        Me.noErr.Name = "noErr"
        Me.noErr.ReadOnly = True
        Me.noErr.Width = 91
        '
        'baris_ke
        '
        Me.baris_ke.HeaderText = "Baris - Ke"
        Me.baris_ke.Name = "baris_ke"
        Me.baris_ke.ReadOnly = True
        Me.baris_ke.Width = 81
        '
        'errMsg
        '
        Me.errMsg.HeaderText = "Deskripsi Invalid"
        Me.errMsg.Name = "errMsg"
        Me.errMsg.ReadOnly = True
        Me.errMsg.Width = 117
        '
        'RadGroupBox4
        '
        Me.RadGroupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.RadGroupBox4.Controls.Add(Me.btnSelectFile)
        Me.RadGroupBox4.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox4.Controls.Add(Me.RadTextBox1)
        Me.RadGroupBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadGroupBox4.HeaderText = "Options"
        Me.RadGroupBox4.Location = New System.Drawing.Point(6, 4)
        Me.RadGroupBox4.Name = "RadGroupBox4"
        Me.RadGroupBox4.Size = New System.Drawing.Size(874, 46)
        Me.RadGroupBox4.TabIndex = 13
        Me.RadGroupBox4.Text = "Options"
        Me.RadGroupBox4.ThemeName = "Office2010Black"
        CType(Me.RadGroupBox4.GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        '
        'btnSelectFile
        '
        Me.btnSelectFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectFile.BackColor = System.Drawing.Color.Transparent
        Me.btnSelectFile.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSelectFile.Location = New System.Drawing.Point(655, 16)
        Me.btnSelectFile.Name = "btnSelectFile"
        Me.btnSelectFile.Size = New System.Drawing.Size(211, 23)
        Me.btnSelectFile.TabIndex = 15
        Me.btnSelectFile.Text = "Pilih &File"
        Me.btnSelectFile.ThemeName = "Office2010Black"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(21, 20)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(55, 19)
        Me.RadLabel2.TabIndex = 13
        Me.RadLabel2.Text = "Filename"
        '
        'RadTextBox1
        '
        Me.RadTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.RadTextBox1.Location = New System.Drawing.Point(82, 16)
        Me.RadTextBox1.MaxLength = 5
        Me.RadTextBox1.Name = "RadTextBox1"
        Me.RadTextBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RadTextBox1.Size = New System.Drawing.Size(567, 23)
        Me.RadTextBox1.TabIndex = 2
        Me.RadTextBox1.ThemeName = "Office2010Black"
        '
        'pBar
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.pBar, 5)
        Me.pBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pBar.Location = New System.Drawing.Point(3, 383)
        Me.pBar.Name = "pBar"
        Me.pBar.Size = New System.Drawing.Size(614, 23)
        Me.pBar.TabIndex = 14
        '
        'btnImport
        '
        Me.btnImport.BackColor = System.Drawing.Color.Transparent
        Me.btnImport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnImport.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnImport.Location = New System.Drawing.Point(438, 3)
        Me.btnImport.Name = "btnImport"
        Me.TableLayoutPanel1.SetRowSpan(Me.btnImport, 2)
        Me.btnImport.Size = New System.Drawing.Size(34, 374)
        Me.btnImport.TabIndex = 16
        Me.btnImport.Text = ">>"
        Me.btnImport.ThemeName = "Office2010Black"
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.SetColumnSpan(Me.btnKeluar, 2)
        Me.btnKeluar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnKeluar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnKeluar.Location = New System.Drawing.Point(623, 383)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(288, 23)
        Me.btnKeluar.TabIndex = 16
        Me.btnKeluar.Text = "&Keluar"
        Me.btnKeluar.ThemeName = "Office2010Black"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.Controls.Add(Me.RadGroupBox2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RadGroupBox3, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnKeluar, 5, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.pBar, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnImport, 3, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 59)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(914, 409)
        Me.TableLayoutPanel1.TabIndex = 17
        '
        'frmImportPartner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 472)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.RadGroupBox4)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "frmImportPartner"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import Invoice"
        Me.ThemeName = "Office2010Black"
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox3.ResumeLayout(False)
        CType(Me.dgErr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox4.ResumeLayout(False)
        Me.RadGroupBox4.PerformLayout()
        CType(Me.btnSelectFile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnImport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnKeluar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGroupBox3 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGroupBox4 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnSelectFile As Telerik.WinControls.UI.RadButton
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents dgErr As System.Windows.Forms.DataGridView
    Friend WithEvents noErr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents baris_ke As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents errMsg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pBar As System.Windows.Forms.ProgressBar
    Friend WithEvents btnImport As Telerik.WinControls.UI.RadButton
    Friend WithEvents Col2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnKeluar As Telerik.WinControls.UI.RadButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel



End Class
