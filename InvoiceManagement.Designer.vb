<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvoiceManagement
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
        Me.btnReceipts = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TallyReceipt = New System.Windows.Forms.RichTextBox()
        Me.DGInvoice = New System.Windows.Forms.DataGridView()
        Me.btnReport = New System.Windows.Forms.Button()
        CType(Me.DGInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReceipts
        '
        Me.btnReceipts.BackColor = System.Drawing.Color.Plum
        Me.btnReceipts.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceipts.ForeColor = System.Drawing.Color.Purple
        Me.btnReceipts.Location = New System.Drawing.Point(271, 366)
        Me.btnReceipts.Name = "btnReceipts"
        Me.btnReceipts.Size = New System.Drawing.Size(186, 39)
        Me.btnReceipts.TabIndex = 1
        Me.btnReceipts.Text = "Print Receipt"
        Me.btnReceipts.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Perpetua Titling MT", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(187, 21)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(368, 33)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Invoice Management"
        '
        'TallyReceipt
        '
        Me.TallyReceipt.BackColor = System.Drawing.Color.LavenderBlush
        Me.TallyReceipt.Location = New System.Drawing.Point(482, 90)
        Me.TallyReceipt.Margin = New System.Windows.Forms.Padding(2)
        Me.TallyReceipt.Name = "TallyReceipt"
        Me.TallyReceipt.Size = New System.Drawing.Size(291, 365)
        Me.TallyReceipt.TabIndex = 0
        Me.TallyReceipt.Text = ""
        '
        'DGInvoice
        '
        Me.DGInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGInvoice.BackgroundColor = System.Drawing.Color.Thistle
        Me.DGInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGInvoice.GridColor = System.Drawing.Color.DarkViolet
        Me.DGInvoice.Location = New System.Drawing.Point(25, 90)
        Me.DGInvoice.Margin = New System.Windows.Forms.Padding(2)
        Me.DGInvoice.Name = "DGInvoice"
        Me.DGInvoice.RowHeadersWidth = 51
        Me.DGInvoice.RowTemplate.Height = 24
        Me.DGInvoice.Size = New System.Drawing.Size(432, 246)
        Me.DGInvoice.TabIndex = 49
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.Plum
        Me.btnReport.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.Color.Purple
        Me.btnReport.Location = New System.Drawing.Point(648, 474)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(125, 39)
        Me.btnReport.TabIndex = 50
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'InvoiceManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(820, 640)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.DGInvoice)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnReceipts)
        Me.Controls.Add(Me.TallyReceipt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "InvoiceManagement"
        Me.Text = "Form1"
        CType(Me.DGInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReceipts As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TallyReceipt As RichTextBox
    Friend WithEvents DGInvoice As DataGridView
    Friend WithEvents btnReport As Button
End Class
