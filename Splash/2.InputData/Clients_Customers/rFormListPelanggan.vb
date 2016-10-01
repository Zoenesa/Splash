Imports Telerik, Telerik.WinControls, Telerik.WinControls.UI
Imports System.Runtime.CompilerServices, System.Windows.Forms, Microsoft.VisualBasic.CompilerServices
Imports System.Threading
Imports System.IO
Imports MySql.Data.MySqlClient
Imports Splash.Konektor

Public Class rFormListPelanggan
    Private ModePilih As Boolean
    Private DataSubjek As String

    Public Function BukaDialogDataPelanggan(ByVal mode As Boolean, ByVal Data As String) As DialogResult
        Dim dlg As DialogResult
        Try
            Me.ModePilih = mode
            Me.DataSubjek = Data
            Me.Text = DataSubjek
            dlg = MyBase.ShowDialog
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim excep As Exception = ex
            mdlSQL.ShowError("Failed to show form." & vbNewLine & ex.Message)
            ProjectData.ClearProjectError()
        End Try
        Return dlg
    End Function

    Public Sub New()
        MyBase.New()

        ParsedAlamat = New List(Of String)

        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub LoadDataPelanggan(Optional ByVal Opsi As String = "")
        Try
            dg.Rows.Clear()
            Dim dt As New DataTable
            Dim errMsg As String = Nothing
            Dim Common As New SQLcommon
            Dim DataField As String() = New String((10 + 1) - 1) {}

            If Common.GetPelangganSupplier(errMsg, dt, Opsi) Then
                Dim num As Integer = (dt.Rows.Count - 1)
                Dim i As Integer = 0
                Do While (i <= num)
                    Dim row As DataRow = dt.Rows.Item(i)
                    DataField(0) = Conversions.ToString(False)
                    DataField(1) = Conversions.ToInteger(CInt(i + 1))
                    DataField(2) = Conversions.ToString(
                        stringSQL.FORMAT_NPWP(
                            row.Item("Client_IdTax")))
                    Dim strAlamat As String
                    DataField(3) = Conversions.ToString(row.Item("client_name"))
                    strAlamat = String.Format("{0};Kel.: {1};Kec.: {2};Kab./Kota: {3};Propinsi.: {4};KodePos: {5}",
                          row.Item("client_address"), row.Item("client_village"), row.Item("client_district"), row.Item("client_city"),
                          row.Item("client_state"), row.Item("client_zipcode"))

                    DataField(4) = Conversions.ToString((strAlamat))
                    DataField(5) = Conversions.ToString((row.Item("client_phone")))
                    DataField(6) = Conversions.ToString((row.Item("client_mail")))
                    DataField(7) = Conversions.ToString(row.Item("UserPerekam"))
                    DataField(8) = Conversions.ToString(row.Item("TanggalRekam"))
                    DataField(9) = Conversions.ToString(row.Item("UserUpdate"))
                    DataField(10) = Conversions.ToString(row.Item("TanggalUpdate"))
                    dg.Rows.Add(DataField)
                    Interlocked.Increment(i)
                Loop
            Else
                mdlSQL.ShowWarning(errMsg)
            End If
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ParseDataField()
        Try
            Dim KolomHeader As String() = New String((9 + 1) - 1) {}
            KolomHeader(0) = "NPWP Pelanggan"
            KolomHeader(1) = "Nama Pelanggan"
            KolomHeader(2) = "Alamat Pelanggan"
            KolomHeader(3) = "Telpon"
            KolomHeader(4) = "Email"
            KolomHeader(5) = "User Perekam"
            KolomHeader(6) = "Tanggal Rekam"
            KolomHeader(7) = "User Update"
            KolomHeader(8) = "Tanggal Update"
            Dim num1 As Integer = 0
            Dim num2 As Integer = (KolomHeader.Length)
            Dim num3 As Integer = num1

            Do While Not (num3 = num2)

                Dim NamaKolom As String = "Field" & Conversions.ToString(num3)
                Dim tempHeader As String = KolomHeader(num3)
                With dg
                    .Columns.Add(("Field" & Conversions.ToString(num3)), (KolomHeader(num3)))
                    .Columns(1).Width = 95
                    .Columns(num3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                End With
                Interlocked.Increment(num3)
            Loop
        Catch ex As Exception
            RadMessageBox.Show("Error, (LoadKolom).Message: " & ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
    End Sub

    Private Sub ParseDataAlamat(ByVal string0 As String)
        Try
            Dim strTemp As String = Nothing
            strTemp = Replace(Replace(Replace(Replace(Replace(
                        string0, "Kab./Kota:", ""),
                        "Propinsi:", ""),
                        "Kec.: ", ""),
                        "Kel.:", ""),
                        "KodePos:", "")
            Dim strAlamat As String() = Strings.Split(strTemp, ";", -1, CompareMethod.Binary)
            ParsedAlamat.AddRange(strAlamat)
        Catch ex As Exception
            RadMessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Shared ParsedAlamat As List(Of String)

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick
        ParsedAlamat.Clear()
        Me.dg.Rows.Item(Me.dg.CurrentRow.Index).Selected = True
        Me.dg.CurrentRow.Cells.Item(0).Value =
            RuntimeHelpers.GetObjectValue(
                Interaction.IIf(
                    Conversions.ToBoolean(
                        Me.dg.CurrentRow.Cells.Item(0).Value), False, True))
        ParseDataAlamat(dg.CurrentRow.Cells.Item(4).Value)
        Dim strMessageDetail As String = ("Alamat: " & ParsedAlamat(0) & vbNewLine &
                           "Kel.: " & ParsedAlamat(1) & vbNewLine &
                           "Kec.: " & ParsedAlamat(2) & vbNewLine &
                           "Kab./Kota: " & ParsedAlamat(3) & vbNewLine &
                           "Propinsi: " & ParsedAlamat(4) & vbNewLine &
                           "KodePos: " & ParsedAlamat(5))
        RadMessageBox.Show("Current Row: " & dg.CurrentRow.Cells.Item(1).Value & ", Nama: " & dg.CurrentRow.Cells.Item(3).Value, "Informasi",
                           MessageBoxButtons.OK, RadMessageIcon.Info, strMessageDetail)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.LoadDataPelanggan()
    End Sub

    Private Sub rFormListPelanggan_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case 113
                Call btnFilter_Click(Me, e)
                Exit Select
            Case 116
                Call btnRefresh_Click(Me, e)
                Exit Select
        End Select
        If (e.Modifiers = Keys.Alt) AndAlso e.KeyCode = Keys.C Then
            Me.DialogResult = System.Windows.Forms.DialogResult.No
            Me.Close()
        End If

    End Sub

    Private Sub rFormListPelanggan_Load(sender As Object, e As EventArgs) Handles Me.Load
        rFormMain.SetTheme(Me, rFormMain.Office2010BlackTheme1.ThemeName.ToString)
        rFormMain.UserSettingIcon(True, Me)
        btnRefresh.Image = spControl.GetImageFromFolder("refresh.png")
        btnFilter.Image = spControl.GetImageFromFolder("Find.png")
        btnBukaFormTambahCustomer.Image = spControl.GetImageFromFolder("Create.png")
        btnEdit.Image = spControl.GetImageFromFolder("Notes.png")
        btnErase.Image = spControl.GetImageFromFolder("Erase.png")
        If Not Me.ModePilih Then
            Me.SuspendLayout()
            Me.Text = "List Data Pelanggan"
            Me.btnBukaFormTambahCustomer.Text = "&Tambah"
            Me.ParseDataField()
            Me.ResumeLayout()
            txFilter.Focus()
        Else
            Me.SuspendLayout()
            Me.Text = "Pilih Data Pelanggan"
            Me.btnBukaFormTambahCustomer.Text = "&Pilih"
            Me.ResumeLayout()
            txFilter.Focus()
        End If
    End Sub

    Private Sub btnBukaFormTambahCustomer_Click(sender As Object, e As EventArgs) Handles btnBukaFormTambahCustomer.Click
        Dim tambah As New rFormTambahCustomer
        tambah.OpenDialog(False, "")
        tambah.Dispose()
        tambah = Nothing
        Me.LoadDataPelanggan()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim editPelanggan As New rFormTambahCustomer
        Dim strEdit As String = dg.CurrentRow.Cells.Item(3).Value
        editPelanggan.OpenDialog(True, strEdit)
        editPelanggan.Dispose()
        editPelanggan = Nothing
        Me.LoadDataPelanggan()
    End Sub

    Private Sub txFilter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txFilter.KeyPress
        Select Case e.KeyChar
            Case Chr(113)
                If txFilter.Focused Then
                    'e.Handled = True
                    Call btnFilter_Click(Me, e)
                Else
                    e.Handled = False
                    Exit Select
                End If
            Case Chr(116)
                If txFilter.Focused Then
                    'e.Handled = True
                    Call btnRefresh_Click(Me, e)
                Else
                    e.Handled = False
                    Exit Select
                End If
            Case Chr(13)
                txFilter.Focus()
                e.Handled = False
                Exit Select
        End Select
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        If txFilter.Text = String.Empty Or (String.IsNullOrWhiteSpace(txFilter.Text)) Then
            Exit Sub
        End If
        LoadDataPelanggan(" WHERE `Client_Name` Like '%" & txFilter.Text.Trim() & "%'")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


End Class