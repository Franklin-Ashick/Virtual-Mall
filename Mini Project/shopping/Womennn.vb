Imports System.Data.SqlClient
Imports System.Data
Public Class Womennn
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim com As SqlCommand
    Dim str As String
    Dim stu As String
    Private Sub mens_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.Transparent

        ComboBox2.Items.Clear()
        ComboBox2.Items.Add("Kurthis")
        ComboBox2.Items.Add("Ethnic Wear")
        ComboBox2.Items.Add("Western Wear")
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedItem = "Kurthis" Then
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("NAINVISH Women Maroon Straight Cotton Kurti Pant Set with Dupatta")
            ComboBox1.Items.Add("Ada Hand Embroidered Lucknow Chikan Pure Cotton Kurti Kurta")
            ComboBox1.Items.Add("DMP FASHION Women's Rayon Embroidery Work Flared Kurta")
        End If
        If ComboBox2.SelectedItem = "Ethnic Wear" Then
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("Women Art Silk Sarees SDPL-SDPL-RAJRANI")
            ComboBox1.Items.Add("Women's Loose Fit Patiala Pants")
            ComboBox1.Items.Add("Rayon Gold Print Skirt Palazzo")
        End If
        If ComboBox2.SelectedItem = "Western Wear" Then
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("Ribbed Polo Collared Spaghetti Full Length Tops")
            ComboBox1.Items.Add("Women Mock Neck Ruffle Cuff Floral Top")
            ComboBox1.Items.Add("Ribbed Square Neck Spaghetti Corset Tops")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "NAINVISH Women Maroon Straight Cotton Kurti Pant Set with Dupatta" Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("M")
            ListBox1.Items.Add("L")
            ListBox1.Items.Add("XL")
            ListBox1.Items.Add("FREE SIZE")
        End If
        If ComboBox1.SelectedItem = "Ada Hand Embroidered Lucknow Chikan Pure Cotton Kurti Kurta" Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("M")
            ListBox1.Items.Add("L")
            ListBox1.Items.Add("XL")
            ListBox1.Items.Add("FREE SIZE")
        End If
        If ComboBox1.SelectedItem = "DMP FASHION Women's Rayon Embroidery Work Flared Kurta" Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("M")
            ListBox1.Items.Add("L")
            ListBox1.Items.Add("XL")
            ListBox1.Items.Add("FREE SIZE")
        End If
        If ComboBox1.SelectedItem = "Women Art Silk Sarees SDPL-SDPL-RAJRANI" Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("Small")
            ListBox1.Items.Add("Medium")
            ListBox1.Items.Add("Large")
        End If
        If ComboBox1.SelectedItem = "Women's Loose Fit Patiala Pants" Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("Small")
            ListBox1.Items.Add("Medium")
            ListBox1.Items.Add("Large")
        End If
        If ComboBox1.SelectedItem = "Rayon Gold Print Skirt Palazzo" Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("Small")
            ListBox1.Items.Add("Medium")
            ListBox1.Items.Add("Large")
        End If
        If ComboBox1.SelectedItem = "Ribbed Polo Collared Spaghetti Full Length Tops" Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("32")
            ListBox1.Items.Add("30")
            ListBox1.Items.Add("28")
        End If
        If ComboBox1.SelectedItem = "Women Mock Neck Ruffle Cuff Floral Top" Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("Small")
            ListBox1.Items.Add("Medium")
            ListBox1.Items.Add("Large")
        End If
        If ComboBox1.SelectedItem = "Ribbed Square Neck Spaghetti Corset Tops" Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("Small")
            ListBox1.Items.Add("Medium")
            ListBox1.Items.Add("Large")
        End If
        product.Text = ComboBox1.SelectedItem
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListBox1.SelectedItem = ("32") Then
            totalprice.Text = "500"
        End If
        If ListBox1.SelectedItem = ("30") Then
            totalprice.Text = "400"
        End If
        If ListBox1.SelectedItem = ("28") Then
            totalprice.Text = "999"
        End If
        If ListBox1.SelectedItem = ("Small") Then
            totalprice.Text = "550"
        End If
        If ListBox1.SelectedItem = ("Medium") Then
            totalprice.Text = "880"
        End If
        If ListBox1.SelectedItem = ("Large") Then
            totalprice.Text = "999"
        End If
        If ListBox1.SelectedItem = ("M") Then
            totalprice.Text = "999"
        End If
        If ListBox1.SelectedItem = ("L") Then
            totalprice.Text = "799"
        End If
        If ListBox1.SelectedItem = ("XL") Then
            totalprice.Text = "559"
        End If
        If ListBox1.SelectedItem = ("FREE SIZE") Then
            totalprice.Text = "699"
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