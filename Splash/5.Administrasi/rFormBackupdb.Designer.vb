<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rFormBackupdb
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
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.btnBackup = New Telerik.WinControls.UI.RadButton()
        Me.RadGroupBox4 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.rchkWrapmode = New Telerik.WinControls.UI.RadCheckBox()
        Me.rDropExportMode = New Telerik.WinControls.UI.RadDropDownList()
        Me.rSpinEditor = New Telerik.WinControls.UI.RadSpinEditor()
        Me.rchkExportRutin = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txPassEncrypt = New Telerik.WinControls.UI.RadTextBox()
        Me.rchkEcrypt = New Telerik.WinControls.UI.RadCheckBox()
        Me.rchkDumptime = New Telerik.WinControls.UI.RadCheckBox()
        Me.rchkResetIncrement = New Telerik.WinControls.UI.RadCheckBox()
        Me.rchkExportRows = New Telerik.WinControls.UI.RadCheckBox()
        Me.rchkDrop = New Telerik.WinControls.UI.RadCheckBox()
        Me.rchkExportProc = New Telerik.WinControls.UI.RadCheckBox()
        Me.rchkAddCreate = New Telerik.WinControls.UI.RadCheckBox()
        Me.object_2726b028_de59_44fe_81ae_7d541093b214 = New Telerik.WinControls.RootRadElement()
        CType(Me.btnBackup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox4.SuspendLayout()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rchkWrapmode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rDropExportMode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rSpinEditor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rchkExportRutin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txPassEncrypt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rchkEcrypt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rchkDumptime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rchkResetIncrement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rchkExportRows, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rchkDrop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rchkExportProc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rchkAddCreate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBackup
        '
        Me.btnBackup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBackup.BackColor = System.Drawing.Color.Transparent
        Me.btnBackup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBackup.Location = New System.Drawing.Point(2, 249)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(408, 29)
        Me.btnBackup.TabIndex = 1
        Me.btnBackup.Text = "&Backup Database"
        Me.btnBackup.ThemeName = "Office2010Black"
        '
        'RadGroupBox4
        '
        Me.RadGroupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.RadGroupBox4.Controls.Add(Me.RadPanel1)
        Me.RadGroupBox4.Controls.Add(Me.rSpinEditor)
        Me.RadGroupBox4.Controls.Add(Me.rchkExportRutin)
        Me.RadGroupBox4.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox4.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox4.Controls.Add(Me.txPassEncrypt)
        Me.RadGroupBox4.Controls.Add(Me.rchkEcrypt)
        Me.RadGroupBox4.Controls.Add(Me.rchkDumptime)
        Me.RadGroupBox4.Controls.Add(Me.rchkResetIncrement)
        Me.RadGroupBox4.Controls.Add(Me.rchkExportRows)
        Me.RadGroupBox4.Controls.Add(Me.rchkDrop)
        Me.RadGroupBox4.Controls.Add(Me.rchkExportProc)
        Me.RadGroupBox4.Controls.Add(Me.rchkAddCreate)
        Me.RadGroupBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadGroupBox4.HeaderText = "Advanced Option"
        Me.RadGroupBox4.Location = New System.Drawing.Point(2, 3)
        Me.RadGroupBox4.Name = "RadGroupBox4"
        Me.RadGroupBox4.Size = New System.Drawing.Size(408, 240)
        Me.RadGroupBox4.TabIndex = 0
        Me.RadGroupBox4.Text = "Advanced Option"
        Me.RadGroupBox4.ThemeName = "Office2010Black"
        CType(Me.RadGroupBox4.GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        '
        'RadPanel1
        '
        Me.RadPanel1.Controls.Add(Me.RadLabel3)
        Me.RadPanel1.Controls.Add(Me.rchkWrapmode)
        Me.RadPanel1.Controls.Add(Me.rDropExportMode)
        Me.RadPanel1.Location = New System.Drawing.Point(7, 174)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(312, 56)
        Me.RadPanel1.TabIndex = 11
        Me.RadPanel1.TabStop = False
        Me.RadPanel1.ThemeName = "Office2010Black"
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadLabel3.Location = New System.Drawing.Point(7, 7)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(115, 19)
        Me.RadLabel3.TabIndex = 0
        Me.RadLabel3.Text = "Rows Export Mode :"
        '
        'rchkWrapmode
        '
        Me.rchkWrapmode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rchkWrapmode.Location = New System.Drawing.Point(7, 32)
        Me.rchkWrapmode.Name = "rchkWrapmode"
        Me.rchkWrapmode.Size = New System.Drawing.Size(214, 19)
        Me.rchkWrapmode.TabIndex = 2
        Me.rchkWrapmode.Text = "Wrap Exported Rows in Transaction"
        '
        'rDropExportMode
        '
        Me.rDropExportMode.AutoSize = False
        Me.rDropExportMode.BackColor = System.Drawing.Color.Transparent
        Me.rDropExportMode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RadListDataItem3.Text = "Normal"
        RadListDataItem4.Text = "Revisions"
        Me.rDropExportMode.Items.Add(RadListDataItem3)
        Me.rDropExportMode.Items.Add(RadListDataItem4)
        Me.rDropExportMode.Location = New System.Drawing.Point(130, 5)
        Me.rDropExportMode.Name = "rDropExportMode"
        Me.rDropExportMode.NullText = "--Choose--"
        Me.rDropExportMode.Size = New System.Drawing.Size(172, 23)
        Me.rDropExportMode.TabIndex = 1
        Me.rDropExportMode.ThemeName = "Office2010Black"
        '
        'rSpinEditor
        '
        Me.rSpinEditor.AutoScroll = True
        Me.rSpinEditor.AutoSize = False
        Me.rSpinEditor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rSpinEditor.Location = New System.Drawing.Point(298, 103)
        Me.rSpinEditor.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.rSpinEditor.Name = "rSpinEditor"
        Me.rSpinEditor.Padding = New System.Windows.Forms.Padding(0, 1, 0, 2)
        Me.rSpinEditor.RightMouseButtonReset = True
        '
        '
        '
        Me.rSpinEditor.RootElement.Alignment = System.Drawing.ContentAlignment.MiddleRight
        Me.rSpinEditor.RootElement.Margin = New System.Windows.Forms.Padding(0)
        Me.rSpinEditor.Size = New System.Drawing.Size(100, 23)
        Me.rSpinEditor.TabIndex = 9
        Me.rSpinEditor.TabStop = False
        Me.rSpinEditor.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.rSpinEditor.ThemeName = "Office2010Black"
        Me.rSpinEditor.Value = New Decimal(New Integer() {6513788, 0, 0, 0})
        Me.rSpinEditor.Wrap = True
        CType(Me.rSpinEditor.GetChildAt(0), Telerik.WinControls.UI.RadSpinElement).Padding = New System.Windows.Forms.Padding(0, 1, 0, 2)
        CType(Me.rSpinEditor.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Text = "6513788"
        CType(Me.rSpinEditor.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Margin = New System.Windows.Forms.Padding(0, 2, 0, 1)
        CType(Me.rSpinEditor.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.StackLayoutElement).Margin = New System.Windows.Forms.Padding(0, -1, 0, -2)
        '
        'rchkExportRutin
        '
        Me.rchkExportRutin.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rchkExportRutin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rchkExportRutin.Location = New System.Drawing.Point(201, 135)
        Me.rchkExportRutin.Name = "rchkExportRutin"
        Me.rchkExportRutin.Size = New System.Drawing.Size(197, 19)
        Me.rchkExportRutin.TabIndex = 10
        Me.rchkExportRutin.Text = "Export Routines Without Definer"
        Me.rchkExportRutin.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadLabel2.Location = New System.Drawing.Point(201, 104)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(98, 19)
        Me.RadLabel2.TabIndex = 8
        Me.RadLabel2.Text = "Max SQL Length:"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadLabel1.Location = New System.Drawing.Point(201, 51)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(61, 19)
        Me.RadLabel1.TabIndex = 6
        Me.RadLabel1.Text = "Password:"
        '
        'txPassEncrypt
        '
        Me.txPassEncrypt.AutoSize = False
        Me.txPassEncrypt.BackColor = System.Drawing.Color.Transparent
        Me.txPassEncrypt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txPassEncrypt.Location = New System.Drawing.Point(261, 49)
        Me.txPassEncrypt.Name = "txPassEncrypt"
        Me.txPassEncrypt.NullText = "Invoice Number"
        Me.txPassEncrypt.Size = New System.Drawing.Size(137, 23)
        Me.txPassEncrypt.TabIndex = 7
        Me.txPassEncrypt.ThemeName = "Office2010Black"
        '
        'rchkEcrypt
        '
        Me.rchkEcrypt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rchkEcrypt.Location = New System.Drawing.Point(201, 24)
        Me.rchkEcrypt.Name = "rchkEcrypt"
        Me.rchkEcrypt.Size = New System.Drawing.Size(118, 19)
        Me.rchkEcrypt.TabIndex = 5
        Me.rchkEcrypt.Text = "Enable Encryption"
        '
        'rchkDumptime
        '
        Me.rchkDumptime.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rchkDumptime.Location = New System.Drawing.Point(201, 78)
        Me.rchkDumptime.Name = "rchkDumptime"
        Me.rchkDumptime.Size = New System.Drawing.Size(126, 19)
        Me.rchkDumptime.TabIndex = 3
        Me.rchkDumptime.Text = "Record Dump Time"
        '
        'rchkResetIncrement
        '
        Me.rchkResetIncrement.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rchkResetIncrement.Location = New System.Drawing.Point(10, 99)
        Me.rchkResetIncrement.Name = "rchkResetIncrement"
        Me.rchkResetIncrement.Size = New System.Drawing.Size(140, 19)
        Me.rchkResetIncrement.TabIndex = 3
        Me.rchkResetIncrement.Text = "Reset Auto-Increment"
        '
        'rchkExportRows
        '
        Me.rchkExportRows.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rchkExportRows.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rchkExportRows.Location = New System.Drawing.Point(10, 74)
        Me.rchkExportRows.Name = "rchkExportRows"
        Me.rchkExportRows.Size = New System.Drawing.Size(88, 19)
        Me.rchkExportRows.TabIndex = 2
        Me.rchkExportRows.Text = "Export Rows"
        Me.rchkExportRows.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'rchkDrop
        '
        Me.rchkDrop.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rchkDrop.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rchkDrop.Location = New System.Drawing.Point(10, 49)
        Me.rchkDrop.Name = "rchkDrop"
        Me.rchkDrop.Size = New System.Drawing.Size(132, 19)
        Me.rchkDrop.TabIndex = 1
        Me.rchkDrop.Text = "Add Drop/Create db"
        Me.rchkDrop.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'rchkExportProc
        '
        Me.rchkExportProc.AutoSize = False
        Me.rchkExportProc.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rchkExportProc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rchkExportProc.Location = New System.Drawing.Point(10, 125)
        Me.rchkExportProc.Name = "rchkExportProc"
        Me.rchkExportProc.Size = New System.Drawing.Size(174, 39)
        Me.rchkExportProc.TabIndex = 4
        Me.rchkExportProc.Text = "Export Procedur, Functions, Triggers, Events, Views"
        Me.rchkExportProc.TextWrap = True
        Me.rchkExportProc.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'rchkAddCreate
        '
        Me.rchkAddCreate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rchkAddCreate.Location = New System.Drawing.Point(10, 24)
        Me.rchkAddCreate.Name = "rchkAddCreate"
        Me.rchkAddCreate.Size = New System.Drawing.Size(100, 19)
        Me.rchkAddCreate.TabIndex = 0
        Me.rchkAddCreate.Text = "Add Create db"
        '
        'object_2726b028_de59_44fe_81ae_7d541093b214
        '
        Me.object_2726b028_de59_44fe_81ae_7d541093b214.Name = "object_2726b028_de59_44fe_81ae_7d541093b214"
        Me.object_2726b028_de59_44fe_81ae_7d541093b214.StretchHorizontally = True
        Me.object_2726b028_de59_44fe_81ae_7d541093b214.StretchVertically = True
        '
        'rFormBackupdb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 281)
        Me.Controls.Add(Me.RadGroupBox4)
        Me.Controls.Add(Me.btnBackup)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "rFormBackupdb"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Backup Database"
        Me.ThemeName = "Office2010Black"
        CType(Me.btnBackup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox4.ResumeLayout(False)
        Me.RadGroupBox4.PerformLayout()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rchkWrapmode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rDropExportMode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rSpinEditor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rchkExportRutin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txPassEncrypt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rchkEcrypt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rchkDumptime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rchkResetIncrement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rchkExportRows, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rchkDrop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rchkExportProc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rchkAddCreate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBackup As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox4 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents rchkAddCreate As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents rchkEcrypt As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents rchkResetIncrement As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents rchkExportRows As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents rchkDrop As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents txPassEncrypt As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents rchkExportRutin As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents rchkExportProc As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents rDropExportMode As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents rchkWrapmode As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents object_2726b028_de59_44fe_81ae_7d541093b214 As Telerik.WinControls.RootRadElement
    Friend WithEvents rSpinEditor As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents rchkDumptime As Telerik.WinControls.UI.RadCheckBox
End Class
