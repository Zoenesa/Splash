Imports Splash.ClassPesan
Imports Telerik, Telerik.WinControls
Imports System, System.Threading, System.Runtime, System.Runtime.InteropServices, System.Runtime.CompilerServices
Imports Microsoft, Microsoft.VisualBasic, Microsoft.VisualBasic.CompilerServices
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class FormBAST
    Private isPilih As Boolean


    Public Function BukaDialogBAST(ByVal ModePilih As Boolean) As DialogResult
        Dim dlg As DialogResult
        Try
            Me.isPilih = ModePilih

            dlg = MyBase.ShowDialog
        Catch ex As Exception

        End Try
        Return dlg
    End Function

    Private Sub LoadClientName(Optional ByVal Opsi As String = "")
        Try
            RadDropDownList1.Items.Clear()
            Dim mysqlcommand As New MySql.Data.MySqlClient.MySqlCommand("SELECT `client_name` FROM `ref_client`;" & Opsi, mdlCom.vConn)
            Dim sqlreader As MySql.Data.MySqlClient.MySqlDataReader

            sqlreader = mysqlcommand.ExecuteReader
            Do While sqlreader.Read
                RadDropDownList1.Items.Add(sqlreader.Item("client_name"))
            Loop
            sqlreader.Close()

        Catch ex As Exception
            Telerik.WinControls.RadMessageBox.Show(ex.Message, "Perhatian", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub FormPerintahKerja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClientName()
        LoadDataBAST()
    End Sub

    Private Sub LoadDataBAST(Optional ByVal Opsi As String = "")
        Try
            RadGridView1.Rows.Clear()
            Dim common As New common
            Dim dt As New DataTable
            Dim errMsg As String = Nothing
            If common.GetDataBAST(errMsg, dt, Opsi) Then
                Dim FieldNames As String() = New String(5 - 1) {}
                Dim num As Integer = (dt.Rows.Count - 1)
                Dim i As Integer = 0
                Do While (i <= num)
                    FieldNames(0) = Conversions.ToInteger(CInt(i + 1))
                    Dim row As DataRow = dt.Rows.Item(i)
                    FieldNames(1) = Conversions.ToString(row.Item("NOBAST"))
                    FieldNames(2) = Conversions.ToString(row.Item("Tanggal"))
                    FieldNames(3) = Conversions.ToString(row.Item("NamaPelanggan"))
                    RadGridView1.Rows.Add(FieldNames)
                    Interlocked.Increment(i)
                Loop
            Else
                mdlCom.ShowWarning(errMsg)
            End If
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim excep As Exception = ex
            mdlCom.ShowError(("Failed(LoadUserData).Message:" & excep.Message))
            mdlCom.INSERTLOG(("Failed(LoadUserData).Message:" & excep.Message), "")
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click

    End Sub

    Private Sub Edit(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgWo_CellContextMenuStripNeeded(sender As Object, e As DataGridViewCellContextMenuStripNeededEventArgs)

    End Sub
End Class
