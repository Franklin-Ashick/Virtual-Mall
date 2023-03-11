Imports System.Data.SqlClient
Imports System.Data
Public Class admin
    Dim con As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim com As SqlCommand
    Dim ds As New DataSet
    Dim dr As SqlDataReader
    Dim dt As DataTable
    Dim dv As DataView
    Dim str As String
    Dim stu As Object
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataDataSet43.sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter1.Fill(Me.DataDataSet43.sales)
        'TODO: This line of code loads data into the 'DataDataSet8.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter1.Fill(Me.DataDataSet8.customer)
        'TODO: This line of code loads data into the 'DataDataSet7.sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Fill(Me.DataDataSet7.sales)
        customers.Visible = False
        salesreport.Visible = False
    End Sub

    Private Sub inventory_Click(sender As Object, e As EventArgs) Handles inventory.Click
        Food_inventory.ShowDialog()
    End Sub

    'customer details
    'add
    Private Sub add_btt_Click(sender As Object, e As EventArgs) Handles add_btt.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashic\source\repos\Mini Project\Mini Project\Data.mdf;Integrated Security=True")
        con.Open()
        str = "insert into customer(c_name,c_mail,address,c_phno) values('" + fname.Text + "','" + email.Text + "','" + address.Text + "','" + PhNumber.Text + "')"
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        MsgBox("Customer Details Inserted Successfully..")
        Using con
            str = "select * from customer"
            com = New SqlCommand(str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            DataGridView1.DataSource = New BindingSource(dt, stu)
        End Using
        con.Close()
    End Sub
    'update
    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashic\source\repos\Mini Project\Mini Project\Data.mdf;Integrated Security=True")
        con.Open()
        str = "update customer setc_mail='" + email.Text + "',address='" + address.Text + "',c_phno='" + PhNumber.Text + "' where  c_name='" + fname.Text + "'"
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        MsgBox("Details Updated Successfully..")
        Using con
            str = "select * from customer"
            com = New SqlCommand(str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            DataGridView1.DataSource = New BindingSource(dt, stu)
        End Using
        con.Close()
    End Sub
    'delete
    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        Try
            If (MsgBox(“Are you sure you want to delete the Details?”, MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashic\source\repos\Mini Project\Mini Project\Data.mdf;Integrated Security=True")
                con.Open()
                str = "DELETE FROM customer WHERE c_name='" + fname.Text + "'"
                com = New SqlCommand(str, con)
                com.ExecuteNonQuery()
                MsgBox("Deleted Successfully..")
                Using con
                    str = "select * from customer"
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

    'sales 
    'delete
    Private Sub BunifuThinButton27_Click(sender As Object, e As EventArgs) Handles BunifuThinButton27.Click
        Try
            If (MsgBox(“Are you sure you want to delete the item?”, MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashic\source\repos\Mini Project\Mini Project\Data.mdf;Integrated Security=True")
                con.Open()
                str = "DELETE FROM sales WHERE Id='" + TextBox1.Text + "'"
                com = New SqlCommand(str, con)
                com.ExecuteNonQuery()
                MsgBox("Deleted Successfully..")
                Using con
                    str = "select * from sales"
                    com = New SqlCommand(str, con)
                    da = New SqlDataAdapter(com)
                    dt = New DataTable()
                    dv = New DataView()
                    da.Fill(dt)
                    DataGridView2.DataSource = New BindingSource(dt, stu)
                End Using
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
                    con.Close()
                End Try
    End Sub

    Private Sub coustmers_Click(sender As Object, e As EventArgs) Handles coustmers.Click
        customers.Visible = True
        salesreport.Visible = False

    End Sub

    Private Sub Sales_report_Click(sender As Object, e As EventArgs) Handles Sales_report.Click
        customers.Visible = False
        salesreport.Visible = True

    End Sub

    'close
    Private Sub BunifuCustomLabel11_MouseEnter(sender As Object, e As EventArgs) Handles BunifuCustomLabel11.MouseEnter
        BunifuCustomLabel11.ForeColor = Color.White
    End Sub
    Private Sub BunifuCustomLabel11_MouseLeave(sender As Object, e As EventArgs) Handles BunifuCustomLabel11.MouseLeave
        BunifuCustomLabel11.ForeColor = Color.Crimson
    End Sub
    Private Sub BunifuCustomLabel11_MouseDoubleClick(sender As Object, e As EventArgs) Handles BunifuCustomLabel11.Click
        Me.Hide()
        Admin_Login.Show()

    End Sub

    Private Sub customers_Paint(sender As Object, e As PaintEventArgs) Handles customers.Paint

    End Sub

    Private Sub BunifuShadowPanel1_ControlAdded(sender As Object, e As ControlEventArgs) Handles BunifuShadowPanel1.ControlAdded

    End Sub
End Class