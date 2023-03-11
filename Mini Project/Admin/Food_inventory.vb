Public Class Food_inventory
    Private Sub Food_inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inventoryy.Visible = False
        reserv.Visible = False
        shop.Visible = False
        'TODO: This line of code loads data into the 'DataDataSet5.shopping_item' table. You can move, or remove it, as needed.
        Me.Shopping_itemTableAdapter.Fill(Me.DataDataSet5.shopping_item)
        'TODO: This line of code loads data into the 'DataDataSet4.food_item' table. You can move, or remove it, as needed.
        Me.Food_itemTableAdapter.Fill(Me.DataDataSet4.food_item)
        'TODO: This line of code loads data into the 'DataDataSet3.reservations_item' table. You can move, or remove it, as needed.
        Me.Reservations_itemTableAdapter.Fill(Me.DataDataSet3.reservations_item)

        'reservations
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Single Room")
        ComboBox1.Items.Add("Double Room")
        ComboBox1.Items.Add("Villa")
        ComboBox1.Items.Add("Duplex")

        'food
        BunifuDropdown1.Items.Clear()
        BunifuDropdown1.Items.Add("")
        BunifuDropdown1.Items.Add("")
        BunifuDropdown1.Items.Add("")
        BunifuDropdown1.Items.Add("")
        BunifuDropdown1.Items.Add("")

        'shopping
        BunifuDropdown2.Items.Clear()
        BunifuDropdown2.Items.Add("")
        BunifuDropdown2.Items.Add("")
        BunifuDropdown2.Items.Add("")
        BunifuDropdown2.Items.Add("")
        BunifuDropdown2.Items.Add("")

    End Sub

    Private Sub Food_Click(sender As Object, e As EventArgs) Handles Food.Click
        inventoryy.Visible = True
        reserv.Visible = False
        shop.Visible = False

    End Sub

    Private Sub Shopping_Click(sender As Object, e As EventArgs) Handles Shopping.Click
        inventoryy.Visible = False
        reserv.Visible = False
        shop.Visible = True

    End Sub

    Private Sub Reservations_Click(sender As Object, e As EventArgs) Handles Reservations.Click
        inventoryy.Visible = False
        reserv.Visible = True
        shop.Visible = False

    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click

    End Sub

    Private Sub BunifuThinButton29_Click(sender As Object, e As EventArgs) Handles BunifuThinButton29.Click

    End Sub

    Private Sub BunifuShadowPanel1_ControlAdded(sender As Object, e As ControlEventArgs) Handles BunifuShadowPanel1.ControlAdded

    End Sub
End Class