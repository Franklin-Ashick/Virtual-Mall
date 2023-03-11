Imports System.Data.SqlClient
Public Class grocery
    Dim con As New SqlConnection
    Dim com As SqlCommand
    Dim str As String
    Dim x As Integer
    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashic\source\repos\Mini Project\Mini Project\Data.mdf;Integrated Security=True")
    End Sub
    Private Sub plants_Click(sender As Object, e As EventArgs)
        meat.Visible = False
        veg.Visible = True
        snacks.Visible = False
        fruita.Visible = False

    End Sub
    Private Sub bouquets_Click(sender As Object, e As EventArgs) Handles meattt.Click

        meat.Visible = True
        veg.Visible = False
        snacks.Visible = False
        fruita.Visible = False

    End Sub
    Private Sub pots_Click(sender As Object, e As EventArgs) Handles vegi.Click

        meat.Visible = False
        veg.Visible = True
        snacks.Visible = False
        fruita.Visible = False

    End Sub
    Private Sub seeds_Click(sender As Object, e As EventArgs) Handles fruitss.Click

        meat.Visible = False
        veg.Visible = False
        snacks.Visible = True
        fruita.Visible = False

    End Sub
    Private Sub accessories_Click(sender As Object, e As EventArgs) Handles snackks.Click

        meat.Visible = False
        veg.Visible = False
        snacks.Visible = False
        fruita.Visible = True

    End Sub

    Private Sub BunifuTileButton5_Click(sender As Object, e As EventArgs) Handles crab.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 500 ", "To Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 500 * quantity
            con.Open()
            str = "insert into cart(product,quantity,price,amt) values('Crabs','" & quantity & "','500','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub

    Private Sub mutton_Click(sender As Object, e As EventArgs) Handles mutton.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 400", "To Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 400 * quantity
            con.Open()
            str = "insert into cart(product,quantity,price,amt) values('Mutton','" & quantity & "','400','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub

    Private Sub fish_Click(sender As Object, e As EventArgs) Handles fish.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 280", "To Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 280 * quantity
            con.Open()
            str = "insert into cart(product,quantity,price,amt) values('Fish','" & quantity & "','500','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub

    Private Sub prawans_Click(sender As Object, e As EventArgs) Handles prawans.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 300 ", "To Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 300 * quantity
            con.Open()
            str = "insert into cart(product,quantity,price,amt) values('Prawans','" & quantity & "','300','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    'str = "insert into cart(product,quantity,price,amt) values(' ','" & quantity & "',' ','" & x & "')"


    Private Sub plants_fertilizers_Click(sender As Object, e As EventArgs) Handles plants_fertilizers.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 60 ", "To Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 60 * quantity
            con.Open()
            str = "insert into cart(product,quantity,price,amt) values('Apple','" & quantity & "','60','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub watering_cans_Click(sender As Object, e As EventArgs) Handles watering_cans.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 100 ", "To Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 100 * quantity
            con.Open()
            str = "insert into cart(product,quantity,price,amt) values('Bananaa','" & quantity & "','100','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub tools_Click(sender As Object, e As EventArgs) Handles tools.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 200", "To Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 200 * quantity
            con.Open()
            str = "insert into cart(product,quantity,price,amt) values('Orange','" & quantity & "','200','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub vases_Click(sender As Object, e As EventArgs) Handles vases.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 250", "To Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 250 * quantity
            con.Open()
            str = "insert into cart(product,quantity,price,amt) values('Mangao','" & quantity & "','250','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub Ribbons_Click(sender As Object, e As EventArgs) Handles Ribbons.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 40 ", "To Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 40 * quantity
            con.Open()
            str = "insert into cart(product,quantity,price,amt) values('Coconut','" & quantity & "',' ','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub artificial_plants_Click(sender As Object, e As EventArgs) Handles artificial_plants.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 45 ", "To Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 45 * quantity
            con.Open()
            str = "insert into cart(product,quantity,price,amt) values('Papaya','" & quantity & "','45','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub flower_seeds_Click(sender As Object, e As EventArgs) Handles flower_seeds.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 160", "To Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 160 * quantity
            con.Open()
            str = "insert into cart(product,quantity,price,amt) values('Fries','" & quantity & "','160','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub veg_seeds_Click(sender As Object, e As EventArgs) Handles veg_seeds.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 150", "To Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else

            x = 150 * quantity
            con.Open()
            str = "insert into cart(product,quantity,price,amt) values('Chips','" & quantity & "','150','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub



    Private Sub red_roses_Click(sender As Object, e As EventArgs) Handles red_roses.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 180", "To Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 180 * quantity
            con.Open()
            str = "insert into cart(product,quantity,price,amt) values('Chicken','" & quantity & "','180','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub



    Private Sub BunifuCustomLabel11_MouseEnter(sender As Object, e As EventArgs) Handles BunifuCustomLabel11.MouseEnter
        BunifuCustomLabel11.ForeColor = Color.White
    End Sub
    Private Sub BunifuCustomLabel11_MouseLeave(sender As Object, e As EventArgs) Handles BunifuCustomLabel11.MouseLeave
        BunifuCustomLabel11.ForeColor = Color.Crimson
    End Sub
    Private Sub BunifuCustomLabel11_MouseDoubleClick(sender As Object, e As EventArgs) Handles BunifuCustomLabel11.Click
        Me.Hide()
        Homepage.Show()
    End Sub


    Private Sub indoor_plants_Click(sender As Object, e As EventArgs) Handles indoor_plants.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 20", "To Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 20 * quantity
            con.Open()
            str = "insert into cart(product,quantity,price,amt) values('Tomato','" & quantity & "','20','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub

    Private Sub outdoor_plants_Click(sender As Object, e As EventArgs) Handles outdoor_plants.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 40", "To Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 40 * quantity
            con.Open()
            str = "insert into cart(product,quantity,price,amt) values('Onions','" & quantity & "','40','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub

    Private Sub BunifuTileButton4_Click(sender As Object, e As EventArgs) Handles BunifuTileButton4.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 50 ", "To Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 50 * quantity
            con.Open()
            str = "insert into cart(product,quantity,price,amt) values('Potatos','" & quantity & "','50','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub

    Private Sub BunifuTileButton2_Click(sender As Object, e As EventArgs) Handles BunifuTileButton2.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 30", "To Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 30 * quantity
            con.Open()
            str = "insert into cart(product,quantity,price,amt) values('Beans','" & quantity & "',' 30','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 20 ", "To Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 20 * quantity
            con.Open()
            str = "insert into cart(product,quantity,price,amt) values('Cucumber','" & quantity & "','20','" & x & "')"
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub

    Private Sub BunifuTileButton3_Click(sender As Object, e As EventArgs) Handles BunifuTileButton3.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 30 ", "To Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 30 * quantity
            con.Open()
            str = "insert into cart(product,quantity,price,amt) values('Beetroot','" & quantity & "','30','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub

    Private Sub BunifuTileButton8_Click(sender As Object, e As EventArgs) Handles BunifuTileButton8.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 200 ", "To Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 200 * quantity
            con.Open()
            str = "insert into cart(product,quantity,price,amt) values('Sweet','" & quantity & "','200','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub

    Private Sub BunifuTileButton6_Click(sender As Object, e As EventArgs) Handles BunifuTileButton6.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 100", "To Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 100 * quantity
            con.Open()
            str = "insert into cart(product,quantity,price,amt) values('Fruit Juice','" & quantity & "','100','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub

    Private Sub BunifuTileButton5_Click_1(sender As Object, e As EventArgs) Handles BunifuTileButton5.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 120", "To Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 120 * quantity
            con.Open()
            str = "insert into cart(product,quantity,price,amt) values('Milkshake','" & quantity & "','120','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub

    Private Sub BunifuTileButton7_Click(sender As Object, e As EventArgs) Handles BunifuTileButton7.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 200", "To Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 200 * quantity
            con.Open()
            str = "insert into cart(product,quantity,price,amt) values('Beverages','" & quantity & "','200','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
End Class