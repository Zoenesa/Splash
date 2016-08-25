Imports System, System.Collections.Generic
Imports Telerik, Telerik.WinControls, Telerik.WinControls.UI
Imports Microsoft.VisualBasic.CompilerServices
Imports MySql.Data.MySqlClient
Imports System.Threading, System.Reflection, System.Windows.Forms
Imports System.Text
Imports System.IO

Public NotInheritable Class ModuleBackupRestore

    Private Shared _connString As String = Nothing

    Public Sub New()

        Telerik.WinControls.RadMessageBox.Instance.AllowTheming = True
        Telerik.WinControls.RadMessageBox.Instance.ControlBox = False
        Telerik.WinControls.RadMessageBox.ShowInTaskbar = False
        Telerik.WinControls.RadMessageBox.ThemeName = rFormMain.Office2010BlackTheme1.ThemeName

    End Sub


    Public Shared Property SqldbConnectionString As String
        Get
            If String.IsNullOrEmpty(_connString) Then
                Throw New Exception("Koneksi String Kosong.")
            Else
                Return _connString
            End If
        End Get
        Set(value As String)
            _connString = value
        End Set
    End Property

    Public Shared FolderDefault As String = Nothing
    Public Shared TargetFile As String = ""

    Public Shared Function isTargetDirektoriValid() As Boolean
        Try
            Dim dir As String = IO.Path.GetDirectoryName(ModuleBackupRestore.TargetFile)
            If Not (IO.Directory.Exists(dir)) Then
                IO.Directory.CreateDirectory(dir)
            End If
            Return True
        Catch ex As Exception
            RadMessageBox.Show("Error." & ex.Message.ToString, "Error", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End Try
    End Function

    Public Shared Function isSourceFileExists() As Boolean
        If Not System.IO.File.Exists(ModuleBackupRestore.TargetFile) Then
            RadMessageBox.Show("File tidak ditemukan. Tekan [Pilih File] untuk memilih file SQL Dump." & Environment.NewLine _
                            & Environment.NewLine & ModuleBackupRestore.TargetFile, "Import", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1)
            Return False
        End If
        Return True
    End Function

End Class
