Imports System.Data.SqlClient
Public Class recipt
    Dim con As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim com As SqlCommand
    Dim cod As New SqlCommand
    Dim dr As SqlDataReader
    Dim dt As DataTable
    Dim dv As DataView
    Dim str As String
    Dim stu As String
    Dim f4 As Billing
    Public Sub New(ByVal frm1 As Billing)
        InitializeComponent()
        f4 = frm1
    End Sub

    Private Sub recipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cart1DataDataSet.cart' table. You can move, or remove it, as needed.
        Me.CartTableAdapter.Fill(Me.Cart1DataDataSet.cart)
        quality.Text = f4.quality.Text
        amount.Text = f4.amount.Text
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashic\source\repos\Mini Project\Mini Project\Data.mdf;Integrated Security=True")
        con.Open()
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



    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim dm As New Bitmap(Me.billing_panel.Width, Me.billing_panel.Height)
        billing_panel.DrawToBitmap(dm, New Rectangle(0, 0, billing_panel.Width, Me.billing_panel.Height))
        e.Graphics.DrawImage(dm, 0, 0)
        Dim asp As New PageSetupDialog
        asp.Document = PrintDocument1
    End Sub



    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        PrintDocument1.Print()
    End Sub

    Private Sub purchase_btn_Click(sender As Object, e As EventArgs) Handles purchase_btn.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashic\source\repos\Mini Project\Mini Project\Data.mdf;Integrated Security=True")
        con.Open()
        stu = "TRUNCATE TABLE cart"
        cod = New SqlCommand(stu, con)
        cod.ExecuteNonQuery()
        con.Close()
        Me.Close()
        feedback_form.Show()
    End Sub

    Private Sub billing_panel_Paint_1(sender As Object, e As PaintEventArgs) Handles billing_panel.Paint

    End Sub
End Class