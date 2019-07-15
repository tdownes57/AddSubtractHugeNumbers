Module modAddingHexs
    ''
    ''Encapsulated 6/21/2019  Thomas Downes
    ''
    Public Function AddAnyTwoHexStrings(pstrHex1 As String, pstrHex2 As String,
                                      pstrErrMessage As String) As String

        Dim strHex1_Padded As String
        Dim strHex2_Padded As String
        Dim intMaxLengthOfHex As Integer
        Dim intLength1 As Integer
        Dim intLength2 As Integer

        intLength1 = Len(Trim(pstrHex1))
        intLength2 = Len(Trim(pstrHex2))

        intMaxLengthOfHex = CInt(IIf(intLength1 >= intLength2, intLength1, intLength2))

        strHex1_Padded = PadLeft(Trim(pstrHex1), intMaxLengthOfHex)
        strHex2_Padded = PadLeft(Trim(pstrHex2), intMaxLengthOfHex)

        AddAnyTwoHexStrings = AddPaddedHexStrings(strHex1_Padded, strHex2_Padded,
                                                  pstrErrMessage)

        ''Don't return any value if there's an error message.
        If (pstrErrMessage <> "") Then AddAnyTwoHexStrings = ""

    End Function ''End of "Public Function AddAnyTwoHexStrings"

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

    Private Function AddPaddedHexStrings(pstrHex1 As String, pstrHex2 As String,
                                       ByRef pstrErrMessage As String) As String

        Dim intCharIndex As Integer
        Dim strConcatenated As String = ""
        Dim boolUnequalLengths As Boolean
        Dim strNewDigit As String = ""
        '--'Dim boolCarryTheOne As String
        Dim strHexDigit1 As String
        Dim strHexDigit2 As String
        Dim boolCarryTheOne_Curr As Boolean
        Dim boolCarryTheOne_Next As Boolean
        Dim boolIsALeadingZero As Boolean ''Added 7/11/2016 Thomas Downes

        boolUnequalLengths = (Len(pstrHex1) <> Len(pstrHex2))

        If (boolUnequalLengths) Then
            pstrErrMessage = "Hex strings are unequal in length."
            ''1/29/2019 td''Exit Function
            Return "áááááááááááááááááááá"
        End If ''End of "If (boolUnequalLengths) Then"

        For intCharIndex = Len(pstrHex1) To 1 Step -1

            strHexDigit1 = Mid$(pstrHex1, intCharIndex, 1)
            strHexDigit2 = Mid$(pstrHex2, intCharIndex, 1)

            strNewDigit = AddHexDigits_AddOne(strHexDigit1,
                                              strHexDigit2,
                                              boolCarryTheOne_Curr,
                                              boolCarryTheOne_Next,
                                              pstrErrMessage)

            ''1/29/2019 td''If (pstrErrMessage <> "") Then Exit Function
            If (pstrErrMessage <> "") Then Return "ÑÑÑÑÑÑÑÑÑÑÑÑÑÑÑÑÑÑÑÑÑÑÑÑÑÑÑÑÑÑÑÑ"

            strConcatenated = (strNewDigit & strConcatenated)

            ''Prepare for next iteration.
            boolCarryTheOne_Curr = boolCarryTheOne_Next
            boolCarryTheOne_Next = False ''Reinitialize.

        Next intCharIndex

        ''Added 7/11/2016 Thomas Downes
        boolIsALeadingZero = (strNewDigit = "0" And (Not boolCarryTheOne_Curr))

        ''Added 7/11/2016 Thomas Downes
        If (boolIsALeadingZero) Then
            ''Added 7/11/2016 Thomas Downes
            MsgBox("How strange!!  A leading zero!", vbExclamation)
        End If ''End of "If (strNewDigit = "0") Then"

        If (boolCarryTheOne_Curr) Then strConcatenated = ("1" & strConcatenated)

        AddPaddedHexStrings = strConcatenated

    End Function ''End of Function AddPaddedHexStrings

    Private Function AddHexDigits_AddOne(ByVal pstrHexDigit1 As String,
                                  ByVal pstrHexDigit2 As String,
                                  ByVal pboolThenAdd1 As Boolean,
                                  ByRef pboolCarryThe1 As Boolean,
                                  ByRef pstrErrMessage As String) As String

        Dim strHexDigit_Temp As String
        Dim strHexDigit_Final As String
        Dim boolCarryThe1_Temp1 As Boolean
        Dim boolCarryThe1_Temp2 As Boolean

        '7/02/2016'strHexDigit_Temp = AddHexDigits_Silly(pstrHexDigit1, pstrHexDigit2, boolCarryThe1_Temp1, pstrErrMessage)
        '7/02/2016'strHexDigit_Temp = AddHexDigits_CInt(pstrHexDigit1, pstrHexDigit2, boolCarryThe1_Temp1, pstrErrMessage)
        strHexDigit_Temp = AddHexDigits_ByArrays(pstrHexDigit1, pstrHexDigit2, boolCarryThe1_Temp1, pstrErrMessage)

        ''1/29/2019 td''If (pstrErrMessage <> "") Then Exit Function
        If (pstrErrMessage <> "") Then Return ""

        If (pboolThenAdd1) Then
            '7/01/2016'Dim boolCarryThe1_Temp2 As Boolean
            pboolCarryThe1 = False ''Reinitialize.
            '7/02/2016'strHexDigit_Final = AddHexDigits_Silly(strHexDigit_Temp, "1", boolCarryThe1_Temp2, pstrErrMessage)
            strHexDigit_Final = AddHexDigits_ByArrays(strHexDigit_Temp, "1", boolCarryThe1_Temp2, pstrErrMessage)
            '7/4/2016'pboolCarryThe1 = boolCarryThe1_Temp2
            pboolCarryThe1 = (boolCarryThe1_Temp1 Or boolCarryThe1_Temp2)
            ''1/29/2019 td''If (pstrErrMessage <> "") Then Exit Function
            If (pstrErrMessage <> "") Then Return ""
        Else
            strHexDigit_Final = strHexDigit_Temp
            pboolCarryThe1 = boolCarryThe1_Temp1
        End If ''End of "If (pboolThenAdd1) Then .... Else ...."

        AddHexDigits_AddOne = strHexDigit_Final

    End Function ''end of "Private Function AddHexDigits_AddOne"

    Private Function AddHexDigits_ByArrays(ByVal pstrHexDigit1 As String,
                                  ByVal pstrHexDigit2 As String,
                                  ByRef pboolCarryThe1 As Boolean,
                                  ByRef pstrErrMessage As String) As String

        Dim intIndex1 As Integer
        Dim intIndex2 As Integer
        Dim arrayHexDigs() As String
        Dim boolMatched1 As Boolean
        Dim boolMatched2 As Boolean
        Dim intIndexCombined As Integer

        If (pstrHexDigit1 = " " Or pstrHexDigit2 = " ") Then
            AddHexDigits_ByArrays = "" ''Added 1/29/2019 td
            If (pstrHexDigit1 = " ") Then AddHexDigits_ByArrays = pstrHexDigit2
            If (pstrHexDigit2 = " ") Then AddHexDigits_ByArrays = pstrHexDigit1
            ''1/29 td''Exit Function
            Return AddHexDigits_ByArrays
        End If ''End of "If (pstrHexDigit1 = " " Or pstrHexDigit2 = " ") Then"

        ReDim arrayHexDigs(0 To 15)

        arrayHexDigs(0) = "0"
        arrayHexDigs(1) = "1"
        arrayHexDigs(2) = "2"
        arrayHexDigs(3) = "3"
        arrayHexDigs(4) = "4"
        arrayHexDigs(5) = "5"
        arrayHexDigs(6) = "6"
        arrayHexDigs(7) = "7"
        arrayHexDigs(8) = "8"
        arrayHexDigs(9) = "9"
        arrayHexDigs(10) = "A"
        arrayHexDigs(11) = "B"
        arrayHexDigs(12) = "C"
        arrayHexDigs(13) = "D"
        arrayHexDigs(14) = "E"
        arrayHexDigs(15) = "F"

        For intIndex1 = 0 To 15
            boolMatched1 = (pstrHexDigit1 = arrayHexDigs(intIndex1))
            If boolMatched1 Then Exit For
        Next intIndex1

        If (Not boolMatched1) Then
            Beep()
            pstrErrMessage = "#1 The digit """ & pstrHexDigit1 & """ is not recognized. (AddHexDigits_ByArrays)  "
            ''1/29 td''Exit Function
            Return pstrErrMessage
        End If ''End of "If (Not boolMatched1) Then"

        intIndexCombined = intIndex1 ''Initialize.

        For intIndex2 = 0 To 15
            boolMatched2 = (pstrHexDigit2 = arrayHexDigs(intIndex2))
            If boolMatched2 Then
                Exit For
            Else
                ''Increment the combined index.
                intIndexCombined = (1 + intIndexCombined)
                If (intIndexCombined >= 16) Then
                    pboolCarryThe1 = True
                    intIndexCombined = 0
                End If ''End of "If (intIndexCombined >= 16) Then"
            End If
        Next intIndex2

        If (Not boolMatched2) Then
            Beep()
            pstrErrMessage = "The digit """ & pstrHexDigit2 & """ is not recognized."
            ''1/29/2019 td''Exit Function
            Return pstrErrMessage ''1/29 td'' ""
        End If ''End of "If (Not boolMatched2) Then"

        ''
        ''Return the hex digit to which the 2nd loop has "pushed us"
        ''   incrementally.  So, the calculation is effectively as follows:
        ''
        ''   "6" + "7" = "6" + "1 + 1 + 1 + 1 + 1 + 1 + 1"
        ''                      7   8   9   0   A   B   C
        ''
        AddHexDigits_ByArrays = arrayHexDigs(intIndexCombined)

    End Function ''eNd of "Private Function AddHexDigits_ByArrays"

    Private Function AddHexDigits_CInt(ByVal pstrHexDigit1 As String,
                                  ByVal pstrHexDigit2 As String,
                                  ByRef pboolCarryThe1 As Boolean,
                                  ByRef pstrErrMessage As String) As String
        ''
        ''The output will never be two(2) digits, only one.
        ''
        ''If two digits are needed, because the sum is >16, then the
        ''  ByRef Boolean will be True to indicate the multiple of 16.
        ''
        ''The output of "F" and "1" will _NOT_ be "10" but instead will be "0" [w/ pboolCarryThe1 = True].
        ''The output of "F" and "2" will _NOT_ be "10" but instead will be "1" [w/ pboolCarryThe1 = True].
        ''The output of "5" and "1" will be "6" [w/ pboolCarryThe1 = False].
        ''
        Dim strSumOfHex As String
        Dim strUnitsPlace As String

        strSumOfHex = Hex$(CInt("&H" & pstrHexDigit1) _
                         + CInt("&H" & pstrHexDigit2))

        If (Len(strSumOfHex) = 1) Then

            AddHexDigits_CInt = strSumOfHex

        Else
            pboolCarryThe1 = True
            strUnitsPlace = Right$(strSumOfHex, 1)
            AddHexDigits_CInt = strUnitsPlace
        End If ''End of "If (Len(strSumOfHex) = 1) Then ... Else ..."

    End Function ''Private Function AddHexDigits_CInt

End Module
