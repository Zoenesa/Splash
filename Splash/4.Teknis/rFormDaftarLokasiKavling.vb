Imports System.Data.Common
Imports System.Threading
Imports Microsoft.VisualBasic.CompilerServices
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls

Public Class rFormDaftarLokasiKavling

    Private ValuHGBENTER As String

    Private Sub GetLoadHGBDropdown(Optional ByVal Opsi As String = "")
        Dim common As New Konektor.SQLcommon
        Dim errmsg As String = ""
        Dim dt As DataTable
        Try
            dt = New DataTable()

            If common.GetNoHGB_Only(errmsg, dt, Opsi) Then

                RadDropDownHGB.DataSource = dt
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub GetLoadDataKavlingDanLokasi(ByVal Optional Opsi As String = "")
        Dim common As New Konektor.SQLcommon
        Dim errmsg As String = ""
        Dim dt As DataTable
        Try
            dt = New DataTable()
            If common.GetDataHGB_dan_Kavling(errmsg, dt, Opsi) Then
                DataGridView1.DataSource = dt
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub rFormInputHGB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetLoadHGBDropdown()
        GetLoadDataKavlingDanLokasi(" Where `datahgb`.`datahgbno` = `datakavling`.`hgb_id` ")
    End Sub

    Private Sub RadDropDownHGB_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles RadDropDownHGB.SelectedIndexChanged
        GetLoadDataKavlingDanLokasi(" Where `datahgb`.`datahgbno` = `datakavling`.`hgb_id` AND `datahgb`.`datahgbno` = '" & RadDropDownHGB.SelectedItem.Text & "'")
    End Sub

    Private Sub RadDropDownKavling_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles RadDropDownKavling.SelectedIndexChanged

    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

    End Sub

    Private Sub RadDropDownHGB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RadDropDownHGB.KeyPress
        Dim errMsg As String = ""
        Select Case e.KeyChar
            Case Chr(13)
                ValuHGBENTER = RadDropDownHGB.Text
                If (RadDropDownHGB.Text IsNot Nothing) Then ValuHGBENTER = RadDropDownHGB.Text
                Dim common As New Konektor.SQLcommon
                If common.isDataHGBOke(errMsg, Me.ValuHGBENTER) Then
                    Beep()
                    Dim result As DialogResult = RadMessageBox.Show("NOMOR HGB di Input tidak ada dalam Daftar!" & vbNewLine &
                                                                    "Input Data HGB Baru?, [Yes] Buka Form Input Baru, [No] untuk batal.", "Informasi",
                                                                    MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button1)
                    If result = DialogResult.Yes Then
                        Dim rformTambahHGB As New rFormTambahHGB
                        rformTambahHGB.BukaDialogFormTambahHGB(False, String.Empty)
                        rformTambahHGB.Dispose()
                        rformTambahHGB = Nothing
                        Me.GetLoadDataKavlingDanLokasi(" Where  datahgb.datahgbno = datakavling.hgb_id" & " " & "AND datahgb.datahgbno = '" & RadDropDownHGB.Text & "'")
                    Else
                        Return
                    End If
                End If
        End Select

    End Sub

End Class