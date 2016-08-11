<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rFormImport
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
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
        Me.btnSelectFile = New Telerik.WinControls.UI.RadButton()
        Me.rDropInvoiceType = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
        Me.rOther = New Telerik.WinControls.UI.RadRadioButton()
        Me.rKoma = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadTextBox2 = New Telerik.WinControls.UI.RadTextBox()
        Me.rSemicol = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadPageView1 = New Telerik.WinControls.UI.RadPageView()
        Me.RadPageViewPage1 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton3 = New Telerik.WinControls.UI.RadButton()
        Me.btnLoad = New Telerik.WinControls.UI.RadButton()
        Me.RadTextBox3 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadPageViewPage2 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.dgPreview = New System.Windows.Forms.DataGridView()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSelectFile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rDropInvoiceType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.RadCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rOther, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rKoma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rSemicol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageView1.SuspendLayout()
        Me.RadPageViewPage1.SuspendLayout()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageViewPage2.SuspendLayout()
        CType(Me.dgPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadTextBox1
        '
        Me.RadTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.RadTextBox1.Location = New System.Drawing.Point(67, 7)
        Me.RadTextBox1.Name = "RadTextBox1"
        Me.RadTextBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RadTextBox1.Size = New System.Drawing.Size(549, 23)
        Me.RadTextBox1.TabIndex = 4
        Me.RadTextBox1.ThemeName = "Office2010Black"
        '
        'btnSelectFile
        '
        Me.btnSelectFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectFile.BackColor = System.Drawing.Color.Transparent
        Me.btnSelectFile.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSelectFile.Location = New System.Drawing.Point(622, 7)
        Me.btnSelectFile.Name = "btnSelectFile"
        Me.btnSelectFile.Size = New System.Drawing.Size(98, 23)
        Me.btnSelectFile.TabIndex = 3
        Me.btnSelectFile.Text = "Pilih &File"
        Me.btnSelectFile.ThemeName = "Office2010Black"
        '
        'rDropInvoiceType
        '
        Me.rDropInvoiceType.AutoSize = False
        Me.rDropInvoiceType.BackColor = System.Drawing.Color.Transparent
        Me.rDropInvoiceType.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RadListDataItem1.Text = """"
        RadListDataItem2.Text = "'"
        RadListDataItem3.Text = "{none}"
        Me.rDropInvoiceType.Items.Add(RadListDataItem1)
        Me.rDropInvoiceType.Items.Add(RadListDataItem2)
        Me.rDropInvoiceType.Items.Add(RadListDataItem3)
        Me.rDropInvoiceType.Location = New System.Drawing.Point(577, 21)
        Me.rDropInvoiceType.Name = "rDropInvoiceType"
        Me.rDropInvoiceType.Size = New System.Drawing.Size(129, 23)
        Me.rDropInvoiceType.TabIndex = 14
        Me.rDropInvoiceType.ThemeName = "Office2010Black"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(520, 23)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(53, 19)
        Me.RadLabel1.TabIndex = 13
        Me.RadLabel1.Text = "Qualifier"
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.RadGroupBox1.Controls.Add(Me.RadCheckBox1)
        Me.RadGroupBox1.Controls.Add(Me.rDropInvoiceType)
        Me.RadGroupBox1.Controls.Add(Me.rOther)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox1.Controls.Add(Me.rKoma)
        Me.RadGroupBox1.Controls.Add(Me.RadTextBox2)
        Me.RadGroupBox1.Controls.Add(Me.rSemicol)
        Me.RadGroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadGroupBox1.HeaderText = "Options"
        Me.RadGroupBox1.Location = New System.Drawing.Point(2, 35)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(718, 61)
        Me.RadGroupBox1.TabIndex = 12
        Me.RadGroupBox1.Text = "Options"
        Me.RadGroupBox1.ThemeName = "Office2010Black"
        CType(Me.RadGroupBox1.GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        '
        'RadCheckBox1
        '
        Me.RadCheckBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadCheckBox1.Location = New System.Drawing.Point(35, 23)
        Me.RadCheckBox1.Name = "RadCheckBox1"
        Me.RadCheckBox1.Size = New System.Drawing.Size(60, 19)
        Me.RadCheckBox1.TabIndex = 14
        Me.RadCheckBox1.Text = "Header"
        '
        'rOther
        '
        Me.rOther.AutoSize = False
        Me.rOther.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rOther.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.rOther.Location = New System.Drawing.Point(313, 23)
        Me.rOther.Name = "rOther"
        Me.rOther.Size = New System.Drawing.Size(74, 19)
        Me.rOther.TabIndex = 2
        Me.rOther.Text = "Lainnya :"
        Me.rOther.ThemeName = "Office2010Black"
        '
        'rKoma
        '
        Me.rKoma.AutoSize = False
        Me.rKoma.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rKoma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.rKoma.Location = New System.Drawing.Point(233, 23)
        Me.rKoma.Name = "rKoma"
        Me.rKoma.Size = New System.Drawing.Size(74, 19)
        Me.rKoma.TabIndex = 2
        Me.rKoma.Text = "Koma"
        Me.rKoma.ThemeName = "Office2010Black"
        '
        'RadTextBox2
        '
        Me.RadTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.RadTextBox2.Location = New System.Drawing.Point(389, 21)
        Me.RadTextBox2.MaxLength = 5
        Me.RadTextBox2.Name = "RadTextBox2"
        Me.RadTextBox2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RadTextBox2.Size = New System.Drawing.Size(72, 23)
        Me.RadTextBox2.TabIndex = 2
        Me.RadTextBox2.ThemeName = "Office2010Black"
        '
        'rSemicol
        '
        Me.rSemicol.AutoSize = False
        Me.rSemicol.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rSemicol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.rSemicol.Location = New System.Drawing.Point(143, 23)
        Me.rSemicol.Name = "rSemicol"
        Me.rSemicol.Size = New System.Drawing.Size(84, 19)
        Me.rSemicol.TabIndex = 2
        Me.rSemicol.Text = "Semicolon"
        Me.rSemicol.ThemeName = "Office2010Black"
        '
        'RadPageView1
        '
        Me.RadPageView1.Controls.Add(Me.RadPageViewPage1)
        Me.RadPageView1.Controls.Add(Me.RadPageViewPage2)
        Me.RadPageView1.DefaultPage = Me.RadPageViewPage1
        Me.RadPageView1.ItemSizeMode = CType((Telerik.WinControls.UI.PageViewItemSizeMode.EqualWidth Or Telerik.WinControls.UI.PageViewItemSizeMode.EqualHeight), Telerik.WinControls.UI.PageViewItemSizeMode)
        Me.RadPageView1.Location = New System.Drawing.Point(2, 102)
        Me.RadPageView1.Name = "RadPageView1"
        Me.RadPageView1.SelectedPage = Me.RadPageViewPage2
        Me.RadPageView1.Size = New System.Drawing.Size(718, 273)
        Me.RadPageView1.TabIndex = 13
        Me.RadPageView1.Text = "RadPageView1"
        Me.RadPageView1.ThemeName = "Office2010Black"
        CType(Me.RadPageView1.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).StripButtons = Telerik.WinControls.UI.StripViewButtons.None
        CType(Me.RadPageView1.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ItemFitMode = Telerik.WinControls.UI.StripViewItemFitMode.Fill
        CType(Me.RadPageView1.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ItemSizeMode = CType((Telerik.WinControls.UI.PageViewItemSizeMode.EqualWidth Or Telerik.WinControls.UI.PageViewItemSizeMode.EqualHeight), Telerik.WinControls.UI.PageViewItemSizeMode)
        '
        'RadPageViewPage1
        '
        Me.RadPageViewPage1.Controls.Add(Me.RadButton1)
        Me.RadPageViewPage1.Controls.Add(Me.RadButton3)
        Me.RadPageViewPage1.Controls.Add(Me.btnLoad)
        Me.RadPageViewPage1.Controls.Add(Me.RadTextBox3)
        Me.RadPageViewPage1.ItemSize = New System.Drawing.SizeF(350.0!, 30.0!)
        Me.RadPageViewPage1.Location = New System.Drawing.Point(12, 40)
        Me.RadPageViewPage1.Name = "RadPageViewPage1"
        Me.RadPageViewPage1.Size = New System.Drawing.Size(694, 221)
        Me.RadPageViewPage1.Text = "Preview CSV"
        '
        'RadButton1
        '
        Me.RadButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadButton1.Location = New System.Drawing.Point(223, 3)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(154, 23)
        Me.RadButton1.TabIndex = 3
        Me.RadButton1.Text = "Transfer Ke DataTable"
        Me.RadButton1.ThemeName = "Office2010Black"
        '
        'RadButton3
        '
        Me.RadButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadButton3.BackColor = System.Drawing.Color.Transparent
        Me.RadButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadButton3.Location = New System.Drawing.Point(107, 3)
        Me.RadButton3.Name = "RadButton3"
        Me.RadButton3.Size = New System.Drawing.Size(98, 23)
        Me.RadButton3.TabIndex = 3
        Me.RadButton3.Text = "Clear"
        Me.RadButton3.ThemeName = "Office2010Black"
        '
        'btnLoad
        '
        Me.btnLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLoad.BackColor = System.Drawing.Color.Transparent
        Me.btnLoad.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLoad.Location = New System.Drawing.Point(3, 3)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(98, 23)
        Me.btnLoad.TabIndex = 3
        Me.btnLoad.Text = "Load"
        Me.btnLoad.ThemeName = "Office2010Black"
        '
        'RadTextBox3
        '
        Me.RadTextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadTextBox3.AutoSize = False
        Me.RadTextBox3.BackColor = System.Drawing.Color.Transparent
        Me.RadTextBox3.Location = New System.Drawing.Point(3, 32)
        Me.RadTextBox3.Multiline = True
        Me.RadTextBox3.Name = "RadTextBox3"
        Me.RadTextBox3.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RadTextBox3.Size = New System.Drawing.Size(688, 186)
        Me.RadTextBox3.TabIndex = 4
        Me.RadTextBox3.ThemeName = "Office2010Black"
        '
        'RadPageViewPage2
        '
        Me.RadPageViewPage2.Controls.Add(Me.dgPreview)
        Me.RadPageViewPage2.ItemSize = New System.Drawing.SizeF(350.0!, 30.0!)
        Me.RadPageViewPage2.Location = New System.Drawing.Point(12, 40)
        Me.RadPageViewPage2.Name = "RadPageViewPage2"
        Me.RadPageViewPage2.Size = New System.Drawing.Size(694, 221)
        Me.RadPageViewPage2.Text = "Preview Table"
        '
        'dgPreview
        '
        Me.dgPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPreview.Location = New System.Drawing.Point(3, 3)
        Me.dgPreview.Name = "dgPreview"
        Me.dgPreview.Size = New System.Drawing.Size(691, 219)
        Me.dgPreview.TabIndex = 0
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(2, 9)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(59, 19)
        Me.RadLabel2.TabIndex = 14
        Me.RadLabel2.Text = "Nama file"
        '
        'rFormImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 416)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadPageView1)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Controls.Add(Me.RadTextBox1)
        Me.Controls.Add(Me.btnSelectFile)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MinimizeBox = False
        Me.Name = "rFormImport"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import dari CSV"
        Me.ThemeName = "Office2010Black"
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSelectFile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rDropInvoiceType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.RadCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rOther, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rKoma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rSemicol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageView1.ResumeLayout(False)
        Me.RadPageViewPage1.ResumeLayout(False)
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLoad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageViewPage2.ResumeLayout(False)
        CType(Me.dgPreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnSelectFile As Telerik.WinControls.UI.RadButton
    Friend WithEvents rDropInvoiceType As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents rOther As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rKoma As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadTextBox2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents rSemicol As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadPageView1 As Telerik.WinControls.UI.RadPageView
    Friend WithEvents RadPageViewPage1 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadPageViewPage2 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadCheckBox1 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnLoad As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton3 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadTextBox3 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents dgPreview As System.Windows.Forms.DataGridView
End Class
