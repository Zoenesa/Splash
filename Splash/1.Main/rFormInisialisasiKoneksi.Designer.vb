﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rFormInisialisasiKoneksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rFormInisialisasiKoneksi))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button3 = New Telerik.WinControls.UI.RadButton()
        Me.Button1 = New Telerik.WinControls.UI.RadButton()
        Me.Button2 = New Telerik.WinControls.UI.RadButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txdbname = New Telerik.WinControls.UI.RadTextBox()
        Me.txserver = New Telerik.WinControls.UI.RadTextBox()
        Me.txUser = New Telerik.WinControls.UI.RadTextBox()
        Me.txPort = New Telerik.WinControls.UI.RadTextBox()
        Me.txPass = New Telerik.WinControls.UI.RadTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Button3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txdbname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txserver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txPort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 154)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(357, 34)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button3.Location = New System.Drawing.Point(3, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(26, 1, 10, 1)
        Me.Button3.Size = New System.Drawing.Size(141, 28)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Cek &Koneksi"
        Me.Button3.ThemeName = "Office2010Black"
        CType(Me.Button3.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Cek &Koneksi"
        CType(Me.Button3.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Padding = New System.Windows.Forms.Padding(26, 1, 10, 1)
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
        Me.Button1.Location = New System.Drawing.Point(150, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(24, 1, 8, 1)
        Me.Button1.Size = New System.Drawing.Size(99, 28)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "&OK"
        Me.Button1.ThemeName = "Office2010Black"
        CType(Me.Button1.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "&OK"
        CType(Me.Button1.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Padding = New System.Windows.Forms.Padding(24, 1, 8, 1)
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
        Me.Button2.Location = New System.Drawing.Point(255, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(24, 1, 8, 1)
        Me.Button2.Size = New System.Drawing.Size(99, 28)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "&Batal"
        Me.Button2.ThemeName = "Office2010Black"
        CType(Me.Button2.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "&Batal"
        CType(Me.Button2.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Padding = New System.Windows.Forms.Padding(24, 1, 8, 1)
        CType(Me.Button2.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.Button2.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Database"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Server"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Port"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txdbname
        '
        Me.txdbname.BackColor = System.Drawing.Color.Transparent
        Me.txdbname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txdbname.Location = New System.Drawing.Point(106, 6)
        Me.txdbname.Name = "txdbname"
        Me.txdbname.NullText = "database"
        Me.txdbname.Padding = New System.Windows.Forms.Padding(6, 2, 6, 3)
        Me.txdbname.Size = New System.Drawing.Size(245, 25)
        Me.txdbname.TabIndex = 1
        Me.txdbname.ThemeName = "Office2010Black"
        CType(Me.txdbname.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txdbname.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        CType(Me.txdbname.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Opacity = 1.0R
        CType(Me.txdbname.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Padding = New System.Windows.Forms.Padding(6, 2, 6, 3)
        CType(Me.txdbname.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Margin = New System.Windows.Forms.Padding(1)
        CType(Me.txdbname.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ShouldPaint = False
        CType(Me.txdbname.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ClipDrawing = False
        CType(Me.txdbname.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).AngleTransform = 0!
        CType(Me.txdbname.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "database"
        CType(Me.txdbname.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txdbname.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.txdbname.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        CType(Me.txdbname.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Opacity = 1.0R
        CType(Me.txdbname.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Padding = New System.Windows.Forms.Padding(0)
        CType(Me.txdbname.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Margin = New System.Windows.Forms.Padding(0)
        CType(Me.txdbname.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).ShouldPaint = False
        CType(Me.txdbname.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.SystemColors.ControlDark
        CType(Me.txdbname.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.Transparent
        CType(Me.txdbname.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.SystemColors.ControlLightLight
        CType(Me.txdbname.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).NumberOfColors = 1
        CType(Me.txdbname.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.txdbname.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientAngle = 90.0!
        CType(Me.txdbname.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage = 0.5!
        CType(Me.txdbname.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage2 = 0.666!
        CType(Me.txdbname.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txdbname.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).Opacity = 1.0R
        CType(Me.txdbname.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).Padding = New System.Windows.Forms.Padding(0)
        CType(Me.txdbname.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).Margin = New System.Windows.Forms.Padding(0)
        CType(Me.txdbname.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Width = 1.0!
        CType(Me.txdbname.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BottomWidth = 1.0!
        CType(Me.txdbname.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BottomColor = System.Drawing.SystemColors.ControlDark
        CType(Me.txdbname.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        CType(Me.txdbname.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        CType(Me.txdbname.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).InnerColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        CType(Me.txdbname.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).InnerColor2 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        CType(Me.txdbname.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        CType(Me.txdbname.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BackColor = System.Drawing.SystemColors.ActiveBorder
        CType(Me.txdbname.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Opacity = 1.0R
        CType(Me.txdbname.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Padding = New System.Windows.Forms.Padding(0)
        CType(Me.txdbname.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Alignment = System.Drawing.ContentAlignment.TopLeft
        CType(Me.txdbname.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ClipDrawing = False
        '
        'txserver
        '
        Me.txserver.AutoSize = False
        Me.txserver.BackColor = System.Drawing.Color.Transparent
        Me.txserver.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txserver.Location = New System.Drawing.Point(106, 36)
        Me.txserver.Name = "txserver"
        Me.txserver.NullText = "server"
        Me.txserver.Padding = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.txserver.Size = New System.Drawing.Size(245, 23)
        Me.txserver.TabIndex = 3
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
        'txUser
        '
        Me.txUser.AutoSize = False
        Me.txUser.BackColor = System.Drawing.Color.Transparent
        Me.txUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txUser.Location = New System.Drawing.Point(106, 94)
        Me.txUser.Name = "txUser"
        Me.txUser.NullText = "Userid"
        Me.txUser.Padding = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.txUser.Size = New System.Drawing.Size(202, 23)
        Me.txUser.TabIndex = 6
        Me.txUser.ThemeName = "Office2010Black"
        CType(Me.txUser.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Padding = New System.Windows.Forms.Padding(6, 0, 6, 0)
        CType(Me.txUser.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Userid"
        CType(Me.txUser.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txUser.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.txUser.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.txUser.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'txPort
        '
        Me.txPort.AutoSize = False
        Me.txPort.BackColor = System.Drawing.Color.Transparent
        Me.txPort.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txPort.Location = New System.Drawing.Point(106, 65)
        Me.txPort.Name = "txPort"
        Me.txPort.NullText = "port"
        Me.txPort.Padding = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.txPort.Size = New System.Drawing.Size(114, 23)
        Me.txPort.TabIndex = 5
        Me.txPort.ThemeName = "Office2010Black"
        CType(Me.txPort.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txPort.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Padding = New System.Windows.Forms.Padding(6, 0, 6, 0)
        CType(Me.txPort.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'txPass
        '
        Me.txPass.AutoSize = False
        Me.txPass.BackColor = System.Drawing.Color.Transparent
        Me.txPass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txPass.Location = New System.Drawing.Point(106, 123)
        Me.txPass.Name = "txPass"
        Me.txPass.NullText = "Password"
        Me.txPass.Padding = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.txPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txPass.Size = New System.Drawing.Size(202, 23)
        Me.txPass.TabIndex = 7
        Me.txPass.ThemeName = "Office2010Black"
        Me.txPass.UseSystemPasswordChar = True
        CType(Me.txPass.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Padding = New System.Windows.Forms.Padding(6, 0, 6, 0)
        CType(Me.txPass.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Password"
        CType(Me.txPass.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txPass.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.txPass.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.txPass.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Password"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rFormInisialisasiKoneksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 189)
        Me.ControlBox = False
        Me.Controls.Add(Me.txPass)
        Me.Controls.Add(Me.txPort)
        Me.Controls.Add(Me.txUser)
        Me.Controls.Add(Me.txserver)
        Me.Controls.Add(Me.txdbname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "rFormInisialisasiKoneksi"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inisialisasi Koneksi"
        Me.ThemeName = "Office2010Black"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.Button3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txdbname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txserver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txPort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents txdbname As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Button2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Button3 As Telerik.WinControls.UI.RadButton
    Friend WithEvents txserver As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txUser As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txPort As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txPass As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
