Imports Telerik, Telerik.WinControls, Telerik.WinControls.UI
Imports Microsoft.VisualBasic.CompilerServices
Imports MySql.Data.MySqlClient
Imports System.Threading, System.Reflection
Imports System.Text
Imports System.IO
Imports Splash.Konektor

Public Class FormTambahInvoice

    Private Const MinW_Size As Integer = 763
    Private Const MinH_Size As Integer = 365
    Private Const MaxW_Size As Integer = 763
    Private Const MaxH_Size As Integer = 525

    Public Sub New()

        InitializeComponent()

        RadPageView1.DefaultPage = RadPageViewPage1

        Telerik.WinControls.RadMessageBox.Instance.AllowTheming = True
        Telerik.WinControls.RadMessageBox.Instance.ControlBox = False
        Telerik.WinControls.RadMessageBox.ShowInTaskbar = False
        Telerik.WinControls.RadMessageBox.ThemeName = rFormMain.Office2010BlackTheme1.ThemeName

        RadLabel1.Text = String.Format("{0}", RadPageView1.SelectedPage.Text)
    End Sub

    Private Sub LoadRefClient(ByVal Optional Opsi As String = "")
        Try
            'RadDropDownPelanggan.Items.Clear()
            Dim errMsg As String = Nothing
            Dim common As New common
            Dim dt As New DataTable()
            RadDropDownPelanggan.DisplayMember = "client_name"
            If common.SqlCustomQuery(errMsg, "SELECT CLIENT_NAME FROM `REF_CLIENT` ", dt, " ORDER BY ID_NUM ASC") Then
                RadDropDownPelanggan.DataSource = dt

                RadDropDownPelanggan.SelectedItem = Nothing
            Else
                mdlCom.ShowWarning(errMsg)
            End If
        Catch ex As Exception
            RadMessageBox.Show(ex.Message, "Kesalahan", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub LoadPurchaseOrder(ByVal Optional Opsi As String = "")
        Dim errMsg As String = Nothing
        Dim common As New common
        Dim dt As New DataTable()
        RadDropDownPO.DisplayMember = "WO_NO"

        If common.SqlCustomQuery(errMsg, "SELECT WO_NO FROM `listworkorder` ", dt, "WHERE WO_CLIENTNAME = '" & RadDropDownPelanggan.Text.Trim() & "'" & " ORDER BY ID ASC") Then
            RadDropDownPO.DataSource = dt

        Else
            mdlCom.ShowWarning(errMsg)
        End If

    End Sub

    Private Sub FormTambahInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rFormMain.SetTheme(Me, rFormMain.Office2010BlackTheme1.ThemeName.ToString)
        rFormMain.LoadIcon(True, Me)

        Me.MinimumSize = New Size(MinW_Size, MinH_Size)
        Me.MaximumSize = New Size(MaxW_Size, MaxH_Size)

        'Me.Width = MinW_Size
        'Me.Height = MinH_Size

        Me.Size = New Size(763, 525)

        LoadRefClient()

    End Sub

    Private Sub RadPageView1_SelectedPageChanged(sender As Object, e As EventArgs) Handles RadPageView1.SelectedPageChanged
        Dim strdetail As String = Nothing
        If RadPageView1.SelectedPage Is RadPageViewPage1 Then
            Me.SuspendLayout()
            Me.Width = MinW_Size
            Me.Height = MinH_Size
            strdetail = "Detail Penerbitan && Penomoran Tagihan"
            Panel3.Parent = RadPageViewPage1
            Me.ResumeLayout()
        ElseIf RadPageView1.SelectedPage Is RadPageViewPage2 Then
            Me.SuspendLayout()
            Me.Width = MinW_Size
            Me.Height = MinH_Size
            Panel3.Parent = RadPageViewPage2
            strdetail = "Detail Penagihan"
            LoadPurchaseOrder()
            Me.ResumeLayout()
        ElseIf RadPageView1.SelectedPage Is RadPageViewPage3 Then
            Me.SuspendLayout()
            Me.Width = MinW_Size
            Me.Height = MinH_Size
            Panel3.Parent = RadPageViewPage3
            strdetail = "Register Sales Order(Purchase Order) && Serah Terima(Hand Over)"
            Me.ResumeLayout()
        ElseIf RadPageView1.SelectedPage Is RadPageViewPage4 Then
            Me.SuspendLayout()
            Me.Width = MaxW_Size
            Me.Height = MaxH_Size
            Panel3.Parent = RadPageViewPage4
            strdetail = "Register Transaksi Item Barang/Jasa"
            Me.ResumeLayout()
        End If
        RadLabel1.Text = String.Format("{0}: {1}", RadPageView1.SelectedPage.Text, strdetail)
    End Sub

    Private Sub RadPageViewPage2_Paint(sender As Object, e As PaintEventArgs) Handles RadPageViewPage2.Paint

    End Sub

    Private Sub btnTambahSalesOrder_Click(sender As Object, e As EventArgs) Handles btnTambahSalesOrder.Click

    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        If RadPageView1.SelectedPage Is RadPageViewPage1 Then
            If ValInv1() Then
                RadPageView1.SelectedPage = RadPageViewPage2
                RadButton2.Text = "&Lanjut"
            End If
        ElseIf RadPageView1.SelectedPage Is RadPageViewPage2 Then
            If ValInv2() Then
                RadPageView1.SelectedPage = RadPageViewPage3
                RadButton2.Text = "&Lanjut"
            End If
        ElseIf RadPageView1.SelectedPage Is RadPageViewPage3 Then
            If ValInv3() Then
                RadPageView1.SelectedPage = RadPageViewPage4
                RadButton2.Text = "&Simpan"
            End If
        End If
    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles RadButton3.Click
        If RadPageView1.SelectedPage Is RadPageViewPage4 Then
            RadPageView1.SelectedPage = RadPageViewPage3
            RadButton2.Text = "&Lanjut"
        ElseIf RadPageView1.SelectedPage Is RadPageViewPage3 Then
            RadPageView1.SelectedPage = RadPageViewPage2
            RadButton2.Text = "&Lanjut"
        ElseIf RadPageView1.SelectedPage Is RadPageViewPage2 Then
            RadPageView1.SelectedPage = RadPageViewPage1
            RadButton2.Text = "&Lanjut"
        End If
    End Sub

    Private Sub RadDropDownList1_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles RadDropDownPO.SelectedIndexChanged

        Dim errmsg As String = Nothing
        Dim common As New common
        Dim dt2 As New DataTable()
        RadDateTimePickerSO.ReadOnly = True
        If common.SqlCustomQuery(errmsg, "SELECT WO_DATE FROM `listworkorder` ", dt2, "WHERE WO_NO = '" & RadDropDownPO.Text.Trim() & "'") Then

            If dt2.Rows.Count > 0 Then
                Dim dr As DataRow = dt2.Rows.Item(0)

                Dim tgl As String = Conversions.ToDate(dr.Item(0))

                rTanggalSO.Text = tgl
                RadDateTimePickerSO.Text = tgl

            End If

        Else
            mdlCom.ShowWarning(errmsg)
        End If
    End Sub

    Private Sub RadDropDownList1_SelectedValueChanged(sender As Object, e As EventArgs) Handles RadDropDownPO.SelectedValueChanged

    End Sub

    Private Function ValInv1() As Boolean
        If Not (RadRadioButton1.IsChecked) Then
            If Not (RadRadioButton2.IsChecked) Then
                RadMessageBox.Show("Pilih Jenis Tagihan (Barang/Jasa)", "Invoice 1", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Return False
            End If
            Return True
        End If
        If rDropInvoiceType.SelectedIndex < 0 Then
            RadMessageBox.Show("Pilih Jenis Tagihan (Baru/Revisi)", "Invoice 1", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return False
        End If
        If RadMaskedEditBox1.Text = "__/__/____" Then
            RadMessageBox.Show("Tentukan Tanggal Invoice" & vbNewLine &
                               "Format (dd/mm/yyyy)", "Invoice 1", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1)
            RadMaskedEditBox1.Focus()
            RadMaskedEditBox1.SelectionStart = 0

            Return False
        End If
        Return True
    End Function

    Private Function ValInv2() As Boolean
        If RadDropDownPelanggan.SelectedIndex < 0 Then
            RadMessageBox.Show("Pilih Data Pelanggan", "Invoice 2", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return False
        End If
        Return True
    End Function

    Private Function ValInv3() As Boolean
        If RadDropDownPO.SelectedIndex < 0 Then
            RadMessageBox.Show("Nomor Purchase Order masih Kosong", "Invoice 3", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return False
        End If
        If RadDropDownHO.SelectedIndex < 0 Then
            RadMessageBox.Show("Identitas Serah terima masih Kosong", "Invoice 3", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return False
        End If
        If String.IsNullOrEmpty(RadTextBoxProgress.Text.Trim()) Or String.IsNullOrWhiteSpace(RadTextBoxProgress.Text.Trim()) Then
            RadMessageBox.Show("Kolom Progress Kosong", "Invoice 3", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return False
        End If
        If String.IsNullOrEmpty(RadTextBoxTermin.Text.Trim()) Or String.IsNullOrWhiteSpace(RadTextBoxTermin.Text.Trim()) Then
            RadMessageBox.Show("Kolom Termin Kosong", "Invoice 3", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return False
        End If
        Return True
    End Function

    Private Function ValInv4() As Boolean

        Return True
    End Function

    Private nfi As System.Globalization.
        NumberFormatInfo = New System.
        Globalization.NumberFormatInfo
    Private Koma As String = Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator

    Private Sub RadTextBoxProgress_Leave(sender As Object, e As EventArgs) Handles RadTextBoxProgress.Leave
        nfi.NumberDecimalSeparator = Koma
        'Dim d As Double = Convert.ToDouble(RadTextBoxProgress.Text.Trim(), nfi)
        'RadTextBoxProgress.Text = Double.Parse(RadTextBoxProgress.Text.Trim, nfi)
    End Sub

    Private Sub RadTextBoxProgress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RadTextBoxProgress.KeyPress
        RadTextBoxProgress.ReadOnly = False
        nfi.NumberDecimalSeparator = ","
        'Dim a As Char = Convert.ToChar(Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
        Dim a As Char = Convert.ToChar(".")
        If e.KeyChar = a Then
            'e.Handled = True
            e.KeyChar = ","
        End If
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Me.Close()
    End Sub

End Class
