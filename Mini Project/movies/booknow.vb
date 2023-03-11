Imports System.Data.SqlClient
Public Class booknow
    Dim price As Integer
    Dim x As Integer
    Dim b As Integer
    Dim con As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim com As SqlCommand
    Dim ds As New DataSet
    Dim dr As SqlDataReader
    Dim dt As DataTable
    Dim dv As DataView
    Dim str As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Or ComboBox3.Text = "" Then
            MsgBox("Please Fill All the fields")
        End If
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashic\source\repos\Mini Project\Mini Project\Data.mdf;Integrated Security=True")
        con.Open()
        str = "Insert Into booking (Booking_name,Phone,Movie,Seat_Type,Food,show_time,Total_Bill) Values ('" & TextBox1.ToString & "','" & TextBox2.ToString & "','" & ComboBox1.ToString & "','" & ComboBox2.ToString & "','" & ComboBox3.ToString & "','" & Text.ToString & "','" & DateTimePicker1.ToString & "', '" & TextBox6.ToString & "')"
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        MsgBox("Booking Successfull. Please Reach 45 min. Before Showtime & Pay At the theatre")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        DateTimePicker1.Text = ""
        TextBox6.Text = ""
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Doctor Strange In The Multiverse Of Madness" Then
            price = 300
            ' TextBox6.Text = price
        ElseIf ComboBox1.SelectedItem = "RRR" Then
            price = 350
            '  TextBox6.Text = price
        ElseIf ComboBox1.SelectedItem = "KGF 2" Then
            price = 400
            ' TextBox6.Text = price
        ElseIf ComboBox1.SelectedItem = "Beast" Then
            price = 150
            '   TextBox6.Text = price
        ElseIf ComboBox1.SelectedItem = "The Batman" Then
            price = 200
            '  TextBox6.Text = price
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedItem = "Front Area" Then
            x = price + 150
            ' TextBox6.Text = x
        ElseIf ComboBox2.SelectedItem = " Back Area " Then
            x = price + 100
            '   TextBox6.Text = x
        ElseIf ComboBox2.SelectedItem = "Corner" Then
            x = price + 200
            ' TextBox6.Text = x
        ElseIf ComboBox2.SelectedItem = "Balcony" Then
            x = price + 170
            ' TextBox6.Text = x
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.SelectedItem = "Popcorn" Then
            b = x + 80
            '   TextBox6.Text = b
        ElseIf ComboBox3.SelectedItem = "Coke" Then
            b = x + 40
            '   TextBox6.Text = b
        ElseIf ComboBox3.SelectedItem = "Chips" Then
            b = x + 30
            '    TextBox6.Text = b

        ElseIf ComboBox3.SelectedItem = "Hot Dog" Then
            b = x + 200


        End If

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        TextBox6.Text = b
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Me.Hide()
        homme.Show()

    End Sub
End Class