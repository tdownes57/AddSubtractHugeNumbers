Option Explicit On ''Added 1/29/2019 td 
Option Strict On ''Added 1/29/2019 td 

''Added 1/29/2019 td 

Module modDecToHexByStrings ''Added 1/29/2019 td 


    ''
    '' D-E-C-I-M-A-L to H-E-X-A-D-E-C-I-M-A-L Conversion
    ''
    ''This module (modHexToDecByStrings) is created for C.I. Solutions, of Los Alamitos, California.
    ''   ---6/30/2016 Thomas Downes
    ''
    Private modstrDecimal As String ''added 6/30/2016
    Private arrayPowersOf10_Hex() As String ''added 7/02/2016

    Public Function RandomHexDigit() As String

        Dim strHexDigit As String
        strHexDigit = Hex$(Int(16 * Rnd(1)))
        RandomHexDigit = strHexDigit

    End Function

    Public Function RandomDecDigit() As String

        Dim strDecDigit As String
        strDecDigit = CStr(Int(10 * Rnd(1)))
        RandomDecDigit = strDecDigit

    End Function

    Public Function ConvertDecToHex(pstrDecimal As String, ByRef pstrErrMessage As String) As String
        ''
        ''
        ''
        Dim intCharIndex As Integer
        Dim strDecimalDigit As String
        Dim strHex_Temp As String
        Dim strRunningTotalHex As String = ""
        Dim intPowerOf10 As Integer

        modstrDecimal = Trim(pstrDecimal)
        pstrDecimal = Trim(pstrDecimal)

        For intCharIndex = 1 To Len(pstrDecimal)

            intPowerOf10 = (Len(pstrDecimal) - intCharIndex)

            strDecimalDigit = Mid$(pstrDecimal, intCharIndex, 1)

            ''Added 7/04/2016 Thomas Downes
            If (Not IsNumeric(pstrDecimal)) Then
                pstrErrMessage = "A non-decimal digit is encoutered, """ & strDecimalDigit & """."
                ''1/29 td''Exit Function
                Return pstrErrMessage
            End If ''End of "If (Not IsNumeric(pstrDecimal)) Then"

            ''Added 7/04/2016 Thomas Downes
            If (strDecimalDigit = "0" And strRunningTotalHex <> "") Then
                ''This calculation will not affect the running total.
                GoTo Skip_GoToNextLoop
            End If ''End of "If (strDecimalDigit = "0" And strRunningTotalHex <> "") Then"

            strHex_Temp = GiveHexOfPowerOf10_TimesN(intPowerOf10, CInt(strDecimalDigit), pstrErrMessage)

            If (pstrErrMessage <> "") Then

                ''Don't return any values other than the error message.
                strHex_Temp = ""
                ConvertDecToHex = ""
                ''1/29 td''Exit Function
                Return "]]]]]]]]]]]]]]]]]]]]]]]]]]"

            ElseIf (strRunningTotalHex = "") Then

                strRunningTotalHex = strHex_Temp

            Else

                strRunningTotalHex = AddAnyTwoHexStrings(strHex_Temp, strRunningTotalHex, pstrErrMessage)

                ''1/29/2019 td''If (pstrErrMessage <> "") Then Exit Function
                ''1/29/2019 td''If (pstrErrMessage <> "") Then Return pstrErrMessage
                If (pstrErrMessage <> "") Then Return "[[[[[[[[[[[[[[[[[[[[[[[[[[["

            End If ''End of "If (pstrErrMessage <> "") Then ... ElseIf ... Else ...."

            ''Added 7/13/2016 Thomas Downes
Skip_GoToNextLoop:

        Next intCharIndex

        ConvertDecToHex = strRunningTotalHex

    End Function ''End of "Public Function ConvertDecToHex"

    Private Function GiveHexOfPowerOf10_TimesN(pintPowerOf10 As Integer,
                                               pintTimesN As Integer,
                                               ByRef pstrErrMessage As String) As String

        Dim intLoop As Integer
        Dim strRunningTotalHex As String = ""
        Dim strPowerOf10_Hex As String
        Dim boolMissingPower As Boolean

        '7/02/2016'If (pintPowerOf10) Then
        If (pintTimesN = 0) Then
            GiveHexOfPowerOf10_TimesN = Left$("00000000000000000000000000000000000000000000", (1 + pintPowerOf10))
            Exit Function
        ElseIf (pintPowerOf10 = 0) Then
            ''Added 7/02/2016 Thomas Downes
            GiveHexOfPowerOf10_TimesN = CStr(pintTimesN)
            Exit Function
        End If ''End of "If (pintPowerOf10 = 0) Then"

        ''strPowerOf10_Hex = GetPowerOf10_InHex(pintPowerOf10, boolMissingPower, pstrErrMessage)
        strPowerOf10_Hex = GetPowerOf10_InHex_Main(pintPowerOf10, boolMissingPower, pstrErrMessage)

        ''1/29/2019 td''If ("" <> pstrErrMessage) Then Exit Function
        If (pstrErrMessage <> "") Then Return "éééééééééééé"

        If (boolMissingPower) Then pstrErrMessage = GiveMsgToProgrammer(modstrDecimal, pintPowerOf10, pintPowerOf10)
        ''1/29 td''If (boolMissingPower) Then Exit Function
        If (boolMissingPower) Then Return "îæîæîæîæîæîæîæîæîæîæ"

        For intLoop = 1 To pintTimesN

            If (strRunningTotalHex = "") Then

                strRunningTotalHex = strPowerOf10_Hex

            Else

                strRunningTotalHex = AddAnyTwoHexStrings(strPowerOf10_Hex, strRunningTotalHex, pstrErrMessage)

                ''1/29/2019 td''If (pstrErrMessage <> "") Then Exit Function
                If (pstrErrMessage <> "") Then Return "//////////////////"

            End If ''End of "If (strRunningTotalHex = "") Then .... Else ...."

        Next intLoop

        GiveHexOfPowerOf10_TimesN = strRunningTotalHex

    End Function ''End of "Private Function GiveHexOfPowerOf10_TimesN"

    Private Function GiveMsgToProgrammer(pstrDecimal As String,
                                   pintPowerOf10_Start As Integer,
                                   pintPowerOf10_End As Integer) As String

        Dim intPower As Integer
        Dim strListOfPowers As String = ""
        Dim strMessage As String

        For intPower = pintPowerOf10_Start To pintPowerOf10_End

            '//'strListOfPowers = strListOfPowers & vbCrLf & _
            '//'                  CStr(10 ^ intPower)
            strListOfPowers = strListOfPowers & vbCrLf &
                              "1" & Left("000000000000000000000000000000000000", intPower) & vbCrLf &
                              CStr(10 ^ intPower) & "   (10 to the power of " & CStr(intPower) & ")"

        Next intPower

        strMessage = "Cannot convert " & pstrDecimal & vbCrLf & vbCrLf &
                     "Please ask a CI Solutions programmer to add the following " &
                     " powers of 10, but converted to hexadecimal." &
                     vbCrLf & vbCrLf &
                     "(PowersOf10_InHex / GiveMsgToProgrammer)" & vbCrLf &
                     strListOfPowers

        ';;'MsgBox strMessage, vbExclamation

        GiveMsgToProgrammer = strMessage

    End Function ''End of "Public Sub GiveMsgToProgrammer"

    Private Function GetPowerOf10_InHex_Main(pintPowerOf10 As Integer, ByRef pboolMissing As Boolean,
                                        pstrErrMessage As String) As String
        ''
        '' Uses arrays to store calculated values.
        ''
        Static static_intArrayLowerBound As Integer

        Dim strHex As String

        If (static_intArrayLowerBound = 0) Then
            ''This tells the lowest power of 10 which needs to be calculated
            ''   (rather than rely on hard-coding).
            ''   ---7/3/2016 Thomas Downes
            static_intArrayLowerBound = GetPowerOf10_FirstMissing()
        End If ''End of "If (static_intArrayLowerBound = 0) Then"

        ''Select Case pintPowerOf10
        ''    Case 0: strHex = "1"
        ''    Case 1: strHex = "A" ''                       10 in hexadecimal.
        ''    Case 2: strHex = "64" ''                     100 in hexadecimal.
        ''    Case 3: strHex = "3E8" ''                  1,000 in hexadecimal.
        ''    Case 4: strHex = "2710" ''                10,000 in hexadecimal.
        ''    Case 5: strHex = "186A0" ''              100,000 in hexadecimal.
        ''    Case 6: strHex = "F4240" ''            1,000,000 in hexadecimal.
        ''    Case 7: strHex = "989680" ''          10,000,000 in hexadecimal.
        ''    Case 8: strHex = "5F5E100" ''        100,000,000 in hexadecimal.
        ''    Case 9: strHex = "3B9ACA00" ''     1,000,000,000 in hexadecimal.
        ''
        ''    Case 10, 11, 12, 13, 14

        If (pintPowerOf10 < static_intArrayLowerBound) Then

            strHex = GetPowerOf10_InHex_Simple(pintPowerOf10, pboolMissing)

        Else

            strHex = GetPowerOf10_InHex_ByArray(pintPowerOf10, pstrErrMessage)

        End If

        pboolMissing = pboolMissing Or ("" = Trim(strHex))

        GetPowerOf10_InHex_Main = strHex

    End Function ''End of "Private Function GetPowerOf10_InHex_Main"

    Private Function GetPowerOf10_InHex_ByArray(pintPowerOf10 As Integer, pstrErrMessage As String) As String
        ''
        ''
        ''Assumption:   For each call to function ConvertDecToHex(),
        ''   the current function (GetPowerOf10_InHex_ByArray) will be called
        ''   with an integer parameter of 15, then called with an integer parameter
        ''   of 16, then 17, and so forth, in increasing numerical order; until
        ''   the calls stop.
        ''
        ''
        Static static_intLBound As Integer

        Dim strOut As String
        Dim strDummy As String
        Dim boolArrayNeedsFirstItem As Boolean
        Dim boolArrayNeedsNextItem As Boolean
        ''Dim strHexTimes10 As String
        Dim strHex_byAdding As String
        Dim strHexForPriorPower As String
        Dim intNextLowerPower As Integer
        Dim boolMustCalculate As Boolean
        Dim boolTakeValueFromArray As Boolean
        Dim boolFirstRunOfThisFunction As Boolean

        ']]'On Error Resume Next

        'See above.'Static static_intLBound As Integer
        If (static_intLBound = 0) Then
            ''This tells the lowest power of 10 which needs to be calculated
            ''   (rather than rely on hard-coding).
            boolFirstRunOfThisFunction = True
            static_intLBound = GetPowerOf10_FirstMissing()
        End If ''End of "If (static_intLBound = 0) Then"

        ']]'''Test to see if the array has been started yet or not.
        ']]'If (pintPowerOf10 >= static_intLBound) Then
        ']]'    strDummy = arrayPowersOf10_Hex(-1 + pintPowerOf10)
        ']]'End If

        ']]'If (Err.Number <> 0) Then
        ']]'  ''boolArrayNeedsFirstItem = (Err.Number <> 0)
        ']]'  boolArrayNeedsFirstItem = (Err.Number = 9)
        ']]'  If (Err.Number <> 9) Then
        ']]'     pstrErrMessage = Err.Description & " (GetPowerOf10_InHex_ByArray)"
        ']]'     MsgBox "Unexpected error..!!  " & Err.Description, vbExclamation
        ']]'     Exit Function
        ']]'  End If ''End of "If (Err.Number <> 9) Then"
        ']]'End If ''End of "If (Err.Number <> 0) Then"

        On Error GoTo 0 ''Resume natural error-handling

        ''Added 7/3/2015 Thomas Downes
        boolArrayNeedsFirstItem = boolFirstRunOfThisFunction

        If (boolArrayNeedsFirstItem) Then
            ''Initialize the array.
            '7/3/2016'static_intLBound = pintPowerOf10
            '7/3/2016'ReDim arrayPowersOf10_Hex(static_intLBound To pintPowerOf10)
            ''1/29/2019 td''ReDim arrayPowersOf10_Hex(static_intLBound To static_intLBound)
            Dim intUBound_Temp As Integer = static_intLBound ''Added 1/29/2019 td
            ReDimArrayPowersOf10_Hex_Refresh(static_intLBound, intUBound_Temp) ''1/29 td''pintPowerOf10)

            '7/3/2016'boolMustCalculate = True
            '7/3/2016'boolMustCalculate = (pintPowerOf10 >= static_intLBound)
            arrayPowersOf10_Hex(static_intLBound) =
                  GetPowerOf10_ByAdding(static_intLBound, pstrErrMessage)
            If (pstrErrMessage <> "") Then Exit Function
        End If ''End of "If (boolArrayNeedsFirstItem) Then"

        ''By executing the next two(2) commands, and then checking (0 <> Err.Number),
        ''   we can find out if the hexadecimal for the current power of 10
        ''   has been stored in the array or not.
        ''
        On Error Resume Next
        strOut = arrayPowersOf10_Hex(pintPowerOf10)

        Dim intError As Integer
        Dim boolArraySizeError As Boolean
        Dim boolAnyError As Boolean
        Dim boolMustRedim As Boolean

        intError = Err.Number
        boolAnyError = (0 <> intError)
        boolArraySizeError = (9 = intError)

        On Error GoTo 0 ''Added 7/04/2016 Thomas Downes

        '7/3/2016'If (0 <> Err.Number) Then
        '7/4/2016'If ((0 <> Err.Number) Or ("" = strOut)) Then
        If (boolAnyError Or ("" = strOut)) Then

            ''boolArrayNeedsNextItem = (0 <> Err.Number)
            ''boolArrayNeedsNextItem = (9 = Err.Number)
            '7/4/2016'boolArrayNeedsNextItem = ((9 = Err.Number) Or ("" = strOut))
            boolArrayNeedsNextItem = (boolArraySizeError Or ("" = strOut))

            If (boolArrayNeedsNextItem) Then
                ''
                ''Assumption:   For each call to function ConvertDecToHex(),
                ''   the current function (GetPowerOf10_InHex_ByArray) will be called
                ''   with an integer parameter of 15, then called with an integer parameter
                ''   of 16, then 17, and so forth, in increasing numerical order; until
                ''   the calls stop.
                ''
                ''Crucial!!  The keyword "Preserve" below prevents the previously-stored
                ''  array values from being lost/cleared.
                ''
                On Error GoTo 0
                boolMustRedim = boolArraySizeError

                If (boolMustRedim) Then
                    ''1/29/2019 td''ReDim Preserve arrayPowersOf10_Hex(static_intLBound To pintPowerOf10)
                    ReDimArrayPowersOf10_Hex_Preserve(static_intLBound, pintPowerOf10)
                End If ''End of "If (boolMustRedim) Then"
                boolMustCalculate = True

            End If ''End of "If (boolArrayNeedsNextItem) Then"

            If (Err.Number <> 9 And Err.Number <> 0) Then
                pstrErrMessage = Err.Description & " (GetPowerOf10_InHex_ByArray)"
                MsgBox("Unexpected error!!..  " & Err.Description, vbExclamation)
                Exit Function
            End If ''End of "If (Err.Number <> 9 And Err.Number <> 0) Then"

        End If ''End of "If (0 <> Err.Number) Then"

        On Error GoTo 0 ''Resume natural error-handling

        ''
        ''Possibly confusing!!
        ''
        ''Let's flip the boolean's polarity into an
        ''  "antonymic" Boolean.
        ''
        boolTakeValueFromArray = (Not boolMustCalculate)

        If (boolTakeValueFromArray) Then

            strOut = arrayPowersOf10_Hex(pintPowerOf10)

        ElseIf (boolMustCalculate) Then

            '7/02/2016'strHexForPriorPower = GetPowerOf10_InHex_Simple(-1 + pintPowerOf10)
            '7/03/2016'intNextLowerPower = (-1 + pintPowerOf10)

            ''Multiply the next lower power of 10 (expressed in hex) by 10,
            ''   so that we have the desired power of 10 (also expressed in hex).
            ''   ----7/02/2016 Thomas Downes
            ''
            '7/03/2016'strHexTimes10 = GiveHexOfPowerOf10_TimesN(intNextLowerPower, 10, pstrErrMessage)

            strHex_byAdding = GetPowerOf10_ByAdding(pintPowerOf10, pstrErrMessage)

            If (pstrErrMessage <> "") Then Exit Function

            ''Save the value.
            '7/03/2016'arrayPowersOf10_Hex(pintPowerOf10) = strHexTimes10
            arrayPowersOf10_Hex(pintPowerOf10) = strHex_byAdding
            strOut = strHex_byAdding

        End If

        GetPowerOf10_InHex_ByArray = strOut

    End Function

    Private Function GetPowerOf10_ByAdding(pintPowerOf10 As Integer, pstrErrMessage As String) As String

        Dim intNextLowerPower As Integer
        Dim strHexTimes10 As String

        '7/02/2016'strHexForPriorPower = GetPowerOf10_InHex_Simple(-1 + pintPowerOf10)
        intNextLowerPower = (-1 + pintPowerOf10)

        ''Multiply the next lower power of 10 (expressed in hex) by 10,
        ''   so that we have the desired power of 10 (also expressed in hex).
        ''   ----7/02/2016 Thomas Downes
        ''
        strHexTimes10 = GiveHexOfPowerOf10_TimesN(intNextLowerPower, 10, pstrErrMessage)

        ''1/29/2019 td''If (pstrErrMessage <> "") Then Exit Function
        If (pstrErrMessage <> "") Then Return strHexTimes10

        GetPowerOf10_ByAdding = strHexTimes10

    End Function ''end of "Private Function GetPowerOf10_ByAdding"

    Private Function GetPowerOf10_InHex_Simple(pintPowerOf10 As Integer, ByRef pboolMissingHardcodedValue As Boolean) As String

        Dim strHex As String

        Select Case pintPowerOf10
            Case 0 : strHex = "1"
            Case 1 : strHex = "A" ''                       10 in hexadecimal.
            Case 2 : strHex = "64" ''                     100 in hexadecimal.
            Case 3 : strHex = "3E8" ''                  1,000 in hexadecimal.
            Case 4 : strHex = "2710" ''                10,000 in hexadecimal.
            Case 5 : strHex = "186A0" ''              100,000 in hexadecimal.
            Case 6 : strHex = "F4240" ''            1,000,000 in hexadecimal.
            Case 7 : strHex = "989680" ''          10,000,000 in hexadecimal.
            Case 8 : strHex = "5F5E100" ''        100,000,000 in hexadecimal.
            Case 9 : strHex = "3B9ACA00" ''     1,000,000,000 in hexadecimal.
            Case 10 : strHex = "2540BE400" ''  10,000,000,000 in hexadecimal.
            Case 11 : strHex = "174876E800" ''100,000,000,000 in hexadecimal.
            Case 12 : strHex = "E8D4A51000"
            Case 13 : strHex = "9184E72A000"
            Case 14 : strHex = "5AF3107A4000"
            Case 15 : strHex = "" : pboolMissingHardcodedValue = True
            Case 16 : strHex = "" : pboolMissingHardcodedValue = True
            Case 17 : strHex = "" : pboolMissingHardcodedValue = True
            Case Else
                strHex = "" : pboolMissingHardcodedValue = True

        End Select

        pboolMissingHardcodedValue = (pboolMissingHardcodedValue Or ("" = Trim(strHex)))

        GetPowerOf10_InHex_Simple = strHex

    End Function ''End of "Private Function GetPowerOf10_InHex_Simple"

    Private Function GetPowerOf10_FirstMissing() As Integer

        Dim intPowerOf10 As Integer
        Dim boolMissingHardcoding As Boolean

        For intPowerOf10 = 1 To 100

            GetPowerOf10_InHex_Simple(intPowerOf10, boolMissingHardcoding)
            If (boolMissingHardcoding) Then Exit For

        Next intPowerOf10

        GetPowerOf10_FirstMissing = intPowerOf10

    End Function

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

            PadLeft = Space(param_Length - intLenOfInput) & paramString

        Else

            PadLeft = paramString

        End If

    End Function

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

    Private Sub ReDimArrayPowersOf10_Hex_Refresh(par_intLBound As Integer, par_intUBound As Integer)
        ''
        ''Added 1/29/2019 thomas downes  
        ''
        ''1/29/2019 td''ReDim arrayPowersOf10_Hex(static_intLBound To static_intLBound)
        ''1/29/2019 td''ReDimArrayPowersOf10_Hex(static_intLBound, static_intUBound)

        Const c_boolRefreshArray As Boolean = True
        Dim boolPreserveValues As Boolean = (Not c_boolRefreshArray)

        ReDimArrayPowersOf10_Hex(par_intLBound, par_intUBound, boolPreserveValues)

        ''If (c_boolRefreshArray) Then
        ''    ReDim arrayPowersOf10_Hex(par_intUBound)
        ''Else
        ''    ReDim Preserve arrayPowersOf10_Hex(par_intUBound)
        ''End If ''End of "If (c_boolRefreshArray) Then"

        ''''
        ''''Below the lower bound, fill with garbage / non-integer values.   ---1/29/2019 td
        ''''
        ''For intEach As Integer = 0 To (-1 + par_intLBound)

        ''    ''Fill these strings with nonsense / garbage characters.  ---1/29/2019 td
        ''    arrayPowersOf10_Hex(intEach) = "@@@@@@@@"

        ''Next intEach

    End Sub ''eND OF "Private Sub ReDimArrayPowersOf10_Hex_Refresh()"

    Private Sub ReDimArrayPowersOf10_Hex_Preserve(par_intLBound As Integer, par_intUBound As Integer)
        ''
        ''Added 1/29/2019 thomas downes  
        ''
        ''1/29/2019 td''ReDim arrayPowersOf10_Hex(static_intLBound To static_intLBound)
        ''1/29/2019 td''ReDimArrayPowersOf10_Hex(static_intLBound, static_intUBound)

        Const c_boolPreserveValues As Boolean = False ''(Not c_boolRefreshArray)

        ReDimArrayPowersOf10_Hex(par_intLBound, par_intUBound, c_boolPreserveValues)

        ''ReDim arrayPowersOf10_Hex(par_intUBound)

        ''For intEach As Integer = 0 To (-1 + par_intLBound)

        ''    ''Fill these strings with nonsense / garbage characters.
        ''    arrayPowersOf10_Hex(intEach) = "+++++++++++++++++++++"

        ''Next intEach

    End Sub ''eND OF "Private Sub ReDimArrayPowersOf10_Hex()"

    Private Sub ReDimArrayPowersOf10_Hex(par_intLBound As Integer, par_intUBound As Integer, par_boolPreserveValues As Boolean)
        ''
        ''Added 1/29/2019 thomas downes  
        ''
        ''1/29/2019 td''ReDim arrayPowersOf10_Hex(static_intLBound To static_intLBound)
        ''1/29/2019 td''ReDimArrayPowersOf10_Hex(static_intLBound, static_intUBound)

        If (par_boolPreserveValues) Then
            ReDim Preserve arrayPowersOf10_Hex(par_intUBound)
        Else
            ReDim arrayPowersOf10_Hex(par_intUBound)
        End If ''End of "If (c_boolRefreshArray) Then"

        ''
        ''Below the lower bound, fill with garbage / non-integer values.   ---1/29/2019 td
        ''
        For intEach As Integer = 0 To (-1 + par_intLBound)

            ''Fill these strings with nonsense / garbage characters.  ---1/29/2019 td
            arrayPowersOf10_Hex(intEach) = "@@@@@@@@"

        Next intEach

    End Sub ''eND OF "Private Sub ReDimArrayPowersOf10_Hex()"

End Module
