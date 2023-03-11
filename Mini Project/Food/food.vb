
Imports System.Data.SqlClient
Imports System.Data
Public Class food
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim cmn As New SqlCommand
    Dim dr As SqlDataReader
    Dim objcon As SqlConnection = Nothing
    Dim da As New SqlDataAdapter
    Dim com As SqlCommand
    Dim ds As New DataSet
    Dim dt As DataTable
    Dim dv As DataView
    Dim str As String
    Dim stu As String
    Private Sub food_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox2.Items.Clear()
        ComboBox2.Items.Add("Rice")
        ComboBox2.Items.Add("Veg")
        ComboBox2.Items.Add("Non_Veg")
        ComboBox2.Items.Add("Deserts")
        ComboBox2.Items.Add("Drinks")
    End Sub


    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedItem = "Rice" Then
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("Mutton Biryani")
            ComboBox1.Items.Add("Bisi Bele Bhaat")
            ComboBox1.Items.Add("Pulao")
            ComboBox1.Items.Add("Curd Rice")
            Label1.Text = "Rice"
        End If
        If ComboBox2.SelectedItem = "Veg" Then
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("Roti with chana dhal")
            ComboBox1.Items.Add("Idli Sambar")
            ComboBox1.Items.Add("Pav Bhaji")
            ComboBox1.Items.Add("Kadai Mushroom")
            Label1.Text = "Veg"
        End If
        If ComboBox2.SelectedItem = "Non_Veg" Then
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("Grilled Chicken")
            ComboBox1.Items.Add("Tandoori Lamb Chops")
            ComboBox1.Items.Add("Malabar Fish Biryani")
            ComboBox1.Items.Add("Chicken 65")
            Label1.Text = "Non_Veg"
        End If
        If ComboBox2.SelectedItem = "Deserts" Then
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("Gulab Jamun")
            ComboBox1.Items.Add("Rasmalai")
            ComboBox1.Items.Add("Jalebi")
            ComboBox1.Items.Add("Kheer")
            Label1.Text = "Deserts"
        End If
        If ComboBox2.SelectedItem = "Drinks" Then
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("Milkshake")
            ComboBox1.Items.Add("Hot chocolate")
            ComboBox1.Items.Add("Iced tea")
            ComboBox1.Items.Add("Lemonade")
            Label1.Text = "Drinks"
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Mutton Biryani" Then
            Label3.Text = "No Of Serves"
            ListBox1.Items.Clear()
            ListBox1.Items.Add("One")
            ListBox1.Items.Add("Two")
            ListBox1.Items.Add("Family Pack")
        End If
        If ComboBox1.SelectedItem = "Bisi Bele Bhaat" Then
            Label3.Text = "No Of Serves"
            ListBox1.Items.Clear()
            ListBox1.Items.Add("One")
            ListBox1.Items.Add("Two")
            ListBox1.Items.Add("Family Pack")
        End If
        If ComboBox1.SelectedItem = "Pulao" Then
            Label3.Text = "No Of Serves"
            ListBox1.Items.Clear()
            ListBox1.Items.Add("One")
            ListBox1.Items.Add("Two")
            ListBox1.Items.Add("Family Pack")
        End If
        If ComboBox1.SelectedItem = "Curd Rice" Then
            Label3.Text = "No Of Serves"
            ListBox1.Items.Clear()
            ListBox1.Items.Add("One")
            ListBox1.Items.Add("Two")
            ListBox1.Items.Add("Family Pack")
        End If
        If ComboBox1.SelectedItem = "Roti with chana dhal" Then
            Label3.Text = "No Of Serves"
            ListBox1.Items.Clear()
            ListBox1.Items.Add("1")
            ListBox1.Items.Add("2")
            ListBox1.Items.Add("4")
        End If
        If ComboBox1.SelectedItem = "Idli Sambar" Then
            Label3.Text = "No Of Serves"
            ListBox1.Items.Clear()
            ListBox1.Items.Add("1")
            ListBox1.Items.Add("2")
            ListBox1.Items.Add("4")
        End If
        If ComboBox1.SelectedItem = "Pav Bhaji" Then
            Label3.Text = "No Of Serves"
            ListBox1.Items.Clear()
            ListBox1.Items.Add("1")
            ListBox1.Items.Add("2")
            ListBox1.Items.Add("4")
        End If
        If ComboBox1.SelectedItem = "Kadai Mushroom" Then
            Label3.Text = "No Of Serves"
            ListBox1.Items.Clear()
            ListBox1.Items.Add("1")
            ListBox1.Items.Add("2")
            ListBox1.Items.Add("4")
        End If


        If ComboBox1.SelectedItem = "Grilled Chicken" Then
            Label3.Text = "Quantity"
            ListBox1.Items.Clear()
            ListBox1.Items.Add("Full")
            ListBox1.Items.Add("Half")
        End If
        If ComboBox1.SelectedItem = "Tandoori Lamb Chops" Then
            Label3.Text = "Quantity"
            ListBox1.Items.Clear()
            ListBox1.Items.Add("Full")
            ListBox1.Items.Add("Half")
        End If
        If ComboBox1.SelectedItem = "Malabar Fish Biryani" Then
            Label3.Text = "No Of Serves"
            ListBox1.Items.Clear()
            ListBox1.Items.Add("1")
            ListBox1.Items.Add("2")
            ListBox1.Items.Add("4")
        End If
        If ComboBox1.SelectedItem = "Chicken 65" Then
            Label3.Text = "Quantity"
            ListBox1.Items.Clear()
            ListBox1.Items.Add("Full")
            ListBox1.Items.Add("Half")
        End If
        If ComboBox1.SelectedItem = "Gulab Jamun" Then
            Label3.Text = "Quantity"
            ListBox1.Items.Clear()
            ListBox1.Items.Add("5")
            ListBox1.Items.Add("6")
            ListBox1.Items.Add("10")
        End If
        If ComboBox1.SelectedItem = "Rasmalai" Then
            Label3.Text = "Quantity"
            ListBox1.Items.Clear()
            ListBox1.Items.Add("5")
            ListBox1.Items.Add("6")
            ListBox1.Items.Add("10")
        End If
        If ComboBox1.SelectedItem = "Jalebi" Then
            Label3.Text = "Quantity"
            ListBox1.Items.Clear()
            ListBox1.Items.Add("5")
            ListBox1.Items.Add("6")
            ListBox1.Items.Add("10")
        End If
        If ComboBox1.SelectedItem = "Kheer" Then
            Label3.Text = "Quantity"
            ListBox1.Items.Clear()
            ListBox1.Items.Add("5")
            ListBox1.Items.Add("6")
            ListBox1.Items.Add("10")
        End If
        If ComboBox1.SelectedItem = "Milkshake" Then
            Label3.Text = "Milkshake"
            ListBox1.Items.Clear()
            ListBox1.Items.Add("1")
            ListBox1.Items.Add("2")
        End If
        If ComboBox1.SelectedItem = "Hot chocolate" Then
            Label3.Text = "Hot chocolate"
            ListBox1.Items.Clear()
            ListBox1.Items.Add("1")
            ListBox1.Items.Add("2")
        End If
        If ComboBox1.SelectedItem = "Iced tea" Then
            Label3.Text = "Iced tea"
            ListBox1.Items.Clear()
            ListBox1.Items.Add("1")
            ListBox1.Items.Add("2")
        End If
        If ComboBox1.SelectedItem = "Lemonade" Then
            Label3.Text = "Lemonade"
            ListBox1.Items.Clear()
            ListBox1.Items.Add("1")
            ListBox1.Items.Add("2")
        End If
        product.Text = ComboBox1.SelectedItem
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        If ListBox1.SelectedItem = ("One") Then
            totalprice.Text = "224"
        End If
        If ListBox1.SelectedItem = ("Two") Then
            totalprice.Text = "400"
        End If
        If ListBox1.SelectedItem = ("Family Pack") Then
            totalprice.Text = "654"
        End If
        If ListBox1.SelectedItem = ("1") Then
            totalprice.Text = "654"
        End If
        If ListBox1.SelectedItem = ("2") Then
            totalprice.Text = "546"
        End If
        If ListBox1.SelectedItem = ("4") Then
            totalprice.Text = "54"
        End If
        If ListBox1.SelectedItem = ("5") Then
            totalprice.Text = "345"
        End If
        If ListBox1.SelectedItem = ("6") Then
            totalprice.Text = "776"
        End If
        If ListBox1.SelectedItem = ("10") Then
            totalprice.Text = "300"
        End If
        If ListBox1.SelectedItem = ("Full") Then
            totalprice.Text = "150"
        End If
        If ListBox1.SelectedItem = ("Half") Then
            totalprice.Text = "300"
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashic\source\repos\Mini Project\Mini Project\Data.mdf;Integrated Security=True")
        con.Open()
        str = "insert into sales(Name,PhNumber,Product,Quantity,Total_Price) values('" + fname.Text + "','" + phnumber.Text + "','" + product.Text + "',1,'" + totalprice.Text + "')"
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        con.Close()
        con.Open()
        str = "insert into cart(product,quantity,price,amt) values('" + product.Text + "',1,'" + totalprice.Text + "','" + totalprice.Text + "')"
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        MsgBox("Items Added To Cart Successfully..")
        con.Close()

        con.Open()
        stu = "insert into customer(c_name,c_mail,address ,c_phno) values('" + fname.Text + "','" + email.Text + "','" + address.Text + "','" + phnumber.Text + "')"
        cmd = New SqlCommand(stu, con)
        cmd.ExecuteNonQuery()
        Me.Hide()
        Homepage.Show()
        con.Close()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Hide()
        Homepage.Show()
    End Sub
End Class