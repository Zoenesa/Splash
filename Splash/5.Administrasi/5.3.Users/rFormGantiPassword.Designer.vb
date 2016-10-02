<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rFormGantiPassword
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.txoldPass = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txPassNew = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.txPassNext = New Telerik.WinControls.UI.RadTextBox()
        Me.PasswordStrengthControl1 = New PasswordMeter.PasswordStrengthControl()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txoldPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txPassNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txPassNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.RadButton1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSave, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 186)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(298, 32)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'RadButton1
        '
        Me.RadButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadButton1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadButton1.Location = New System.Drawing.Point(152, 3)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.RadButton1.Size = New System.Drawing.Size(143, 26)
        Me.RadButton1.TabIndex = 1
        Me.RadButton1.Text = "&Batal"
        Me.RadButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RadButton1.ThemeName = "Office2010Black"
        CType(Me.RadButton1.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        CType(Me.RadButton1.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "&Batal"
        CType(Me.RadButton1.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        CType(Me.RadButton1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.RadButton1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSave.Location = New System.Drawing.Point(3, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.btnSave.Size = New System.Drawing.Size(143, 26)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Simpan"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.ThemeName = "Office2010Black"
        CType(Me.btnSave.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        CType(Me.btnSave.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "&Simpan"
        CType(Me.btnSave.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        CType(Me.btnSave.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.btnSave.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'txoldPass
        '
        Me.txoldPass.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txoldPass.AutoSize = False
        Me.txoldPass.BackColor = System.Drawing.Color.Transparent
        Me.txoldPass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txoldPass.Location = New System.Drawing.Point(5, 24)
        Me.txoldPass.Name = "txoldPass"
        Me.txoldPass.NullText = "Password"
        Me.txoldPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txoldPass.Size = New System.Drawing.Size(292, 23)
        Me.txoldPass.TabIndex = 1
        Me.txoldPass.ThemeName = "Office2010Black"
        Me.txoldPass.UseSystemPasswordChar = True
        CType(Me.txoldPass.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Password"
        CType(Me.txoldPass.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txoldPass.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.txoldPass.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.txoldPass.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'RadLabel5
        '
        Me.RadLabel5.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadLabel5.ForeColor = System.Drawing.Color.Black
        Me.RadLabel5.Location = New System.Drawing.Point(5, 5)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(112, 19)
        Me.RadLabel5.TabIndex = 0
        Me.RadLabel5.Text = "Password Sekarang"
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadLabel1.ForeColor = System.Drawing.Color.Black
        Me.RadLabel1.Location = New System.Drawing.Point(5, 61)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(86, 19)
        Me.RadLabel1.TabIndex = 2
        Me.RadLabel1.Text = "Password Baru"
        '
        'txPassNew
        '
        Me.txPassNew.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txPassNew.AutoSize = False
        Me.txPassNew.BackColor = System.Drawing.Color.Transparent
        Me.txPassNew.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txPassNew.Location = New System.Drawing.Point(5, 80)
        Me.txPassNew.Name = "txPassNew"
        Me.txPassNew.NullText = "Invoice Number"
        Me.txPassNew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txPassNew.Size = New System.Drawing.Size(292, 23)
        Me.txPassNew.TabIndex = 3
        Me.txPassNew.ThemeName = "Office2010Black"
        Me.txPassNew.UseSystemPasswordChar = True
        CType(Me.txPassNew.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Invoice Number"
        CType(Me.txPassNew.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txPassNew.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.txPassNew.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.txPassNew.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'RadLabel2
        '
        Me.RadLabel2.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadLabel2.ForeColor = System.Drawing.Color.Black
        Me.RadLabel2.Location = New System.Drawing.Point(5, 109)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(64, 19)
        Me.RadLabel2.TabIndex = 4
        Me.RadLabel2.Text = "Konfirmasi"
        '
        'txPassNext
        '
        Me.txPassNext.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txPassNext.AutoSize = False
        Me.txPassNext.BackColor = System.Drawing.Color.Transparent
        Me.txPassNext.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txPassNext.Location = New System.Drawing.Point(5, 128)
        Me.txPassNext.Name = "txPassNext"
        Me.txPassNext.NullText = "Invoice Number"
        Me.txPassNext.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txPassNext.Size = New System.Drawing.Size(292, 23)
        Me.txPassNext.TabIndex = 5
        Me.txPassNext.ThemeName = "Office2010Black"
        Me.txPassNext.UseSystemPasswordChar = True
        CType(Me.txPassNext.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Invoice Number"
        CType(Me.txPassNext.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txPassNext.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.txPassNext.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.txPassNext.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'PasswordStrengthControl1
        '
        Me.PasswordStrengthControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PasswordStrengthControl1.Location = New System.Drawing.Point(5, 154)
        Me.PasswordStrengthControl1.Name = "PasswordStrengthControl1"
        Me.PasswordStrengthControl1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.PasswordStrengthControl1.Size = New System.Drawing.Size(292, 21)
        Me.PasswordStrengthControl1.TabIndex = 7
        '
        'rFormGantiPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 222)
        Me.Controls.Add(Me.PasswordStrengthControl1)
        Me.Controls.Add(Me.txPassNext)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.txPassNew)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.txoldPass)
        Me.Controls.Add(Me.RadLabel5)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "rFormGantiPassword"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ubah Password"
        Me.ThemeName = "Office2010Black"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txoldPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txPassNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txPassNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents txoldPass As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txPassNew As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txPassNext As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents PasswordStrengthControl1 As PasswordMeter.PasswordStrengthControl
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
End Class
