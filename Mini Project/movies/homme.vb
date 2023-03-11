Public Class homme
    Private Sub homme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataDataSet9.booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(Me.DataDataSet9.booking)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Me.Close()
        Homepage.Show()

    End Sub
End Class