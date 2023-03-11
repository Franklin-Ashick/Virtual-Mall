Imports System.Data.SqlClient
Imports System.Data
Public Class cart
    Dim con As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim com As SqlCommand
    Dim ds As New DataSet
    Dim dr As SqlDataReader
    Dim dt As DataTable
    Dim dv As DataView
    Dim str As String
    Dim stu As Object
    Dim x As Integer
    Dim a As Integer
    Dim t As Integer


    Public Sub New()
        InitializeComponent()
        BindGrid()
    End Sub
    Private Sub BindGrid()
        Dim constring As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashic\source\repos\Mini Project\Mini Project\Data.mdf;Integrated Security=True"
        Using con As New SqlConnection(constring)
            Using cmd As New SqlCommand("SELECT * FROM cart", con)
                cmd.CommandType = CommandType.Text
                Using sda As New SqlDataAdapter(cmd)
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub
    Private Sub Flower_Cart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CartDataDataSet.cart' table. You can move, or remove it, as needed.
        Me.CartTableAdapter.Fill(Me.CartDataDataSet.cart)
        Panel1.BackColor = Color.Transparent
        Panel2.BackColor = Color.Transparent
    End Sub
    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Textbox1.Text = row.Cells(0).Value.ToString
            Textbox2.Text = row.Cells(2).Value.ToString
            Textbox3.Text = row.Cells(1).Value.ToString
            Textbox4.Text = row.Cells(4).Value.ToString
            Textbox5.Text = row.Cells(3).Value.ToString
        End If
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Dim sum As Integer = 0
        Dim sum1 As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            sum = sum + DataGridView1.Rows(i).Cells(2).Value
            sum1 = sum1 + DataGridView1.Rows(i).Cells(4).Value
        Next
        quality.Text = sum.ToString()
        amount.Text = sum1.ToString()
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        Try
            If (MsgBox(“Are you sure you want to delete the item?”, MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashic\source\repos\Mini Project\Mini Project\Data.mdf;Integrated Security=True")
                con.Open()
                str = "DELETE FROM cart WHERE cart_Id='" + Textbox1.Text + "'"
                com = New SqlCommand(str, con)
                com.ExecuteNonQuery()
                MsgBox("Deleted Successfully..")
                Using con
                    str = "select * from cart"
                    com = New SqlCommand(str, con)
                    da = New SqlDataAdapter(com)
                    dt = New DataTable()
                    dv = New DataView()
                    da.Fill(dt)
                    DataGridView1.DataSource = New BindingSource(dt, stu)
                End Using
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

    End Sub
    Private Sub add_btt_Click(sender As Object, e As EventArgs) Handles add_btt.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashic\source\repos\Mini Project\Mini Project\Data.mdf;Integrated Security=True")
        con.Open()
        str = "insert into cart(quantity,product,price,amt) values('" + Textbox2.Text + "','" + Textbox3.Text + "','" + Textbox5.Text + "','" + Textbox4.Text + "')"
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        MsgBox("Car Details Inserted Successfully..")
        Using con
            str = "select * from cart"
            com = New SqlCommand(str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            DataGridView1.DataSource = New BindingSource(dt, stu)
        End Using
        con.Close()
    End Sub
    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        x = Textbox5.Text
        a = Textbox2.Text
        t = x * a
        Textbox4.Text = t
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashic\source\repos\Mini Project\Mini Project\Data.mdf;Integrated Security=True")
        con.Open()
        str = "update cart set quantity='" + Textbox2.Text + "',amt='" + Textbox4.Text + "' where cart_Id='" + Textbox1.Text + "'"
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        MsgBox("Cart Data Updated Successfully..")
        Using con
            str = "select * from cart"
            com = New SqlCommand(str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            DataGridView1.DataSource = New BindingSource(dt, stu)
        End Using
        con.Close()
    End Sub

    Private Sub purchase_btn_Click(sender As Object, e As EventArgs) Handles purchase_btn.Click
        Me.Hide()

        Dim f2 As New Billing(Me)
        f2.Show()
        Textbox1.Text = ""
        Textbox2.Text = ""
        Textbox3.Text = ""
        Textbox4.Text = ""
        Textbox5.Text = ""
    End Sub

    Private Sub BunifuCustomLabel11_MouseDoubleClick(sender As Object, e As EventArgs) Handles BunifuCustomLabel11.Click
        Me.Hide()
        Homepage.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class