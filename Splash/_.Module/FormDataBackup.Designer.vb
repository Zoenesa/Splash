<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataBackup
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
        Me.components = New System.ComponentModel.Container()
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.txPath = New Telerik.WinControls.UI.RadTextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnBackup = New Telerik.WinControls.UI.RadButton()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.chWrapExportMode = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
        Me.txEncryptPass = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.numericSQL = New Telerik.WinControls.UI.RadSpinEditor()
        Me.chExportProcedureFunct = New Telerik.WinControls.UI.RadCheckBox()
        Me.chCreatedb = New Telerik.WinControls.UI.RadCheckBox()
        Me.chEncryption = New Telerik.WinControls.UI.RadCheckBox()
        Me.chDumpTime = New Telerik.WinControls.UI.RadCheckBox()
        Me.ExportRoutin = New Telerik.WinControls.UI.RadCheckBox()
        Me.chResetIncrement = New Telerik.WinControls.UI.RadCheckBox()
        Me.chExportRows = New Telerik.WinControls.UI.RadCheckBox()
        Me.chDropCreate = New Telerik.WinControls.UI.RadCheckBox()
        Me.btnBrowse = New Telerik.WinControls.UI.RadButton()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnRestore = New Telerik.WinControls.UI.RadButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.txDefaultCharset = New Telerik.WinControls.UI.RadTextBox()
        Me.txTargetDb = New Telerik.WinControls.UI.RadTextBox()
        Me.txErrLogPath = New Telerik.WinControls.UI.RadTextBox()
        Me.btnSaveLog = New Telerik.WinControls.UI.RadButton()
        Me.txDecryptPass = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.chIgnoreError = New Telerik.WinControls.UI.RadCheckBox()
        Me.chDecryption = New Telerik.WinControls.UI.RadCheckBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSelectSQL = New Telerik.WinControls.UI.RadButton()
        Me.txSQLFile = New Telerik.WinControls.UI.RadTextBox()
        Me.txSettingKoneksi = New Telerik.WinControls.UI.RadTextBox()
        Me.chAutoSave = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadStatusStrippp = New Telerik.WinControls.UI.RadStatusStrip()
        Me.lbCurrentTableName = New Telerik.WinControls.UI.RadLabelElement()
        Me.label2 = New Telerik.WinControls.UI.RadLabelElement()
        Me.pbRowInCurTable = New Telerik.WinControls.UI.RadProgressBarElement()
        Me.RadLabelElement3 = New Telerik.WinControls.UI.RadLabelElement()
        Me.pbRowInAllTable = New Telerik.WinControls.UI.RadProgressBarElement()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbTotalRows_Tables = New Telerik.WinControls.UI.RadLabel()
        Me.bwExport = New System.ComponentModel.BackgroundWorker()
        Me.pbtable = New Telerik.WinControls.UI.RadProgressBarElement()
        CType(Me.txPath, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.btnBackup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chWrapExportMode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txEncryptPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericSQL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chExportProcedureFunct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chCreatedb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chEncryption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chDumpTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportRoutin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chResetIncrement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chExportRows, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chDropCreate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBrowse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.btnRestore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txDefaultCharset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txTargetDb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txErrLogPath, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSaveLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txDecryptPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chIgnoreError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chDecryption, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.btnSelectSQL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txSQLFile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txSettingKoneksi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chAutoSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrippp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbTotalRows_Tables, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txPath
        '
        Me.txPath.AutoSize = False
        Me.txPath.BackColor = System.Drawing.Color.Transparent
        Me.txPath.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txPath.Location = New System.Drawing.Point(3, 32)
        Me.txPath.Name = "txPath"
        Me.txPath.NullText = "Backup Filename Path"
        Me.txPath.Padding = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.txPath.ReadOnly = True
        Me.txPath.Size = New System.Drawing.Size(588, 23)
        Me.txPath.TabIndex = 8
        Me.txPath.ThemeName = "Office2010Black"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnBackup, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(2, 233)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(460, 33)
        Me.TableLayoutPanel2.TabIndex = 9
        '
        'btnBackup
        '
        Me.btnBackup.BackColor = System.Drawing.Color.Transparent
        Me.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBackup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBackup.Location = New System.Drawing.Point(3, 3)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(454, 27)
        Me.btnBackup.TabIndex = 0
        Me.btnBackup.Text = "Execute &Backup"
        Me.btnBackup.ThemeName = "Office2010Black"
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.RadGroupBox1.Controls.Add(Me.Panel1)
        Me.RadGroupBox1.Controls.Add(Me.txEncryptPass)
        Me.RadGroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel6)
        Me.RadGroupBox1.Controls.Add(Me.numericSQL)
        Me.RadGroupBox1.Controls.Add(Me.chExportProcedureFunct)
        Me.RadGroupBox1.Controls.Add(Me.chCreatedb)
        Me.RadGroupBox1.Controls.Add(Me.chEncryption)
        Me.RadGroupBox1.Controls.Add(Me.chDumpTime)
        Me.RadGroupBox1.Controls.Add(Me.ExportRoutin)
        Me.RadGroupBox1.Controls.Add(Me.chResetIncrement)
        Me.RadGroupBox1.Controls.Add(Me.chExportRows)
        Me.RadGroupBox1.Controls.Add(Me.chDropCreate)
        Me.RadGroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadGroupBox1.HeaderText = "Backup/Export Options"
        Me.RadGroupBox1.Location = New System.Drawing.Point(3, 61)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(464, 268)
        Me.RadGroupBox1.TabIndex = 10
        Me.RadGroupBox1.Text = "Backup/Export Options"
        Me.RadGroupBox1.ThemeName = "Office2010Black"
        CType(Me.RadGroupBox1.GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.RadLabel4)
        Me.Panel1.Controls.Add(Me.chWrapExportMode)
        Me.Panel1.Controls.Add(Me.RadDropDownList1)
        Me.Panel1.Location = New System.Drawing.Point(216, 126)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(240, 80)
        Me.Panel1.TabIndex = 14
        '
        'RadLabel4
        '
        Me.RadLabel4.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.ForeColor = System.Drawing.Color.Black
        Me.RadLabel4.Location = New System.Drawing.Point(9, 3)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(109, 19)
        Me.RadLabel4.TabIndex = 11
        Me.RadLabel4.Text = "Rows Export Mode"
        '
        'chWrapExportMode
        '
        Me.chWrapExportMode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chWrapExportMode.Location = New System.Drawing.Point(9, 55)
        Me.chWrapExportMode.Name = "chWrapExportMode"
        Me.chWrapExportMode.Size = New System.Drawing.Size(214, 19)
        Me.chWrapExportMode.TabIndex = 8
        Me.chWrapExportMode.Text = "Wrap Exported Rows In Transaction"
        '
        'RadDropDownList1
        '
        Me.RadDropDownList1.AutoSize = False
        Me.RadDropDownList1.BackColor = System.Drawing.Color.Transparent
        Me.RadDropDownList1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RadListDataItem1.Text = "Normal"
        RadListDataItem2.Text = "Revisions"
        Me.RadDropDownList1.Items.Add(RadListDataItem1)
        Me.RadDropDownList1.Items.Add(RadListDataItem2)
        Me.RadDropDownList1.Location = New System.Drawing.Point(9, 26)
        Me.RadDropDownList1.Name = "RadDropDownList1"
        Me.RadDropDownList1.NullText = "Row Mode"
        Me.RadDropDownList1.Size = New System.Drawing.Size(214, 23)
        Me.RadDropDownList1.TabIndex = 13
        Me.RadDropDownList1.ThemeName = "Office2010Black"
        '
        'txEncryptPass
        '
        Me.txEncryptPass.AutoSize = False
        Me.txEncryptPass.BackColor = System.Drawing.Color.Transparent
        Me.txEncryptPass.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txEncryptPass.Location = New System.Drawing.Point(73, 158)
        Me.txEncryptPass.Name = "txEncryptPass"
        Me.txEncryptPass.Padding = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.txEncryptPass.Size = New System.Drawing.Size(132, 23)
        Me.txEncryptPass.TabIndex = 12
        Me.txEncryptPass.ThemeName = "Office2010Black"
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.ForeColor = System.Drawing.Color.Black
        Me.RadLabel1.Location = New System.Drawing.Point(9, 162)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(58, 19)
        Me.RadLabel1.TabIndex = 11
        Me.RadLabel1.Text = "Password"
        '
        'RadLabel6
        '
        Me.RadLabel6.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel6.ForeColor = System.Drawing.Color.Black
        Me.RadLabel6.Location = New System.Drawing.Point(9, 193)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(96, 19)
        Me.RadLabel6.TabIndex = 11
        Me.RadLabel6.Text = "Max SQL Length"
        '
        'numericSQL
        '
        Me.numericSQL.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numericSQL.Increment = New Decimal(New Integer() {150, 0, 0, 0})
        Me.numericSQL.Location = New System.Drawing.Point(105, 191)
        Me.numericSQL.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.numericSQL.Minimum = New Decimal(New Integer() {1500, 0, 0, 0})
        Me.numericSQL.Name = "numericSQL"
        Me.numericSQL.Padding = New System.Windows.Forms.Padding(8, 1, 0, 1)
        Me.numericSQL.Size = New System.Drawing.Size(100, 23)
        Me.numericSQL.TabIndex = 0
        Me.numericSQL.TabStop = False
        Me.numericSQL.ThemeName = "Office2010Black"
        Me.numericSQL.Value = New Decimal(New Integer() {3145728, 0, 0, 0})
        CType(Me.numericSQL.GetChildAt(0), Telerik.WinControls.UI.RadSpinElement).Padding = New System.Windows.Forms.Padding(8, 1, 0, 1)
        CType(Me.numericSQL.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Padding = New System.Windows.Forms.Padding(4, 0, 6, 0)
        CType(Me.numericSQL.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Padding = New System.Windows.Forms.Padding(4, 0, 6, 0)
        CType(Me.numericSQL.GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.StackLayoutElement).Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        '
        'chExportProcedureFunct
        '
        Me.chExportProcedureFunct.AutoSize = False
        Me.chExportProcedureFunct.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chExportProcedureFunct.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chExportProcedureFunct.Location = New System.Drawing.Point(216, 21)
        Me.chExportProcedureFunct.Name = "chExportProcedureFunct"
        Me.chExportProcedureFunct.Size = New System.Drawing.Size(240, 33)
        Me.chExportProcedureFunct.TabIndex = 6
        Me.chExportProcedureFunct.Text = "Export Procedures, Functions, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Triggers, Events, Views"
        Me.chExportProcedureFunct.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.chExportProcedureFunct.TextWrap = True
        Me.chExportProcedureFunct.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'chCreatedb
        '
        Me.chCreatedb.AutoSize = False
        Me.chCreatedb.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chCreatedb.Location = New System.Drawing.Point(9, 21)
        Me.chCreatedb.Name = "chCreatedb"
        Me.chCreatedb.Size = New System.Drawing.Size(196, 18)
        Me.chCreatedb.TabIndex = 2
        Me.chCreatedb.Text = "Add Create Database"
        '
        'chEncryption
        '
        Me.chEncryption.AutoSize = False
        Me.chEncryption.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chEncryption.Location = New System.Drawing.Point(9, 135)
        Me.chEncryption.Name = "chEncryption"
        Me.chEncryption.Size = New System.Drawing.Size(196, 19)
        Me.chEncryption.TabIndex = 7
        Me.chEncryption.Text = "Enable Encryption"
        '
        'chDumpTime
        '
        Me.chDumpTime.AutoSize = False
        Me.chDumpTime.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chDumpTime.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chDumpTime.Location = New System.Drawing.Point(216, 94)
        Me.chDumpTime.Name = "chDumpTime"
        Me.chDumpTime.Size = New System.Drawing.Size(240, 18)
        Me.chDumpTime.TabIndex = 7
        Me.chDumpTime.Text = "Record Dump Time"
        Me.chDumpTime.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'ExportRoutin
        '
        Me.ExportRoutin.AutoSize = False
        Me.ExportRoutin.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ExportRoutin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportRoutin.Location = New System.Drawing.Point(216, 63)
        Me.ExportRoutin.Name = "ExportRoutin"
        Me.ExportRoutin.Size = New System.Drawing.Size(240, 18)
        Me.ExportRoutin.TabIndex = 7
        Me.ExportRoutin.Text = "Export Routines Without Definer"
        Me.ExportRoutin.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'chResetIncrement
        '
        Me.chResetIncrement.AutoSize = False
        Me.chResetIncrement.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chResetIncrement.Location = New System.Drawing.Point(9, 106)
        Me.chResetIncrement.Name = "chResetIncrement"
        Me.chResetIncrement.Size = New System.Drawing.Size(196, 18)
        Me.chResetIncrement.TabIndex = 5
        Me.chResetIncrement.Text = "Reset Auto Increment"
        '
        'chExportRows
        '
        Me.chExportRows.AutoSize = False
        Me.chExportRows.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chExportRows.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chExportRows.Location = New System.Drawing.Point(9, 78)
        Me.chExportRows.Name = "chExportRows"
        Me.chExportRows.Size = New System.Drawing.Size(196, 18)
        Me.chExportRows.TabIndex = 4
        Me.chExportRows.Text = "Export Rows"
        Me.chExportRows.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'chDropCreate
        '
        Me.chDropCreate.AutoSize = False
        Me.chDropCreate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chDropCreate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chDropCreate.Location = New System.Drawing.Point(9, 49)
        Me.chDropCreate.Name = "chDropCreate"
        Me.chDropCreate.Size = New System.Drawing.Size(196, 18)
        Me.chDropCreate.TabIndex = 3
        Me.chDropCreate.Text = "Add Drop/Create Table"
        Me.chDropCreate.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowse.BackColor = System.Drawing.Color.Transparent
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBrowse.Location = New System.Drawing.Point(597, 32)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(156, 23)
        Me.btnBrowse.TabIndex = 7
        Me.btnBrowse.Text = "&Browse"
        Me.btnBrowse.ThemeName = "Office2010Black"
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.RadGroupBox2.Controls.Add(Me.TableLayoutPanel3)
        Me.RadGroupBox2.Controls.Add(Me.Panel2)
        Me.RadGroupBox2.Controls.Add(Me.txErrLogPath)
        Me.RadGroupBox2.Controls.Add(Me.btnSaveLog)
        Me.RadGroupBox2.Controls.Add(Me.txDecryptPass)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel5)
        Me.RadGroupBox2.Controls.Add(Me.chIgnoreError)
        Me.RadGroupBox2.Controls.Add(Me.chDecryption)
        Me.RadGroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadGroupBox2.HeaderText = "Restore/Import Options"
        Me.RadGroupBox2.Location = New System.Drawing.Point(473, 61)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(281, 268)
        Me.RadGroupBox2.TabIndex = 10
        Me.RadGroupBox2.Text = "Restore/Import Options"
        Me.RadGroupBox2.ThemeName = "Office2010Black"
        CType(Me.RadGroupBox2.GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnRestore, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(2, 233)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(277, 33)
        Me.TableLayoutPanel3.TabIndex = 15
        '
        'btnRestore
        '
        Me.btnRestore.BackColor = System.Drawing.Color.Transparent
        Me.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRestore.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRestore.Location = New System.Drawing.Point(3, 3)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(271, 27)
        Me.btnRestore.TabIndex = 0
        Me.btnRestore.Text = "Execute &Restore"
        Me.btnRestore.ThemeName = "Office2010Black"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.RadLabel2)
        Me.Panel2.Controls.Add(Me.txDefaultCharset)
        Me.Panel2.Controls.Add(Me.txTargetDb)
        Me.Panel2.Location = New System.Drawing.Point(11, 101)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(231, 85)
        Me.Panel2.TabIndex = 14
        '
        'RadLabel2
        '
        Me.RadLabel2.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.ForeColor = System.Drawing.Color.Black
        Me.RadLabel2.Location = New System.Drawing.Point(9, 3)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(135, 19)
        Me.RadLabel2.TabIndex = 11
        Me.RadLabel2.Text = "Import ke database lain"
        '
        'txDefaultCharset
        '
        Me.txDefaultCharset.AutoSize = False
        Me.txDefaultCharset.BackColor = System.Drawing.Color.Transparent
        Me.txDefaultCharset.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txDefaultCharset.Location = New System.Drawing.Point(9, 52)
        Me.txDefaultCharset.Name = "txDefaultCharset"
        Me.txDefaultCharset.NullText = "Optional Charset"
        Me.txDefaultCharset.Padding = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.txDefaultCharset.Size = New System.Drawing.Size(212, 23)
        Me.txDefaultCharset.TabIndex = 12
        Me.txDefaultCharset.ThemeName = "Office2010Black"
        '
        'txTargetDb
        '
        Me.txTargetDb.AutoSize = False
        Me.txTargetDb.BackColor = System.Drawing.Color.Transparent
        Me.txTargetDb.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txTargetDb.Location = New System.Drawing.Point(9, 23)
        Me.txTargetDb.Name = "txTargetDb"
        Me.txTargetDb.NullText = "Nama Target Database"
        Me.txTargetDb.Padding = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.txTargetDb.Size = New System.Drawing.Size(212, 23)
        Me.txTargetDb.TabIndex = 12
        Me.txTargetDb.ThemeName = "Office2010Black"
        '
        'txErrLogPath
        '
        Me.txErrLogPath.AutoSize = False
        Me.txErrLogPath.BackColor = System.Drawing.Color.Transparent
        Me.txErrLogPath.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txErrLogPath.Location = New System.Drawing.Point(75, 193)
        Me.txErrLogPath.Name = "txErrLogPath"
        Me.txErrLogPath.NullText = "Save Error Log"
        Me.txErrLogPath.Padding = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.txErrLogPath.ReadOnly = True
        Me.txErrLogPath.Size = New System.Drawing.Size(197, 23)
        Me.txErrLogPath.TabIndex = 12
        Me.txErrLogPath.ThemeName = "Office2010Black"
        '
        'btnSaveLog
        '
        Me.btnSaveLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveLog.BackColor = System.Drawing.Color.Transparent
        Me.btnSaveLog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveLog.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSaveLog.Location = New System.Drawing.Point(11, 193)
        Me.btnSaveLog.Name = "btnSaveLog"
        Me.btnSaveLog.Size = New System.Drawing.Size(58, 23)
        Me.btnSaveLog.TabIndex = 7
        Me.btnSaveLog.Text = "&Save Log"
        Me.btnSaveLog.ThemeName = "Office2010Black"
        '
        'txDecryptPass
        '
        Me.txDecryptPass.AutoSize = False
        Me.txDecryptPass.BackColor = System.Drawing.Color.Transparent
        Me.txDecryptPass.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txDecryptPass.Location = New System.Drawing.Point(75, 43)
        Me.txDecryptPass.Name = "txDecryptPass"
        Me.txDecryptPass.Padding = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.txDecryptPass.Size = New System.Drawing.Size(132, 23)
        Me.txDecryptPass.TabIndex = 12
        Me.txDecryptPass.ThemeName = "Office2010Black"
        '
        'RadLabel5
        '
        Me.RadLabel5.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel5.ForeColor = System.Drawing.Color.Black
        Me.RadLabel5.Location = New System.Drawing.Point(11, 47)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(58, 19)
        Me.RadLabel5.TabIndex = 11
        Me.RadLabel5.Text = "Password"
        '
        'chIgnoreError
        '
        Me.chIgnoreError.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chIgnoreError.Location = New System.Drawing.Point(11, 75)
        Me.chIgnoreError.Name = "chIgnoreError"
        Me.chIgnoreError.Size = New System.Drawing.Size(116, 19)
        Me.chIgnoreError.TabIndex = 8
        Me.chIgnoreError.Text = "Ignore SQL Errors"
        '
        'chDecryption
        '
        Me.chDecryption.AutoSize = False
        Me.chDecryption.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chDecryption.Location = New System.Drawing.Point(11, 21)
        Me.chDecryption.Name = "chDecryption"
        Me.chDecryption.Size = New System.Drawing.Size(196, 19)
        Me.chDecryption.TabIndex = 7
        Me.chDecryption.Text = "Enable Encryption"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnSelectSQL, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txSQLFile, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 332)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(757, 29)
        Me.TableLayoutPanel1.TabIndex = 15
        '
        'btnSelectSQL
        '
        Me.btnSelectSQL.BackColor = System.Drawing.Color.Transparent
        Me.btnSelectSQL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelectSQL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSelectSQL.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSelectSQL.Location = New System.Drawing.Point(597, 3)
        Me.btnSelectSQL.Name = "btnSelectSQL"
        Me.btnSelectSQL.Size = New System.Drawing.Size(157, 23)
        Me.btnSelectSQL.TabIndex = 0
        Me.btnSelectSQL.Text = "Select &SQL"
        Me.btnSelectSQL.ThemeName = "Office2010Black"
        '
        'txSQLFile
        '
        Me.txSQLFile.AutoSize = False
        Me.txSQLFile.BackColor = System.Drawing.Color.Transparent
        Me.txSQLFile.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txSQLFile.Location = New System.Drawing.Point(3, 3)
        Me.txSQLFile.Name = "txSQLFile"
        Me.txSQLFile.NullText = "Select Sql File"
        Me.txSQLFile.ReadOnly = True
        Me.txSQLFile.Size = New System.Drawing.Size(588, 23)
        Me.txSQLFile.TabIndex = 8
        Me.txSQLFile.ThemeName = "Office2010Black"
        '
        'txSettingKoneksi
        '
        Me.txSettingKoneksi.AutoSize = False
        Me.txSettingKoneksi.BackColor = System.Drawing.Color.Transparent
        Me.txSettingKoneksi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txSettingKoneksi.Location = New System.Drawing.Point(164, 5)
        Me.txSettingKoneksi.Name = "txSettingKoneksi"
        Me.txSettingKoneksi.NullText = "Format Koneksi (server;user;password;database)"
        Me.txSettingKoneksi.Padding = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.txSettingKoneksi.Size = New System.Drawing.Size(589, 23)
        Me.txSettingKoneksi.TabIndex = 8
        Me.txSettingKoneksi.ThemeName = "Office2010Black"
        '
        'chAutoSave
        '
        Me.chAutoSave.AutoSize = False
        Me.chAutoSave.CheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.chAutoSave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chAutoSave.Location = New System.Drawing.Point(12, 7)
        Me.chAutoSave.Name = "chAutoSave"
        Me.chAutoSave.Size = New System.Drawing.Size(146, 18)
        Me.chAutoSave.TabIndex = 4
        Me.chAutoSave.Text = "Koneksi String, Save As"
        Me.chAutoSave.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadStatusStrippp
        '
        Me.RadStatusStrippp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RadStatusStrippp.Items.AddRange(New Telerik.WinControls.RadItem() {Me.lbCurrentTableName, Me.pbtable, Me.label2, Me.pbRowInCurTable, Me.RadLabelElement3, Me.pbRowInAllTable})
        Me.RadStatusStrippp.Location = New System.Drawing.Point(0, 415)
        Me.RadStatusStrippp.Name = "RadStatusStrippp"
        Me.RadStatusStrippp.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.RadStatusStrippp.Size = New System.Drawing.Size(757, 25)
        Me.RadStatusStrippp.TabIndex = 16
        Me.RadStatusStrippp.Text = "RadStatusStrip1"
        Me.RadStatusStrippp.ThemeName = "Office2010Black"
        '
        'lbCurrentTableName
        '
        Me.lbCurrentTableName.AccessibleDescription = "RadLabelElement1"
        Me.lbCurrentTableName.AccessibleName = "RadLabelElement1"
        Me.lbCurrentTableName.Name = "lbCurrentTableName"
        Me.RadStatusStrippp.SetSpring(Me.lbCurrentTableName, False)
        Me.lbCurrentTableName.Text = "Table"
        Me.lbCurrentTableName.TextWrap = True
        '
        'label2
        '
        Me.label2.AccessibleDescription = "RadLabelElement2"
        Me.label2.AccessibleName = "RadLabelElement2"
        Me.label2.Name = "label2"
        Me.RadStatusStrippp.SetSpring(Me.label2, False)
        Me.label2.Text = "Rows in Current Table"
        Me.label2.TextWrap = True
        '
        'pbRowInCurTable
        '
        Me.pbRowInCurTable.AccessibleDescription = "1/1"
        Me.pbRowInCurTable.AccessibleName = "1/1"
        Me.pbRowInCurTable.AutoSize = False
        Me.pbRowInCurTable.Bounds = New System.Drawing.Rectangle(0, 0, 102, 19)
        Me.pbRowInCurTable.DrawText = True
        Me.pbRowInCurTable.GradientStyle = Telerik.WinControls.GradientStyles.Vista
        Me.pbRowInCurTable.Name = "pbRowInCurTable"
        Me.pbRowInCurTable.SeparatorColor1 = System.Drawing.Color.White
        Me.pbRowInCurTable.SeparatorColor2 = System.Drawing.Color.White
        Me.pbRowInCurTable.SeparatorColor3 = System.Drawing.Color.White
        Me.pbRowInCurTable.SeparatorColor4 = System.Drawing.Color.White
        Me.pbRowInCurTable.SeparatorGradientAngle = 0
        Me.pbRowInCurTable.SeparatorGradientPercentage1 = 0.4!
        Me.pbRowInCurTable.SeparatorGradientPercentage2 = 0.6!
        Me.pbRowInCurTable.SeparatorNumberOfColors = 2
        Me.RadStatusStrippp.SetSpring(Me.pbRowInCurTable, False)
        Me.pbRowInCurTable.Step = 1
        Me.pbRowInCurTable.StepWidth = 5
        Me.pbRowInCurTable.SweepAngle = 90
        Me.pbRowInCurTable.Text = ""
        '
        'RadLabelElement3
        '
        Me.RadLabelElement3.AccessibleDescription = "RadLabelElement3"
        Me.RadLabelElement3.AccessibleName = "RadLabelElement3"
        Me.RadLabelElement3.Name = "RadLabelElement3"
        Me.RadStatusStrippp.SetSpring(Me.RadLabelElement3, False)
        Me.RadLabelElement3.Text = "Rows in All Tables"
        Me.RadLabelElement3.TextWrap = True
        '
        'pbRowInAllTable
        '
        Me.pbRowInAllTable.AccessibleDescription = "1/1"
        Me.pbRowInAllTable.AccessibleName = "1/1"
        Me.pbRowInAllTable.AutoSize = False
        Me.pbRowInAllTable.Bounds = New System.Drawing.Rectangle(0, 0, 102, 19)
        Me.pbRowInAllTable.DrawText = True
        Me.pbRowInAllTable.GradientStyle = Telerik.WinControls.GradientStyles.Vista
        Me.pbRowInAllTable.Name = "pbRowInAllTable"
        Me.pbRowInAllTable.SeparatorColor1 = System.Drawing.Color.White
        Me.pbRowInAllTable.SeparatorColor2 = System.Drawing.Color.White
        Me.pbRowInAllTable.SeparatorColor3 = System.Drawing.Color.White
        Me.pbRowInAllTable.SeparatorColor4 = System.Drawing.Color.White
        Me.pbRowInAllTable.SeparatorGradientAngle = 0
        Me.pbRowInAllTable.SeparatorGradientPercentage1 = 0.4!
        Me.pbRowInAllTable.SeparatorGradientPercentage2 = 0.6!
        Me.pbRowInAllTable.SeparatorNumberOfColors = 2
        Me.RadStatusStrippp.SetSpring(Me.pbRowInAllTable, False)
        Me.pbRowInAllTable.Step = 1
        Me.pbRowInAllTable.StepWidth = 5
        Me.pbRowInAllTable.SweepAngle = 90
        Me.pbRowInAllTable.Text = ""
        '
        'RadLabel3
        '
        Me.RadLabel3.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.ForeColor = System.Drawing.Color.Black
        Me.RadLabel3.Location = New System.Drawing.Point(0, 374)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(80, 35)
        Me.RadLabel3.TabIndex = 11
        Me.RadLabel3.Text = "Total Tables:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Total Rows:"
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'lbTotalRows_Tables
        '
        Me.lbTotalRows_Tables.AutoSize = False
        Me.lbTotalRows_Tables.BackColor = System.Drawing.Color.Transparent
        Me.lbTotalRows_Tables.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalRows_Tables.ForeColor = System.Drawing.Color.Black
        Me.lbTotalRows_Tables.Location = New System.Drawing.Point(86, 374)
        Me.lbTotalRows_Tables.Name = "lbTotalRows_Tables"
        Me.lbTotalRows_Tables.Size = New System.Drawing.Size(343, 35)
        Me.lbTotalRows_Tables.TabIndex = 11
        '
        'bwExport
        '
        Me.bwExport.WorkerReportsProgress = True
        Me.bwExport.WorkerSupportsCancellation = True
        '
        'pbtable
        '
        Me.pbtable.AutoSize = False
        Me.pbtable.Bounds = New System.Drawing.Rectangle(0, 0, 102, 19)
        Me.pbtable.GradientStyle = Telerik.WinControls.GradientStyles.Vista
        Me.pbtable.Name = "pbtable"
        Me.pbtable.SeparatorColor1 = System.Drawing.Color.White
        Me.pbtable.SeparatorColor2 = System.Drawing.Color.White
        Me.pbtable.SeparatorColor3 = System.Drawing.Color.White
        Me.pbtable.SeparatorColor4 = System.Drawing.Color.White
        Me.pbtable.SeparatorGradientAngle = 0
        Me.pbtable.SeparatorGradientPercentage1 = 0.4!
        Me.pbtable.SeparatorGradientPercentage2 = 0.6!
        Me.pbtable.SeparatorNumberOfColors = 2
        Me.RadStatusStrippp.SetSpring(Me.pbtable, False)
        Me.pbtable.Step = 1
        Me.pbtable.StepWidth = 5
        Me.pbtable.SweepAngle = 90
        Me.pbtable.Text = ""
        '
        'FormDataBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 440)
        Me.Controls.Add(Me.RadStatusStrippp)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.lbTotalRows_Tables)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txSettingKoneksi)
        Me.Controls.Add(Me.txPath)
        Me.Controls.Add(Me.chAutoSave)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormDataBackup"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export & Import Database"
        Me.ThemeName = "Office2010Black"
        CType(Me.txPath, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.btnBackup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chWrapExportMode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txEncryptPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericSQL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chExportProcedureFunct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chCreatedb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chEncryption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chDumpTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportRoutin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chResetIncrement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chExportRows, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chDropCreate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBrowse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        Me.RadGroupBox2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.btnRestore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txDefaultCharset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txTargetDb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txErrLogPath, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSaveLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txDecryptPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chIgnoreError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chDecryption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.btnSelectSQL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txSQLFile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txSettingKoneksi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chAutoSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrippp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbTotalRows_Tables, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txPath As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnBackup As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents chExportProcedureFunct As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents chCreatedb As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents ExportRoutin As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents chResetIncrement As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents chExportRows As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents chDropCreate As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents numericSQL As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txEncryptPass As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents chEncryption As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents btnBrowse As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadDropDownList1 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents txDecryptPass As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents chWrapExportMode As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents chIgnoreError As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents chDecryption As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnSelectSQL As Telerik.WinControls.UI.RadButton
    Friend WithEvents txSQLFile As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txTargetDb As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txDefaultCharset As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnRestore As Telerik.WinControls.UI.RadButton
    Friend WithEvents chDumpTime As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents txErrLogPath As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnSaveLog As Telerik.WinControls.UI.RadButton
    Friend WithEvents txSettingKoneksi As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents chAutoSave As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadStatusStrippp As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents lbCurrentTableName As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents label2 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents pbRowInCurTable As Telerik.WinControls.UI.RadProgressBarElement
    Friend WithEvents RadLabelElement3 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents pbRowInAllTable As Telerik.WinControls.UI.RadProgressBarElement
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbTotalRows_Tables As Telerik.WinControls.UI.RadLabel
    Friend WithEvents bwExport As System.ComponentModel.BackgroundWorker
    Friend WithEvents pbtable As Telerik.WinControls.UI.RadProgressBarElement
End Class
