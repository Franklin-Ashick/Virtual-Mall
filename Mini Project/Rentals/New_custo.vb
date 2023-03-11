
Imports System.Data.SqlClient
Public Class New_custo
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


    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        textBox12.Text = ""
        textBox13.Text = ""
        textBox14.Text = ""
        textBox15.Text = ""
        textBox16.Text = ""
        textBox17.Text = ""
        textBox18.Text = ""
        textBox11.Text = ""
    End Sub

    Private Sub BunifuThinButton22_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashic\source\repos\Mini Project\Mini Project\Rentals\RentalCar.mdf;Integrated Security=True")
        con.Open()
        str = "insert into cust(f_name,l_name,mob,licence,dob,issue_date,addr) values('" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox16.Text + "','" + textBox17.Text + "','" + textBox18.Text + "')"
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        MsgBox("Customer Details Inserted Successfully..")
        textBox12.Text = ""
        textBox13.Text = ""
        textBox14.Text = ""
        textBox15.Text = ""
        textBox16.Text = ""
        textBox17.Text = ""
        textBox18.Text = ""
        textBox11.Text = ""
        con.Close()
    End Sub


End Class