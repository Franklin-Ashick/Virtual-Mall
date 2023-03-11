Imports System.Data.SqlClient
Public Class Billing
    Dim con As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim com As SqlCommand
    Dim cod As New SqlCommand
    Dim dr As SqlDataReader
    Dim dt As DataTable
    Dim dv As DataView
    Dim str As String
    Dim stu As String

    Dim f1 As cart
    Public Sub New(ByVal frm1 As cart)
        InitializeComponent()
        f1 = frm1
    End Sub
    Private Sub Billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        quality.Text = f1.quality.Text
        amount.Text = f1.amount.Text
        upii.Visible = False
        card.Visible = False
        Cash.Visible = False
        card.BackColor = Color.FromArgb(25, Color.Black)
        upii.BackColor = Color.FromArgb(25, Color.Black)
        Cash.BackColor = Color.FromArgb(25, Color.Black)
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        upii.Visible = False
        card.Visible = True
        Cash.Visible = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        upii.Visible = False
        card.Visible = False
        Cash.Visible = True
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        upii.Visible = True
        card.Visible = False
        Cash.Visible = False
    End Sub

    Private Sub purchase_btn_Click(sender As Object, e As EventArgs) Handles purchase_btn.Click
        If (name.Text = "" And phnumber.Text = "") Then
            MsgBox("Fill The details")
        Else
            con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashic\source\repos\Mini Project\Mini Project\Data.mdf;Integrated Security=True")
            con.Open()
            str = "insert into sales(Name,PhNumber,Product,Quantity,Total_Price,Date) values('" + Name.Text + "','" + phnumber.Text + "','Mixed Products','" + quality.Text + "','" + amount.Text + "','" + Date.Now + "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            con.Close()
            Dim f3 As New recipt(Me)
            f3.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub BunifuCustomLabel11_MouseDoubleClick(sender As Object, e As EventArgs) Handles BunifuCustomLabel11.Click
        Me.Hide()
        cart.Show()
    End Sub


End Class