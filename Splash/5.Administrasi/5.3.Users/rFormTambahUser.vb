Imports Telerik, Telerik.WinControls, Telerik.WinControls.UI
Imports Microsoft.VisualBasic.CompilerServices

Public Class rFormTambahUser
    Private EditMode As Boolean
    Private IdUser As String

    Public Sub New()

        InitializeComponent()

        Telerik.WinControls.RadMessageBox.Instance.AllowTheming = True
        Telerik.WinControls.RadMessageBox.Instance.ControlBox = False
        Telerik.WinControls.RadMessageBox.ShowInTaskbar = False
        Telerik.WinControls.RadMessageBox.ThemeName = rFormMain.Office2010BlackTheme1.ThemeName

        rFormMain.SetTheme(Me, rFormMain.Office2010BlackTheme1.ThemeName.ToString)
    End Sub

    Public Function OpenDialog(Optional ByVal isEdit As Boolean = False, Optional ByVal idEdit As String = "") As DialogResult
        Dim Result As DialogResult
        Try
            Me.EditMode = isEdit
            Me.IdUser = idEdit
            Result = MyBase.ShowDialog
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim excep As Exception = ex
            mdlCom.ShowError("Failed to show form.")
            ProjectData.ClearProjectError()
        End Try
        Return Result
    End Function

    Private Sub EksekusiSimpan()
        If Me.ValPage1 Then
            Me.SimpanUsertodb()
        End If
    End Sub

    Private Sub SimpanUsertodb()
        Dim comon As New common
        Dim errMsg As String = ""
        If (Me.txPassword.Text.Trim() = txKonfirmasi.Text.Trim()) Then
            Dim flag As Boolean
            Dim str2 As String
            If Me.rAdmin.IsChecked Then
                str2 = "00;1;1;1;1;1;1;1;1;1;"
            Else
                str2 = "01;"
                str2 = Conversions.ToString(Operators.ConcatenateObject(
                         Conversions.ToString(Operators.ConcatenateObject(
                         Conversions.ToString(Operators.ConcatenateObject(
                         Conversions.ToString(Operators.ConcatenateObject(
                         Conversions.ToString(Operators.ConcatenateObject(
                         Conversions.ToString(Operators.ConcatenateObject(
                         Conversions.ToString(Operators.ConcatenateObject(
                         Conversions.ToString(Operators.ConcatenateObject(
                         Conversions.ToString(Operators.ConcatenateObject(
                         str2, Operators.ConcatenateObject(Interaction.IIf(Me.chk1.Checked, "1", "0"), ";"))),
                         Operators.ConcatenateObject(Interaction.IIf(Me.chk2.Checked, "1", "0"), ";"))),
                         Operators.ConcatenateObject(Interaction.IIf(Me.chk3.Checked, "1", "0"), ";"))),
                         Operators.ConcatenateObject(Interaction.IIf(Me.chk4.Checked, "1", "0"), ";"))),
                         Operators.ConcatenateObject(Interaction.IIf(Me.chk5.Checked, "1", "0"), ";"))),
                         Operators.ConcatenateObject(Interaction.IIf(Me.chk6.Checked, "1", "0"), ";"))),
                         Operators.ConcatenateObject(Interaction.IIf(Me.chk7.Checked, "1", "0"), ";"))),
                         Operators.ConcatenateObject(Interaction.IIf(Me.chk8.Checked, "1", "0"), ";"))),
                         Operators.ConcatenateObject(Interaction.IIf(Me.chk9.Checked, "1", "0"), ";")))
            End If
            Dim tempPass As String = CodeLibs.CodeMethod.Encrypt_TRIPLEDES(txKonfirmasi.Text.Trim(), mdlstring.defaultKey)
            If Not Me.EditMode Then
                If comon.unameOke(errMsg, Me.txUsername.Text.Trim) Then

                    flag = comon.tambahUname(Me.txUsername.Text.Trim(), tempPass, str2, txUserFname.Text.Trim(), rCbJobdesk.Text.Trim())
                Else
                    mdlCom.ShowWarning("Username sudah terdaftar.")
                End If
            Else
                flag = comon.updateUser(tempPass, Me.txUsername.Text.Trim(), str2)
            End If
            If flag Then
                mdlCom.ShowInfo("Username berhasil disimpan.")
                Me.Close()
            Else
                mdlCom.ShowWarning("Error simpan database.")
            End If
        Else
            mdlCom.ShowWarning("Password dan Konfirmasi harus sama.")
        End If
    End Sub

    Private Sub RadCheckBox1_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chk1.ToggleStateChanged
        If rAdmin.IsChecked = True Then
            If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                rUser.CheckState = CheckState.Checked
            End If
        End If
    End Sub

    Private Sub RadCheckBox2_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chk2.ToggleStateChanged
        If rAdmin.IsChecked = True Then
            If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                rUser.CheckState = CheckState.Checked
            End If
        End If
    End Sub

    Private Sub RadCheckBox3_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chk3.ToggleStateChanged
        If rAdmin.IsChecked = True Then
            If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                rUser.CheckState = CheckState.Checked
            End If
        End If
    End Sub

    Private Sub RadCheckBox7_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chk4.ToggleStateChanged
        If rAdmin.IsChecked = True Then
            If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                rUser.CheckState = CheckState.Checked
            End If
        End If
    End Sub

    Private Sub RadCheckBox6_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chk5.ToggleStateChanged
        If rAdmin.IsChecked = True Then
            If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                rUser.CheckState = CheckState.Checked
            End If
        End If
    End Sub

    Private Sub RadCheckBox4_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chk6.ToggleStateChanged
        If rAdmin.IsChecked = True Then
            If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                rUser.CheckState = CheckState.Checked
            End If
        End If
    End Sub

    Private Sub RadCheckBox5_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chk7.ToggleStateChanged
        If rAdmin.IsChecked = True Then
            If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                rUser.CheckState = CheckState.Checked
            End If
        End If
    End Sub

    Private Sub RadCheckBox8_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chk8.ToggleStateChanged
        If rAdmin.IsChecked = True Then
            If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                rUser.CheckState = CheckState.Checked
            End If
        End If
    End Sub

    Private Sub RadCheckBox9_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chk9.ToggleStateChanged
        If rAdmin.IsChecked = True Then
            If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                rUser.CheckState = CheckState.Checked
            End If
        End If
    End Sub

    Private Sub rUser_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles rUser.ToggleStateChanged
        Dim flag As Telerik.WinControls.Enumerations.ToggleState
        If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
            flag = Telerik.WinControls.Enumerations.ToggleState.On
        Else
            flag = Telerik.WinControls.Enumerations.ToggleState.Off
        End If

        chk1.ToggleState = flag
        chk2.ToggleState = flag
        chk3.ToggleState = flag
        chk4.ToggleState = flag
        chk5.ToggleState = flag
        chk6.ToggleState = flag
        chk7.ToggleState = flag
        chk8.ToggleState = flag
        chk9.ToggleState = flag

    End Sub

    Private Sub rFormTambahUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rFormMain.SetTheme(Me, rFormMain.Office2010BlackTheme1.ThemeName.ToString)
        rFormMain.LoadIcon(True, Me)

        InisialisasiPasswordMeter1.Visible = False
        Try
            If Me.EditMode Then
                Me.Text = "Ubah Data User"
                Me.btnSave.Text = "&Simpan"
                Me.txUsername.ReadOnly = True
                Dim comon As New common
                Dim dt As New DataTable
                Dim errMsg As String = ""
                If comon.getUsers(errMsg, dt, ("WHERE `Username` = '" & IdUser & "'")) Then
                    Dim row As DataRow = dt.Rows.Item(0)
                    Me.txUsername.Text = Conversions.ToString(row.Item("Username"))
                    Me.txPassword.Text = Conversions.ToString(row.Item("Password"))
                    Me.txKonfirmasi.Text = Conversions.ToString(row.Item("Password"))
                    Me.txUserFname.Text = Conversions.ToString(row.Item("UserFname"))
                    Me.txJabatan.Text = mdlCom.UserRole
                    Me.rCbJobdesk.Text = Conversions.ToString(row.Item("JobDesk"))

                    If Operators.CompareObjectEqual(row.Item("kdgroup"), "00", False) Then
                        Me.rAdmin.IsChecked = True
                    Else
                        Me.rAdmin.IsChecked = False
                        If Operators.CompareObjectEqual(row.Item("nip_user"), "000000000", False) Then
                            Me.chk1.Checked = False
                            Me.chk2.Checked = False
                            Me.chk3.Checked = False
                            Me.chk4.Checked = False
                            Me.chk5.Checked = False
                            Me.chk6.Checked = False
                            Me.chk7.Checked = False
                            Me.chk8.Checked = False
                            Me.chk9.Checked = False
                        Else
                            Dim strArray As String() = Strings.Split(Conversions.ToString(row.Item("nip_user")), ";", -1, CompareMethod.Binary)
                            Me.chk1.Checked = Conversions.ToBoolean(Interaction.IIf((strArray(1) = "0"), False, True))
                            Me.chk2.Checked = Conversions.ToBoolean(Interaction.IIf((strArray(2) = "0"), False, True))
                            Me.chk3.Checked = Conversions.ToBoolean(Interaction.IIf((strArray(3) = "0"), False, True))
                            Me.chk4.Checked = Conversions.ToBoolean(Interaction.IIf((strArray(4) = "0"), False, True))
                            Me.chk5.Checked = Conversions.ToBoolean(Interaction.IIf((strArray(5) = "0"), False, True))
                            Me.chk6.Checked = Conversions.ToBoolean(Interaction.IIf((strArray(6) = "0"), False, True))
                            Me.chk7.Checked = Conversions.ToBoolean(Interaction.IIf((strArray(7) = "0"), False, True))
                            Me.chk8.Checked = Conversions.ToBoolean(Interaction.IIf((strArray(8) = "0"), False, True))
                            Me.chk9.Checked = Conversions.ToBoolean(Interaction.IIf((strArray(9) = "0"), False, True))
                        End If
                    End If
                    row = Nothing
                Else
                    mdlCom.ShowError(errMsg)
                End If
            End If
        Catch ex As Exception
            ProjectData.SetProjectError(ex)
            Dim excep As Exception = ex
            mdlCom.ShowError("Failed to (load_form).Message: " & ex.Message)
            ProjectData.ClearProjectError()
        End Try
        Try
            rCbJobdesk.Items.Clear()
            rCbJobdesk.Items.AddRange({"Operator", "Admin", "Manager"})
        Catch ex As Exception
            RadMessageBox.Show("Failed (Jobdesk-AddRange).Message: " & ex.Message, "Administrasi User", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End Try
    End Sub

    Private Function ValPage1() As Boolean
        If txUsername.Text.Trim() = "" Then
            RadMessageBox.Show("Kolom Username Kosong.", "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            txUsername.Focus()
            txUsername.SelectAll()
            Return False
        End If
        If txPassword.Text.Trim() = "" Then
            RadMessageBox.Show("Kolom Password tidak boleh Kosong.", "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            txPassword.Focus()
            txPassword.SelectAll()
            Return False
        End If
        If txKonfirmasi.Text.Trim() = "" Then
            RadMessageBox.Show("Kolom Konfirmasi tidak boleh Kosong.", "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            txKonfirmasi.Focus()
            txKonfirmasi.SelectAll()
            Return False
        End If
        If Not (txKonfirmasi.Text.Trim() = txPassword.Text.Trim()) Then
            RadMessageBox.Show("Kolom Password & Konfirmasi tidak sama.", "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            txKonfirmasi.Focus()
            txKonfirmasi.SelectAll()
            Return False
        End If
        If rCbJobdesk.Text.Trim() = "" Then
            RadMessageBox.Show("Kolom Job Desk belum dipilih.", "Perhatian", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            rCbJobdesk.Focus()
            rCbJobdesk.ShowDropDown()
            Return False
        End If
        Return True
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        EksekusiSimpan()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txKonfirmasi_TextChanged(sender As Object, e As EventArgs) Handles txKonfirmasi.TextChanged
        If txKonfirmasi.Text.Trim() <> "" Then
            InisialisasiPasswordMeter1.Visible = True
            InisialisasiPasswordMeter1.SetPassword(txKonfirmasi.Text.Trim())
        Else
            InisialisasiPasswordMeter1.Visible = False
        End If
    End Sub
End Class