Imports System.Data.SqlClient
Imports System.Data
Public Class Menn
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


    Private Sub mens_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox2.Items.Clear()
        ComboBox2.Items.Add("T-Shirts & Polos")
        ComboBox2.Items.Add("Shirts")
        ComboBox2.Items.Add("Jeans")
        ComboBox2.Items.Add("Innerwear")
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedItem = "T-Shirts & Polos" Then
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("Allen Solly Mens Polo")
            ComboBox1.Items.Add("U.S. POLO ASSN. Mens Solid")
            ComboBox1.Items.Add("Levis Mens Round Neck Printed T-Shirt")
        End If
        If ComboBox2.SelectedItem = "Shirts" Then
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("Diverse Mens Regular Formal Shirt")
            ComboBox1.Items.Add("Dennis Lingo Mens Mandarin Collar Casual Shirt")
            ComboBox1.Items.Add("Allen Solly Mens Plain Slim Fit Casual Shirt")
        End If
        If ComboBox2.SelectedItem = "Jeans" Then
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("Denim Shorts")
            ComboBox1.Items.Add("Denim Jackets")
            ComboBox1.Items.Add("Denim Shirts")
        End If
        If ComboBox2.SelectedItem = "Innerwear" Then
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("Men Vest")
            ComboBox1.Items.Add("Mens Antibacterial Cotton Boxer Brief")
            ComboBox1.Items.Add("Mens Square Cut Brief 8037-0110-ASSTD Black M")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Allen Solly Mens Polo" Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("32")
            ListBox1.Items.Add("30")
            ListBox1.Items.Add("28")
        End If
        If ComboBox1.SelectedItem = "U.S. POLO ASSN. Mens Solid" Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("32")
            ListBox1.Items.Add("30")
            ListBox1.Items.Add("28")
        End If
        If ComboBox1.SelectedItem = "Levis Mens Round Neck Printed T-Shirt" Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("32")
            ListBox1.Items.Add("30")
            ListBox1.Items.Add("28")
        End If
        If ComboBox1.SelectedItem = "Diverse Mens Regular Formal Shirt" Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("Small")
            ListBox1.Items.Add("Medium")
            ListBox1.Items.Add("Large")
        End If
        If ComboBox1.SelectedItem = "Dennis Lingo Mens Mandarin Collar Casual Shirt" Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("Small")
            ListBox1.Items.Add("Medium")
            ListBox1.Items.Add("Large")
        End If
        If ComboBox1.SelectedItem = "Allen Solly Mens Plain Slim Fit Casual Shirt" Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("Small")
            ListBox1.Items.Add("Medium")
            ListBox1.Items.Add("Large")
        End If
        If ComboBox1.SelectedItem = "Denim Shorts" Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("32")
            ListBox1.Items.Add("30")
            ListBox1.Items.Add("28")
        End If
        If ComboBox1.SelectedItem = "Denim Jackets" Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("Small")
            ListBox1.Items.Add("Medium")
            ListBox1.Items.Add("Large")
        End If
        If ComboBox1.SelectedItem = "Denim Shirts" Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("Small")
            ListBox1.Items.Add("Medium")
            ListBox1.Items.Add("Large")
        End If
        product.Text = ComboBox1.SelectedItem
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListBox1.SelectedItem = ("32") Then
            totalprice.Text = "1500"
        End If
        If ListBox1.SelectedItem = ("30") Then
            totalprice.Text = "1400"
        End If
        If ListBox1.SelectedItem = ("28") Then
            totalprice.Text = "1999"
        End If
        If ListBox1.SelectedItem = ("Small") Then
            totalprice.Text = "3550"
        End If
        If ListBox1.SelectedItem = ("Medium") Then
            totalprice.Text = "1880"
        End If
        If ListBox1.SelectedItem = ("Large") Then
            totalprice.Text = "1999"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashic\source\repos\Mini Project\Mini Project\Data.mdf;Integrated Security=True")

        con.Open()
        str = " insert into sales(Name,PhNumber,Product,Quantity,Total_Price) values('" + fname.Text + "','" + phnumber.Text + "','" + product.Text + "',1,'" + totalprice.Text + "')"
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