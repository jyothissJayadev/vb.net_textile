Imports System.Data.SqlClient

Public Class Employee
    Dim con As SqlConnection = New SqlConnection("Data Source=JYOTHISS\SQLEXPRESS;Initial Catalog=Textile;Integrated Security=True;Encrypt=False")

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load items into the first DataGridView
        LoadItems()
        DataGridViewCart.DefaultCellStyle.ForeColor = Color.Black
        DataGridViewItems.DefaultCellStyle.ForeColor = Color.Black
        ' Set up columns for the DataGridViewCart
        DataGridViewCart.Columns.Add("ItemCodeCart", "Item Code")
        DataGridViewCart.Columns.Add("ItemNameCart", "Item Name")
        DataGridViewCart.Columns.Add("ItemPriceCart", "Item Price")
    End Sub

    Private Sub LoadItems()
        Try
            ' SQL query to retrieve data from itemTable
            Dim query = "SELECT [itemCode], [itemName], [ItemPrice] FROM [dbo].[itemTable]"

            ' Create a SqlDataAdapter to fill the DataTable
            Dim adapter As New SqlDataAdapter(query, con)
            Dim dataTable As New DataTable()

            ' Fill the DataTable
            adapter.Fill(dataTable)

            ' Bind the DataTable to the first DataGridView
            DataGridViewItems.DataSource = dataTable

            ' Set AutoGenerateColumns to True
            DataGridViewItems.AutoGenerateColumns = True

        Catch ex As Exception
            ' Display error message if an exception occurs
            MsgBox("Error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub ButtonAddToCart_Click(sender As Object, e As EventArgs) Handles ButtonAddToCart.Click
        ' Check if a row is selected in the first DataGridView
        If DataGridViewItems.SelectedRows.Count > 0 Then
            ' Get the selected item details
            Dim selectedRow = DataGridViewItems.SelectedRows(0)
            Dim itemCode As String = selectedRow.Cells("itemCode").Value.ToString()
            Dim itemName As String = selectedRow.Cells("itemName").Value.ToString()
            Dim itemPrice As Decimal = Convert.ToDecimal(selectedRow.Cells("ItemPrice").Value)

            ' Add the selected item to the cart (second DataGridView)
            DataGridViewCart.Rows.Add(itemCode, itemName, itemPrice)

            ' Update labels
            LabelItemCount.Text = "" & (DataGridViewCart.Rows.Count - 1).ToString()
            LabelTotalPrice.Text = "" & CalculateTotalPrice().ToString("F2")
        Else
            MsgBox("Please select an item to add to the cart.")
        End If
    End Sub

    Private Function CalculateTotalPrice() As Decimal
        ' Calculate the total price of items in the cart
        Dim totalPrice As Decimal = 0

        For Each row As DataGridViewRow In DataGridViewCart.Rows
            totalPrice += Convert.ToDecimal(row.Cells("ItemPriceCart").Value)
        Next

        Return totalPrice
    End Function

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        ' Perform search based on the TextBoxSearch value
        If Not String.IsNullOrWhiteSpace(TextBoxSearch.Text.Trim()) Then
            Dim searchQuery = "SELECT [itemCode], [itemName], [ItemPrice] FROM [dbo].[itemTable] WHERE [itemName] LIKE @search OR [itemCode] LIKE @search"
            Dim adapter As New SqlDataAdapter(searchQuery, con)
            adapter.SelectCommand.Parameters.AddWithValue("@search", "%" & TextBoxSearch.Text.Trim() & "%")

            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            DataGridViewItems.DataSource = dataTable
        Else
            ' If search TextBox is empty, load all data
            LoadItems()
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Application.Exit()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Check if there are items in the cart
        If DataGridViewCart.Rows.Count > 1 Then ' Rows.Count > 1 to account for header
            ' Open the Purchase form
            Dim purchaseForm As New Purchase(DataGridViewCart)
            purchaseForm.ShowDialog()

            ' Clear the cart after the purchase is completed
            DataGridViewCart.Rows.Clear()
            LabelItemCount.Text = "0"
            LabelTotalPrice.Text = "0.00"
        Else
            MsgBox("The cart is empty. Please add items before making a purchase.")
        End If
    End Sub
End Class
