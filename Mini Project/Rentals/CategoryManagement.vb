Imports System.Data.SqlClient

Public Class CategoryManagement
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
        str = "insert into categ(name,descr) values('" + textBox2.Text + "','" + textBox3.Text + "')"
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        MsgBox("Category Details Inserted Successfully..")
        textBox2.Text = ""
        textBox3.Text = ""
        textBox1.Text = ""
        Hide()
        con.Close()
    End Sub

    Private Sub CategoryManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashic\source\repos\Mini Project\Mini Project\Rentals\RentalCar.mdf;Integrated Security=True")
        con.Open()
        Try
            str = "select nextID=MAX(Id)+1 from categ"
            com = New SqlCommand(str, con)
            dr = com.ExecuteReader()
            If dr.Read() Then
                textBox1.Text = dr.GetValue(0).ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        textBox2.Text = ""
        textBox3.Text = ""
        textBox1.Text = ""
    End Sub

    Private Sub BunifuCustomLabel3_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel3.Click
        Me.Hide()
        Car_home.Show()
    End Sub
End Class