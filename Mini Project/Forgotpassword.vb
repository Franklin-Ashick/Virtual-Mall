Imports System.Data.SqlClient
Public Class Forgotpassword
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashic\source\repos\Mini Project\Mini Project\users.mdf;Integrated Security=True"
        If Password.Text <> ConfPassword.Text Then
            MsgBox("Password Does Not Match")
            Password.Text = ""
            ConfPassword.Text = ""
            Exit Sub
        End If

        If Password.Text = " " And ConfPassword.Text = " " Then
            MsgBox("Please Enter Details", MsgBoxStyle.Information, "Data Updation")
            Exit Sub
        End If

        con.Open()
        cmd = New SqlCommand(" update signin set Password ='" & Password.Text & "' WHERE Username ='" & Username.Text & "' ", con)
        cmd.ExecuteNonQuery()
        MsgBox("Password Updated")
        con.Close()
        Me.Close()
        Login.Show()
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

    'user login
    Private Sub BunifuCustomLabel7_MouseClick(sender As Object, e As MouseEventArgs) Handles BunifuCustomLabel7.MouseClick
        Me.Hide()
        Login.Show()
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
        If pass.Trim().ToLower() = "new password" Or pass.Trim() = "" Then
            Password.Text = ""
            Password.ForeColor = Color.Black
            Password.isPassword = True
        End If
    End Sub

    Private Sub BunifuPasswordTextbox2_Leave(sender As Object, e As EventArgs) Handles Password.Leave
        ' when textbox password lost focus
        Dim pass As String = Password.Text
        If pass.Trim().ToLower() = "New Password" Or pass.Trim() = "" Then
            Password.Text = "New Password"
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

    Private Sub Forgotpassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class