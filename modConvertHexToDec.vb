''Option Compare Database
Option Explicit On
Option Strict On

''
'' H-E-X-A-D-E-C-I-M-A-L to D-E-C-I-M-A-L Conversion
''
''This module (modDecToHexByStrings_July) is modelled after module modHexToDecByStrings_June.bas
''   ---7/04/2016 Thomas Downes
''
Module modConvertHexToDec

    ''
    '' H-E-X-A-D-E-C-I-M-A-L to D-E-C-I-M-A-L Conversion
    ''
    ''This module (modDecToHexByStrings_July) is modelled after module modHexToDecByStrings_June.bas
    ''   ---7/04/2016 Thomas Downes
    ''
    Private mod_strHeximal As String ''added 6/30/2016
    ''6/25/2019 td''Private mod_arrayPowersOf16_Dec() As String ''added 7/02/2016

    ''Private Structure VB6_ArrayWithLowerBound ''Added 6/25/2019
    ''    Dim array_ofStrings() As String ''added 6/25/2019 & 7/02/2016
    ''    Dim lowerBound As Integer ''Added 6/25/2019
    ''End Structure
    Private mod_arrayPowersOf16_Dec As modUtilities.VB6_ArrayWithLowerBound

    Public Function ConvertHexToDec(pstrHeximal As String, ByRef pstrErrMessage As String,
                                Optional ByRef pstrAllPowersOf16Msg As String = "") As String

        Dim intCharIndex As Integer
        Dim strHeximalDigit As String = ""
        Dim strDec_Temp As String = ""
        Dim strRunningTotalDec As String = ""
        Dim intPowerOf16 As Integer
        Dim strPowerOf10Msg As String = "" ''Added 7/14/2016

        mod_strHeximal = Trim(pstrHeximal)
        pstrHeximal = Trim(pstrHeximal)

        For intCharIndex = 1 To Len(pstrHeximal)

            intPowerOf16 = (Len(pstrHeximal) - intCharIndex)

            strHeximalDigit = Mid$(pstrHeximal, intCharIndex, 1)

            ''Added 7/04/2016 Thomas Downes
            ''
            '//'If (Not IsNumeric(CInt("&H" & pstrHeximal))) Then
            If (Not IsNumeric(CInt("&H" & strHeximalDigit))) Then
                pstrErrMessage = "A non-hexadecimal digit is encoutered, """ & strHeximalDigit & """."
                Exit Function
            End If

            ''Added 7/04/2016 Thomas Downes
            If (strHeximalDigit = "0" And strRunningTotalDec <> "") Then
                ''This calculation will not affect the running total.
                GoTo Skip_GoToNextLoop
            End If

            strPowerOf10Msg = "" ''Reinitialize. 7/14/2016

            '7/14'strDec_Temp = GiveDecOfPowerOf16_TimesN(intPowerOf16, CInt("&H" & strHeximalDigit), pstrErrMessage)
            strDec_Temp = GiveDecOfPowerOf16_TimesN(intPowerOf16, CInt("&H" & strHeximalDigit), pstrErrMessage, strPowerOf10Msg)

            If (pstrErrMessage <> "") Then

                ''Don't return any values other than the error message.
                strDec_Temp = ""
                ConvertHexToDec = ""
                Exit Function

            ElseIf (strRunningTotalDec = "") Then

                strRunningTotalDec = strDec_Temp

            Else

                strRunningTotalDec = AddAnyTwoDecStrings(strDec_Temp, strRunningTotalDec, pstrErrMessage)

                If (pstrErrMessage <> "") Then Exit Function

            End If

            ''Added 7/14/2016
            If (strPowerOf10Msg <> "") Then
                pstrAllPowersOf16Msg = (pstrAllPowersOf16Msg & vbCrLf & strPowerOf10Msg)
            End If

            ''Added 7/13/2016 Thomas Downes
Skip_GoToNextLoop:

        Next intCharIndex

        ConvertHexToDec = strRunningTotalDec

    End Function ''End of "Public Function ConvertHexToDec"

    Private Function GiveDecOfPowerOf16_TimesN(pintPowerOf16 As Integer,
                                           pintTimesN As Integer,
                                           ByRef pstrErrMessage As String,
                                           Optional ByRef pstrPowerMessage As String = "") As String

        Dim intLoop As Integer
        Dim strRunningTotalDec As String
        Dim strPowerOf16_Dec As String
        Dim boolMissingPower As Boolean
        'now a parameter'Dim strPowerMessage As String ''Added 7/14/2016

        '7/02/2016'If (pintPowerOf16) Then
        If (pintTimesN = 0) Then
            GiveDecOfPowerOf16_TimesN = Left$("00000000000000000000000000000000000000000000", (1 + pintPowerOf16))
            Exit Function
        ElseIf (pintPowerOf16 = 0) Then
            ''Added 7/02/2016 Thomas Downes
            GiveDecOfPowerOf16_TimesN = CStr(pintTimesN)
            Exit Function
        End If ''End of "If (pintPowerOf16 = 0) Then"

        '7/14/2016'strPowerOf16_Dec = GetPowerOf16_InDec(pintPowerOf16, boolMissingPower, pstrErrMessage)
        strPowerOf16_Dec = GetPowerOf16_InDec_Main(pintPowerOf16, boolMissingPower, pstrErrMessage, pstrPowerMessage)

        If ("" <> pstrErrMessage) Then Exit Function

        If (boolMissingPower) Then pstrErrMessage = GiveMsgToProgrammer(mod_strHeximal, pintPowerOf16, pintPowerOf16)
        If (boolMissingPower) Then Exit Function

        For intLoop = 1 To pintTimesN

            If (strRunningTotalDec = "") Then

                strRunningTotalDec = strPowerOf16_Dec

            Else

                strRunningTotalDec = AddAnyTwoDecStrings(strPowerOf16_Dec, strRunningTotalDec, pstrErrMessage)

                If (pstrErrMessage <> "") Then Exit Function

            End If

        Next intLoop

        GiveDecOfPowerOf16_TimesN = strRunningTotalDec

    End Function ''End of "Private Function GiveDecOfPowerOf16_TimesN"

    Private Function GiveMsgToProgrammer(pstrHeximal As String,
                               pintPowerOf16_Start As Integer,
                               pintPowerOf16_End As Integer) As String

        Dim intPower As Integer
        Dim strListOfPowers As String
        Dim strMessage As String

        For intPower = pintPowerOf16_Start To pintPowerOf16_End

            '//'strListOfPowers = strListOfPowers & vbCrLf & _
            '//'                  CStr(16 ^ intPower)
            strListOfPowers = strListOfPowers & vbCrLf &
                          "1" & Left("000000000000000000000000000000000000", intPower) & vbCrLf &
                          CStr(16 ^ intPower) & "   (16 to the power of " & CStr(intPower) & ")"

        Next intPower

        strMessage = "Cannot convert " & pstrHeximal & vbCrLf & vbCrLf &
                  "Please ask a CI Solutions programmer to add the following " &
                  " powers of 16, but converted to DecaHeximal." &
                  vbCrLf & vbCrLf &
                  "(PowersOf16_InDec / GiveMsgToProgrammer)" & vbCrLf &
                  strListOfPowers

        ';;'MsgBox strMessage, vbExclamation

        GiveMsgToProgrammer = strMessage

    End Function ''End of "Public Sub GiveMsgToProgrammer"

    Private Function GetPowerOf16_InDec_Main(pintPowerOf16 As Integer, ByRef pboolMissing As Boolean,
                                    ByRef pstrErrMessage As String,
                                    Optional ByRef pstrIfNew_TextMessage As String = "") As String
        ''
        '' Uses arrays to store calculated values.
        ''
        Static static_intArrayLowerBound As Integer
        Static static_intHighestPowerSoFar As Integer

        Dim strDec As String

        If (static_intArrayLowerBound = 0) Then
            ''This tells the lowest power of 16 which needs to be calculated
            ''   (rather than rely on hard-coding).
            ''   ---7/3/2016 Thomas Downes
            static_intArrayLowerBound = GetPowerOf16_FirstMissing()
        End If ''End of "If (static_intArrayLowerBound = 0) Then"

        ''Select Case pintPowerOf16
        ''    Case 0: strDec = "1"
        ''    Case 1: strDec = "A" ''                       16 in DecaHeximal.
        ''    Case 2: strDec = "64" ''                     160 in DecaHeximal.
        ''    Case 3: strDec = "3E8" ''                  1,000 in DecaHeximal.
        ''    Case 4: strDec = "2716" ''                16,000 in DecaHeximal.
        ''    Case 5: strDec = "186A0" ''              160,000 in DecaHeximal.
        ''    Case 6: strDec = "F4240" ''            1,000,000 in DecaHeximal.
        ''    Case 7: strDec = "989680" ''          16,000,000 in DecaHeximal.
        ''    Case 8: strDec = "5F5E160" ''        160,000,000 in DecaHeximal.
        ''    Case 9: strDec = "3B9ACA00" ''     1,000,000,000 in DecaHeximal.
        ''
        ''    Case 16, 11, 12, 13, 14

        If (pintPowerOf16 < static_intArrayLowerBound) Then

            strDec = GetPowerOf16_InDec_Simple(pintPowerOf16, pboolMissing)

        Else

            strDec = GetPowerOf16_InDec_ByArray(pintPowerOf16, pstrErrMessage)

        End If

        pboolMissing = pboolMissing Or ("" = Trim(strDec))

        GetPowerOf16_InDec_Main = strDec

        ''
        ''Lagniappe!!   For a visually-displayed list of powers of 16.
        ''
        Dim boolNewPower As Boolean ''Added 7/14/2016 Thomas

        boolNewPower = (pintPowerOf16 > static_intHighestPowerSoFar)
        If boolNewPower Then

            pstrIfNew_TextMessage = ("16 ^ " & CStr(pintPowerOf16) & " = " & strDec)
            static_intHighestPowerSoFar = pintPowerOf16

        End If

    End Function ''End of "Private Function GetPowerOf16_InDec_Main"

    Private Function GetPowerOf16_InDec_ByArray(pintPowerOf16 As Integer, pstrErrMessage As String) As String
        ''
        ''
        ''Assumption:   For each call to function ConvertHexToDec(),
        ''   the current function (GetPowerOf16_InDec_ByArray) will be called
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
        ''Dim strDecTimes16 As String
        Dim strDec_byAdding As String
        Dim strDecForPriorPower As String
        Dim intNextLowerPower As Integer
        Dim boolMustCalculate As Boolean
        Dim boolTakeValueFromArray As Boolean
        Dim boolFirstRunOfThisFunction As Boolean

        ']]'On Error Resume Next

        'See above.'Static static_intLBound As Integer
        If (static_intLBound = 0) Then
            ''This tells the lowest power of 16 which needs to be calculated
            ''   (rather than rely on hard-coding).
            boolFirstRunOfThisFunction = True
            static_intLBound = GetPowerOf16_FirstMissing()
        End If ''End of "If (static_intLBound = 0) Then"

        ']]'''Test to see if the array has been started yet or not.
        ']]'If (pintPowerOf16 >= static_intLBound) Then
        ']]'    strDummy = arrayPowersOf16_Dec(-1 + pintPowerOf16)
        ']]'End If

        ']]'If (Err.Number <> 0) Then
        ']]'  ''boolArrayNeedsFirstItem = (Err.Number <> 0)
        ']]'  boolArrayNeedsFirstItem = (Err.Number = 9)
        ']]'  If (Err.Number <> 9) Then
        ']]'     pstrErrMessage = Err.Description & " (GetPowerOf16_InDec_ByArray)"
        ']]'     MsgBox "Unexpected error..!!  " & Err.Description, vbExclamation
        ']]'     Exit Function
        ']]'  End If ''End of "If (Err.Number <> 9) Then"
        ']]'End If ''End of "If (Err.Number <> 0) Then"

        On Error GoTo 0 ''Resume natural error-handling

        ''Added 7/3/2015 Thomas Downes
        boolArrayNeedsFirstItem = boolFirstRunOfThisFunction

        If (boolArrayNeedsFirstItem) Then
            ''
            ''Initialize the array.
            ''
            '7/3/2016'static_intLBound = pintPowerOf16
            '7/3/2016'ReDim arrayPowersOf16_Dec(static_intLBound To pintPowerOf16)
            ''6/25/2019 td''ReDim mod_arrayPowersOf16_Dec(static_intLBound To static_intLBound)
            modUtilities.ReDim_VB6(mod_arrayPowersOf16_Dec, static_intLBound, static_intLBound)

            '7/3/2016'boolMustCalculate = True
            '7/3/2016'boolMustCalculate = (pintPowerOf16 >= static_intLBound)
            ''6/25/2019 td''mod_arrayPowersOf16_Dec(static_intLBound) =
            ''      GetPowerOf16_ByAdding(static_intLBound, pstrErrMessage)

            mod_arrayPowersOf16_Dec.array_ofStrings(static_intLBound) =
                  GetPowerOf16_ByAdding(static_intLBound, pstrErrMessage)

            If (pstrErrMessage <> "") Then Exit Function
        End If ''End of "If (boolArrayNeedsFirstItem) Then"

        ''By executing the next two(2) commands, and then checking (0 <> Err.Number),
        ''   we can find out if the DecaHeximal for the current power of 16
        ''   has been stored in the array or not.
        ''
        On Error Resume Next

        ''6/25/2019 td''strOut = mod_arrayPowersOf16_Dec(pintPowerOf16)
        strOut = mod_arrayPowersOf16_Dec.array_ofStrings(pintPowerOf16)

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
                ''Assumption:   For each call to function ConvertHexToDec(),
                ''   the current function (GetPowerOf16_InDec_ByArray) will be called
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
                    ''6/25/2019 td''ReDim Preserve mod_arrayPowersOf16_Dec(static_intLBound To pintPowerOf16)
                    modUtilities.ReDim_VB6_Preserve(mod_arrayPowersOf16_Dec, static_intLBound, pintPowerOf16)
                End If ''End of "If (boolMustRedim) Then"
                boolMustCalculate = True

            End If ''End of "If (boolArrayNeedsNextItem) Then"

            If (Err.Number <> 9 And Err.Number <> 0) Then
                pstrErrMessage = Err.Description & " (GetPowerOf16_InDec_ByArray)"
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

            ''6/25/2019 td''strOut = mod_arrayPowersOf16_Dec(pintPowerOf16)
            strOut = mod_arrayPowersOf16_Dec.array_ofStrings(pintPowerOf16)

        ElseIf (boolMustCalculate) Then

            '7/02/2016'strDecForPriorPower = GetPowerOf16_InDec_Simple(-1 + pintPowerOf16)
            '7/03/2016'intNextLowerPower = (-1 + pintPowerOf16)

            ''Multiply the next lower power of 16 (expressed in Dec) by 16,
            ''   so that we have the desired power of 16 (also expressed in Dec).
            ''   ----7/02/2016 Thomas Downes
            ''
            '7/03/2016'strDecTimes16 = GiveDecOfPowerOf16_TimesN(intNextLowerPower, 16, pstrErrMessage)

            strDec_byAdding = GetPowerOf16_ByAdding(pintPowerOf16, pstrErrMessage)

            If (pstrErrMessage <> "") Then Exit Function

            ''Save the value.
            '7/03/2016'arrayPowersOf16_Dec(pintPowerOf16) = strDecTimes16
            ''6/25/2019 td''mod_arrayPowersOf16_Dec(pintPowerOf16) = strDec_byAdding
            mod_arrayPowersOf16_Dec.array_ofStrings(pintPowerOf16) = strDec_byAdding
            strOut = strDec_byAdding

        End If

        GetPowerOf16_InDec_ByArray = strOut

    End Function

    Private Function GetPowerOf16_ByAdding(pintPowerOf16 As Integer, pstrErrMessage As String) As String

        Dim intNextLowerPower As Integer
        Dim strDecTimes16 As String

        '7/02/2016'strDecForPriorPower = GetPowerOf16_InDec_Simple(-1 + pintPowerOf16)
        intNextLowerPower = (-1 + pintPowerOf16)

        ''Multiply the next lower power of 16 (expressed in Dec) by 16,
        ''   so that we have the desired power of 16 (also expressed in Dec).
        ''   ----7/02/2016 Thomas Downes
        ''
        strDecTimes16 = GiveDecOfPowerOf16_TimesN(intNextLowerPower, 16, pstrErrMessage)

        If (pstrErrMessage <> "") Then Exit Function

        GetPowerOf16_ByAdding = strDecTimes16
        Return strDecTimes16

    End Function ''ENd of " Private Function GetPowerOf16_ByAdding(pintPowerOf16 As Integer, pstrErrMessage As String) As String"

    Private Function GetPowerOf16_InDec_Simple(pintPowerOf16 As Integer, ByRef pboolMissingHardcodedValue As Boolean) As String

        Dim strDec As String

        Select Case pintPowerOf16
            Case 0 : strDec = "1"
            Case 1 : strDec = "16" ''            16 in Decimal.
            Case 2 : strDec = "256" ''        16*16 in Decimal.
            Case 3 : strDec = "4096" ''      16*256 in Decimal.
            Case 4 : strDec = "65536" ''    256*256 in Decimal.
            Case 5 : strDec = "1048576" ''     16^5 in Decimal.
            Case 6 : strDec = "16777216" ''    16^6 in Decimal.
            Case 7 : strDec = "268435456" ''   16^7 in Decimal.
            Case 8 : strDec = "4294967296" ''        160,000,000 in Decimal.
            Case 9 : strDec = "68719476736" ''       1,000,000,000 in Decimal.
            Case 10 : strDec = "1099511627776" ''    16,000,000,000 in Decimal.
            Case 11 : strDec = "17592186044416" ''160,000,000,000 in Decimal.
            Case 12 : strDec = "" : pboolMissingHardcodedValue = True
            Case 13 : strDec = "" : pboolMissingHardcodedValue = True
            Case 14 : strDec = "" : pboolMissingHardcodedValue = True
            Case Else
                strDec = "" : pboolMissingHardcodedValue = True

        End Select

        pboolMissingHardcodedValue = (pboolMissingHardcodedValue Or ("" = Trim(strDec)))

        GetPowerOf16_InDec_Simple = strDec

    End Function ''End of "Private Function GetPowerOf16_InDec_Simple"

    Private Function GetPowerOf16_FirstMissing() As Integer

        Dim intPowerOf16 As Integer
        Dim boolMissingHardcoding As Boolean

        For intPowerOf16 = 1 To 100
            ''
            ''Set the ByRef Boolean variable. 
            ''
            GetPowerOf16_InDec_Simple(intPowerOf16, boolMissingHardcoding)

            If (boolMissingHardcoding) Then Exit For

        Next intPowerOf16

        GetPowerOf16_FirstMissing = intPowerOf16
        Return intPowerOf16

    End Function ''End of " Private Function GetPowerOf16_FirstMissing() As Integer"

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
