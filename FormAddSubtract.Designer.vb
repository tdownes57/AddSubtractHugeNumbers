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
        Me.txtSummand1 = New System.Windows.Forms.TextBox()
        Me.txtSummand2 = New System.Windows.Forms.TextBox()
        Me.txtAnswerAdd = New System.Windows.Forms.TextBox()
        Me.LabelLeftHdrAdd = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelLeftHdrEqualsAdd = New System.Windows.Forms.Label()
        Me.PanelAdd = New System.Windows.Forms.Panel()
        Me.LabelRightHdrEqualsAdd = New System.Windows.Forms.Label()
        Me.LabelAdd2TwoPowerOf64 = New System.Windows.Forms.Label()
        Me.LabelAdd1TwoPowerOf64 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelSub1TwoPowerOf64b = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelRightHdrEqualsMinus = New System.Windows.Forms.Label()
        Me.LabelSub2TwoPowerOf64 = New System.Windows.Forms.Label()
        Me.LabelSub1TwoPowerOf64 = New System.Windows.Forms.Label()
        Me.txtAnswerMinus = New System.Windows.Forms.TextBox()
        Me.LabelLeftHdrEqualsMinus = New System.Windows.Forms.Label()
        Me.txtMinusTop = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMinusBottom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelHeader1Minus = New System.Windows.Forms.Label()
        Me.chkEnforceCommas = New System.Windows.Forms.CheckBox()
        Me.LabelHeader2Add = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PanelAdd.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSummand1
        '
        Me.txtSummand1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSummand1.Location = New System.Drawing.Point(80, 14)
        Me.txtSummand1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSummand1.Name = "txtSummand1"
        Me.txtSummand1.Size = New System.Drawing.Size(530, 26)
        Me.txtSummand1.TabIndex = 0
        '
        'txtSummand2
        '
        Me.txtSummand2.Location = New System.Drawing.Point(80, 46)
        Me.txtSummand2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSummand2.Name = "txtSummand2"
        Me.txtSummand2.Size = New System.Drawing.Size(530, 20)
        Me.txtSummand2.TabIndex = 1
        '
        'txtAnswerAdd
        '
        Me.txtAnswerAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswerAdd.Location = New System.Drawing.Point(80, 93)
        Me.txtAnswerAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAnswerAdd.Name = "txtAnswerAdd"
        Me.txtAnswerAdd.Size = New System.Drawing.Size(530, 26)
        Me.txtAnswerAdd.TabIndex = 2
        '
        'LabelLeftHdrAdd
        '
        Me.LabelLeftHdrAdd.AutoSize = True
        Me.LabelLeftHdrAdd.Location = New System.Drawing.Point(50, 49)
        Me.LabelLeftHdrAdd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelLeftHdrAdd.Name = "LabelLeftHdrAdd"
        Me.LabelLeftHdrAdd.Size = New System.Drawing.Size(26, 13)
        Me.LabelLeftHdrAdd.TabIndex = 3
        Me.LabelLeftHdrAdd.Text = "Add"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 75)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(558, 8)
        Me.Label1.TabIndex = 5
        '
        'LabelLeftHdrEqualsAdd
        '
        Me.LabelLeftHdrEqualsAdd.AutoSize = True
        Me.LabelLeftHdrEqualsAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLeftHdrEqualsAdd.ForeColor = System.Drawing.Color.Blue
        Me.LabelLeftHdrEqualsAdd.Location = New System.Drawing.Point(37, 95)
        Me.LabelLeftHdrEqualsAdd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelLeftHdrEqualsAdd.Name = "LabelLeftHdrEqualsAdd"
        Me.LabelLeftHdrEqualsAdd.Size = New System.Drawing.Size(39, 13)
        Me.LabelLeftHdrEqualsAdd.TabIndex = 6
        Me.LabelLeftHdrEqualsAdd.Text = "Equals"
        '
        'PanelAdd
        '
        Me.PanelAdd.BackColor = System.Drawing.Color.Honeydew
        Me.PanelAdd.Controls.Add(Me.LabelRightHdrEqualsAdd)
        Me.PanelAdd.Controls.Add(Me.LabelAdd2TwoPowerOf64)
        Me.PanelAdd.Controls.Add(Me.LabelAdd1TwoPowerOf64)
        Me.PanelAdd.Controls.Add(Me.txtAnswerAdd)
        Me.PanelAdd.Controls.Add(Me.LabelLeftHdrEqualsAdd)
        Me.PanelAdd.Controls.Add(Me.txtSummand1)
        Me.PanelAdd.Controls.Add(Me.Label1)
        Me.PanelAdd.Controls.Add(Me.txtSummand2)
        Me.PanelAdd.Controls.Add(Me.LabelLeftHdrAdd)
        Me.PanelAdd.Location = New System.Drawing.Point(184, 255)
        Me.PanelAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelAdd.Name = "PanelAdd"
        Me.PanelAdd.Size = New System.Drawing.Size(662, 129)
        Me.PanelAdd.TabIndex = 7
        '
        'LabelRightHdrEqualsAdd
        '
        Me.LabelRightHdrEqualsAdd.AutoSize = True
        Me.LabelRightHdrEqualsAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRightHdrEqualsAdd.ForeColor = System.Drawing.Color.Blue
        Me.LabelRightHdrEqualsAdd.Location = New System.Drawing.Point(614, 96)
        Me.LabelRightHdrEqualsAdd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelRightHdrEqualsAdd.Name = "LabelRightHdrEqualsAdd"
        Me.LabelRightHdrEqualsAdd.Size = New System.Drawing.Size(39, 13)
        Me.LabelRightHdrEqualsAdd.TabIndex = 9
        Me.LabelRightHdrEqualsAdd.Text = "Equals"
        '
        'LabelAdd2TwoPowerOf64
        '
        Me.LabelAdd2TwoPowerOf64.AutoSize = True
        Me.LabelAdd2TwoPowerOf64.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAdd2TwoPowerOf64.ForeColor = System.Drawing.Color.Blue
        Me.LabelAdd2TwoPowerOf64.Location = New System.Drawing.Point(614, 49)
        Me.LabelAdd2TwoPowerOf64.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAdd2TwoPowerOf64.Name = "LabelAdd2TwoPowerOf64"
        Me.LabelAdd2TwoPowerOf64.Size = New System.Drawing.Size(37, 13)
        Me.LabelAdd2TwoPowerOf64.TabIndex = 8
        Me.LabelAdd2TwoPowerOf64.Text = "2 ^ 64"
        '
        'LabelAdd1TwoPowerOf64
        '
        Me.LabelAdd1TwoPowerOf64.AutoSize = True
        Me.LabelAdd1TwoPowerOf64.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAdd1TwoPowerOf64.ForeColor = System.Drawing.Color.Blue
        Me.LabelAdd1TwoPowerOf64.Location = New System.Drawing.Point(614, 17)
        Me.LabelAdd1TwoPowerOf64.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAdd1TwoPowerOf64.Name = "LabelAdd1TwoPowerOf64"
        Me.LabelAdd1TwoPowerOf64.Size = New System.Drawing.Size(37, 13)
        Me.LabelAdd1TwoPowerOf64.TabIndex = 7
        Me.LabelAdd1TwoPowerOf64.Text = "2 ^ 64"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MintCream
        Me.Panel1.Controls.Add(Me.LabelSub1TwoPowerOf64b)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.LabelRightHdrEqualsMinus)
        Me.Panel1.Controls.Add(Me.LabelSub2TwoPowerOf64)
        Me.Panel1.Controls.Add(Me.LabelSub1TwoPowerOf64)
        Me.Panel1.Controls.Add(Me.txtAnswerMinus)
        Me.Panel1.Controls.Add(Me.LabelLeftHdrEqualsMinus)
        Me.Panel1.Controls.Add(Me.txtMinusTop)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtMinusBottom)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(13, 78)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(833, 129)
        Me.Panel1.TabIndex = 8
        '
        'LabelSub1TwoPowerOf64b
        '
        Me.LabelSub1TwoPowerOf64b.AutoSize = True
        Me.LabelSub1TwoPowerOf64b.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSub1TwoPowerOf64b.ForeColor = System.Drawing.Color.Blue
        Me.LabelSub1TwoPowerOf64b.Location = New System.Drawing.Point(36, 17)
        Me.LabelSub1TwoPowerOf64b.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelSub1TwoPowerOf64b.Name = "LabelSub1TwoPowerOf64b"
        Me.LabelSub1TwoPowerOf64b.Size = New System.Drawing.Size(51, 20)
        Me.LabelSub1TwoPowerOf64b.TabIndex = 13
        Me.LabelSub1TwoPowerOf64b.Text = "2 ^ 64"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(660, 93)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Reported Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(614, 49)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Printed Number"
        '
        'LabelRightHdrEqualsMinus
        '
        Me.LabelRightHdrEqualsMinus.AutoSize = True
        Me.LabelRightHdrEqualsMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRightHdrEqualsMinus.ForeColor = System.Drawing.Color.Blue
        Me.LabelRightHdrEqualsMinus.Location = New System.Drawing.Point(614, 96)
        Me.LabelRightHdrEqualsMinus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelRightHdrEqualsMinus.Name = "LabelRightHdrEqualsMinus"
        Me.LabelRightHdrEqualsMinus.Size = New System.Drawing.Size(39, 13)
        Me.LabelRightHdrEqualsMinus.TabIndex = 10
        Me.LabelRightHdrEqualsMinus.Text = "Equals"
        '
        'LabelSub2TwoPowerOf64
        '
        Me.LabelSub2TwoPowerOf64.AutoSize = True
        Me.LabelSub2TwoPowerOf64.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSub2TwoPowerOf64.ForeColor = System.Drawing.Color.Blue
        Me.LabelSub2TwoPowerOf64.Location = New System.Drawing.Point(759, 54)
        Me.LabelSub2TwoPowerOf64.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelSub2TwoPowerOf64.Name = "LabelSub2TwoPowerOf64"
        Me.LabelSub2TwoPowerOf64.Size = New System.Drawing.Size(37, 13)
        Me.LabelSub2TwoPowerOf64.TabIndex = 9
        Me.LabelSub2TwoPowerOf64.Text = "2 ^ 64"
        '
        'LabelSub1TwoPowerOf64
        '
        Me.LabelSub1TwoPowerOf64.AutoSize = True
        Me.LabelSub1TwoPowerOf64.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSub1TwoPowerOf64.ForeColor = System.Drawing.Color.Blue
        Me.LabelSub1TwoPowerOf64.Location = New System.Drawing.Point(614, 17)
        Me.LabelSub1TwoPowerOf64.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelSub1TwoPowerOf64.Name = "LabelSub1TwoPowerOf64"
        Me.LabelSub1TwoPowerOf64.Size = New System.Drawing.Size(51, 20)
        Me.LabelSub1TwoPowerOf64.TabIndex = 8
        Me.LabelSub1TwoPowerOf64.Text = "2 ^ 64"
        '
        'txtAnswerMinus
        '
        Me.txtAnswerMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswerMinus.Location = New System.Drawing.Point(103, 93)
        Me.txtAnswerMinus.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAnswerMinus.Name = "txtAnswerMinus"
        Me.txtAnswerMinus.Size = New System.Drawing.Size(507, 26)
        Me.txtAnswerMinus.TabIndex = 2
        '
        'LabelLeftHdrEqualsMinus
        '
        Me.LabelLeftHdrEqualsMinus.AutoSize = True
        Me.LabelLeftHdrEqualsMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLeftHdrEqualsMinus.ForeColor = System.Drawing.Color.Blue
        Me.LabelLeftHdrEqualsMinus.Location = New System.Drawing.Point(37, 95)
        Me.LabelLeftHdrEqualsMinus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelLeftHdrEqualsMinus.Name = "LabelLeftHdrEqualsMinus"
        Me.LabelLeftHdrEqualsMinus.Size = New System.Drawing.Size(58, 20)
        Me.LabelLeftHdrEqualsMinus.TabIndex = 6
        Me.LabelLeftHdrEqualsMinus.Text = "Equals"
        '
        'txtMinusTop
        '
        Me.txtMinusTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinusTop.Location = New System.Drawing.Point(103, 14)
        Me.txtMinusTop.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMinusTop.Name = "txtMinusTop"
        Me.txtMinusTop.Size = New System.Drawing.Size(507, 26)
        Me.txtMinusTop.TabIndex = 0
        Me.txtMinusTop.Text = "18,446,744,073,709,551,616"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DimGray
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 75)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(558, 8)
        Me.Label3.TabIndex = 5
        '
        'txtMinusBottom
        '
        Me.txtMinusBottom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinusBottom.Location = New System.Drawing.Point(103, 46)
        Me.txtMinusBottom.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMinusBottom.Name = "txtMinusBottom"
        Me.txtMinusBottom.Size = New System.Drawing.Size(507, 26)
        Me.txtMinusBottom.TabIndex = 1
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 42)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(288, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Reported Number = 2 ^ 64 - Printed Number"
        '
        'LabelHeader1Minus
        '
        Me.LabelHeader1Minus.AutoSize = True
        Me.LabelHeader1Minus.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHeader1Minus.Location = New System.Drawing.Point(9, 17)
        Me.LabelHeader1Minus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelHeader1Minus.Name = "LabelHeader1Minus"
        Me.LabelHeader1Minus.Size = New System.Drawing.Size(250, 22)
        Me.LabelHeader1Minus.TabIndex = 10
        Me.LabelHeader1Minus.Text = "Subtract Decimals of Any Size"
        '
        'chkEnforceCommas
        '
        Me.chkEnforceCommas.AutoSize = True
        Me.chkEnforceCommas.Checked = True
        Me.chkEnforceCommas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEnforceCommas.Location = New System.Drawing.Point(423, 56)
        Me.chkEnforceCommas.Name = "chkEnforceCommas"
        Me.chkEnforceCommas.Size = New System.Drawing.Size(224, 17)
        Me.chkEnforceCommas.TabIndex = 11
        Me.chkEnforceCommas.Text = "Enforce commas to separate digital triplets"
        Me.chkEnforceCommas.UseVisualStyleBackColor = True
        '
        'LabelHeader2Add
        '
        Me.LabelHeader2Add.AutoSize = True
        Me.LabelHeader2Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHeader2Add.Location = New System.Drawing.Point(180, 220)
        Me.LabelHeader2Add.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelHeader2Add.Name = "LabelHeader2Add"
        Me.LabelHeader2Add.Size = New System.Drawing.Size(215, 22)
        Me.LabelHeader2Add.TabIndex = 12
        Me.LabelHeader2Add.Text = "Add Decimals of Any Size"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Yellow
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(362, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(473, 24)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Why isn't the Reported Number appearing as negative?"
        '
        'FormAddSubtract
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 398)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LabelHeader2Add)
        Me.Controls.Add(Me.chkEnforceCommas)
        Me.Controls.Add(Me.LabelHeader1Minus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelAdd)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormAddSubtract"
        Me.Text = "  Add or Subtract Decimals of Any Size"
        Me.PanelAdd.ResumeLayout(False)
        Me.PanelAdd.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSummand1 As TextBox
    Friend WithEvents txtSummand2 As TextBox
    Friend WithEvents txtAnswerAdd As TextBox
    Friend WithEvents LabelLeftHdrAdd As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelLeftHdrEqualsAdd As Label
    Friend WithEvents PanelAdd As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtAnswerMinus As TextBox
    Friend WithEvents LabelLeftHdrEqualsMinus As Label
    Friend WithEvents txtMinusTop As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMinusBottom As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelHeader1Minus As Label
    Friend WithEvents LabelAdd1TwoPowerOf64 As Label
    Friend WithEvents LabelSub1TwoPowerOf64 As Label
    Friend WithEvents LabelAdd2TwoPowerOf64 As Label
    Friend WithEvents LabelSub2TwoPowerOf64 As Label
    Friend WithEvents chkEnforceCommas As CheckBox
    Friend WithEvents LabelRightHdrEqualsAdd As Label
    Friend WithEvents LabelRightHdrEqualsMinus As Label
    Friend WithEvents LabelHeader2Add As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelSub1TwoPowerOf64b As Label
    Friend WithEvents Label7 As Label
End Class
