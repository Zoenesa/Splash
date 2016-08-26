<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateNewSQLConn
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
        Me.txserver = New Telerik.WinControls.UI.RadTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txUser = New Telerik.WinControls.UI.RadTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txPassword = New Telerik.WinControls.UI.RadTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txPort = New Telerik.WinControls.UI.RadTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txNamaKoneksi = New Telerik.WinControls.UI.RadTextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button3 = New Telerik.WinControls.UI.RadButton()
        Me.Button1 = New Telerik.WinControls.UI.RadButton()
        Me.Button2 = New Telerik.WinControls.UI.RadButton()
        CType(Me.txserver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txPort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txNamaKoneksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Button3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txserver
        '
        Me.txserver.AutoSize = False
        Me.txserver.BackColor = System.Drawing.Color.Transparent
        Me.txserver.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txserver.Location = New System.Drawing.Point(96, 41)
        Me.txserver.Name = "txserver"
        Me.txserver.NullText = "server"
        Me.txserver.Padding = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.txserver.Size = New System.Drawing.Size(296, 23)
        Me.txserver.TabIndex = 5
        Me.txserver.ThemeName = "Office2010Black"
        CType(Me.txserver.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txserver.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Padding = New System.Windows.Forms.Padding(6, 0, 6, 0)
        CType(Me.txserver.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.SystemColors.ControlDark
        CType(Me.txserver.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.SystemColors.ControlDark
        CType(Me.txserver.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.SystemColors.ControlLightLight
        CType(Me.txserver.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        CType(Me.txserver.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientAngle = 90.0!
        CType(Me.txserver.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage = 0.5!
        CType(Me.txserver.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage2 = 0.666!
        CType(Me.txserver.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Server"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 185)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Padding = New System.Windows.Forms.Padding(2)
        Me.RadStatusStrip1.Size = New System.Drawing.Size(404, 25)
        Me.RadStatusStrip1.TabIndex = 6
        Me.RadStatusStrip1.Text = "RadStatusStrip1"
        Me.RadStatusStrip1.ThemeName = "Office2010Black"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Userid"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txUser
        '
        Me.txUser.AutoSize = False
        Me.txUser.BackColor = System.Drawing.Color.Transparent
        Me.txUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txUser.Location = New System.Drawing.Point(96, 70)
        Me.txUser.Name = "txUser"
        Me.txUser.NullText = "userid"
        Me.txUser.Padding = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.txUser.Size = New System.Drawing.Size(138, 23)
        Me.txUser.TabIndex = 5
        Me.txUser.ThemeName = "Office2010Black"
        CType(Me.txUser.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txUser.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Padding = New System.Windows.Forms.Padding(6, 0, 6, 0)
        CType(Me.txUser.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.SystemColors.ControlDark
        CType(Me.txUser.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.SystemColors.ControlDark
        CType(Me.txUser.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.SystemColors.ControlLightLight
        CType(Me.txUser.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        CType(Me.txUser.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientAngle = 90.0!
        CType(Me.txUser.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage = 0.5!
        CType(Me.txUser.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage2 = 0.666!
        CType(Me.txUser.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txPassword
        '
        Me.txPassword.AutoSize = False
        Me.txPassword.BackColor = System.Drawing.Color.Transparent
        Me.txPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txPassword.Location = New System.Drawing.Point(96, 99)
        Me.txPassword.Name = "txPassword"
        Me.txPassword.NullText = "password"
        Me.txPassword.Padding = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.txPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txPassword.Size = New System.Drawing.Size(138, 23)
        Me.txPassword.TabIndex = 5
        Me.txPassword.ThemeName = "Office2010Black"
        Me.txPassword.UseSystemPasswordChar = True
        CType(Me.txPassword.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txPassword.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Padding = New System.Windows.Forms.Padding(6, 0, 6, 0)
        CType(Me.txPassword.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.SystemColors.ControlDark
        CType(Me.txPassword.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.SystemColors.ControlDark
        CType(Me.txPassword.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.SystemColors.ControlLightLight
        CType(Me.txPassword.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        CType(Me.txPassword.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientAngle = 90.0!
        CType(Me.txPassword.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage = 0.5!
        CType(Me.txPassword.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage2 = 0.666!
        CType(Me.txPassword.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(257, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Port"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txPort
        '
        Me.txPort.AutoSize = False
        Me.txPort.BackColor = System.Drawing.Color.Transparent
        Me.txPort.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txPort.Location = New System.Drawing.Point(303, 70)
        Me.txPort.MaxLength = 8
        Me.txPort.Name = "txPort"
        Me.txPort.NullText = "port"
        Me.txPort.Padding = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.txPort.Size = New System.Drawing.Size(89, 23)
        Me.txPort.TabIndex = 5
        Me.txPort.ThemeName = "Office2010Black"
        CType(Me.txPort.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txPort.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Padding = New System.Windows.Forms.Padding(6, 0, 6, 0)
        CType(Me.txPort.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.SystemColors.ControlDark
        CType(Me.txPort.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.SystemColors.ControlDark
        CType(Me.txPort.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.SystemColors.ControlLightLight
        CType(Me.txPort.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        CType(Me.txPort.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientAngle = 90.0!
        CType(Me.txPort.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage = 0.5!
        CType(Me.txPort.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage2 = 0.666!
        CType(Me.txPort.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nama Koneksi"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txNamaKoneksi
        '
        Me.txNamaKoneksi.AutoSize = False
        Me.txNamaKoneksi.BackColor = System.Drawing.Color.Transparent
        Me.txNamaKoneksi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txNamaKoneksi.Location = New System.Drawing.Point(96, 12)
        Me.txNamaKoneksi.Name = "txNamaKoneksi"
        Me.txNamaKoneksi.NullText = "Nama"
        Me.txNamaKoneksi.Padding = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.txNamaKoneksi.Size = New System.Drawing.Size(296, 23)
        Me.txNamaKoneksi.TabIndex = 5
        Me.txNamaKoneksi.ThemeName = "Office2010Black"
        CType(Me.txNamaKoneksi.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txNamaKoneksi.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Padding = New System.Windows.Forms.Padding(6, 0, 6, 0)
        CType(Me.txNamaKoneksi.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.SystemColors.ControlDark
        CType(Me.txNamaKoneksi.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.SystemColors.ControlDark
        CType(Me.txNamaKoneksi.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.SystemColors.ControlLightLight
        CType(Me.txNamaKoneksi.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        CType(Me.txNamaKoneksi.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientAngle = 90.0!
        CType(Me.txNamaKoneksi.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage = 0.5!
        CType(Me.txNamaKoneksi.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage2 = 0.666!
        CType(Me.txNamaKoneksi.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.77946!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.22053!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 146)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(404, 34)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button3.Location = New System.Drawing.Point(3, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(193, 28)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Cek &Koneksi"
        Me.Button3.ThemeName = "Office2010Black"
        CType(Me.Button3.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Cek &Koneksi"
        CType(Me.Button3.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.Button3.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button1.Location = New System.Drawing.Point(202, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 28)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "&OK"
        Me.Button1.ThemeName = "Office2010Black"
        CType(Me.Button1.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "&OK"
        CType(Me.Button1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.Button1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button2.Location = New System.Drawing.Point(306, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 28)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "&Batal"
        Me.Button2.ThemeName = "Office2010Black"
        CType(Me.Button2.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "&Batal"
        CType(Me.Button2.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.Button2.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'CreateNewSQLConn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 210)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.txPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txPort)
        Me.Controls.Add(Me.txUser)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txNamaKoneksi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txserver)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "CreateNewSQLConn"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buat SQL BARU"
        Me.ThemeName = "Office2010Black"
        CType(Me.txserver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txPort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txNamaKoneksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.Button3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txserver As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents txUser As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txPassword As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txPort As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txNamaKoneksi As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Button3 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Button1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Button2 As Telerik.WinControls.UI.RadButton
End Class

