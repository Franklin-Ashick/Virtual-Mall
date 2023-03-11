Public Class Maze

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("would you like to try again?", "GAME OVER", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            Homepage.Show()

        Else
        End If
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        single1.Show()
        Me.Hide()
        single1.Label1.Text = 60
        single1.Timer1.Start()
        single1.PictureBox2.Top = 79
        single1.PictureBox2.Left = 116
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        doubleplayer1.Show()
        Me.Hide()
    End Sub


End Class
