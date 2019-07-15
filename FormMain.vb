Option Explicit On
Option Strict On
''
''Added 7/16/2019 thomas downes   
''

Public Class FormMain
    Private Sub ButtonProofOfConcept_Click(sender As Object, e As EventArgs) Handles ButtonProofOfConcept.Click
        ''
        ''Added 7/16/2019 thomas downes   
        ''
        Dim frm_toShow As New FormProofOfConcept ''Added 7/16/2019 thomas downes 
        frm_toShow.Show()

    End Sub

    Private Sub ButtonGenerateBatch_Click(sender As Object, e As EventArgs) Handles ButtonGenerateBatch.Click
        ''
        ''Added 7/16/2019 thomas downes   
        ''
        Dim frm_toShow As New FormGenerateBatch ''Added 7/16/2019 thomas downes 
        frm_toShow.Show()

    End Sub

    Private Sub ButtonAddSubtract_Click(sender As Object, e As EventArgs) Handles ButtonAddSubtract.Click
        ''
        ''Added 7/16/2019 thomas downes   
        ''
        Dim frm_toShow As New FormAddSubtract ''Added 7/16/2019 thomas downes 
        frm_toShow.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonMSExcel.Click
        ''
        ''Added 7/16/2019 thomas downes   
        ''
        Dim frm_toShow As New FormTipsForExcel ''Added 7/16/2019 thomas downes 
        frm_toShow.Show()

    End Sub
End Class