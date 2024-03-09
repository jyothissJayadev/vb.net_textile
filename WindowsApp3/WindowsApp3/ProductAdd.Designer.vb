<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductAdd
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
        Me.TextBoxItemName = New System.Windows.Forms.TextBox()
        Me.ButtonAddItem = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ButtonGoBack = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBoxItemCategory = New System.Windows.Forms.ComboBox()
        Me.NumericUpDownItemCode = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownItemPrice = New System.Windows.Forms.NumericUpDown()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.NumericUpDownItemCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownItemPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxItemName
        '
        Me.TextBoxItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!)
        Me.TextBoxItemName.Location = New System.Drawing.Point(82, 184)
        Me.TextBoxItemName.Name = "TextBoxItemName"
        Me.TextBoxItemName.Size = New System.Drawing.Size(255, 38)
        Me.TextBoxItemName.TabIndex = 1
        '
        'ButtonAddItem
        '
        Me.ButtonAddItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ButtonAddItem.Font = New System.Drawing.Font("Showcard Gothic", 13.8!)
        Me.ButtonAddItem.ForeColor = System.Drawing.Color.White
        Me.ButtonAddItem.Location = New System.Drawing.Point(44, 469)
        Me.ButtonAddItem.Name = "ButtonAddItem"
        Me.ButtonAddItem.Size = New System.Drawing.Size(330, 54)
        Me.ButtonAddItem.TabIndex = 8
        Me.ButtonAddItem.Text = "ADD ITEM"
        Me.ButtonAddItem.UseVisualStyleBackColor = False
        '
        'ButtonGoBack
        '
        Me.ButtonGoBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ButtonGoBack.Font = New System.Drawing.Font("Showcard Gothic", 13.8!)
        Me.ButtonGoBack.ForeColor = System.Drawing.Color.White
        Me.ButtonGoBack.Location = New System.Drawing.Point(44, 549)
        Me.ButtonGoBack.Name = "ButtonGoBack"
        Me.ButtonGoBack.Size = New System.Drawing.Size(330, 46)
        Me.ButtonGoBack.TabIndex = 9
        Me.ButtonGoBack.Text = "Back"
        Me.ButtonGoBack.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(558, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(583, 682)
        Me.Panel1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Perpetua Titling MT", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(529, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(10)
        Me.Label2.Size = New System.Drawing.Size(51, 48)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Stencil", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(165, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 53)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Add Item"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp3.My.Resources.Resources.additem
        Me.PictureBox1.Location = New System.Drawing.Point(92, 136)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(439, 437)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.NumericUpDownItemPrice)
        Me.Panel2.Controls.Add(Me.NumericUpDownItemCode)
        Me.Panel2.Controls.Add(Me.ComboBoxItemCategory)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.ButtonGoBack)
        Me.Panel2.Controls.Add(Me.TextBoxItemName)
        Me.Panel2.Controls.Add(Me.ButtonAddItem)
        Me.Panel2.Location = New System.Drawing.Point(62, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(435, 615)
        Me.Panel2.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(78, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 22)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "ItemCode"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(79, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 22)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "ItemName"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(80, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 22)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "ItemPrice"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(80, 373)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 22)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "ItemCategory"
        '
        'ComboBoxItemCategory
        '
        Me.ComboBoxItemCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxItemCategory.FormattingEnabled = True
        Me.ComboBoxItemCategory.Location = New System.Drawing.Point(82, 398)
        Me.ComboBoxItemCategory.Name = "ComboBoxItemCategory"
        Me.ComboBoxItemCategory.Size = New System.Drawing.Size(255, 39)
        Me.ComboBoxItemCategory.TabIndex = 16
        '
        'NumericUpDownItemCode
        '
        Me.NumericUpDownItemCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownItemCode.Location = New System.Drawing.Point(83, 88)
        Me.NumericUpDownItemCode.Name = "NumericUpDownItemCode"
        Me.NumericUpDownItemCode.Size = New System.Drawing.Size(254, 38)
        Me.NumericUpDownItemCode.TabIndex = 17
        Me.NumericUpDownItemCode.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'NumericUpDownItemPrice
        '
        Me.NumericUpDownItemPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownItemPrice.Location = New System.Drawing.Point(83, 295)
        Me.NumericUpDownItemPrice.Name = "NumericUpDownItemPrice"
        Me.NumericUpDownItemPrice.Size = New System.Drawing.Size(254, 38)
        Me.NumericUpDownItemPrice.TabIndex = 18
        Me.NumericUpDownItemPrice.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'ProductAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1141, 682)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProductAdd"
        Me.Text = "ProductAdd"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.NumericUpDownItemCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownItemPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBoxItemName As TextBox
    Friend WithEvents ButtonAddItem As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ButtonGoBack As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxItemCategory As ComboBox
    Friend WithEvents NumericUpDownItemPrice As NumericUpDown
    Friend WithEvents NumericUpDownItemCode As NumericUpDown
End Class
