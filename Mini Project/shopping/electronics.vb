
Imports System.Data.SqlClient
    Imports System.Data
Public Class electronics
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


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox2.Items.Clear()
        ComboBox2.Items.Add("Mobiles And Laptop")
        ComboBox2.Items.Add("Electronic Home Appliances")
        ComboBox2.Items.Add("Electronic Accessories")
        ComboBox2.Items.Add("Audio Systems And Speakers")
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedItem = "Mobiles And Laptop" Then
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("Mobiles")
            ComboBox1.Items.Add("Laptops")
            ComboBox1.Items.Add("Desktop")
            ComboBox1.Items.Add("Tablet")
            Label1.Text = "Mobiles And Laptop"
        End If
        If ComboBox2.SelectedItem = "Electronic Home Appliances" Then
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("TV")
            ComboBox1.Items.Add("Refrigerator")
            ComboBox1.Items.Add("Washing Machine")
            Label1.Text = "Electronic Home Appliances"
        End If
        If ComboBox2.SelectedItem = "Electronic Accessories" Then
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("USB Cables")
            ComboBox1.Items.Add("KeyBoards")
            ComboBox1.Items.Add("Mouse")
            ComboBox1.Items.Add("PenDrives")
            Label1.Text = "Electronic Accessories"
        End If
        If ComboBox2.SelectedItem = "Audio Systems And Speakers" Then
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("Speaker")
            ComboBox1.Items.Add("Mics")
            ComboBox1.Items.Add("Head Phones")
            Label1.Text = "Audio Systems And Speakers"
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Laptops" Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("Lenovo IdeaPad core i3 10th Gen")
            ListBox1.Items.Add("Infinix INBook X1 core i3 10th Gen")
            ListBox1.Items.Add("HP Pavilion Ryzen Hexa core 5600H")
            ListBox1.Items.Add("Acer Aspire 7 core i5 10th Gen")
            ListBox1.Items.Add("Dell Vostro core i3 11th Gen")
        End If
        If ComboBox1.SelectedItem = "Mobiles" Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("Realme C31(Dark Green,64GB)")
            ListBox1.Items.Add("Redmi 9i sports(Metallic Blue,64GB)")
            ListBox1.Items.Add("Vivo T1(Rainbow Fantasy,128GB)")
            ListBox1.Items.Add("Oppo K10(Black Carbon,128GB)")
            ListBox1.Items.Add("SAMSUNG Galaxy F23(Forest Green,256GB)")
        End If
        If ComboBox1.SelectedItem = "Desktop" Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("Lenovo IdeaCentre 320 Celeron dual Core")
            ListBox1.Items.Add("ZOONIS BASIC Core 2 Duo")
            ListBox1.Items.Add("HP All-in-one Core i3")
            ListBox1.Items.Add("Brozzo G1 core 2 Duo")
            ListBox1.Items.Add("Assembled Core i3")
        End If
        If ComboBox1.SelectedItem = "Tablet" Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("APPLE ipad(9th Gen)")
            ListBox1.Items.Add("Realme Pad(4GB RAM) ")
            ListBox1.Items.Add("Lenovo Smart Yoga Tab")
            ListBox1.Items.Add("SAMSUNG Galaxy Tab S7+")
            ListBox1.Items.Add("I Kall N7")
        End If
        If ComboBox1.SelectedItem = "TV" Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("One Plus Y1S 80cm(32 inch)")
            ListBox1.Items.Add("Mi 4A PRO 80cm(32 inch)")
            ListBox1.Items.Add("Realme 108cm(43 inch)")
            ListBox1.Items.Add("SONY BRAVIA 108cm(43 inch)")
            ListBox1.Items.Add("INFINIX 138.8cm(55 inch)")
            ListBox1.Items.Add("LG ULTRA HD 125.7cm(50 inch)")
        End If
        If ComboBox1.SelectedItem = "Refrigerator" Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("SAMSUNG 193L")
            ListBox1.Items.Add("Whirlpool 190L")
            ListBox1.Items.Add("LG 260L")
            ListBox1.Items.Add("Haier 195L")
            ListBox1.Items.Add("Godrej 185L")
        End If
        If ComboBox1.SelectedItem = "Washing Machine" Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("LG Top Load 7kg")
            ListBox1.Items.Add("Whirlpool Front Load 7.5kg")
            ListBox1.Items.Add("SAMSUNG Top Load 6.5kg")
            ListBox1.Items.Add("IFB Top Load 6kg")
            ListBox1.Items.Add("IFB Top Load 6kg")
        End If
        If ComboBox1.SelectedItem = "Speaker" Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("boAt Stone 190F")
            ListBox1.Items.Add("REB CRAB K7 20")
            ListBox1.Items.Add("Mivi Fort S100")
            ListBox1.Items.Add("ZEBRONICS Zeb")
            ListBox1.Items.Add("JBL Flip IPX7")
        End If
        If ComboBox1.SelectedItem = "Mics" Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("BRD CLIP A4")
            ListBox1.Items.Add("HUBSTAR 429")
            ListBox1.Items.Add("AJRO 989")
            ListBox1.Items.Add("MAONO AU-400")
            ListBox1.Items.Add("ATARC 700")
        End If
        If ComboBox1.SelectedItem = "Head Phones" Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("boAt Bassheads")
            ListBox1.Items.Add("OnePlus R444")
            ListBox1.Items.Add("TECHFFIRE 145")
            ListBox1.Items.Add("Aroma NB119B")
            ListBox1.Items.Add("Ubon H334")
        End If
        If ComboBox1.SelectedItem = "USB Cables" Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("ULTRADART 65W Type C Cable")
            ListBox1.Items.Add("Ambrane ACM-1 1m Micro USB Cable")
            ListBox1.Items.Add("Mi SJV41 Type C Cable")
            ListBox1.Items.Add("boAt Deuce 2 in 1 USB Cable")
            ListBox1.Items.Add("iBAss DASH Type C Cable")
        End If
        If ComboBox1.SelectedItem = "KeyBoards" Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("ZEBRONICS ZEB HK")
            ListBox1.Items.Add("HP C2500")
            ListBox1.Items.Add("AMKETTE Xcite")
            ListBox1.Items.Add("DELL KM117")
            ListBox1.Items.Add("Logitech MK235")
        End If
        If ComboBox1.SelectedItem = "Mouse" Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("Intex Eco-8")
            ListBox1.Items.Add("Logitech B175")
            ListBox1.Items.Add("DELL MS116")
            ListBox1.Items.Add("HP AA1000")
            ListBox1.Items.Add("ZEBRONICS WM-552")
        End If
        If ComboBox1.SelectedItem = "PenDrives" Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("SanDisk SDDDC4-1")
            ListBox1.Items.Add("EDENIC 4K ULTRA HD")
            ListBox1.Items.Add("HP 64GB ULTRA HD")
            ListBox1.Items.Add("MIcroware New 16")
            ListBox1.Items.Add("GARV ULTRA 128GB")
        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        totalprice.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'mobiles
        If ListBox1.SelectedItem = ("Realme C31(Dark Green,64GB)") Then
            totalprice.Text = "13,999"
        End If
        If ListBox1.SelectedItem = ("Redmi 9i sports(Metallic Blue,64GB)") Then
            totalprice.Text = "14,999"
        End If
        If ListBox1.SelectedItem = ("Vivo T1(Rainbow Fantasy,128GB)") Then
            totalprice.Text = "19,999"
        End If
        If ListBox1.SelectedItem = ("Oppo K10(Black Carbon,128GB)") Then
            totalprice.Text = "21,999"
        End If
        If ListBox1.SelectedItem = ("SAMSUNG Galaxy F23(Forest Green,256GB)") Then
            totalprice.Text = "42,999"
        End If
        If ListBox1.SelectedItem = ("Lenovo IdeaPad core i3 10th Gen") Then
            totalprice.Text = "38,999"
        End If
        If ListBox1.SelectedItem = ("Infinix INBook X1 core i3 10th Gen") Then
            totalprice.Text = "42,999"
        End If
        If ListBox1.SelectedItem = ("HP Pavilion Ryzen Hexa core 5600H") Then
            totalprice.Text = "45,999"
        End If
        If ListBox1.SelectedItem = ("Acer Aspire 7 core i5 10th Gen") Then
            totalprice.Text = "55,999"
        End If
        If ListBox1.SelectedItem = ("Dell Vostro core i3 11th Gen") Then
            totalprice.Text = "52,999"
        End If
        If ListBox1.SelectedItem = ("Lenovo IdeaPad core i3 10th Gen") Then
            totalprice.Text = "32,999"
        End If
        If ListBox1.SelectedItem = ("ZOONIS BASIC Core 2 Duo") Then
            totalprice.Text = "35,999"
        End If
        If ListBox1.SelectedItem = ("HP All-in-one Core i3") Then
            totalprice.Text = "33,999"
        End If
        If ListBox1.SelectedItem = ("Brozzo G1 core 2 Duo") Then
            totalprice.Text = "28,999"
        End If
        If ListBox1.SelectedItem = ("Assembled Core i3") Then
            totalprice.Text = "29,999"
        End If
        If ListBox1.SelectedItem = ("APPLE ipad(9th Gen)") Then
            totalprice.Text = "38,999"
        End If
        If ListBox1.SelectedItem = ("Realme Pad(4GB RAM) ") Then
            totalprice.Text = "17,999"
        End If
        If ListBox1.SelectedItem = ("Lenovo Smart Yoga Tab") Then
            totalprice.Text = "21,999"
        End If
        If ListBox1.SelectedItem = ("SAMSUNG Galaxy Tab S7+") Then
            totalprice.Text = "19,099"
        End If
        If ListBox1.SelectedItem = ("I Kall N7") Then
            totalprice.Text = "16,999"
        End If
        'speakers
        If ListBox1.SelectedItem = ("boAt Stone 190F") Then
            totalprice.Text = "399"
        End If
        If ListBox1.SelectedItem = ("REB CRAB K7 20") Then
            totalprice.Text = "599"
        End If
        If ListBox1.SelectedItem = ("Mivi Fort S100") Then
            totalprice.Text = "279"
        End If
        If ListBox1.SelectedItem = ("ZEBRONICS Zeb") Then
            totalprice.Text = "999"
        End If
        If ListBox1.SelectedItem = ("JBL Flip IPX7") Then
            totalprice.Text = "1,499"
        End If
        If ListBox1.SelectedItem = ("BRD CLIP A4") Then
            totalprice.Text = "899"
        End If
        If ListBox1.SelectedItem = ("HUBSTAR 42") Then
            totalprice.Text = "429"
        End If
        If ListBox1.SelectedItem = ("AJRO 989") Then
            totalprice.Text = "577"
        End If
        If ListBox1.SelectedItem = ("MAONO AU-400") Then
            totalprice.Text = "699"
        End If
        If ListBox1.SelectedItem = ("ATARC 700") Then
            totalprice.Text = "899"
        End If
        If ListBox1.SelectedItem = ("boAt Bassheads") Then
            totalprice.Text = "1,499"
        End If
        If ListBox1.SelectedItem = ("OnePlus R444") Then
            totalprice.Text = "1,899"
        End If
        If ListBox1.SelectedItem = ("TECHFFIRE 145") Then
            totalprice.Text = "1,450"
        End If
        If ListBox1.SelectedItem = ("Aroma NB119B") Then
            totalprice.Text = "899"
        End If
        If ListBox1.SelectedItem = ("Ubon H334") Then
            totalprice.Text = "1,399"
        End If

        'home appliance
        If ListBox1.SelectedItem = ("One Plus Y1S 80cm(32 inch)") Then
            totalprice.Text = "21,999"
        End If
        If ListBox1.SelectedItem = ("Mi 4A PRO 80cm(32 inch)") Then
            totalprice.Text = "22,999"
        End If
        If ListBox1.SelectedItem = ("Realme 108cm(43 inch)") Then
            totalprice.Text = "25,999"
        End If
        If ListBox1.SelectedItem = ("SONY BRAVIA 108cm(43 inch)") Then
            totalprice.Text = "27,999"
        End If
        If ListBox1.SelectedItem = ("INFINIX 138.8cm(55 inch)") Then
            totalprice.Text = "38,999"
        End If
        If ListBox1.SelectedItem = ("LG ULTRA HD 125.7cm(50 inch)") Then
            totalprice.Text = "41,999"
        End If
        If ListBox1.SelectedItem = ("SAMSUNG 193L") Then
            totalprice.Text = "15,199"
        End If
        If ListBox1.SelectedItem = ("Whirlpool 190L") Then
            totalprice.Text = "14,199"
        End If
        If ListBox1.SelectedItem = ("LG 260L") Then
            totalprice.Text = "28,999"
        End If
        If ListBox1.SelectedItem = ("Haier 195L") Then
            totalprice.Text = "18,999"
        End If
        If ListBox1.SelectedItem = ("Godrej 185L") Then
            totalprice.Text = "12,999"
        End If
        If ListBox1.SelectedItem = ("LG Top Load 7kg") Then
            totalprice.Text = "15,999"
        End If
        If ListBox1.SelectedItem = ("Whirlpool Front Load 7.5kg") Then
            totalprice.Text = "18,999"
        End If
        If ListBox1.SelectedItem = ("SAMSUNG Top Load 6.5kg") Then
            totalprice.Text = "13,999"
        End If
        If ListBox1.SelectedItem = ("IFB Top Load 6kg") Then
            totalprice.Text = "12,999"
        End If
        If ListBox1.SelectedItem = ("IFB Top Load 6kg") Then
            totalprice.Text = "14,999"
        End If
        'accesories
        If ListBox1.SelectedItem = ("ULTRADART 65W Type C Cable") Then
            totalprice.Text = "299"
        End If
        If ListBox1.SelectedItem = ("Ambrane ACM-1 1m Micro USB Cable") Then
            totalprice.Text = "199"
        End If
        If ListBox1.SelectedItem = ("Mi SJV41 Type C Cable") Then
            totalprice.Text = "399"
        End If
        If ListBox1.SelectedItem = ("boAt Deuce 2 in 1 USB Cable") Then
            totalprice.Text = "459"
        End If
        If ListBox1.SelectedItem = ("iBAss DASH Type C Cable") Then
            totalprice.Text = "799"
        End If
        If ListBox1.SelectedItem = ("ZEBRONICS ZEB HK") Then
            totalprice.Text = "659"
        End If
        If ListBox1.SelectedItem = ("HP C2500") Then
            totalprice.Text = "459"
        End If
        If ListBox1.SelectedItem = ("AMKETTE Xcite") Then
            totalprice.Text = "899"
        End If
        If ListBox1.SelectedItem = ("DELL KM117") Then
            totalprice.Text = "789"
        End If
        If ListBox1.SelectedItem = ("Logitech MK235") Then
            totalprice.Text = "999"
        End If
        If ListBox1.SelectedItem = ("Intex Eco-8") Then
            totalprice.Text = "459"
        End If
        If ListBox1.SelectedItem = ("Logitech B175o") Then
            totalprice.Text = "669"
        End If
        If ListBox1.SelectedItem = ("DELL MS116") Then
            totalprice.Text = "999"
        End If
        If ListBox1.SelectedItem = ("HP AA1000") Then
            totalprice.Text = "779"
        End If
        If ListBox1.SelectedItem = ("ZEBRONICS WM-552") Then
            totalprice.Text = "749"
        End If
        If ListBox1.SelectedItem = ("SanDisk SDDDC4-1") Then
            totalprice.Text = "399"
        End If
        If ListBox1.SelectedItem = ("EDENIC 4K ULTRA HD") Then
            totalprice.Text = "499"
        End If
        If ListBox1.SelectedItem = ("HP 64GB ULTRA HD") Then
            totalprice.Text = "679"
        End If
        If ListBox1.SelectedItem = ("MIcroware New 16") Then
            totalprice.Text = "899"
        End If
        If ListBox1.SelectedItem = ("GARV ULTRA 128GB") Then
            totalprice.Text = "1,299"
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        product.Text = ListBox1.SelectedItem

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