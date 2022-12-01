Option Explicit On
Option Strict On
''
''Added 9/13/2020  Thomas Downes
''
Module mod_SubtractDecs_Char

    Public Function SubAnyTwoDecStrings(pstrDec1 As String, pstrDec2 As String,
                              pstrErrMessage As String) As String
        ''
        ''Subtract any two decimal strings.   
        ''
        Dim strDec1_Padded As String
        Dim strDec2_Padded As String
        Dim intMaxLengthOfDec As Integer
        Dim intLength1 As Integer
        Dim intLength2 As Integer
        Dim oneSignificantDigit1 As String
        Dim oneSignificantDigit2 As String
        Dim intCharIndex As Integer
        Dim boolDigit1_IsBigger As Boolean
        Dim boolDigit2_IsBigger As Boolean
        Dim strTemp As String
        Dim boolLetsSwapNumbers As Boolean

        intLength1 = Len(Trim(pstrDec1))
        intLength2 = Len(Trim(pstrDec2))

        intMaxLengthOfDec = CType(IIf(intLength1 >= intLength2, intLength1, intLength2), Integer)

        strDec1_Padded = PadLeft(Trim(pstrDec1), intMaxLengthOfDec)
        strDec2_Padded = PadLeft(Trim(pstrDec2), intMaxLengthOfDec)

        intCharIndex = -1 ''6/25/2019 td'' = 0 
        Do
            intCharIndex += 1
            oneSignificantDigit1 = strDec1_Padded.Substring(intCharIndex, 1)
            oneSignificantDigit2 = strDec2_Padded.Substring(intCharIndex, 1)
            boolDigit1_IsBigger = (Integer.Parse(oneSignificantDigit1) > Integer.Parse(oneSignificantDigit2))
            boolDigit2_IsBigger = (Integer.Parse(oneSignificantDigit1) < Integer.Parse(oneSignificantDigit2))
            If (boolDigit1_IsBigger) Then Exit Do
            If (boolDigit2_IsBigger) Then Exit Do
            If (intCharIndex >= (-1 + strDec1_Padded.Length)) Then Exit Do
            If (intCharIndex >= (-1 + strDec1_Padded.Length)) Then Exit Do
        Loop

        If (boolDigit1_IsBigger) Then
            ''
            ''Good, it's as expected/desired.  
            ''
        ElseIf (boolDigit2_IsBigger) Then
            ''
            ''Uh-oh........ we have to swap the numbers.   
            ''
            boolLetsSwapNumbers = True
            strTemp = strDec2_Padded
            strDec2_Padded = strDec1_Padded
            strDec1_Padded = strTemp

        Else
            ''
            ''The numbers are equal.  
            ''
            Return "00000000000"

        End If ''End of "If (boolDigit1_IsBigger) Then .... ElseIf ..... Else ....."

        SubAnyTwoDecStrings = SubPaddedDecStrings(strDec1_Padded, strDec2_Padded,
                                              pstrErrMessage)

        ''Add a minus sign, if needed.
        ''
        If (boolLetsSwapNumbers) Then SubAnyTwoDecStrings = ("-" & SubAnyTwoDecStrings)

        ''Don't return any value if there's an error message.
        If (pstrErrMessage <> "") Then SubAnyTwoDecStrings = ""

    End Function ''End of "Public Function SubAnyTwoDecStrings(pstrDec1 As String, pstrDec2 As String, ......"

    Private Function SubPaddedDecStrings(pstrDec1 As String, pstrDec2 As String,
                                     ByRef pstrErrMessage As String) As String
        ''
        ''Added 6/25/2019 Thomas Downes 
        ''
        Dim intCharIndex As Integer
        Dim strConcatenated As String = ""
        Dim boolUnequalLengths As Boolean
        Dim strNewDigit As String = ""
        '--'Dim boolBorrowTheOne As String
        Dim charDecDigit1 As Char ''9/14 td''String
        Dim charDecDigit2 As Char ''9/14 td''String
        Dim boolBorrowTheOne_Curr As Boolean
        Dim boolBorrowTheOne_Next As Boolean
        Dim boolIsALeadingZero As Boolean ''Added 7/11/2016 Thomas Downes

        boolUnequalLengths = (Len(pstrDec1) <> Len(pstrDec2))

        If (boolUnequalLengths) Then
            pstrErrMessage = "Dec strings are unequal in length."
            ''9/13/2020 td''Exit Function
            If (pstrErrMessage <> "") Then Return "{" ''Added 9/13/2020 td
        End If ''End of "If (boolUnequalLengths) Then"

        For intCharIndex = Len(pstrDec1) To 1 Step -1

            ''strDecDigit1 = Mid$(pstrDec1, intCharIndex, 1)
            ''strDecDigit2 = Mid$(pstrDec2, intCharIndex, 1)

            charDecDigit1 = Mid$(pstrDec1, intCharIndex, 1)(0) ''Use (0) to specify the first & only character in the string.
            charDecDigit2 = Mid$(pstrDec2, intCharIndex, 1)(0) ''Use (0) to specify the first & only character in the string.

            strNewDigit = SubDecDigits_BorrowOne(charDecDigit1,
                                                charDecDigit2,
                                                boolBorrowTheOne_Curr,
                                                boolBorrowTheOne_Next,
                                                pstrErrMessage)

            ''9/13/2020 td''If (pstrErrMessage <> "") Then Exit Function
            If (pstrErrMessage <> "") Then Return "}" ''Added 9/13/2020 td

            strConcatenated = (strNewDigit & strConcatenated)

            ''Prepare for next iteration.
            boolBorrowTheOne_Curr = boolBorrowTheOne_Next
            boolBorrowTheOne_Next = False ''Reinitialize.

        Next intCharIndex

        ''Added 7/11/2016 Thomas Downes
        boolIsALeadingZero = (strNewDigit = "0" And (Not boolBorrowTheOne_Curr))

        ''Added 7/11/2016 Thomas Downes
        If (boolIsALeadingZero) Then
            ''6/25/2019 td''MsgBox("How strange!!  A leading zero!", vbExclamation)
        End If ''End of "If (strNewDigit = "0") Then"

        If (boolBorrowTheOne_Curr) Then strConcatenated = ("1" & strConcatenated)

        SubPaddedDecStrings = strConcatenated
        Return SubPaddedDecStrings ''Added 9/13/2020 td

    End Function ''End of Function SubPaddedDecStrings

    Private Function SubDecDigits_BorrowOne(ByVal pcharDecDigit1 As Char,
                              ByVal pcharDecDigit2 As Char,
                              ByVal pboolThenSubtract1 As Boolean,
                              ByRef pboolBorrowThe1 As Boolean,
                              ByRef pstrErrMessage As String) As Char ''9/13 As String
        ''
        '' Modified 9/13/2020 thomas downes
        ''
        Dim charDecDigit_Temp As Char ''9/13 String
        Dim charDecDigit_Final As Char ''9/13 String
        Dim boolBorrowThe1_Temp1 As Boolean
        Dim boolBorrowThe1_Temp2 As Boolean

        ''
        ''Initial pass.    Create a temporary digit.     
        ''
        charDecDigit_Temp = SubDecDigits_ByArrays(pcharDecDigit1, pcharDecDigit2, boolBorrowThe1_Temp1, pstrErrMessage)

        ''9/13/2020 td''If (pstrErrMessage <> "") Then Exit Function
        If (pstrErrMessage <> "") Then Return "{"c ''-----"See error msg #1." ''Exit Function

        ''6/25/2019 td''If (pboolThenAdd1) Then
        If (pboolThenSubtract1) Then

            pboolBorrowThe1 = False ''Reinitialize.

            ''6/25/2019 td''charDecDigit_Final = AddDecDigits_ByArrays(charDecDigit_Temp, "1", boolBorrowThe1_Temp2, pstrErrMessage)
            charDecDigit_Final = SubDecDigits_ByArrays(charDecDigit_Temp, "1"c, boolBorrowThe1_Temp2, pstrErrMessage)

            pboolBorrowThe1 = (boolBorrowThe1_Temp1 Or boolBorrowThe1_Temp2)
            ''-----If (pstrErrMessage <> "") Then Exit Function
            If (pstrErrMessage <> "") Then Return "}"c ''----"See error msg #2." ''Exit Function

        Else
            charDecDigit_Final = charDecDigit_Temp
            pboolBorrowThe1 = boolBorrowThe1_Temp1

        End If ''End of "If (pboolThenBorrow1) Then ..... Else ...."

        SubDecDigits_BorrowOne = charDecDigit_Final

    End Function ''end of "Private Function SubDecDigits_BorrowOne"

    Private Function SubDecDigits_ByArrays(ByVal pcharDecDigit1 As Char,
                                           ByVal pcharDecDigit2 As Char,
                              ByRef pboolBorrowThe10 As Boolean,
                              ByRef pstrErrMessage As String) As Char ''------String
        ''Private Function SubDecDigits_ByArrays(ByVal pcharDecDigit1 As String,
        ''                          ByVal pcharDecDigit2 As String,
        ''                           ByRef pboolBorrowThe10 As Boolean,
        ''                          ByRef pstrErrMessage As String) As String

        Dim intIndex1 As Integer
        Dim intIndex2 As Integer
        Dim arrayDecDigs() As Char ''------String
        Dim boolMatched1 As Boolean
        Dim boolMatched2 As Boolean
        Dim intIndexCombined As Integer

        If (pcharDecDigit1 = " " Or pcharDecDigit2 = " ") Then
            ''6/25 td''If (pcharDecDigit1 = " ") Then SubDecDigits_ByArrays = pcharDecDigit2
            If (pcharDecDigit1 = " ") Then pstrErrMessage = "Whitespace character @@@@@@@" ''Added 9/13/2020 thomas d.
            If (pcharDecDigit1 = " ") Then Throw New Exception("Whitespace character @@@@@@@") ''6/25 td'' SubDecDigits_ByArrays = pcharDecDigit2

            If (pcharDecDigit2 = " ") Then SubDecDigits_ByArrays = pcharDecDigit1
            ''----9/13/2020 td---Exit Function
            Return "z"c   ''----"See error mssg #1."
        End If ''End of "If (pcharDecDigit1 = " " Or pcharDecDigit2 = " ") Then"

        ReDim arrayDecDigs(0 To 9)

        arrayDecDigs(0) = "0"c
        arrayDecDigs(1) = "1"c
        arrayDecDigs(2) = "2"c
        arrayDecDigs(3) = "3"c
        arrayDecDigs(4) = "4"c
        arrayDecDigs(5) = "5"c
        arrayDecDigs(6) = "6"c
        arrayDecDigs(7) = "7"c
        arrayDecDigs(8) = "8"c
        arrayDecDigs(9) = "9"c

        For intIndex1 = 0 To 9
            boolMatched1 = (pcharDecDigit1 = arrayDecDigs(intIndex1))
            If boolMatched1 Then Exit For
        Next intIndex1

        ''Added 6/25/2019 td   
        For intIndex2 = 0 To 9
            boolMatched2 = (pcharDecDigit2 = arrayDecDigs(intIndex2))
            If boolMatched2 Then Exit For
        Next intIndex2

        If (Not boolMatched1) Then
            Beep()
            pstrErrMessage = "#1 The digit """ & pcharDecDigit1 & """ is not recognized. (SubDecDigits_ByArrays)  "
            ''6/25/2019 td''Exit Function
            Return "y"c  ''----pstrErrMessage
        End If ''End of "If (Not boolMatched1) Then"

        If (Not boolMatched2) Then
            Beep()
            pstrErrMessage = "#2 The digit """ & pcharDecDigit2 & """ is not recognized. (SubDecDigits_ByArrays)  "
            ''6/25/2019 td''Exit Function
            Return "x"c ''----pstrErrMessage
        End If ''End of "If (Not boolMatched1) Then"

        ''6/25/2019 td''intIndexCombined = intIndex1 ''Initialize.

        ''6/25/2019 td''For intIndex2 = 0 To 9
        ''    boolMatched2 = (pcharDecDigit2 = arrayDecDigs(intIndex2))
        ''    If boolMatched2 Then
        ''        Exit For
        ''    Else
        ''        ''Increment the combined index.
        ''        intIndexCombined = (1 + intIndexCombined)
        ''        If (intIndexCombined >= 10) Then
        ''            pboolBorrowThe1 = True
        ''            intIndexCombined = 0
        ''        End If ''End of "If (intIndexCombined >= 10) Then"
        ''    End If
        ''Next intIndex2

        intIndexCombined = (intIndex1 - intIndex2)
        pboolBorrowThe10 = (intIndex2 > intIndex1)
        If (pboolBorrowThe10) Then intIndexCombined += 10 ''Borrowing the 10, to avoid a negative number. 

        ''
        ''Return the Dec digit to which the 2nd loop has "pushed us"
        ''   incrementally.  So, the calculation is effectively as follows:
        ''
        ''   "6" + "7" = "6" + "1 + 1 + 1 + 1 + 1 + 1 + 1"
        ''                      7   8   9   0   1   2   3
        ''
        SubDecDigits_ByArrays = arrayDecDigs(intIndexCombined)

        Return SubDecDigits_ByArrays ''Added 9/13/2020 td

    End Function ''eNd of "Private Function SubDecDigits_ByArrays"

    Private Function PadLeft(paramString As String, param_Length As Integer) As String
        ''
        ''Copied from module modAddingDecs_Str.
        ''
        Dim intLenOfInput As Integer

        paramString = Trim(paramString)
        intLenOfInput = Len(Trim(paramString))

        If (intLenOfInput < param_Length) Then

            PadLeft = Strings.Space(param_Length - intLenOfInput) & paramString
            PadLeft = PadLeft.Replace(" ", "0") ''Added 6/25/2019 td

        Else

            PadLeft = paramString

        End If ''End of "If (intLenOfInput < param_Length) Then ... Else ..."

    End Function ''End of "Private Function PadLeft(paramString As String, param_Length As Integer) As String"

End Module
