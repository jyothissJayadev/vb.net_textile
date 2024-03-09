Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Purchase
    Dim con As SqlConnection = New SqlConnection("Data Source=JYOTHISS\SQLEXPRESS;Initial Catalog=Textile;Integrated Security=True;Encrypt=False")
    Dim cartDataGridView As DataGridView

    Public Sub New(dataGridView As DataGridView)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        cartDataGridView = dataGridView
    End Sub

    Private Sub Purchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display the items from the cart in the Purchase form
        DataGridViewPurchase.DataSource = CopyCartToDataTable(cartDataGridView)
    End Sub

    Private Function CopyCartToDataTable(cartDataGridView As DataGridView) As DataTable
        ' Create a new DataTable to store the cart items
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("ItemCode")
        dataTable.Columns.Add("ItemName")
        dataTable.Columns.Add("ItemPrice")

        ' Copy the items from the cart to the DataTable
        For Each row As DataGridViewRow In cartDataGridView.Rows
            If Not row.IsNewRow Then ' Exclude the new row for data entry
                Dim itemCode As String = row.Cells("ItemCodeCart").Value.ToString()
                Dim itemName As String = row.Cells("ItemNameCart").Value.ToString()
                Dim itemPrice As Decimal = Convert.ToDecimal(row.Cells("ItemPriceCart").Value)
                dataTable.Rows.Add(itemCode, itemName, itemPrice)
            End If
        Next

        Return dataTable
    End Function

    Private Sub ButtonConfirmPurchase_Click(sender As Object, e As EventArgs) Handles ButtonConfirmPurchase.Click
        ' Insert the order details into the ordertable
        If InsertOrderDetails(DataGridViewPurchase.DataSource) Then
            MsgBox("Order placed successfully.")
            Me.Close()
        Else
            MsgBox("Error placing the order.")
        End If
    End Sub

    Private Function InsertOrderDetails(orderItems As Object) As Boolean
        Try
            ' Open the connection
            con.Open()

            ' Create a SqlDataAdapter to update the database
            Dim adapter As New SqlDataAdapter()

            ' Define the Insert command with parameters
            adapter.InsertCommand = New SqlCommand("INSERT INTO [dbo].[ordertable] ([ItemCode], [ItemName], [ItemPrice]) VALUES (@ItemCode, @ItemName, @ItemPrice)", con)
            adapter.InsertCommand.Parameters.Add("@ItemCode", SqlDbType.VarChar, 50, "ItemCode")
            adapter.InsertCommand.Parameters.Add("@ItemName", SqlDbType.VarChar, 255, "ItemName")
            adapter.InsertCommand.Parameters.Add("@ItemPrice", SqlDbType.Decimal, 18, "ItemPrice")

            ' Create a DataTable for the order items
            Dim orderTable As DataTable = TryCast(orderItems, DataTable)

            ' Update the database with the order items
            adapter.Update(orderTable)

            Return True
        Catch ex As Exception
            MsgBox("Error occurred: " & ex.Message)
            Return False
        Finally
            ' Close the connection
            con.Close()
        End Try
    End Function

    Private Sub ButtonCancelPurchase_Click(sender As Object, e As EventArgs) Handles ButtonCancelPurchase.Click
        Me.Close()
    End Sub
End Class
