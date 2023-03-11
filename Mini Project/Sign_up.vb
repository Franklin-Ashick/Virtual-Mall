Imports System.Data.SqlClient

Public Class Sign_up
    Private Sub register_Click(sender As Object, e As EventArgs) Handles register.Click
        If Password.Text <> ConfPassword.Text Then
            MsgBox("Password Does Not Match")
            Password.Text = ""
            ConfPassword.Text = ""
            Exit Sub

        End If

        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader
            con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashic\source\repos\Mini Project\Mini Project\users.mdf;Integrated Security=True"
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from signin where Phnumber='" & PhNumber.Text & "'  AND Username='" & Username.Text & "' "
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MsgBox("Number Already Registered", MsgBoxStyle.Critical)
                con.Close()
            Else
                con.Close()
                con.Open()
                cmd = New SqlCommand("INSERT INTO signin values('" & fname.Text & "','" & PhNumber.Text & "','" & Username.Text & "','" & Password.Text & "')", con)
                If (fname.Text = "" And PhNumber.Text = "" And Username.Text = "" And Password.Text = "" And ConfPassword.Text = "") Then
                    MessageBox.Show("Please enter the details")
                Else
                    cmd.ExecuteNonQuery()
                    MsgBox("Succerssfully Registered.", MsgBoxStyle.Information, "Success")
                    Me.Hide()
                    Login.Show()
                    fname.Text = ""
                    PhNumber.Text = ""
                    Username.Text = ""
                    Password.Text = ""
                    ConfPassword.Text = ""
                End If
                con.Close()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Error")
        End Try

    End Sub
    Private Sub Sign_up_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.BackColor = Color.FromArgb(25, Color.Black)
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



    Private Sub BunifuNameTextbox2_Enter(sender As Object, e As EventArgs) Handles fname.Enter
        ' clear the textbox when the textbox get the focus
        Dim name As String = fname.Text
        If name.Trim().ToLower() = "name" Or name.Trim() = "" Then
            fname.Text = ""
            fname.ForeColor = Color.Black
        End If
    End Sub

    Private Sub BunifuNameTextbox2_Leave(sender As Object, e As EventArgs) Handles fname.Leave
        ' when the textbox get lost the focus
        Dim name As String = fname.Text
        If name.Trim().ToLower() = "Name" Or name.Trim() = "" Then
            fname.Text = "Name"
            fname.ForeColor = Color.DarkGray

        End If
    End Sub



    Private Sub BunifuPhNumberlTextbox3_Enter(sender As Object, e As EventArgs) Handles PhNumber.Enter
        ' clear the textbox when the textbox get the focus
        Dim name As String = PhNumber.Text
        If name.Trim().ToLower() = "phone number" Or name.Trim() = "" Then
            PhNumber.Text = ""
            PhNumber.ForeColor = Color.Black
        End If
    End Sub

    Private Sub BunifuPhNumberlTextbox3_Leave(sender As Object, e As EventArgs) Handles PhNumber.Leave
        ' when the textbox get lost the focus
        Dim Name As String = PhNumber.Text
        If Name.Trim().ToLower() = "phone number" Or Name.Trim() = "" Then
            PhNumber.Text = "Phone Number"
            PhNumber.ForeColor = Color.DarkGray

        End If
    End Sub
    Private Sub BunifuUsernameTextbox1_Enter(sender As Object, e As EventArgs) Handles Username.Enter
        ' clear the textbox when the textbox get the focus
        Dim username As String = Me.Username.Text
        If username.Trim().ToLower() = "username" Or username.Trim() = "" Then
            Me.Username.Text = ""
            Me.Username.ForeColor = Color.Black
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

    Private Sub BunifuConfPasswordTextbox1_Enter(sender As Object, e As EventArgs) Handles ConfPassword.Enter
        ' when textbox password has focus
        Dim pass As String = ConfPassword.Text
        If pass.Trim().ToLower() = "confirm password" Or pass.Trim() = "" Then
            ConfPassword.Text = ""
            ConfPassword.ForeColor = Color.Black
            ConfPassword.isPassword = True
        End If
    End Sub

    Private Sub BunifuConfPasswordTextbox1_Leave(sender As Object, e As EventArgs) Handles ConfPassword.Leave
        ' when textbox password lost focus
        Dim pass As String = ConfPassword.Text
        If pass.Trim().ToLower() = "Confirm Password" Or pass.Trim() = "" Then
            ConfPassword.Text = "Confirm Password"
            ConfPassword.ForeColor = Color.DarkGray
            ConfPassword.isPassword = False
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Password.isPassword = False
            ConfPassword.isPassword = False
        Else
            Password.isPassword = True
            ConfPassword.isPassword = True
        End If
    End Sub


    'Admin login
    Private Sub BunifuCustomLabel7_MouseClick(sender As Object, e As MouseEventArgs) Handles BunifuCustomLabel7.MouseClick
        Me.Hide()
        Admin_login.Show()
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
        help.Show()
    End Sub

    Private Sub BunifuCustomLabel8_MouseEnter(sender As Object, e As EventArgs) Handles BunifuCustomLabel8.MouseEnter
        BunifuCustomLabel8.ForeColor = Color.LightCoral
    End Sub

    Private Sub BunifuCustomLabel8_MouseLeave(sender As Object, e As EventArgs) Handles BunifuCustomLabel8.MouseLeave
        BunifuCustomLabel8.ForeColor = Color.White
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BunifuCustomLabel3_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel3.Click

    End Sub
End Class