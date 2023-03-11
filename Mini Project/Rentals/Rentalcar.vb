Imports System.Data.SqlClient
Public Class Rentalcar

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

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashic\source\repos\Mini Project\Mini Project\Rentals\RentalCar.mdf;Integrated Security=True")
        con.Open()
        str = "insert into rental(car,c_name,from_date,return_date,total) values('" + textbox1.Text + "','" + textbox2.Text + "','" + textbox3.Text + "','" + textbox4.Text + "','" + textbox5.Text + "')"
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        MsgBox("Rental Car Details Inserted Successfully..")
        textbox2.Text = ""
        textbox3.Text = ""
        textbox4.Text = ""
        textbox5.Text = ""
        textbox1.Text = ""
        con.Close()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        textbox2.Text = ""
        textbox3.Text = ""
        textbox4.Text = ""
        textbox5.Text = ""
        textbox1.Text = ""
    End Sub

    Private Sub BunifuCustomLabel3_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel3.Click
        Me.Hide()
        Car_home.Show()
    End Sub
End Class