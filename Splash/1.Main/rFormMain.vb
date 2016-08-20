Imports Telerik, Telerik.WinControls, Telerik.WinControls.UI
Imports Microsoft.VisualBasic.CompilerServices
Imports MySql.Data.MySqlClient
Imports System.Threading
Imports System.Text

Public Class rFormMain

    Public Shared tempForm As Form


    Public Sub New()

        InitializeComponent()

        Telerik.WinControls.RadMessageBox.Instance.AllowTheming = True
        Telerik.WinControls.RadMessageBox.Instance.ControlBox = False
        Telerik.WinControls.RadMessageBox.ShowInTaskbar = False
        Telerik.WinControls.RadMessageBox.ThemeName = Me.Office2010BlackTheme1.ThemeName

        Me.Logout()
    End Sub

    Public Sub KeluarAplikasi()
        Dim errMsg As String = ""
        Try
            If mdlCom.CloseDb(errMsg) Then
                KeluarAplikasi()
            ElseIf RadMessageBox.Show("Gagal menutup koneksi database." & errMsg & vbNewLine & "Apakah anda tetap keluar?", "Konfirmasi", MessageBoxButtons.OKCancel, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) <> Windows.Forms.DialogResult.OK Then
                KeluarAplikasi()
            End If
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim num As Integer = DirectCast(RadMessageBox.Show("Error." & ex.Source, "Error", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1, ex.Message), Integer)
        End Try
    End Sub

    Public Sub BukaPilihanKoneksi()
        If mdlCom.IsLogin Then
            Beep()
            If (RadMessageBox.Show("Dengan Memilih database lain, session ini akan otomatis logout," & vbNewLine & "Apakah anda ingin logout?", "Perhatian", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes) AndAlso Me.Logout Then
                Dim formPilih As New rFormInisialisasiKoneksi
                If (formPilih.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                    Me.SetMenu()
                End If
                formPilih.Dispose()
                formPilih = Nothing
            End If
        ElseIf (My.Forms.rFormInisialisasiKoneksi.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Me.SetMenu()
        End If
    End Sub

    Private Sub SetMenu()
        Dim FormLogin As New rFormLogin
        Dim num As Integer = CInt(FormLogin.ShowDialog())
        FormLogin.Dispose()
        FormLogin = Nothing
        If (num = 1) Then
            Me.EnableMenu(True, False)
        ElseIf (num = 6) Then
            Me.EnableMenu(True, True)
        Else
            Me.EnableMenu(False, False)
        End If
    End Sub

    Private Sub EnableMenu(ByVal flag As Boolean, Optional ByVal noProfile As Boolean = False)
        If Not noProfile Then
            Me.Text = "Splash Database"
            rMenuLogout.Enabled = flag
            rMenuSetingdb.Enabled = flag
            rMenuInvoiceItem.Enabled = flag
            rMenuPurchase.Enabled = flag
            rMenuWorkSalesOrder.Enabled = flag
            rMenuDataProject.Enabled = flag
            rMenuResumeOrder.Enabled = flag
            rMenuItemBarang.Enabled = flag
            rMenuRefCustomer.Enabled = flag
            rMenuAdministrasi.Enabled = flag
            rMenuInputData.Enabled = flag
            rDataTeknis.Enabled = flag
        Else
            rMenuLogout.Enabled = flag


        End If
        mdlCom.IsLogin = flag
    End Sub

    Private Function Logout() As Boolean
        If Me.MdiChildren.Length > 0 Then
            RadMessageBox.Show("Masih ada Form terbuka!", "Logout", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return False
        End If
        Dim errMsg As String = ""
        If mdlCom.CloseDb(errMsg) Then
            Me.EnableMenu(False, False)
            Return True
        End If
        Dim num As Integer = DirectCast(RadMessageBox.Show("Gagal menutup koneksi database" & errMsg, "Logout", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1), Integer)
        Return False
    End Function

    Public Shared Sub BukaFormChild(ByVal ChildForm As Form)
        With ChildForm
            .MdiParent = rFormMain
            .Show()
        End With
    End Sub

    Public Shared Sub BukaFormDialog(ByRef rForm As Form)
        rForm = New Form
        With rForm
            .ShowDialog()
        End With
    End Sub

    Public Shared Sub SetTheme(ByVal sControl As Control, ByVal sTheme As String)
        Try
            sTheme = rFormMain.Office2010BlackTheme1.ThemeName
            Dim iRadControl As IComponentTreeHandler = _
                TryCast(sControl, IComponentTreeHandler)
            If iRadControl IsNot Nothing Then
                iRadControl.ThemeName = sTheme
            End If
            For Each sChild As Control In sControl.Controls
                SetTheme(sChild, sTheme)
            Next
        Catch ex As Exception
            RadMessageBox.Show("Could not load setup theme :" & vbNewLine _
                                               & ex.Source & vbNewLine & "Click &Details for more Information", _
                                               "Error", MessageBoxButtons.OK, RadMessageIcon.Error, ex.Message)
        End Try
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        StatusVersi.Text = ""
        StatusVersi.Text = My.Application.Info.Title.ToString & " V" & My.Application.Info.Version.ToString
        RadDateAndTimeStatus.Text = DateTime.Now.ToString("dddd, dd-MM-yy")
        Call rMenuKoneksiDb_Click(Me, e)
        Timer1.Start()
        RadDateTimePicker1.Text = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Web_Update.Main()
    End Sub

    Private Sub rMenuKoneksiDb_Click(sender As Object, e As EventArgs) Handles rMenuKoneksiDb.Click
        BukaPilihanKoneksi()
    End Sub

    Private Sub rMenuSetingdb_Click(sender As Object, e As EventArgs) Handles rMenuSetingdb.Click
        rFormMain.tempForm = rFormDatabaseSetup
        If (mdlCom.V_Role(3) <> "1") Then
            If (Not mdlCom.UserRole = "Administrator") Then
                RadMessageBox.Show("Hanya ADMINISTRATOR yang berhak mengakses menu ini.", "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
                Exit Sub
            End If
            Beep()
            Dim Result As DialogResult = RadMessageBox.Show("Anda memerlukan Permission dari Administrator!" & vbNewLine & _
                                                            "Dengan memilih Yes, Silahkan hubungi Administrator untuk input Permission" & vbNewLine _
                                                            & "Pilih No untuk membatalkan", "Perhatian", MessageBoxButtons.OKCancel, RadMessageIcon.Question, MessageBoxDefaultButton.Button2)
            If Result = Windows.Forms.DialogResult.Cancel Then
                Return
            Else
                Dim rShowPermission As New rFormPermission
                rShowPermission.ShowDialog()
            End If
        Else
            rFormMain.BukaFormChild(rFormDatabaseSetup)
        End If
    End Sub

    Private Sub rMenuExit_Click(sender As Object, e As EventArgs) Handles rMenuExit.Click
        Application.Exit()
    End Sub

    Private Sub rMenuInvoiceItem_Click(sender As Object, e As EventArgs) Handles rMenuInvoiceItem.Click
        If (mdlCom.JobDesk = "Administrator") Or (mdlCom.JobDesk = "Pemasaran") Or (mdlCom.JobDesk = "Superuser") Or (mdlCom.UserRole = "Administrator") Then
            BukaFormChild(rFormDataListInvoice)
        Else
            RadMessageBox.Show("Anda tidak berhak mengakses Menu ini!", "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If
    End Sub

    Private Sub rUpdate_Click(sender As Object, e As EventArgs) Handles rUpdate.Click
        Web_Update.Main()
    End Sub

    Private Sub rMenuLogout_Click(sender As Object, e As EventArgs) Handles rMenuLogout.Click
        If Me.Logout Then
            Me.IsMdiContainer = False
        End If
    End Sub

    Private Sub rMenuImportInvoiceItem_Click(sender As Object, e As EventArgs) Handles rMenuImportInvoiceItem.Click
        rFormMain.tempForm = rFormImport
        If Not (mdlCom.UserRole = "Administrator") Then
            Dim Result As DialogResult = RadMessageBox.Show("Anda memerlukan Permission dari Administrator!" & vbNewLine & _
                                                                       "Dengan memilih Yes, Silahkan hubungi Administrator untuk input Permission" & vbNewLine _
                                                                       & "Pilih No untuk membatalkan", "Perhatian", MessageBoxButtons.OKCancel, RadMessageIcon.Question, MessageBoxDefaultButton.Button2)
            If Result = Windows.Forms.DialogResult.Cancel Then
                Return
            Else
                Dim rShowPermission As New rFormPermission
                rShowPermission.ShowDialog()
            End If
        Else
            BukaFormChild(rFormImport)
        End If
    End Sub

    Private Sub rMenuExportInvoiceItem_Click(sender As Object, e As EventArgs) Handles rMenuExportInvoiceItem.Click
        Try
            Dim rformexport As New rFormExportCSV
            rformexport.ShowDialog()

        Catch ex As Exception
            RadMessageBox.Show(ex.ToString, "Error Export", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End Try
    End Sub

    Private Sub rMenuCustomerListItem_Click(sender As Object, e As EventArgs) Handles rMenuCustomerListItem.Click
        'BukaFormChild(FrmCustomerReference)
        'BukaFormChild(rFormListPelanggan)
        Dim dataPelanggan As New rFormListPelanggan
        Dim num As Integer = DirectCast(dataPelanggan.BukaDialogDataPelanggan(False, "Pilih Data Pelanggan"), Integer)
        dataPelanggan.Dispose()
        dataPelanggan = Nothing
    End Sub

    Private Sub rMenuImportCustomerItem_Click(sender As Object, e As EventArgs) Handles rMenuImportCustomerItem.Click

    End Sub

    Private Sub rMenuExportCustomerItem_Click(sender As Object, e As EventArgs) Handles rMenuExportCustomerItem.Click

    End Sub

    Private Sub rMenuPurchaseOrderItem_Click(sender As Object, e As EventArgs) Handles rMenuPurchaseOrderItem.Click

    End Sub

    Private Sub rMenuPurchase_Click(sender As Object, e As EventArgs) Handles rMenuPurchase.Click

    End Sub

    Private Sub rMenuImportPurchaseItem_Click(sender As Object, e As EventArgs) Handles rMenuImportPurchaseItem.Click

    End Sub

    Private Sub rMenuExportPurchaseItem_Click(sender As Object, e As EventArgs) Handles rMenuExportPurchaseItem.Click

    End Sub

    Private Sub rMenuWODataItem_Click(sender As Object, e As EventArgs) Handles rMenuSalesOrderItem.Click
        BukaFormChild(rFormListWorkOrder)
    End Sub

    Private Sub rMenuImportWOSPKItem_Click(sender As Object, e As EventArgs) Handles rMenuImportWOSPKItem.Click

    End Sub

    Private Sub rMenuExportWOSPKItem_Click(sender As Object, e As EventArgs) Handles rMenuExportWOSPKItem.Click

    End Sub

    Private Sub rMenuDaftarProjectItem_Click(sender As Object, e As EventArgs) Handles rMenuDaftarProjectItem.Click

    End Sub

    Private Sub rMenuSwitchProjectItem_Click(sender As Object, e As EventArgs) Handles rMenuSwitchProjectItem.Click

    End Sub

    Private Sub rMenuCreatePenawaranItem_Click(sender As Object, e As EventArgs) Handles rMenuCreatePenawaranItem.Click

    End Sub

    Private Sub rMenuItemBarang_Click(sender As Object, e As EventArgs) Handles rMenuItemBarang.Click

    End Sub

    Private Sub rMenuRefCustomer_Click(sender As Object, e As EventArgs) Handles rMenuRefCustomer.Click

    End Sub

    Private Sub rMenuUserDataItem_Click(sender As Object, e As EventArgs) Handles rMenuUserDataItem.Click
        If (Not mdlCom.V_Role(0) = "00") Then
            If (Not mdlCom.UserRole = "Administrator") Then
                RadMessageBox.Show("Hanya ADMINISTRATOR yang berhak mengakses menu ini.", "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
                Exit Sub
            End If
        End If
        BukaFormChild(rFormUsersList)
    End Sub

    Private Sub rMenuChangePassword_Click(sender As Object, e As EventArgs) Handles rMenuChangePassword.Click
        Dim FormUbahPass As New rFormGantiPassword
        FormUbahPass.ShowDialog()
    End Sub

    Private Sub rHelp_Click(sender As Object, e As EventArgs) Handles rHelp.Click

    End Sub

    Private Sub rAppInfo_Click(sender As Object, e As EventArgs) Handles rAppInfo.Click

    End Sub

    Private Sub rMenuDataProject_Click(sender As Object, e As EventArgs) Handles rMenuDataProject.Click

    End Sub

    Private Sub rBackupDatabaseMenuItem_Click(sender As Object, e As EventArgs)
        Dim rFormBackup As New rFormBackupdb
        rFormBackup.ShowDialog()
    End Sub

    Private Sub RadMenuItem1_Click_1(sender As Object, e As EventArgs)
        BukaFormChild(frmImportPartner)
    End Sub

    Private Sub rMenuPembayaran_Click(sender As Object, e As EventArgs) Handles rMenuPembayaran.Click
        If (Not mdlCom.V_Role(0) = "00") Then
            If (Not mdlCom.UserRole = "Administrator") Then
                RadMessageBox.Show("Hanya ADMINISTRATOR yang berhak mengakses menu ini.", "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
                Exit Sub
            End If
        End If
        BukaFormChild(rFormKonfirmasiPembayaran)
    End Sub

    Private Sub RadMenuItemBAST_Click(sender As Object, e As EventArgs) Handles RadMenuItemBAST.Click
        BukaFormChild(FormBAST)
    End Sub

    Private Sub Countersql(ByVal NamaField As String, ByVal tableName As String, Optional ByVal Opsi As String = "")
        Dim sqlCommand As New MySqlCommand
        sqlCommand.CommandText = String.Format("SELECT TABLE_NAME, TABLE_ROWS, CREATE_TIME,  FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = " & Opsi)
        sqlCommand.Connection = mdlCom.vConn
        Dim sqlreader As MySqlDataReader
        sqlreader = sqlCommand.ExecuteReader
        Dim fieldNames As String() = New String(3 - 1) {}
        RadGridView1.Rows.Clear()
        Dim dt As New DataTable
        Do While sqlreader.Read
            fieldNames(0) = sqlreader.Item("TABLE_NAME")
            fieldNames(1) = sqlreader.Item("TABLE_ROWS")
            RadGridView1.Rows.Add(fieldNames)
        Loop
        sqlreader.Close()
    End Sub

    Private Sub getTableSchema(ByVal NamaSchema As String, Optional ByVal Opsi As String = "")
        Dim errmsg As String = Nothing
        Try
            RadGridView1.Rows.Clear()
            Dim dt As New DataTable
            Dim common As New common
            If common.LoadTableSchema(errmsg, dt, NamaSchema, Opsi) Then
                Dim values As String() = New String(2 - 1) {}
                Dim num As Integer = (dt.Rows.Count - 1)
                Dim i As Integer = 0

                Do While (i <= num)
                    Dim row As DataRow = dt.Rows.Item(i)
                    values(0) = Conversions.ToString(row.Item("TABLE_NAME"))
                    values(1) = Conversions.ToString(row.Item("TABLE_ROWS"))
                    Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM " & dt.Rows.Count, mdlCom.vConn)
                    Dim sqlreader As MySqlDataReader
                    sqlreader = cmd.ExecuteReader
                    sqlreader.Read()
                    values(2) = sqlreader.Item("")
                    Interlocked.Increment(i)
                    RadGridView1.Rows.Add(values)
                Loop
            Else
                mdlCom.ShowError(errmsg)
            End If
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolWindow1.Caption = Mid(ToolWindow1.Caption, 2) & Strings.Left(ToolWindow1.Caption, 1)
    End Sub

    Private sList As New List(Of String)
    Private Sub KoleksiDatatable()
        Dim i As Integer = dgcounter.Rows.Count - 1
        Dim num As Integer = 0
        sList.Clear()
        For j As Integer = 0 To i
            Dim str As String = String.Format("Table: {0}, Total Data: {1}, Data Masuk PerTanggal {2}: {3}", dgcounter.Rows(j).Cells(0).Value, dgcounter.Rows(j).Cells(1).Value, RadDateTimePicker1.Text, dgcounter.Rows(j).Cells(2).Value)
            sList.Add(str)
        Next j
    End Sub
    Private Sub LoopCountRowsTables()
        Dim sqlDS As New DataSet
        Dim sqlCmd As New MySqlCommand
        Dim sqlAdapter As MySqlDataAdapter
        Dim dbName As New DataTable
        Dim tables As New DataTable
        Try
            sqlAdapter = New MySqlDataAdapter("SELECT TABLE_NAME, TABLE_ROWS FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = '" _
                                              & mdlstring.ADD_QUOTE_ON_SQL(mdlCom.cDbname) & _
                                              "' AND TABLE_NAME NOT IN('data_customer','districts'," &
                                              "'provinces','datatemp','patch','user','ref_user','databast'," &
                                              "'ref_profile','regencies','villages','temp_subproject','temp_workorder')", mdlCom.vConn)

            sqlAdapter.Fill(dbName)
            Dim num As Integer = dbName.Rows.Count - 1
            Dim i As Integer = 0
            Dim values As String() = New String(3 - 1) {}
            dgcounter.Rows.Clear()
            Do While (i <= num)
                Dim row As DataRow = dbName.Rows.Item(i)
                values(0) = row.Item("table_name")
                values(1) = row.Item("table_rows")
                Dim sqlreader As MySqlDataReader
                Dim StrTable As String = dbName.Rows(i)(0).ToString
                sqlCmd.CommandText = "SELECT COUNT(*) AS HITUNG FROM `" & StrTable & "` WHERE TanggalUpdate = '" & RadDateTimePicker1.Text & "'"
                sqlCmd.Connection = mdlCom.vConn
                sqlreader = sqlCmd.ExecuteReader
                sqlreader.Read()
                values(2) = sqlreader.Item("HITUNG")
                sqlreader.Close()
                Interlocked.Increment(i)
                dgcounter.Rows.Add(values)
            Loop
            dbName.Dispose()
            sqlAdapter.Dispose()
            dgcounter.Columns.Item(2).HeaderText = "Per Tanggal " & RadDateTimePicker1.Text

        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private sBuilderString As String
    Private Sub StrBuilder()
        If sList.Count > 0 Then
            Dim sb As New StringBuilder
            For Each sTemp As String In sList
                sb.Append(sTemp).Append(" ")
            Next
            sBuilderString = sb.ToString
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoopCountRowsTables()
        ToolWindow1.Text = ""
        ToolWindow1.Caption = ""
        KoleksiDatatable()
        StrBuilder()
        ToolWindow1.Caption = sBuilderString

    End Sub

    Private Sub RadMenuItemCompanyProfile_Click(sender As Object, e As EventArgs) Handles RadMenuItemCompanyProfile.Click
        Dim formCompany As New FormProfilPerusahaan
        formCompany.ModeBuka(False)
        formCompany.Dispose()
        formCompany = Nothing
    End Sub
End Class