Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class SignUpForm

    Private Sub chkpass_CheckedChanged(sender As Object, e As EventArgs) Handles chkpass.CheckedChanged
        If chkpass.Checked = True Then
            txtpassS.UseSystemPasswordChar = False
        Else
            txtpassS.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub SignUp_Click(sender As Object, e As EventArgs) Handles SignUp.Click
        Dim name As String = txtname.Text
        Dim username As String = txtusernameS.Text
        Dim contact As Single = txtC_number.Text
        Dim password As String = txtpassS.Text


        Dim query As String = $"INSERT INTO customertable1 (customer_name, customer_username, customer_number, customer_password) VALUES (@customer_name, @customer_username, @customer_number, @customer_password)"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@customer_name", name)
        cmd.Parameters.AddWithValue("@customer_username", username)
        cmd.Parameters.AddWithValue("@customer_number", contact)
        cmd.Parameters.AddWithValue("@customer_password", password)


        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Registration successful!")
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub close_form(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub
End Class
