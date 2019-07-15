Option Explicit On ''Added 7/16/2019 td 
Option Strict On ''Added 7/16/2019 td 
''
''Added 7/16/2019 thomas d.  
''

Public Class FormDemoReportedNum

    Private Function BottomNumberIs2to64() As Boolean
        ''
        ''Added 7/15/2019 td
        ''
        Dim bBottomNumberMatches2to64 As Boolean
        Dim boolCheckForCommas As Boolean

        bBottomNumberMatches2to64 = (txtMinusBottom.Text = modUtilities.TwoToThePowerOf64)

        ''
        ''Add commas, if requested by the user.
        ''
        boolCheckForCommas = (chkEnforceCommas.Checked Or (Not bBottomNumberMatches2to64))

        If (boolCheckForCommas) Then

            ''Added 7/15/2019 td 
            ''
            ''   Check for commas. 
            ''
            ''7/15 td''txtMinusBottom.Text = modUtilities.InsertCommasForTriplets(txtMinusBottom.Text)
            Dim strTwoTo64_withCommas As String

            strTwoTo64_withCommas = modUtilities.InsertCommasForTriplets(modUtilities.TwoToThePowerOf64)

            bBottomNumberMatches2to64 = (strTwoTo64_withCommas = txtMinusBottom.Text)

        End If ''end of "If (boolCheckForCommas) Then"

        Return bBottomNumberMatches2to64

    End Function ''eNd of "Private Function BottomNumberIs2to64() As Boolean"

    Private Sub LabelLeftHdrEqualsMinus_Click(sender As Object, e As EventArgs) Handles LabelLeftHdrEqualsMinus.Click,
        LabelRightHdrEqualsMinus.Click
        ''
        ''Added 6/25/2019 td  
        ''
        Dim strSubtractTop As String
        Dim strSubtractBtm As String
        Dim strErrorMessage As String = ""

        ''
        ''Remove any commas!!  
        ''
        strSubtractTop = txtMinusTop.Text.Replace(",", "")
        strSubtractBtm = txtMinusBottom.Text.Replace(",", "")

        ''Added 7/15/2019 thomas downes   
        txtReportedNumber.Text =
            mod_SubtractDecs.SubAnyTwoDecStrings(strSubtractTop, strSubtractBtm, strErrorMessage)

        If (chkEnforceCommas.Checked) Then

            '' 7/15 td''txtAnswerMinus.Text =
            ''--=----Moved up, out of If-Block.  7/15 td
            ''--=--txtReportedNumber.Text =
            ''--=--mod_SubtractDecs.SubAnyTwoDecStrings(strSubtractTop, strSubtractBtm, strErrorMessage)

            ''Added 6/25/2019 td 
            ''
            ''   Add commas. 
            ''
            '' 7/15 td''txtAnswerMinus.Text = modUtilities.InsertCommasForTriplets(txtAnswerMinus.Text)
            txtAnswerMinus.Text = modUtilities.InsertCommasForTriplets(txtReportedNumber.Text)

        Else
            ''
            ''Just copy the Report Number.  ----7/15/2019 thomas downes    
            ''
            '' 7/15 td''txtAnswerAdd.Text =
            txtAnswerMinus.Text = txtReportedNumber.Text

        End If ''End of "If (chkEnforceCommas.Checked) Then ... Else ...."

        ''
        ''Added 7/15/2019 td
        ''
        Dim bBottomNumberIs_2to64 As Boolean ''Added 7/15/2019 td
        Dim bBottomNumberIsNot_2to64 As Boolean ''Added 7/15/2019 td

        bBottomNumberIs_2to64 = (BottomNumberIs2to64())
        bBottomNumberIsNot_2to64 = (Not bBottomNumberIs_2to64)

        If (bBottomNumberIsNot_2to64) Then
            ''Added 7/15/2019 td
            txtReportedNumber.Text = "Cannot calculate, bottom number must be 2 to the power of 64."

        Else
            ''
            ''Remove the leading zero, if it exists.  Change -02,... to -2,...
            ''   (Per Miles Cole, on 6/25/2019.) 
            ''
            Dim boolLeadingZero As Boolean ''ADded 7/15/2019 td
            Dim strLeadingZeroRemoved As String ''ADded 7/15/2019 td
            Do
                boolLeadingZero = txtReportedNumber.Text.StartsWith("-0")
                If (Not boolLeadingZero) Then Exit Do
                strLeadingZeroRemoved = txtReportedNumber.Text.Replace("-0", "-")
                txtReportedNumber.Text = strLeadingZeroRemoved
            Loop

        End If ''End of "If (bBottomNumberIsNot_2to64) Then"

        ''
        ''Added 6/25/2019 thomas downes
        ''
        If ("" <> strErrorMessage) Then

            MessageBox.Show("Program error:  " & strErrorMessage, "Adding Decs",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If ''ENd of "If ("" <> strErrorMessage) Then"

    End Sub




    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click

        ''Added 7/16/2019 td
        ''
        Me.Close()

    End Sub

    Private Sub Sub2TwoPowerOf64_Click(sender As Object, e As EventArgs) Handles LabelSub2TwoPowerOf64a.Click, LabelSub2TwoPowerOf64b.Click
        ''
        ''Added 6/25/2019 td
        ''
        txtMinusBottom.Text = modUtilities.TwoToThePowerOf64
        ''
        ''Add commas, if requested by the user.
        ''
        If (chkEnforceCommas.Checked) Then

            ''Added 6/25/2019 td 
            ''
            ''   Add commas. 
            ''
            txtMinusBottom.Text = modUtilities.InsertCommasForTriplets(txtMinusBottom.Text)

        End If ''end of "If (chkEnforceCommas.Checked) Then"

    End Sub



    Private Sub LabelSub1TwoPowerOf64_Click(sender As Object, e As EventArgs) Handles LabelSub1TwoPowerOf64.Click
        ''
        ''Added 6/25/2019 td
        ''
        Dim boolHasANumberAlready As Boolean ''Added 7/15/2019 thomas d.

        boolHasANumberAlready = ("" <> txtMinusTop.Text.Trim) ''Added 7/15/2019 thomas d.
        If (boolHasANumberAlready) Then ''Added 7/15/2019 thomas d.
            ''
            ''Don't allow the top number to be replaced. 
            ''
            MessageBox.Show("There is a number in the top box.  First, clear out the top box." & vbCrLf & vbCrLf &
                            "(This operation will place 2^64 in the top box, which is the reverse of the normal.  " & vbCrLf &
                            "      Normally, 2^64 is on the bottom of the subtraction, even though the result will be negative.)", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub

        End If ''Endof "If (boolHasANumberAlready) Then"

        txtMinusTop.Text = modUtilities.TwoToThePowerOf64

        ''
        ''Add commas, if requested by the user.
        ''
        If (chkEnforceCommas.Checked) Then

            ''Added 6/25/2019 td 
            ''
            ''   Add commas. 
            ''
            txtMinusTop.Text = modUtilities.InsertCommasForTriplets(txtMinusTop.Text)

        End If ''end of "If (chkEnforceCommas.Checked) Then"

    End Sub

    Private Sub LabelRightHdrEqualsMinus_Click(sender As Object, e As EventArgs) Handles LabelRightHdrEqualsMinus.Click

    End Sub

    Private Sub LabelWebsiteLink1_Click(sender As Object, e As EventArgs) Handles LabelWebsiteLink1.Click
        ''
        ''Added 7/15/2019 thomas downes
        ''
        System.Diagnostics.Process.Start("https://www.rapidtables.com/convert/number/hex-to-decimal.html")

    End Sub

    Private Sub LabelWebsiteLink2_Click(sender As Object, e As EventArgs) Handles LabelWebsiteLink2.Click
        ''
        ''Added 7/15/2019 thomas downes
        ''
        System.Diagnostics.Process.Start("http://www.webmath.com/k8ipsub.html")

    End Sub
End Class