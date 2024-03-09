<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnAddEmployee = New System.Windows.Forms.Button()
        Me.btnEditItem = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnAddItem.Font = New System.Drawing.Font("Showcard Gothic", 13.8!)
        Me.btnAddItem.Location = New System.Drawing.Point(100, 37)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(276, 58)
        Me.btnAddItem.TabIndex = 0
        Me.btnAddItem.Text = "Add Product"
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'btnAddEmployee
        '
        Me.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.btnAddEmployee.Font = New System.Drawing.Font("Showcard Gothic", 13.8!)
        Me.btnAddEmployee.Location = New System.Drawing.Point(100, 152)
        Me.btnAddEmployee.Name = "btnAddEmployee"
        Me.btnAddEmployee.Size = New System.Drawing.Size(276, 55)
        Me.btnAddEmployee.TabIndex = 1
        Me.btnAddEmployee.Text = "Add Employee"
        Me.btnAddEmployee.UseVisualStyleBackColor = False
        '
        'btnEditItem
        '
        Me.btnEditItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnEditItem.Font = New System.Drawing.Font("Showcard Gothic", 13.8!)
        Me.btnEditItem.Location = New System.Drawing.Point(100, 274)
        Me.btnEditItem.Name = "btnEditItem"
        Me.btnEditItem.Size = New System.Drawing.Size(276, 60)
        Me.btnEditItem.TabIndex = 2
        Me.btnEditItem.Text = "Edit Product"
        Me.btnEditItem.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.btnLogout.Font = New System.Drawing.Font("Showcard Gothic", 13.8!)
        Me.btnLogout.Location = New System.Drawing.Point(100, 398)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(276, 57)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "LogOut"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnAddItem)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btnAddEmployee)
        Me.Panel1.Controls.Add(Me.btnEditItem)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(240, 172)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(465, 487)
        Me.Panel1.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Stencil", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(323, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(298, 51)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "AdminPanel"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(955, 717)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnAddEmployee As Button
    Friend WithEvents btnEditItem As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
End Class
