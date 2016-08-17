Imports MySql.Data.MySqlClient, Microsoft.VisualBasic.CompilerServices
Imports Telerik, Telerik.WinControls, Telerik.WinControls.UI
Imports System.Threading
Imports System.Runtime.CompilerServices

Public Class rFormUsersList

    Private JumRole As Integer
    Private idUserEdit As String

    Private Sub EditDeleteEnable()
        Dim num1 As Integer = 0
        Try
            Me.btnEdit.Enabled = False
            Me.btnErase.Enabled = False
            Dim num2 As Integer = 0
            Dim num3 As Integer = Me.dg.Rows.Count - 1
            Dim index As Integer = 0
            While index <= num3
                If Conversions.ToBoolean(Me.dg.Rows(index).Cells(0).Value) Then
                    System.Threading.Interlocked.Increment(num1)
                    Me.idUserEdit = Conversions.ToString(Me.dg.Rows(index).Cells(2).Value)
                    If num1 > 1 Then
                        Exit While
                    End If
                End If
                System.Threading.Interlocked.Increment(index)
            End While
            Select Case num1
                Case 0
                    Me.btnEdit.Enabled = False
                    Me.btnErase.Enabled = False
                    Me.idUserEdit = "-1"
                    Exit Select
                Case 1
                    Me.btnEdit.Enabled = True
                    Me.btnErase.Enabled = True
                    Exit Select
                Case Else
                    Me.btnEdit.Enabled = False
                    Me.btnErase.Enabled = True
                    Me.idUserEdit = "-1"
                    Exit Select
            End Select
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim exception As Exception = ex
            mdlCom.ShowError("Failed (edit_delete). Message : " + exception.Message)
            mdlCom.INSERTLOG("Failed (edit_delete). Message : " + exception.Message, "")
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Public Sub LoadUserData(Optional ByVal opsi As String = "")
        Try
            Me.EditDeleteEnable()
            Me.dg.Rows.Clear()
            Dim comon As New common
            Dim dt As New DataTable
            Dim errMsg As String = Nothing
            If comon.getUsers(errMsg, dt, opsi) Then
                Dim values As String() = New String(((5 + Me.JumRole) + 1) - 1) {}
                Dim num2 As Integer = (dt.Rows.Count - 1)
                Dim i As Integer = 0
                Do While (i <= num2)
                    values(0) = Conversions.ToString(False)
                    values(1) = Conversions.ToString(CInt((i + 1)))
                    Dim row As DataRow = dt.Rows.Item(i)
                    values(2) = Conversions.ToString(row.Item("Username"))
                    values(5) = row.Item("JobDesk")
                    values(4) = row.Item("UserFName")
                    If Operators.CompareObjectEqual(row.Item("kdgroup"), "00", False) Then
                        values(3) = "Administrator"
                        Dim jumRole As Integer = Me.JumRole
                        Dim j As Integer = 1
                        Do While (j <= jumRole)
                            values((j + 5)) = ChrW(&H221A)
                            Interlocked.Increment(j)
                        Loop
                    Else
                        values(3) = "User"
                        If Operators.CompareObjectEqual(row.Item("nip_user"), "000000000", False) Then
                            Dim num3 As Integer = Me.JumRole
                            Dim k As Integer = 1
                            Do While (k <= num3)
                                values(k + 5) = "X"
                                Interlocked.Increment(k)
                            Loop
                        Else
                            Dim strArr As String() = Strings.Split(Conversions.ToString(row.Item("nip_user")), ";", -1, CompareMethod.Binary)
                            Dim num4 As Integer = Me.JumRole
                            Dim m As Integer = 1
                            Do While (m <= num4)
                                values(m + 5) = Conversions.ToString(Interaction.IIf((strArr(m) = "1"), ChrW(&H221A), "X"))
                                Interlocked.Increment(m)
                            Loop
                        End If
                    End If
                    row = Nothing
                    Me.dg.Rows.Add(values)
                    Interlocked.Increment(i)
                Loop
            Else
                mdlCom.ShowError(errMsg)
            End If
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim excep As Exception = ex
            mdlCom.ShowError(("Failed(LoadUserData).Message:" & excep.Message))
            mdlCom.INSERTLOG(("Failed(LoadUserData).Message:" & excep.Message), "")
            ProjectData.ClearProjectError()
            Return
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Public Sub New()

        Me.JumRole = 9

        InitializeComponent()

        Telerik.WinControls.RadMessageBox.Instance.AllowTheming = True
        Telerik.WinControls.RadMessageBox.Instance.ControlBox = False
        Telerik.WinControls.RadMessageBox.ShowInTaskbar = False
        Telerik.WinControls.RadMessageBox.ThemeName = rFormMain.Office2010BlackTheme1.ThemeName

        rFormMain.SetTheme(Me, rFormMain.Office2010BlackTheme1.ThemeName.ToString)

    End Sub

    Private Sub rFormUsersList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rFormMain.SetTheme(Me, rFormMain.Office2010BlackTheme1.ThemeName.ToString)

        Dim strArray As String() = New String(((Me.JumRole + 1) - 1)) {}
        strArray(0) = "Input Data"
        strArray(1) = "Ubah Data"
        strArray(2) = "Hapus Data"
        strArray(3) = "Buat Resume / Penawaran"
        strArray(4) = "Data Teknis"
        strArray(5) = "Export PDF"
        strArray(6) = "Export Data"
        strArray(7) = "Import Data"
        strArray(8) = "Administrasi Database"
        Dim intRole As Integer = Me.JumRole
        Dim i As Integer = 1
        Do While (i <= intRole)
            Me.dg.Columns.Add(("r" & Conversions.ToString(i)), strArray((i - 1)))
            Me.dg.Columns.Item(i + 5).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            Me.dg.Columns.Item(i + 5).Width = 45
            Me.dg.ColumnHeadersHeight = 65
            Me.dg.Columns.Item(i + 5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Interlocked.Increment(i)
            For Each kolom As DataGridViewColumn In dg.Columns
                If kolom.HeaderText.Contains("Buat Resume / Penawaran") Then
                    kolom.Width = 71
                End If
                If kolom.HeaderText.Contains("Administrasi Database") Then
                    kolom.Width = 95
                End If
            Next
        Loop

        Me.LoadUserData()

        dg.Columns.Add("rTemp", "")
        dg.Columns.Item("rTemp").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim tambah As New rFormTambahUser
        tambah.OpenDialog(False, "-1")
        tambah.Dispose()
        tambah = Nothing
        Me.LoadUserData()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim detail As New rFormTambahUser
        detail.OpenDialog(True, Me.idUserEdit)
        detail.Dispose()
        detail = Nothing
        Me.LoadUserData()
    End Sub

    Private Sub dg_Click(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        Me.dg.Rows.Item(Me.dg.CurrentRow.Index).Selected = True
        Me.dg.CurrentRow.Cells.Item(0).Value =
            RuntimeHelpers.GetObjectValue(
                Interaction.IIf(
                    Conversions.ToBoolean(
                        Me.dg.CurrentRow.Cells.Item(0).Value), False, True))
        Me.EditDeleteEnable()
    End Sub

    'Private Sub dg_Sorted(sender As Object, e As EventArgs) Handles dg.Sorted
    '    Dim num2 As Integer = (Me.dg.Rows.Count - 1)
    '    Dim i As Integer = 0
    '    Do While (i <= num2)
    '        Me.dg.Rows.Item(i).Cells.Item(1).Value = (i + 1)
    '        i += 1
    '    Loop
    'End Sub

    Public Sub SelAllRow(ByVal GridView As DataGridView, ByVal ColumnName As String)
        Dim UnCheckedItems = From Rows In GridView.Rows.Cast(Of DataGridViewRow)() _
                    Where CBool(Rows.Cells(ColumnName).Value) = False
        For Each item In UnCheckedItems
            item.Cells(ColumnName).Value = True
        Next
    End Sub

    Public Sub ClearAllRow(ByVal GridView As DataGridView, ByVal ColumnName As String)
        Dim UnCheckedItems = From Rows In GridView.Rows.Cast(Of DataGridViewRow)() _
                    Where CBool(Rows.Cells(ColumnName).Value) = True
        For Each item In UnCheckedItems
            item.Cells(ColumnName).Value = False
        Next
    End Sub

    Private Sub RadCheckBox1_ToggleStateChanged(sender As Object, args As UI.StateChangedEventArgs) Handles RadCheckBox1.ToggleStateChanged
        If args.ToggleState = Enumerations.ToggleState.On Then
            SelAllRow(dg, "Col1")
            RadCheckBox1.Text = "Clear Selection"
            EditDeleteEnable()
        Else
            RadCheckBox1.Text = "Select All"
            EditDeleteEnable()
            ClearAllRow(dg, "Col1")
        End If
    End Sub

    Private Sub btnErase_Click(sender As Object, e As EventArgs) Handles btnErase.Click
        Beep()
        Dim Result As DialogResult = RadMessageBox.Show("Anda yakin akan menghapus record database dipilih.?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2)
        Try
            If Result = Windows.Forms.DialogResult.Yes Then
                Dim num As Integer = 0
                Dim command As New MySqlCommand With {
                    .Connection = mdlCom.vConn}
                Dim num3 As Integer = (Me.dg.Rows.Count - 1)
                Dim i As Integer = 0
                Do While (i <= num3)
                    If Conversions.ToBoolean(Me.dg.Rows.Item(i).Cells.Item(0).Value) Then
                        Dim str As String = Conversions.ToString(Me.dg.Rows.Item(i).Cells.Item(2).Value)
                        command.CommandText = ("DELETE FROM `user` WHERE `Username` = '" & str & "'")
                        num = (num + command.ExecuteNonQuery)
                    End If
                    i += 1
                Loop
                RadMessageBox.Show(num.ToString & " record berhasil dihapus.", "Hapus Data", MessageBoxButtons.OK, RadMessageIcon.Info)
                Me.LoadUserData()
            End If
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim excep As Exception = ex
            mdlCom.ShowError("Failed (delete_user).Message: " & excep.Message)
            mdlCom.INSERTLOG(("Failed (delete_user).Message: " & excep.Message), "")
            ProjectData.ClearProjectError()
        End Try
    End Sub

End Class