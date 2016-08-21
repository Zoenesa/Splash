<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rFormPermission
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rFormPermission))
        Me.Button1 = New Telerik.WinControls.UI.RadButton()
        Me.rTxPassword = New Telerik.WinControls.UI.RadTextBox()
        Me.rTxUsername = New Telerik.WinControls.UI.RadTextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rTxPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rTxUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(276, 28)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&OK"
        Me.Button1.ThemeName = "Office2010Black"
        CType(Me.Button1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.Button1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'rTxPassword
        '
        Me.rTxPassword.BackColor = System.Drawing.Color.Transparent
        Me.rTxPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rTxPassword.Location = New System.Drawing.Point(2, 37)
        Me.rTxPassword.Name = "rTxPassword"
        Me.rTxPassword.NullText = "Password"
        Me.rTxPassword.Padding = New System.Windows.Forms.Padding(8, 3, 0, 2)
        Me.rTxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.rTxPassword.Size = New System.Drawing.Size(282, 23)
        Me.rTxPassword.TabIndex = 1
        Me.rTxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.rTxPassword.ThemeName = "Office2010Black"
        Me.rTxPassword.UseSystemPasswordChar = True
        CType(Me.rTxPassword.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Password"
        CType(Me.rTxPassword.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.rTxPassword.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.rTxPassword.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.rTxPassword.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'rTxUsername
        '
        Me.rTxUsername.BackColor = System.Drawing.Color.Transparent
        Me.rTxUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rTxUsername.Location = New System.Drawing.Point(2, 5)
        Me.rTxUsername.Name = "rTxUsername"
        Me.rTxUsername.Padding = New System.Windows.Forms.Padding(8, 3, 0, 2)
        Me.rTxUsername.ReadOnly = True
        Me.rTxUsername.Size = New System.Drawing.Size(282, 23)
        Me.rTxUsername.TabIndex = 0
        Me.rTxUsername.TabStop = False
        Me.rTxUsername.Text = "Input Password Administrator dibawah"
        Me.rTxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.rTxUsername.ThemeName = "Office2010Black"
        Me.rTxUsername.WordWrap = False
        CType(Me.rTxUsername.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.rTxUsername.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.rTxUsername.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.rTxUsername.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 69)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(282, 34)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'rFormPermission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 104)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.rTxPassword)
        Me.Controls.Add(Me.rTxUsername)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "rFormPermission"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Akses Permission"
        Me.ThemeName = "Office2010Black"
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rTxPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rTxUsername, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents rTxPassword As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents rTxUsername As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class
