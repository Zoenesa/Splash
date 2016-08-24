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

        LoadSetting()

        FastColoredTextBox1.Text = ""
        tsFile.Text = ""
        tsStatus.Text = "(Tidak ada File yang dimuat.)"

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

    End Sub

    Private Sub FormAdvancedSqlBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stopWrite = False
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
            tsFile.Text = file
            tsStatus.Text = "File berhasil dimuat."
            Me.ResumeLayout()
        Catch ex As Exception
            RadMessageBox.Show(ex.Message.ToString(), "", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub CommandBarButton1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ofdd As OpenFileDialog = New OpenFileDialog()
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
        tsStatus.Text = "(Editing...)"
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

    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles RadButton3.Click
        Using conn As MySqlConnection = New MySqlConnection(ModuleBackupRestore.SqldbConnectionString)
            Using cmd As MySqlCommand = New MySqlCommand()
                cmd.Connection = conn
                conn.Open()
                Dim dt As DataTable = QueryExpress.GetTable(cmd, "show tables")
                RadCheckedListBox1.Items.Clear()
                For Each dr As DataRow In dt.Rows
                    RadCheckedListBox1.Items.Add(dr(0) & "", False)
                Next
            End Using
        End Using
        RadLabel4.Text = "Total Tables: " & RadCheckedListBox1.Items.Count
    End Sub

    Private Sub RadButton4_Click(sender As Object, e As EventArgs) Handles RadButton4.Click

        RadCheckedListBox1.CheckAllItems()

    End Sub

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click





    End Sub
End Class
