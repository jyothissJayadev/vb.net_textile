Imports System.Data.SqlClient

Public Class ProductEdit
    Dim con As SqlConnection = New SqlConnection("Data Source=JYOTHISS\SQLEXPRESS;Initial Catalog=Textile;Integrated Security=True;Encrypt=False")

    Private Sub ProductEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data into DataGridView
        LoadData()

        ' Populate the category ComboBox
        ComboBoxItemCategory.Items.AddRange({"kids", "women", "men", "inners", "shoes"})
        ComboBoxItemCategory.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub LoadData()
        Try
            ' SQL query to retrieve data from itemTable
            Dim query = "SELECT [itemName], [itemCode], [ItemPrice], [ItemCategory] FROM [dbo].[itemTable]"

            ' Create a SqlDataAdapter to fill the DataTable
            Dim adapter As New SqlDataAdapter(query, con)
            Dim dataTable As New DataTable()

            ' Fill the DataTable
            adapter.Fill(dataTable)

            ' Bind the DataTable to the DataGridView
            DataGridViewProducts.DataSource = dataTable

        Catch ex As Exception
            ' Display error message if an exception occurs
            MsgBox("Error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub DataGridViewProducts_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewProducts.SelectionChanged
        ' Update controls when a row is selected
        If DataGridViewProducts.SelectedRows.Count > 0 Then
            Dim selectedRow = DataGridViewProducts.SelectedRows(0)
            TextBoxItemName.Text = selectedRow.Cells("itemName").Value.ToString()
            NumericUpDownItemCode.Value = Convert.ToDecimal(selectedRow.Cells("itemCode").Value)
            NumericUpDownItemPrice.Value = Convert.ToDecimal(selectedRow.Cells("ItemPrice").Value)
            ComboBoxItemCategory.SelectedItem = selectedRow.Cells("ItemCategory").Value.ToString()
        End If
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        ' Check if a row is selected
        If DataGridViewProducts.SelectedRows.Count > 0 Then
            Try
                ' Get the selected row
                Dim selectedRow = DataGridViewProducts.SelectedRows(0)

                ' SQL query to update item details
                Dim query = "UPDATE [dbo].[itemTable] SET [itemName] = @itemName, [ItemPrice] = @itemPrice, [ItemCategory] = @itemCategory WHERE [itemCode] = @itemCode"

                ' Create a SqlCommand with the query and SqlConnection
                Dim cmd As New SqlCommand(query, con)

                ' Add parameters to the SqlCommand
                cmd.Parameters.AddWithValue("@itemName", TextBoxItemName.Text.Trim())
                cmd.Parameters.AddWithValue("@itemCode", NumericUpDownItemCode.Value)
                cmd.Parameters.AddWithValue("@itemPrice", NumericUpDownItemPrice.Value)
                cmd.Parameters.AddWithValue("@itemCategory", ComboBoxItemCategory.SelectedItem.ToString())

                ' Open the connection
                con.Open()

                ' Execute the query
                cmd.ExecuteNonQuery()

                ' Display success message
                MsgBox("Item details updated successfully.")

                ' Reload data into DataGridView
                LoadData()



            Catch ex As Exception
                ' Display error message if an exception occurs
                MsgBox("Error occurred: " & ex.Message)
            Finally
                ' Close the connection in the finally block
                con.Close()
            End Try
        Else
            MsgBox("Please select a row to edit.")
        End If
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        ' Check if a row is selected
        If DataGridViewProducts.SelectedRows.Count > 0 Then
            Try
                ' Get the selected row
                Dim selectedRow = DataGridViewProducts.SelectedRows(0)

                ' Get the itemCode from the selected row
                Dim itemCodeToDelete As String = selectedRow.Cells("itemCode").Value.ToString()

                ' SQL query to delete the selected row from itemTable
                Dim query = "DELETE FROM [dbo].[itemTable] WHERE [itemCode] = @itemCode"

                ' Create a SqlCommand with the query and SqlConnection
                Dim cmd As New SqlCommand(query, con)

                ' Add parameters to the SqlCommand
                cmd.Parameters.AddWithValue("@itemCode", itemCodeToDelete.Trim())

                ' Open the connection
                con.Open()

                ' Execute the query
                cmd.ExecuteNonQuery()

                ' Display success message
                MsgBox("Item deleted successfully.")

                ' Reload data into DataGridView
                LoadData()

            Catch ex As Exception
                ' Display error message if an exception occurs
                MsgBox("Error occurred: " & ex.Message)
            Finally
                ' Close the connection in the finally block
                con.Close()
            End Try
        Else
            MsgBox("Please select a row to delete.")
        End If
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        ' Perform search based on the TextBoxSearch value
        If Not String.IsNullOrWhiteSpace(TextBoxSearch.Text.Trim()) Then
            Dim searchQuery = "SELECT [itemName], [itemCode], [ItemPrice], [ItemCategory] FROM [dbo].[itemTable] WHERE [itemName] LIKE @search OR [itemCode] LIKE @search OR [ItemCategory] LIKE @search"
            Dim adapter As New SqlDataAdapter(searchQuery, con)
            adapter.SelectCommand.Parameters.AddWithValue("@search", "%" & TextBoxSearch.Text.Trim() & "%")

            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            DataGridViewProducts.DataSource = dataTable
        Else
            ' If search TextBox is empty, load all data
            LoadData()
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Application.Exit()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Application.Exit()

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dim employeeForm As New Admin()
        employeeForm.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
