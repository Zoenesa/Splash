Imports Telerik, Telerik.WinControls
Imports System, System.Threading, System.Runtime, System.Runtime.InteropServices, System.Runtime.CompilerServices
Imports Microsoft, Microsoft.VisualBasic, Microsoft.VisualBasic.CompilerServices
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Imports Splash.mdlstring
Imports System.Data.Common
Imports Telerik.WinControls.UI.Data
Imports Splash.Konektor

Public Class rFormKonfirmasiPembayaran

    Public Sub New()

        InitializeComponent()

        Telerik.WinControls.RadMessageBox.Instance.AllowTheming = True
        Telerik.WinControls.RadMessageBox.Instance.ControlBox = False
        Telerik.WinControls.RadMessageBox.ShowInTaskbar = False
        Telerik.WinControls.RadMessageBox.ThemeName = rFormMain.Office2010BlackTheme1.ThemeName

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub getInvoiceNo(Optional ByVal opsi As String = "")
        Try
            Dim str As String = ("SELECT `invoiceno`, `invoiceClient` FROM `invoicedata`" & opsi & " ORDER BY `RecordNo`;")
            Using cmd As MySqlCommand = New MySqlCommand()
                cmd.CommandText = str
                cmd.Connection = mdlCom.vConn
                Using sqlreader As MySqlDataReader = cmd.ExecuteReader
                    Dim Values As String() = New String(1) {}
                    If sqlreader.HasRows Then
                        rDropWO.Items.Clear()
                        Do While sqlreader.Read
                            Values(0) = sqlreader.Item("InvoiceNo")
                            Values(1) = sqlreader.Item("InvoiceClient")
                            rDropWO.Items.Add(Values(0)) ' & " | " & Values(1))
                            rDropWO.DescriptionTextMember = "InvoiceClient"
                        Loop
                    End If
                    sqlreader.Close()
                End Using
            End Using
        Catch ex As Exception
            RadMessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub GetClient(Optional ByVal opsi As String = "")
        Dim myreader As MySqlDataReader
        Try
            Dim command As MySqlCommand = New MySqlCommand(("SELECT * FROM `ref_client` " &
                                                            opsi), mdlCom.vConn)

            myreader = command.ExecuteReader
            Dim values As String() = New String(1) {}
            If myreader.HasRows Then
                Do While myreader.Read
                    values(0) = myreader.Item("Client_Name")
                    rCustomer.Items.Add(values(0))
                Loop
            End If
            myreader.Close()
        Catch ex As Exception
            RadMessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub datatableinvoice(Optional ByVal Opsi As String = "")
        Dim sqladapter As MySqlDataAdapter
        Dim sqlcommand As MySqlCommand = New MySqlCommand(("SELECT `invoiceNo`, `invoiceClient` FROM `invoicedata` " & Opsi & " ORDER BY `RecordNo` ASC"))
        Dim dt As New DataTable
        sqlcommand.Connection = mdlCom.vConn
        sqladapter = New MySqlDataAdapter With {.SelectCommand = sqlcommand}

        DirectCast(sqladapter, DbDataAdapter).Fill(dt)

        If dt.Rows.Count > 0 Then
            rDropWO.DisplayMember = dt.Columns(0).ColumnName

            rDropWO.ValueMember = "invoiceno"

            rDropWO.DescriptionTextMember = dt.Columns(1).ColumnName

            rDropWO.DataSource = dt

            rDropWO.PerformLayout()

            rDropWO.Update()
        End If

    End Sub

    Private Sub rFormKonfirmasiPembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rFormMain.SetTheme(Me, rFormMain.Office2010BlackTheme1.ThemeName.ToString)
        rFormMain.LoadIcon(True, Me)
        GetClient()
    End Sub

    Private Sub rCustomer_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles rCustomer.SelectedIndexChanged
        'getInvoiceNo(" WHERE `invoiceClient` = '" & rCustomer.SelectedItem.Text & "'")
        datatableinvoice(" WHERE `invoiceClient` = '" & rCustomer.SelectedItem.Text.Trim() & "'")
    End Sub

End Class