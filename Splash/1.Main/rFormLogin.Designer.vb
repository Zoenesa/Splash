<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rFormLogin
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
        Me.rTxUsername = New Telerik.WinControls.UI.RadTextBox()
        Me.rTxPassword = New Telerik.WinControls.UI.RadTextBox()
        Me.Button1 = New Telerik.WinControls.UI.RadButton()
        Me.Button2 = New Telerik.WinControls.UI.RadButton()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.rTxUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rTxPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rTxUsername
        '
        Me.rTxUsername.BackColor = System.Drawing.Color.Transparent
        Me.rTxUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rTxUsername.Location = New System.Drawing.Point(2, 12)
        Me.rTxUsername.Name = "rTxUsername"
        Me.rTxUsername.NullText = "Username"
        Me.rTxUsername.Padding = New System.Windows.Forms.Padding(8, 3, 0, 2)
        Me.rTxUsername.Size = New System.Drawing.Size(282, 23)
        Me.rTxUsername.TabIndex = 0
        Me.rTxUsername.ThemeName = "Office2010Black"
        '
        'rTxPassword
        '
        Me.rTxPassword.BackColor = System.Drawing.Color.Transparent
        Me.rTxPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rTxPassword.Location = New System.Drawing.Point(2, 45)
        Me.rTxPassword.Name = "rTxPassword"
        Me.rTxPassword.NullText = "Password"
        Me.rTxPassword.Padding = New System.Windows.Forms.Padding(8, 3, 0, 2)
        Me.rTxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.rTxPassword.Size = New System.Drawing.Size(282, 23)
        Me.rTxPassword.TabIndex = 1
        Me.rTxPassword.ThemeName = "Office2010Black"
        Me.rTxPassword.UseSystemPasswordChar = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.Location = New System.Drawing.Point(2, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 30)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&Sign In"
        Me.Button1.ThemeName = "Office2010Black"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button2.Location = New System.Drawing.Point(188, 96)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 30)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "&Cancel"
        Me.Button2.ThemeName = "Office2010Black"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(1, 74)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(122, 13)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Sign With Anonymous"
        '
        'rFormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 129)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rTxPassword)
        Me.Controls.Add(Me.rTxUsername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "rFormLogin"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "User Login"
        Me.ThemeName = "Office2010Black"
        CType(Me.rTxUsername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rTxPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rTxUsername As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents rTxPassword As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Button1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Button2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
End Class
