Public Class feedback_form
    Private Sub purchase_btn_Click(sender As Object, e As EventArgs) Handles purchase_btn.Click
        MsgBox("Feedback Taken")
        Application.Exit()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub feedback_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class