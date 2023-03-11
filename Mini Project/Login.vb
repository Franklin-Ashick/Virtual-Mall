Imports System.Data.SqlClient

Public Class Login
    Private Sub loginn_Click(sender As Object, e As EventArgs) Handles loginn.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashic\source\repos\Mini Project\Mini Project\users.mdf;Integrated Security=True"
        Dim objcon As SqlConnection = Nothing
        Dim objcmd As SqlCommand = Nothing

        Try
            objcon = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashic\source\repos\Mini Project\Mini Project\users.mdf;Integrated Security=True")
            objcon.Open()
            Dim stmt As String = "select * from signin where Username ='" & Username.Text & "' AND Password ='" & Password.Text & "' "
            objcmd = New SqlCommand(stmt, objcon)
            Dim reader As SqlDataReader = objcmd.ExecuteReader
            If reader.Read Then
                MessageBox.Show("Login successfully")
                Me.Hide()
                Homepage.Show()
            Else
                MessageBox.Show("Invalid Login Please Check!")
                Username.Text = ""
                Password.Text = ""

            End If
        Catch ex As Exception
            MsgBox("MSSQL ERROR")
        End Try
    End Sub


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.BackColor = Color.FromArgb(25, Color.Black)
    End Sub


    'forgot password 
    Private Sub BunifuCustomLabel4_MouseClick(sender As Object, e As MouseEventArgs) Handles BunifuCustomLabel4.MouseClick
        Me.Hide()
        forgotpassword.Show()

    End Sub

    Private Sub BunifuCustomLabel4_MouseEnter(sender As Object, e As EventArgs) Handles BunifuCustomLabel4.MouseEnter
        BunifuCustomLabel4.ForeColor = Color.OrangeRed
    End Sub

    Private Sub BunifuCustomLabel4_MouseLeave(sender As Object, e As EventArgs) Handles BunifuCustomLabel4.MouseLeave
        BunifuCustomLabel4.ForeColor = Color.LightCoral
    End Sub


    'sign up

    Private Sub BunifuCustomLabel6_MouseClick(sender As Object, e As MouseEventArgs) Handles BunifuCustomLabel6.MouseClick
        Me.Hide()
        Sign_up.Show()
    End Sub

    Private Sub BunifuCustomLabel6_MouseEnter(sender As Object, e As EventArgs) Handles BunifuCustomLabel6.MouseEnter
        BunifuCustomLabel6.ForeColor = Color.White
    End Sub

    Private Sub BunifuCustomLabel6_MouseLeave(sender As Object, e As EventArgs) Handles BunifuCustomLabel6.MouseLeave
        BunifuCustomLabel6.ForeColor = Color.LightCoral
    End Sub


    'Admin login
    Private Sub BunifuCustomLabel7_MouseClick(sender As Object, e As MouseEventArgs) Handles BunifuCustomLabel7.MouseClick
        Me.Hide()
        Admin_Login.Show()
    End Sub

    Private Sub BunifuCustomLabel7_MouseEnter(sender As Object, e As EventArgs) Handles BunifuCustomLabel7.MouseEnter
        BunifuCustomLabel7.ForeColor = Color.White
    End Sub

    Private Sub BunifuCustomLabel7_MouseLeave(sender As Object, e As EventArgs) Handles BunifuCustomLabel7.MouseLeave
        BunifuCustomLabel7.ForeColor = Color.LightCoral
    End Sub


    'help
    Private Sub BunifuCustomLabel8_MouseClick(sender As Object, e As MouseEventArgs) Handles BunifuCustomLabel8.MouseClick
        Me.Hide()

    End Sub

    Private Sub BunifuCustomLabel8_MouseEnter(sender As Object, e As EventArgs) Handles BunifuCustomLabel8.MouseEnter
        BunifuCustomLabel8.ForeColor = Color.LightCoral
    End Sub

    Private Sub BunifuCustomLabel8_MouseLeave(sender As Object, e As EventArgs) Handles BunifuCustomLabel8.MouseLeave
        BunifuCustomLabel8.ForeColor = Color.White
    End Sub

    'close
    Private Sub BunifuCustomLabel3_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles BunifuCustomLabel3.MouseDoubleClick
        Application.Exit()
    End Sub

    Private Sub BunifuCustomLabel3_MouseEnter(sender As Object, e As EventArgs) Handles BunifuCustomLabel3.MouseEnter
        BunifuCustomLabel3.ForeColor = Color.OrangeRed
    End Sub

    Private Sub BunifuCustomLabel3_MouseLeave(sender As Object, e As EventArgs) Handles BunifuCustomLabel3.MouseLeave
        BunifuCustomLabel3.ForeColor = Color.LightCoral
    End Sub






    Private Sub Username_Enter(sender As Object, e As EventArgs) Handles Username.Enter
        ' clear the textbox when the textbox get the focus
        Dim uname As String = Username.Text
        If uname.Trim().ToLower() = "username" Or uname.Trim() = "" Then
            Username.Text = ""
            Username.ForeColor = Color.Black
        End If
    End Sub

    Private Sub BunifuUsernameTextbox1_Leave(sender As Object, e As EventArgs) Handles Username.Leave
        ' when the textbox get lost the focus
        Dim username As String = Me.Username.Text
        If username.Trim().ToLower() = "username" Or username.Trim() = "" Then
            Me.Username.Text = "Username"
            Me.Username.ForeColor = Color.DarkGray

        End If
    End Sub

    Private Sub BunifuPasswordTextbox2_Enter(sender As Object, e As EventArgs) Handles Password.Enter
        ' when textbox password has focus
        Dim pass As String = Password.Text
        If pass.Trim().ToLower() = "password" Or pass.Trim() = "" Then
            Password.Text = ""
            Password.ForeColor = Color.Black
            Password.isPassword = True
        End If
    End Sub

    Private Sub BunifuPasswordTextbox2_Leave(sender As Object, e As EventArgs) Handles Password.Leave
        ' when textbox password lost focus
        Dim pass As String = Password.Text
        If pass.Trim().ToLower() = "password" Or pass.Trim() = "" Then
            Password.Text = "Password"
            Password.ForeColor = Color.DarkGray
            Password.isPassword = False
        End If
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Password.isPassword = False
        Else
            Password.isPassword = True
        End If
    End Sub


End Class