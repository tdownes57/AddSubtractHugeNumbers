<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ButtonGenerateBatch = New System.Windows.Forms.Button()
        Me.LabelHeader1Minus = New System.Windows.Forms.Label()
        Me.ButtonAddSubtract = New System.Windows.Forms.Button()
        Me.ButtonProofOfConcept = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonMSExcel = New System.Windows.Forms.Button()
        Me.imgCIS = New System.Windows.Forms.PictureBox()
        CType(Me.imgCIS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonGenerateBatch
        '
        Me.ButtonGenerateBatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGenerateBatch.Location = New System.Drawing.Point(21, 326)
        Me.ButtonGenerateBatch.Name = "ButtonGenerateBatch"
        Me.ButtonGenerateBatch.Size = New System.Drawing.Size(229, 66)
        Me.ButtonGenerateBatch.TabIndex = 0
        Me.ButtonGenerateBatch.Text = "Batch Generation of Reported Numbers"
        Me.ButtonGenerateBatch.UseVisualStyleBackColor = True
        '
        'LabelHeader1Minus
        '
        Me.LabelHeader1Minus.AutoSize = True
        Me.LabelHeader1Minus.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHeader1Minus.Location = New System.Drawing.Point(16, 236)
        Me.LabelHeader1Minus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelHeader1Minus.Name = "LabelHeader1Minus"
        Me.LabelHeader1Minus.Size = New System.Drawing.Size(292, 26)
        Me.LabelHeader1Minus.TabIndex = 11
        Me.LabelHeader1Minus.Text = "Generate Reported Numbers"
        '
        'ButtonAddSubtract
        '
        Me.ButtonAddSubtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddSubtract.Location = New System.Drawing.Point(286, 326)
        Me.ButtonAddSubtract.Name = "ButtonAddSubtract"
        Me.ButtonAddSubtract.Size = New System.Drawing.Size(229, 66)
        Me.ButtonAddSubtract.TabIndex = 18
        Me.ButtonAddSubtract.Text = "Add or Subtract 20-Digit Numbers (or of similar size)"
        Me.ButtonAddSubtract.UseVisualStyleBackColor = True
        '
        'ButtonProofOfConcept
        '
        Me.ButtonProofOfConcept.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonProofOfConcept.Location = New System.Drawing.Point(286, 410)
        Me.ButtonProofOfConcept.Name = "ButtonProofOfConcept"
        Me.ButtonProofOfConcept.Size = New System.Drawing.Size(229, 66)
        Me.ButtonProofOfConcept.TabIndex = 19
        Me.ButtonProofOfConcept.Text = "Programmer's Proof of Concept / Hybrid Utility"
        Me.ButtonProofOfConcept.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 273)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(388, 26)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Add or Subtract 20-digit Card Numbers"
        '
        'ButtonMSExcel
        '
        Me.ButtonMSExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMSExcel.Location = New System.Drawing.Point(21, 410)
        Me.ButtonMSExcel.Name = "ButtonMSExcel"
        Me.ButtonMSExcel.Size = New System.Drawing.Size(229, 66)
        Me.ButtonMSExcel.TabIndex = 21
        Me.ButtonMSExcel.Text = "How do I work w/ MS Excel?"
        Me.ButtonMSExcel.UseVisualStyleBackColor = True
        '
        'imgCIS
        '
        Me.imgCIS.Image = Global.AddSubtractDecimals.My.Resources.Resources.CI_Logo
        Me.imgCIS.Location = New System.Drawing.Point(12, 12)
        Me.imgCIS.Name = "imgCIS"
        Me.imgCIS.Size = New System.Drawing.Size(548, 203)
        Me.imgCIS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgCIS.TabIndex = 17
        Me.imgCIS.TabStop = False
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(588, 488)
        Me.Controls.Add(Me.ButtonMSExcel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonProofOfConcept)
        Me.Controls.Add(Me.ButtonAddSubtract)
        Me.Controls.Add(Me.imgCIS)
        Me.Controls.Add(Me.LabelHeader1Minus)
        Me.Controls.Add(Me.ButtonGenerateBatch)
        Me.Name = "FormMain"
        Me.Text = "Generate Reported Numbers / Add or Subtract 20-digit card values"
        CType(Me.imgCIS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonGenerateBatch As Button
    Friend WithEvents LabelHeader1Minus As Label
    Friend WithEvents imgCIS As PictureBox
    Friend WithEvents ButtonAddSubtract As Button
    Friend WithEvents ButtonProofOfConcept As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonMSExcel As Button
End Class
