<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Purchase
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridViewPurchase = New System.Windows.Forms.DataGridView()
        Me.ButtonConfirmPurchase = New System.Windows.Forms.Button()
        Me.ButtonCancelPurchase = New System.Windows.Forms.Button()
        CType(Me.DataGridViewPurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewPurchase
        '
        Me.DataGridViewPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPurchase.Location = New System.Drawing.Point(251, 112)
        Me.DataGridViewPurchase.Name = "DataGridViewPurchase"
        Me.DataGridViewPurchase.RowHeadersWidth = 51
        Me.DataGridViewPurchase.RowTemplate.Height = 24
        Me.DataGridViewPurchase.Size = New System.Drawing.Size(506, 289)
        Me.DataGridViewPurchase.TabIndex = 0
        '
        'ButtonConfirmPurchase
        '
        Me.ButtonConfirmPurchase.Location = New System.Drawing.Point(327, 504)
        Me.ButtonConfirmPurchase.Name = "ButtonConfirmPurchase"
        Me.ButtonConfirmPurchase.Size = New System.Drawing.Size(75, 23)
        Me.ButtonConfirmPurchase.TabIndex = 4
        Me.ButtonConfirmPurchase.Text = "purchase"
        Me.ButtonConfirmPurchase.UseVisualStyleBackColor = True
        '
        'ButtonCancelPurchase
        '
        Me.ButtonCancelPurchase.Location = New System.Drawing.Point(665, 504)
        Me.ButtonCancelPurchase.Name = "ButtonCancelPurchase"
        Me.ButtonCancelPurchase.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancelPurchase.TabIndex = 5
        Me.ButtonCancelPurchase.Text = "Cancel"
        Me.ButtonCancelPurchase.UseVisualStyleBackColor = True
        '
        'Purchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 602)
        Me.Controls.Add(Me.ButtonCancelPurchase)
        Me.Controls.Add(Me.ButtonConfirmPurchase)
        Me.Controls.Add(Me.DataGridViewPurchase)
        Me.Name = "Purchase"
        Me.Text = "Purchase"
        CType(Me.DataGridViewPurchase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewPurchase As DataGridView
    Friend WithEvents ButtonConfirmPurchase As Button
    Friend WithEvents ButtonCancelPurchase As Button
End Class
