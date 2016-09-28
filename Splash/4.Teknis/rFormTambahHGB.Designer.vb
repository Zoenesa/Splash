<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class rFormTambahHGB
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem6 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem7 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem8 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.RadGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
        Me.txName = New Telerik.WinControls.UI.RadTextBox()
        Me.txNPWP = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txNomorRecord = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownHGB = New Telerik.WinControls.UI.RadDropDownList()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.btnClose = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox3.SuspendLayout()
        CType(Me.txName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txNPWP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txNomorRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownHGB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox3
        '
        Me.RadGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.RadGroupBox3.Controls.Add(Me.RadDropDownHGB)
        Me.RadGroupBox3.Controls.Add(Me.RadTextBox1)
        Me.RadGroupBox3.Controls.Add(Me.txName)
        Me.RadGroupBox3.Controls.Add(Me.txNPWP)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox3.Controls.Add(Me.txNomorRecord)
        Me.RadGroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadGroupBox3.HeaderText = "Input Detail HGB"
        Me.RadGroupBox3.Location = New System.Drawing.Point(3, 6)
        Me.RadGroupBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.RadGroupBox3.Name = "RadGroupBox3"
        Me.RadGroupBox3.Padding = New System.Windows.Forms.Padding(0)
        Me.RadGroupBox3.Size = New System.Drawing.Size(441, 136)
        Me.RadGroupBox3.TabIndex = 2
        Me.RadGroupBox3.Text = "Input Detail HGB"
        Me.RadGroupBox3.ThemeName = "Office2010Black"
        CType(Me.RadGroupBox3.GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        '
        'txName
        '
        Me.txName.AllowShowFocusCues = True
        Me.txName.AutoSize = False
        Me.txName.BackColor = System.Drawing.Color.Transparent
        Me.txName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txName.Location = New System.Drawing.Point(11, 59)
        Me.txName.Name = "txName"
        Me.txName.NullText = "NOMOR HGB"
        Me.txName.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txName.Size = New System.Drawing.Size(206, 23)
        Me.txName.TabIndex = 10
        Me.txName.ThemeName = "Office2010Black"
        CType(Me.txName.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        CType(Me.txName.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "NOMOR HGB"
        CType(Me.txName.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txName.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.txName.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        CType(Me.txName.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'txNPWP
        '
        Me.txNPWP.AcceptsReturn = True
        Me.txNPWP.AllowShowFocusCues = True
        Me.txNPWP.AutoSize = False
        Me.txNPWP.BackColor = System.Drawing.Color.Transparent
        Me.txNPWP.EnableKeyMap = True
        Me.txNPWP.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txNPWP.Location = New System.Drawing.Point(104, 94)
        Me.txNPWP.Mask = "00/00/0000"
        Me.txNPWP.MaskType = Telerik.WinControls.UI.MaskType.Standard
        Me.txNPWP.Name = "txNPWP"
        Me.txNPWP.NullText = "_"
        Me.txNPWP.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txNPWP.Size = New System.Drawing.Size(113, 23)
        Me.txNPWP.TabIndex = 16
        Me.txNPWP.TabStop = False
        Me.txNPWP.Text = "__-__-____"
        Me.txNPWP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txNPWP.ThemeName = "Office2010Black"
        CType(Me.txNPWP.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = "__-__-____"
        CType(Me.txNPWP.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
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
        Me.RadLabel1.Location = New System.Drawing.Point(9, 96)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(87, 19)
        Me.RadLabel1.TabIndex = 9
        Me.RadLabel1.Text = "Tanggal Daftar"
        '
        'txNomorRecord
        '
        Me.txNomorRecord.AllowShowFocusCues = True
        Me.txNomorRecord.AutoSize = False
        Me.txNomorRecord.BackColor = System.Drawing.Color.Transparent
        Me.txNomorRecord.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txNomorRecord.Location = New System.Drawing.Point(11, 25)
        Me.txNomorRecord.MaxLength = 8
        Me.txNomorRecord.Name = "txNomorRecord"
        Me.txNomorRecord.NullText = "NO. REKAM"
        Me.txNomorRecord.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txNomorRecord.ReadOnly = True
        Me.txNomorRecord.Size = New System.Drawing.Size(109, 23)
        Me.txNomorRecord.TabIndex = 10
        Me.txNomorRecord.ThemeName = "Office2010Black"
        CType(Me.txNomorRecord.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        CType(Me.txNomorRecord.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "NO. REKAM"
        CType(Me.txNomorRecord.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txNomorRecord.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.txNomorRecord.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        CType(Me.txNomorRecord.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'RadTextBox1
        '
        Me.RadTextBox1.AllowShowFocusCues = True
        Me.RadTextBox1.AutoSize = False
        Me.RadTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.RadTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadTextBox1.Location = New System.Drawing.Point(235, 59)
        Me.RadTextBox1.Name = "RadTextBox1"
        Me.RadTextBox1.NullText = "AREA TEMPAT / LOKASI"
        Me.RadTextBox1.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.RadTextBox1.Size = New System.Drawing.Size(194, 23)
        Me.RadTextBox1.TabIndex = 10
        Me.RadTextBox1.ThemeName = "Office2010Black"
        CType(Me.RadTextBox1.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        CType(Me.RadTextBox1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "AREA TEMPAT / LOKASI"
        CType(Me.RadTextBox1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.RadTextBox1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.RadTextBox1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        CType(Me.RadTextBox1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'RadLabel3
        '
        Me.RadLabel3.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadLabel3.ForeColor = System.Drawing.Color.Black
        Me.RadLabel3.Location = New System.Drawing.Point(233, 96)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(40, 19)
        Me.RadLabel3.TabIndex = 9
        Me.RadLabel3.Text = "Status"
        '
        'RadDropDownHGB
        '
        Me.RadDropDownHGB.AllowShowFocusCues = True
        Me.RadDropDownHGB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.RadDropDownHGB.AutoSize = False
        Me.RadDropDownHGB.BackColor = System.Drawing.Color.Transparent
        Me.RadDropDownHGB.DisplayMember = "name"
        Me.RadDropDownHGB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RadListDataItem5.Text = "OK"
        RadListDataItem6.Text = "Dalam Proses"
        RadListDataItem7.Text = "Daftar"
        RadListDataItem8.Text = "Ditolak"
        Me.RadDropDownHGB.Items.Add(RadListDataItem5)
        Me.RadDropDownHGB.Items.Add(RadListDataItem6)
        Me.RadDropDownHGB.Items.Add(RadListDataItem7)
        Me.RadDropDownHGB.Items.Add(RadListDataItem8)
        Me.RadDropDownHGB.Location = New System.Drawing.Point(289, 94)
        Me.RadDropDownHGB.Name = "RadDropDownHGB"
        Me.RadDropDownHGB.NullText = "Status"
        Me.RadDropDownHGB.Size = New System.Drawing.Size(140, 23)
        Me.RadDropDownHGB.TabIndex = 17
        Me.RadDropDownHGB.ThemeName = "Office2010Black"
        Me.RadDropDownHGB.ValueMember = "id"
        CType(Me.RadDropDownHGB.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.RadDropDownHGB.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnSave, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnClose, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 148)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(447, 33)
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
        Me.btnSave.Size = New System.Drawing.Size(217, 27)
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
        Me.btnClose.Location = New System.Drawing.Point(226, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(218, 27)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "&Keluar"
        Me.btnClose.ThemeName = "Office2010Black"
        CType(Me.btnClose.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "&Keluar"
        CType(Me.btnClose.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.btnClose.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        '
        'rFormTambahHGB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 181)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.RadGroupBox3)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "rFormTambahHGB"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Data HGB"
        Me.ThemeName = "Office2010Black"
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox3.ResumeLayout(False)
        Me.RadGroupBox3.PerformLayout()
        CType(Me.txName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txNPWP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txNomorRecord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownHGB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadGroupBox3 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents txName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txNPWP As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txNomorRecord As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownHGB As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnClose As Telerik.WinControls.UI.RadButton
End Class
