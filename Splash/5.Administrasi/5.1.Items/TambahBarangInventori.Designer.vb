<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahBarangInventori
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TambahBarangInventori))
        Me.RadButton8 = New Telerik.WinControls.UI.RadButton()
        Me.RadTextBox8 = New Telerik.WinControls.UI.RadTextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
        Me.comboSatuan = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadTextBox3 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadTextBox2 = New Telerik.WinControls.UI.RadTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.RadButton8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboSatuan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadButton8
        '
        Me.RadButton8.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.RadButton8, "RadButton8")
        Me.RadButton8.Name = "RadButton8"
        Me.RadButton8.ThemeName = "Office2010Black"
        '
        'RadTextBox8
        '
        resources.ApplyResources(Me.RadTextBox8, "RadTextBox8")
        Me.RadTextBox8.BackColor = System.Drawing.Color.Transparent
        Me.RadTextBox8.Name = "RadTextBox8"
        Me.RadTextBox8.ThemeName = "Office2010Black"
        CType(Me.RadTextBox8.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.Transparent
        CType(Me.RadTextBox8.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Nama Barang"
        CType(Me.RadTextBox8.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.RadTextBox8.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.RadTextBox8.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.RadTextBox8.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        CType(Me.RadTextBox8.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        '
        'TableLayoutPanel1
        '
        resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
        Me.TableLayoutPanel1.Controls.Add(Me.RadButton8, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RadButton1, 1, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        '
        'RadButton1
        '
        Me.RadButton1.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.RadButton1, "RadButton1")
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.ThemeName = "Office2010Black"
        '
        'RadTextBox1
        '
        resources.ApplyResources(Me.RadTextBox1, "RadTextBox1")
        Me.RadTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.RadTextBox1.MaxLength = 23
        Me.RadTextBox1.Name = "RadTextBox1"
        Me.RadTextBox1.ThemeName = "Office2010Black"
        CType(Me.RadTextBox1.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.Transparent
        CType(Me.RadTextBox1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Harga Satuan"
        CType(Me.RadTextBox1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.RadTextBox1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.RadTextBox1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.RadTextBox1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        CType(Me.RadTextBox1.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        '
        'comboSatuan
        '
        Me.comboSatuan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        resources.ApplyResources(Me.comboSatuan, "comboSatuan")
        Me.comboSatuan.BackColor = System.Drawing.Color.Transparent
        Me.comboSatuan.DropDownAnimationFrames = 8
        Me.comboSatuan.DropDownHeight = 100
        Me.comboSatuan.DropDownMinSize = New System.Drawing.Size(165, 0)
        Me.comboSatuan.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
        Me.comboSatuan.EnableAlternatingItemColor = True
        Me.comboSatuan.EnableKineticScrolling = True
        Me.comboSatuan.MaxDropDownItems = 8
        Me.comboSatuan.Name = "comboSatuan"
        Me.comboSatuan.ThemeName = "Office2010Black"
        CType(Me.comboSatuan.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.SystemColors.Control
        CType(Me.comboSatuan.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).NumberOfColors = 2
        CType(Me.comboSatuan.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.comboSatuan.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'RadTextBox3
        '
        resources.ApplyResources(Me.RadTextBox3, "RadTextBox3")
        Me.RadTextBox3.BackColor = System.Drawing.Color.Transparent
        Me.RadTextBox3.Name = "RadTextBox3"
        Me.RadTextBox3.ThemeName = "Office2010Black"
        CType(Me.RadTextBox3.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.Transparent
        CType(Me.RadTextBox3.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Satuan Qty"
        CType(Me.RadTextBox3.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.RadTextBox3.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.RadTextBox3.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.RadTextBox3.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        CType(Me.RadTextBox3.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        '
        'RadCheckBox1
        '
        resources.ApplyResources(Me.RadCheckBox1, "RadCheckBox1")
        Me.RadCheckBox1.Name = "RadCheckBox1"
        '
        'RadTextBox2
        '
        resources.ApplyResources(Me.RadTextBox2, "RadTextBox2")
        Me.RadTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.RadTextBox2.Name = "RadTextBox2"
        Me.RadTextBox2.ThemeName = "Office2010Black"
        CType(Me.RadTextBox2.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.Transparent
        CType(Me.RadTextBox2.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Kode Barang"
        CType(Me.RadTextBox2.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.RadTextBox2.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.RadTextBox2.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.RadTextBox2.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        CType(Me.RadTextBox2.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'TambahBarangInventori
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RadCheckBox1)
        Me.Controls.Add(Me.comboSatuan)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.RadTextBox3)
        Me.Controls.Add(Me.RadTextBox1)
        Me.Controls.Add(Me.RadTextBox2)
        Me.Controls.Add(Me.RadTextBox8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TambahBarangInventori"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ThemeName = "Office2010Black"
        CType(Me.RadButton8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboSatuan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadButton8 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadTextBox8 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents comboSatuan As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadTextBox3 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadCheckBox1 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadTextBox2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
