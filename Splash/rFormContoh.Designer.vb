<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RFormContoh
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txInvoiceNum = New Telerik.WinControls.UI.RadTextBox()
        Me.btTest = New Telerik.WinControls.UI.RadButton()
        Me.RadTextBox2 = New Telerik.WinControls.UI.RadTextBox()
        Me.rDropInvoiceType = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadTextBox5 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox3 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox4 = New Telerik.WinControls.UI.RadTextBox()
        Me.Propinsi = New Telerik.WinControls.UI.RadDropDownList()
        Me.Kabupaten = New Telerik.WinControls.UI.RadDropDownList()
        Me.Kecamatan = New Telerik.WinControls.UI.RadDropDownList()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txInvoiceNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btTest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rDropInvoiceType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Propinsi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Kabupaten, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Kecamatan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.DataGridView1.Location = New System.Drawing.Point(49, 32)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 66)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'txInvoiceNum
        '
        Me.txInvoiceNum.AutoSize = False
        Me.txInvoiceNum.BackColor = System.Drawing.Color.Transparent
        Me.txInvoiceNum.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txInvoiceNum.Location = New System.Drawing.Point(49, 117)
        Me.txInvoiceNum.Name = "txInvoiceNum"
        Me.txInvoiceNum.NullText = "Contoh Format"
        Me.txInvoiceNum.Size = New System.Drawing.Size(172, 23)
        Me.txInvoiceNum.TabIndex = 7
        Me.txInvoiceNum.ThemeName = "Office2010Black"
        '
        'btTest
        '
        Me.btTest.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btTest.BackColor = System.Drawing.Color.Transparent
        Me.btTest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btTest.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btTest.Location = New System.Drawing.Point(646, 185)
        Me.btTest.Name = "btTest"
        Me.btTest.Size = New System.Drawing.Size(79, 27)
        Me.btTest.TabIndex = 8
        Me.btTest.Text = "Test"
        Me.btTest.ThemeName = "Office2010Black"
        '
        'RadTextBox2
        '
        Me.RadTextBox2.AutoSize = False
        Me.RadTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.RadTextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadTextBox2.Location = New System.Drawing.Point(49, 164)
        Me.RadTextBox2.Name = "RadTextBox2"
        Me.RadTextBox2.NullText = "Jalan Kota Propinsi KodePos "
        Me.RadTextBox2.Size = New System.Drawing.Size(348, 23)
        Me.RadTextBox2.TabIndex = 7
        Me.RadTextBox2.ThemeName = "Office2010Black"
        '
        'rDropInvoiceType
        '
        Me.rDropInvoiceType.AutoSize = False
        Me.rDropInvoiceType.BackColor = System.Drawing.Color.Transparent
        Me.rDropInvoiceType.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RadListDataItem1.Text = "/"
        RadListDataItem2.Text = "_None_"
        Me.rDropInvoiceType.Items.Add(RadListDataItem1)
        Me.rDropInvoiceType.Items.Add(RadListDataItem2)
        Me.rDropInvoiceType.Location = New System.Drawing.Point(241, 117)
        Me.rDropInvoiceType.Name = "rDropInvoiceType"
        Me.rDropInvoiceType.NullText = "Delimiter"
        Me.rDropInvoiceType.Size = New System.Drawing.Size(172, 23)
        Me.rDropInvoiceType.TabIndex = 9
        Me.rDropInvoiceType.ThemeName = "Office2010Black"
        '
        'RadTextBox5
        '
        Me.RadTextBox5.AutoSize = False
        Me.RadTextBox5.BackColor = System.Drawing.Color.Transparent
        Me.RadTextBox5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadTextBox5.Location = New System.Drawing.Point(199, 222)
        Me.RadTextBox5.Multiline = True
        Me.RadTextBox5.Name = "RadTextBox5"
        Me.RadTextBox5.NullText = "Jalan Kota Propinsi KodePos "
        Me.RadTextBox5.Size = New System.Drawing.Size(348, 77)
        Me.RadTextBox5.TabIndex = 7
        Me.RadTextBox5.ThemeName = "Office2010Black"
        '
        'RadTextBox3
        '
        Me.RadTextBox3.AutoSize = False
        Me.RadTextBox3.BackColor = System.Drawing.Color.Transparent
        Me.RadTextBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadTextBox3.Location = New System.Drawing.Point(49, 193)
        Me.RadTextBox3.Name = "RadTextBox3"
        Me.RadTextBox3.NullText = "Jalan Kota Propinsi KodePos "
        Me.RadTextBox3.Size = New System.Drawing.Size(144, 23)
        Me.RadTextBox3.TabIndex = 7
        Me.RadTextBox3.ThemeName = "Office2010Black"
        '
        'RadTextBox1
        '
        Me.RadTextBox1.AutoSize = False
        Me.RadTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.RadTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadTextBox1.Location = New System.Drawing.Point(199, 193)
        Me.RadTextBox1.Name = "RadTextBox1"
        Me.RadTextBox1.NullText = "Jalan Kota Propinsi KodePos "
        Me.RadTextBox1.Size = New System.Drawing.Size(144, 23)
        Me.RadTextBox1.TabIndex = 7
        Me.RadTextBox1.ThemeName = "Office2010Black"
        '
        'RadTextBox4
        '
        Me.RadTextBox4.AutoSize = False
        Me.RadTextBox4.BackColor = System.Drawing.Color.Transparent
        Me.RadTextBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadTextBox4.Location = New System.Drawing.Point(49, 222)
        Me.RadTextBox4.Name = "RadTextBox4"
        Me.RadTextBox4.NullText = "Jalan Kota Propinsi KodePos "
        Me.RadTextBox4.Size = New System.Drawing.Size(144, 23)
        Me.RadTextBox4.TabIndex = 7
        Me.RadTextBox4.ThemeName = "Office2010Black"
        '
        'Propinsi
        '
        Me.Propinsi.AutoSize = False
        Me.Propinsi.BackColor = System.Drawing.Color.Transparent
        Me.Propinsi.DisplayMember = "name"
        Me.Propinsi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Propinsi.Location = New System.Drawing.Point(392, 56)
        Me.Propinsi.Name = "Propinsi"
        Me.Propinsi.NullText = "Propinsi"
        Me.Propinsi.Size = New System.Drawing.Size(167, 23)
        Me.Propinsi.TabIndex = 9
        Me.Propinsi.ThemeName = "Office2010Black"
        Me.Propinsi.ValueMember = "id"
        '
        'Kabupaten
        '
        Me.Kabupaten.AutoSize = False
        Me.Kabupaten.BackColor = System.Drawing.Color.Transparent
        Me.Kabupaten.DisplayMember = "name"
        Me.Kabupaten.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kabupaten.Location = New System.Drawing.Point(579, 56)
        Me.Kabupaten.Name = "Kabupaten"
        Me.Kabupaten.NullText = "Kabupaten"
        Me.Kabupaten.Size = New System.Drawing.Size(196, 23)
        Me.Kabupaten.TabIndex = 9
        Me.Kabupaten.ThemeName = "Office2010Black"
        Me.Kabupaten.ValueMember = "id"
        '
        'Kecamatan
        '
        Me.Kecamatan.AutoSize = False
        Me.Kecamatan.BackColor = System.Drawing.Color.Transparent
        Me.Kecamatan.DisplayMember = "name"
        Me.Kecamatan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kecamatan.Location = New System.Drawing.Point(579, 102)
        Me.Kecamatan.Name = "Kecamatan"
        Me.Kecamatan.NullText = "Kecamatan"
        Me.Kecamatan.Size = New System.Drawing.Size(196, 23)
        Me.Kecamatan.TabIndex = 9
        Me.Kecamatan.ThemeName = "Office2010Black"
        Me.Kecamatan.ValueMember = "id"
        '
        'RFormContoh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 338)
        Me.Controls.Add(Me.Kecamatan)
        Me.Controls.Add(Me.Kabupaten)
        Me.Controls.Add(Me.Propinsi)
        Me.Controls.Add(Me.rDropInvoiceType)
        Me.Controls.Add(Me.btTest)
        Me.Controls.Add(Me.RadTextBox4)
        Me.Controls.Add(Me.RadTextBox1)
        Me.Controls.Add(Me.RadTextBox3)
        Me.Controls.Add(Me.RadTextBox5)
        Me.Controls.Add(Me.RadTextBox2)
        Me.Controls.Add(Me.txInvoiceNum)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "RFormContoh"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "RFormContoh"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txInvoiceNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btTest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rDropInvoiceType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Propinsi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Kabupaten, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Kecamatan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txInvoiceNum As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btTest As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadTextBox2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents rDropInvoiceType As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadTextBox5 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox3 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBox4 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Propinsi As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Kabupaten As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Kecamatan As Telerik.WinControls.UI.RadDropDownList
End Class

