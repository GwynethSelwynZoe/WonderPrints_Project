<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfileForm
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
        Me.labelName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtnumber = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnPindot = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DGProfile = New System.Windows.Forms.DataGridView()
        Me.chkpass = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelName
        '
        Me.labelName.AutoSize = True
        Me.labelName.Font = New System.Drawing.Font("Times New Roman", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelName.Location = New System.Drawing.Point(20, 22)
        Me.labelName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelName.Name = "labelName"
        Me.labelName.Size = New System.Drawing.Size(114, 40)
        Me.labelName.TabIndex = 0
        Me.labelName.Text = "Hello, "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(45, 318)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(45, 485)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(45, 402)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Contact Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(45, 359)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 21)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Username"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(184, 322)
        Me.txtname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(164, 20)
        Me.txtname.TabIndex = 8
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(184, 487)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(164, 20)
        Me.txtpassword.TabIndex = 9
        '
        'txtnumber
        '
        Me.txtnumber.Location = New System.Drawing.Point(184, 404)
        Me.txtnumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnumber.Name = "txtnumber"
        Me.txtnumber.Size = New System.Drawing.Size(164, 20)
        Me.txtnumber.TabIndex = 10
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(184, 362)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(164, 20)
        Me.txtusername.TabIndex = 11
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Location = New System.Drawing.Point(232, 528)
        Me.btnSaveChanges.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(116, 34)
        Me.btnSaveChanges.TabIndex = 13
        Me.btnSaveChanges.Text = "Save Changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WonderPrints_Project.My.Resources.Resources.user
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(282, 82)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 144)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'btnPindot
        '
        Me.btnPindot.Location = New System.Drawing.Point(49, 243)
        Me.btnPindot.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPindot.Name = "btnPindot"
        Me.btnPindot.Size = New System.Drawing.Size(49, 23)
        Me.btnPindot.TabIndex = 15
        Me.btnPindot.Text = "Info"
        Me.btnPindot.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(45, 286)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 21)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "ID"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(184, 286)
        Me.txtid.Margin = New System.Windows.Forms.Padding(2)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(164, 20)
        Me.txtid.TabIndex = 17
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(184, 447)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(164, 20)
        Me.txtaddress.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(45, 445)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 21)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Address"
        '
        'DGProfile
        '
        Me.DGProfile.BackgroundColor = System.Drawing.Color.Thistle
        Me.DGProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGProfile.Location = New System.Drawing.Point(427, 286)
        Me.DGProfile.Name = "DGProfile"
        Me.DGProfile.Size = New System.Drawing.Size(363, 210)
        Me.DGProfile.TabIndex = 20
        '
        'chkpass
        '
        Me.chkpass.AutoSize = True
        Me.chkpass.Location = New System.Drawing.Point(353, 490)
        Me.chkpass.Name = "chkpass"
        Me.chkpass.Size = New System.Drawing.Size(15, 14)
        Me.chkpass.TabIndex = 21
        Me.chkpass.UseVisualStyleBackColor = True
        '
        'ProfileForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(856, 643)
        Me.Controls.Add(Me.chkpass)
        Me.Controls.Add(Me.DGProfile)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnPindot)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSaveChanges)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.txtnumber)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.labelName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ProfileForm"
        Me.Text = "Profile Form"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtnumber As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnPindot As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DGProfile As DataGridView
    Friend WithEvents chkpass As CheckBox
End Class
