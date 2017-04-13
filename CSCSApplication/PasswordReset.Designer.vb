<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordReset
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblLogin = New System.Windows.Forms.LinkLabel()
        Me.LblResetPassword = New System.Windows.Forms.Label()
        Me.LblInstruction = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.TxtPasswordRetype = New System.Windows.Forms.TextBox()
        Me.LblPasswordRetype = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.LblPassInstruction = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblLname = New System.Windows.Forms.Label()
        Me.LblFname = New System.Windows.Forms.Label()
        Me.TxtLname = New System.Windows.Forms.TextBox()
        Me.TxtFname = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Computer Science Course Scheduler"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.CSCSApplication.My.Resources.Resources.uscLogo3
        Me.PictureBox1.Location = New System.Drawing.Point(113, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'LblLogin
        '
        Me.LblLogin.AutoSize = True
        Me.LblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLogin.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LblLogin.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblLogin.Location = New System.Drawing.Point(607, 58)
        Me.LblLogin.Name = "LblLogin"
        Me.LblLogin.Size = New System.Drawing.Size(127, 18)
        Me.LblLogin.TabIndex = 32
        Me.LblLogin.TabStop = True
        Me.LblLogin.Text = "<<Return to Login"
        '
        'LblResetPassword
        '
        Me.LblResetPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblResetPassword.AutoSize = True
        Me.LblResetPassword.BackColor = System.Drawing.Color.Ivory
        Me.LblResetPassword.Font = New System.Drawing.Font("Papyrus", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblResetPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.LblResetPassword.Location = New System.Drawing.Point(353, 117)
        Me.LblResetPassword.Name = "LblResetPassword"
        Me.LblResetPassword.Size = New System.Drawing.Size(156, 30)
        Me.LblResetPassword.TabIndex = 33
        Me.LblResetPassword.Text = "Reset Password"
        '
        'LblInstruction
        '
        Me.LblInstruction.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblInstruction.AutoSize = True
        Me.LblInstruction.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInstruction.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.LblInstruction.Location = New System.Drawing.Point(229, 161)
        Me.LblInstruction.Name = "LblInstruction"
        Me.LblInstruction.Size = New System.Drawing.Size(505, 45)
        Me.LblInstruction.TabIndex = 34
        Me.LblInstruction.Text = "If you forgot your password, you will need to reset it. In order to reset it plea" &
    "se enter your " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "First and Last names, then enter your New Password and confirm i" &
    "t." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.BtnReset)
        Me.Panel1.Controls.Add(Me.TxtPasswordRetype)
        Me.Panel1.Controls.Add(Me.LblPasswordRetype)
        Me.Panel1.Controls.Add(Me.TxtPassword)
        Me.Panel1.Controls.Add(Me.LblPassInstruction)
        Me.Panel1.Controls.Add(Me.LblPassword)
        Me.Panel1.Controls.Add(Me.LblLname)
        Me.Panel1.Controls.Add(Me.LblFname)
        Me.Panel1.Controls.Add(Me.TxtLname)
        Me.Panel1.Controls.Add(Me.TxtFname)
        Me.Panel1.Location = New System.Drawing.Point(143, 224)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(591, 237)
        Me.Panel1.TabIndex = 35
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(465, 197)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(66, 20)
        Me.BtnReset.TabIndex = 32
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'TxtPasswordRetype
        '
        Me.TxtPasswordRetype.Location = New System.Drawing.Point(222, 197)
        Me.TxtPasswordRetype.Name = "TxtPasswordRetype"
        Me.TxtPasswordRetype.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TxtPasswordRetype.Size = New System.Drawing.Size(219, 20)
        Me.TxtPasswordRetype.TabIndex = 31
        '
        'LblPasswordRetype
        '
        Me.LblPasswordRetype.AutoSize = True
        Me.LblPasswordRetype.Location = New System.Drawing.Point(110, 200)
        Me.LblPasswordRetype.Name = "LblPasswordRetype"
        Me.LblPasswordRetype.Size = New System.Drawing.Size(93, 13)
        Me.LblPasswordRetype.TabIndex = 30
        Me.LblPasswordRetype.Text = "Retype Password:"
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(222, 160)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TxtPassword.Size = New System.Drawing.Size(219, 20)
        Me.TxtPassword.TabIndex = 29
        '
        'LblPassInstruction
        '
        Me.LblPassInstruction.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblPassInstruction.AutoSize = True
        Me.LblPassInstruction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassInstruction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.LblPassInstruction.Location = New System.Drawing.Point(106, 128)
        Me.LblPassInstruction.Name = "LblPassInstruction"
        Me.LblPassInstruction.Size = New System.Drawing.Size(406, 15)
        Me.LblPassInstruction.TabIndex = 28
        Me.LblPassInstruction.Text = "Please enter your new password and retype it for confirmation:"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Location = New System.Drawing.Point(110, 163)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(81, 13)
        Me.LblPassword.TabIndex = 7
        Me.LblPassword.Text = "New Password:"
        '
        'LblLname
        '
        Me.LblLname.AutoSize = True
        Me.LblLname.Location = New System.Drawing.Point(106, 85)
        Me.LblLname.Name = "LblLname"
        Me.LblLname.Size = New System.Drawing.Size(61, 13)
        Me.LblLname.TabIndex = 6
        Me.LblLname.Text = "Last Name:"
        '
        'LblFname
        '
        Me.LblFname.AutoSize = True
        Me.LblFname.Location = New System.Drawing.Point(106, 42)
        Me.LblFname.Name = "LblFname"
        Me.LblFname.Size = New System.Drawing.Size(60, 13)
        Me.LblFname.TabIndex = 5
        Me.LblFname.Text = "First Name:"
        '
        'TxtLname
        '
        Me.TxtLname.Location = New System.Drawing.Point(222, 85)
        Me.TxtLname.Name = "TxtLname"
        Me.TxtLname.Size = New System.Drawing.Size(219, 20)
        Me.TxtLname.TabIndex = 2
        '
        'TxtFname
        '
        Me.TxtFname.Location = New System.Drawing.Point(222, 35)
        Me.TxtFname.Name = "TxtFname"
        Me.TxtFname.Size = New System.Drawing.Size(219, 20)
        Me.TxtFname.TabIndex = 1
        '
        'PasswordReset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(777, 484)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblInstruction)
        Me.Controls.Add(Me.LblResetPassword)
        Me.Controls.Add(Me.LblLogin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PasswordReset"
        Me.Text = "Password Reset"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblLogin As LinkLabel
    Friend WithEvents LblResetPassword As Label
    Friend WithEvents LblInstruction As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtFname As TextBox
    Friend WithEvents TxtLname As TextBox
    Friend WithEvents LblFname As Label
    Friend WithEvents LblLname As Label
    Friend WithEvents LblPassInstruction As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents LblPasswordRetype As Label
    Friend WithEvents TxtPasswordRetype As TextBox
    Friend WithEvents BtnReset As Button
End Class
