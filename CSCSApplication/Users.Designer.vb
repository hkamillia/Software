<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabUsers = New System.Windows.Forms.TabControl()
        Me.AddUser = New System.Windows.Forms.TabPage()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.LblPasswordRetype = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblLname = New System.Windows.Forms.Label()
        Me.LblFname = New System.Windows.Forms.Label()
        Me.TxtPasswordRetype = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtLname = New System.Windows.Forms.TextBox()
        Me.TxtFname = New System.Windows.Forms.TextBox()
        Me.DeleteUser = New System.Windows.Forms.TabPage()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.TxtPassword2 = New System.Windows.Forms.TextBox()
        Me.LblPassword2 = New System.Windows.Forms.Label()
        Me.LblLname2 = New System.Windows.Forms.Label()
        Me.LblFname2 = New System.Windows.Forms.Label()
        Me.TxtLname2 = New System.Windows.Forms.TextBox()
        Me.TxtFname2 = New System.Windows.Forms.TextBox()
        Me.LblLogin = New System.Windows.Forms.LinkLabel()
        Me.LblInstruction = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabUsers.SuspendLayout()
        Me.AddUser.SuspendLayout()
        Me.DeleteUser.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.CSCSApplication.My.Resources.Resources.uscLogo3
        Me.PictureBox1.Location = New System.Drawing.Point(103, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Computer Science Course Scheduler"
        '
        'TabUsers
        '
        Me.TabUsers.Controls.Add(Me.AddUser)
        Me.TabUsers.Controls.Add(Me.DeleteUser)
        Me.TabUsers.Location = New System.Drawing.Point(-2, 149)
        Me.TabUsers.Name = "TabUsers"
        Me.TabUsers.SelectedIndex = 0
        Me.TabUsers.Size = New System.Drawing.Size(779, 336)
        Me.TabUsers.TabIndex = 5
        '
        'AddUser
        '
        Me.AddUser.Controls.Add(Me.LblInstruction)
        Me.AddUser.Controls.Add(Me.BtnSubmit)
        Me.AddUser.Controls.Add(Me.LblPasswordRetype)
        Me.AddUser.Controls.Add(Me.LblPassword)
        Me.AddUser.Controls.Add(Me.LblLname)
        Me.AddUser.Controls.Add(Me.LblFname)
        Me.AddUser.Controls.Add(Me.TxtPasswordRetype)
        Me.AddUser.Controls.Add(Me.TxtPassword)
        Me.AddUser.Controls.Add(Me.TxtLname)
        Me.AddUser.Controls.Add(Me.TxtFname)
        Me.AddUser.Location = New System.Drawing.Point(4, 22)
        Me.AddUser.Name = "AddUser"
        Me.AddUser.Padding = New System.Windows.Forms.Padding(3)
        Me.AddUser.Size = New System.Drawing.Size(771, 310)
        Me.AddUser.TabIndex = 0
        Me.AddUser.Text = "Activate  Account"
        Me.AddUser.UseVisualStyleBackColor = True
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Location = New System.Drawing.Point(303, 238)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(81, 29)
        Me.BtnSubmit.TabIndex = 8
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'LblPasswordRetype
        '
        Me.LblPasswordRetype.AutoSize = True
        Me.LblPasswordRetype.Location = New System.Drawing.Point(135, 199)
        Me.LblPasswordRetype.Name = "LblPasswordRetype"
        Me.LblPasswordRetype.Size = New System.Drawing.Size(93, 13)
        Me.LblPasswordRetype.TabIndex = 7
        Me.LblPasswordRetype.Text = "Retype Password:"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Location = New System.Drawing.Point(135, 160)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(56, 13)
        Me.LblPassword.TabIndex = 6
        Me.LblPassword.Text = "Password:"
        '
        'LblLname
        '
        Me.LblLname.AutoSize = True
        Me.LblLname.Location = New System.Drawing.Point(135, 109)
        Me.LblLname.Name = "LblLname"
        Me.LblLname.Size = New System.Drawing.Size(61, 13)
        Me.LblLname.TabIndex = 5
        Me.LblLname.Text = "Last Name:"
        '
        'LblFname
        '
        Me.LblFname.AutoSize = True
        Me.LblFname.Location = New System.Drawing.Point(135, 76)
        Me.LblFname.Name = "LblFname"
        Me.LblFname.Size = New System.Drawing.Size(60, 13)
        Me.LblFname.TabIndex = 4
        Me.LblFname.Text = "First Name:"
        '
        'TxtPasswordRetype
        '
        Me.TxtPasswordRetype.Location = New System.Drawing.Point(234, 196)
        Me.TxtPasswordRetype.Name = "TxtPasswordRetype"
        Me.TxtPasswordRetype.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TxtPasswordRetype.Size = New System.Drawing.Size(219, 20)
        Me.TxtPasswordRetype.TabIndex = 3
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(234, 157)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TxtPassword.Size = New System.Drawing.Size(219, 20)
        Me.TxtPassword.TabIndex = 2
        '
        'TxtLname
        '
        Me.TxtLname.Location = New System.Drawing.Point(234, 109)
        Me.TxtLname.Name = "TxtLname"
        Me.TxtLname.Size = New System.Drawing.Size(219, 20)
        Me.TxtLname.TabIndex = 1
        '
        'TxtFname
        '
        Me.TxtFname.Location = New System.Drawing.Point(234, 73)
        Me.TxtFname.Name = "TxtFname"
        Me.TxtFname.Size = New System.Drawing.Size(219, 20)
        Me.TxtFname.TabIndex = 0
        '
        'DeleteUser
        '
        Me.DeleteUser.Controls.Add(Me.Label2)
        Me.DeleteUser.Controls.Add(Me.BtnDelete)
        Me.DeleteUser.Controls.Add(Me.TxtPassword2)
        Me.DeleteUser.Controls.Add(Me.LblPassword2)
        Me.DeleteUser.Controls.Add(Me.LblLname2)
        Me.DeleteUser.Controls.Add(Me.LblFname2)
        Me.DeleteUser.Controls.Add(Me.TxtLname2)
        Me.DeleteUser.Controls.Add(Me.TxtFname2)
        Me.DeleteUser.Location = New System.Drawing.Point(4, 22)
        Me.DeleteUser.Name = "DeleteUser"
        Me.DeleteUser.Padding = New System.Windows.Forms.Padding(3)
        Me.DeleteUser.Size = New System.Drawing.Size(771, 310)
        Me.DeleteUser.TabIndex = 1
        Me.DeleteUser.Text = "Delete User"
        Me.DeleteUser.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(323, 216)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(81, 29)
        Me.BtnDelete.TabIndex = 9
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'TxtPassword2
        '
        Me.TxtPassword2.Location = New System.Drawing.Point(251, 178)
        Me.TxtPassword2.Name = "TxtPassword2"
        Me.TxtPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TxtPassword2.Size = New System.Drawing.Size(219, 20)
        Me.TxtPassword2.TabIndex = 8
        '
        'LblPassword2
        '
        Me.LblPassword2.AutoSize = True
        Me.LblPassword2.Location = New System.Drawing.Point(172, 178)
        Me.LblPassword2.Name = "LblPassword2"
        Me.LblPassword2.Size = New System.Drawing.Size(56, 13)
        Me.LblPassword2.TabIndex = 7
        Me.LblPassword2.Text = "Password:"
        '
        'LblLname2
        '
        Me.LblLname2.AutoSize = True
        Me.LblLname2.Location = New System.Drawing.Point(167, 131)
        Me.LblLname2.Name = "LblLname2"
        Me.LblLname2.Size = New System.Drawing.Size(61, 13)
        Me.LblLname2.TabIndex = 6
        Me.LblLname2.Text = "Last Name:"
        '
        'LblFname2
        '
        Me.LblFname2.AutoSize = True
        Me.LblFname2.Location = New System.Drawing.Point(168, 91)
        Me.LblFname2.Name = "LblFname2"
        Me.LblFname2.Size = New System.Drawing.Size(60, 13)
        Me.LblFname2.TabIndex = 5
        Me.LblFname2.Text = "First Name:"
        '
        'TxtLname2
        '
        Me.TxtLname2.Location = New System.Drawing.Point(251, 131)
        Me.TxtLname2.Name = "TxtLname2"
        Me.TxtLname2.Size = New System.Drawing.Size(219, 20)
        Me.TxtLname2.TabIndex = 2
        '
        'TxtFname2
        '
        Me.TxtFname2.Location = New System.Drawing.Point(251, 88)
        Me.TxtFname2.Name = "TxtFname2"
        Me.TxtFname2.Size = New System.Drawing.Size(219, 20)
        Me.TxtFname2.TabIndex = 1
        '
        'LblLogin
        '
        Me.LblLogin.AutoSize = True
        Me.LblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLogin.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LblLogin.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblLogin.Location = New System.Drawing.Point(565, 32)
        Me.LblLogin.Name = "LblLogin"
        Me.LblLogin.Size = New System.Drawing.Size(127, 18)
        Me.LblLogin.TabIndex = 31
        Me.LblLogin.TabStop = True
        Me.LblLogin.Text = "<<Return to Login"
        '
        'LblInstruction
        '
        Me.LblInstruction.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblInstruction.AutoSize = True
        Me.LblInstruction.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInstruction.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.LblInstruction.Location = New System.Drawing.Point(135, 12)
        Me.LblInstruction.Name = "LblInstruction"
        Me.LblInstruction.Size = New System.Drawing.Size(414, 45)
        Me.LblInstruction.TabIndex = 9
        Me.LblInstruction.Text = "To activate your user account please enter your First name and Last name. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Then " &
    "enter your password and retype it for confirmation." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label2.Location = New System.Drawing.Point(167, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(372, 45)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Your account is fully powered by your name and password." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Therefore, in order to" &
    " remove your account from the system," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " you must enter your First and Last name " &
    "as well as your password."
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(777, 484)
        Me.Controls.Add(Me.LblLogin)
        Me.Controls.Add(Me.TabUsers)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Users"
        Me.Text = "Users"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabUsers.ResumeLayout(False)
        Me.AddUser.ResumeLayout(False)
        Me.AddUser.PerformLayout()
        Me.DeleteUser.ResumeLayout(False)
        Me.DeleteUser.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabUsers As TabControl
    Friend WithEvents AddUser As TabPage
    Friend WithEvents DeleteUser As TabPage
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents LblPasswordRetype As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents LblLname As Label
    Friend WithEvents LblFname As Label
    Friend WithEvents TxtPasswordRetype As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtLname As TextBox
    Friend WithEvents TxtFname As TextBox
    Friend WithEvents BtnDelete As Button
    Friend WithEvents TxtPassword2 As TextBox
    Friend WithEvents LblPassword2 As Label
    Friend WithEvents LblLname2 As Label
    Friend WithEvents LblFname2 As Label
    Friend WithEvents TxtLname2 As TextBox
    Friend WithEvents TxtFname2 As TextBox
    Friend WithEvents LblLogin As LinkLabel
    Friend WithEvents LblInstruction As Label
    Friend WithEvents Label2 As Label
End Class
