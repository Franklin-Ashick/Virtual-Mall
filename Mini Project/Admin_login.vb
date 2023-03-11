Public Class Admin_Login
    Private Sub Admin_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.BackColor = Color.FromArgb(25, Color.Black)
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


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Password.isPassword = False
        Else
            Password.isPassword = True
        End If
    End Sub

    Private Sub BunifuCustomLabel3_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel3.Click

    End Sub

    Private Sub loginn_Click(sender As Object, e As EventArgs) Handles loginn.Click

    End Sub
End Class