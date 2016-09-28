Imports System, System.Threading
Imports MySql.Data.MySqlClient
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic, Microsoft.VisualBasic.CompilerServices
Imports Telerik.WinControls
Imports Splash.Konektor.stringSQL
Imports Splash.Konektor

Public Class rFormAddWorkorderRecord

    Private idUser As String
    Private EditMode As Boolean
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Telerik.WinControls.RadMessageBox.Instance.AllowTheming = True
        Telerik.WinControls.RadMessageBox.Instance.ControlBox = False
        Telerik.WinControls.RadMessageBox.ShowInTaskbar = False
        Telerik.WinControls.RadMessageBox.ThemeName = rFormMain.Office2010BlackTheme1.ThemeName
        Dim strTheme As String = rFormMain.Office2010BlackTheme1.ThemeName
        rFormMain.SetTheme(Me, strTheme)

        Me.Size = New Size(771, 300)
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Function Showdlg(Optional ByVal isedit As Boolean = False, Optional ByVal UserEdit As String = "-1") As System.Windows.Forms.DialogResult
        Dim Result As System.Windows.Forms.DialogResult
        Try
            Me.EditMode = isedit
            Me.idUser = UserEdit
            Result = MyBase.ShowDialog
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim Excep As Exception = ex
            mdlSQL.ShowError("Failed to show form.")
            ProjectData.ClearProjectError()
        End Try
        Return Result
    End Function

    Private Sub rFormAddWorkorderRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point((rFormMain.Width / 2) - (Me.Width / 2), (50))

        rFormMain.SetTheme(Me, rFormMain.Office2010BlackTheme1.ThemeName.ToString)
        rFormMain.UserSettingIcon(True, Me)

        If Me.EditMode Then
            Me.Text = "Ubah Record"
            Dim cmn As New SQLcommon
            Dim dt As New DataTable
            Dim errMsg As String = Nothing
            If cmn.getListWO(errMsg, dt, ("WHERE `WO_NO`='" & Me.idUser & "'")) Then
                Dim row As DataRow = dt.Rows.Item(0)
                Me.rTxID.Text = Conversions.ToString(row.Item("ID"))
                Me.rCbClient.Text = Conversions.ToString(row.Item("WO_CLIENTNAME"))
                Me.rWONum.Text = Conversions.ToString(row.Item("WO_NO"))
                Me.rTxMaskDate.Text = Conversions.ToString(row.Item("WO_DATE"))
            Else
                mdlSQL.ShowError(errMsg)
            End If
        Else
            Dim norekam As Integer
            norekam = rFormListWorkOrder.dg.Rows.Count + 1
            rTxID.Text = norekam
        End If
        GetListPelanggan()

        'GetDataItemJobOrder("SELECT `nomor_workorder` AS 'Nomor Job Order', " &
        '                    "`Nama_Barang` AS 'Nama Item/Barang', `kuantitas` AS 'Kuantitas', " &
        '                    "`harga_satuan` AS 'Harga Satuan', `Jumlah_harga` AS 'Jumlah Harga', " &
        '                    "`UserPerekam` AS 'User Perekam', `TanggalRekam` AS 'Tanggal Rekam', " &
        '                    "`UserUpdate` AS 'User Update', `TanggalUpdate` AS 'Tanggal Update' FROM `daftar_item_joborder` WHERE `nomor_workorder` = '" & rWONum.Text.Trim() & "'")
    End Sub

    Private Sub GetListPelanggan(Optional ByVal Opsi As String = "")
        Dim mysqlreader As MySqlDataReader
        Dim sqlCommand As MySqlCommand = New MySqlCommand
        Try
            sqlCommand.CommandText = ("SELECT `Client_Name` FROM `ref_client`")
            sqlCommand.Connection = Konektor.mdlSQL.vConn

            mysqlreader = sqlCommand.ExecuteReader
            Do While mysqlreader.Read
                Dim item As New Telerik.WinControls.UI.RadListDataItem
                rCbClient.Items.Add(New UI.RadListDataItem(mysqlreader.Item("Client_Name")))
            Loop
            mysqlreader.Close()
            sqlCommand = Nothing
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim Excep As Exception = ex
            mysqlreader = Nothing
            sqlCommand = Nothing
            mdlSQL.ShowError("Gagal Mendapatkan Data Pelanggan." & vbNewLine & Excep.Message)
            ProjectData.ClearProjectError()
        Finally
            mysqlreader = Nothing
            sqlCommand = Nothing
        End Try
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Me.cekValue Then
            Me.SavetoDB()
        End If
    End Sub

    Private Function cekValue() As Boolean
        Dim cmn As New SQLcommon
        If rCbClient.Text = "" Then
            RadMessageBox.Show("Client Belum dipilih!", "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            rCbClient.Focus()
            rCbClient.ShowDropDown()
            Return False
        ElseIf rWONum.Text.Trim() = "" Then
            RadMessageBox.Show("Kolom Nomor Workorder belum isi!", "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            rWONum.Focus()
            rWONum.SelectAll()
            Return False
        ElseIf Not cmn.ValidasiTanggal(rTxMaskDate.Text) Then
            RadMessageBox.Show("Format tanggal salah!" & vbNewLine & _
                               "input tanggal dengan format" & Chr(34) & "DD/MM/YYYY" & Chr(34), "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            rWONum.Focus()
            rWONum.SelectAll()
            Return False
        End If
        Return True
    End Function

    Private Sub SavetoDB()
        Try
            If Me.EditMode Then
                If Conversions.ToBoolean(Me.SaveWorkorder(rTxID.Text.Trim, rCbClient.Text.Trim, rWONum.Text.Trim, rTxMaskDate.Text.Trim)) Then
                    rFormListWorkOrder.LoadWorkorder()
                    rFormListWorkOrder.Refresh()
                    RadMessageBox.Show("Record berhasil disimpan!.", "Edit Workorder", MessageBoxButtons.OK, RadMessageIcon.Info)
                    Me.Close()
                Else
                    RadMessageBox.Show("Tidak ada data yang disimpan.", "Workorder", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
                End If
                Exit Sub
            End If
            If Conversions.ToBoolean(Me.SaveWorkorder(rTxID.Text.Trim, rCbClient.Text.Trim, rWONum.Text.Trim, rTxMaskDate.Text.Trim)) Then
                rFormListWorkOrder.LoadWorkorder()
                rFormListWorkOrder.Refresh()
                Beep()
                Dim resul As DialogResult = RadMessageBox.Show("Record berhasil disimpan!." & vbNewLine & "Apakah Anda ingin membuat workorder baru?", "Tambah Workorder", MessageBoxButtons.YesNo, RadMessageIcon.Question)
                If resul = Windows.Forms.DialogResult.Yes Then
                    Dim norekam As Integer
                    norekam = rFormListWorkOrder.dg.Rows.Count + 1
                    rTxID.Text = norekam
                    Me.rTxMaskDate.Text = String.Empty
                    Me.rWONum.Text = ""
                    rCbClient.Text = ""
                    Return
                Else
                    rFormListWorkOrder.LoadWorkorder()
                    Me.Close()
                End If
            Else
                RadMessageBox.Show("Tidak ada data yang disimpan.", "Workorder", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            End If
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim excep As Exception = ex
            mdlSQL.ShowError("Save Failed.Message:" & excep.Message)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Public Function SaveWorkorder(ByVal ID As String, _
                                   ByVal Client As String, _
                                   ByVal Nomor As String, _
                                   ByVal Tanggal As String _
                                   ) As Boolean
        Dim obj As Boolean

        Try
            Dim strCommand As String

            Dim sqlCmd As New MySqlCommand With {.Connection = mdlSQL.vConn}

            If EditMode Then
                strCommand = String.Concat(New String() {"UPDATE `listworkorder` SET `WO_NO` = '", ADD_QUOTE_ON_SQL(rWONum.Text.Trim()), "', `WO_CLIENTNAME` = '", Client, "', `WO_DATE` = '", Tanggal, "', `UserUpdated` = '", mdlSQL.UserLogin, "', `RecordUpdated` = '" & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), "' WHERE `ID` = '", ADD_QUOTE_ON_SQL(ID), "'"})
            Else
                strCommand = String.Concat(New String() {"INSERT INTO `listworkorder` (`ID`, `WO_CLIENTNAME`, `WO_NO`, `WO_DATE`, `UserRecorder`, `DateRecorded`, `UserUpdated`, `RecordUpdated`) " &
                            "VALUES ('", ADD_QUOTE_ON_SQL(ID), "', '",
                            ADD_QUOTE_ON_SQL(Client), "', '",
                            ADD_QUOTE_ON_SQL(Nomor), "', '",
                            ADD_QUOTE_ON_SQL(Tanggal), "', '",
                            ADD_QUOTE_ON_SQL(mdlSQL.UserLogin), "', '",
                            ADD_QUOTE_ON_SQL(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")), "', '",
                            ADD_QUOTE_ON_SQL(mdlSQL.UserLogin), "', '", ADD_QUOTE_ON_SQL(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")), "');"})
            End If
            sqlCmd.CommandText = strCommand
            If (sqlCmd.ExecuteNonQuery > 0) Then
                Return True
            End If
            obj = False
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim excep As Exception = ex
            mdlSQL.ShowError("Save Failed.Message:" & excep.Message)
            obj = False
            ProjectData.ClearProjectError()
            Return obj
            ProjectData.ClearProjectError()
        End Try
        Return obj
    End Function

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Me.Close()
        rFormListWorkOrder.LoadWorkorder()
    End Sub

    Private Sub rCbClient_Leave(sender As Object, e As EventArgs) Handles rCbClient.Leave
        Dim common As New SQLcommon
        Dim errMsg As String = ""
        If rCbClient.Text <> "" Then
            If common.GetCustomerName(errMsg, rCbClient.Text.Trim()) Then
                Return
            Else
                If errMsg = "Nama Pelanggan Belum Terdaftar" Then
                    Beep()
                    Dim Pesan As DialogResult = RadMessageBox.Show(errMsg & vbNewLine &
                                                                   "Apakah Anda ingin Input Pelanggan Baru?" & vbNewLine &
                                                                   "Pilih Button [Yes] untuk Tambah Pelanggan, Pilih Button [No] Keluar", "Perhatian", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button1)
                    If Pesan = DialogResult.Yes Then
                        Dim tambahPelanggan As New rFormTambahCustomer
                        tambahPelanggan.ShowDialog()
                    Else
                        Me.Close()
                    End If
                Else
                    RadMessageBox.Show(errMsg, "Perhatian", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button1)
                End If
            End If
        End If
    End Sub

    Private Sub RadPageView1_SelectedPageChanged(sender As Object, e As EventArgs) Handles RadPageView1.SelectedPageChanged
        If RadPageView1.SelectedPage Is JobOrderPage1 Then
            Me.Size = New Size(771, 300)
        ElseIf RadPageView1.SelectedPage Is JobOrderPage2
            Me.Size = New Size(771, 508)
            GetDataItemJobOrder("SELECT `nomor_workorder` AS 'Nomor Job Order', " &
                           "`Nama_Barang` AS 'Nama Item/Barang', `kuantitas` AS 'Kuantitas', " &
                           "`harga_satuan` AS 'Harga Satuan', `Jumlah_harga` AS 'Jumlah Harga', " &
                           "`UserPerekam` AS 'User Perekam', `TanggalRekam` AS 'Tanggal Rekam', " &
                           "`UserUpdate` AS 'User Update', `TanggalUpdate` AS 'Tanggal Update' " &
                           "FROM `temp_items` WHERE `nomor_workorder` = '" & Me.rWONum.Text.Trim() & "'", " ORDER BY `ID`")
        End If
    End Sub

    Private Sub RadButton9_Click(sender As Object, e As EventArgs) Handles RadButton9.Click
        Dim InputOrderBaru As New FormInputItemOrder
        InputOrderBaru.DialogInputItemOrder(rWONum.Text.Trim())
        InputOrderBaru.Dispose()
        InputOrderBaru = Nothing
        GetDataItemJobOrder("SELECT `nomor_workorder` AS 'Nomor Job Order', " &
                            "`Nama_Barang` AS 'Nama Item/Barang', `kuantitas` AS 'Kuantitas', " &
                            "`harga_satuan` AS 'Harga Satuan', `Jumlah_harga` AS 'Jumlah Harga', " &
                            "`UserPerekam` AS 'User Perekam', `TanggalRekam` AS 'Tanggal Rekam', " &
                            "`UserUpdate` AS 'User Update', `TanggalUpdate` AS 'Tanggal Update' " &
                            "FROM `temp_items` WHERE `nomor_workorder` = '" & Me.rWONum.Text.Trim() & "'", " ORDER BY `ID`")
    End Sub

    Private Sub GetDataItemJobOrder(ByVal QueryCommand As String, ByVal Optional Opsi As String = "")
        Dim sqlAdapter As MySqlDataAdapter = Nothing
        Dim sqlcommand As New MySqlCommand
        Dim errmsg As String = Nothing
        Dim dt As New DataTable
        Dim common As New Konektor.SQLcommon

        Try
            'dgItem.Rows.Clear()
            'dgItem.Columns.Clear()

            If common.sql_Custom_Query(errmsg, QueryCommand, dt, Opsi) Then
                dgItem.DataSource = dt
            Else
                mdlSQL.ShowError("Gagal Mendapatkan Data Item Order, Message: " & errmsg)
            End If
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim excep As Exception = ex
            mdlSQL.ShowError("Gagal Mendapatkan Data Item Order, Message: " & excep.Message)
            ProjectData.ClearProjectError()
        End Try
    End Sub

End Class