Imports System.Data.SqlClient

Public Class Register

    Dim con As SqlConnection = New SqlConnection("Data Source=JYOTHISS\SQLEXPRESS;Initial Catalog=Textile;Integrated Security=True;Encrypt=False")

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' Populate the role ComboBox with values "Admin" and "Employee"
        ComboBoxRole.Items.Add("Admin")
        ComboBoxRole.Items.Add("Employee")
    End Sub

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        Try
            ' Check if passwords match
            If TextBoxPassword.Text <> TextBoxConfirmPassword.Text Then
                MsgBox("Passwords do not match.")
                Return
            End If

            ' SQL query for registration
            Dim Query = "INSERT INTO [dbo].[register_table] ([name], [email], [password], [role]) VALUES(@name, @email, @password, @role)"

            ' Create a SqlCommand with the query and SqlConnection
            Dim cmd As New SqlCommand(Query, con)

            ' Add parameters to the SqlCommand
            cmd.Parameters.AddWithValue("@name", TextBoxName.Text)
            cmd.Parameters.AddWithValue("@email", TextBoxEmail.Text)
            cmd.Parameters.AddWithValue("@password", TextBoxPassword.Text)
            cmd.Parameters.AddWithValue("@role", ComboBoxRole.SelectedItem)

            ' Open the connection
            con.Open()

            ' Execute the query
            cmd.ExecuteNonQuery()

            ' Display success message
            MsgBox("Registration successful. Redirecting to login page.")

            ' Redirect to the login page (assuming the login form is named "Login")
            Dim loginForm As New Login()
            loginForm.Show()
            Me.Hide()

        Catch ex As Exception
            ' Display error message if an exception occurs
            MsgBox("Error occurred: " & ex.Message)
        Finally
            ' Close the connection in the finally block
            con.Close()
        End Try
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Application.Exit()

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Label1.BackColor = Color.Transparent
    End Sub

    Private Sub TextBoxPassword_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPassword.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim employeeForm As New Admin()
        employeeForm.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.BackColor = Color.Transparent
    End Sub
End Class
