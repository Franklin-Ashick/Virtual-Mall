Imports System.Data.SqlClient
Public Class Car_home
    Dim con As SqlConnection
    Dim com As SqlCommand
    Dim dr As SqlDataReader
    Dim gen As String
    Dim str As String
    Dim getuser As String
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim dv As DataView
    Dim car As Object

    Private Sub new_cust_Click(sender As Object, e As EventArgs) Handles new_cust.Click
        New_custo.ShowDialog()
        Me.Hide()

    End Sub

    Private Sub new_car_Click(sender As Object, e As EventArgs) Handles new_car.Click
        New_carr.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub management_Click(sender As Object, e As EventArgs) Handles management.Click
        CategoryManagement.ShowDialog()
        Me.Hide()

    End Sub

    Private Sub rental_Click(sender As Object, e As EventArgs) Handles rental.Click
        Rentalcar.ShowDialog()

    End Sub

    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        Search_items.ShowDialog()

    End Sub

    Private Sub BunifuCustomLabel3_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel3.Click
        Me.Hide()
        Homepage.Show()
    End Sub
End Class