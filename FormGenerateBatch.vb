Option Explicit On ''Added 7/16/2019 td 
Option Strict On ''Added 7/16/2019 td 

''
''Added 7/216/2019 thomas d.  
''

Public Class FormGenerateBatch
    ''
    ''Added 7/216/2019 thomas d.  
    ''
    Private Const TWO_TO_POWER_64_wCommas As String = "18,446,744,073,709,551,616" ''This equals 2 to the power of 64.  
    Private Const TWO_TO_POWER_64 As String = "18446744073709551616"
    Private Const DEFAULT_PRINTED_NUMBER As String = "16142029164840482413" ''Added 7/16/2019 td   

    ''Added 7/17/2019 thomas d.  
    Private Structure ProcessingInfo
        Dim bProcessInitiated As Boolean ''Added 7/17/2019 td 
        Dim boolInsertCrLf As Boolean
        Dim intAnticipatedItems As Integer  ''Added 7/16/2019 thomas d. 
        Dim intCountProcessed As Integer  ''Added 7/16/2019 thomas d. 
        Dim intLineIndex_Prior As Integer ''Added 7/17/2019 thomas d. 
        Dim int1to40 As Integer ''Added 7/16/2019 td
        Dim bExcelRequiresAQuotemark As Boolean ''Formerly "bIncludeQuotemarkForExcel". ---7/17/2019 td
        Dim bExcelRequiresASpaceChar As Boolean ''Added 7/17/2019 td 
        Dim strErrorMessage As String
        Dim bErrorOccurred As Boolean
        Dim bUserRequestsPause As Boolean
        Dim bPauseRequestGranted As Boolean
    End Structure
    Private mod_process As ProcessingInfo ''Added 7/17/2019 thomas d.  

    Private Sub FormGenerateBatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''Fill Listbox. 
        FillListBoxOfValueTypes()

    End Sub

    Private Sub LinkGenerateList_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkGenerateList.LinkClicked
        ''
        ''Added 7/216/2019 thomas d.  
        ''
        Dim intCountPrintedNums_ListedAlready As Integer
        Dim intCountPrintedNums_Desired As Integer
        Dim strCountPrintedNums_Desired As String
        Dim bExactlyOnePrintedNum As Boolean
        Dim strPrintedNumber_Initial As String
        Dim boolPrintedIsNumeric As Boolean

        intCountPrintedNums_ListedAlready = TextListNumsPrinted.Lines().Count
        bExactlyOnePrintedNum = (1 = intCountPrintedNums_ListedAlready)

        ''If (Not bExactlyOnePrintedNum) Then Exit Sub
        If (Not bExactlyOnePrintedNum) Then
            MessageBox.Show("Cannot generate a sequence. " & vbCrLf & vbCrLf &
                            "There already appears to be multiple Printed Numbers.  (Are some blank?) " & vbCrLf & vbCrLf &
                "To create a sequence, limit the lefthand printed-number list to exactly one(1) initial number.", "", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation)
            Exit Sub
        End If ''End of  "If (Not bExactlyOnePrintedNum) Then"

        ''Added 7/16/2019 td 
        strPrintedNumber_Initial = TextListNumsPrinted.Lines(0).Trim()

        ''Added 7/16/2019 td 
        If ("" = strPrintedNumber_Initial) Then
            MessageBox.Show("The initial Printed Number is missing. " & vbCrLf & vbCrLf &
                "To create a sequence, add an initial Printed Number.", "", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation)
            Exit Sub
        End If ''End of  "If ("" = strPrintedNumber_Initial) Then"

        boolPrintedIsNumeric = IsNumeric(strPrintedNumber_Initial)

        ''Added 7/16/2019 td 
        If (Not boolPrintedIsNumeric) Then
            ''Added 7/16/2019 td 
            MessageBox.Show("The number doesn't appear to be numeric.  (Are some blank?) " & vbCrLf & vbCrLf &
                "To create a sequence, limit the lefthand printed-number list to exactly one(1) initial number.", "", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation)
            Exit Sub
        End If ''End of  "If (Not boolPrintedIsNumeric) Then"

        ''
        ''Added procedure 7/16/2019 td
        ''
        strCountPrintedNums_Desired = txtSequenceOfHowMany.Text

        If (IsNumeric(strCountPrintedNums_Desired)) Then
            intCountPrintedNums_Desired = Integer.Parse(txtSequenceOfHowMany.Text)
        Else
            txtSequenceOfHowMany.Text = "100"
            intCountPrintedNums_Desired = 100
        End If ''End of "If (IsNumeric(strCountPrintedNums_Desired)) Then .... Else ...."

        If (1 < intCountPrintedNums_Desired) Then
            ''
            ''Major call !!
            ''
            CreateSequenceOfPrintedNumbers(intCountPrintedNums_Desired, strPrintedNumber_Initial)

        End If ''End of "If (1 < intCountPrintedNums) Then"
    End Sub

    Private Sub CopyTheReportedNumsToClipboard()

        ''ADded 7/16/2019 td  
        ''
        Windows.Forms.Clipboard.SetText(TextListNumsReported.Text)

    End Sub ''eNd of "Private Sub CopyTheReportedNumsToClipboard()"

    Private Sub CreateSequenceOfPrintedNumbers(par_intNumberOfItems As Integer, par_strInitial As String)
        ''
        ''Added 7/16/2019 td  
        ''
        Dim intIndex As Integer
        Dim strNextItem As String
        Dim strPriorItem As String
        Dim strErrMessage As String = ""
        Dim intCountFinal As Integer

        strPriorItem = par_strInitial

        ''
        ''Iterate to fill the left-hand listbox ("Printed Numbers")  
        ''
        For intIndex = 1 To (-1 + par_intNumberOfItems)

            strNextItem = modAddingDecs.AddAnyTwoDecStrings(strPriorItem, "1", strErrMessage)
            If (0 < strErrMessage.Length) Then Exit For
            TextListNumsPrinted.AppendText(vbCrLf & strNextItem)

            Application.DoEvents()
            Application.DoEvents()

PrepareForNextLoop:
            strPriorItem = strNextItem
        Next intIndex

ExitHandler:
        intCountFinal = TextListNumsPrinted.Lines().Count
        MessageBox.Show(String.Format("Completed sequence.  There are now {0} items.", intCountFinal),
                        "CreateSequenceOfPrintedNumbers",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End Sub ''End of "Private Sub CreateSequenceOfPrintedNumbers()"

    Private Sub FillListBoxOfValueTypes()
        ''
        ''Added 1/29/2019 td  
        ''
        With ListOfTextboxesOnForm

            .Items.Add(TextPrintedNum_Current)
            .Items.Add(TextReportedNum_Current)

            ''Select two (2) of the above items.   ----1/29/2019 td 
            .SelectedItems.Add(TextPrintedNum_Current)
            .SelectedItems.Add(TextReportedNum_Current)

        End With ''End of "With ListOfTextboxesOnForm"

    End Sub ''End of "Private Sub FillListBoxOfValuesTypes()"

    Private Function GetLineOfOutput(par_strExcelPrefixChar As String) As String
        ''7/17/2019 td''Private Function GetLineOfOutput(par_bIncludeQuotemark As Boolean) As String
        ''7/17/2019 td''Private Function GetLineOfOutput() As String
        ''
        ''Added 1/29/2019 td  
        ''
        Dim eachControl As Control ''String
        Dim strOutputLine As String = ""
        ''7/17/2019 td''Dim strQuote_IfParam As String = String.Empty ''Single quote-mark, if needed.  By default, a zero-length string. 

        ''Single quote-mark, if needed.  By default, a zero-length string. ---7/17/2019 td  
        ''7/17/2019 td''If (par_bIncludeQuotemark) Then strQuote_IfParam = "'"

        For Each eachControl In ListOfTextboxesOnForm.SelectedItems

            If (strOutputLine = "") Then
                ''7/17/2019 td''strOutputLine = eachControl.Text
                ''7/17/2019 td''strOutputLine = (strQuote_IfParam & eachControl.Text)
                strOutputLine = (par_strExcelPrefixChar & eachControl.Text)
            Else
                ''7/17/2019 td''strOutputLine &= (vbTab & eachControl.Text)
                ''7/17/2019 td''strOutputLine &= (vbTab & strQuote_IfParam & eachControl.Text)
                strOutputLine &= (vbTab & par_strExcelPrefixChar & eachControl.Text)
            End If

        Next eachControl

        ''Append the error message, if any. -----1/29/2019 td
        ''If ("" <> BinaryDataControl1.CurrentErrorMessage) Then
        ''If (0 <> BinaryDataControl1.CurrentErrorMessage.Length) Then
        ''    ''Append the error message. -----1/29/2019 td
        ''    strOutputLine &= (vbTab & BinaryDataControl1.CurrentErrorMessage.ToString())
        ''End If ''End of "If ("" <> BinaryDataControl1.CurrentErrorMessage) Then"

        Return strOutputLine

    End Function ''End of "Private Function GetLineOfOutput() As String"

    Private Sub CleanUpLeadingZeros_Reported(ByRef par_box As TextBox)
        ''
        ''Encapsulated 7/16/2019 thomas downes
        ''
        Dim boolLeadingZero_Positive As Boolean ''ADded 7/16/2019 td
        Dim boolLeadingZero_Negative As Boolean ''ADded 7/16/2019 td

        ''
        ''----------------VERY LIKELY NEEDED, REMOVE LEADING ZERO FOR NEGATIVE REPORTED NUMBERS
        ''
        ''Remove the leading zero, if it exists.  Change -02,... to -2,...
        ''   (Per Miles Cole, on 6/25/2019.) 
        ''
        ''boolLeadingZero_Negative = TextReportedNum_Current.Text.StartsWith("-0")
        ''Do While (boolLeadingZero_Negative)
        ''    If (Not boolLeadingZero_Negative) Then Exit Do ''Yes, this is a bit redundant. 
        ''    TextReportedNum_Current.Text = TextReportedNum_Current.Text.Replace("-0", "-")
        ''    boolLeadingZero_Negative = TextReportedNum_Current.Text.StartsWith("-0")
        ''Loop

        boolLeadingZero_Negative = par_box.Text.StartsWith("-0")
        Do While (boolLeadingZero_Negative)
            If (Not boolLeadingZero_Negative) Then Exit Do ''Yes, this is a bit redundant. 
            par_box.Text = par_box.Text.Replace("-0", "-")
            boolLeadingZero_Negative = par_box.Text.StartsWith("-0")
        Loop ''End of "Do While (boolLeadingZero_Negative)"

        ''
        ''----------------LESS LIKELY NEEDED, REMOVE LEADING ZERO FOR POSITIVE REPORTED NUMBERS
        ''
        ''Remove the leading zero, if it exists.  Change 02,... to 2,..
        ''
        ''boolLeadingZero_Positive = TextReportedNum_Current.Text.StartsWith("0") AndAlso
        ''                                   (1 < TextReportedNum_Current.Text.Length)

        ''Do While (boolLeadingZero_Positive)
        ''    If (Not boolLeadingZero_Positive) Then Exit Do ''Yes, this is a bit redundant. 
        ''    TextReportedNum_Current.Text = ("+" & TextReportedNum_Current.Text).Replace("+0", "")
        ''    boolLeadingZero_Positive = TextReportedNum_Current.Text.StartsWith("0") AndAlso
        ''                                   (1 < TextReportedNum_Current.Text.Length)
        ''Loop

        Const c_boolPossiblyNeeded As Boolean = False ''Turn this off, to save processing time. 

        If (c_boolPossiblyNeeded) Then

            boolLeadingZero_Positive = par_box.Text.StartsWith("0") AndAlso
                                        (1 < par_box.Text.Length)

            Do While (boolLeadingZero_Positive)
                If (Not boolLeadingZero_Positive) Then Exit Do ''Yes, this is a bit redundant. 
                par_box.Text = ("+" & par_box.Text).Replace("+0", "")
                boolLeadingZero_Positive = par_box.Text.StartsWith("0") AndAlso
                                               (1 < par_box.Text.Length)
            Loop ''End of "Do While (boolLeadingZero_Positive)"

        End If ''eNd of "If (c_boolPossiblyNeeded) Then"

    End Sub ''End of [[]Private Sub CleanUpLeadingZeros_Reported()"

    Private Sub buttonProcessList_Click(sender As Object, e As EventArgs) Handles buttonProcessList.Click
        ''
        ''Added 7/16/2019 thomas downes  
        ''
        ''Dim intIndex As Integer
        ''Dim strCurrentItem As String
        Dim strErrMessage As String = ""
        Dim intCountFinal As Integer
        ''7/17 td''Dim boolInsertCrLf As Boolean
        Dim intAnticipatedItems As Integer  ''Added 7/16/2019 thomas d. 
        ''7/17 td''Dim intCountProcessed As Integer  ''Added 7/16/2019 thomas d. 
        ''7/17 td''Dim int1to40 As Integer ''Added 7/16/2019 td 
        Dim boolIncludeQuotemark As Boolean ''Added 7/17/2019 thomas d. 
        Dim boolDummy_False As Boolean ''Added 7/18/2019 thomas d. 
        Dim boolProcessIsPaused As Boolean ''Added 7/18/2019 thomas d. 

        buttonProcessList.Enabled = False ''Block from being used twice in quick succession, accidentally.
        buttonProcessList.Refresh() ''Force the control to re-display itself.  
        Application.DoEvents()  ''Added 7/17/2019 thomas downes
        System.Threading.Thread.Sleep(1000)
        Application.DoEvents()  ''Added 7/17/2019 thomas downes
        System.Threading.Thread.Sleep(1000)

        boolIncludeQuotemark = checkExcelNeedsQuotemarks.Checked ''Added 7/17/2019 thomas d. 

        ''Check to see if we will be overwriting any prior run.  (The user must press the Clear button to re-run.)  
        ''   ----7/16/2019 td 
        If (0 <> TextListNumsReported.Text.Length) Then
            ''Let's not overwrite any prior run.  (The user must press the Clear button to re-run.)  
            MessageBox.Show("First, you must clear the right-hand box." & vbCrLf & vbCrLf &
                             "(Press the Clear button before executing a 2nd run.)", "",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            buttonProcessList.Enabled = True ''Allow it to be used again. ---7/17/2019 td 
            Exit Sub
        End If ''ENd fo "If (0 <> TextListNumsReported.Text.Length) Then"

        ''Added 7/16/2019 td 
        intAnticipatedItems = TextListNumsPrinted.Lines().Count
        lblProcessCountTracker.Visible = True
        lblProcessCountTracker.Text = String.Format(lblProcessCountTracker.Tag.ToString(), 0, intAnticipatedItems)

        ''Added 7/16/2019 td 
        lblTimeOfStart.Visible = True
        ''7/18/2019 td''lblTimeOfStart.Text = "Started " & DateTime.Now.ToString("hh:nn:ss am/pm")
        lblTimeOfStart.Text = "Started " & DateTime.Now.ToString("hh:mm:ss am/pm")

        ''
        ''Initialize processing values!  
        ''
        With mod_process
            .bProcessInitiated = False ''Don't set to True quite yet!! 
            .bUserRequestsPause = False
            .bPauseRequestGranted = False
            .boolInsertCrLf = False
            .int1to40 = 0
            .intLineIndex_Prior = 0
            .intAnticipatedItems = intAnticipatedItems
            .intCountProcessed = 0
            .strErrorMessage = ""
            .bExcelRequiresAQuotemark = checkExcelNeedsQuotemarks.Checked
            .bExcelRequiresASpaceChar = checkExcelNeedsBlankSpaces.Checked
        End With

        ''
        ''Encapsulated 7/17/2019 thomas downes
        ''
        Process_Master(mod_process, boolDummy_False, boolProcessIsPaused)

        If (0 < strErrMessage.Length) Then GoTo ErrHandler

ExitHandler:
        ''Added 7/16/2019 td 
        If (boolProcessIsPaused) Then
            ''
            ''Added 7 / 16 / 2019 td 
            ''
            buttonResume.Visible = True

        Else
            lblTimeOfFinish.Visible = True
            ''7/18/2019 td''lblTimeOfFinish.Text = "Ended " & DateTime.Now.ToString("hh:nn:ss am/pm")
            lblTimeOfFinish.Text = "Ended " & DateTime.Now.ToString("hh:mm:ss am/pm")
            buttonProcessList.Enabled = True ''Allow it to be used again. ---7/17/2019 td 

            intCountFinal = TextListNumsReported.Lines().Count

            If (checkboxAutoCopy.Checked) Then CopyTheReportedNumsToClipboard()
            ''Inform the user of completion. 
            MessageBox.Show(String.Format("Completed sequence.  There are now {0} items.", intCountFinal), "Generate",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If ''End of "If (boolProcessIsPaused) Then .... Else ...."

        Exit Sub
ErrHandler:
        If (0 < strErrMessage.Length) Then MessageBox.Show("Program error, as follows: " & strErrMessage, "",
                                                           MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub ButtonReportedClear_Click(sender As Object, e As EventArgs) Handles ButtonReportedClear.Click

        Dim intDiagReply As DialogResult

        intDiagReply = MessageBox.Show("Are you sure you want to clear/delete the list of Reported Numbers?", "Clear?",
                                       MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        If (DialogResult.Yes = intDiagReply) Then TextListNumsReported.Clear()
        ''Added 7/18/2019 td 
        If (DialogResult.Yes = intDiagReply) Then buttonProcessList.Enabled = True

    End Sub

    Private Sub Process_Master(ByRef par_process As ProcessingInfo,
                                Optional pboolResume As Boolean = False,
                               Optional ByRef pref_bProcessIsPaused As Boolean = False)
        ''
        ''Added 7/17/2019 thomas downes
        ''
        ''Dim boolInsertCrLf As Boolean
        ''Dim intAnticipatedItems As Integer  ''Added 7/16/2019 thomas d. 
        ''Dim intCountProcessed As Integer  ''Added 7/16/2019 thomas d. 
        ''Dim int1to40 As Integer ''Added 7/16/2019 td 

        Dim each_numberPrinted As String ''Added 7/17/2019 td  
        Dim each_lineIndex As Integer ''Added 7/17/2019 td
        Dim startingIndex As Integer ''Added 7/17/2019 td
        Dim endingIndex As Integer ''Added 7/17/2019 td

        If (pboolResume Or mod_process.bProcessInitiated) Then

            ''Resume the work! 
            startingIndex = (1 + mod_process.intLineIndex_Prior)

        ElseIf (Not pboolResume) Then
            startingIndex = 0 ''Added 7/17/2019 td 
            endingIndex = (-1 + TextListNumsPrinted.Lines().Count) ''Added 7/17/2019 td
        End If ''Endof ""If (pboolResume) Then ... Else"

        ''7/17/20019 td''For Each each_numberPrinted As String In TextListNumsPrinted.Lines()
        For each_lineIndex = startingIndex To endingIndex

            ''Added 7/17/2019 td  
            mod_process.bProcessInitiated = True

            ''Added 7/17/2019 td  
            ''7/18/2019 td''each_numberPrinted = TextListNumsPrinted.Lines(each_lineIndex)
            each_numberPrinted = TextListNumsPrinted.Lines(each_lineIndex).Trim()

            ''Added 7/16/2019 td  
            If ("" = each_numberPrinted) Then Continue For ''The very list item might be blank. ---7/16/2019 td

            ''
            ''Encapsulated 7/17/2019 td 
            ''
            Process_OneNumber(par_process, each_numberPrinted)

            ''Added 7/17/2019 td  
            If (par_process.bErrorOccurred) Then Exit For

PrepareForNextLoop:
            With par_process
                .int1to40 += 1
                If (.int1to40 >= 40) Then Application.DoEvents()
                If (.int1to40 >= 40) Then Application.DoEvents()
                If (.int1to40 >= 40) Then .int1to40 = 0
                .boolInsertCrLf = True
            End With ''End of "With par_process"

            ''Clear the single-line textboxes.  
            TextReportedNum_Current.Clear()
            TextPrintedNum_Current.Clear()

            ''Added 7/17/2019 td 
            With mod_process
                .intLineIndex_Prior = each_lineIndex
                If (.bUserRequestsPause) Then
                    .bPauseRequestGranted = True
                    pref_bProcessIsPaused = True ''Added 7/18/2019 td  
                    Exit For ''Leave this For-Next loop. 
                End If ''End of "If (.bUserRequestsPause) Then"
            End With ''End of "With mod_process"

        Next each_lineIndex ''Next each_numberPrinted

    End Sub ''End of "Private Sub Process_Master()"

    Private Sub Process_OneNumber(ByRef par_process As ProcessingInfo, ByRef par_numberPrinted As String)
        ''
        ''Added 7/17/2019 thomas downes
        ''
        Dim strExcelPrefixChar As String = "" ''Added 7/18/2019 td

        ''Added 7/16/2019 td  
        If (par_process.boolInsertCrLf) Then TextListNumsReported.AppendText(vbCrLf)

        TextPrintedNum_Current.Text = par_numberPrinted

        TextReportedNum_Current.Text = mod_SubtractDecs.SubAnyTwoDecStrings(par_numberPrinted, TWO_TO_POWER_64,
                                                                                par_process.strErrorMessage)

        ''
        ''Encapsulated 7/16/2019 thomas downes
        ''
        CleanUpLeadingZeros_Reported(TextReportedNum_Current)

        ''7/17/2019 td''If (0 < par_process.strErrorMessage.Length) Then Exit For
        If (0 < par_process.strErrorMessage.Length) Then
            par_process.bErrorOccurred = True
            Exit Sub
        End If ''ENd of "If (0 < par_process.strErrorMessage.Length) Then"

        ''Output !!
        ''   7/16/2019 td''TextListNumsReported.AppendText(GetLineOfOutput() & vbCrLf)
        ''   7/17/2019 td''TextListNumsReported.AppendText(GetLineOfOutput())
        '' #1  7/18/2019 td''TextListNumsReported.AppendText(GetLineOfOutput(par_process.bExcelRequiresAQuotemark))

        '' #2 7/18/2019 td''strExcelPrefixChar = IIf(par_process.bExcelRequiresAQuotemark, "'",
        '' #2 7/18/2019 td''                         IIf(par_process.bExcelRequiresASpaceChar, " ", "")).ToString()
        '' #2 7/18/2019 td''TextListNumsReported.AppendText(GetLineOfOutput(strExcelPrefixChar))

        ''Added 7/17/2019 td  
        '' #3 7/18/2019 td''Dim strExcelTextualChar As String = ""
        If (par_process.bExcelRequiresAQuotemark) Then strExcelPrefixChar = "'"
        If (par_process.bExcelRequiresASpaceChar) Then strExcelPrefixChar = " "
        TextListNumsReported.AppendText(GetLineOfOutput(strExcelPrefixChar))

        ''Added 7/16/2019 td 
        par_process.intCountProcessed += 1
        lblProcessCountTracker.Text = String.Format(lblProcessCountTracker.Tag.ToString(),
                                                        par_process.intCountProcessed,
                                                        par_process.intAnticipatedItems)

    End Sub ''End of "Private Sub Process_OneNumber()"

    Private Sub ButtonPasteListOfPrinted_Click(sender As Object, e As EventArgs) Handles ButtonPasteListOfPrinted.Click
        ''
        ''Added 7/16/2019 thomas downes
        ''
        Dim intDiagReply As DialogResult
        Dim intCountPrintedNums As Integer

        intCountPrintedNums = TextListNumsPrinted.Lines().Count

        ''Double-check with the user.  
        intDiagReply = MessageBox.Show(String.Format("Are you sure you want to replace the list of {0} Printed Numbers?",
                                                     intCountPrintedNums), "Clear?",
                                       MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        If (DialogResult.Yes = intDiagReply) Then

            TextListNumsPrinted.Clear()
            TextListNumsPrinted.Text = Windows.Forms.Clipboard.GetText()

        End If ''End of "If (DialogResult.Yes = intDiagReply) Then"

    End Sub

    Private Sub ButtonPrintedClear_Click(sender As Object, e As EventArgs) Handles ButtonPrintedClear.Click
        Dim intDiagReply As DialogResult
        Dim intCountPrintedNums As Integer

        intCountPrintedNums = TextListNumsPrinted.Lines().Count

        ''Double-check with the user.  
        intDiagReply = MessageBox.Show(String.Format("Are you sure you want to replace the list of {0} Printed Numbers?",
                                                     intCountPrintedNums), "Clear?",
                                       MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        If (DialogResult.Yes = intDiagReply) Then

            TextListNumsPrinted.Clear()

        End If ''End of "If (DialogResult.Yes = intDiagReply) Then"
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelRestoreDefault.LinkClicked

        ''Added 7/16/2019 thomas downes

        ''TextListNumsPrinted.Text = DEFAULT_PRINTED_NUMBER
        Dim intDiagReply As DialogResult
        Dim intCountPrintedNums As Integer

        intCountPrintedNums = TextListNumsPrinted.Lines().Count

        If (0 < intCountPrintedNums) Then
            ''Double-check with the user.  
            intDiagReply = MessageBox.Show(String.Format("Are you sure you want to replace the list of {0} Printed Numbers?",
                                                     intCountPrintedNums), "Clear?",
                                       MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        End If ''End of "If (0 < intCountPrintedNums) Then"

        If (DialogResult.Yes = intDiagReply) Then

            TextListNumsPrinted.Clear()
            TextListNumsPrinted.Text = DEFAULT_PRINTED_NUMBER

        ElseIf (0 = intCountPrintedNums) Then

            ''Not needed. ---7/16/2019 td''TextListNumsPrinted.Clear()
            TextListNumsPrinted.Text = DEFAULT_PRINTED_NUMBER

        End If ''End of "If (DialogResult.Yes = intDiagReply) Then ..... ElseIf ....."

    End Sub

    Private Sub ButtonReportedCopy_Click(sender As Object, e As EventArgs) Handles ButtonReportedCopy.Click

        ''ADded 7/16/2019 td  
        CopyTheReportedNumsToClipboard()

    End Sub

    Private Sub LabelWebsiteLink1_Click(sender As Object, e As EventArgs) Handles LabelWebsiteLink1.Click
        ''
        ''Added 7/15/2019 thomas downes
        ''
        System.Diagnostics.Process.Start("https://www.rapidtables.com/convert/number/hex-to-decimal.html")

    End Sub

    Private Sub LinkHowAreReportedNumbers_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkHowAreReportedNums1.LinkClicked, LinkHowAreReportedNums2.LinkClicked

        ''
        ''Added 7/16/2019 thomas downes   
        ''
        Dim frm_toShow As New FormDemoReportedNum ''Added 7/16/2019 thomas downes 
        frm_toShow.Show()


    End Sub

    Private Sub LinkPauseProcessing_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkPauseProcessing.LinkClicked

        ''Added 7/1/2019 thomas downes
        ''
        mod_process.bUserRequestsPause = True

    End Sub

    Private Sub LinkResumeProcessing_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkResumeProcessing.LinkClicked

        ''Added 7/1/2019 thomas downes
        ''
        ResumeProcessing_WithChecks()

    End Sub

    Private Sub ResumeProcessing_WithChecks()
        ''
        ''Encapsulated 7/17/2019 td 
        ''
        Dim bCurrentlyPaused As Boolean

        bCurrentlyPaused = (mod_process.bUserRequestsPause Or mod_process.bPauseRequestGranted)

        If (bCurrentlyPaused) Then
            ''
            ''Proceed to re-start processing (to complete the paused processing).  
            ''
            mod_process.bUserRequestsPause = False ''Reinitialize to False!!  Otherwise we will only process one or two numbers, if that.  
            mod_process.bPauseRequestGranted = False ''Reinitialize to False!!
            Const c_boolResumeProcessing As Boolean = True
            buttonResume.Visible = False ''Hide it again, since is only supposed to appear while
            '' processing has been paused (and is currently in pause).
            Application.DoEvents()

            ''
            ''Major call !!
            ''
            Process_Master(mod_process, c_boolResumeProcessing)

        Else
            MsgBox("This command (Resume) is not currently applicable.", vbExclamation)

        End If ''End of "If (bCurrentlyPaused) Then.... Else ...."

    End Sub ''End of "Private Sub ResumeProcessing_WithChecks()"

    Private Sub ButtonResume_Click(sender As Object, e As EventArgs) Handles buttonResume.Click

        ''Added 7/17/2019 td 
        buttonResume.Visible = False ''Hide it again, since is only supposed to appear while
        '' processing has been paused (and is currently in pause).

        Application.DoEvents()

        ''Encapsulated 7/17/2019 td 
        ResumeProcessing_WithChecks()

    End Sub
End Class