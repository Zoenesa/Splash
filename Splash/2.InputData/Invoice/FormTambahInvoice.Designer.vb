<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTambahInvoice
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.RadWizard1 = New Telerik.WinControls.UI.RadWizard()
        Me.WizardWelcomePage1 = New Telerik.WinControls.UI.WizardWelcomePage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.WizardCompletionPage1 = New Telerik.WinControls.UI.WizardCompletionPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.WizardPage1 = New Telerik.WinControls.UI.WizardPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.WizardPage2 = New Telerik.WinControls.UI.WizardPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.RadWizard1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadWizard1.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadWizard1
        '
        Me.RadWizard1.CompletionPage = Me.WizardCompletionPage1
        Me.RadWizard1.Controls.Add(Me.Panel1)
        Me.RadWizard1.Controls.Add(Me.Panel5)
        Me.RadWizard1.Controls.Add(Me.Panel2)
        Me.RadWizard1.Controls.Add(Me.Panel3)
        Me.RadWizard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadWizard1.Location = New System.Drawing.Point(0, 0)
        Me.RadWizard1.Name = "RadWizard1"
        Me.RadWizard1.PageHeaderIcon = Nothing
        Me.RadWizard1.Pages.Add(Me.WizardWelcomePage1)
        Me.RadWizard1.Pages.Add(Me.WizardPage1)
        Me.RadWizard1.Pages.Add(Me.WizardPage2)
        Me.RadWizard1.Pages.Add(Me.WizardCompletionPage1)
        Me.RadWizard1.Size = New System.Drawing.Size(723, 332)
        Me.RadWizard1.TabIndex = 0
        Me.RadWizard1.Text = "RadWizard1"
        Me.RadWizard1.ThemeName = "Office2010Black"
        Me.RadWizard1.WelcomePage = Me.WizardWelcomePage1
        CType(Me.RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.WizardPageHeaderElement).Icon = Nothing
        CType(Me.RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.WizardPageHeaderElement).BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid
        CType(Me.RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.WizardPageHeaderElement).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        CType(Me.RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.WizardTextElement).BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid
        CType(Me.RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.WizardTextElement).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        CType(Me.RadWizard1.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.WizardTextElement).Text = "Detail Invoice Baru"
        '
        'WizardWelcomePage1
        '
        Me.WizardWelcomePage1.ContentArea = Me.Panel1
        Me.WizardWelcomePage1.Name = "WizardWelcomePage1"
        Me.WizardWelcomePage1.Title = "Detail Invoice Baru"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(150, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(573, 228)
        Me.Panel1.TabIndex = 0
        '
        'WizardCompletionPage1
        '
        Me.WizardCompletionPage1.ContentArea = Me.Panel5
        Me.WizardCompletionPage1.Header = "Page header"
        Me.WizardCompletionPage1.Name = "WizardCompletionPage1"
        Me.WizardCompletionPage1.Title = "Deskripsi"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(150, 56)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(573, 228)
        Me.Panel5.TabIndex = 4
        '
        'WizardPage1
        '
        Me.WizardPage1.ContentArea = Me.Panel2
        Me.WizardPage1.Header = "Page header"
        Me.WizardPage1.Name = "WizardPage1"
        Me.WizardPage1.Title = "Page title"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 81)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(723, 203)
        Me.Panel2.TabIndex = 5
        '
        'WizardPage2
        '
        Me.WizardPage2.ContentArea = Me.Panel3
        Me.WizardPage2.Header = "Page header"
        Me.WizardPage2.Name = "WizardPage2"
        Me.WizardPage2.Title = "Page title"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(0, 81)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(723, 203)
        Me.Panel3.TabIndex = 6
        '
        'FormTambahInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 332)
        Me.Controls.Add(Me.RadWizard1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "FormTambahInvoice"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buat Invoice Baru"
        Me.ThemeName = "Office2010Black"
        CType(Me.RadWizard1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadWizard1.ResumeLayout(False)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadWizard1 As Telerik.WinControls.UI.RadWizard
    Friend WithEvents WizardCompletionPage1 As Telerik.WinControls.UI.WizardCompletionPage
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents WizardWelcomePage1 As Telerik.WinControls.UI.WizardWelcomePage
    Friend WithEvents WizardPage1 As Telerik.WinControls.UI.WizardPage
    Friend WithEvents WizardPage2 As Telerik.WinControls.UI.WizardPage
End Class

