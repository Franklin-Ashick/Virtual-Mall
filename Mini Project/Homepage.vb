Public Class Homepage
    Private Sub food_Click(sender As Object, e As EventArgs) Handles food.Click
        foodpnl.Visible = True
        shopingpnl.Visible = False
        gamespnl.Visible = False
        reservationspnl.Visible = False
        rentalspnl.Visible = False
    End Sub
    Private Sub shopping_Click(sender As Object, e As EventArgs) Handles shopping.Click
        foodpnl.Visible = False
        shopingpnl.Visible = True
        gamespnl.Visible = False
        reservationspnl.Visible = False
        rentalspnl.Visible = False
    End Sub

    Private Sub banking_Click(sender As Object, e As EventArgs) Handles games.Click
        foodpnl.Visible = False
        shopingpnl.Visible = False
        gamespnl.Visible = True
        reservationspnl.Visible = False
        rentalspnl.Visible = False
    End Sub

    Private Sub reservations_Click(sender As Object, e As EventArgs) Handles reservations.Click
        foodpnl.Visible = False
        shopingpnl.Visible = False
        gamespnl.Visible = False
        reservationspnl.Visible = True
        rentalspnl.Visible = False
    End Sub

    Private Sub rentals_Click(sender As Object, e As EventArgs) Handles rentals.Click
        foodpnl.Visible = False
        shopingpnl.Visible = False
        gamespnl.Visible = False
        reservationspnl.Visible = False
        rentalspnl.Visible = True
    End Sub

    Private Sub snake_Click(sender As Object, e As EventArgs) Handles snake.Click
        frmSnake.Show()
        Me.Hide()
    End Sub

    Private Sub tictac_Click(sender As Object, e As EventArgs) Handles tictac.Click
        tic_tac.Show()
        Me.Hide()

    End Sub

    Private Sub mazee_Click(sender As Object, e As EventArgs) Handles mazee.Click
        Maze.Show()
        Me.Hide()
    End Sub

    Private Sub cars_Click(sender As Object, e As EventArgs) Handles cars.Click
        Car_home.ShowDialog()
        Me.Hide()

    End Sub

    Private Sub movie_Click(sender As Object, e As EventArgs) Handles movie.Click
        homme.Show()
        Me.Hide()

    End Sub

    Private Sub electronics_Click(sender As Object, e As EventArgs) Handles electronics.Click
        Me.Hide()
        electronics.Show()

    End Sub

    Private Sub mens_Click(sender As Object, e As EventArgs) Handles mens.Click
        Me.Hide()
        Menn.Show()

    End Sub

    Private Sub rice_Click(sender As Object, e As EventArgs) Handles rice.Click
        food.Show()
        Me.Hide()

    End Sub

    Private Sub veg_Click(sender As Object, e As EventArgs) Handles veg.Click
        food.Show()
        Me.Hide()

    End Sub

    Private Sub non_veg_Click(sender As Object, e As EventArgs) Handles non_veg.Click
        food.Show()
        Me.Hide()

    End Sub

    Private Sub deserts_Click(sender As Object, e As EventArgs) Handles deserts.Click
        food.Show()
        Me.Hide()

    End Sub

    Private Sub drinks_Click(sender As Object, e As EventArgs) Handles drinks.Click
        food.Show()
        Me.Hide()

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click

    End Sub
End Class
