Imports System.Data.SqlClient
Public Class Search_items
    Private Sub Search_items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ser_car.BackColor = Color.FromArgb(25, Color.Black)
        ser_rental.BackColor = Color.FromArgb(25, Color.Black)
        ser_cust.BackColor = Color.FromArgb(25, Color.Black)
        Panel2.BackColor = Color.FromArgb(25, Color.Black)
        Panel3.BackColor = Color.FromArgb(25, Color.Black)
        Panel4.BackColor = Color.FromArgb(25, Color.Black)
        'TODO: This line of code loads data into the 'RentalCarDataSet1.car' table. You can move, or remove it, as needed.
        Me.CarTableAdapter.Fill(Me.RentalCarDataSet1.car)
        'TODO: This line of code loads data into the 'RentalCarDataSet2.cust' table. You can move, or remove it, as needed.
        Me.CustTableAdapter.Fill(Me.RentalCarDataSet2.cust)
        'TODO: This line of code loads data into the 'RentalCarDataSet3.rental' table. You can move, or remove it, as needed.
        Me.RentalTableAdapter.Fill(Me.RentalCarDataSet3.rental)
        Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashic\Downloads\CarRentalServiceSystemVB\CarRentalServiceSystemVB\RentalCar.mdf;Integrated Security=True")
            str = "select * from rental"
            com = New SqlCommand(str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            dataGridView1.DataSource = New BindingSource(dt, car)
        End Using
    End Sub




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
        Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashic\Downloads\CarRentalServiceSystemVB\CarRentalServiceSystemVB\RentalCar.mdf;Integrated Security=True")
            str = "select * from rental where car='" + textBox1.Text + "'"
            com = New SqlCommand(str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            dataGridView1.DataSource = New BindingSource(dt, car)
        End Using
    End Sub

    Private Sub search_rental_Click(sender As Object, e As EventArgs) Handles search_rental.Click
        ser_rental.Visible = True
        ser_cust.Visible = False
        ser_car.Visible = False
    End Sub

    Private Sub search_cust_Click(sender As Object, e As EventArgs) Handles search_cust.Click
        ser_rental.Visible = False
        ser_cust.Visible = True
        ser_car.Visible = False
    End Sub

    Private Sub search_car_Click(sender As Object, e As EventArgs) Handles search_car.Click
        ser_rental.Visible = False
        ser_cust.Visible = False
        ser_car.Visible = True
    End Sub

    Private Sub BunifuCustomLabel3_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel3.Click
        Me.Hide()
        Car_home.Show()
    End Sub
End Class