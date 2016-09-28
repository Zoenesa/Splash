Public Class rFormTambahHGB

    Private EditMode As Boolean
    Private ValueHGB As String
    Private IntParseLastRecord As Integer

    Private Sub rFormTambahHGB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.EditMode Then
            Me.Text = "Ubah Nomor HGB"

        Else

        End If
    End Sub

    Public Function BukaDialogFormTambahHGB(ByVal isEdit As Boolean, ByVal IdHGB As String) As DialogResult
        Dim dlg As DialogResult
        Try
            Me.EditMode = isEdit
            Me.ValueHGB = IdHGB
            dlg = MyBase.ShowDialog()
        Catch ex As Exception
            Dim excep As Exception = ex
            Konektor.mdlSQL.ShowError("Failed to show form.")
            dlg = Nothing
        End Try
        Return dlg
    End Function

    Private Sub SimpanDataHGBroDB(Optional ByVal Opsi As String = "")
        Dim common As New Konektor.SQLcommon
        Dim errMsg As String = ""
        If Not Me.EditMode Then

        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim flag As Boolean = False
        If Not Me.EditMode Then
            Dim command As String = ""


        Else


        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class