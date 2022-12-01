Option Explicit On ''Added 6/25/2019 thomas d. 
Option Strict On ''Added 6/25/2019 thomas d. 
''
''' <summary>
''' This is for shared functions and procedures.   (module modUtilities)  ----Added 6/25/2019  td 
''' </summary>

Module modUtilities

    ''2^64	18446744073709551616   From  http://www.tsm-resources.com/alists/pow2.html
    Public Const TwoToThePowerOf64 As String = "18446744073709551616" ''2^64	18446744073709551616   From  http://www.tsm-resources.com/alists/pow2.html

    Public Structure VB6_ArrayWithLowerBound ''Added 6/25/2019
        Dim array_ofStrings() As String ''added 6/25/2019 & 7/02/2016
        Dim lowerBound As Integer ''Added 6/25/2019
        Dim upperBound As Integer ''Added 6/25/2019
    End Structure

    Public Sub ReDim_VB6(ByRef par_array As VB6_ArrayWithLowerBound, par_intLowerBound As Integer, par_intUpperBound As Integer)
        ''
        ''Added 6/25/2019 td
        ''
        ''  This is overloaded. 
        ''
        par_array.lowerBound = par_intLowerBound ''Added 6/25/2019 td
        par_array.upperBound = par_intUpperBound ''Added 6/25/2019 td

        ReDim par_array.array_ofStrings(par_intUpperBound)

        ''
        ''Caution against using the lower indices.  
        ''
        Dim intIndex As Integer
        For intIndex = 0 To (par_intLowerBound - 1)
            ''par_array(intIndex) = "This VB6/VBA array out of bounds!"
            par_array.array_ofStrings(intIndex) = "éâäçêëè" ''These non-ASCII symbols indicate the array is out of bounds. 
        Next intIndex

    End Sub ''End of "Public Sub ReDim_VB6(mod_arrayPowersOf16_Dec, static_intLBound, static_intLBound)"

    Public Sub ReDim_VB6(ByRef par_array As String(), par_intLowerBound As Integer, par_intUpperBound As Integer)
        ''
        ''Added 6/25/2019 td
        ''
        ''  This is overloaded. 
        ''
        ReDim par_array(par_intUpperBound)

        ''
        ''Caution against using the lower indices.  
        ''
        Dim intIndex As Integer
        For intIndex = 0 To (par_intLowerBound - 1)
            ''par_array(intIndex) = "This VB6/VBA array out of bounds!"
            par_array(intIndex) = "Array out of bounds!"
        Next intIndex

    End Sub ''End of "Public Sub ReDim_VB6(mod_arrayPowersOf16_Dec, static_intLBound, static_intLBound)"

    Public Sub ReDim_VB6_Preserve(ByRef par_array As VB6_ArrayWithLowerBound, par_intLowerBound As Integer, par_intUpperBound As Integer)
        ''
        ''Added 6/25/2019 td
        ''
        ''  This is overloaded. 
        ''
        par_array.lowerBound = par_intLowerBound ''Added 6/25/2019 td
        par_array.upperBound = par_intUpperBound ''Added 6/25/2019 td

        ReDim Preserve par_array.array_ofStrings(par_intUpperBound)

        ''
        ''Caution against using the lower indices.  
        ''
        Const c_boolClearOuterLowerIndexItems As Boolean = False ''Not needed, and goes against the "Preserve" concept. 

        If (c_boolClearOuterLowerIndexItems) Then
            Dim intIndex As Integer
            For intIndex = 0 To (par_intLowerBound - 1)
                ''par_array(intIndex) = "This VB6/VBA array out of bounds!"
                par_array.array_ofStrings(intIndex) = "Array out of bounds!"
            Next intIndex
        End If ''End of "If (c_boolClearOuterLowerIndexItems) Then"

    End Sub ''End of "Public Sub ReDim_VB6(mod_arrayPowersOf16_Dec, static_intLBound, static_intLBound)"

    Public Sub ReDim_VB6_Preserve(ByRef par_array As String(), par_intLowerBound As Integer, par_intUpperBound As Integer)
        ''
        ''Added 6/25/2019 td
        ''
        ''  This is overloaded. 
        ''
        ReDim Preserve par_array(par_intUpperBound)

        ''
        ''Caution against using the lower indices.  
        ''
        Const c_boolClearOuterLowerIndexItems As Boolean = False ''Not needed, and goes against the "Preserve" concept. 

        If (c_boolClearOuterLowerIndexItems) Then
            Dim intIndex As Integer
            For intIndex = 0 To (par_intLowerBound - 1)
                ''par_array(intIndex) = "This VB6/VBA array out of bounds!"
                par_array(intIndex) = "Array out of bounds!"
            Next intIndex
        End If ''End of "If (c_boolClearOuterLowerIndexItems) Then"

    End Sub ''End of "Public Sub ReDim_VB6(mod_arrayPowersOf16_Dec, static_intLBound, static_intLBound)"

    Public Function AddCommasForTriplets(par_inputNumber As String) As String
        ''
        ''Added 6/25/2019 td
        ''
        Dim intCharIndex As Integer
        Dim strOutput As String = ""
        Dim each_char As Char
        Dim intTripletIndex As Integer = 0

        ''Exit, if not needed.
        ''
        If (0 < InStr(par_inputNumber, ",")) Then Return par_inputNumber

        ''
        ''Processing. 
        ''
        For intCharIndex = (-1 + par_inputNumber.Length) To 0 Step -1

            intTripletIndex += 1

            ''Add a comma just immediately prior to pre-appending the 4th digit, the 7th digit, the 10th digit, etc. 
            If (intTripletIndex = 4) Then strOutput = ("," & strOutput)
            If (intTripletIndex = 4) Then intTripletIndex = 1 ''0 ''Reinitialize. 

            each_char = par_inputNumber(intCharIndex)
            strOutput = (each_char.ToString() & strOutput)

        Next intCharIndex

        Return strOutput

    End Function ''End of "Public Function AddCommasForTriplets(par_inputNumber As String) As String""


End Module
