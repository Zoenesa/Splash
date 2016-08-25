Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports FastColoredTextBoxNS
Imports MySql.Data.MySqlClient
Imports Telerik
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FormAdvancedSqlBackup

    Dim connSettingFile As String = IO.Path.Combine(Environment.CurrentDirectory, "ConnectionSettings.txt")
    Dim stopWrite As Boolean = True

    Dim lstForm As List(Of Form) = New List(Of Form)

    Public Sub New()

        InitializeComponent()
        Telerik.WinControls.RadMessageBox.Instance.AllowTheming = True
        Telerik.WinControls.RadMessageBox.Instance.ControlBox = False
        Telerik.WinControls.RadMessageBox.ShowInTaskbar = False
        Telerik.WinControls.RadMessageBox.ThemeName = rFormMain.Office2010BlackTheme1.ThemeName

        Me.Text += " ,MySqlBackup.DLL Version: " + MySql.Data.MySqlClient.MySqlBackup.Version

        'DataGridView1.VirtualMode = True
        RadGridView1.VirtualMode = True

        LoadSetting()

        If RadPageView1.SelectedPage Is RadPageViewPage5 Then
            FastColoredTextBox1.Text = ""
            tsFile.Text = ""
            tsStatus.Text = "                                                          "
        End If


    End Sub

    Private Sub LoadSetting()
        Try
            If IO.File.Exists(connSettingFile) Then
                txKoneksi.Text = IO.File.ReadAllText(connSettingFile)
                chAutoSave.Checked = True
            Else
                chAutoSave.Checked = False
            End If
        Catch ex As Exception
            RadMessageBox.Show("Error." & ex.Message.ToString, "Error", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Function WriteSetting(forceSave As Boolean) As Boolean
        Try
            If stopWrite Then
                Return forceSave
            End If
            If forceSave Then
                IO.File.WriteAllText(connSettingFile, txKoneksi.Text.Trim())
            Else
                If IO.File.Exists(connSettingFile) Then
                    IO.File.WriteAllText(connSettingFile, txKoneksi.Text.Trim())
                End If
            End If
            Return True
        Catch ex As Exception
            RadMessageBox.Show("Error." & ex.Message.ToString, "Error", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End Try
    End Function

    Private Sub RadPageView1_SelectedPageChanged(sender As Object, e As EventArgs) Handles RadPageView1.SelectedPageChanged
        If RadPageView1.SelectedPage Is RadPageViewPage5 Then
            tsStatus.Text = "(Tidak Ada File yang dimuat.)"
        Else
            tsStatus.Text = ""
        End If
        If RadPageView1.SelectedPage Is RadPageViewPage1 Then
            TableLayoutPanel2.Parent = RadPageViewPage1
        End If
        If RadPageView1.SelectedPage Is RadPageViewPage3 Then
            TableLayoutPanel2.Parent = RadPageViewPage3
        End If
    End Sub

    Private Sub FormAdvancedSqlBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stopWrite = False
        txKoneksi.Text = mdlCom.KoneksiString
    End Sub

    Private Sub OpenForm(formType As Type)
        Me.SuspendLayout()

        Try
            Dim i As Integer = 0
            While i < lstForm.Count
                lstForm(i).Close()
                lstForm(i).Dispose()
                lstForm(i) = Nothing
                System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
            End While

            lstForm.Clear()

            Dim form As Form = DirectCast(Activator.CreateInstance(formType), Form)
            form.WindowState = FormWindowState.Maximized
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            form.TopLevel = False

            Panel1.Controls.Add(form)
            form.Show()

            lstForm.Add(form)
        Catch ex As Exception
            RadMessageBox.Show(ex.Message.ToString(), "", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
        Me.ResumeLayout(True)
    End Sub

    Private Sub btnExportAs_Click(sender As Object, e As EventArgs) Handles btnExportAs.Click
        Dim f As SaveFileDialog = New SaveFileDialog()
        f.Title = "Simpan Dump Sql File"
        f.SupportMultiDottedExtensions = True

        If ModuleBackupRestore.FolderDefault <> "" Then
            f.InitialDirectory = ModuleBackupRestore.FolderDefault
        End If
        f.Filter = "*.sql|*.sql|*.*|*.*"
        f.FileName = "Dump " + DateTime.Now.ToString("yyyy-MM-dd HHmmss") + ".sql"
        If DialogResult.OK = f.ShowDialog() Then
            txBackupFilePath.Text = f.FileName
            ModuleBackupRestore.FolderDefault = System.IO.Path.GetDirectoryName(txBackupFilePath.Text.Trim())
        End If
    End Sub

    Private Sub txPilihFileSql_Click(sender As Object, e As EventArgs) Handles txPilihFileSql.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "*.sql|*.sql|*.*|*.*"
        ofd.Multiselect = False
        ofd.Title = "Pilih Sql File"
        ofd.SupportMultiDottedExtensions = True
        If ModuleBackupRestore.FolderDefault <> "" Then
            ofd.InitialDirectory = ModuleBackupRestore.FolderDefault
        End If
        If DialogResult.OK = ofd.ShowDialog() Then
            txBackupFilePath.Text = ofd.FileName
            ModuleBackupRestore.FolderDefault = IO.Path.GetDirectoryName(txBackupFilePath.Text.Trim())
        End If
    End Sub

    Private Sub txKoneksi_TextChanged(sender As Object, e As EventArgs) Handles txKoneksi.TextChanged
        ModuleBackupRestore.SqldbConnectionString = txKoneksi.Text.Trim()
        WriteSetting(False)
    End Sub

    Private Sub txBackupFilePath_TextChanged(sender As Object, e As EventArgs) Handles txBackupFilePath.TextChanged
        ModuleBackupRestore.TargetFile = txBackupFilePath.Text.Trim()
    End Sub

    Private Sub OpenFile(ByVal file As String)
        If RadPageView1.SelectedPage Is RadPageViewPage5 Then
            tsStatus.Text = "(Tidak Ada File yang dimuat.)"
        Else

        End If
        If file = "" Then
            tsFile.Text = ""
            FastColoredTextBox1.Text = ""
            tsStatus.Text = "(Tidak Ada File yang dimuat.)"
            Return
        End If

        If Not IO.File.Exists(file) Then
            tsFile.Text = ""
            tsStatus.Text = "(File tidak ditemukan.)"
            RadMessageBox.Show("File tidak ditemukan: " & Environment.NewLine &
                               file, "Buka File Sql", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return
        End If
        Try
            tsStatus.Text = "(Mohon Tunggu... Sedang Memuat File Sql...)"
            Me.Refresh()
            Me.SuspendLayout()
            FastColoredTextBox1.Text = IO.File.ReadAllText(file)
            Dim fileLines As String = FastColoredTextBox1.Lines.Count
            Dim alltext As String = IO.File.ReadAllText(file).Length
            tsFile.Text = "" & file & " | Lines: " & fileLines & " | Length: " & alltext
            tsStatus.Text = "File berhasil dimuat."
            Me.ResumeLayout()
        Catch ex As Exception
            RadMessageBox.Show(ex.Message.ToString(), "", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub CommandBarButton1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ofdd As OpenFileDialog = New OpenFileDialog()
        ofdd.RestoreDirectory = True
        ofdd.Title = "Pilih SQL Dump"
        If (ModuleBackupRestore.FolderDefault <> "") Then
            ofdd.InitialDirectory = ModuleBackupRestore.FolderDefault
        End If
        If ofdd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            OpenFile(ofdd.FileName)
        End If
    End Sub

    Private Sub CommandBarButton2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If tsFile.Text = "" Then
            RadMessageBox.Show("Tidak ada file untuk disimpan.")
        End If
        IO.File.WriteAllText(tsFile.Text, FastColoredTextBox1.Text, New UTF8Encoding(False))
        tsStatus.Text = "File berhasil disimpan."
    End Sub

    Private Sub FastColoredTextBox1_TextChanged(sender As Object, e As TextChangedEventArgs) Handles FastColoredTextBox1.TextChanged
        If RadPageView1.SelectedPage Is RadPageViewPage5 Then
            tsStatus.Text = "(Editing...)"
        Else
            tsStatus.Text = ""
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sf As SaveFileDialog = New SaveFileDialog()
        If sf.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            IO.File.WriteAllText(sf.FileName, FastColoredTextBox1.Text, New UTF8Encoding(False))
            tsStatus.Text = "File berhasil disimpan."
            ModuleBackupRestore.FolderDefault = IO.Path.GetDirectoryName(tsFile.Text)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FastColoredTextBox1.Text = ""
        tsStatus.Text = "(Tidak ada File yang dimuat.)"
        tsFile.Text = ""
    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Using conn As MySqlConnection = New MySqlConnection(ModuleBackupRestore.SqldbConnectionString)
            Using cmd As MySqlCommand = New MySqlCommand()
                cmd.Connection = conn
                conn.Open()
                Dim dt As DataTable = QueryExpress.GetTable(cmd, "show tables")
                RadCheckedListBox1.Items.Clear()
                For Each dr As DataRow In dt.Rows
                    RadCheckedListBox1.Items.Add(dr(0) & "")

                Next
            End Using
        End Using
        RadLabel4.Text = "Total Tables: " & RadCheckedListBox1.Items.Count
    End Sub

    Private Sub RadButton4_Click(sender As Object, e As EventArgs) Handles RadButton4.Click
        RadCheckedListBox1.CheckAllItems()
    End Sub

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click
        RadCheckedListBox1.UncheckAllItems()
    End Sub

    Private Sub RadButton6_Click(sender As Object, e As EventArgs) Handles RadButton6.Click
        If Not ModuleBackupRestore.isTargetDirektoriValid() Then
            Return
        End If
        If RadCheckedListBox1.Items.Count = 0 Then
            RadMessageBox.Show("data table > 0 ")
        End If
        Try
            Dim lst As New List(Of String)()
            For Each item As ListViewDataItem In RadCheckedListBox1.CheckedItems
                lst.Add(item.Text.ToString)
            Next
            Using conn As New MySqlConnection(ModuleBackupRestore.SqldbConnectionString)
                Using cmd As New MySqlCommand()
                    Using mb As New MySqlBackup(cmd)
                        cmd.Connection = conn
                        conn.Open()
                        mb.ExportInfo.ExcludeTables = lst
                        mb.ExportToFile(ModuleBackupRestore.TargetFile)
                    End Using
                End Using
            End Using
            RadMessageBox.Show("Berhasil dump sql.", "Backup", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1)
        Catch ex As Exception
            RadMessageBox.Show(ex.Message.ToString, "Backup", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub RadButton7_Click(sender As Object, e As EventArgs) Handles RadButton7.Click
        ExecuteSql()
    End Sub

    Private sqlDT As DataTable = New DataTable

    Private Sub ExecuteSql()
        Try
            'DataGridView1.Rows.Clear()
            'DataGridView1.Columns.Clear()
            RadGridView1.Rows.Clear()
            RadGridView1.Columns.Clear()

            sqlDT = New DataTable
            Dim sqlstring As String = txsqlCommandtext.Text.Trim()
            Dim sqllower As String = sqlstring.ToLower
            Dim isExecution As Boolean = False
            Using conn As New MySqlConnection(ModuleBackupRestore.SqldbConnectionString)
                Using cmd As New MySqlCommand()
                    conn.Open()
                    cmd.Connection = conn
                    If sqllower.StartsWith("select") OrElse sqllower.StartsWith("show") Then
                        cmd.CommandText = sqlstring
                        Dim da As New MySqlDataAdapter(cmd)
                        da.Fill(sqlDT)
                    Else
                        isExecution = True
                        cmd.CommandText = sqlstring
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                        sqlDT.Columns.Add("Result")
                        If rowsAffected < 2 Then
                            sqlDT.Rows.Add(rowsAffected + " row affected by the last command, no resultset returned.")
                        Else
                            sqlDT.Rows.Add(rowsAffected + " rows affected by the last command, no resultset returned.")
                        End If
                    End If
                    conn.Close()
                End Using
            End Using

            For Each dc As DataColumn In sqlDT.Columns
                Dim dgvTB As New DataGridViewTextBoxColumn()
                dgvTB.HeaderText = dc.ColumnName

                'DataGridView1.Columns.Add(dgvTB)

                RadGridView1.Columns.Add(dgvTB.Name, dgvTB.HeaderText)

                RadGridView1.BestFitColumns()

                If isExecution Then
                    dgvTB.Width = 700
                Else
                    dgvTB.Width = RadSpinEditor1.Value
                End If
            Next

            'DataGridView1.RowTemplate.Height = 25

            If sqlDT.Rows.Count > 0 Then

                'DataGridView1.Rows.Add(sqlDT.Rows.Count)

                For Each gridrow As DataRow In sqlDT.Rows
                    RadGridView1.Rows.Add(gridrow)
                Next

                RadGridView1.BestFitColumns()
            End If

            'dataGridView1.ClearSelection()
            RadGridView1.ClearSelection()

        Catch ex As Exception

            'DataGridView1.Rows.Clear()
            'DataGridView1.Columns.Clear()
            RadGridView1.Rows.Clear()
            RadGridView1.Columns.Clear()

            Dim err As String = ex.ToString()
            sqlDT = New DataTable()
            sqlDT.Columns.Add("Error")
            sqlDT.Rows.Add(err)

            'DataGridView1.RowTemplate.Height = 300

            Dim dgvTB As New DataGridViewTextBoxColumn()

            dgvTB.Width = 750
            dgvTB.HeaderText = "Error"

            'DataGridView1.Columns.Add(dgvTB)

            'DataGridView1.Rows.Add(1)

            RadGridView1.Columns.Add(dgvTB.Name)
            RadGridView1.Rows.Add(1)

            'DataGridView1.ClearSelection()
            RadGridView1.ClearSelection()

        End Try
    End Sub

    Private Sub DataGridView1_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs)
        Try
            If e.RowIndex >= sqlDT.Rows.Count Then
                Return
            End If
            If e.ColumnIndex >= sqlDT.Columns.Count Then
                Return
            End If
            If sqlDT.Rows(e.RowIndex)(e.ColumnIndex) = Nothing OrElse TypeOf sqlDT.Rows(e.RowIndex)(e.ColumnIndex) Is DBNull Then
                e.Value = "null"
                Return
            End If
            Dim dttype As Type = sqlDT.Columns(e.ColumnIndex).DataType
            If dttype = GetType(Byte()) Then
                e.Value = "blob/byte[]"
            ElseIf dttype = GetType(DateTime) Then
                e.Value = DirectCast(sqlDT.Rows(e.RowIndex)(e.ColumnIndex), DateTime).ToString("yyyy-MM-dd HH:mm:ss")
            Else
                e.Value = sqlDT.Rows(e.RowIndex)(e.ColumnIndex) & ""
            End If
        Catch ex As Exception
            RadMessageBox.Show("Error" & ex.Message.ToString)
        End Try
    End Sub

    Private Sub RadCheckBox1_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles chExcludedb.ToggleStateChanged
        If args.ToggleState = Enumerations.ToggleState.On Then
            RadPageView1.SelectedPage = RadPageViewPage3
            TableLayoutPanel2.Parent = RadPageViewPage3
            Me.SuspendLayout()
            Call RadButton3_Click(chExcludedb, args)
            Me.ResumeLayout()
        Else
            RadCheckedListBox1.Items.Clear()
        End If
    End Sub

    Private Sub RadGridView1_CellValueNeeded(sender As Object, e As GridViewCellValueEventArgs) Handles RadGridView1.CellValueNeeded
        Try
            If e.RowIndex >= sqlDT.Rows.Count Then
                Return
            End If
            If e.ColumnIndex >= sqlDT.Columns.Count Then
                Return
            End If
            If (sqlDT.Rows(e.RowIndex)(e.ColumnIndex) Is Nothing) OrElse (TypeOf sqlDT.Rows(e.RowIndex)(e.ColumnIndex) Is DBNull) Then
                e.Value = "null"
                Return
            End If
            Dim dttype As Type = sqlDT.Columns(e.ColumnIndex).DataType
            If dttype = GetType(Byte()) Then
                e.Value = "blob/byte[]"
            ElseIf dttype = GetType(DateTime) Then
                e.Value = DirectCast(sqlDT.Rows(e.RowIndex)(e.ColumnIndex), DateTime).ToString("yyyy-MM-dd HH:mm:ss")
            Else
                e.Value = sqlDT.Rows(e.RowIndex)(e.ColumnIndex) & ""
            End If
        Catch ex As Exception
            RadMessageBox.Show("Error" & ex.Message.ToString)
        End Try
    End Sub
End Class
