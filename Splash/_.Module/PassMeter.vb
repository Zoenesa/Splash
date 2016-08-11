Imports System, System.Collections, System.Data
Public Class PassMeter

    Private tableDetail As DataTable
    Private PreviousPassword As String = ""

    Public Sub SetPasword(ByVal pwd As String)
        If PreviousPassword <> pwd Then
            PreviousPassword = pwd
            CheckPasswordWithDetails(PreviousPassword)
        End If
    End Sub

    Public Function GetPasswodScore() As Integer
        If Not (tableDetail Is Nothing) Then
            Return DirectCast(tableDetail.Rows(0)(5), Integer)
        Else
            Return 0
        End If
    End Function

    Public Function GetPasswordStrength() As String
        If Not (tableDetail Is Nothing) Then
            Return DirectCast(tableDetail.Rows(0)(3), [String])
        Else
            Return "Unknown"
        End If
    End Function

    Public Function GetStrengthDetails() As DataTable
        Return tableDetail
    End Function

    Private Sub CheckPasswordWithDetails(ByVal pwd As String)
        Dim nScore As Integer = 0
        Dim sComplexity = ""
        Dim iUpperCase As Integer = 0
        Dim iLowerCase As Integer = 0
        Dim iDigit As Integer = 0
        Dim iSymbol As Integer = 0
        Dim iRepeated As Integer = 1
        Dim htRepeated As Hashtable = New Hashtable()
        Dim iMiddle As Integer = 0
        Dim iMiddleEx As Integer = 1
        Dim ConsecutiveMode As Integer = 0
        Dim iConsecutiveUpper As Integer = 0
        Dim iConsecutiveLower As Integer = 0
        Dim iConsecutiveDigit As Integer = 0
        Dim iLevel As Integer = 0
        Dim sAlphas As String = "abcdefghijklmnopqrstuvwxyz"
        Dim sNumerics As String = "01234567890"
        Dim nSeqAlpha As Integer = 0
        Dim nSeqChar As Integer = 0
        Dim nSeqNumber As Integer = 0

        ' Create data table to store results
        CreateDetailsTable()
        Dim drScore As DataRow = AddDetailsRow(System.Math.Max(System.Threading.Interlocked.Increment(iLevel), iLevel - 1), "Score", "", "", 0, 0)

        ' Scan password
        For Each ch As Char In pwd.ToCharArray()
            ' Count digits
            If [Char].IsDigit(ch) Then
                System.Math.Max(System.Threading.Interlocked.Increment(iDigit), iDigit - 1)

                If ConsecutiveMode = 3 Then
                    System.Math.Max(System.Threading.Interlocked.Increment(iConsecutiveDigit), iConsecutiveDigit - 1)
                End If
                ConsecutiveMode = 3
            End If

            ' Count uppercase characters
            If [Char].IsUpper(ch) Then
                System.Math.Max(System.Threading.Interlocked.Increment(iUpperCase), iUpperCase - 1)
                If ConsecutiveMode = 1 Then
                    System.Math.Max(System.Threading.Interlocked.Increment(iConsecutiveUpper), iConsecutiveUpper - 1)
                End If
                ConsecutiveMode = 1
            End If

            ' Count lowercase characters
            If [Char].IsLower(ch) Then
                System.Math.Max(System.Threading.Interlocked.Increment(iLowerCase), iLowerCase - 1)
                If ConsecutiveMode = 2 Then
                    System.Math.Max(System.Threading.Interlocked.Increment(iConsecutiveLower), iConsecutiveLower - 1)
                End If
                ConsecutiveMode = 2
            End If

            ' Count symbols
            If [Char].IsSymbol(ch) OrElse [Char].IsPunctuation(ch) Then
                System.Math.Max(System.Threading.Interlocked.Increment(iSymbol), iSymbol - 1)
                ConsecutiveMode = 0
            End If

            ' Count repeated letters 
            If [Char].IsLetter(ch) Then
                If htRepeated.Contains([Char].ToLower(ch)) Then
                    System.Math.Max(System.Threading.Interlocked.Increment(iRepeated), iRepeated - 1)
                Else
                    htRepeated.Add([Char].ToLower(ch), 0)
                End If

                If iMiddleEx > 1 Then
                    iMiddle = iMiddleEx - 1
                End If
            End If

            If iUpperCase > 0 OrElse iLowerCase > 0 Then
                If [Char].IsDigit(ch) OrElse [Char].IsSymbol(ch) Then
                    System.Math.Max(System.Threading.Interlocked.Increment(iMiddleEx), iMiddleEx - 1)
                End If
            End If
        Next
        ' Check for sequential alpha string patterns (forward and reverse) 
        Dim s As Integer = 0
        While s < 23
            Dim sFwd As String = sAlphas.Substring(s, 3)
            Dim sRev As String = strReverse(sFwd)
            If pwd.ToLower().IndexOf(sFwd) <> -1 OrElse pwd.ToLower().IndexOf(sRev) <> -1 Then
                System.Math.Max(System.Threading.Interlocked.Increment(nSeqAlpha), nSeqAlpha - 1)
                System.Math.Max(System.Threading.Interlocked.Increment(nSeqChar), nSeqChar - 1)
            End If
            System.Math.Max(System.Threading.Interlocked.Increment(s), s - 1)
        End While

        ' Check for sequential numeric string patterns (forward and reverse)
        Dim s1 As Integer = 0
        While s1 < 8
            Dim sFwd As String = sNumerics.Substring(s1, 3)
            Dim sRev As String = strReverse(sFwd)
            If pwd.ToLower().IndexOf(sFwd) <> -1 OrElse pwd.ToLower().IndexOf(sRev) <> -1 Then
                System.Math.Max(System.Threading.Interlocked.Increment(nSeqNumber), nSeqNumber - 1)
                System.Math.Max(System.Threading.Interlocked.Increment(nSeqChar), nSeqChar - 1)
            End If
            System.Math.Max(System.Threading.Interlocked.Increment(s1), s1 - 1)
        End While

        ' Calcuate score
        AddDetailsRow(System.Math.Max(System.Threading.Interlocked.Increment(iLevel), iLevel - 1), "Additions", "", "", 0, 0)

        ' Score += 4 * Password Length
        nScore = 4 * pwd.Length
        AddDetailsRow(System.Math.Max(System.Threading.Interlocked.Increment(iLevel), iLevel - 1), "Password Length", "Flat", "(n*4)", pwd.Length, pwd.Length * 4)

        ' if we have uppercase letetrs Score +=(number of uppercase letters *2)
        If iUpperCase > 0 Then
            nScore += ((pwd.Length - iUpperCase) * 2)
            AddDetailsRow(System.Math.Max(System.Threading.Interlocked.Increment(iLevel), iLevel - 1), "Uppercase Letters", "Cond/Incr", "+((len-n)*2)", iUpperCase, ((pwd.Length - iUpperCase) * 2))
        Else
            AddDetailsRow(System.Math.Max(System.Threading.Interlocked.Increment(iLevel), iLevel - 1), "Uppercase Letters", "Cond/Incr", "+((len-n)*2)", iUpperCase, 0)
        End If

        ' if we have lowercase letetrs Score +=(number of lowercase letters *2)
        If iLowerCase > 0 Then
            nScore += ((pwd.Length - iLowerCase) * 2)
            AddDetailsRow(System.Math.Max(System.Threading.Interlocked.Increment(iLevel), iLevel - 1), "Lowercase Letters", "Cond/Incr", "+((len-n)*2)", iLowerCase, ((pwd.Length - iLowerCase) * 2))
        Else
            AddDetailsRow(System.Math.Max(System.Threading.Interlocked.Increment(iLevel), iLevel - 1), "Lowercase Letters", "Cond/Incr", "+((len-n)*2)", iLowerCase, 0)
        End If


        ' Score += (Number of digits *4)
        nScore += (iDigit * 4)
        AddDetailsRow(System.Math.Max(System.Threading.Interlocked.Increment(iLevel), iLevel - 1), "Numbers", "Cond", "+(n*4)", iDigit, (iDigit * 4))

        ' Score += (Number of Symbols * 6)
        nScore += (iSymbol * 6)
        AddDetailsRow(System.Math.Max(System.Threading.Interlocked.Increment(iLevel), iLevel - 1), "Symbols", "Flat", "+(n*6)", iSymbol, (iSymbol * 6))

        ' Score += (Number of digits or symbols in middle of password *2)
        nScore += (iMiddle * 2)
        AddDetailsRow(System.Math.Max(System.Threading.Interlocked.Increment(iLevel), iLevel - 1), "Middle Numbers or Symbols", "Flat", "+(n*2)", iMiddle, (iMiddle * 2))

        'requirments
        Dim requirments As Integer = 0
        If pwd.Length >= 8 Then
            System.Math.Max(System.Threading.Interlocked.Increment(requirments), requirments - 1)
        End If
        ' Min password length
        If iUpperCase > 0 Then
            System.Math.Max(System.Threading.Interlocked.Increment(requirments), requirments - 1)
        End If
        ' Uppercase letters
        If iLowerCase > 0 Then
            System.Math.Max(System.Threading.Interlocked.Increment(requirments), requirments - 1)
        End If
        ' Lowercase letters
        If iDigit > 0 Then
            System.Math.Max(System.Threading.Interlocked.Increment(requirments), requirments - 1)
        End If
        ' Digits
        If iSymbol > 0 Then
            System.Math.Max(System.Threading.Interlocked.Increment(requirments), requirments - 1)
        End If
        ' Symbols
        ' If we have more than 3 requirments then
        If requirments > 3 Then
            ' Score += (requirments *2) 
            nScore += (requirments * 2)
            AddDetailsRow(System.Math.Max(System.Threading.Interlocked.Increment(iLevel), iLevel - 1), "Requirments", "Flat", "+(n*2)", requirments, (requirments * 2))
        Else
            AddDetailsRow(System.Math.Max(System.Threading.Interlocked.Increment(iLevel), iLevel - 1), "Requirments", "Flat", "+(n*2)", requirments, 0)
        End If

        '
        ' Deductions
        '
        AddDetailsRow(System.Math.Max(System.Threading.Interlocked.Increment(iLevel), iLevel - 1), "Deductions", "", "", 0, 0)

        ' If only letters then score -=  password length
        If iDigit = 0 AndAlso iSymbol = 0 Then
            nScore -= pwd.Length
            AddDetailsRow(System.Math.Max(System.Threading.Interlocked.Increment(iLevel), iLevel - 1), "Letters only", "Flat", "-n", pwd.Length, -pwd.Length)
        Else
            AddDetailsRow(System.Math.Max(System.Threading.Interlocked.Increment(iLevel), iLevel - 1), "Letters only", "Flat", "-n", 0, 0)
        End If

        ' If only digits then score -=  password length
        If iDigit = pwd.Length Then
            nScore -= pwd.Length
            AddDetailsRow(System.Math.Max(System.Threading.Interlocked.Increment(iLevel), iLevel - 1), "Numbers only", "Flat", "-n", pwd.Length, -pwd.Length)
        Else
            AddDetailsRow(System.Math.Max(System.Threading.Interlocked.Increment(iLevel), iLevel - 1), "Numbers only", "Flat", "-n", 0, 0)
        End If

        ' If repeated letters used then score -= (iRepeated * (iRepeated - 1));
        If iRepeated > 1 Then
            nScore -= (iRepeated * (iRepeated - 1))
            AddDetailsRow(System.Math.Max(System.Threading.Interlocked.Increment(iLevel), iLevel - 1), "Repeat Characters (Case Insensitive)", "Incr", "-(n(n-1))", iRepeated, -(iRepeated * (iRepeated - 1)))
        End If

        ' If Consecutive uppercase letters then score -= (iConsecutiveUpper * 2);
        nScore -= (iConsecutiveUpper * 2)
        AddDetailsRow(System.Math.Max(System.Threading.Interlocked.Increment(iLevel), iLevel - 1), "Consecutive Uppercase Letters", "Flat", "-(n*2)", iConsecutiveUpper, -(iConsecutiveUpper * 2))

        ' If Consecutive lowercase letters then score -= (iConsecutiveUpper * 2);
        nScore -= (iConsecutiveLower * 2)
        AddDetailsRow(System.Math.Max(System.Threading.Interlocked.Increment(iLevel), iLevel - 1), "Consecutive Lowercase Letters", "Flat", "-(n*2)", iConsecutiveLower, -(iConsecutiveLower * 2))

        ' If Consecutive digits used then score -= (iConsecutiveDigits* 2);
        nScore -= (iConsecutiveDigit * 2)
        AddDetailsRow(System.Math.Max(System.Threading.Interlocked.Increment(iLevel), iLevel - 1), "Consecutive Numbers", "Flat", "-(n*2)", iConsecutiveDigit, -(iConsecutiveDigit * 2))

        ' If password contains sequence of letters then score -= (nSeqAlpha * 3)
        nScore -= (nSeqAlpha * 3)
        AddDetailsRow(System.Math.Max(System.Threading.Interlocked.Increment(iLevel), iLevel - 1), "Sequential Letters (3+)", "Flat", "-(n*3)", nSeqAlpha, -(nSeqAlpha * 3))

        ' If password contains sequence of digits then score -= (nSeqNumber * 3)
        nScore -= (nSeqNumber * 3)
        AddDetailsRow(System.Math.Max(System.Threading.Interlocked.Increment(iLevel), iLevel - 1), "Sequential Numbers (3+)", "Flat", "-(n*3)", nSeqNumber, -(nSeqNumber * 3))

        ' Determine complexity based on overall score 

        If nScore > 100 Then
            nScore = 100
        ElseIf nScore < 0 Then
            nScore = 0
        End If
        If nScore >= 0 AndAlso nScore < 20 Then
            sComplexity = "Terlalu Lemah"
        ElseIf nScore >= 20 AndAlso nScore < 40 Then
            sComplexity = "Lemah"
        ElseIf nScore >= 40 AndAlso nScore < 60 Then
            sComplexity = "Sedang"
        ElseIf nScore >= 60 AndAlso nScore < 80 Then
            sComplexity = "Kuat"
        ElseIf nScore >= 80 AndAlso nScore <= 100 Then
            sComplexity = "Sangat Kuat"
        End If

        ' Store score and complexity in dataset
        drScore(5) = nScore
        drScore(3) = sComplexity
        tableDetail.AcceptChanges()
    End Sub

    Private Sub CreateDetailsTable()
        tableDetail = New DataTable("PasswordDetails")
        tableDetail.Columns.Add(New DataColumn("Level", GetType(Int32)))
        tableDetail.Columns.Add(New DataColumn("Description", GetType([String])))
        tableDetail.Columns.Add(New DataColumn("Type", GetType([String])))
        tableDetail.Columns.Add(New DataColumn("Rate", GetType([String])))
        tableDetail.Columns.Add(New DataColumn("Count", GetType(Int32)))
        tableDetail.Columns.Add(New DataColumn("Bonus", GetType(Int32)))
    End Sub

    Private Function AddDetailsRow(Id As Integer, Description As String, Type As String, Rate As String, Count As Integer, Bouns As Integer) As DataRow
        Dim dr As DataRow = tableDetail.NewRow()
        dr(0) = Id
        dr(1) = Description
        dr(2) = Type
        dr(3) = Rate
        dr(4) = Count
        dr(5) = Bouns
        tableDetail.Rows.Add(dr)
        tableDetail.AcceptChanges()
        Return dr
    End Function

    Private Function strReverse(str As [String]) As [String]
        Dim newstring As String = ""
        Dim s As Integer = 0
        While s < str.Length
            newstring = str(s) + newstring
            System.Math.Max(System.Threading.Interlocked.Increment(s), s - 1)
        End While
        Return newstring
    End Function


End Class
