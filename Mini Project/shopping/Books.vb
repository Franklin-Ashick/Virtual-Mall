Imports System.Data.SqlClient
Public Class Books
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
    Dim total As Double
    Dim cost, discount, nobooks As Single
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbobooktype.Items.Add("Mathematics")
        cbobooktype.Items.Add("Accounting")
        cbobooktype.Items.Add("Economics")
        cbobooktype.Items.Add("English")
        cbobooktype.Items.Add("Marketing")
        cbobuyer.Items.Add("Student")
        cbobuyer.Items.Add("Teacher")
        cbobuyer.Items.Add("Others")
    End Sub

    Private Sub btntotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntotal.Click
        nobooks = Val(txtbooks.Text)
        If cbobooktype.Text = "Mathematics" Then
            cost = 600
        ElseIf cbobooktype.Text = "Marketing" Then
            cost = 350
        ElseIf cbobooktype.Text = "Accounting" Then
            cost = 652
        ElseIf cbobooktype.Text = "Economics" Then
            cost = 510
        Else
            cost = 350
        End If
        If cbobuyer.Text = "Student" Then
            discount = 65
        ElseIf cbobuyer.Text = "Teacher" Then
            discount = 85
        Else
            discount = 40
        End If
        total = (nobooks * cost) - (nobooks * discount)

        lbltotal.Text = "Rs." & "" & FormatNumber(total)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Hide()
        Homepage.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashic\source\repos\Mini Project\Mini Project\Data.mdf;Integrated Security=True")
        con.Open()
        str = "insert into sales(Name,PhNumber,Product,Quantity,Total_Price) values('" + fname.Text + "','" + phnumber.Text + "','" & cbobooktype.SelectedItem.ToString() & "',1,'" + lbltotal.Text + "')"
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        con.Close()
        con.Open()
        str = "insert into cart(product,quantity,price,amt) values('" & cbobooktype.SelectedItem.ToString() & "','" + txtbooks.Text + "','" & cost & "','" + lbltotal.Text + "')"
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

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cbobooktype.Text = ""
        cbobuyer.Text = ""
        txtbooks.Text = ""
        lbltotal.Text = ""
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class