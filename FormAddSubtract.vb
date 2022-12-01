Public Class FormAddSubtract


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSummand1.KeyPress, txtSummand2.KeyPress, txtMinusTop.KeyPress, txtMinusBottom.KeyPress
        ''
        ''For the _KeyPress event.  
        ''
        ''6/25/2019 td''e.Handled = Not Char.IsDigit(e.KeyChar)

        Select Case True
            Case Char.IsDigit(e.KeyChar)
                ''
                ''Allow the user's keyed digit-character to go into the textbox. 
                ''
            Case Char.IsLetter(e.KeyChar)
                ''
                ''Allow the user's keyed digit-character to go into the textbox. 
                ''
                e.Handled = True''Suppress the key-character.   Don't allow to go into the textbox. 

            Case ((e.KeyChar = Char.Parse(",")) And chkEnforceCommas.Checked)
                ''
                ''Allow the comma.
                ''
            Case Char.IsControl(e.KeyChar)
                ''
                ''Allow control characters.  
                ''
            Case Else
                ''
                ''To allow flexibility of use, and since we've supressed letters above, let's allow unexpected characters. 
                ''
                ''6/25/2019 td''e.Handled = True

        End Select

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub FormAddSubract_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LabelLeftHdrEqualsAdd_Click(sender As Object, e As EventArgs) Handles LabelLeftHdrEqualsAdd.Click, LabelRightHdrEqualsAdd.Click

        Dim strSummand1 As String
        Dim strSummand2 As String
        Dim strErrorMessage As String = ""

        ''
        ''Remove any commas!!  
        ''
        strSummand1 = txtSummand1.Text.Replace(",", "")
        strSummand2 = txtSummand2.Text.Replace(",", "")

        If (chkEnforceCommas.Checked) Then

            txtAnswerAdd.Text =
            modAddingDecs.AddAnyTwoDecStrings(strSummand1, strSummand2, strErrorMessage)

            ''Added 6/25/2019 td 
            ''
            ''   Add commas. 
            ''
            txtAnswerAdd.Text = modUtilities.AddCommasForTriplets(txtAnswerAdd.Text)

        Else

            txtAnswerAdd.Text =
            modAddingDecs.AddAnyTwoDecStrings(strSummand1, strSummand2, strErrorMessage)

        End If ''End of "If (chkEnforceCommas.Checked) Then ... Else ...."

        If ("" <> strErrorMessage) Then

            MessageBox.Show("Program error:  " & strErrorMessage, "Adding Decs",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If ''ENd of "If ("" <> strErrorMessage) Then"

    End Sub

    Private Sub LabelAdd1TwoPowerOf64_Click(sender As Object, e As EventArgs) Handles LabelAdd1TwoPowerOf64.Click
        ''
        ''Added 6/25/2019 td
        ''
        txtSummand1.Text = modUtilities.TwoToThePowerOf64

        ''
        ''Add commas, if requested by the user.
        ''
        If (chkEnforceCommas.Checked) Then

            ''Added 6/25/2019 td 
            ''
            ''   Add commas. 
            ''
            txtSummand1.Text = modUtilities.AddCommasForTriplets(txtSummand1.Text)

        End If ''end of "If (chkEnforceCommas.Checked) Then"

    End Sub

    Private Sub LabelAdd2TwoPowerOf64_Click(sender As Object, e As EventArgs) Handles LabelAdd2TwoPowerOf64.Click
        ''
        ''Added 6/25/2019 td
        ''
        txtSummand2.Text = modUtilities.TwoToThePowerOf64

        ''
        ''Add commas, if requested by the user.
        ''
        If (chkEnforceCommas.Checked) Then

            ''Added 6/25/2019 td 
            ''
            ''   Add commas. 
            ''
            txtSummand2.Text = modUtilities.AddCommasForTriplets(txtSummand2.Text)

        End If ''end of "If (chkEnforceCommas.Checked) Then"

    End Sub

    Private Sub LabelSub1TwoPowerOf64_Click(sender As Object, e As EventArgs) Handles LabelSub1TwoPowerOf64.Click, LabelSub1TwoPowerOf64b.Click
        ''
        ''Added 6/25/2019 td
        ''
        txtMinusTop.Text = modUtilities.TwoToThePowerOf64

        ''
        ''Add commas, if requested by the user.
        ''
        If (chkEnforceCommas.Checked) Then

            ''Added 6/25/2019 td 
            ''
            ''   Add commas. 
            ''
            txtMinusTop.Text = modUtilities.AddCommasForTriplets(txtMinusTop.Text)

        End If ''end of "If (chkEnforceCommas.Checked) Then"

    End Sub

    Private Sub LabelSub2TwoPowerOf64_Click(sender As Object, e As EventArgs) Handles LabelSub2TwoPowerOf64.Click
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
            txtMinusBottom.Text = modUtilities.AddCommasForTriplets(txtMinusBottom.Text)

        End If ''end of "If (chkEnforceCommas.Checked) Then"


    End Sub

    Private Sub LabelLeftHdrEqualsMinus_Click(sender As Object, e As EventArgs) Handles LabelLeftHdrEqualsMinus.Click, LabelRightHdrEqualsMinus.Click
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

        If (chkEnforceCommas.Checked) Then

            txtAnswerMinus.Text =
            mod_SubtractDecs.SubAnyTwoDecStrings(strSubtractTop, strSubtractBtm, strErrorMessage)

            ''Added 6/25/2019 td 
            ''
            ''   Add commas. 
            ''
            txtAnswerMinus.Text = modUtilities.AddCommasForTriplets(txtAnswerMinus.Text)

        Else

            txtAnswerAdd.Text =
            mod_SubtractDecs.SubAnyTwoDecStrings(strSubtractTop, strSubtractBtm, strErrorMessage)

        End If ''End of "If (chkEnforceCommas.Checked) Then ... Else ...."

        If ("" <> strErrorMessage) Then

            MessageBox.Show("Program error:  " & strErrorMessage, "Adding Decs",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If ''ENd of "If ("" <> strErrorMessage) Then"

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class
