Imports System.Data.SqlClient
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



        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashic\source\repos\Mini Project\Mini Project\Data.mdf;Integrated Security=True"
        Dim objcon As SqlConnection = Nothing
        Dim objcmd As SqlCommand = Nothing

        Try
            objcon = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashic\source\repos\Mini Project\Mini Project\Data.mdf;Integrated Security=True")
            objcon.Open()
            Dim stmt As String = "select * from admin where username ='" & Username.Text & "' AND password ='" & Password.Text & "' "
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

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class