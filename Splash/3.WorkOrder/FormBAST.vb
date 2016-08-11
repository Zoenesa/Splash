Public Class FormPerintahKerja
    Private isPilih As Boolean

    Public Function BukaDialogBAST(ByVal ModePilih As Boolean) As DialogResult
        Dim dlg As DialogResult
        Try
            Me.isPilih = ModePilih
            dlg = MyBase.ShowDialog
        Catch ex As Exception

        End Try
        Return dlg
    End Function

    Private Sub FormPerintahKerja_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoadDataBAST(Optional ByVal Opsi As String = "")
        Try
            dgWo.Rows.Clear()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click

    End Sub
End Class
