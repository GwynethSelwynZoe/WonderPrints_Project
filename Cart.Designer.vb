<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cart
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
        Me.DGCart = New System.Windows.Forms.DataGridView()
        Me.ids = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namess = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.typess = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pricess = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantitys = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.withtax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totals = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CartCheckOut = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.receipt = New System.Windows.Forms.RichTextBox()
        CType(Me.DGCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGCart
        '
        Me.DGCart.AllowUserToAddRows = False
        Me.DGCart.AllowUserToDeleteRows = False
        Me.DGCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGCart.BackgroundColor = System.Drawing.Color.Thistle
        Me.DGCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGCart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ids, Me.namess, Me.typess, Me.pricess, Me.quantitys, Me.withtax, Me.totals})
        Me.DGCart.GridColor = System.Drawing.Color.DarkViolet
        Me.DGCart.Location = New System.Drawing.Point(68, 22)
        Me.DGCart.Margin = New System.Windows.Forms.Padding(2)
        Me.DGCart.Name = "DGCart"
        Me.DGCart.ReadOnly = True
        Me.DGCart.RowHeadersWidth = 51
        Me.DGCart.RowTemplate.Height = 24
        Me.DGCart.Size = New System.Drawing.Size(654, 186)
        Me.DGCart.TabIndex = 0
        '
        'ids
        '
        Me.ids.HeaderText = "Product ID"
        Me.ids.MinimumWidth = 6
        Me.ids.Name = "ids"
        Me.ids.ReadOnly = True
        '
        'namess
        '
        Me.namess.HeaderText = "Product Name"
        Me.namess.MinimumWidth = 6
        Me.namess.Name = "namess"
        Me.namess.ReadOnly = True
        '
        'typess
        '
        Me.typess.HeaderText = "Type of Product"
        Me.typess.MinimumWidth = 6
        Me.typess.Name = "typess"
        Me.typess.ReadOnly = True
        '
        'pricess
        '
        Me.pricess.HeaderText = "Price"
        Me.pricess.MinimumWidth = 6
        Me.pricess.Name = "pricess"
        Me.pricess.ReadOnly = True
        '
        'quantitys
        '
        Me.quantitys.HeaderText = "Quantity"
        Me.quantitys.MinimumWidth = 6
        Me.quantitys.Name = "quantitys"
        Me.quantitys.ReadOnly = True
        '
        'withtax
        '
        Me.withtax.HeaderText = "Tax"
        Me.withtax.MinimumWidth = 6
        Me.withtax.Name = "withtax"
        Me.withtax.ReadOnly = True
        '
        'totals
        '
        Me.totals.HeaderText = "Total"
        Me.totals.MinimumWidth = 6
        Me.totals.Name = "totals"
        Me.totals.ReadOnly = True
        '
        'CartCheckOut
        '
        Me.CartCheckOut.BackColor = System.Drawing.Color.Plum
        Me.CartCheckOut.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CartCheckOut.ForeColor = System.Drawing.Color.DarkMagenta
        Me.CartCheckOut.Location = New System.Drawing.Point(562, 238)
        Me.CartCheckOut.Margin = New System.Windows.Forms.Padding(2)
        Me.CartCheckOut.Name = "CartCheckOut"
        Me.CartCheckOut.Size = New System.Drawing.Size(160, 53)
        Me.CartCheckOut.TabIndex = 1
        Me.CartCheckOut.Text = "Place Order"
        Me.CartCheckOut.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Typewriter", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 275)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Here's your Receipt"
        '
        'receipt
        '
        Me.receipt.Location = New System.Drawing.Point(68, 295)
        Me.receipt.Name = "receipt"
        Me.receipt.Size = New System.Drawing.Size(302, 185)
        Me.receipt.TabIndex = 3
        Me.receipt.Text = ""
        '
        'Cart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(833, 508)
        Me.Controls.Add(Me.receipt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CartCheckOut)
        Me.Controls.Add(Me.DGCart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Cart"
        Me.Text = "Form1"
        CType(Me.DGCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGCart As DataGridView
    Friend WithEvents CartCheckOut As Button
    Friend WithEvents ids As DataGridViewTextBoxColumn
    Friend WithEvents namess As DataGridViewTextBoxColumn
    Friend WithEvents typess As DataGridViewTextBoxColumn
    Friend WithEvents pricess As DataGridViewTextBoxColumn
    Friend WithEvents quantitys As DataGridViewTextBoxColumn
    Friend WithEvents withtax As DataGridViewTextBoxColumn
    Friend WithEvents totals As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents receipt As RichTextBox
End Class
