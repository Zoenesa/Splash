Imports Telerik, Telerik.WinControls
Imports System, System.Threading, System.Runtime, System.Runtime.InteropServices, System.Runtime.CompilerServices
Imports Microsoft, Microsoft.VisualBasic, Microsoft.VisualBasic.CompilerServices
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class RFormContoh

    Private Sub btTest_Click(sender As Object, e As EventArgs) Handles btTest.Click
    
    End Sub

    Private Sub LoadPropinsi(Optional ByVal Opsi As String = "")
        Try
            Dim common As New common
            Dim dt As New DataTable
            Dim errMsg As String = ""
            If common.GetPropinsi(errMsg, dt, "") Then

                Propinsi.DataSource = dt
                Propinsi.SuspendLayout()
            End If
            Propinsi.ResumeLayout()
            Propinsi.Text = ""
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim excep As Exception = ex
            mdlCom.ShowError(("Failed(LoadProvinces).Message:" & excep.Message))
            mdlCom.INSERTLOG(("Failed(LoadProvinces).Message:" & excep.Message), "")
            ProjectData.ClearProjectError()
            Return
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub LoadKabupatenKota(Optional ByVal Opsi As String = "")
        Try
            Dim comon As New common
            Dim dtKab As New DataTable
            Dim errMsg As String = ""
            If comon.GetKabupaten(errMsg, dtKab, Opsi) Then
                Kabupaten.DataSource = dtKab
                Kabupaten.SuspendLayout()
            End If
            Kabupaten.ResumeLayout()
            Kabupaten.Text = ""
        Catch ex As Exception
            RadMessageBox.Show("gagal loaddataregencies, " & ex.ToString)
        End Try
    End Sub

    Private Sub LoadKecamatan(Optional ByVal Opsi As String = "")
        Try
            Dim commonn As New common
            Dim dtKecamatan As New DataTable
            Dim errMsg As String = ""
            If commonn.GetKecamatan(errMsg, dtKecamatan, Opsi) Then
                Kecamatan.DataSource = dtKecamatan
                Kecamatan.SuspendLayout()
            End If
            Kecamatan.ResumeLayout()
            Kecamatan.Text = ""
        Catch ex As MySqlException
            RadMessageBox.Show("gagal loaddatadistricts, " & ex.ToString)
        End Try
    End Sub

    Private Sub Propinsi_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles Propinsi.SelectedIndexChanged
        'Dim strSplit As String() = Strings.Split(Propinsi.Text, "|", )
        'If Propinsi.SelectedItem.Text <> "" Then
        '    LoadDataKabKota("WHERE `provinces_id` = '")
        'End If

        LoadKabupatenKota("WHERE `province_id` = " + Propinsi.SelectedValue + "")

        ' RadTextBox5.Text = Propinsi.SelectedValue
    End Sub

    Private Sub RFormContoh_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadPropinsi()
        'Propinsi.SelectedIndex = Nothing
    End Sub

    Private Sub Kabupaten_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles Kabupaten.SelectedIndexChanged
        LoadKecamatan("WHERE `regency_id` = " & Kabupaten.SelectedValue & "")
    End Sub
End Class
