<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUpForm
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
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtusernameS = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtC_number = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SignUp = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkpass = New System.Windows.Forms.CheckBox()
        Me.txtpassS = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.LavenderBlush
        Me.txtname.Location = New System.Drawing.Point(174, 119)
        Me.txtname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(114, 20)
        Me.txtname.TabIndex = 4
        '
        'txtusernameS
        '
        Me.txtusernameS.BackColor = System.Drawing.Color.LavenderBlush
        Me.txtusernameS.Location = New System.Drawing.Point(174, 159)
        Me.txtusernameS.Margin = New System.Windows.Forms.Padding(2)
        Me.txtusernameS.Name = "txtusernameS"
        Me.txtusernameS.Size = New System.Drawing.Size(114, 20)
        Me.txtusernameS.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Plum
        Me.Label4.Location = New System.Drawing.Point(59, 240)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password"
        '
        'txtC_number
        '
        Me.txtC_number.BackColor = System.Drawing.Color.LavenderBlush
        Me.txtC_number.Location = New System.Drawing.Point(174, 201)
        Me.txtC_number.Margin = New System.Windows.Forms.Padding(2)
        Me.txtC_number.Name = "txtC_number"
        Me.txtC_number.Size = New System.Drawing.Size(114, 20)
        Me.txtC_number.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Plum
        Me.Label3.Location = New System.Drawing.Point(59, 158)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Plum
        Me.Label2.Location = New System.Drawing.Point(59, 199)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contact Number"
        '
        'SignUp
        '
        Me.SignUp.BackColor = System.Drawing.Color.Transparent
        Me.SignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SignUp.Location = New System.Drawing.Point(137, 306)
        Me.SignUp.Margin = New System.Windows.Forms.Padding(2)
        Me.SignUp.Name = "SignUp"
        Me.SignUp.Size = New System.Drawing.Size(80, 33)
        Me.SignUp.TabIndex = 8
        Me.SignUp.Text = "Sign Up"
        Me.SignUp.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Plum
        Me.Label1.Location = New System.Drawing.Point(59, 117)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'chkpass
        '
        Me.chkpass.AutoSize = True
        Me.chkpass.Location = New System.Drawing.Point(292, 245)
        Me.chkpass.Margin = New System.Windows.Forms.Padding(2)
        Me.chkpass.Name = "chkpass"
        Me.chkpass.Size = New System.Drawing.Size(15, 14)
        Me.chkpass.TabIndex = 10
        Me.chkpass.UseVisualStyleBackColor = True
        '
        'txtpassS
        '
        Me.txtpassS.BackColor = System.Drawing.Color.LavenderBlush
        Me.txtpassS.Location = New System.Drawing.Point(174, 242)
        Me.txtpassS.Margin = New System.Windows.Forms.Padding(2)
        Me.txtpassS.Name = "txtpassS"
        Me.txtpassS.Size = New System.Drawing.Size(114, 20)
        Me.txtpassS.TabIndex = 7
        Me.txtpassS.UseSystemPasswordChar = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Perpetua Titling MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Plum
        Me.Label6.Location = New System.Drawing.Point(90, 58)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 23)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "REGISTER HERE"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Window
        Me.Button3.Location = New System.Drawing.Point(323, 5)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(22, 28)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "X"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'SignUpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(362, 376)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtpassS)
        Me.Controls.Add(Me.chkpass)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtusernameS)
        Me.Controls.Add(Me.SignUp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtC_number)
        Me.Controls.Add(Me.Label3)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "SignUpForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign Up"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtname As TextBox
    Friend WithEvents txtusernameS As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtC_number As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SignUp As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents chkpass As CheckBox
    Friend WithEvents txtpassS As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
End Class
