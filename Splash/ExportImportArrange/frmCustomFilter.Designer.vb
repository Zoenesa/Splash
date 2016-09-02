<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomFilter
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
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem6 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem7 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem8 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.RadListControl1 = New Telerik.WinControls.UI.RadListControl()
        Me.RadDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txExpresion = New Telerik.WinControls.UI.RadTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnClose = New Telerik.WinControls.UI.RadButton()
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.RadListControl2 = New Telerik.WinControls.UI.RadListControl()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RadButton4 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton5 = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadListControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txExpresion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadListControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadListControl1
        '
        Me.RadListControl1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.SetColumnSpan(Me.RadListControl1, 3)
        Me.RadListControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadListControl1.Location = New System.Drawing.Point(3, 23)
        Me.RadListControl1.Name = "RadListControl1"
        Me.TableLayoutPanel1.SetRowSpan(Me.RadListControl1, 7)
        Me.RadListControl1.Size = New System.Drawing.Size(201, 218)
        Me.RadListControl1.TabIndex = 0
        Me.RadListControl1.Text = "RadListControl1"
        Me.RadListControl1.ThemeName = "Office2010Black"
        '
        'RadDropDownList1
        '
        Me.RadDropDownList1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.SetColumnSpan(Me.RadDropDownList1, 3)
        Me.RadDropDownList1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadDropDownList1.DefaultItemsCountInDropDown = 8
        Me.RadDropDownList1.Dock = System.Windows.Forms.DockStyle.Fill
        RadListDataItem1.Text = "="
        RadListDataItem2.Text = "<"
        RadListDataItem3.Text = "<="
        RadListDataItem4.Text = ">"
        RadListDataItem5.Text = ">="
        RadListDataItem6.Text = "<>"
        RadListDataItem7.Text = "Like"
        RadListDataItem8.Text = "Not Like"
        Me.RadDropDownList1.Items.Add(RadListDataItem1)
        Me.RadDropDownList1.Items.Add(RadListDataItem2)
        Me.RadDropDownList1.Items.Add(RadListDataItem3)
        Me.RadDropDownList1.Items.Add(RadListDataItem4)
        Me.RadDropDownList1.Items.Add(RadListDataItem5)
        Me.RadDropDownList1.Items.Add(RadListDataItem6)
        Me.RadDropDownList1.Items.Add(RadListDataItem7)
        Me.RadDropDownList1.Items.Add(RadListDataItem8)
        Me.RadDropDownList1.Location = New System.Drawing.Point(210, 23)
        Me.RadDropDownList1.Name = "RadDropDownList1"
        Me.RadDropDownList1.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.RadDropDownList1.ReadOnly = True
        Me.RadDropDownList1.Size = New System.Drawing.Size(203, 24)
        Me.RadDropDownList1.TabIndex = 1
        Me.RadDropDownList1.ThemeName = "Office2010Black"
        CType(Me.RadDropDownList1.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        CType(Me.RadDropDownList1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        CType(Me.RadDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadDropDownListArrowButtonElement).Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        CType(Me.RadDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadDropDownListArrowButtonElement).Margin = New System.Windows.Forms.Padding(0, -1, 0, -1)
        CType(Me.RadDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Padding = New System.Windows.Forms.Padding(0)
        CType(Me.RadDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Margin = New System.Windows.Forms.Padding(-1)
        CType(Me.RadDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Padding = New System.Windows.Forms.Padding(0)
        CType(Me.RadDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Margin = New System.Windows.Forms.Padding(-2)
        '
        'RadTextBox1
        '
        Me.RadTextBox1.AutoSize = False
        Me.RadTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.SetColumnSpan(Me.RadTextBox1, 3)
        Me.RadTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadTextBox1.Location = New System.Drawing.Point(210, 73)
        Me.RadTextBox1.Multiline = True
        Me.RadTextBox1.Name = "RadTextBox1"
        Me.RadTextBox1.Size = New System.Drawing.Size(203, 74)
        Me.RadTextBox1.TabIndex = 2
        Me.RadTextBox1.ThemeName = "Office2010Black"
        CType(Me.RadTextBox1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).StretchVertically = True
        CType(Me.RadTextBox1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.RadTextBox1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.RadTextBox1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label1, 3)
        Me.Label1.Location = New System.Drawing.Point(210, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Operator"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label2, 3)
        Me.Label2.Location = New System.Drawing.Point(210, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Description"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txExpresion
        '
        Me.txExpresion.AutoSize = False
        Me.txExpresion.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.SetColumnSpan(Me.txExpresion, 3)
        Me.txExpresion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txExpresion.Location = New System.Drawing.Point(210, 173)
        Me.txExpresion.Multiline = True
        Me.txExpresion.Name = "txExpresion"
        Me.TableLayoutPanel1.SetRowSpan(Me.txExpresion, 2)
        Me.txExpresion.Size = New System.Drawing.Size(203, 38)
        Me.txExpresion.TabIndex = 2
        Me.txExpresion.ThemeName = "Office2010Black"
        CType(Me.txExpresion.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).StretchVertically = True
        CType(Me.txExpresion.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.txExpresion.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.txExpresion.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label3, 3)
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(210, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(203, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Expressions"
        '
        'RadButton1
        '
        Me.RadButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadButton1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadButton1.Location = New System.Drawing.Point(348, 217)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(65, 24)
        Me.RadButton1.TabIndex = 4
        Me.RadButton1.Text = "&DEL"
        Me.RadButton1.ThemeName = "Office2010Black"
        CType(Me.RadButton1.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "&DEL"
        CType(Me.RadButton1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.RadButton1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fields"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnClose, 1, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSave, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.RadListControl2, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.RadListControl1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RadButton1, 5, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.RadButton4, 3, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.RadDropDownList1, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txExpresion, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RadTextBox1, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.RadButton5, 4, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 3, 4)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 12
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(416, 383)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.SetColumnSpan(Me.btnClose, 3)
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClose.Location = New System.Drawing.Point(210, 350)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(203, 30)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "&Keluar"
        Me.btnClose.ThemeName = "Office2010Black"
        CType(Me.btnClose.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "&Keluar"
        CType(Me.btnClose.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.btnClose.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.SetColumnSpan(Me.btnSave, 3)
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSave.Location = New System.Drawing.Point(3, 350)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(201, 30)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "&Simpan"
        Me.btnSave.ThemeName = "Office2010Black"
        CType(Me.btnSave.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "&Simpan"
        CType(Me.btnSave.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.btnSave.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'RadListControl2
        '
        Me.RadListControl2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.SetColumnSpan(Me.RadListControl2, 6)
        Me.RadListControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadListControl2.Location = New System.Drawing.Point(3, 267)
        Me.RadListControl2.Name = "RadListControl2"
        Me.TableLayoutPanel1.SetRowSpan(Me.RadListControl2, 2)
        Me.RadListControl2.Size = New System.Drawing.Size(410, 77)
        Me.RadListControl2.TabIndex = 5
        Me.RadListControl2.Text = "RadListControl1"
        Me.RadListControl2.ThemeName = "Office2010Black"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label5, 6)
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(3, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(410, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Query Expressions"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadButton4
        '
        Me.RadButton4.BackColor = System.Drawing.Color.Transparent
        Me.RadButton4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadButton4.Location = New System.Drawing.Point(210, 217)
        Me.RadButton4.Name = "RadButton4"
        Me.RadButton4.Size = New System.Drawing.Size(63, 24)
        Me.RadButton4.TabIndex = 4
        Me.RadButton4.Text = "&AND"
        Me.RadButton4.ThemeName = "Office2010Black"
        CType(Me.RadButton4.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "&AND"
        CType(Me.RadButton4.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.RadButton4.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'RadButton5
        '
        Me.RadButton5.BackColor = System.Drawing.Color.Transparent
        Me.RadButton5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadButton5.Location = New System.Drawing.Point(279, 217)
        Me.RadButton5.Name = "RadButton5"
        Me.RadButton5.Size = New System.Drawing.Size(63, 24)
        Me.RadButton5.TabIndex = 4
        Me.RadButton5.Text = "&OR"
        Me.RadButton5.ThemeName = "Office2010Black"
        CType(Me.RadButton5.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "&OR"
        CType(Me.RadButton5.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.RadButton5.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'FrmCustomFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCustomFilter"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.Text = "Query Expresion Builder"
        Me.ThemeName = "Office2010Black"
        CType(Me.RadListControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txExpresion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadListControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadListControl1 As Telerik.WinControls.UI.RadListControl
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnClose As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadListControl2 As Telerik.WinControls.UI.RadListControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RadButton4 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadDropDownList1 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents txExpresion As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadButton5 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class

