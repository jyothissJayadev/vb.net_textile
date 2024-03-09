<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridViewCart = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridViewItems = New System.Windows.Forms.DataGridView()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonAddToCart = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelItemCount = New System.Windows.Forms.Label()
        Me.LabelTotalPrice = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridViewCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridViewItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewCart
        '
        Me.DataGridViewCart.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCart.Location = New System.Drawing.Point(636, 104)
        Me.DataGridViewCart.Name = "DataGridViewCart"
        Me.DataGridViewCart.RowHeadersWidth = 51
        Me.DataGridViewCart.RowTemplate.Height = 24
        Me.DataGridViewCart.Size = New System.Drawing.Size(664, 372)
        Me.DataGridViewCart.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Stencil", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 39)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "TOTAL:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Stencil", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 33)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ITEMS :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1312, 98)
        Me.Panel2.TabIndex = 6
        '
        'DataGridViewItems
        '
        Me.DataGridViewItems.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewItems.GridColor = System.Drawing.Color.Black
        Me.DataGridViewItems.Location = New System.Drawing.Point(-2, 328)
        Me.DataGridViewItems.Name = "DataGridViewItems"
        Me.DataGridViewItems.RowHeadersWidth = 51
        Me.DataGridViewItems.RowTemplate.Height = 24
        Me.DataGridViewItems.Size = New System.Drawing.Size(625, 433)
        Me.DataGridViewItems.TabIndex = 2
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.Location = New System.Drawing.Point(63, 212)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(216, 38)
        Me.TextBoxSearch.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(72, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Search"
        '
        'ButtonAddToCart
        '
        Me.ButtonAddToCart.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.ButtonAddToCart.Font = New System.Drawing.Font("Showcard Gothic", 13.8!)
        Me.ButtonAddToCart.Location = New System.Drawing.Point(427, 193)
        Me.ButtonAddToCart.Name = "ButtonAddToCart"
        Me.ButtonAddToCart.Size = New System.Drawing.Size(163, 64)
        Me.ButtonAddToCart.TabIndex = 5
        Me.ButtonAddToCart.Text = "ADD"
        Me.ButtonAddToCart.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.DataGridViewItems)
        Me.Panel1.Controls.Add(Me.ButtonAddToCart)
        Me.Panel1.Controls.Add(Me.TextBoxSearch)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(630, 763)
        Me.Panel1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Perpetua Titling MT", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(1261, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(10)
        Me.Label6.Size = New System.Drawing.Size(51, 48)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "X"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelTotalPrice, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelItemCount, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(676, 499)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(20)
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(372, 142)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'LabelItemCount
        '
        Me.LabelItemCount.AutoSize = True
        Me.LabelItemCount.BackColor = System.Drawing.Color.Transparent
        Me.LabelItemCount.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelItemCount.Location = New System.Drawing.Point(189, 20)
        Me.LabelItemCount.Name = "LabelItemCount"
        Me.LabelItemCount.Size = New System.Drawing.Size(21, 24)
        Me.LabelItemCount.TabIndex = 5
        Me.LabelItemCount.Text = "0"
        Me.LabelItemCount.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'LabelTotalPrice
        '
        Me.LabelTotalPrice.AutoSize = True
        Me.LabelTotalPrice.BackColor = System.Drawing.Color.Transparent
        Me.LabelTotalPrice.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Italic)
        Me.LabelTotalPrice.Location = New System.Drawing.Point(189, 71)
        Me.LabelTotalPrice.Name = "LabelTotalPrice"
        Me.LabelTotalPrice.Size = New System.Drawing.Size(38, 24)
        Me.LabelTotalPrice.TabIndex = 6
        Me.LabelTotalPrice.Text = "0.0"
        Me.LabelTotalPrice.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Stencil", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(507, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(371, 51)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "billing System"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Showcard Gothic", 13.8!)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(706, 678)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(535, 64)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "purchase"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp3.My.Resources.Resources.cart
        Me.PictureBox1.Location = New System.Drawing.Point(1115, 514)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1312, 763)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridViewCart)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Employee"
        Me.Text = "Employee"
        CType(Me.DataGridViewCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridViewItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewCart As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridViewItems As DataGridView
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonAddToCart As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LabelTotalPrice As Label
    Friend WithEvents LabelItemCount As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
End Class
