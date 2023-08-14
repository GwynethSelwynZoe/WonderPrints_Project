<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Me.DGMyOrders = New System.Windows.Forms.DataGridView()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtpname = New System.Windows.Forms.TextBox()
        Me.txtoqty = New System.Windows.Forms.TextBox()
        Me.txtstatus = New System.Windows.Forms.TextBox()
        CType(Me.DGMyOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGMyOrders
        '
        Me.DGMyOrders.BackgroundColor = System.Drawing.Color.Thistle
        Me.DGMyOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMyOrders.GridColor = System.Drawing.Color.DarkViolet
        Me.DGMyOrders.Location = New System.Drawing.Point(64, 34)
        Me.DGMyOrders.Name = "DGMyOrders"
        Me.DGMyOrders.Size = New System.Drawing.Size(678, 187)
        Me.DGMyOrders.TabIndex = 0
        '
        'btnRead
        '
        Me.btnRead.BackColor = System.Drawing.Color.Plum
        Me.btnRead.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRead.ForeColor = System.Drawing.Color.DarkMagenta
        Me.btnRead.Location = New System.Drawing.Point(589, 271)
        Me.btnRead.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(153, 43)
        Me.btnRead.TabIndex = 2
        Me.btnRead.Text = "My Orders"
        Me.btnRead.UseVisualStyleBackColor = False
        '
        'btnDisplay
        '
        Me.btnDisplay.BackColor = System.Drawing.Color.Plum
        Me.btnDisplay.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.ForeColor = System.Drawing.Color.DarkMagenta
        Me.btnDisplay.Location = New System.Drawing.Point(589, 340)
        Me.btnDisplay.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(153, 43)
        Me.btnDisplay.TabIndex = 3
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label1.Location = New System.Drawing.Point(94, 271)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label2.Location = New System.Drawing.Point(94, 310)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Product Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label3.Location = New System.Drawing.Point(94, 351)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label4.Location = New System.Drawing.Point(94, 389)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Status"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(266, 271)
        Me.txtname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(151, 20)
        Me.txtname.TabIndex = 28
        '
        'txtpname
        '
        Me.txtpname.Location = New System.Drawing.Point(266, 313)
        Me.txtpname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtpname.Name = "txtpname"
        Me.txtpname.Size = New System.Drawing.Size(151, 20)
        Me.txtpname.TabIndex = 29
        '
        'txtoqty
        '
        Me.txtoqty.Location = New System.Drawing.Point(266, 354)
        Me.txtoqty.Margin = New System.Windows.Forms.Padding(2)
        Me.txtoqty.Name = "txtoqty"
        Me.txtoqty.Size = New System.Drawing.Size(151, 20)
        Me.txtoqty.TabIndex = 30
        '
        'txtstatus
        '
        Me.txtstatus.Location = New System.Drawing.Point(266, 392)
        Me.txtstatus.Margin = New System.Windows.Forms.Padding(2)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(151, 20)
        Me.txtstatus.TabIndex = 31
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(833, 640)
        Me.Controls.Add(Me.txtstatus)
        Me.Controls.Add(Me.txtoqty)
        Me.Controls.Add(Me.txtpname)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.DGMyOrders)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Dashboard"
        Me.Text = "Customer POV"
        CType(Me.DGMyOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGMyOrders As DataGridView
    Friend WithEvents btnRead As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtpname As TextBox
    Friend WithEvents txtoqty As TextBox
    Friend WithEvents txtstatus As TextBox
End Class
