<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rFormAddWorkorderRecord
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
        Me.btnSave = New Telerik.WinControls.UI.RadButton()
        Me.rTxID = New Telerik.WinControls.UI.RadTextBox()
        Me.rWONum = New Telerik.WinControls.UI.RadTextBox()
        Me.rTxMaskDate = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.rCbClient = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rTxID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rWONum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rTxMaskDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rCbClient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSave.Location = New System.Drawing.Point(3, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(198, 27)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Simpan"
        Me.btnSave.ThemeName = "Office2010Black"
        CType(Me.btnSave.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.btnSave.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        '
        'rTxID
        '
        Me.rTxID.BackColor = System.Drawing.Color.Transparent
        Me.rTxID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rTxID.Location = New System.Drawing.Point(115, 6)
        Me.rTxID.Name = "rTxID"
        Me.rTxID.NullText = "No."
        Me.rTxID.Padding = New System.Windows.Forms.Padding(8, 3, 0, 2)
        Me.rTxID.ReadOnly = True
        Me.rTxID.Size = New System.Drawing.Size(130, 23)
        Me.rTxID.TabIndex = 1
        Me.rTxID.ThemeName = "Office2010Black"
        CType(Me.rTxID.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "No."
        CType(Me.rTxID.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.rTxID.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.rTxID.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.rTxID.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'rWONum
        '
        Me.rWONum.BackColor = System.Drawing.Color.Transparent
        Me.rWONum.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rWONum.Location = New System.Drawing.Point(6, 103)
        Me.rWONum.Name = "rWONum"
        Me.rWONum.NullText = "No. Workorder/SPK/SalesOrder"
        Me.rWONum.Padding = New System.Windows.Forms.Padding(8, 3, 0, 2)
        Me.rWONum.Size = New System.Drawing.Size(262, 23)
        Me.rWONum.TabIndex = 5
        Me.rWONum.ThemeName = "Office2010Black"
        CType(Me.rWONum.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "No. Workorder/SPK/SalesOrder"
        CType(Me.rWONum.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.rWONum.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.rWONum.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.rWONum.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'rTxMaskDate
        '
        Me.rTxMaskDate.AcceptsReturn = True
        Me.rTxMaskDate.AutoSize = False
        Me.rTxMaskDate.BackColor = System.Drawing.Color.Transparent
        Me.rTxMaskDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rTxMaskDate.Location = New System.Drawing.Point(287, 103)
        Me.rTxMaskDate.Mask = "00/00/0000"
        Me.rTxMaskDate.MaskType = Telerik.WinControls.UI.MaskType.Standard
        Me.rTxMaskDate.Name = "rTxMaskDate"
        Me.rTxMaskDate.NullText = "_"
        Me.rTxMaskDate.Size = New System.Drawing.Size(121, 23)
        Me.rTxMaskDate.TabIndex = 7
        Me.rTxMaskDate.TabStop = False
        Me.rTxMaskDate.Text = "__/__/____"
        Me.rTxMaskDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.rTxMaskDate.ThemeName = "Office2010Black"
        CType(Me.rTxMaskDate.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = "__/__/____"
        CType(Me.rTxMaskDate.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).Padding = New System.Windows.Forms.Padding(2, 2, 2, 3)
        CType(Me.rTxMaskDate.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "_"
        CType(Me.rTxMaskDate.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.rTxMaskDate.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.rTxMaskDate.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'rCbClient
        '
        Me.rCbClient.AutoSize = False
        Me.rCbClient.BackColor = System.Drawing.Color.Transparent
        Me.rCbClient.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rCbClient.Location = New System.Drawing.Point(6, 55)
        Me.rCbClient.Name = "rCbClient"
        Me.rCbClient.NullText = "Pilih Costumer"
        Me.rCbClient.Size = New System.Drawing.Size(262, 23)
        Me.rCbClient.TabIndex = 3
        Me.rCbClient.ThemeName = "Office2010Black"
        CType(Me.rCbClient.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.SystemColors.Control
        CType(Me.rCbClient.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).NumberOfColors = 2
        CType(Me.rCbClient.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.rCbClient.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadLabel1.Location = New System.Drawing.Point(6, 7)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(103, 19)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "No. Rekam (Auto)"
        '
        'RadLabel2
        '
        Me.RadLabel2.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadLabel2.Location = New System.Drawing.Point(6, 84)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(134, 19)
        Me.RadLabel2.TabIndex = 4
        Me.RadLabel2.Text = "Workorder/SPK/SO No."
        '
        'RadLabel3
        '
        Me.RadLabel3.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadLabel3.Location = New System.Drawing.Point(6, 36)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(95, 19)
        Me.RadLabel3.TabIndex = 2
        Me.RadLabel3.Text = "Nama Customer"
        '
        'RadLabel4
        '
        Me.RadLabel4.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadLabel4.Location = New System.Drawing.Point(287, 84)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(121, 19)
        Me.RadLabel4.TabIndex = 6
        Me.RadLabel4.Text = "Tanggal WO/SPK/SO"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnSave, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RadButton1, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 142)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(408, 33)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'RadButton1
        '
        Me.RadButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadButton1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadButton1.Location = New System.Drawing.Point(207, 3)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(198, 27)
        Me.RadButton1.TabIndex = 1
        Me.RadButton1.Text = "&Batal"
        Me.RadButton1.ThemeName = "Office2010Black"
        CType(Me.RadButton1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.RadButton1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        '
        'rFormAddWorkorderRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(412, 177)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.rCbClient)
        Me.Controls.Add(Me.rTxMaskDate)
        Me.Controls.Add(Me.rWONum)
        Me.Controls.Add(Me.rTxID)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "rFormAddWorkorderRecord"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Data Workorder/SPK/Salesorder"
        Me.ThemeName = "Office2010Black"
        CType(Me.btnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rTxID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rWONum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rTxMaskDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rCbClient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents rTxID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents rWONum As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents rTxMaskDate As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents rCbClient As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
End Class
