<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddSubtract
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelHeader2Add = New System.Windows.Forms.Label()
        Me.chkEnforceCommas = New System.Windows.Forms.CheckBox()
        Me.LabelHeader1Minus = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtReportedNumber = New System.Windows.Forms.TextBox()
        Me.LabelDecimalFromSigned2sComp = New System.Windows.Forms.Label()
        Me.LabelSub2TwoPowerOf64b = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelRightHdrEqualsMinus = New System.Windows.Forms.Label()
        Me.LabelSub2TwoPowerOf64a = New System.Windows.Forms.Label()
        Me.LabelSub1TwoPowerOf64 = New System.Windows.Forms.Label()
        Me.txtAnswerMinus = New System.Windows.Forms.TextBox()
        Me.LabelLeftHdrEqualsMinus = New System.Windows.Forms.Label()
        Me.txtMinusTop = New System.Windows.Forms.TextBox()
        Me.LabelGreySeparatorSub = New System.Windows.Forms.Label()
        Me.txtMinusBottom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelAdd = New System.Windows.Forms.Panel()
        Me.LabelRightHdrEqualsAdd = New System.Windows.Forms.Label()
        Me.LabelAdd2TwoPowerOf64 = New System.Windows.Forms.Label()
        Me.LabelAdd1TwoPowerOf64 = New System.Windows.Forms.Label()
        Me.txtAnswerAdd = New System.Windows.Forms.TextBox()
        Me.LabelLeftHdrEqualsAdd = New System.Windows.Forms.Label()
        Me.txtSummand1 = New System.Windows.Forms.TextBox()
        Me.LabelGreySeparatorAdd = New System.Windows.Forms.Label()
        Me.txtSummand2 = New System.Windows.Forms.TextBox()
        Me.LabelLeftHdrAdd = New System.Windows.Forms.Label()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.PanelAdd.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 22)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Subtract Numbers of Any Size (Base 10)"
        '
        'LabelHeader2Add
        '
        Me.LabelHeader2Add.AutoSize = True
        Me.LabelHeader2Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHeader2Add.Location = New System.Drawing.Point(12, 277)
        Me.LabelHeader2Add.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelHeader2Add.Name = "LabelHeader2Add"
        Me.LabelHeader2Add.Size = New System.Drawing.Size(297, 22)
        Me.LabelHeader2Add.TabIndex = 20
        Me.LabelHeader2Add.Text = "Add Numbers of Any Size (Base 10)"
        '
        'chkEnforceCommas
        '
        Me.chkEnforceCommas.AutoSize = True
        Me.chkEnforceCommas.Checked = True
        Me.chkEnforceCommas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEnforceCommas.Location = New System.Drawing.Point(594, 65)
        Me.chkEnforceCommas.Name = "chkEnforceCommas"
        Me.chkEnforceCommas.Size = New System.Drawing.Size(224, 17)
        Me.chkEnforceCommas.TabIndex = 19
        Me.chkEnforceCommas.Text = "Enforce commas to separate digital triplets"
        Me.chkEnforceCommas.UseVisualStyleBackColor = True
        '
        'LabelHeader1Minus
        '
        Me.LabelHeader1Minus.AutoSize = True
        Me.LabelHeader1Minus.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHeader1Minus.Location = New System.Drawing.Point(11, 19)
        Me.LabelHeader1Minus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelHeader1Minus.Name = "LabelHeader1Minus"
        Me.LabelHeader1Minus.Size = New System.Drawing.Size(391, 31)
        Me.LabelHeader1Minus.TabIndex = 18
        Me.LabelHeader1Minus.Text = "Add or Subtract Huge Numbers"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MintCream
        Me.Panel1.Controls.Add(Me.txtReportedNumber)
        Me.Panel1.Controls.Add(Me.LabelDecimalFromSigned2sComp)
        Me.Panel1.Controls.Add(Me.LabelSub2TwoPowerOf64b)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.LabelRightHdrEqualsMinus)
        Me.Panel1.Controls.Add(Me.LabelSub2TwoPowerOf64a)
        Me.Panel1.Controls.Add(Me.LabelSub1TwoPowerOf64)
        Me.Panel1.Controls.Add(Me.txtAnswerMinus)
        Me.Panel1.Controls.Add(Me.LabelLeftHdrEqualsMinus)
        Me.Panel1.Controls.Add(Me.txtMinusTop)
        Me.Panel1.Controls.Add(Me.LabelGreySeparatorSub)
        Me.Panel1.Controls.Add(Me.txtMinusBottom)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(52, 87)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(767, 172)
        Me.Panel1.TabIndex = 17
        '
        'txtReportedNumber
        '
        Me.txtReportedNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReportedNumber.Location = New System.Drawing.Point(363, 129)
        Me.txtReportedNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtReportedNumber.Name = "txtReportedNumber"
        Me.txtReportedNumber.ReadOnly = True
        Me.txtReportedNumber.Size = New System.Drawing.Size(337, 26)
        Me.txtReportedNumber.TabIndex = 15
        '
        'LabelDecimalFromSigned2sComp
        '
        Me.LabelDecimalFromSigned2sComp.AutoSize = True
        Me.LabelDecimalFromSigned2sComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDecimalFromSigned2sComp.Location = New System.Drawing.Point(34, 132)
        Me.LabelDecimalFromSigned2sComp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDecimalFromSigned2sComp.Name = "LabelDecimalFromSigned2sComp"
        Me.LabelDecimalFromSigned2sComp.Size = New System.Drawing.Size(322, 20)
        Me.LabelDecimalFromSigned2sComp.TabIndex = 14
        Me.LabelDecimalFromSigned2sComp.Text = "Reported Number (Signed 2's Complement):"
        '
        'LabelSub2TwoPowerOf64b
        '
        Me.LabelSub2TwoPowerOf64b.AutoSize = True
        Me.LabelSub2TwoPowerOf64b.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSub2TwoPowerOf64b.ForeColor = System.Drawing.Color.Blue
        Me.LabelSub2TwoPowerOf64b.Location = New System.Drawing.Point(96, 49)
        Me.LabelSub2TwoPowerOf64b.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelSub2TwoPowerOf64b.Name = "LabelSub2TwoPowerOf64b"
        Me.LabelSub2TwoPowerOf64b.Size = New System.Drawing.Size(51, 20)
        Me.LabelSub2TwoPowerOf64b.TabIndex = 13
        Me.LabelSub2TwoPowerOf64b.Text = "2 ^ 64"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 17)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Printed Number"
        '
        'LabelRightHdrEqualsMinus
        '
        Me.LabelRightHdrEqualsMinus.AutoSize = True
        Me.LabelRightHdrEqualsMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRightHdrEqualsMinus.ForeColor = System.Drawing.Color.Blue
        Me.LabelRightHdrEqualsMinus.Location = New System.Drawing.Point(554, 96)
        Me.LabelRightHdrEqualsMinus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelRightHdrEqualsMinus.Name = "LabelRightHdrEqualsMinus"
        Me.LabelRightHdrEqualsMinus.Size = New System.Drawing.Size(212, 18)
        Me.LabelRightHdrEqualsMinus.TabIndex = 10
        Me.LabelRightHdrEqualsMinus.Text = "<<<<<< Get Reported Number"
        '
        'LabelSub2TwoPowerOf64a
        '
        Me.LabelSub2TwoPowerOf64a.AutoSize = True
        Me.LabelSub2TwoPowerOf64a.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSub2TwoPowerOf64a.ForeColor = System.Drawing.Color.Blue
        Me.LabelSub2TwoPowerOf64a.Location = New System.Drawing.Point(566, 49)
        Me.LabelSub2TwoPowerOf64a.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelSub2TwoPowerOf64a.Name = "LabelSub2TwoPowerOf64a"
        Me.LabelSub2TwoPowerOf64a.Size = New System.Drawing.Size(51, 20)
        Me.LabelSub2TwoPowerOf64a.TabIndex = 9
        Me.LabelSub2TwoPowerOf64a.Text = "2 ^ 64"
        '
        'LabelSub1TwoPowerOf64
        '
        Me.LabelSub1TwoPowerOf64.AutoSize = True
        Me.LabelSub1TwoPowerOf64.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSub1TwoPowerOf64.ForeColor = System.Drawing.Color.Blue
        Me.LabelSub1TwoPowerOf64.Location = New System.Drawing.Point(614, 27)
        Me.LabelSub1TwoPowerOf64.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelSub1TwoPowerOf64.Name = "LabelSub1TwoPowerOf64"
        Me.LabelSub1TwoPowerOf64.Size = New System.Drawing.Size(124, 13)
        Me.LabelSub1TwoPowerOf64.TabIndex = 8
        Me.LabelSub1TwoPowerOf64.Text = "If testing reverse: 2 ^ 64 "
        '
        'txtAnswerMinus
        '
        Me.txtAnswerMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswerMinus.Location = New System.Drawing.Point(151, 93)
        Me.txtAnswerMinus.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAnswerMinus.Name = "txtAnswerMinus"
        Me.txtAnswerMinus.Size = New System.Drawing.Size(400, 26)
        Me.txtAnswerMinus.TabIndex = 2
        '
        'LabelLeftHdrEqualsMinus
        '
        Me.LabelLeftHdrEqualsMinus.AutoSize = True
        Me.LabelLeftHdrEqualsMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLeftHdrEqualsMinus.ForeColor = System.Drawing.Color.Blue
        Me.LabelLeftHdrEqualsMinus.Location = New System.Drawing.Point(11, 96)
        Me.LabelLeftHdrEqualsMinus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelLeftHdrEqualsMinus.Name = "LabelLeftHdrEqualsMinus"
        Me.LabelLeftHdrEqualsMinus.Size = New System.Drawing.Size(136, 20)
        Me.LabelLeftHdrEqualsMinus.TabIndex = 6
        Me.LabelLeftHdrEqualsMinus.Text = "Equals / Calculate"
        '
        'txtMinusTop
        '
        Me.txtMinusTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinusTop.Location = New System.Drawing.Point(151, 14)
        Me.txtMinusTop.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMinusTop.Name = "txtMinusTop"
        Me.txtMinusTop.Size = New System.Drawing.Size(400, 26)
        Me.txtMinusTop.TabIndex = 0
        Me.txtMinusTop.Text = "16,142,029,164,840,482,413"
        '
        'LabelGreySeparatorSub
        '
        Me.LabelGreySeparatorSub.BackColor = System.Drawing.Color.DimGray
        Me.LabelGreySeparatorSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGreySeparatorSub.Location = New System.Drawing.Point(50, 75)
        Me.LabelGreySeparatorSub.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelGreySeparatorSub.Name = "LabelGreySeparatorSub"
        Me.LabelGreySeparatorSub.Size = New System.Drawing.Size(515, 10)
        Me.LabelGreySeparatorSub.TabIndex = 5
        '
        'txtMinusBottom
        '
        Me.txtMinusBottom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinusBottom.Location = New System.Drawing.Point(151, 46)
        Me.txtMinusBottom.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMinusBottom.Name = "txtMinusBottom"
        Me.txtMinusBottom.Size = New System.Drawing.Size(400, 26)
        Me.txtMinusBottom.TabIndex = 1
        Me.txtMinusBottom.Text = "18,446,744,073,709,551,616"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 49)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Minus (-)"
        '
        'PanelAdd
        '
        Me.PanelAdd.BackColor = System.Drawing.Color.LightBlue
        Me.PanelAdd.Controls.Add(Me.LabelRightHdrEqualsAdd)
        Me.PanelAdd.Controls.Add(Me.LabelAdd2TwoPowerOf64)
        Me.PanelAdd.Controls.Add(Me.LabelAdd1TwoPowerOf64)
        Me.PanelAdd.Controls.Add(Me.txtAnswerAdd)
        Me.PanelAdd.Controls.Add(Me.LabelLeftHdrEqualsAdd)
        Me.PanelAdd.Controls.Add(Me.txtSummand1)
        Me.PanelAdd.Controls.Add(Me.LabelGreySeparatorAdd)
        Me.PanelAdd.Controls.Add(Me.txtSummand2)
        Me.PanelAdd.Controls.Add(Me.LabelLeftHdrAdd)
        Me.PanelAdd.Location = New System.Drawing.Point(54, 310)
        Me.PanelAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelAdd.Name = "PanelAdd"
        Me.PanelAdd.Size = New System.Drawing.Size(766, 129)
        Me.PanelAdd.TabIndex = 16
        '
        'LabelRightHdrEqualsAdd
        '
        Me.LabelRightHdrEqualsAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelRightHdrEqualsAdd.AutoSize = True
        Me.LabelRightHdrEqualsAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRightHdrEqualsAdd.ForeColor = System.Drawing.Color.Blue
        Me.LabelRightHdrEqualsAdd.Location = New System.Drawing.Point(694, 96)
        Me.LabelRightHdrEqualsAdd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelRightHdrEqualsAdd.Name = "LabelRightHdrEqualsAdd"
        Me.LabelRightHdrEqualsAdd.Size = New System.Drawing.Size(39, 13)
        Me.LabelRightHdrEqualsAdd.TabIndex = 9
        Me.LabelRightHdrEqualsAdd.Text = "Equals"
        '
        'LabelAdd2TwoPowerOf64
        '
        Me.LabelAdd2TwoPowerOf64.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelAdd2TwoPowerOf64.AutoSize = True
        Me.LabelAdd2TwoPowerOf64.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAdd2TwoPowerOf64.ForeColor = System.Drawing.Color.Blue
        Me.LabelAdd2TwoPowerOf64.Location = New System.Drawing.Point(694, 49)
        Me.LabelAdd2TwoPowerOf64.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAdd2TwoPowerOf64.Name = "LabelAdd2TwoPowerOf64"
        Me.LabelAdd2TwoPowerOf64.Size = New System.Drawing.Size(37, 13)
        Me.LabelAdd2TwoPowerOf64.TabIndex = 8
        Me.LabelAdd2TwoPowerOf64.Text = "2 ^ 64"
        '
        'LabelAdd1TwoPowerOf64
        '
        Me.LabelAdd1TwoPowerOf64.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelAdd1TwoPowerOf64.AutoSize = True
        Me.LabelAdd1TwoPowerOf64.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAdd1TwoPowerOf64.ForeColor = System.Drawing.Color.Blue
        Me.LabelAdd1TwoPowerOf64.Location = New System.Drawing.Point(694, 17)
        Me.LabelAdd1TwoPowerOf64.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAdd1TwoPowerOf64.Name = "LabelAdd1TwoPowerOf64"
        Me.LabelAdd1TwoPowerOf64.Size = New System.Drawing.Size(37, 13)
        Me.LabelAdd1TwoPowerOf64.TabIndex = 7
        Me.LabelAdd1TwoPowerOf64.Text = "2 ^ 64"
        '
        'txtAnswerAdd
        '
        Me.txtAnswerAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAnswerAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswerAdd.Location = New System.Drawing.Point(80, 93)
        Me.txtAnswerAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAnswerAdd.Name = "txtAnswerAdd"
        Me.txtAnswerAdd.Size = New System.Drawing.Size(610, 26)
        Me.txtAnswerAdd.TabIndex = 2
        '
        'LabelLeftHdrEqualsAdd
        '
        Me.LabelLeftHdrEqualsAdd.AutoSize = True
        Me.LabelLeftHdrEqualsAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLeftHdrEqualsAdd.ForeColor = System.Drawing.Color.Blue
        Me.LabelLeftHdrEqualsAdd.Location = New System.Drawing.Point(16, 96)
        Me.LabelLeftHdrEqualsAdd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelLeftHdrEqualsAdd.Name = "LabelLeftHdrEqualsAdd"
        Me.LabelLeftHdrEqualsAdd.Size = New System.Drawing.Size(58, 20)
        Me.LabelLeftHdrEqualsAdd.TabIndex = 6
        Me.LabelLeftHdrEqualsAdd.Text = "Equals"
        '
        'txtSummand1
        '
        Me.txtSummand1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSummand1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSummand1.Location = New System.Drawing.Point(80, 14)
        Me.txtSummand1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSummand1.Name = "txtSummand1"
        Me.txtSummand1.Size = New System.Drawing.Size(610, 26)
        Me.txtSummand1.TabIndex = 0
        '
        'LabelGreySeparatorAdd
        '
        Me.LabelGreySeparatorAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelGreySeparatorAdd.BackColor = System.Drawing.Color.DimGray
        Me.LabelGreySeparatorAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGreySeparatorAdd.Location = New System.Drawing.Point(11, 75)
        Me.LabelGreySeparatorAdd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelGreySeparatorAdd.Name = "LabelGreySeparatorAdd"
        Me.LabelGreySeparatorAdd.Size = New System.Drawing.Size(697, 10)
        Me.LabelGreySeparatorAdd.TabIndex = 5
        '
        'txtSummand2
        '
        Me.txtSummand2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSummand2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSummand2.Location = New System.Drawing.Point(80, 46)
        Me.txtSummand2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSummand2.Name = "txtSummand2"
        Me.txtSummand2.Size = New System.Drawing.Size(610, 26)
        Me.txtSummand2.TabIndex = 1
        '
        'LabelLeftHdrAdd
        '
        Me.LabelLeftHdrAdd.AutoSize = True
        Me.LabelLeftHdrAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLeftHdrAdd.Location = New System.Drawing.Point(36, 52)
        Me.LabelLeftHdrAdd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelLeftHdrAdd.Name = "LabelLeftHdrAdd"
        Me.LabelLeftHdrAdd.Size = New System.Drawing.Size(38, 20)
        Me.LabelLeftHdrAdd.TabIndex = 3
        Me.LabelLeftHdrAdd.Text = "Add"
        '
        'ButtonExit
        '
        Me.ButtonExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExit.Location = New System.Drawing.Point(710, 460)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(137, 36)
        Me.ButtonExit.TabIndex = 30
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'FormAddSubtract
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 508)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelHeader2Add)
        Me.Controls.Add(Me.chkEnforceCommas)
        Me.Controls.Add(Me.LabelHeader1Minus)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelAdd)
        Me.Name = "FormAddSubtract"
        Me.Text = "FormAddSubtract"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelAdd.ResumeLayout(False)
        Me.PanelAdd.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LabelHeader2Add As Label
    Friend WithEvents chkEnforceCommas As CheckBox
    Friend WithEvents LabelHeader1Minus As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtReportedNumber As TextBox
    Friend WithEvents LabelDecimalFromSigned2sComp As Label
    Friend WithEvents LabelSub2TwoPowerOf64b As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelRightHdrEqualsMinus As Label
    Friend WithEvents LabelSub2TwoPowerOf64a As Label
    Friend WithEvents LabelSub1TwoPowerOf64 As Label
    Friend WithEvents txtAnswerMinus As TextBox
    Friend WithEvents LabelLeftHdrEqualsMinus As Label
    Friend WithEvents txtMinusTop As TextBox
    Friend WithEvents LabelGreySeparatorSub As Label
    Friend WithEvents txtMinusBottom As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PanelAdd As Panel
    Friend WithEvents LabelRightHdrEqualsAdd As Label
    Friend WithEvents LabelAdd2TwoPowerOf64 As Label
    Friend WithEvents LabelAdd1TwoPowerOf64 As Label
    Friend WithEvents txtAnswerAdd As TextBox
    Friend WithEvents LabelLeftHdrEqualsAdd As Label
    Friend WithEvents txtSummand1 As TextBox
    Friend WithEvents LabelGreySeparatorAdd As Label
    Friend WithEvents txtSummand2 As TextBox
    Friend WithEvents LabelLeftHdrAdd As Label
    Friend WithEvents ButtonExit As Button
End Class
