<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InisialisasiPasswordMeter
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lbText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbText
        '
        Me.lbText.BackColor = System.Drawing.Color.Transparent
        Me.lbText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbText.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbText.Location = New System.Drawing.Point(0, 0)
        Me.lbText.Name = "lbText"
        Me.lbText.Size = New System.Drawing.Size(166, 24)
        Me.lbText.TabIndex = 0
        Me.lbText.Text = "Sangat Lemah"
        Me.lbText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InisialisasiPasswordMeter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.lbText)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoubleBuffered = True
        Me.Name = "InisialisasiPasswordMeter"
        Me.Size = New System.Drawing.Size(166, 24)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbText As System.Windows.Forms.Label

End Class
