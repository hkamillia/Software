<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(803, 91)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Image = Global.CSCSApplication.My.Resources.Resources.usc_logo
        Me.PictureBox1.Location = New System.Drawing.Point(246, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(310, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel3.Controls.Add(Me.CheckedListBox1)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Username)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(0, 91)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(803, 397)
        Me.Panel3.TabIndex = 2
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(481, 298)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(396, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 28)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Password"
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.Location = New System.Drawing.Point(395, 106)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(97, 28)
        Me.Username.TabIndex = 5
        Me.Username.Text = "Username"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(591, 205)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Register"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(498, 205)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Login"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(529, 247)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Forget Password"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(498, 161)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(168, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(498, 111)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(168, 20)
        Me.TextBox1.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(44, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(401, 273)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(591, 291)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(120, 94)
        Me.CheckedListBox1.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 488)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Username As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents CheckedListBox1 As CheckedListBox
End Class
