Imports Telerik, Telerik.WinControls
Imports System, System.Threading, System.Runtime, System.Runtime.InteropServices, System.Runtime.CompilerServices
Imports Microsoft, Microsoft.VisualBasic, Microsoft.VisualBasic.CompilerServices
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class rFormTambahCustomer

    Private EditMode As Boolean
    Private strEdit As String

    Private Sub rFormTambahCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rFormMain.SetTheme(Me, rFormMain.Office2010BlackTheme1.ThemeName.ToString)
        rFormMain.LoadIcon(True, Me)
        Try
            If Me.EditMode Then
                Me.Text = "Ubah Data Customer / Supplier"
                Me.btnSave.Text = "&Simpan"
                Dim cmn As New common
                Dim dtCustomers As New DataTable
                Dim errMsg As String = ""
                If cmn.getCustomerSupplier(errMsg, dtCustomers, ("WHERE `Client_Name` = '" & Me.strEdit & "';")) Then
                    Dim row As DataRow = dtCustomers.Rows.Item(0)
                    Me.txName.Text = Conversions.ToString(row.Item("Client_Name"))
                    Me.txNPWP.Text = Conversions.ToString(row.Item("Client_IdTax"))
                    Me.txAlamat.Text = Conversions.ToString(row.Item("Client_AddrTemp"))
                    Me.Propinsi.Text = Conversions.ToString(row.Item("Client_State"))
                    Me.Kabupaten.Text = Conversions.ToString(row.Item("Client_State"))
                    Me.Kecamatan.Text = Conversions.ToString(row.Item("Client_District"))
                    Me.txKodePos.Text = Conversions.ToString(row.Item("Client_Zipcode"))
                    Dim parseTelpon As String() = Strings.Split(Conversions.ToString(row.Item("Client_Phone")), ";", -1, CompareMethod.Binary)
                    Me.txTelpon1.Text = parseTelpon(0).TrimStart("(")
                    Me.txTelpon2.Text = parseTelpon(0).TrimEnd(")")
                    Me.txEmail.Text = Conversions.ToString(row.Item("Client_Mail"))
                    Me.txNomorRecord.Text = Conversions.ToString(row.Item("ID_NUM"))
                Else
                    mdlCom.ShowError(errMsg)
                End If
            Else
                txNomorRecord.ReadOnly = True
                Dim numCount As Integer = rFormListPelanggan.dg.Rows.Count - 1
                txNomorRecord.Text = numCount + 1
                LoadProvince()
            End If
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim excep As Exception = ex
            mdlCom.ShowError("Failed to (load_FuncCustomers).Message: " & ex.Message)
            ProjectData.ClearProjectError()
        End Try
        'LoadProvince()
    End Sub

    Public Function OpenDialog(Optional ByVal isEdit As Boolean = False, Optional ByVal idEdit As String = "") As DialogResult
        Dim Result As DialogResult
        Try
            Me.EditMode = isEdit
            Me.strEdit = idEdit
            Result = MyBase.ShowDialog
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim excep As Exception = ex
            mdlCom.ShowError("Failed to show form." & vbNewLine & ex.Message)
            ProjectData.ClearProjectError()
        End Try
        Return Result
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim strAlamat As String
        Dim strJalan As String = txAlamat.Text.Trim()
 
        Dim strTelpon As String = "(" & txTelpon1.Text.Trim() & " " & txTelpon2.Text.Trim() & ")"
        strAlamat = String.Format("{0};Kel.0: {1};Propinsi: {2};Kec.: {3};Telpon.: {4};KodePos: {5};email: {6}",
                                  strJalan, Kabupaten.Text.Trim(), Propinsi.Text.Trim(),
                                  Kecamatan.Text.Trim(), strTelpon, txKodePos.Text.Trim(), txEmail.Text.Trim())


    End Sub

    Private Function CekInputData() As Boolean
        Dim flag As Boolean
        If txNPWP.Text.Trim = "" Then

            Return False

        End If
        Return flag
    End Function
    Private Sub SimpanDataCustomer(ByVal alamat As String, ByVal strTelpon As String)
        Dim common As New common
        Dim errMsg As String = ""
        Dim flag As Boolean
        If Not Me.EditMode Then
            Dim RecordNo As String = ""
            RecordNo = txNomorRecord.Text
            Dim strnpwp As String = (Replace(Replace(txNPWP.Text, ".", "", 1, -1, CompareMethod.Binary), "-", "", 1, -1, CompareMethod.Binary))
            flag = common.TambahCustomerSupplier(txNomorRecord, strnpwp,
                                                 txName.Text.Trim(), txAlamat.Text.Trim(),
                                                 Propinsi.Text.Trim(), Kabupaten.Text.Trim(),
                                                 Kecamatan.Text.Trim(), txTelpon1.Text.Trim(),
                                                 txKodePos.Text.Trim())
        Else
            flag = common.UpdatePelangganSupplier(txNomorRecord.Text, txName.Text.Trim(),
                                                 Replace(Replace(txNPWP.Text, ".", "", 1, -1, CompareMethod.Binary), "-", "", 1, -1, CompareMethod.Binary),
                                                 txAlamat.Text.Trim(), Kabupaten.Text.Trim(), Propinsi.Text.Trim(), Kecamatan.Text.Trim(), "Kelurahan", txKodePos.Text.Trim(),
                                                 strTelpon, txEmail.Text.Trim())
        End If
        If flag Then
            mdlCom.ShowInfo("Sukses menambahkan data Pelanggan baru.")
        Else
            mdlCom.ShowError("Tidak dapat menambahkan Pelanggan baru.")
        End If
    End Sub

    Private Sub LoadProvince(Optional ByVal Opsi As String = "")
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

    Private Sub LoadResidence(Optional ByVal Opsi As String = "")
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
            ProjectData.SetProjectError(ex)
            Dim excep As Exception = ex
            mdlCom.ShowError(("Failed(LoadResidences).Message:" & excep.Message))
            mdlCom.INSERTLOG(("Failed(LoadResidences).Message:" & excep.Message), "")
            ProjectData.ClearProjectError()
            Return
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub LoadDistricts(Optional ByVal Opsi As String = "")
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
            ProjectData.SetProjectError(ex)
            Dim excep As Exception = ex
            mdlCom.ShowError(("Failed(LoadResidences).Message:" & excep.Message))
            mdlCom.INSERTLOG(("Failed(LoadResidences).Message:" & excep.Message), "")
            ProjectData.ClearProjectError()
            Return
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub Propinsi_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles Propinsi.SelectedIndexChanged
        LoadResidence("WHERE `province_id` = " & Propinsi.SelectedValue & "")
    End Sub

    Private Sub Kabupaten_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles Kabupaten.SelectedIndexChanged
        LoadDistricts("WHERE `regency_id` = " & Kabupaten.SelectedValue & "")
    End Sub
     
End Class