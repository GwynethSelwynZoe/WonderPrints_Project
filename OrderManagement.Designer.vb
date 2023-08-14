<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrderManagement
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
        Me.DGOrderManagement = New System.Windows.Forms.DataGridView()
        Me.txtcustomerid = New System.Windows.Forms.TextBox()
        Me.txtorderid = New System.Windows.Forms.TextBox()
        Me.txtstatus = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtdate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DGOrderManagement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGOrderManagement
        '
        Me.DGOrderManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGOrderManagement.BackgroundColor = System.Drawing.Color.Thistle
        Me.DGOrderManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGOrderManagement.GridColor = System.Drawing.Color.DarkViolet
        Me.DGOrderManagement.Location = New System.Drawing.Point(184, 95)
        Me.DGOrderManagement.Margin = New System.Windows.Forms.Padding(2)
        Me.DGOrderManagement.Name = "DGOrderManagement"
        Me.DGOrderManagement.RowHeadersWidth = 51
        Me.DGOrderManagement.RowTemplate.Height = 24
        Me.DGOrderManagement.Size = New System.Drawing.Size(599, 246)
        Me.DGOrderManagement.TabIndex = 5
        '
        'txtcustomerid
        '
        Me.txtcustomerid.Location = New System.Drawing.Point(370, 427)
        Me.txtcustomerid.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcustomerid.Name = "txtcustomerid"
        Me.txtcustomerid.Size = New System.Drawing.Size(118, 20)
        Me.txtcustomerid.TabIndex = 29
        '
        'txtorderid
        '
        Me.txtorderid.Location = New System.Drawing.Point(370, 387)
        Me.txtorderid.Margin = New System.Windows.Forms.Padding(2)
        Me.txtorderid.Name = "txtorderid"
        Me.txtorderid.Size = New System.Drawing.Size(118, 20)
        Me.txtorderid.TabIndex = 28
        '
        'txtstatus
        '
        Me.txtstatus.Location = New System.Drawing.Point(370, 515)
        Me.txtstatus.Margin = New System.Windows.Forms.Padding(2)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(118, 20)
        Me.txtstatus.TabIndex = 38
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Plum
        Me.Button1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Button1.Location = New System.Drawing.Point(619, 413)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 31)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Select"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnRead
        '
        Me.btnRead.BackColor = System.Drawing.Color.Plum
        Me.btnRead.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRead.ForeColor = System.Drawing.Color.DarkMagenta
        Me.btnRead.Location = New System.Drawing.Point(704, 373)
        Me.btnRead.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(82, 31)
        Me.btnRead.TabIndex = 42
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Plum
        Me.btnUpdate.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.DarkMagenta
        Me.btnUpdate.Location = New System.Drawing.Point(619, 373)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(81, 31)
        Me.btnUpdate.TabIndex = 41
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Plum
        Me.btnDelete.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Crimson
        Me.btnDelete.Location = New System.Drawing.Point(704, 413)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(79, 31)
        Me.btnDelete.TabIndex = 40
        Me.btnDelete.Text = "Cancel"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Perpetua Titling MT", 23.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(280, 34)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(394, 37)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Order Management"
        '
        'txtdate
        '
        Me.txtdate.Location = New System.Drawing.Point(370, 471)
        Me.txtdate.Margin = New System.Windows.Forms.Padding(2)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(118, 20)
        Me.txtdate.TabIndex = 48
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label4.Location = New System.Drawing.Point(241, 384)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Order ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label1.Location = New System.Drawing.Point(241, 424)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 20)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Customer ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label2.Location = New System.Drawing.Point(241, 515)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label3.Location = New System.Drawing.Point(241, 471)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 20)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Date Ordered"
        '
        'OrderManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(833, 788)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtdate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtstatus)
        Me.Controls.Add(Me.txtcustomerid)
        Me.Controls.Add(Me.txtorderid)
        Me.Controls.Add(Me.DGOrderManagement)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "OrderManagement"
        Me.Text = "Order Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGOrderManagement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGOrderManagement As DataGridView
    Friend WithEvents txtcustomerid As TextBox
    Friend WithEvents txtorderid As TextBox
    Friend WithEvents txtstatus As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtdate As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
