Imports Telerik, Telerik.WinControls, Telerik.WinControls.UI
Imports Microsoft.VisualBasic.CompilerServices
Imports MySql.Data.MySqlClient
Imports System.Threading, System.Reflection
Imports System.Text
Imports System.IO

Public Class FormTambahInvoice

    Public Sub New()

        InitializeComponent()

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
        RadDropDownList1.DisplayMember = "WO_NO"

        If common.SqlCustomQuery(errMsg, "SELECT WO_NO FROM `listworkorder` ", dt, "WHERE WO_CLIENTNAME = '" & RadDropDownPelanggan.Text.Trim() & "'" & " ORDER BY ID ASC") Then
            RadDropDownList1.DataSource = dt

            RadDropDownList1.SelectedItem = Nothing
        Else
            mdlCom.ShowWarning(errMsg)
        End If

    End Sub

    Private Sub FormTambahInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRefClient()
    End Sub

    Private Sub RadPageView1_SelectedPageChanged(sender As Object, e As EventArgs) Handles RadPageView1.SelectedPageChanged
        If RadPageView1.SelectedPage Is RadPageViewPage1 Then
            Panel3.Parent = RadPageViewPage1
        End If
        If RadPageView1.SelectedPage Is RadPageViewPage2 Then
            Panel3.Parent = RadPageViewPage2
            LoadPurchaseOrder()
        End If
        If RadPageView1.SelectedPage Is RadPageViewPage3 Then
            Panel3.Parent = RadPageViewPage3
        End If
        If RadPageView1.SelectedPage Is RadPageViewPage4 Then
            Panel3.Parent = RadPageViewPage4
        End If
        RadLabel1.Text = String.Format("{0}", RadPageView1.SelectedPage.Text)
    End Sub

    Private Sub RadPageViewPage2_Paint(sender As Object, e As PaintEventArgs) Handles RadPageViewPage2.Paint

    End Sub

    Private Sub btnTambahSalesOrder_Click(sender As Object, e As EventArgs) Handles btnTambahSalesOrder.Click

    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        If RadPageView1.SelectedPage Is RadPageViewPage1 Then
            RadPageView1.SelectedPage = RadPageViewPage2
            RadButton2.Text = "&Lanjut"
        ElseIf RadPageView1.SelectedPage Is RadPageViewpage2 Then
            RadPageView1.SelectedPage = RadPageViewPage3
            RadButton2.Text = "&Lanjut"
        ElseIf RadPageView1.SelectedPage Is RadPageViewPage3 Then
            RadPageView1.SelectedPage = RadPageViewPage4
            RadButton2.Text = "&Simpan"
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

    Private Sub RadDropDownList1_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles RadDropDownList1.SelectedIndexChanged

    End Sub

    Private Sub RadDropDownList1_SelectedValueChanged(sender As Object, e As EventArgs) Handles RadDropDownList1.SelectedValueChanged
        Dim errmsg As String = Nothing
        Dim common As New common
        Dim dt2 As New DataTable()
        If common.SqlCustomQuery(errMsg, "SELECT WO_DATE FROM `listworkorder` ", dt2, "WHERE WO_NO = '" & RadDropDownList1.Text.Trim() & "'") Then
            Dim dr As DataRow = dt2.Rows.Item(0)

            Dim tgl As String = Conversions.ToDate(dr.Item(0))

            rTanggalSO.Text = tgl
            RadDateTimePickerSO.Text = tgl
        Else
            mdlCom.ShowWarning(errmsg)
        End If
    End Sub
End Class
