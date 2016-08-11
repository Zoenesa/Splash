<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rFormExportCSV
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
        Me.components = New System.ComponentModel.Container()
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.pbar = New System.Windows.Forms.ProgressBar()
        Me.bwExport = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.rSemicol = New Telerik.WinControls.UI.RadRadioButton()
        Me.rKoma = New Telerik.WinControls.UI.RadRadioButton()
        Me.rOther = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadTextBox2 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.rDropInvoiceType = New Telerik.WinControls.UI.RadDropDownList()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.rSemicol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rKoma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rOther, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rDropInvoiceType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadButton1
        '
        Me.RadButton1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadButton1.Location = New System.Drawing.Point(2, 163)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(424, 24)
        Me.RadButton1.TabIndex = 0
        Me.RadButton1.Text = "Export CSV"
        Me.RadButton1.ThemeName = "Office2010Black"
        '
        'RadTextBox1
        '
        Me.RadTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.RadTextBox1.Location = New System.Drawing.Point(2, 5)
        Me.RadTextBox1.Name = "RadTextBox1"
        Me.RadTextBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RadTextBox1.Size = New System.Drawing.Size(316, 23)
        Me.RadTextBox1.TabIndex = 2
        Me.RadTextBox1.ThemeName = "Office2010Black"
        '
        'RadButton2
        '
        Me.RadButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadButton2.Location = New System.Drawing.Point(324, 5)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(102, 23)
        Me.RadButton2.TabIndex = 0
        Me.RadButton2.Text = "Pilih &Folder"
        Me.RadButton2.ThemeName = "Office2010Black"
        '
        'pbar
        '
        Me.pbar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbar.Location = New System.Drawing.Point(2, 139)
        Me.pbar.Name = "pbar"
        Me.pbar.Size = New System.Drawing.Size(424, 19)
        Me.pbar.Step = 1
        Me.pbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbar.TabIndex = 3
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.RadGroupBox1.Controls.Add(Me.rOther)
        Me.RadGroupBox1.Controls.Add(Me.rKoma)
        Me.RadGroupBox1.Controls.Add(Me.RadTextBox2)
        Me.RadGroupBox1.Controls.Add(Me.rSemicol)
        Me.RadGroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadGroupBox1.HeaderText = "Delimiter"
        Me.RadGroupBox1.Location = New System.Drawing.Point(2, 31)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(201, 104)
        Me.RadGroupBox1.TabIndex = 6
        Me.RadGroupBox1.Text = "Delimiter"
        Me.RadGroupBox1.ThemeName = "Office2010Black"
        CType(Me.RadGroupBox1.GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        '
        'rSemicol
        '
        Me.rSemicol.AutoSize = False
        Me.rSemicol.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rSemicol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.rSemicol.Location = New System.Drawing.Point(9, 23)
        Me.rSemicol.Name = "rSemicol"
        Me.rSemicol.Size = New System.Drawing.Size(185, 19)
        Me.rSemicol.TabIndex = 2
        Me.rSemicol.Text = "Semicolon"
        Me.rSemicol.ThemeName = "Office2010Black"
        '
        'rKoma
        '
        Me.rKoma.AutoSize = False
        Me.rKoma.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rKoma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.rKoma.Location = New System.Drawing.Point(9, 48)
        Me.rKoma.Name = "rKoma"
        Me.rKoma.Size = New System.Drawing.Size(183, 19)
        Me.rKoma.TabIndex = 2
        Me.rKoma.Text = "Koma"
        Me.rKoma.ThemeName = "Office2010Black"
        '
        'rOther
        '
        Me.rOther.AutoSize = False
        Me.rOther.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rOther.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.rOther.Location = New System.Drawing.Point(9, 73)
        Me.rOther.Name = "rOther"
        Me.rOther.Size = New System.Drawing.Size(74, 19)
        Me.rOther.TabIndex = 2
        Me.rOther.Text = "Lainnya :"
        Me.rOther.ThemeName = "Office2010Black"
        '
        'RadTextBox2
        '
        Me.RadTextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.RadTextBox2.Location = New System.Drawing.Point(85, 71)
        Me.RadTextBox2.MaxLength = 5
        Me.RadTextBox2.Name = "RadTextBox2"
        Me.RadTextBox2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RadTextBox2.Size = New System.Drawing.Size(65, 23)
        Me.RadTextBox2.TabIndex = 2
        Me.RadTextBox2.ThemeName = "Office2010Black"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(209, 54)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(53, 19)
        Me.RadLabel1.TabIndex = 7
        Me.RadLabel1.Text = "Qualifier"
        '
        'rDropInvoiceType
        '
        Me.rDropInvoiceType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rDropInvoiceType.AutoSize = False
        Me.rDropInvoiceType.BackColor = System.Drawing.Color.Transparent
        Me.rDropInvoiceType.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RadListDataItem1.Text = """"
        RadListDataItem2.Text = "'"
        RadListDataItem3.Text = "{none}"
        Me.rDropInvoiceType.Items.Add(RadListDataItem1)
        Me.rDropInvoiceType.Items.Add(RadListDataItem2)
        Me.rDropInvoiceType.Items.Add(RadListDataItem3)
        Me.rDropInvoiceType.Location = New System.Drawing.Point(268, 52)
        Me.rDropInvoiceType.Name = "rDropInvoiceType"
        Me.rDropInvoiceType.Size = New System.Drawing.Size(158, 23)
        Me.rDropInvoiceType.TabIndex = 11
        Me.rDropInvoiceType.ThemeName = "Office2010Black"
        '
        'rFormExportCSV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 188)
        Me.Controls.Add(Me.rDropInvoiceType)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Controls.Add(Me.pbar)
        Me.Controls.Add(Me.RadTextBox1)
        Me.Controls.Add(Me.RadButton2)
        Me.Controls.Add(Me.RadButton1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "rFormExportCSV"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export Data"
        Me.ThemeName = "Office2010Black"
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.rSemicol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rKoma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rOther, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rDropInvoiceType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents pbar As System.Windows.Forms.ProgressBar
    Friend WithEvents bwExport As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents rOther As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rKoma As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rSemicol As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadTextBox2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents rDropInvoiceType As Telerik.WinControls.UI.RadDropDownList
End Class
