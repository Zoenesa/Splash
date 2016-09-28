Imports Microsoft.VisualBasic.CompilerServices
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls

Public Class FormInputItemOrder

    Private Sub RadTextBox8_Leave(sender As Object, e As EventArgs) Handles RadTextBox8.Leave
        'If String.IsNullOrEmpty(RadTextBox2.Text.Trim()) Then
        '    RadMessageBox.Show("")
        'End If
        'Dim common As New Konektor.common
        'Dim errmsg As String = Nothing
        'Dim dt As New DataTable()
        'If common.LoadTable(errmsg, dt, "") Then

        'Else
        '    Beep()
        '    Dim pesan As DialogResult = RadMessageBox.Show("")

        '    If pesan = DialogResult.Yes Then

        '    Else

        '    End If
        'End If

    End Sub

    Private Sub RadTextBox2_Leave(sender As Object, e As EventArgs) Handles RadTextBox2.Leave

    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click

    End Sub

    ''' <summary>
    ''' Tambah Order Item dari Job Order Pelanggan
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RadButton8_Click(sender As Object, e As EventArgs) Handles RadButton8.Click
        TambahJobOrderItem(NomorOrder, RadTextBox8.Text.Trim(), RadTextBox3.Text.Trim(), RadTextBox1.Text.Trim(), RadTextBox4.Text.Trim())
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Me.Close()
    End Sub


    Private EditMode As Boolean

    Public Function DialogInputItemOrder(ByVal Value As String)
        Dim dlg As DialogResult
        Try
            Me.NomorOrder = Value
            Me.Text += " -- [Nomor Job Order: " & Value & "]"
            dlg = MyBase.ShowDialog()
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim exception As Exception = ex
            Konektor.mdlSQL.ShowError("Gagal.(Buka Form Input Item Job Order). Message : " + exception.Message)
            ProjectData.ClearProjectError()
        End Try
        Return dlg
    End Function

    Private NomorOrder As String
    Private Function TambahJobOrderItem(ByVal IDJoborder As String,
                                        ByVal NamaItem As String,
                                        ByVal Kuantiti As String,
                                        ByVal HargaSatuan As String,
                                        ByVal JumlahHarga As String) As Boolean
        Dim flag As Boolean
        Try
            Dim StrInsert As String = "INSERT INTO `temp_items` (`nomor_workorder`, " &
                "`nama_barang`, `kuantitas`, `harga_satuan`, `jumlah_harga`, `userperekam`, " &
                "`tanggalrekam`, `userupdate`, `tanggalupdate`) VALUES ('" & Konektor.stringSQL.ADD_QUOTE_ON_SQL(IDJoborder) & "', '" &
                Konektor.stringSQL.ADD_QUOTE_ON_SQL(NamaItem) & "','" & Konektor.stringSQL.ADD_QUOTE_ON_SQL(Kuantiti) & "', '" &
                Konektor.stringSQL.ADD_QUOTE_ON_SQL(HargaSatuan) & "', '" & JumlahHarga & "', '" & Konektor.mdlSQL.UserLogin & "', '" &
                DateTime.Now.ToString("dd/mm/yyyy") & "', '" & Konektor.mdlSQL.UserLogin & "', '" & DateTime.Now.ToString("dd/mm/yyyy") & "')"
            flag = New MySqlCommand() With {
                .Connection = Konektor.mdlSQL.vConn,
                .CommandText = (StrInsert)}.ExecuteNonQuery() > 0
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim exception As Exception = ex
            Konektor.mdlSQL.ShowError("Gagal.(Query Tambah Job Order). Message : " + exception.Message)
            Konektor.mdlSQL.INSERTLOG("Gagal.(Query Tambah Job Order). Message : " + exception.Message, "")
            ProjectData.ClearProjectError()
        End Try
        Return flag
    End Function



End Class