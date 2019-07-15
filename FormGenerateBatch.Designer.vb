<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGenerateBatch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGenerateBatch))
        Me.buttonProcessList = New System.Windows.Forms.Button()
        Me.TextListNumsReported = New System.Windows.Forms.TextBox()
        Me.LabelHdrReportedNumList = New System.Windows.Forms.Label()
        Me.TextListNumsPrinted = New System.Windows.Forms.TextBox()
        Me.LabelHdrPrintedNumList = New System.Windows.Forms.Label()
        Me.LabelHeaderBatchProcess = New System.Windows.Forms.Label()
        Me.ButtonPrintedClear = New System.Windows.Forms.Button()
        Me.ButtonReportedCopy = New System.Windows.Forms.Button()
        Me.ButtonReportedClear = New System.Windows.Forms.Button()
        Me.LinkGenerateList = New System.Windows.Forms.LinkLabel()
        Me.txtSequenceOfHowMany = New System.Windows.Forms.TextBox()
        Me.ListOfTextboxesOnForm = New System.Windows.Forms.ListBox()
        Me.TextPrintedNum_Current = New System.Windows.Forms.TextBox()
        Me.LabelHdrCurrentPrinted = New System.Windows.Forms.Label()
        Me.LabelHdrCurrentReported = New System.Windows.Forms.Label()
        Me.TextReportedNum_Current = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonPasteListOfPrinted = New System.Windows.Forms.Button()
        Me.LinkLabelRestoreDefault = New System.Windows.Forms.LinkLabel()
        Me.checkboxAutoCopy = New System.Windows.Forms.CheckBox()
        Me.LabelWebsiteLink1 = New System.Windows.Forms.Label()
        Me.LinkHowAreReportedNums1 = New System.Windows.Forms.LinkLabel()
        Me.LinkHowAreReportedNums2 = New System.Windows.Forms.LinkLabel()
        Me.lblProcessCountTracker = New System.Windows.Forms.Label()
        Me.lblTimeOfStart = New System.Windows.Forms.Label()
        Me.lblTimeOfFinish = New System.Windows.Forms.Label()
        Me.checkExcelNeedsQuotemarks = New System.Windows.Forms.CheckBox()
        Me.LinkPauseProcessing = New System.Windows.Forms.LinkLabel()
        Me.LinkResumeProcessing = New System.Windows.Forms.LinkLabel()
        Me.buttonResume = New System.Windows.Forms.Button()
        Me.checkExcelNeedsBlankSpaces = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'buttonProcessList
        '
        Me.buttonProcessList.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonProcessList.Location = New System.Drawing.Point(422, 119)
        Me.buttonProcessList.Name = "buttonProcessList"
        Me.buttonProcessList.Size = New System.Drawing.Size(123, 56)
        Me.buttonProcessList.TabIndex = 28
        Me.buttonProcessList.Text = ">>>>"
        Me.buttonProcessList.UseVisualStyleBackColor = True
        '
        'TextListNumsReported
        '
        Me.TextListNumsReported.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextListNumsReported.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextListNumsReported.Location = New System.Drawing.Point(561, 89)
        Me.TextListNumsReported.Margin = New System.Windows.Forms.Padding(2)
        Me.TextListNumsReported.Multiline = True
        Me.TextListNumsReported.Name = "TextListNumsReported"
        Me.TextListNumsReported.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextListNumsReported.Size = New System.Drawing.Size(406, 331)
        Me.TextListNumsReported.TabIndex = 27
        '
        'LabelHdrReportedNumList
        '
        Me.LabelHdrReportedNumList.AutoSize = True
        Me.LabelHdrReportedNumList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHdrReportedNumList.Location = New System.Drawing.Point(460, 67)
        Me.LabelHdrReportedNumList.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelHdrReportedNumList.Name = "LabelHdrReportedNumList"
        Me.LabelHdrReportedNumList.Size = New System.Drawing.Size(284, 20)
        Me.LabelHdrReportedNumList.TabIndex = 26
        Me.LabelHdrReportedNumList.Text = "Output / Printed && Reported Numbers *"
        '
        'TextListNumsPrinted
        '
        Me.TextListNumsPrinted.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextListNumsPrinted.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextListNumsPrinted.Location = New System.Drawing.Point(151, 89)
        Me.TextListNumsPrinted.Margin = New System.Windows.Forms.Padding(2)
        Me.TextListNumsPrinted.Multiline = True
        Me.TextListNumsPrinted.Name = "TextListNumsPrinted"
        Me.TextListNumsPrinted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextListNumsPrinted.Size = New System.Drawing.Size(252, 379)
        Me.TextListNumsPrinted.TabIndex = 25
        Me.TextListNumsPrinted.Text = "16142029164840482413"
        '
        'LabelHdrPrintedNumList
        '
        Me.LabelHdrPrintedNumList.AutoSize = True
        Me.LabelHdrPrintedNumList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHdrPrintedNumList.Location = New System.Drawing.Point(16, 64)
        Me.LabelHdrPrintedNumList.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelHdrPrintedNumList.Name = "LabelHdrPrintedNumList"
        Me.LabelHdrPrintedNumList.Size = New System.Drawing.Size(180, 20)
        Me.LabelHdrPrintedNumList.TabIndex = 24
        Me.LabelHdrPrintedNumList.Text = "Input / Printed Numbers:"
        '
        'LabelHeaderBatchProcess
        '
        Me.LabelHeaderBatchProcess.AutoSize = True
        Me.LabelHeaderBatchProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHeaderBatchProcess.Location = New System.Drawing.Point(12, 19)
        Me.LabelHeaderBatchProcess.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelHeaderBatchProcess.Name = "LabelHeaderBatchProcess"
        Me.LabelHeaderBatchProcess.Size = New System.Drawing.Size(674, 26)
        Me.LabelHeaderBatchProcess.TabIndex = 23
        Me.LabelHeaderBatchProcess.Text = "Generate Reported Numbers / Batch Processing of Printed Numbers"
        '
        'ButtonPrintedClear
        '
        Me.ButtonPrintedClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonPrintedClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrintedClear.Location = New System.Drawing.Point(146, 520)
        Me.ButtonPrintedClear.Name = "ButtonPrintedClear"
        Me.ButtonPrintedClear.Size = New System.Drawing.Size(179, 36)
        Me.ButtonPrintedClear.TabIndex = 29
        Me.ButtonPrintedClear.Text = "Clear Input"
        Me.ButtonPrintedClear.UseVisualStyleBackColor = True
        '
        'ButtonReportedCopy
        '
        Me.ButtonReportedCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonReportedCopy.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonReportedCopy.Location = New System.Drawing.Point(983, 538)
        Me.ButtonReportedCopy.Name = "ButtonReportedCopy"
        Me.ButtonReportedCopy.Size = New System.Drawing.Size(159, 36)
        Me.ButtonReportedCopy.TabIndex = 32
        Me.ButtonReportedCopy.Text = "Copy Output"
        Me.ButtonReportedCopy.UseVisualStyleBackColor = True
        '
        'ButtonReportedClear
        '
        Me.ButtonReportedClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonReportedClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonReportedClear.Location = New System.Drawing.Point(766, 538)
        Me.ButtonReportedClear.Name = "ButtonReportedClear"
        Me.ButtonReportedClear.Size = New System.Drawing.Size(175, 36)
        Me.ButtonReportedClear.TabIndex = 31
        Me.ButtonReportedClear.Text = "Clear Output"
        Me.ButtonReportedClear.UseVisualStyleBackColor = True
        '
        'LinkGenerateList
        '
        Me.LinkGenerateList.Location = New System.Drawing.Point(17, 134)
        Me.LinkGenerateList.Name = "LinkGenerateList"
        Me.LinkGenerateList.Size = New System.Drawing.Size(129, 80)
        Me.LinkGenerateList.TabIndex = 33
        Me.LinkGenerateList.TabStop = True
        Me.LinkGenerateList.Text = "Generate a list of sequential Printed Numbers"
        '
        'txtSequenceOfHowMany
        '
        Me.txtSequenceOfHowMany.Location = New System.Drawing.Point(86, 200)
        Me.txtSequenceOfHowMany.Name = "txtSequenceOfHowMany"
        Me.txtSequenceOfHowMany.Size = New System.Drawing.Size(40, 20)
        Me.txtSequenceOfHowMany.TabIndex = 34
        Me.txtSequenceOfHowMany.Text = "100"
        '
        'ListOfTextboxesOnForm
        '
        Me.ListOfTextboxesOnForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListOfTextboxesOnForm.DisplayMember = "Name"
        Me.ListOfTextboxesOnForm.FormattingEnabled = True
        Me.ListOfTextboxesOnForm.Location = New System.Drawing.Point(983, 89)
        Me.ListOfTextboxesOnForm.Name = "ListOfTextboxesOnForm"
        Me.ListOfTextboxesOnForm.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListOfTextboxesOnForm.Size = New System.Drawing.Size(160, 69)
        Me.ListOfTextboxesOnForm.TabIndex = 35
        '
        'TextPrintedNum_Current
        '
        Me.TextPrintedNum_Current.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextPrintedNum_Current.Location = New System.Drawing.Point(146, 480)
        Me.TextPrintedNum_Current.Name = "TextPrintedNum_Current"
        Me.TextPrintedNum_Current.Size = New System.Drawing.Size(252, 20)
        Me.TextPrintedNum_Current.TabIndex = 36
        '
        'LabelHdrCurrentPrinted
        '
        Me.LabelHdrCurrentPrinted.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelHdrCurrentPrinted.AutoSize = True
        Me.LabelHdrCurrentPrinted.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHdrCurrentPrinted.Location = New System.Drawing.Point(6, 478)
        Me.LabelHdrCurrentPrinted.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelHdrCurrentPrinted.Name = "LabelHdrCurrentPrinted"
        Me.LabelHdrCurrentPrinted.Size = New System.Drawing.Size(120, 20)
        Me.LabelHdrCurrentPrinted.TabIndex = 37
        Me.LabelHdrCurrentPrinted.Text = "Current Printed:"
        '
        'LabelHdrCurrentReported
        '
        Me.LabelHdrCurrentReported.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelHdrCurrentReported.AutoSize = True
        Me.LabelHdrCurrentReported.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHdrCurrentReported.Location = New System.Drawing.Point(484, 510)
        Me.LabelHdrCurrentReported.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelHdrCurrentReported.Name = "LabelHdrCurrentReported"
        Me.LabelHdrCurrentReported.Size = New System.Drawing.Size(137, 20)
        Me.LabelHdrCurrentReported.TabIndex = 39
        Me.LabelHdrCurrentReported.Text = "Current Reported:"
        '
        'TextReportedNum_Current
        '
        Me.TextReportedNum_Current.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextReportedNum_Current.Location = New System.Drawing.Point(624, 512)
        Me.TextReportedNum_Current.Name = "TextReportedNum_Current"
        Me.TextReportedNum_Current.Size = New System.Drawing.Size(252, 20)
        Me.TextReportedNum_Current.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 184)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 36)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "How many you want in sequence:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(570, 431)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(572, 58)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(980, 67)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 20)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Include in the Output box:"
        '
        'ButtonPasteListOfPrinted
        '
        Me.ButtonPasteListOfPrinted.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPasteListOfPrinted.Location = New System.Drawing.Point(201, 48)
        Me.ButtonPasteListOfPrinted.Name = "ButtonPasteListOfPrinted"
        Me.ButtonPasteListOfPrinted.Size = New System.Drawing.Size(137, 36)
        Me.ButtonPasteListOfPrinted.TabIndex = 43
        Me.ButtonPasteListOfPrinted.Text = "Paste List"
        Me.ButtonPasteListOfPrinted.UseVisualStyleBackColor = True
        '
        'LinkLabelRestoreDefault
        '
        Me.LinkLabelRestoreDefault.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabelRestoreDefault.Location = New System.Drawing.Point(12, 563)
        Me.LinkLabelRestoreDefault.Name = "LinkLabelRestoreDefault"
        Me.LinkLabelRestoreDefault.Size = New System.Drawing.Size(173, 21)
        Me.LinkLabelRestoreDefault.TabIndex = 44
        Me.LinkLabelRestoreDefault.TabStop = True
        Me.LinkLabelRestoreDefault.Text = "Restore default Printed Number"
        '
        'checkboxAutoCopy
        '
        Me.checkboxAutoCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkboxAutoCopy.AutoSize = True
        Me.checkboxAutoCopy.Checked = True
        Me.checkboxAutoCopy.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkboxAutoCopy.Location = New System.Drawing.Point(983, 521)
        Me.checkboxAutoCopy.Name = "checkboxAutoCopy"
        Me.checkboxAutoCopy.Size = New System.Drawing.Size(172, 17)
        Me.checkboxAutoCopy.TabIndex = 45
        Me.checkboxAutoCopy.Text = "Automatically copy to clipboard"
        Me.checkboxAutoCopy.UseVisualStyleBackColor = True
        '
        'LabelWebsiteLink1
        '
        Me.LabelWebsiteLink1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelWebsiteLink1.AutoSize = True
        Me.LabelWebsiteLink1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWebsiteLink1.ForeColor = System.Drawing.Color.Blue
        Me.LabelWebsiteLink1.Location = New System.Drawing.Point(376, 563)
        Me.LabelWebsiteLink1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelWebsiteLink1.Name = "LabelWebsiteLink1"
        Me.LabelWebsiteLink1.Size = New System.Drawing.Size(325, 13)
        Me.LabelWebsiteLink1.TabIndex = 46
        Me.LabelWebsiteLink1.Text = "Website to check calculation (Decimal from signed 2's complement)"
        '
        'LinkHowAreReportedNums1
        '
        Me.LinkHowAreReportedNums1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkHowAreReportedNums1.Location = New System.Drawing.Point(984, 312)
        Me.LinkHowAreReportedNums1.Name = "LinkHowAreReportedNums1"
        Me.LinkHowAreReportedNums1.Size = New System.Drawing.Size(173, 36)
        Me.LinkHowAreReportedNums1.TabIndex = 47
        Me.LinkHowAreReportedNums1.TabStop = True
        Me.LinkHowAreReportedNums1.Text = "How are Reported Numbers calculated?"
        '
        'LinkHowAreReportedNums2
        '
        Me.LinkHowAreReportedNums2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkHowAreReportedNums2.Location = New System.Drawing.Point(419, 301)
        Me.LinkHowAreReportedNums2.Name = "LinkHowAreReportedNums2"
        Me.LinkHowAreReportedNums2.Size = New System.Drawing.Size(126, 36)
        Me.LinkHowAreReportedNums2.TabIndex = 48
        Me.LinkHowAreReportedNums2.TabStop = True
        Me.LinkHowAreReportedNums2.Text = "How are Reported Numbers calculated?"
        '
        'lblProcessCountTracker
        '
        Me.lblProcessCountTracker.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblProcessCountTracker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessCountTracker.Location = New System.Drawing.Point(420, 337)
        Me.lblProcessCountTracker.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProcessCountTracker.Name = "lblProcessCountTracker"
        Me.lblProcessCountTracker.Size = New System.Drawing.Size(125, 54)
        Me.lblProcessCountTracker.TabIndex = 49
        Me.lblProcessCountTracker.Tag = "Processed {0} out of {1}"
        Me.lblProcessCountTracker.Text = "Processed {0} out of {1}"
        Me.lblProcessCountTracker.Visible = False
        '
        'lblTimeOfStart
        '
        Me.lblTimeOfStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTimeOfStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeOfStart.Location = New System.Drawing.Point(420, 391)
        Me.lblTimeOfStart.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTimeOfStart.Name = "lblTimeOfStart"
        Me.lblTimeOfStart.Size = New System.Drawing.Size(125, 44)
        Me.lblTimeOfStart.TabIndex = 50
        Me.lblTimeOfStart.Tag = "Started:  {0} "
        Me.lblTimeOfStart.Text = "Started: [start time]"
        Me.lblTimeOfStart.Visible = False
        '
        'lblTimeOfFinish
        '
        Me.lblTimeOfFinish.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTimeOfFinish.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeOfFinish.Location = New System.Drawing.Point(420, 435)
        Me.lblTimeOfFinish.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTimeOfFinish.Name = "lblTimeOfFinish"
        Me.lblTimeOfFinish.Size = New System.Drawing.Size(125, 44)
        Me.lblTimeOfFinish.TabIndex = 51
        Me.lblTimeOfFinish.Tag = "Ended:  {0} "
        Me.lblTimeOfFinish.Text = "Ended: [start time]"
        Me.lblTimeOfFinish.Visible = False
        '
        'checkExcelNeedsQuotemarks
        '
        Me.checkExcelNeedsQuotemarks.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkExcelNeedsQuotemarks.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.checkExcelNeedsQuotemarks.Checked = True
        Me.checkExcelNeedsQuotemarks.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkExcelNeedsQuotemarks.Location = New System.Drawing.Point(987, 228)
        Me.checkExcelNeedsQuotemarks.Name = "checkExcelNeedsQuotemarks"
        Me.checkExcelNeedsQuotemarks.Size = New System.Drawing.Size(172, 49)
        Me.checkExcelNeedsQuotemarks.TabIndex = 52
        Me.checkExcelNeedsQuotemarks.Text = "Include single quotemarks for use by MS Excel, to flag numbers as textual info."
        Me.checkExcelNeedsQuotemarks.UseVisualStyleBackColor = True
        '
        'LinkPauseProcessing
        '
        Me.LinkPauseProcessing.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkPauseProcessing.Location = New System.Drawing.Point(455, 230)
        Me.LinkPauseProcessing.Name = "LinkPauseProcessing"
        Me.LinkPauseProcessing.Size = New System.Drawing.Size(99, 15)
        Me.LinkPauseProcessing.TabIndex = 53
        Me.LinkPauseProcessing.TabStop = True
        Me.LinkPauseProcessing.Text = "Pause processing"
        '
        'LinkResumeProcessing
        '
        Me.LinkResumeProcessing.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkResumeProcessing.Location = New System.Drawing.Point(455, 245)
        Me.LinkResumeProcessing.Name = "LinkResumeProcessing"
        Me.LinkResumeProcessing.Size = New System.Drawing.Size(101, 21)
        Me.LinkResumeProcessing.TabIndex = 54
        Me.LinkResumeProcessing.TabStop = True
        Me.LinkResumeProcessing.Text = "Resume processing"
        '
        'buttonResume
        '
        Me.buttonResume.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonResume.Location = New System.Drawing.Point(424, 184)
        Me.buttonResume.Name = "buttonResume"
        Me.buttonResume.Size = New System.Drawing.Size(123, 33)
        Me.buttonResume.TabIndex = 55
        Me.buttonResume.Text = ">>>>"
        Me.buttonResume.UseVisualStyleBackColor = True
        Me.buttonResume.Visible = False
        '
        'checkExcelNeedsBlankSpaces
        '
        Me.checkExcelNeedsBlankSpaces.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkExcelNeedsBlankSpaces.Location = New System.Drawing.Point(983, 171)
        Me.checkExcelNeedsBlankSpaces.Name = "checkExcelNeedsBlankSpaces"
        Me.checkExcelNeedsBlankSpaces.Size = New System.Drawing.Size(172, 49)
        Me.checkExcelNeedsBlankSpaces.TabIndex = 56
        Me.checkExcelNeedsBlankSpaces.Text = "Include single spaces for use by MS Excel, to flag numbers as textual info."
        Me.checkExcelNeedsBlankSpaces.UseVisualStyleBackColor = True
        '
        'FormGenerateBatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1154, 586)
        Me.Controls.Add(Me.checkExcelNeedsBlankSpaces)
        Me.Controls.Add(Me.buttonResume)
        Me.Controls.Add(Me.LinkResumeProcessing)
        Me.Controls.Add(Me.LinkPauseProcessing)
        Me.Controls.Add(Me.checkExcelNeedsQuotemarks)
        Me.Controls.Add(Me.lblTimeOfFinish)
        Me.Controls.Add(Me.lblTimeOfStart)
        Me.Controls.Add(Me.lblProcessCountTracker)
        Me.Controls.Add(Me.LinkHowAreReportedNums2)
        Me.Controls.Add(Me.LinkHowAreReportedNums1)
        Me.Controls.Add(Me.LabelWebsiteLink1)
        Me.Controls.Add(Me.checkboxAutoCopy)
        Me.Controls.Add(Me.LinkLabelRestoreDefault)
        Me.Controls.Add(Me.ButtonPasteListOfPrinted)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSequenceOfHowMany)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelHdrCurrentReported)
        Me.Controls.Add(Me.TextReportedNum_Current)
        Me.Controls.Add(Me.LabelHdrCurrentPrinted)
        Me.Controls.Add(Me.TextPrintedNum_Current)
        Me.Controls.Add(Me.ListOfTextboxesOnForm)
        Me.Controls.Add(Me.LinkGenerateList)
        Me.Controls.Add(Me.ButtonReportedCopy)
        Me.Controls.Add(Me.ButtonReportedClear)
        Me.Controls.Add(Me.ButtonPrintedClear)
        Me.Controls.Add(Me.buttonProcessList)
        Me.Controls.Add(Me.TextListNumsReported)
        Me.Controls.Add(Me.LabelHdrReportedNumList)
        Me.Controls.Add(Me.TextListNumsPrinted)
        Me.Controls.Add(Me.LabelHdrPrintedNumList)
        Me.Controls.Add(Me.LabelHeaderBatchProcess)
        Me.Name = "FormGenerateBatch"
        Me.Text = "FormGenerateBatch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonProcessList As Button
    Friend WithEvents TextListNumsReported As TextBox
    Friend WithEvents LabelHdrReportedNumList As Label
    Friend WithEvents TextListNumsPrinted As TextBox
    Friend WithEvents LabelHdrPrintedNumList As Label
    Friend WithEvents LabelHeaderBatchProcess As Label
    Friend WithEvents ButtonPrintedClear As Button
    Friend WithEvents ButtonReportedCopy As Button
    Friend WithEvents ButtonReportedClear As Button
    Friend WithEvents LinkGenerateList As LinkLabel
    Friend WithEvents txtSequenceOfHowMany As TextBox
    Friend WithEvents ListOfTextboxesOnForm As ListBox
    Friend WithEvents TextPrintedNum_Current As TextBox
    Friend WithEvents LabelHdrCurrentPrinted As Label
    Friend WithEvents LabelHdrCurrentReported As Label
    Friend WithEvents TextReportedNum_Current As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonPasteListOfPrinted As Button
    Friend WithEvents LinkLabelRestoreDefault As LinkLabel
    Friend WithEvents checkboxAutoCopy As CheckBox
    Friend WithEvents LabelWebsiteLink1 As Label
    Friend WithEvents LinkHowAreReportedNums1 As LinkLabel
    Friend WithEvents LinkHowAreReportedNums2 As LinkLabel
    Friend WithEvents lblProcessCountTracker As Label
    Friend WithEvents lblTimeOfStart As Label
    Friend WithEvents lblTimeOfFinish As Label
    Friend WithEvents checkExcelNeedsQuotemarks As CheckBox
    Friend WithEvents LinkPauseProcessing As LinkLabel
    Friend WithEvents LinkResumeProcessing As LinkLabel
    Friend WithEvents buttonResume As Button
    Friend WithEvents checkExcelNeedsBlankSpaces As CheckBox
End Class
