<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RadFormExportProgress
    Inherits System.Windows.Forms.Form

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
        Me.lbTotalRows_Tables = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.nmExInterval = New System.Windows.Forms.NumericUpDown()
        Me.label5 = New System.Windows.Forms.Label()
        Me.lbRowInAllTable = New System.Windows.Forms.Label()
        Me.lbRowInCurTable = New System.Windows.Forms.Label()
        Me.lbTableCount = New System.Windows.Forms.Label()
        Me.pbRowInAllTable = New System.Windows.Forms.ProgressBar()
        Me.label3 = New System.Windows.Forms.Label()
        Me.pbRowInCurTable = New System.Windows.Forms.ProgressBar()
        Me.label2 = New System.Windows.Forms.Label()
        Me.pbTable = New System.Windows.Forms.ProgressBar()
        Me.lbCurrentTableName = New System.Windows.Forms.Label()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.btExport = New System.Windows.Forms.Button()
        CType(Me.nmExInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbTotalRows_Tables
        '
        Me.lbTotalRows_Tables.AutoSize = True
        Me.lbTotalRows_Tables.Location = New System.Drawing.Point(95, 102)
        Me.lbTotalRows_Tables.Name = "lbTotalRows_Tables"
        Me.lbTotalRows_Tables.Size = New System.Drawing.Size(0, 13)
        Me.lbTotalRows_Tables.TabIndex = 38
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(9, 102)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(69, 26)
        Me.label4.TabIndex = 37
        Me.label4.Text = "Total Tables:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Total Rows:"
        '
        'nmExInterval
        '
        Me.nmExInterval.Location = New System.Drawing.Point(242, 68)
        Me.nmExInterval.Name = "nmExInterval"
        Me.nmExInterval.Size = New System.Drawing.Size(76, 20)
        Me.nmExInterval.TabIndex = 36
        Me.nmExInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nmExInterval.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(9, 70)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(185, 13)
        Me.label5.TabIndex = 35
        Me.label5.Text = "Progress Report Interval (Miliseconds)"
        '
        'lbRowInAllTable
        '
        Me.lbRowInAllTable.AutoSize = True
        Me.lbRowInAllTable.Location = New System.Drawing.Point(9, 346)
        Me.lbRowInAllTable.Name = "lbRowInAllTable"
        Me.lbRowInAllTable.Size = New System.Drawing.Size(30, 13)
        Me.lbRowInAllTable.TabIndex = 34
        Me.lbRowInAllTable.Text = "1 / 1"
        '
        'lbRowInCurTable
        '
        Me.lbRowInCurTable.AutoSize = True
        Me.lbRowInCurTable.Location = New System.Drawing.Point(9, 270)
        Me.lbRowInCurTable.Name = "lbRowInCurTable"
        Me.lbRowInCurTable.Size = New System.Drawing.Size(30, 13)
        Me.lbRowInCurTable.TabIndex = 33
        Me.lbRowInCurTable.Text = "1 / 1"
        '
        'lbTableCount
        '
        Me.lbTableCount.AutoSize = True
        Me.lbTableCount.Location = New System.Drawing.Point(9, 196)
        Me.lbTableCount.Name = "lbTableCount"
        Me.lbTableCount.Size = New System.Drawing.Size(30, 13)
        Me.lbTableCount.TabIndex = 32
        Me.lbTableCount.Text = "1 / 1"
        '
        'pbRowInAllTable
        '
        Me.pbRowInAllTable.Location = New System.Drawing.Point(12, 320)
        Me.pbRowInAllTable.Name = "pbRowInAllTable"
        Me.pbRowInAllTable.Size = New System.Drawing.Size(306, 23)
        Me.pbRowInAllTable.TabIndex = 31
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(9, 301)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(94, 13)
        Me.label3.TabIndex = 30
        Me.label3.Text = "Rows in All Tables"
        '
        'pbRowInCurTable
        '
        Me.pbRowInCurTable.Location = New System.Drawing.Point(12, 244)
        Me.pbRowInCurTable.Name = "pbRowInCurTable"
        Me.pbRowInCurTable.Size = New System.Drawing.Size(306, 23)
        Me.pbRowInCurTable.TabIndex = 29
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(9, 225)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(112, 13)
        Me.label2.TabIndex = 28
        Me.label2.Text = "Rows in Current Table"
        '
        'pbTable
        '
        Me.pbTable.Location = New System.Drawing.Point(12, 170)
        Me.pbTable.Name = "pbTable"
        Me.pbTable.Size = New System.Drawing.Size(306, 23)
        Me.pbTable.TabIndex = 27
        '
        'lbCurrentTableName
        '
        Me.lbCurrentTableName.AutoSize = True
        Me.lbCurrentTableName.Location = New System.Drawing.Point(9, 151)
        Me.lbCurrentTableName.Name = "lbCurrentTableName"
        Me.lbCurrentTableName.Size = New System.Drawing.Size(34, 13)
        Me.lbCurrentTableName.TabIndex = 26
        Me.lbCurrentTableName.Text = "Table"
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(151, 13)
        Me.btCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(118, 33)
        Me.btCancel.TabIndex = 25
        Me.btCancel.Text = "Cancel Export"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'btExport
        '
        Me.btExport.Location = New System.Drawing.Point(12, 13)
        Me.btExport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btExport.Name = "btExport"
        Me.btExport.Size = New System.Drawing.Size(118, 33)
        Me.btExport.TabIndex = 24
        Me.btExport.Text = "Start Export"
        Me.btExport.UseVisualStyleBackColor = True
        '
        'RadFormExportProgress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 393)
        Me.Controls.Add(Me.lbTotalRows_Tables)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.nmExInterval)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.lbRowInAllTable)
        Me.Controls.Add(Me.lbRowInCurTable)
        Me.Controls.Add(Me.lbTableCount)
        Me.Controls.Add(Me.pbRowInAllTable)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.pbRowInCurTable)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.pbTable)
        Me.Controls.Add(Me.lbCurrentTableName)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btExport)
        Me.Name = "RadFormExportProgress"
        Me.Text = "RadFormExportProgress"
        CType(Me.nmExInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lbTotalRows_Tables As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents nmExInterval As System.Windows.Forms.NumericUpDown
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents lbRowInAllTable As System.Windows.Forms.Label
    Private WithEvents lbRowInCurTable As System.Windows.Forms.Label
    Private WithEvents lbTableCount As System.Windows.Forms.Label
    Private WithEvents pbRowInAllTable As System.Windows.Forms.ProgressBar
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents pbRowInCurTable As System.Windows.Forms.ProgressBar
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents pbTable As System.Windows.Forms.ProgressBar
    Private WithEvents lbCurrentTableName As System.Windows.Forms.Label
    Private WithEvents btCancel As System.Windows.Forms.Button
    Private WithEvents btExport As System.Windows.Forms.Button
End Class
