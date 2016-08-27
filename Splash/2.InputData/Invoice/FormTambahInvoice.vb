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


    End Sub

    Private Shared Sub LoadRefClient(ByVal Optional Opsi As String = "")
        Using RefConn As MySqlConnection = New MySqlConnection()
            Using cmd As MySqlCommand = New MySqlCommand
                cmd.CommandText = "SELECT CLIENT_NAME FROM `ref_client` " & Opsi
                cmd.Connection = mdlCom.vConn
                RefConn.Open()
                Dim sqlreader As MySqlDataReader = cmd.ExecuteReader
                Do While sqlreader.Read
                    FormTambahInvoice.RadDropDownPelanggan.Items.Add(sqlreader.Item("CLIENT_NAME"))
                Loop
                sqlreader.Close()
            End Using
            RefConn.Close()
        End Using
    End Sub

    Private Sub FormTambahInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRefClient()
    End Sub


End Class
