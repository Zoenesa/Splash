Imports Microsoft.VisualBasic.CompilerServices
Imports MySql.Data.MySqlClient

Public Class rFormDaftarBarang

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Dim tambahbarangbaru As New TambahBarangInventori
        tambahbarangbaru.ShowDialog()
        LoadDataInventori()
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click

    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles RadButton3.Click

    End Sub

    Private Sub RadButton4_Click(sender As Object, e As EventArgs) Handles RadButton4.Click
        Me.Close()
    End Sub

    Private Sub rFormDaftarBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rFormMain.UserSettingIcon(True, Me)
        LoadDataInventori()
    End Sub

    Private Sub LoadDataInventori(Optional ByVal Opsi As String = "")
        Dim sqlAdapter As New MySqlDataAdapter

        Dim dt As New DataTable

        Dim command As New MySqlCommand

        Try
            command.CommandText = "SELECT `ITMCOL_CODE` AS 'KODE BARANG', `ITMCOL_DESCRIPTIONS` AS 'DESKRIPSI NAMA BARANG', " &
                        "`ITMCOL_QTY` AS 'KUANTITAS', `USERPEREKAM` AS 'USER PEREKAM', `TANGGALREKAM` AS 'TANGGAL REKAM', " &
                        "`USERUPDATE` AS 'USER UPDATE', `TANGGALUPDATE` AS 'TANGGAL UPDATE' FROM `ITEMS_REF`" & Opsi
            command.Connection = Konektor.mdlCom.vConn
            sqlAdapter.SelectCommand = command
            DirectCast(sqlAdapter, MySqlDataAdapter).Fill(dt)
            dgItem.DataSource = dt
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim excep As Exception = ex

            Konektor.mdlCom.ShowError("Gagal Load Data Barang, Error: " & excep.Message)
            ProjectData.ClearProjectError()
        End Try
    End Sub
End Class