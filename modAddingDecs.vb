﻿Option Explicit On
Option Strict On
''
''Encapsulated 6/21/2019  Thomas Downes
''
Module modAddingDecs

    Public Function AddAnyTwoDecStrings(pstrDec1 As String, pstrDec2 As String,
                                 pstrErrMessage As String) As String
        ''
        ''
        ''
        Dim strDec1_Padded As String
        Dim strDec2_Padded As String
        Dim intMaxLengthOfDec As Integer
        Dim intLength1 As Integer
        Dim intLength2 As Integer

        intLength1 = Len(Trim(pstrDec1))
        intLength2 = Len(Trim(pstrDec2))

        intMaxLengthOfDec = CType(IIf(intLength1 >= intLength2, intLength1, intLength2), Integer)

        strDec1_Padded = PadLeft(Trim(pstrDec1), intMaxLengthOfDec)
        strDec2_Padded = PadLeft(Trim(pstrDec2), intMaxLengthOfDec)

        AddAnyTwoDecStrings = AddPaddedDecStrings(strDec1_Padded, strDec2_Padded,
                                              pstrErrMessage)

        ''Don't return any value if there's an error message.
        If (pstrErrMessage <> "") Then AddAnyTwoDecStrings = ""

    End Function ''End of "Public Function AddAnyTwoDecStrings(pstrDec1 As String, pstrDec2 As String, ......"

    Private Function PadLeft(paramString As String, param_Length As Integer) As String

        Dim intLenOfInput As Integer

        paramString = Trim(paramString)
        intLenOfInput = Len(Trim(paramString))

        If (intLenOfInput < param_Length) Then

            PadLeft = Strings.Space(param_Length - intLenOfInput) & paramString

        Else

            PadLeft = paramString

        End If ''End of "If (intLenOfInput < param_Length) Then ... Else ..."

    End Function ''End of "Private Function PadLeft(paramString As String, param_Length As Integer) As String"

    Private Function AddPaddedDecStrings(pstrDec1 As String, pstrDec2 As String,
                                     ByRef pstrErrMessage As String) As String

        Dim intCharIndex As Integer
        Dim strConcatenated As String = ""
        Dim boolUnequalLengths As Boolean
        Dim strNewDigit As String = ""
        '--'Dim boolCarryTheOne As String
        Dim strDecDigit1 As String
        Dim strDecDigit2 As String
        Dim boolCarryTheOne_Curr As Boolean
        Dim boolCarryTheOne_Next As Boolean
        Dim boolIsALeadingZero As Boolean ''Added 7/11/2016 Thomas Downes

        boolUnequalLengths = (Len(pstrDec1) <> Len(pstrDec2))

        If (boolUnequalLengths) Then
            pstrErrMessage = "Dec strings are unequal in length."
            Exit Function
        End If

        For intCharIndex = Len(pstrDec1) To 1 Step -1

            strDecDigit1 = Mid$(pstrDec1, intCharIndex, 1)
            strDecDigit2 = Mid$(pstrDec2, intCharIndex, 1)

            strNewDigit = AddDecDigits_AddOne(strDecDigit1,
                                          strDecDigit2,
                                          boolCarryTheOne_Curr,
                                          boolCarryTheOne_Next,
                                          pstrErrMessage)

            If (pstrErrMessage <> "") Then Exit Function

            strConcatenated = (strNewDigit & strConcatenated)

            ''Prepare for next iteration.
            boolCarryTheOne_Curr = boolCarryTheOne_Next
            boolCarryTheOne_Next = False ''Reinitialize.

        Next intCharIndex

        ''Added 7/11/2016 Thomas Downes
        boolIsALeadingZero = (strNewDigit = "0" And (Not boolCarryTheOne_Curr))

        ''Added 7/11/2016 Thomas Downes
        If (boolIsALeadingZero) Then
            MsgBox("How strange!!  A leading zero!", vbExclamation)
        End If ''End of "If (strNewDigit = "0") Then"

        If (boolCarryTheOne_Curr) Then strConcatenated = ("1" & strConcatenated)

        AddPaddedDecStrings = strConcatenated

    End Function ''End of Function AddPaddedDecStrings

    Private Function AddDecDigits_AddOne(ByVal pstrDecDigit1 As String,
                              ByVal pstrDecDigit2 As String,
                              ByVal pboolThenAdd1 As Boolean,
                              ByRef pboolCarryThe1 As Boolean,
                              ByRef pstrErrMessage As String) As String

        Dim strDecDigit_Temp As String
        Dim strDecDigit_Final As String
        Dim boolCarryThe1_Temp1 As Boolean
        Dim boolCarryThe1_Temp2 As Boolean

        strDecDigit_Temp = AddDecDigits_ByArrays(pstrDecDigit1, pstrDecDigit2, boolCarryThe1_Temp1, pstrErrMessage)

        If (pstrErrMessage <> "") Then Exit Function

        If (pboolThenAdd1) Then
            pboolCarryThe1 = False ''Reinitialize.
            strDecDigit_Final = AddDecDigits_ByArrays(strDecDigit_Temp, "1", boolCarryThe1_Temp2, pstrErrMessage)
            pboolCarryThe1 = (boolCarryThe1_Temp1 Or boolCarryThe1_Temp2)
            If (pstrErrMessage <> "") Then Exit Function
        Else
            strDecDigit_Final = strDecDigit_Temp
            pboolCarryThe1 = boolCarryThe1_Temp1
        End If

        AddDecDigits_AddOne = strDecDigit_Final

    End Function ''end of "Private Function AddDecDigits_AddOne"

    Private Function AddDecDigits_ByArrays(ByVal pstrDecDigit1 As String,
                              ByVal pstrDecDigit2 As String,
                              ByRef pboolCarryThe1 As Boolean,
                              ByRef pstrErrMessage As String) As String

        Dim intIndex1 As Integer
        Dim intIndex2 As Integer
        Dim arrayDecDigs() As String
        Dim boolMatched1 As Boolean
        Dim boolMatched2 As Boolean
        Dim intIndexCombined As Integer

        If (pstrDecDigit1 = " " Or pstrDecDigit2 = " ") Then
            If (pstrDecDigit1 = " ") Then AddDecDigits_ByArrays = pstrDecDigit2
            If (pstrDecDigit2 = " ") Then AddDecDigits_ByArrays = pstrDecDigit1
            Exit Function
        End If

        ReDim arrayDecDigs(0 To 9)

        arrayDecDigs(0) = "0"
        arrayDecDigs(1) = "1"
        arrayDecDigs(2) = "2"
        arrayDecDigs(3) = "3"
        arrayDecDigs(4) = "4"
        arrayDecDigs(5) = "5"
        arrayDecDigs(6) = "6"
        arrayDecDigs(7) = "7"
        arrayDecDigs(8) = "8"
        arrayDecDigs(9) = "9"

        For intIndex1 = 0 To 9
            boolMatched1 = (pstrDecDigit1 = arrayDecDigs(intIndex1))
            If boolMatched1 Then Exit For
        Next intIndex1

        If (Not boolMatched1) Then
            Beep()
            pstrErrMessage = "#1 The digit """ & pstrDecDigit1 & """ is not recognized. (AddDecDigits_ByArrays)  "
            Exit Function
        End If ''End of "If (Not boolMatched1) Then"

        intIndexCombined = intIndex1 ''Initialize.

        For intIndex2 = 0 To 9
            boolMatched2 = (pstrDecDigit2 = arrayDecDigs(intIndex2))
            If boolMatched2 Then
                Exit For
            Else
                ''Increment the combined index.
                intIndexCombined = (1 + intIndexCombined)
                If (intIndexCombined >= 10) Then
                    pboolCarryThe1 = True
                    intIndexCombined = 0
                End If ''End of "If (intIndexCombined >= 10) Then"
            End If
        Next intIndex2

        If (Not boolMatched2) Then
            Beep()
            pstrErrMessage = "The digit """ & pstrDecDigit2 & """ is not recognized."
            Exit Function
        End If ''End of "If (Not boolMatched2) Then"

        ''
        ''Return the Dec digit to which the 2nd loop has "pushed us"
        ''   incrementally.  So, the calculation is effectively as follows:
        ''
        ''   "6" + "7" = "6" + "1 + 1 + 1 + 1 + 1 + 1 + 1"
        ''                      7   8   9   0   1   2   3
        ''
        AddDecDigits_ByArrays = arrayDecDigs(intIndexCombined)

    End Function

End Module
