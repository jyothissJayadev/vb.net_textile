Imports System.Data.SqlClient

Public Class ProductAdd
    Dim con As SqlConnection = New SqlConnection("Data Source=JYOTHISS\SQLEXPRESS;Initial Catalog=Textile;Integrated Security=True;Encrypt=False")

    Private Sub ButtonAddItem_Click(sender As Object, e As EventArgs) Handles ButtonAddItem.Click
        ' Check if all fields are filled
        If String.IsNullOrWhiteSpace(TextBoxItemName.Text) OrElse
           NumericUpDownItemCode.Value = 0 OrElse
           NumericUpDownItemPrice.Value = 0 OrElse
           String.IsNullOrWhiteSpace(ComboBoxItemCategory.Text) Then
            MsgBox("All fields are mandatory. Please fill in all the information.")
            Return
        End If

        Try
            ' Check if the itemCode already exists
            If ItemCodeExists(NumericUpDownItemCode.Value.ToString()) Then
                MsgBox("Item with this ItemCode already exists. Please provide a unique ItemCode.")
                Return
            End If

            ' SQL query for adding an item with an identity column 'id'
            Dim query = "INSERT INTO [dbo].[itemTable] ([itemName], [itemCode], [ItemPrice], [ItemCategory]) VALUES (@itemName, @itemCode, @itemPrice, @itemCategory)"

            ' Create a SqlCommand with the query and SqlConnection
            Dim cmd As New SqlCommand(query, con)

            ' Add parameters to the SqlCommand
            cmd.Parameters.AddWithValue("@itemName", TextBoxItemName.Text)
            cmd.Parameters.AddWithValue("@itemCode", NumericUpDownItemCode.Value.ToString())
            cmd.Parameters.AddWithValue("@itemPrice", NumericUpDownItemPrice.Value)
            cmd.Parameters.AddWithValue("@itemCategory", ComboBoxItemCategory.Text)

            ' Open the connection
            con.Open()

            ' Execute the query
            cmd.ExecuteNonQuery()

            ' Display success message
            MsgBox("Item added successfully.")

        Catch ex As Exception
            ' Display error message if an exception occurs
            MsgBox("Error occurred: " & ex.Message)
        Finally
            ' Close the connection in the finally block
            con.Close()
        End Try
    End Sub

    Private Sub ButtonGoBack_Click(sender As Object, e As EventArgs) Handles ButtonGoBack.Click
        ' Go back to the admin form (assuming the admin form is named "Admin")
        Dim adminForm As New Admin()
        adminForm.Show()
        Me.Hide()
    End Sub

    ' Function to check if the itemCode already exists in the database
    Private Function ItemCodeExists(itemCode As String) As Boolean
        Dim query = "SELECT COUNT(*) FROM [dbo].[itemTable] WHERE [itemCode] = @itemCode"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@itemCode", itemCode)

        con.Open()
        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        con.Close()

        Return count > 0
    End Function

    ' Populate the ComboBox with item categories
    Private Sub ProductAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxItemCategory.Items.AddRange({"kids", "women", "men", "innners", "shoes"})
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Application.Exit()

    End Sub
End Class
