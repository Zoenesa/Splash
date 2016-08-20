<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProfilPerusahaan
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
        Me.txNPWP = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
        Me.txTelpon2 = New Telerik.WinControls.UI.RadTextBox()
        Me.Kecamatan = New Telerik.WinControls.UI.RadDropDownList()
        Me.txTelpon1 = New Telerik.WinControls.UI.RadTextBox()
        Me.Kabupaten = New Telerik.WinControls.UI.RadDropDownList()
        Me.txEmail = New Telerik.WinControls.UI.RadTextBox()
        Me.Propinsi = New Telerik.WinControls.UI.RadDropDownList()
        Me.txKodePos = New Telerik.WinControls.UI.RadTextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.btnClose = New Telerik.WinControls.UI.RadButton()
        Me.RadDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
        CType(Me.txNPWP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txTelpon2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Kecamatan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txTelpon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Kabupaten, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Propinsi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txKodePos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txNPWP
        '
        Me.txNPWP.AcceptsReturn = True
        Me.txNPWP.AllowShowFocusCues = True
        Me.txNPWP.AutoSize = False
        Me.txNPWP.BackColor = System.Drawing.Color.Transparent
        Me.txNPWP.Culture = New System.Globalization.CultureInfo("en-US")
        Me.txNPWP.EnableKeyMap = True
        Me.txNPWP.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txNPWP.Location = New System.Drawing.Point(53, 34)
        Me.txNPWP.Mask = "00.000.000.0-000.000"
        Me.txNPWP.MaskType = Telerik.WinControls.UI.MaskType.Standard
        Me.txNPWP.Modified = True
        Me.txNPWP.Name = "txNPWP"
        Me.txNPWP.NullText = "_"
        Me.txNPWP.Size = New System.Drawing.Size(119, 23)
        Me.txNPWP.TabIndex = 18
        Me.txNPWP.TabStop = False
        Me.txNPWP.Text = "__.___.___._-___.___"
        Me.txNPWP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txNPWP.ThemeName = "Office2010Black"
        Me.txNPWP.UseGenericBorderPaint = True
        CType(Me.txNPWP.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = "__.___.___._-___.___"
        CType(Me.txNPWP.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).PaintUsingParentShape = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "NPWP"
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.RadGroupBox2.Controls.Add(Me.RadTextBox1)
        Me.RadGroupBox2.Controls.Add(Me.txTelpon2)
        Me.RadGroupBox2.Controls.Add(Me.Kecamatan)
        Me.RadGroupBox2.Controls.Add(Me.txTelpon1)
        Me.RadGroupBox2.Controls.Add(Me.Kabupaten)
        Me.RadGroupBox2.Controls.Add(Me.txEmail)
        Me.RadGroupBox2.Controls.Add(Me.Propinsi)
        Me.RadGroupBox2.Controls.Add(Me.txKodePos)
        Me.RadGroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadGroupBox2.HeaderText = " Detail Alamat Perusahaan "
        Me.RadGroupBox2.Location = New System.Drawing.Point(3, 63)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(464, 188)
        Me.RadGroupBox2.TabIndex = 20
        Me.RadGroupBox2.Text = " Detail Alamat Perusahaan "
        Me.RadGroupBox2.ThemeName = "Office2010Black"
        CType(Me.RadGroupBox2.GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        '
        'RadTextBox1
        '
        Me.RadTextBox1.AllowShowFocusCues = True
        Me.RadTextBox1.AutoSize = False
        Me.RadTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.RadTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadTextBox1.Location = New System.Drawing.Point(11, 21)
        Me.RadTextBox1.Name = "RadTextBox1"
        Me.RadTextBox1.NullText = "Alamat"
        Me.RadTextBox1.Size = New System.Drawing.Size(444, 23)
        Me.RadTextBox1.TabIndex = 10
        Me.RadTextBox1.ThemeName = "Office2010Black"
        CType(Me.RadTextBox1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Alamat"
        CType(Me.RadTextBox1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.RadTextBox1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.RadTextBox1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
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
        'Kabupaten
        '
        Me.Kabupaten.AllowShowFocusCues = True
        Me.Kabupaten.AutoSize = False
        Me.Kabupaten.BackColor = System.Drawing.Color.Transparent
        Me.Kabupaten.DisplayMember = "name"
        Me.Kabupaten.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kabupaten.Location = New System.Drawing.Point(235, 53)
        Me.Kabupaten.Name = "Kabupaten"
        Me.Kabupaten.NullText = "Kabupaten"
        Me.Kabupaten.Size = New System.Drawing.Size(220, 23)
        Me.Kabupaten.TabIndex = 15
        Me.Kabupaten.ThemeName = "Office2010Black"
        Me.Kabupaten.ValueMember = "id"
        CType(Me.Kabupaten.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        CType(Me.Kabupaten.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
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
        'Propinsi
        '
        Me.Propinsi.AllowShowFocusCues = True
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnSave, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnClose, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 253)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(470, 33)
        Me.TableLayoutPanel1.TabIndex = 21
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSave.Location = New System.Drawing.Point(3, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(229, 27)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Simpan Data"
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
        Me.btnClose.Location = New System.Drawing.Point(238, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(229, 27)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "&Keluar"
        Me.btnClose.ThemeName = "Office2010Black"
        CType(Me.btnClose.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.btnClose.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'RadDropDownList1
        '
        Me.RadDropDownList1.AllowShowFocusCues = True
        Me.RadDropDownList1.AutoSize = False
        Me.RadDropDownList1.BackColor = System.Drawing.Color.Transparent
        Me.RadDropDownList1.DisplayMember = "name"
        Me.RadDropDownList1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDropDownList1.Location = New System.Drawing.Point(3, 5)
        Me.RadDropDownList1.Name = "RadDropDownList1"
        Me.RadDropDownList1.NullText = "Nama Perusahaan"
        Me.RadDropDownList1.Size = New System.Drawing.Size(464, 23)
        Me.RadDropDownList1.TabIndex = 15
        Me.RadDropDownList1.ThemeName = "Office2010Black"
        Me.RadDropDownList1.ValueMember = "id"
        CType(Me.RadDropDownList1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        CType(Me.RadDropDownList1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'FormProfilPerusahaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 286)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txNPWP)
        Me.Controls.Add(Me.RadDropDownList1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "FormProfilPerusahaan"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Company Profile"
        Me.ThemeName = "Office2010Black"
        CType(Me.txNPWP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txTelpon2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Kecamatan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txTelpon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Kabupaten, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Propinsi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txKodePos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txNPWP As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txTelpon2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Kecamatan As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents txTelpon1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Kabupaten As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents txEmail As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Propinsi As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents txKodePos As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnClose As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadDropDownList1 As Telerik.WinControls.UI.RadDropDownList
End Class
