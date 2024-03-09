Imports System.Data.SqlClient

Public Class Login

    Dim con As SqlConnection = New SqlConnection("Data Source=JYOTHISS\SQLEXPRESS;Initial Catalog=Textile;Integrated Security=True;Encrypt=False")

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Try
            ' SQL query to check if the user exists with the provided credentials and role
            Dim query = "SELECT [role] FROM [dbo].[register_table] WHERE [name] = @name AND [password] = @password AND [role] = @role"

            ' Create a SqlCommand with the query and SqlConnection
            Dim cmd As New SqlCommand(query, con)

            ' Add parameters to the SqlCommand
            cmd.Parameters.AddWithValue("@name", TextBoxName.Text)
            cmd.Parameters.AddWithValue("@password", TextBoxPassword.Text)
            cmd.Parameters.AddWithValue("@role", ComboBoxRole.SelectedItem)

            ' Open the connection
            con.Open()

            ' Execute the query and get the role
            Dim role As Object = cmd.ExecuteScalar()

            ' Check if the user exists and has the correct role
            If role IsNot Nothing Then
                MsgBox("Login successful. Redirecting to " & role.ToString() & " Page.")

                ' Redirect based on the role
                Select Case role.ToString().Trim()
                    Case "Admin"
                        ' Redirect to admin page (replace "AdminPage" with your actual admin page name)
                        Dim adminForm As New Admin()
                        adminForm.Show()
                        Me.Hide()
                    Case "Employee"
                        ' Redirect to employee page (replace "EmployeePage" with your actual employee page name)
                        Dim employeeForm As New Employee()
                        employeeForm.Show()
                        Me.Hide()
                    Case Else
                        MsgBox(role)

                End Select
            Else
                MsgBox("Invalid credentials or role. Please check your name, password, and role.")

            End If

        Catch ex As Exception
            ' Display error message if an exception occurs
            MsgBox("Error occurred: " & ex.Message)
        Finally
            ' Close the connection in the finally block
            con.Close()
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBoxPassword_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPassword.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Application.Exit()
    End Sub
End Class
