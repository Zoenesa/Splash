
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArrangeColumns
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
        Me.HideList = New Telerik.WinControls.UI.RadListControl()
        Me.btnRem = New Telerik.WinControls.UI.RadButton()
        Me.CurrentList = New Telerik.WinControls.UI.RadListControl()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.btnAppend = New Telerik.WinControls.UI.RadButton()
        Me.btnApply = New Telerik.WinControls.UI.RadButton()
        Me.btnRemAll = New Telerik.WinControls.UI.RadButton()
        Me.btnAppAll = New Telerik.WinControls.UI.RadButton()
        Me.btnClose = New Telerik.WinControls.UI.RadButton()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Col1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Col2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.HideList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrentList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAppend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnApply, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRemAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAppAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HideList
        '
        Me.HideList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.HideList.CaseSensitiveSort = False
        Me.HideList.EnableGestures = False
        Me.HideList.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.HideList.Location = New System.Drawing.Point(12, 30)
        Me.HideList.Name = "HideList"
        Me.HideList.Size = New System.Drawing.Size(129, 264)
        Me.HideList.TabIndex = 0
        Me.HideList.Text = "RadListControl1"
        Me.HideList.ThemeName = "Office2010Black"
        '
        'btnRem
        '
        Me.btnRem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRem.Location = New System.Drawing.Point(147, 122)
        Me.btnRem.Name = "btnRem"
        Me.btnRem.Size = New System.Drawing.Size(96, 34)
        Me.btnRem.TabIndex = 0
        Me.btnRem.Text = "< &Remove"
        Me.btnRem.ThemeName = "Office2010Black"
        '
        'CurrentList
        '
        Me.CurrentList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CurrentList.CaseSensitiveSort = False
        Me.CurrentList.EnableGestures = False
        Me.CurrentList.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CurrentList.Location = New System.Drawing.Point(249, 30)
        Me.CurrentList.Name = "CurrentList"
        Me.CurrentList.Size = New System.Drawing.Size(129, 264)
        Me.CurrentList.TabIndex = 0
        Me.CurrentList.Text = "RadListControl1"
        Me.CurrentList.ThemeName = "Office2010Black"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadLabel1.Location = New System.Drawing.Point(12, 9)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(105, 19)
        Me.RadLabel1.TabIndex = 1
        Me.RadLabel1.Text = "List Columns Hide"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadLabel2.Location = New System.Drawing.Point(249, 9)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(99, 19)
        Me.RadLabel2.TabIndex = 1
        Me.RadLabel2.Text = "Current Columns"
        '
        'btnAppend
        '
        Me.btnAppend.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAppend.Location = New System.Drawing.Point(147, 163)
        Me.btnAppend.Name = "btnAppend"
        Me.btnAppend.Size = New System.Drawing.Size(96, 34)
        Me.btnAppend.TabIndex = 0
        Me.btnAppend.Text = "A&ppend >"
        Me.btnAppend.ThemeName = "Office2010Black"
        '
        'btnApply
        '
        Me.btnApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnApply.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnApply.Location = New System.Drawing.Point(12, 300)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(74, 34)
        Me.btnApply.TabIndex = 0
        Me.btnApply.Text = "&Apply"
        Me.btnApply.ThemeName = "Office2010Black"
        '
        'btnRemAll
        '
        Me.btnRemAll.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRemAll.Location = New System.Drawing.Point(147, 82)
        Me.btnRemAll.Name = "btnRemAll"
        Me.btnRemAll.Size = New System.Drawing.Size(96, 34)
        Me.btnRemAll.TabIndex = 0
        Me.btnRemAll.Text = "<< Re&move All"
        Me.btnRemAll.ThemeName = "Office2010Black"
        '
        'btnAppAll
        '
        Me.btnAppAll.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAppAll.Location = New System.Drawing.Point(147, 203)
        Me.btnAppAll.Name = "btnAppAll"
        Me.btnAppAll.Size = New System.Drawing.Size(96, 34)
        Me.btnAppAll.TabIndex = 0
        Me.btnAppAll.Text = "Appe&nd All >>"
        Me.btnAppAll.ThemeName = "Office2010Black"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.Location = New System.Drawing.Point(626, 300)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(74, 34)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "&Close"
        Me.btnClose.ThemeName = "Office2010Black"
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.AllowUserToResizeRows = False
        Me.dg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg.ColumnHeadersHeight = 30
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col1, Me.Col2, Me.Col3, Me.Col4, Me.Col5, Me.Col6, Me.Col7, Me.Col8, Me.Col9, Me.Col10, Me.Col11, Me.Col12, Me.Col13, Me.Col14, Me.Col15, Me.Col16, Me.Col17, Me.Col18, Me.Col19, Me.Col20})
        Me.dg.Location = New System.Drawing.Point(384, 30)
        Me.dg.MultiSelect = False
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.RowHeadersVisible = False
        Me.dg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(316, 225)
        Me.dg.TabIndex = 14
        '
        'Col1
        '
        Me.Col1.HeaderText = "Select"
        Me.Col1.Name = "Col1"
        Me.Col1.ReadOnly = True
        Me.Col1.Width = 50
        '
        'Col2
        '
        Me.Col2.HeaderText = "Record No."
        Me.Col2.Name = "Col2"
        Me.Col2.ReadOnly = True
        Me.Col2.Width = 101
        '
        'Col3
        '
        Me.Col3.HeaderText = "Invoice No."
        Me.Col3.Name = "Col3"
        Me.Col3.ReadOnly = True
        Me.Col3.Width = 102
        '
        'Col4
        '
        Me.Col4.HeaderText = "Date"
        Me.Col4.Name = "Col4"
        Me.Col4.ReadOnly = True
        Me.Col4.Width = 63
        '
        'Col5
        '
        Me.Col5.HeaderText = "Invoice Type"
        Me.Col5.Name = "Col5"
        Me.Col5.ReadOnly = True
        Me.Col5.Width = 110
        '
        'Col6
        '
        Me.Col6.HeaderText = "Client"
        Me.Col6.Name = "Col6"
        Me.Col6.ReadOnly = True
        Me.Col6.Width = 69
        '
        'Col7
        '
        Me.Col7.HeaderText = "Address"
        Me.Col7.Name = "Col7"
        Me.Col7.ReadOnly = True
        Me.Col7.Width = 83
        '
        'Col8
        '
        Me.Col8.HeaderText = "Work Order"
        Me.Col8.Name = "Col8"
        Me.Col8.ReadOnly = True
        Me.Col8.Width = 107
        '
        'Col9
        '
        Me.Col9.HeaderText = "Work Order Date"
        Me.Col9.Name = "Col9"
        Me.Col9.ReadOnly = True
        Me.Col9.Width = 140
        '
        'Col10
        '
        Me.Col10.HeaderText = "Work Agreement"
        Me.Col10.Name = "Col10"
        Me.Col10.ReadOnly = True
        Me.Col10.Width = 139
        '
        'Col11
        '
        Me.Col11.HeaderText = "Progress"
        Me.Col11.Name = "Col11"
        Me.Col11.ReadOnly = True
        Me.Col11.Width = 87
        '
        'Col12
        '
        Me.Col12.HeaderText = "Termyn"
        Me.Col12.Name = "Col12"
        Me.Col12.ReadOnly = True
        Me.Col12.Width = 80
        '
        'Col13
        '
        Me.Col13.HeaderText = "Items Record"
        Me.Col13.Name = "Col13"
        Me.Col13.ReadOnly = True
        Me.Col13.Width = 114
        '
        'Col14
        '
        Me.Col14.HeaderText = "Total Items Price"
        Me.Col14.Name = "Col14"
        Me.Col14.ReadOnly = True
        Me.Col14.Width = 135
        '
        'Col15
        '
        Me.Col15.HeaderText = "Payments Record"
        Me.Col15.Name = "Col15"
        Me.Col15.ReadOnly = True
        Me.Col15.Width = 140
        '
        'Col16
        '
        Me.Col16.HeaderText = "Tax"
        Me.Col16.Name = "Col16"
        Me.Col16.ReadOnly = True
        Me.Col16.Width = 54
        '
        'Col17
        '
        Me.Col17.HeaderText = "User Input"
        Me.Col17.Name = "Col17"
        Me.Col17.ReadOnly = True
        Me.Col17.Width = 99
        '
        'Col18
        '
        Me.Col18.HeaderText = "Date Input"
        Me.Col18.Name = "Col18"
        Me.Col18.ReadOnly = True
        '
        'Col19
        '
        Me.Col19.HeaderText = "User Edit"
        Me.Col19.Name = "Col19"
        Me.Col19.ReadOnly = True
        Me.Col19.Width = 89
        '
        'Col20
        '
        Me.Col20.HeaderText = "Date Update"
        Me.Col20.Name = "Col20"
        Me.Col20.ReadOnly = True
        Me.Col20.Width = 112
        '
        'FrmArrangeColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 346)
        Me.ControlBox = False
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnAppAll)
        Me.Controls.Add(Me.btnAppend)
        Me.Controls.Add(Me.btnRemAll)
        Me.Controls.Add(Me.btnRem)
        Me.Controls.Add(Me.CurrentList)
        Me.Controls.Add(Me.HideList)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmArrangeColumns"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Arrange Columns"
        Me.ThemeName = "Office2010Black"
        CType(Me.HideList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrentList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAppend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnApply, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRemAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAppAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HideList As Telerik.WinControls.UI.RadListControl
    Friend WithEvents btnRem As Telerik.WinControls.UI.RadButton
    Friend WithEvents CurrentList As Telerik.WinControls.UI.RadListControl
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btnAppend As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnApply As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnRemAll As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnAppAll As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnClose As Telerik.WinControls.UI.RadButton
    Friend WithEvents Col1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Col2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dg As System.Windows.Forms.DataGridView
End Class
