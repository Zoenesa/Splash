Imports Telerik, Telerik.WinControls, Telerik.WinControls.UI
Imports MySql.Data.MySqlClient, Microsoft.VisualBasic.CompilerServices
Imports Splash.Konektor

Public Class rFormBackupdb

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Telerik.WinControls.RadMessageBox.Instance.AllowTheming = True
        Telerik.WinControls.RadMessageBox.Instance.ControlBox = False
        Telerik.WinControls.RadMessageBox.ShowInTaskbar = False
        Telerik.WinControls.RadMessageBox.ThemeName = rFormMain.Office2010BlackTheme1.ThemeName

        rFormMain.SetTheme(Me, rFormMain.Office2010BlackTheme1.ThemeName.ToString)

        Me.rDropExportMode.ValueMember = "id"
        Me.rDropExportMode.DisplayMember = "name"
        Dim tbl As New DataTable
        tbl.Columns.Add("id", GetType(RowsDataExportMode))
        tbl.Columns.Add("name")
        Dim mode As RowsDataExportMode
        For Each mode In [Enum].GetValues(GetType(RowsDataExportMode))
            tbl.Rows.Add(New Object() {mode, mode.ToString})
        Next

        Me.rDropExportMode.DataSource = tbl
        Me.rDropExportMode.SelectedIndex = 0
    End Sub

    Private Function TargetDirValid() As Boolean
        Dim flag As Boolean
        Try
            Dim dirPath As String = IO.Path.GetDirectoryName(My.Application.Info.DirectoryPath & "\backups\")
            If Not IO.Directory.Exists(dirPath) Then
                IO.Directory.CreateDirectory(dirPath)
            End If
            flag = True
        Catch ex As Exception
            flag = False
            RadMessageBox.Show(ex.Message, "Invalid Directory", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
        Return flag
    End Function

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Dim errmsg As String
        If TargetDirValid() Then
            Try
                Dim sConn As String
                sConn = mdlSQL.KoneksiString
                sConn = "server=localhost;user=SUPERVISOR;password=di5t0rti0n;database=db_apps;"
                'Dim nFileName As String = My.Application.Info.DirectoryPath & "\backups\" & DateTime.Now.ToString("dd-MMM-yy@HH-mm-ss") & "@_local.sql"
                Dim nfile As String = "d:\backups.sql"
                Using sqlcon As MySqlConnection = New MySqlConnection(sConn)
                    Using Command As MySqlCommand = New MySqlCommand()
                        Using backup As MySqlBackup = New MySqlBackup()
                            Command.Connection = mdlSQL.vConn
                            backup.Command = Command
                            sqlcon.Open()
                            backup.ExportInfo.AddCreateDatabase = Me.rchkAddCreate.Checked
                            backup.ExportInfo.ExportTableStructure = Me.rchkDrop.Checked
                            backup.ExportInfo.ExportRows = Me.rchkExportRows.Checked
                            backup.ExportInfo.RecordDumpTime = Me.rchkDumptime.Checked
                            backup.ExportInfo.ResetAutoIncrement = Me.rchkResetIncrement.Checked
                            backup.ExportInfo.EnableEncryption = Me.rchkEcrypt.Checked
                            backup.ExportInfo.EncryptionPassword = Me.txPassEncrypt.Text.Trim()
                            backup.ExportInfo.MaxSqlLength = CInt(Me.rSpinEditor.Value)
                            backup.ExportInfo.ExportFunctions = Me.rchkExportProc.Checked
                            backup.ExportInfo.ExportProcedures = Me.rchkExportProc.Checked
                            backup.ExportInfo.ExportTriggers = Me.rchkExportProc.Checked
                            backup.ExportInfo.ExportViews = Me.rchkExportProc.Checked
                            backup.ExportInfo.ExportEvents = Me.rchkExportProc.Checked
                            backup.ExportInfo.ExportRoutinesWithoutDefiner = Me.rchkExportRutin.Checked
                            backup.ExportInfo.RowsExportMode = DirectCast(Me.rDropExportMode.SelectedValue, RowsDataExportMode)
                            backup.ExportInfo.WrapWithinTransaction = Me.rchkWrapmode.Checked
                            backup.ExportToFile(nfile)
                            sqlcon.Close()
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim excep As Exception = ex
                errmsg = "Error.Message: " & excep.Message
                mdlSQL.INSERTLOG(errmsg, "")
                RadMessageBox.Show("Error" & ex.Source & vbNewLine & ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
                ProjectData.ClearProjectError()
            End Try
        End If
    End Sub

    Private Sub rFormBackupdb_Load(sender As Object, e As EventArgs) Handles Me.Load
        rFormMain.SetTheme(Me, rFormMain.Office2010BlackTheme1.ThemeName.ToString)
        rFormMain.UserSettingIcon(True, Me)
    End Sub
End Class