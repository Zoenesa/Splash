Imports MySql.Data.MySqlClient
Imports Splash.Konektor.mdlstring
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Data.SqlClient
Imports System.Threading

Namespace Splash.Konektor
    Public Class common
        <DebuggerNonUserCode>
        Public Sub New()
        End Sub

        Public Sub openHelp(Optional bookmarks As String = "")
            Dim fileName As String = "User Manual\"
            Try
                Process.Start(fileName)
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim exception As Exception = ex
                mdlCom.ShowError("Gagal. (open_help). Message : " + exception.Message)
                mdlCom.INSERTLOG("Gagal. (open_help). Message : " + exception.Message, "")
                ProjectData.ClearProjectError()
            End Try
        End Sub

        Public Function cekNPWP(_npwp9 As String, Optional nama_form As String = "", Optional nama_event As String = "") As Boolean
            Dim flag As Boolean
            Try
                If _npwp9.Length < 9 Or Not Versioned.IsNumeric(DirectCast(_npwp9, Object)) Then
                    flag = False
                ElseIf Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Left(_npwp9, 3), "240", False) = 0 Then
                    flag = True
                Else
                    Dim num1 As Integer = Conversions.ToInteger(_npwp9.Substring(0, 1))
                    Dim num2 As Integer = Conversions.ToInteger(_npwp9.Substring(1, 1)) * 2
                    Dim num3 As Integer = Conversions.ToInteger(_npwp9.Substring(2, 1))
                    Dim num4 As Integer = Conversions.ToInteger(_npwp9.Substring(3, 1)) * 2
                    Dim num5 As Integer = Conversions.ToInteger(_npwp9.Substring(4, 1))
                    Dim num6 As Integer = Conversions.ToInteger(_npwp9.Substring(5, 1)) * 2
                    Dim num7 As Integer = Conversions.ToInteger(_npwp9.Substring(6, 1))
                    Dim num8 As Integer = Conversions.ToInteger(_npwp9.Substring(7, 1)) * 2
                    If num2 > 9 Then
                        num2 -= 9
                    End If
                    If num4 > 9 Then
                        num4 -= 9
                    End If
                    If num6 > 9 Then
                        num6 -= 9
                    End If
                    If num8 > 9 Then
                        num8 -= 9
                    End If
                    Dim num9 As Integer = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8
                    While num9 > 10
                        num9 -= 10
                        '  num9 -= 10
                        ' End While
                        'flag = DirectCast(10 - num9, Double) = Conversions.ToDouble(_npwp9.Substring(8, 1))
                    End While
                    Dim a10 = 10 - num9
                    flag = CType(a10, Double) = Conversions.ToDouble(_npwp9.Substring(8, 1))
                End If
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim exception As Exception = ex
                mdlCom.ShowError("Gagal. (cek_npwp). Message : " + exception.Message)
                mdlCom.INSERTLOG("Gagal. (cek_npwp). Message : " + exception.Message, "")
                ProjectData.ClearProjectError()
            End Try
            Return flag
        End Function

        Public Function isProfileExist() As Boolean
            Dim flag1 As Boolean = False
            Dim flag2 As Boolean
            Try
                Dim MysqlDataReader As MySqlDataReader = New MySqlCommand() With {
                .Connection = mdlCom.vConn,
                 .CommandText = "SELECT `npwp` FROM `ref_profile`"
            }.ExecuteReader()
                If MysqlDataReader.HasRows Then
                    flag1 = True
                End If
                MysqlDataReader.Close()
                flag2 = flag1
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                mdlCom.INSERTLOG("Gagal. (cek_profile). Message : " + ex.Message, "")
                flag2 = False
                ProjectData.ClearProjectError()
            End Try
            Return flag2
        End Function

        Public Function tambahUname(uname As String, password As String, role As String, UserFName As String, Jabatan As String) As Boolean
            Dim flag As Boolean
            Try
                flag = New MySqlCommand() With {
                .Connection = mdlCom.vConn,
                .CommandText = ("INSERT INTO `user` (`Username`, `Password`, `kdgroup`, `nip_user`, `UserFname`, `uaktif`, `UserRole`, `JobDesk`) VALUES('" +
                                uname + "', '" + password + "','" + Strings.Mid(role, 1, 2) + "','" + role + "','" + UserFName + "','" + "T" + "', '" + Strings.Mid(role, 1, 2) + "', '" + Jabatan + "')")
            }.ExecuteNonQuery() > 0
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                mdlCom.INSERTLOG("Gagal. (add_user). Message : " + ex.Message, "")
                flag = False
                ProjectData.ClearProjectError()
            End Try
            Return flag
        End Function

        Public Function updateUser(password As String, uname As String, role As String) As Boolean
            Dim flag As Boolean
            Try
                flag = New MySqlCommand() With {.Connection = mdlCom.vConn,
                .CommandText = ("UPDATE `user` SET `Password` = '" + password + "', `kdgroup` = '" + Strings.Mid(role, 1,
                2) + "', `nip_user` = '" + role + "' WHERE `Username` = '" + uname + "'")}.ExecuteNonQuery() > 0
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                mdlCom.INSERTLOG("Gagal. (update_user). Message : " + ex.Message, "")
                flag = False
                ProjectData.ClearProjectError()
            End Try
            Return flag
        End Function

        Public Function unameOke(ByRef errMsg As String, uname As String) As Boolean
            Dim flag1 As Boolean
            Try
                Dim flag2 As Boolean = False
                Dim DbDataAdapter As New MySqlDataAdapter("SELECT `Password` FROM `user` WHERE `Username` = '" + uname + "'", mdlCom.vConn)
                Dim dataTable As New DataTable()
                DirectCast(DbDataAdapter, MySqlDataAdapter).Fill(dataTable)
                If dataTable.Rows.Count = 0 Then
                    flag2 = True
                End If
                flag1 = flag2
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim exception As Exception = ex
                errMsg = "Gagal. (get_password). Message : " + exception.Message
                mdlCom.INSERTLOG(errMsg, "")
                flag1 = False
                ProjectData.ClearProjectError()
            End Try
            Return flag1
        End Function

        Public Function passwordOke(ByRef errMsg As String, password As String, uname As String) As Boolean
            Dim flag1 As Boolean
            Try
                Dim flag2 As Boolean = False
                Dim oleDbDataAdapter As New MySqlDataAdapter("SELECT `Password` FROM `user` WHERE `Username` = '" + uname + "'", mdlCom.vConn)
                Dim dataTable As New DataTable()
                DirectCast(oleDbDataAdapter, DbDataAdapter).Fill(dataTable)
                If dataTable.Rows.Count > 0 Then
                    If Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(dataTable.Rows(0)(0), DirectCast(password, Object), False) Then
                        flag2 = True
                    End If
                Else
                    flag2 = False
                End If
                flag1 = flag2
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim exception As Exception = ex
                errMsg = "Gagal. (get_password). Message : " + exception.Message
                mdlCom.INSERTLOG(errMsg, "")
                flag1 = False
                ProjectData.ClearProjectError()
            End Try
            Return flag1
        End Function

        Public Function updatePassword(password As String, uname As String) As Boolean
            Dim flag As Boolean
            Try
                flag = New MySqlCommand() With {
                .Connection = mdlCom.vConn,
                .CommandText = ("UPDATE `user` SET `Password` = '" + password + "' WHERE `Username` = '" + uname + "'")
            }.ExecuteNonQuery() > 0
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                mdlCom.INSERTLOG("Gagal. (update_password). Message : " + ex.Message, "")
                flag = False
                mdlCom.ShowError(ex.Message)
                ProjectData.ClearProjectError()
            End Try
            Return flag
        End Function

        Public Function SqlCustomQuery(ByRef errMsg As String, ByVal Command As String, ByRef dt As DataTable, ByVal Optional Opsi As String = "") As Boolean
            errMsg = ""
            Dim flag As Boolean
            Try
                Dim adapter As New MySqlDataAdapter(Command & " " & Opsi, mdlCom.vConn)
                dt = New DataTable()
                DirectCast(adapter, DbDataAdapter).Fill(dt)
                flag = True
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim exception As Exception = ex
                errMsg = "Gagal. (common_SQLQUERY). Message : " + exception.Message
                mdlCom.INSERTLOG(errMsg, "")
                flag = False
                ProjectData.ClearProjectError()
            End Try
            Return flag
        End Function

        Public Function getUsers(ByRef errMsg As String, ByRef dtUsers As DataTable, Optional opsi As String = "") As Boolean
            errMsg = ""
            Dim flag As Boolean
            Try
                Dim sqlAdapter As New MySqlDataAdapter("SELECT * FROM `user` " + opsi, mdlCom.vConn)
                dtUsers = New DataTable()
                DirectCast(sqlAdapter, DbDataAdapter).Fill(dtUsers)
                flag = True
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim exception As Exception = ex
                errMsg = "Gagal. (common_get_user). Message : " + exception.Message
                mdlCom.INSERTLOG(errMsg, "")
                flag = False
                ProjectData.ClearProjectError()
            End Try
            Return flag
        End Function

        Public Function getInfo(ByRef errMsg As String, ByRef retData As String()) As Boolean
            Dim flag As Boolean
            Try
                retData = New String(11) {}
                errMsg = "0"
                Dim MysqlDataReader As MySqlDataReader = New MySqlCommand() With {
                .Connection = mdlCom.vConn,
                .CommandText = "SELECT npwp, nama_wp_profile, alamat, telepon FROM ref_profile"
            }.ExecuteReader()
                If MysqlDataReader.HasRows Then
                    MysqlDataReader.Read()

                    retData(0) = MysqlDataReader("npwp").ToString()
                    retData(1) = MysqlDataReader("alamat").ToString()
                    retData(2) = MysqlDataReader("nama_wp_profile").ToString()
                    retData(3) = MysqlDataReader("telepon").ToString()
                    MysqlDataReader.Close()
                    flag = True
                Else
                    MysqlDataReader.Close()
                    errMsg = "Data Profile tidak ditemukan."
                    flag = False
                End If
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim exception As Exception = ex
                errMsg = "Gagal. (get_info). Message : " + exception.Message
                mdlCom.INSERTLOG(errMsg, "")
                flag = False
                ProjectData.ClearProjectError()
            End Try
            Return flag
        End Function

        Public Function LoadTable(ByRef errMsg As String, ByRef dt As DataTable, ByVal tablename As String, Optional ByVal opsi As String = "") As Boolean
            errMsg = ""
            Dim flag As Boolean
            Try
                Dim sqlAdapter As New MySqlDataAdapter("SELECT * FROM `" & tablename & "` " + opsi, mdlCom.vConn)
                dt = New DataTable()
                DirectCast(sqlAdapter, DbDataAdapter).Fill(dt)
                flag = True
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim exception As Exception = ex
                errMsg = "Gagal. (common_Load_table" & tablename & "). Message : " + exception.Message
                mdlCom.INSERTLOG(errMsg, "")
                flag = False
                ProjectData.ClearProjectError()
            End Try
            Return flag
        End Function

        Public Function GetSqlInvoiceData(ByRef errMsg As String, ByRef dt As DataTable, Optional ByVal Opsi As String = "") As Boolean
            errMsg = ""
            Dim flag As Boolean
            Try
                Dim sqlAdapter As New MySqlDataAdapter("SELECT * FROM `invoicedata` " & Opsi, mdlCom.vConn)
                dt = New DataTable()
                DirectCast(sqlAdapter, DbDataAdapter).Fill(dt)
                flag = True
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim exception As Exception = ex
                errMsg = "Gagal. (common_getSqlInvoiceData). Message : " + exception.Message
                mdlCom.INSERTLOG(errMsg, "")
                flag = False
                ProjectData.ClearProjectError()
            End Try
            Return flag
        End Function

        Public Function LoadTableSchema(ByRef errMsg As String, ByRef dt As DataTable, ByVal schema As String, Optional ByVal opsi As String = "") As Boolean
            errMsg = ""
            Dim flag As Boolean
            Try
                Dim sqlAdapter As New MySqlDataAdapter("SELECT TABLE_NAME, TABLE_ROWS FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = " & schema & opsi, mdlCom.vConn)
                dt = New DataTable()
                DirectCast(sqlAdapter, DbDataAdapter).Fill(dt)
                flag = True
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim exception As Exception = ex
                errMsg = "Gagal. (common_get_dataSchema). Message : " + exception.Message
                mdlCom.INSERTLOG(errMsg, "")
                flag = False
                ProjectData.ClearProjectError()
            End Try
            Return flag
        End Function
        Public Function getCustomerSupplier(ByRef errmsg As String, ByRef dt As DataTable, Optional Opsi As String = "") As Boolean
            errmsg = ""
            Dim flag As Boolean
            Try
                Dim sqladapter As New MySqlDataAdapter("Select * FROM `ref_client` " + Opsi, mdlCom.vConn)
                dt = New DataTable()
                DirectCast(sqladapter, DbDataAdapter).Fill(dt)
                flag = True
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim exception As Exception = ex
                errmsg = "Gagal. (get_data_CustomersSupplier). Message : " + exception.Message
                mdlCom.INSERTLOG(errmsg, "")
                flag = False
                ProjectData.ClearProjectError()
            End Try
            Return flag
        End Function
        Public Function editSupplier(ByVal ID As Object, ByVal Nama As Object, ByVal Kategori As Object,
                               ByVal owner As Object, ByVal alamat As Object, ByVal telpon As Object) As Boolean
            Dim flag As Boolean
            Try
                flag = New MySqlCommand() With {.Connection = mdlCom.vConn,
                    .CommandText = String.Format("UPDATE SUPPLIER SET SUP_NAMASUPPLIER = '" + Nama + "', SUP_KATEGORI = '" + Kategori +
                                         "', SUP_OWNER = '" + owner + "', SUP_ALAMAT = '" +
                                         alamat + "', SUP_NOTELPON = '" + telpon + "' WHERE SUP_ID = '" + ID + "'")} _
                                         .ExecuteNonQuery() > 0
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                mdlCom.INSERTLOG("Gagal. (Update_Supplier). Message : " + ex.Message, "")
                flag = False
                ProjectData.ClearProjectError()
            End Try
            Return flag
        End Function

        Public Function GetCustomerName(ByRef errMsg As String, ByVal Nama As String) As Boolean
            Dim flag1 As Boolean
            Try
                Dim flag2 As Boolean = False
                Dim sqlAdapter As New MySqlDataAdapter("SELECT `Client_Name` FROM `ref_client` WHERE `Client_Name` = '" & Nama & "'", mdlCom.vConn)
                Dim dtTable As New DataTable()
                DirectCast(sqlAdapter, MySqlDataAdapter).Fill(dtTable)
                If dtTable.Rows.Count > 0 Then
                    flag2 = True
                Else
                    flag2 = False
                    errMsg = "Nama Pelanggan Belum Terdaftar"
                End If
                flag1 = flag2
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim exception As Exception = ex
                errMsg = "Gagal (get_Pelanggan). Message : " + exception.Message
                mdlCom.INSERTLOG(errMsg, "")
                flag1 = False
                ProjectData.ClearProjectError()
            End Try
            Return flag1
        End Function
        Public Function TambahCustomerSupplier(ByVal ID As Object, ByVal npwp As Object,
                                           ByVal Customer As Object, ByVal alamat As Object, ByVal Propinsi As Object,
                                ByVal Kota As Object, ByVal kecamatan As Object, ByVal telpon As Object, ByVal kodepos As Object) As Boolean
            Dim flag As Boolean
            Try
                flag = New MySqlCommand() With {.Connection = mdlCom.vConn,
                    .CommandText = String.Format("INSERT INTO `ref_client` VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
            RuntimeHelpers.GetObjectValue(ID), RuntimeHelpers.GetObjectValue(npwp),
            RuntimeHelpers.GetObjectValue(Customer), RuntimeHelpers.GetObjectValue(alamat), RuntimeHelpers.GetObjectValue(Propinsi), RuntimeHelpers.GetObjectValue(Kota),
            RuntimeHelpers.GetObjectValue(kecamatan), RuntimeHelpers.GetObjectValue(telpon), RuntimeHelpers.GetObjectValue(kodepos))} _
            .ExecuteNonQuery()
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim exception As Exception = ex
                mdlCom.INSERTLOG("Gagal. (get_Insert_CustomersSupplier). Message : " + exception.Message, "")
                flag = False
                ProjectData.ClearProjectError()
            End Try
            Return flag
        End Function

        Public Function UpdatePelangganSupplier(ByVal RecordNo As Object, ByVal Nama As Object, ByVal NPWP As Object,
                             ByVal Alamat As Object, ByVal Kota As Object, ByVal Propinsi As Object,
                             ByVal Kecamatan As Object, ByVal Kelurahan As Object, ByVal Kodepos As Object,
                             ByVal Telpon As Object, ByVal Email As Object
                             ) As Boolean
            Dim flag As Boolean
            Try
                flag = New MySqlCommand() With {.Connection = mdlCom.vConn,
                    .CommandText = String.Concat(New String() {"UPDATE `REF_CLIENT` SET `CLIENT_NAME` = '", ADD_QUOTE_ON_SQL(Nama),
                                                 "', `CLIENT_IDTAX` = '", ADD_QUOTE_ON_SQL(NPWP), "', `CLIENT_ADDRESS` = '", ADD_QUOTE_ON_SQL(Alamat),
                                                 "', `CLIENT_CITY` = '", ADD_QUOTE_ON_SQL(Kota), "', `CLIENT_STATE` = '", ADD_QUOTE_ON_SQL(Propinsi),
                                                 "', `CLIENT_DISTRICT` = '", ADD_QUOTE_ON_SQL(Kecamatan), "', `CLIENT_VILLAGE` = '", ADD_QUOTE_ON_SQL(Kelurahan),
                                                 "', `CLIENT_ZIPCODE` = '", ADD_QUOTE_ON_SQL(Kodepos), "', `CLIENT_PHONE` = '", ADD_QUOTE_ON_SQL(Telpon),
                                                 "', `CLIENT_MAIL` = '", ADD_QUOTE_ON_SQL(Email), "', " & "`CLIENT_USEREDIT` = '" & ADD_QUOTE_ON_SQL(mdlCom.UserLogin) & "', " &
                                                 "`CLIENT_UPDATE` = '" & ADD_QUOTE_ON_SQL(DateTime.Now.ToString("dd/MM/yyyy")) & "' WHERE `ID_NUM` = '", ADD_QUOTE_ON_SQL(RecordNo), "'"})}.ExecuteNonQuery() > 0
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                mdlCom.INSERTLOG("Gagal. (update_Supplier). Message : " + ex.Message, "")
                flag = False
                ProjectData.ClearProjectError()
            End Try
            Return flag
        End Function

        Public Function GetPelangganSupplier(ByRef errMsg As String,
                    ByRef dtPelanggan As DataTable,
                    Optional ByVal Opsi As String = "") As Boolean
            Dim flag As Boolean
            errMsg = ""
            Try
                Dim sqladapter As New MySqlDataAdapter(("SELECT  * FROM `ref_Client` " & Opsi & " ORDER BY `ID_NUM`;"), mdlCom.vConn)
                dtPelanggan = New DataTable
                sqladapter.Fill(dtPelanggan)
                flag = True
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                errMsg = ("(Gagal mendapatkan dataPelanggan). Message: " & ex.Message)
                mdlCom.INSERTLOG("Gagal. (update_Supplier). Message : " + ex.Message, "")
                flag = False
                ProjectData.ClearProjectError()
            End Try
            Return flag
        End Function

        Public Function getListWO(ByRef errMsg As String, ByRef dt As DataTable, Optional ByVal opsi As String = "") As Boolean
            Dim flag As Boolean
            errMsg = ""
            Try
                Dim sqladapter As New MySqlDataAdapter(("SELECT * FROM `listworkorder` " & opsi), mdlCom.vConn)
                dt = New DataTable
                sqladapter.Fill(dt)
                flag = True
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim excep As Exception = ex
                errMsg = ("Gagal.(common_get_workorder).Message:" & ex.Message)
                mdlCom.INSERTLOG(errMsg, "")
                flag = False
                ProjectData.ClearProjectError()
                Return flag
                ProjectData.ClearProjectError()
            End Try
            Return flag
        End Function

        Public Function GetDataBAST(ByVal errMsg As String, ByRef dt As DataTable, Optional ByVal Opsi As String = "") As Boolean
            Dim flag As Boolean
            Try
                Dim sqladapter As New MySqlDataAdapter(("SELECT * FROM `BAST` " & Opsi), mdlCom.vConn)
                dt = New DataTable
                sqladapter.Fill(dt)
                flag = True
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim excep As Exception = ex
                errMsg = ("Gagal.(common_get_BAST).Message:" & ex.Message)
                mdlCom.INSERTLOG(errMsg, "")
                flag = False
                ProjectData.ClearProjectError()
                Return flag
                ProjectData.ClearProjectError()
            End Try
            Return flag
        End Function

        Public Function ValidasiTanggal(ByVal tgl As String) As Boolean
            Dim flag As Boolean
            Try
                If Not Information.IsDate(tgl) Then
                    Return False
                End If
                flag = True
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim excep As Exception = ex
                mdlCom.INSERTLOG(("Gagal. (validasi.Tanggal).Message:" & excep.Message), "")
                flag = False
                ProjectData.ClearProjectError()
                Return flag
                ProjectData.ClearProjectError()
            End Try
            Return flag
        End Function

        Public Function ReadCSVImport(ByRef errMsg As String, ByRef xList As List(Of String), ByVal xFilePath As String) As Boolean
            Dim flag As Boolean
            Try
                Dim reader As New IO.StreamReader(xFilePath, False)
                Dim num As Integer = 0
                Dim str As String = reader.ReadLine
                Do While (Not str Is Nothing)
                    Interlocked.Increment(1)
                    If (num > &HFDE8) Then
                        errMsg = "jumlah data melebihi batas maksimal 65.000 baris!."
                        Return False
                    End If
                    xList.Add(str)
                    str = reader.ReadLine
                Loop
                reader.Close()
                reader.Dispose()
                flag = True
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim excep As Exception = ex
                errMsg = ("(Gagal. (read_csv).Message: " & excep.Message)
                mdlCom.INSERTLOG(errMsg, "")
                flag = False
                ProjectData.ClearProjectError()
                Return flag
                ProjectData.ClearProjectError()
            End Try
            Return flag
        End Function

        Public Function pastingLine(ByRef errMsg As String, ByVal strLine As String, ByRef arrSukses As String(), ByRef errParsing As String) As Boolean
            Dim flag As Boolean
            Try
                Dim comon As New common
                arrSukses = New String(22 - 1) {}
                Dim source As String() = Strings.Split(strLine, ";", -1, CompareMethod.Binary)
                If (Enumerable.Count(Of String)(source) = 22) Then
                    If (source(1) = "") Then
                        errParsing = ("Nomor Invoice tidak boleh Kosong.")
                        Return False
                    End If
                    If (source(3) = "1") Then
                        arrSukses(3) = "Barang"
                    ElseIf (source(3) = "2") Then
                        arrSukses(3) = "Jasa"
                    ElseIf (source(3) = "3") Then
                        arrSukses(3) = "Revisi"
                    End If
                    If (source(6) = "") Then
                        errParsing = ("Nomor Sales Order dari Client tidak boleh Kosong.")
                        Return False
                    End If
                    If (source(7) = "") Then
                        errParsing = ("Nomor BAST Client tidak boleh Kosong.")
                        Return False
                    End If
                    If (source(21) = "") Then

                    End If
                    arrSukses(1) = source(1)
                    arrSukses(2) = source(2)
                    arrSukses(4) = source(4)
                    arrSukses(5) = source(5)
                    arrSukses(6) = source(6)
                    arrSukses(7) = source(7)
                    arrSukses(8) = source(8)
                    arrSukses(9) = source(9)
                    arrSukses(10) = source(10)
                    arrSukses(11) = source(11)
                    arrSukses(12) = source(12)
                    arrSukses(13) = source(13)
                    arrSukses(14) = source(14)
                    arrSukses(15) = source(15)
                    arrSukses(16) = source(16)
                    arrSukses(17) = source(17)
                    arrSukses(18) = source(18)
                    arrSukses(19) = source(19)
                    arrSukses(20) = source(20)
                    arrSukses(21) = source(21)
                    Return True
                End If
                errParsing = ("Format CSV Invoice tidak dikenali : " & strLine)
                flag = False
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim excep As Exception = ex
                errParsing = ("Gagal. (parsing_line). Message : " & excep.Message)
                mdlCom.INSERTLOG("Gagal. (parsing_line). Message : " + excep.Message, "")
                flag = False
                ProjectData.ClearProjectError()
                Return flag
                ProjectData.ClearProjectError()
            End Try
            Return flag
        End Function

        Public Function CekNoInvoiceada(ByVal invNo As String, ByVal clientName As String) As Boolean
            Dim flag As Boolean
            Try
                Dim adapter As New MySqlDataAdapter(("SELECT `invoiceno` FROM `invoicedata` WHERE `invoiceno` = '" & mdlstring.ADD_QUOTE_ON_SQL(invNo) & "' AND `invoiceClient` = '" & mdlstring.ADD_QUOTE_ON_SQL(clientName)), mdlCom.vConn)
                Dim datatable As New DataTable
                adapter.Fill(datatable)
                If (datatable.Rows.Count > 0) Then
                    Return True
                End If
                flag = False
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim excep As Exception = ex
                mdlCom.INSERTLOG("Gagal. (cek_existing_Invoice).Message : " + excep.Message, "")
                flag = False
                ProjectData.ClearProjectError()
                Return flag
                ProjectData.ClearProjectError()
            End Try
            Return flag
        End Function

        Public Function InsertInvoiceData(
            ByVal invNo As String, ByVal invDate As String,
            ByVal invType As Integer, ByVal invClient As String,
            ByVal invCAddr As String, ByVal invWOSPK As String,
            ByVal invBAST As String, ByVal invProgress As String,
            ByVal invTerm As String, ByVal intItemRecord As String,
            ByVal invTotalItems As String, ByVal invPayment As String,
            ByVal invAfterTerm As String, ByVal invTax As String,
            ByVal invTerbilang As String, ByVal invProject As String,
            Optional ByVal editmode As Boolean = False,
            Optional ByVal Userinput As String = "",
            Optional ByVal CrtDate As String = "",
            Optional ByVal UserUpdate As String = "",
            Optional ByVal UpdatedDate As String = "") As Boolean

            Dim flag As Boolean
            Try
                Select Case invType
                    Case "Barang"
                        invType = "0"
                        Exit Select
                    Case "Jasa"
                        invType = "1"
                        Exit Select
                    Case "Revisi"
                        invType = "3"
                        Exit Select
                End Select
                Dim strCommand As String
                Dim command As New MySqlCommand With {
                .Connection = mdlCom.vConn}
                If editmode Then
                    strCommand = String.Concat(New String() {"UPDATE `invoivedata` SET `, "})
                Else
                    strCommand = String.Concat(New String() {"INSERT INTO `invoicedata` (" &
                                           "`recordNo`, `invoiceno`, `invoicedate`," &
                                           " `InvoiceType`, `InvoiceClient`, `InvoiceClientAddress`," &
                                           " `InvoiceWorkOrderSPK`, `InvoiceLisence`," &
                                           " `InvoiceProgress`, `InvoiceTerm`, `InvoiceItemsRecords`," &
                                           " `InvoiceTotalItems`, `InvoicePaymentsRecord`," &
                                           " `InvoiceAfterTermyn`, `InvoiceTaxPrice`, `InvoiceTerbilang`, ``, ``, ``, ``, ``, ``) VALUES ()"})
                End If
                command.CommandText = strCommand
                If (command.ExecuteNonQuery > 0) Then
                    Return True
                End If
                flag = False
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim excep As Exception = ex
                mdlCom.INSERTLOG("Gagal. (cek_existing_Invoice).Message : " + excep.Message, "")
                flag = False
                ProjectData.ClearProjectError()
                Return flag
                ProjectData.ClearProjectError()
            End Try
            Return flag
        End Function

        Public Function GetPropinsi(ByRef errMsg As String, ByRef dtUsers As DataTable, Optional opsi As String = "") As Boolean
            errMsg = ""
            Dim flag As Boolean
            Try
                Dim sqlAdapter As New MySqlDataAdapter("SELECT * FROM `provinces` " + opsi, mdlCom.vConn)
                dtUsers = New DataTable()
                DirectCast(sqlAdapter, DbDataAdapter).Fill(dtUsers)
                flag = True
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim exception As Exception = ex
                errMsg = "Gagal. (common_get_provinces). Message : " + exception.Message
                mdlCom.INSERTLOG(errMsg, "")
                flag = False
                ProjectData.ClearProjectError()
            End Try
            Return flag
        End Function

        Public Function GetKabupaten(ByRef errMsg As String, ByRef dtKabupaten As DataTable, Optional opsi As String = "") As Boolean
            errMsg = ""
            Dim flag As Boolean
            Try
                Dim sqlAdapter As New MySqlDataAdapter("SELECT * FROM `regencies` " + opsi, mdlCom.vConn)
                dtKabupaten = New DataTable()
                DirectCast(sqlAdapter, DbDataAdapter).Fill(dtKabupaten)
                flag = True
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim exception As Exception = ex
                errMsg = "Gagal. (common_get_provinces). Message : " + exception.Message
                mdlCom.INSERTLOG(errMsg, "")
                flag = False
                ProjectData.ClearProjectError()
            End Try
            Return flag
        End Function

        Public Function GetKecamatan(ByRef errMsg As String, ByRef dtKabupaten As DataTable, Optional opsi As String = "") As Boolean
            errMsg = ""
            Dim flag As Boolean
            Try
                Dim sqlAdapter As New MySqlDataAdapter("SELECT * FROM `districts` " + opsi, mdlCom.vConn)
                dtKabupaten = New DataTable()
                DirectCast(sqlAdapter, DbDataAdapter).Fill(dtKabupaten)
                flag = True
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim exception As Exception = ex
                errMsg = "Gagal. (common_get_provinces). Message : " + exception.Message
                mdlCom.INSERTLOG(errMsg, "")
                flag = False
                ProjectData.ClearProjectError()
            End Try
            Return flag
        End Function
    End Class
End Namespace