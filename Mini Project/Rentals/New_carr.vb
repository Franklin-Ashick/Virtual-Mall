Imports System.Data.SqlClient

Public Class New_carr

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
    Private Sub New_carr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RentalCarDataSet.car' table. You can move, or remove it, as needed.
        Me.CarTableAdapter.Fill(Me.RentalCarDataSet.car)

    End Sub
    'add
    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashic\source\repos\Mini Project\Mini Project\Rentals\RentalCar.mdf;Integrated Security=True")
        con.Open()
        Str = "insert into car(car_name,car_no,category,brand_name,colour,mfg_date,milage,insurance_no) values('" + textBox111.Text + "','" + textBox112.Text + "','" + textBox113.Text + "','" + textBox114.Text + "','" + textBox115.Text + "','" + textBox116.Text + "','" + textBox117.Text + "','" + textBox118.Text + "')"
        com = New SqlCommand(Str, con)
        com.ExecuteNonQuery()
        MsgBox("Car Details Inserted Successfully..")
        Using con
            Str = "select * from car"
            com = New SqlCommand(Str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            dataGridView1.DataSource = New BindingSource(dt, car)
        End Using
        textBox112.Text = ""
        textBox113.Text = ""
        textBox114.Text = ""
        textBox115.Text = ""
        textBox116.Text = ""
        textBox117.Text = ""
        textBox118.Text = ""
        textBox111.Text = ""
        con.Close()
    End Sub
    'search
    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashic\source\repos\Mini Project\Mini Project\Rentals\RentalCar.mdf;Integrated Security=True")
        con.Open()
        Try
            Str = "Select car_name,car_no,category,brand_name,colour,mfg_date,milage,insurance_no from car where id='" + textBox111.Text + "'"
            com = New SqlCommand(Str, con)
            dr = com.ExecuteReader()
            If dr.Read() Then
                textBox111.Text = dr.GetValue(0).ToString()
                textBox112.Text = dr.GetValue(1).ToString()
                textBox113.Text = dr.GetValue(2).ToString()
                textBox114.Text = dr.GetValue(3).ToString()
                textBox115.Text = dr.GetValue(4).ToString()
                textBox116.Text = dr.GetValue(5).ToString()
                textBox117.Text = dr.GetValue(6).ToString()
                textBox118.Text = dr.GetValue(7).ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'update
    Private Sub BunifuThinButton26_Click(sender As Object, e As EventArgs) Handles BunifuThinButton26.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashic\source\repos\Mini Project\Mini Project\Rentals\RentalCar.mdf;Integrated Security=True")
        con.Open()
        Str = "update car set car_name='" + textBox111.Text + "',car_no='" + textBox112.Text + "',category='" + textBox113.Text + "',brand_name='" + textBox114.Text + "',colour='" + textBox115.Text + "',mfg_date='" + textBox116.Text + "',milage='" + textBox117.Text + "',insurance_no='" + textBox118.Text + "' where id='" + textBox111.Text + "'"
        com = New SqlCommand(Str, con)
        com.ExecuteNonQuery()
        MsgBox("Car Data Updated Successfully..")
        Using con
            Str = "select * from car"
            com = New SqlCommand(Str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            dataGridView1.DataSource = New BindingSource(dt, car)
        End Using
        textBox117.Text = ""
        textBox118.Text = ""
        textBox111.Text = ""
        textBox112.Text = ""
        textBox113.Text = ""
        textBox114.Text = ""
        textBox115.Text = ""
        textBox116.Text = ""
        con.Close()
    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        textBox117.Text = ""
        textBox118.Text = ""
        textBox111.Text = ""
        textBox112.Text = ""
        textBox113.Text = ""
        textBox114.Text = ""
        textBox115.Text = ""
        textBox116.Text = ""
    End Sub

    Private Sub BunifuCustomLabel3_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel3.Click
        Me.Hide()
        Car_home.Show()
    End Sub
End Class