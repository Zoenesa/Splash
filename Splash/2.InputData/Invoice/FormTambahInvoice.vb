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

    Private Shared Sub LoadRefClient(ByVal Optional Opsi As String = "")
        Try
            Using RefConn As MySqlConnection = New MySqlConnection()
                Using cmd As MySqlCommand = New MySqlCommand
                    cmd.CommandText = "SELECT CLIENT_NAME FROM `ref_client` " & Opsi
                    cmd.Connection = mdlCom.vConn
                    'RefConn.Open()
                    Dim sqlreader As MySqlDataReader = cmd.ExecuteReader
                    Do While sqlreader.Read
                        FormTambahInvoice.RadDropDownPelanggan.Items.Add(sqlreader.Item("CLIENT_NAME"))
                    Loop
                    sqlreader.Close()
                End Using
                'RefConn.Close()
            End Using

        Catch ex As Exception

        End Try
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
End Class
