Public Class Single1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        Timer1.Interval = 1000

        If Label1.Text = 10 Then
            Label1.ForeColor = Color.Red
            Label1.Text = Val(Label1.Text) - 1
        ElseIf Label1.Text = 0 Then
            Timer1.Enabled = False

            If MessageBox.Show("would you like to try again?", "GAME OVER", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                MessageBox.Show("press OK")
                PictureBox2.Top = 79
                PictureBox2.Left = 116
                Me.Hide()
                Maze.Show()



                If Label1.Text = 10 Then
                    Label1.Text = 60
                    Timer1.Start()
                    Label1.ForeColor = Color.Red
                    Label1.Text = Val(Label1.Text) - 1
                    Label1.Text = Val(Label1.Text) - 1
                End If
            ElseIf Label1.Text = 0 Then
                Timer1.Enabled = False
                Label1.ForeColor = Color.Green
                If Timer1.Enabled = True Then
                    Timer1.Start()
                Else
                    Label1.Text = 60
                    Timer1.Start()
                End If

            Else
                MessageBox.Show("press OK")
                Me.Hide()
                Maze.Show()

            End If

        Else
            Label1.Text = Val(Label1.Text) - 1
        End If
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.A Then
            PictureBox2.Left = PictureBox2.Left - 3
        End If
        If e.KeyCode = Keys.D Then
            PictureBox2.Left = PictureBox2.Left + 3
        End If
        If e.KeyCode = Keys.S Then
            PictureBox2.Top = PictureBox2.Top + 3
        End If
        If e.KeyCode = Keys.W Then
            PictureBox2.Top = PictureBox2.Top - 3
        End If

        If PictureBox2.Bounds.IntersectsWith(Label1.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label2.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label3.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label4.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label5.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label6.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label7.Bounds) Then
            MessageBox.Show("CONGRATULATION")
            Single2.Show()
            Me.Hide()

        End If
        If PictureBox2.Bounds.IntersectsWith(Label8.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label9.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label10.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label11.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label12.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label13.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label14.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label15.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label16.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label17.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label18.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label19.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label20.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label21.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label22.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label23.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label24.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label25.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label26.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label27.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label28.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label29.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label30.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label31.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label32.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label33.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label34.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label35.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label36.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label37.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label38.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label39.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label40.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label41.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        If PictureBox2.Bounds.IntersectsWith(Label42.Bounds) Then
            MessageBox.Show("Penalty! you will back from the top")
            PictureBox2.Top = 79
            PictureBox2.Left = 116
        End If
        




    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
     




        Label1.ForeColor = Color.Green
        If Timer1.Enabled = True Then
            Timer1.Start()
        Else
            Label1.Text = 60
            Timer1.Start()
        End If


    End Sub


    Private Sub Label43_Click_1(sender As Object, e As EventArgs) Handles Label43.Click
        Maze.Show()

        Me.Hide()
        Timer1.Stop()


    End Sub
End Class