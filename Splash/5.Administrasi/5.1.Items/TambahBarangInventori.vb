Imports Microsoft.VisualBasic.CompilerServices
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls

Public Class TambahBarangInventori

    Private EditMode As Boolean
    Private NamaBarang As String = Nothing

    Public Sub New()

        InitializeComponent()

        Telerik.WinControls.RadMessageBox.Instance.AllowTheming = True
        Telerik.WinControls.RadMessageBox.Instance.ControlBox = False
        Telerik.WinControls.RadMessageBox.ShowInTaskbar = False
        Telerik.WinControls.RadMessageBox.ThemeName = rFormMain.Office2010BlackTheme1.ThemeName

        rFormMain.SetTheme(Me, rFormMain.Office2010BlackTheme1.ThemeName.ToString)
    End Sub

    Public Function BukaFormTambahBarang(ByVal isEdit As Boolean, ByVal NamaItem As String) As DialogResult
        Dim ResultDialogTambahBarang As DialogResult
        Try
            Me.EditMode = isEdit
            Me.NamaBarang = NamaItem
            ResultDialogTambahBarang = MyBase.ShowDialog
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim excep As Exception = ex
            Konektor.mdlSQL.ShowError("Gagal membuka Form Tambah Barang, Error: " & excep.Message)
            ProjectData.ClearProjectError()
        End Try
        Return ResultDialogTambahBarang
    End Function

    Private Sub LoadListSatuan(Optional ByVal Opsi As String = "")
        Dim common As New Konektor.SQLcommon
        Dim dt As New DataTable()
        Dim errmsg As String = ""
        Try

            Dim cmd As String = "INSERT INTO `items_ref` SET "

            If common.LoadTable(errmsg, dt, "datasatuan", "order by `idsatuan`") Then

                Dim num As Integer = 0

                Dim num2 As Integer = dt.Rows.Count - 1

                Dim values As String() = New String(num2) {}

                Do While (num <= num2)

                    Dim descItem As Telerik.WinControls.UI.DescriptionTextListDataItem = New Telerik.WinControls.UI.DescriptionTextListDataItem()

                    Dim dr As DataRow = dt.Rows.Item(num)

                    descItem.Text = dr.Item("satuan")

                    descItem.DescriptionText = dr.Item("namasatuan")

                    comboSatuan.Items.Add(descItem)

                    Threading.Interlocked.Increment(num)

                Loop

                'comboSatuan.ValueMember = "satuan"

            End If

            comboSatuan.Text = ""

        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim excep As Exception = ex
            Konektor.mdlSQL.ShowError("Gagal Load Data Satuan, Error: " & excep.Message)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub SimpanDataBaru(Optional ByVal Opsi As String = "")
        Dim sqlReader As MySqlDataReader = Nothing
        Dim sqlCommand As New MySqlCommand
        Try
            Dim cmd As String = "INSERT INTO `items_ref` SET "
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim excep As Exception = ex
            sqlReader.Close()
            sqlCommand = Nothing
            Konektor.mdlSQL.ShowError("Gagal Menyimpan Data Barang, Error: " & excep.Message)
            ProjectData.ClearProjectError()
        Finally
            sqlReader.Close()
            sqlCommand = Nothing
        End Try
    End Sub

    Private Function CekValue() As Boolean
        Dim errMsg As String = Nothing
        If String.IsNullOrEmpty(RadTextBox8.Text) Or String.IsNullOrWhiteSpace(RadTextBox8.Text) Then
            errMsg = "Tentukan Nama Barang, Tidak Boleh Kosong"
            GoTo LabelPesanError
        End If

        If String.IsNullOrEmpty(comboSatuan.Text) Or String.IsNullOrWhiteSpace(comboSatuan.Text) Then
            errMsg = "Pilih Satuan / Unit Barang, Tidak Boleh Kosong"
            GoTo LabelPesanError
        End If

        If String.IsNullOrEmpty(RadTextBox1.Text) Or String.IsNullOrWhiteSpace(RadTextBox1.Text) Then
            errMsg = "Tentukan Harga Satuan Barang, Tidak Boleh Kosong"
            GoTo LabelPesanError
        End If

LabelPesanError: If errMsg = "" Then
            RadMessageBox.Show(errMsg, "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return False
        End If

        Return True
    End Function
    Private Sub RadButton8_Click(sender As Object, e As EventArgs) Handles RadButton8.Click

    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Me.Close()
    End Sub

    Private Sub TambahBarangInventori_Load(sender As Object, e As EventArgs) Handles Me.Load
        rFormMain.UserSettingIcon(True, Me)
        LoadListSatuan()
        'Dim flag As Boolean
        'Dim errMsg As String = Nothing
        'Dim common As New Konektor.common
        'Dim dt As New DataTable()
        'If Not Me.EditMode Then
        '    flag = False


        'Else
        '    Me.Text = "Ubah Data Barang"
        '    Dim StrCommand As String = "Select"
        '    If common.LoadDataBarang(errMsg, dt, "") Then

        '    Else
        '        Konektor.mdlCom.ShowError(errMsg)
        '    End If
        '    flag = True
        'End If

        'If flag Then
        '    RadMessageBox.Show("Berhasil menambahkan Barang ke Inventori", "", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1)
        'Else
        '    RadMessageBox.Show("Gagal menambahkan Barang, dengan Error" & errMsg, "", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1)
        'End If
    End Sub

End Class