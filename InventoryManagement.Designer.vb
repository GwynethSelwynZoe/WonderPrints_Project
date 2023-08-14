<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryManagement
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
        Me.DGInventoryManagement = New System.Windows.Forms.DataGridView()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.txtinventoryid = New System.Windows.Forms.TextBox()
        Me.txtproductid = New System.Windows.Forms.TextBox()
        Me.txtprodname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DGPname = New System.Windows.Forms.DataGridView()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGInventoryManagement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGPname, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGInventoryManagement
        '
        Me.DGInventoryManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGInventoryManagement.BackgroundColor = System.Drawing.Color.Thistle
        Me.DGInventoryManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGInventoryManagement.GridColor = System.Drawing.Color.DarkOrchid
        Me.DGInventoryManagement.Location = New System.Drawing.Point(31, 76)
        Me.DGInventoryManagement.Margin = New System.Windows.Forms.Padding(2)
        Me.DGInventoryManagement.Name = "DGInventoryManagement"
        Me.DGInventoryManagement.RowHeadersWidth = 51
        Me.DGInventoryManagement.RowTemplate.Height = 24
        Me.DGInventoryManagement.Size = New System.Drawing.Size(407, 233)
        Me.DGInventoryManagement.TabIndex = 0
        '
        'btnRead
        '
        Me.btnRead.BackColor = System.Drawing.Color.Plum
        Me.btnRead.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRead.ForeColor = System.Drawing.Color.DarkMagenta
        Me.btnRead.Location = New System.Drawing.Point(340, 338)
        Me.btnRead.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(82, 29)
        Me.btnRead.TabIndex = 9
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Plum
        Me.btnUpdate.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.DarkMagenta
        Me.btnUpdate.Location = New System.Drawing.Point(340, 420)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 29)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Plum
        Me.Button1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Button1.Location = New System.Drawing.Point(340, 381)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 29)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Select"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.Plum
        Me.btnShow.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.ForeColor = System.Drawing.Color.DarkMagenta
        Me.btnShow.Location = New System.Drawing.Point(615, 327)
        Me.btnShow.Margin = New System.Windows.Forms.Padding(2)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(164, 50)
        Me.btnShow.TabIndex = 11
        Me.btnShow.Text = "Show Product Name"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'txtinventoryid
        '
        Me.txtinventoryid.Location = New System.Drawing.Point(156, 338)
        Me.txtinventoryid.Margin = New System.Windows.Forms.Padding(2)
        Me.txtinventoryid.Name = "txtinventoryid"
        Me.txtinventoryid.Size = New System.Drawing.Size(118, 20)
        Me.txtinventoryid.TabIndex = 12
        '
        'txtproductid
        '
        Me.txtproductid.Location = New System.Drawing.Point(156, 381)
        Me.txtproductid.Margin = New System.Windows.Forms.Padding(2)
        Me.txtproductid.Name = "txtproductid"
        Me.txtproductid.Size = New System.Drawing.Size(118, 20)
        Me.txtproductid.TabIndex = 14
        '
        'txtprodname
        '
        Me.txtprodname.Location = New System.Drawing.Point(156, 420)
        Me.txtprodname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtprodname.Name = "txtprodname"
        Me.txtprodname.Size = New System.Drawing.Size(118, 20)
        Me.txtprodname.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Perpetua Titling MT", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(202, 20)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(426, 33)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Inventory Management"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label5.Location = New System.Drawing.Point(41, 378)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 20)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Product ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label7.Location = New System.Drawing.Point(27, 335)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 20)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Inventory ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label9.Location = New System.Drawing.Point(12, 420)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 20)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Product Name"
        '
        'DGPname
        '
        Me.DGPname.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGPname.BackgroundColor = System.Drawing.Color.Thistle
        Me.DGPname.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPname.GridColor = System.Drawing.Color.DarkOrchid
        Me.DGPname.Location = New System.Drawing.Point(465, 76)
        Me.DGPname.Margin = New System.Windows.Forms.Padding(2)
        Me.DGPname.Name = "DGPname"
        Me.DGPname.RowHeadersWidth = 51
        Me.DGPname.RowTemplate.Height = 24
        Me.DGPname.Size = New System.Drawing.Size(329, 233)
        Me.DGPname.TabIndex = 53
        '
        'txtstock
        '
        Me.txtstock.Location = New System.Drawing.Point(156, 463)
        Me.txtstock.Margin = New System.Windows.Forms.Padding(2)
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(118, 20)
        Me.txtstock.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label1.Location = New System.Drawing.Point(81, 460)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Stock"
        '
        'InventoryManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(833, 640)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtstock)
        Me.Controls.Add(Me.DGPname)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtprodname)
        Me.Controls.Add(Me.txtproductid)
        Me.Controls.Add(Me.txtinventoryid)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.DGInventoryManagement)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "InventoryManagement"
        Me.Text = "Inventory Management"
        CType(Me.DGInventoryManagement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGPname, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGInventoryManagement As DataGridView
    Friend WithEvents btnRead As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents txtinventoryid As TextBox
    Friend WithEvents txtproductid As TextBox
    Friend WithEvents txtprodname As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DGPname As DataGridView
    Friend WithEvents txtstock As TextBox
    Friend WithEvents Label1 As Label
End Class
