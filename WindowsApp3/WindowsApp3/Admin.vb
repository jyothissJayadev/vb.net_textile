Public Class Admin

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        ' Navigate to ProductAdd form
        Dim productAddForm As New ProductAdd()
        productAddForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        ' Navigate to Register form
        Dim registerForm As New Register()
        registerForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnEditItem_Click(sender As Object, e As EventArgs) Handles btnEditItem.Click
        ' Navigate to ProductEdit form
        Dim productEditForm As New ProductEdit()
        productEditForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Exit the application
        Dim login As New Login()
        login.Show()
        Me.Hide()
    End Sub
End Class
