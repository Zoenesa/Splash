﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPilihBarang
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgItem = New System.Windows.Forms.DataGridView()
        Me.RadLabel19 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBox8 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadButton8 = New Telerik.WinControls.UI.RadButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton4 = New Telerik.WinControls.UI.RadButton()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgItem, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.RadLabel19, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RadTextBox8, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RadButton8, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(520, 226)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'dgItem
        '
        Me.dgItem.AllowUserToAddRows = False
        Me.dgItem.AllowUserToDeleteRows = False
        Me.dgItem.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgItem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.dgItem, 5)
        Me.dgItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgItem.Location = New System.Drawing.Point(3, 31)
        Me.dgItem.MultiSelect = False
        Me.dgItem.Name = "dgItem"
        Me.dgItem.ReadOnly = True
        Me.dgItem.RowHeadersVisible = False
        Me.TableLayoutPanel1.SetRowSpan(Me.dgItem, 2)
        Me.dgItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgItem.Size = New System.Drawing.Size(514, 160)
        Me.dgItem.TabIndex = 10
        '
        'RadLabel19
        '
        Me.RadLabel19.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel19.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadLabel19.ForeColor = System.Drawing.Color.Black
        Me.RadLabel19.Location = New System.Drawing.Point(3, 3)
        Me.RadLabel19.Name = "RadLabel19"
        Me.RadLabel19.Size = New System.Drawing.Size(33, 19)
        Me.RadLabel19.TabIndex = 7
        Me.RadLabel19.Text = "Filter"
        Me.RadLabel19.ThemeName = "Office2010Black"
        '
        'RadTextBox8
        '
        Me.RadTextBox8.AutoSize = False
        Me.RadTextBox8.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.SetColumnSpan(Me.RadTextBox8, 3)
        Me.RadTextBox8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadTextBox8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadTextBox8.Location = New System.Drawing.Point(68, 3)
        Me.RadTextBox8.Name = "RadTextBox8"
        Me.RadTextBox8.NullText = "Nama Barang"
        Me.RadTextBox8.Size = New System.Drawing.Size(351, 22)
        Me.RadTextBox8.TabIndex = 8
        Me.RadTextBox8.ThemeName = "Office2010Black"
        CType(Me.RadTextBox8.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.Transparent
        CType(Me.RadTextBox8.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Nama Barang"
        CType(Me.RadTextBox8.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.SystemColors.Control
        CType(Me.RadTextBox8.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CType(Me.RadTextBox8.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.RadTextBox8.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.SystemColors.Control
        CType(Me.RadTextBox8.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        '
        'RadButton8
        '
        Me.RadButton8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadButton8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadButton8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadButton8.Location = New System.Drawing.Point(425, 3)
        Me.RadButton8.Name = "RadButton8"
        Me.RadButton8.Size = New System.Drawing.Size(92, 22)
        Me.RadButton8.TabIndex = 9
        Me.RadButton8.Text = "[F3] Cari"
        Me.RadButton8.ThemeName = "Office2010Black"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 5)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.RadButton1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RadButton4, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 194)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(520, 32)
        Me.TableLayoutPanel2.TabIndex = 11
        '
        'RadButton1
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.RadButton1, 2)
        Me.RadButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadButton1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadButton1.Location = New System.Drawing.Point(3, 3)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(254, 26)
        Me.RadButton1.TabIndex = 9
        Me.RadButton1.Text = "&Pilih"
        Me.RadButton1.ThemeName = "Office2010Black"
        '
        'RadButton4
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.RadButton4, 2)
        Me.RadButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadButton4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadButton4.Location = New System.Drawing.Point(263, 3)
        Me.RadButton4.Name = "RadButton4"
        Me.RadButton4.Size = New System.Drawing.Size(254, 26)
        Me.RadButton4.TabIndex = 9
        Me.RadButton4.Text = "&Keluar"
        Me.RadButton4.ThemeName = "Office2010Black"
        '
        'FormPilihBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 226)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "FormPilihBarang"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pilih Barang"
        Me.ThemeName = "Office2010Black"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dgItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dgItem As DataGridView
    Friend WithEvents RadLabel19 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox8 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadButton8 As Telerik.WinControls.UI.RadButton
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton4 As Telerik.WinControls.UI.RadButton
End Class
