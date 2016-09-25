Imports Telerik, Telerik.WinControls, Telerik.WinControls.UI
Imports Microsoft.VisualBasic.CompilerServices
Imports MySql.Data.MySqlClient
Imports System.Threading
Imports System.Text
Imports Splash.Konektor

Public Class FormProfilPerusahaan
    Private isEdit As Boolean

    Public Function ModeBuka(ByVal editMode As Boolean) As DialogResult
        Dim dialog As DialogResult
        Try
            Me.isEdit = editMode
            MyBase.ShowDialog()
        Catch ex As Exception

        End Try
        Return dialog
    End Function

    Private List As New List(Of String)

    Private Sub LoadDataCompany(Optional ByVal Opsi As String = "")
        Dim sqlreader As MySqlDataReader
        Dim sqlcmd As New MySqlCommand

        Try
            List.Clear()

            sqlcmd.CommandText = "SELECt * FROM `CompanyProfile` " & Opsi
            sqlcmd.Connection = Konektor.mdlCom.vConn
            sqlreader = sqlcmd.ExecuteReader
            sqlreader.Read()

            List.Add(sqlreader.Item("NamaPerusahaan"))
            List.Add(sqlreader.Item("NPWP"))
            List.Add(sqlreader.Item("AlamatKantor"))
            List.Add(sqlreader.Item("Provinsi"))
            List.Add(sqlreader.Item("Kabupaten"))
            List.Add(sqlreader.Item("Kecamatan"))
            List.Add(sqlreader.Item("Kelurahan"))
            List.Add(sqlreader.Item("Kodepos"))
            List.Add(sqlreader.Item("Email"))
            List.Add(sqlreader.Item("NoTelpon"))

            RadDropDownList1.Items.Add(List.Item(0))

            sqlreader.Close()
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            RadMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub FormProfilPerusahaan_Load(sender As Object, e As EventArgs) Handles Me.Load
        rFormMain.SetTheme(Me, rFormMain.Office2010BlackTheme1.ThemeName.ToString)
        rFormMain.UserSettingIcon(True, Me)
        If Me.isEdit Then
            Me.Text = "Ubah Profil Perusahaan"
            btnSave.Text = "&Simpan"
            LoadDataCompany(" WHERE `NamaPerusahaan` = '" & RadDropDownList1.Text & "'")

        Else
            LoadDataCompany()
            Me.Text = "Profile Perusahaan"
            RadDropDownList1.Enabled = False
            btnSave.Text = "&OK"
            RadDropDownList1.Text = List.Item(0)
            txNPWP.Text = mdlstring.FORMAT_NPWP(List.Item(1))
            RadTextBox1.Text = List.Item(2)
            Propinsi.Text = List.Item(3)
            Kabupaten.Text = List.Item(4)
            Kecamatan.Text = List.Item(5)
            txKodePos.Text = List.Item(7)
            txTelpon1.Text = List.Item(9)
            txEmail.Text = List.Item(8)

        End If
    End Sub
End Class