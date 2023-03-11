Public Class Splash
    Private Sub Splashh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub


    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        BunifuSeparator1.Width += 10
        If BunifuSeparator1.Width >= 567 Then
            Timer1.Stop()
            Me.Hide()
            Login.Show()
        End If
    End Sub
End Class