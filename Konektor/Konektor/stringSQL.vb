Imports System.Runtime.CompilerServices, System.Windows.Forms, Microsoft.VisualBasic.CompilerServices
Imports System.Threading
Imports System.Security.Cryptography
Imports System.Text
'Imports Splash.Konektor.SettingOpsi

Namespace Splash.Konektor

    Public NotInheritable Class stringSQL

        Public Shared defaultKey As String = "MyKey@AG"

        Enum Limiter
            DoubleQoute = 34
            SingleQuote = 39
            OEM = 96
            Makro = 124
            Tab = 10
            HashTag = 35
            SignD = 36
        End Enum

        Public Overloads Shared Function SQL_QUERY_FROM_FILE(ByVal fileName As String) As String
            Dim strValue As String = Nothing
            Dim lines As String() = IO.File.ReadAllLines(fileName)
            Try
                If Not IO.File.Exists(fileName) Then
                    Throw New Exception("Error File Not Exists")
                Else
                    strValue = String.Concat(lines)
                    Return strValue
                End If
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Overloads Shared Function ADD_QUOTE_ON_SQL(str As String) As String
            If Operators.CompareString(str.Trim(), "", False) = 0 Then
                Return ""
            Else
                Return Strings.Replace(str, "'", " ", 1, -1, CompareMethod.Binary)
            End If
        End Function

        Public Overloads Shared Function ADD_QUOTE_ON_SQL(ByVal Value As String, Optional ByVal Qualifier As Limiter = Limiter.DoubleQoute) As String
            Dim ReturnString As String = Nothing
            Select Case Qualifier
                Case Limiter.DoubleQoute
                    ReturnString = String.Concat(Chr(34), Value.Trim().Replace(Chr(34), ""), Chr(34))
                    Exit Select
                Case Limiter.SingleQuote
                    ReturnString = String.Concat(Chr(39), Value.Trim().Replace(Chr(39), ""), Chr(39))
                    Exit Select
                Case Limiter.OEM
                    ReturnString = String.Concat(Chr(96), Value.Trim().Replace(Chr(96), ""), Chr(96))
                    Exit Select
                Case Limiter.Makro
                    ReturnString = String.Concat(Chr(124), Value.Trim().Replace(Chr(124), ""), Chr(124))
                    Exit Select
                Case Limiter.Tab
                    ReturnString = String.Concat(Chr(10), Value.Trim().Replace(Chr(10), ""), Chr(10))
                    Exit Select
                Case Limiter.HashTag
                    ReturnString = String.Concat(Chr(35), Value.Trim().Replace(Chr(35), ""), Chr(35))
                    Exit Select
                Case Limiter.SignD = 36
                    ReturnString = String.Concat(Chr(36), Value.Trim().Replace(Chr(36), ""), Chr(36))
                    Exit Select
            End Select
            Return ReturnString
        End Function

        Public Shared Function FORMAT_NPWP(str As String) As String
            Dim str1 As String
            Try
                If Operators.CompareString(str.Trim(), "", False) = 0 Then
                    str1 = ""
                Else
                    str1 = Strings.Mid(str, 1, 2) + "." + Strings.Mid(str, 3, 3) + "." + Strings.Mid(str, 6, 3) + "." + Strings.Mid(str, 9, 1) + "-" + Strings.Mid(str, 10, 3) + "." + Strings.Mid(str, 13, 3)
                End If
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim exception As Exception = ex
                mdlSQL.ShowError("Failed (format_npwp). Message : " + exception.Message)
                mdlSQL.INSERTLOG("Failed (format_npwp). Message : " + exception.Message, "")
                str1 = ""
                ProjectData.ClearProjectError()
            End Try
            Return str1
        End Function

        Public Shared Function MathRoundUp(number As Double, places As Integer) As Double
            Dim numberFormat As String = "###."
            numberFormat = numberFormat.PadRight(numberFormat.Length + places, "#"c)
            Return Double.Parse(number.ToString(numberFormat))
        End Function

        Public Shared Function CustomRound(value As Double) As Integer
            Dim decimalpoints As Double = Math.Abs(value - Math.Floor(value))
            If decimalpoints > 0.5 Then
                Return Conversion.Int(Math.Round(value))
            Else
                Return Conversion.Int(Math.Floor(value))
            End If
        End Function

        Public Shared Function CountSumTotalPrice(ByVal dg As DataGridView, ByVal columnName As String) As String
            Dim str As String = Nothing
            Dim sum As Double = 0.0
            For i As Integer = 0 To dg.RowCount - 1
                sum += dg.Rows(i).Cells(columnName).Value
            Next
            str = FormatNumber(stringSQL.MathRoundUp(sum, 0), 2)
            Return str
        End Function

        Public Shared Function SampleFormatNoInvoice(ByVal Format_Penomoran As String, ByVal delimiter As String) As String
            Dim str As String = Nothing
            If delimiter = "_None_" Then
                delimiter = "_"
            End If
            Dim tmp As String() = Strings.Split(Format_Penomoran, delimiter)
            Dim sb As New System.Text.StringBuilder
            For i As Integer = 0 To tmp.Length - 1
                sb.Append(tmp(i)).Append(delimiter)
            Next
            If delimiter = "_None_" Then
                str = Replace(sb.ToString, "_", "")
            Else
                str = sb.ToString
            End If
            str = ResultFormatInvoice(str)
            Return str
        End Function

        Public Shared Function ResultFormatInvoice(ByVal Format As String) As String
            Dim str As String = Nothing
            If Strings.Right(Format, 1).Contains("_") Then
                str = Right(Format, 1).Trim("_")

            End If
            If Strings.Right(Format, 1).Contains("/") Then
                str = Right(Format, 1).Trim("/")

            End If
            'str = Format.Substring(0, Format.Length - 1)
            Return str
        End Function


        Public Shared komaDesimal As Integer
        Public Shared DesimalSeparator As String

        ''' <summary>
        ''' Parsing Terbilang</summary>
        ''' <param name="Angka">Input Angka</param>
        ''' <param name="Opsi"> True: Pecahan Desimal, False: Non Desimal</param>
        ''' <param name="Desimal">Panjang Desimal</param>
        ''' <param name="delimiterDesimal">Delimiter Desimal</param>
        ''' <returns>True dengan pembilangan setelah koma</returns>
        ''' <remarks>False tanpa pembilngan desimal</remarks>
        Public Shared Function ParseTerbilang(ByVal Angka As String,
                                     ByVal Opsi As Boolean,
                                     Optional ByVal Desimal As Integer = 2,
                                     Optional ByVal delimiterDesimal As String = ",") As String
            Dim str As String = Nothing
            If Opsi Then
                Dim strTemp As String = FormatNumber(Angka.Trim(), Desimal)
                Dim strParseTemp As String() = Strings.Split(strTemp, delimiterDesimal, -1)
                Dim ParseBefore As String = strParseTemp(0)
                Dim ParseAfter As String = strParseTemp(1)
                str = String.Concat(New String() {Terbilang(ParseBefore), "koma ", ParseBilanganDesimal(ParseAfter)})
            Else
                str = Terbilang(Angka)
            End If
            Return str
        End Function

        Public Shared Function ParseBilanganDesimal(ByVal Sen As String) As String
            Dim int As Integer
            int = Sen.Length
            Dim Parse As String = ""
            Dim bilang As String = ""
            Dim angka(9)
            angka(1) = "satu "
            angka(2) = "dua "
            angka(3) = "tiga "
            angka(4) = "empat "
            angka(5) = "lima "
            angka(6) = "enam "
            angka(7) = "tujuh "
            angka(8) = "delapan "
            angka(9) = "sembilan "
            Dim str As String = ""
            Dim nbilang As String() = New String(Sen.Length - 1) {}
            For i As Integer = 0 To int - 1
                bilang = Sen.Substring(i, 1)
                nbilang(i) = angka(CInt(bilang))
            Next i
            Dim sb As New System.Text.StringBuilder
            For Each Sen In nbilang
                sb.Append(Sen)
            Next
            ParseBilanganDesimal = sb.ToString
        End Function

        Public Shared Function Terbilang(ByVal x As Double) As String
            Dim xTemp As Double
            Dim Teks As String
            Dim Section As String
            Dim i As Integer
            Dim Posisi As Boolean
            Dim letak As String() = New String(5) {}
            letak(1) = "ribu "
            letak(2) = "juta "
            letak(3) = "milyar "
            letak(4) = "triliun "

            If (x < 0) Then
                Terbilang = ""
                Exit Function
            End If
            If (x = 0) Then
                Terbilang = "nol"
                Exit Function
            End If
            If (x < 2000) Then
                Posisi = True
            End If
            Teks = Nothing
            If (x >= 1.0E+15) Then
                Terbilang = "Nilai terlalu besar"
                Exit Function
            End If

            For i = 4 To 1 Step -1
                xTemp = Int(x / (10 ^ (3 * i)))
                If (xTemp > 0) Then
                    Section = Ratus(xTemp, Posisi)
                    Teks = Teks & Section & letak(i)
                End If
                x = x - xTemp * (10 ^ (3 * i))
            Next

            Teks = Teks & Ratus(x, False)
            Terbilang = Teks
        End Function

        Public Shared Function Ratus(ByVal y As Double, ByVal flag As Boolean) As String
            Dim tmp As Double
            Dim bilang As String
            Dim bag As String
            Dim j As Integer

            Dim angka(9)
            angka(1) = "se"
            angka(2) = "dua "
            angka(3) = "tiga "
            angka(4) = "empat "
            angka(5) = "lima "
            angka(6) = "enam "
            angka(7) = "tujuh "
            angka(8) = "delapan "
            angka(9) = "sembilan "

            Dim posisi(2)
            posisi(1) = "puluh "
            posisi(2) = "ratus "

            bilang = ""
            For j = 2 To 1 Step -1
                tmp = Int(y / (10 ^ j))
                If (tmp > 0) Then
                    bag = angka(tmp)
                    If (j = 1 And tmp = 1) Then
                        y = y - tmp * 10 ^ j
                        If (y >= 1) Then
                            posisi(j) = "belas "
                        Else
                            angka(y) = "se"
                        End If
                        bilang = bilang & angka(y) & posisi(j)
                        Ratus = bilang
                        Exit Function
                    Else
                        bilang = bilang & bag & posisi(j)
                    End If
                End If
                y = y - tmp * 10 ^ j
            Next

            If (flag = False) Then
                angka(1) = "satu "
            End If
            bilang = bilang & angka(y)
            Ratus = bilang
        End Function

        'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '    ' make a reference to a directory
        '    Dim di As New IO.DirectoryInfo("c:\")
        '    Dim diar1 As IO.FileInfo() = di.GetFiles()
        '    Dim dra As IO.FileInfo

        '    'list the names of all files in the specified directory
        '    For Each dra In diar1
        '        ListBox1.Items.Add(dra)
        '    Next
        'End Sub

        Public Overloads Shared Sub WriteGeneralSetting(ByVal fs As IO.FileStream, ByVal Value As String)
            Dim b As Byte() = New System.Text.UTF8Encoding(True).GetBytes(Value)
            fs.Write(b, 0, b.Length)
        End Sub

        Public Overloads Shared Sub WriteGeneralSetting(ByVal WithNewLine As Boolean, ByVal fs As IO.FileStream, ByVal Value As String)
            If WithNewLine Then
                Dim b As Byte() = New System.Text.UTF8Encoding(True).GetBytes(Value & vbNewLine)
                fs.Write(b, 0, b.Length)
            Else
                Dim b As Byte() = New System.Text.UTF8Encoding(True).GetBytes(Value)
                fs.Write(b, 0, b.Length)
            End If
        End Sub


        Public Shared Function AESERans(ByVal input As Byte(), ByVal key As String) As Byte()
            Dim managed As New RijndaelManaged
            managed.Key = New SHA256Cng().ComputeHash(Encoding.ASCII.GetBytes(key))
            managed.Mode = CipherMode.ECB
            Dim transForm As ICryptoTransform = managed.CreateEncryptor
            Dim inputBuffer As Byte() = input
            Return transForm.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length)
        End Function

        Public Shared Function AESDRans(ByVal input As Byte(), ByVal key As String) As Byte()
            Dim managed As New RijndaelManaged
            managed.Key = New SHA256Cng().ComputeHash(Encoding.ASCII.GetBytes(key))
            managed.Mode = CipherMode.ECB
            Dim transform As ICryptoTransform = managed.CreateDecryptor
            Dim inputBuffer As Byte() = input
            Return transform.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length)
        End Function

        Public Shared Sub EncryptRansText(ByVal nFilename As String, ByVal stringkey As String)
            If My.Computer.FileSystem.FileExists(nFilename) Then
                My.Computer.FileSystem.WriteAllBytes(nFilename,
            stringSQL.AESERans(My.Computer.FileSystem.ReadAllBytes(
                                    nFilename), stringkey), False)
            End If
        End Sub

        Public Shared Sub DecryptRansText(ByVal nFilename As String, ByVal stringKey As String)
            If My.Computer.FileSystem.FileExists(nFilename) Then
                My.Computer.FileSystem.WriteAllBytes(nFilename,
            stringSQL.AESDRans(My.Computer.FileSystem.ReadAllBytes(
                                    nFilename), stringKey), False)
            End If
        End Sub

        Public Shared Function SqlFilter(ByVal SqlCommand As String, Optional ByVal Opsi As String = "") As String
            Dim str As String
            str = SqlCommand & " " & Opsi
            If Not IO.File.Exists(Environment.CurrentDirectory & "\filter.txt") Then
                'IO.File.Create(Environment.CurrentDirectory & "\filter.txt")
                IO.File.WriteAllText(Environment.CurrentDirectory & "\filter.txt", str)
                ' CodeLibs.CodeMethod.EncryptTextFile(Environment.CurrentDirectory & "\filter.txt", mdlstring.defaultKey)
            Else
                IO.File.WriteAllText(Environment.CurrentDirectory & "\filter.txt", str)
            End If
            Return IO.File.ReadAllText(Environment.CurrentDirectory & "\filter.txt")
        End Function
    End Class
End Namespace