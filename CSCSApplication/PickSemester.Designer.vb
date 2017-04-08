<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PickSemCreate
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSemester1 = New System.Windows.Forms.RadioButton()
        Me.BtnSemester2 = New System.Windows.Forms.RadioButton()
        Me.BtnSemester3 = New System.Windows.Forms.RadioButton()
        Me.LsbCourses = New System.Windows.Forms.ListBox()
        Me.TxtCrsCode = New System.Windows.Forms.TextBox()
        Me.TxtCrsTitle = New System.Windows.Forms.TextBox()
        Me.LblCrsCode = New System.Windows.Forms.Label()
        Me.LblCrsTitle = New System.Windows.Forms.Label()
        Me.LblCrsType = New System.Windows.Forms.Label()
        Me.CmbType = New System.Windows.Forms.ComboBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblInstructions = New System.Windows.Forms.Label()
        Me.LblDelete = New System.Windows.Forms.Label()
        Me.LblNext = New System.Windows.Forms.LinkLabel()
        Me.LblBack = New System.Windows.Forms.LinkLabel()
        Me.LblCredits = New System.Windows.Forms.Label()
        Me.TxtCredits = New System.Windows.Forms.TextBox()
        Me.TxtClassSize = New System.Windows.Forms.TextBox()
        Me.LblClassSize = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(777, 49)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Ivory
        Me.Label1.Location = New System.Drawing.Point(272, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(375, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Computer Science Course Scheduler"
        '
        'BtnSemester1
        '
        Me.BtnSemester1.AutoSize = True
        Me.BtnSemester1.Location = New System.Drawing.Point(35, 46)
        Me.BtnSemester1.Name = "BtnSemester1"
        Me.BtnSemester1.Size = New System.Drawing.Size(86, 17)
        Me.BtnSemester1.TabIndex = 2
        Me.BtnSemester1.Text = "1st Semester"
        Me.BtnSemester1.UseVisualStyleBackColor = True
        '
        'BtnSemester2
        '
        Me.BtnSemester2.AutoSize = True
        Me.BtnSemester2.Location = New System.Drawing.Point(35, 89)
        Me.BtnSemester2.Name = "BtnSemester2"
        Me.BtnSemester2.Size = New System.Drawing.Size(90, 17)
        Me.BtnSemester2.TabIndex = 3
        Me.BtnSemester2.Text = "2nd Semester"
        Me.BtnSemester2.UseVisualStyleBackColor = True
        '
        'BtnSemester3
        '
        Me.BtnSemester3.AutoSize = True
        Me.BtnSemester3.Location = New System.Drawing.Point(34, 137)
        Me.BtnSemester3.Name = "BtnSemester3"
        Me.BtnSemester3.Size = New System.Drawing.Size(87, 17)
        Me.BtnSemester3.TabIndex = 4
        Me.BtnSemester3.Text = "3rd Semester"
        Me.BtnSemester3.UseVisualStyleBackColor = True
        '
        'LsbCourses
        '
        Me.LsbCourses.FormattingEnabled = True
        Me.LsbCourses.Location = New System.Drawing.Point(220, 80)
        Me.LsbCourses.Name = "LsbCourses"
        Me.LsbCourses.Size = New System.Drawing.Size(269, 251)
        Me.LsbCourses.TabIndex = 11
        '
        'TxtCrsCode
        '
        Me.TxtCrsCode.Location = New System.Drawing.Point(505, 92)
        Me.TxtCrsCode.Name = "TxtCrsCode"
        Me.TxtCrsCode.Size = New System.Drawing.Size(152, 20)
        Me.TxtCrsCode.TabIndex = 12
        '
        'TxtCrsTitle
        '
        Me.TxtCrsTitle.Location = New System.Drawing.Point(505, 135)
        Me.TxtCrsTitle.Name = "TxtCrsTitle"
        Me.TxtCrsTitle.Size = New System.Drawing.Size(152, 20)
        Me.TxtCrsTitle.TabIndex = 13
        '
        'LblCrsCode
        '
        Me.LblCrsCode.AutoSize = True
        Me.LblCrsCode.Location = New System.Drawing.Point(509, 71)
        Me.LblCrsCode.Name = "LblCrsCode"
        Me.LblCrsCode.Size = New System.Drawing.Size(93, 13)
        Me.LblCrsCode.TabIndex = 15
        Me.LblCrsCode.Text = "Course Code-Sec:"
        '
        'LblCrsTitle
        '
        Me.LblCrsTitle.AutoSize = True
        Me.LblCrsTitle.Location = New System.Drawing.Point(509, 119)
        Me.LblCrsTitle.Name = "LblCrsTitle"
        Me.LblCrsTitle.Size = New System.Drawing.Size(66, 13)
        Me.LblCrsTitle.TabIndex = 16
        Me.LblCrsTitle.Text = "Course Title:"
        '
        'LblCrsType
        '
        Me.LblCrsType.AutoSize = True
        Me.LblCrsType.Location = New System.Drawing.Point(505, 219)
        Me.LblCrsType.Name = "LblCrsType"
        Me.LblCrsType.Size = New System.Drawing.Size(70, 13)
        Me.LblCrsType.TabIndex = 17
        Me.LblCrsType.Text = "Course Type:"
        '
        'CmbType
        '
        Me.CmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbType.FormattingEnabled = True
        Me.CmbType.Items.AddRange(New Object() {"Core", "Cognate", "Emphasis", "Elective", "General Ed"})
        Me.CmbType.Location = New System.Drawing.Point(505, 235)
        Me.CmbType.Name = "CmbType"
        Me.CmbType.Size = New System.Drawing.Size(152, 21)
        Me.CmbType.TabIndex = 18
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(672, 281)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 19
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(672, 327)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 21
        Me.BtnDelete.Text = "Delete "
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.LblInstructions)
        Me.Panel2.Controls.Add(Me.BtnSemester1)
        Me.Panel2.Controls.Add(Me.BtnSemester2)
        Me.Panel2.Controls.Add(Me.BtnSemester3)
        Me.Panel2.Location = New System.Drawing.Point(0, 49)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 437)
        Me.Panel2.TabIndex = 22
        '
        'LblInstructions
        '
        Me.LblInstructions.AutoSize = True
        Me.LblInstructions.Location = New System.Drawing.Point(31, 22)
        Me.LblInstructions.Name = "LblInstructions"
        Me.LblInstructions.Size = New System.Drawing.Size(96, 13)
        Me.LblInstructions.TabIndex = 5
        Me.LblInstructions.Text = "Select a Semester:"
        '
        'LblDelete
        '
        Me.LblDelete.AutoSize = True
        Me.LblDelete.Location = New System.Drawing.Point(509, 334)
        Me.LblDelete.Name = "LblDelete"
        Me.LblDelete.Size = New System.Drawing.Size(157, 13)
        Me.LblDelete.TabIndex = 23
        Me.LblDelete.Text = "Select Course then click delete:"
        '
        'LblNext
        '
        Me.LblNext.AutoSize = True
        Me.LblNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNext.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LblNext.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblNext.Location = New System.Drawing.Point(508, 413)
        Me.LblNext.Name = "LblNext"
        Me.LblNext.Size = New System.Drawing.Size(59, 20)
        Me.LblNext.TabIndex = 24
        Me.LblNext.TabStop = True
        Me.LblNext.Text = "Next>>"
        '
        'LblBack
        '
        Me.LblBack.AutoSize = True
        Me.LblBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBack.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LblBack.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblBack.Location = New System.Drawing.Point(404, 413)
        Me.LblBack.Name = "LblBack"
        Me.LblBack.Size = New System.Drawing.Size(63, 20)
        Me.LblBack.TabIndex = 2
        Me.LblBack.TabStop = True
        Me.LblBack.Text = "<<Back"
        '
        'LblCredits
        '
        Me.LblCredits.AutoSize = True
        Me.LblCredits.Location = New System.Drawing.Point(509, 170)
        Me.LblCredits.Name = "LblCredits"
        Me.LblCredits.Size = New System.Drawing.Size(42, 13)
        Me.LblCredits.TabIndex = 25
        Me.LblCredits.Text = "Credits:"
        '
        'TxtCredits
        '
        Me.TxtCredits.Location = New System.Drawing.Point(505, 185)
        Me.TxtCredits.Name = "TxtCredits"
        Me.TxtCredits.Size = New System.Drawing.Size(152, 20)
        Me.TxtCredits.TabIndex = 26
        '
        'TxtClassSize
        '
        Me.TxtClassSize.Location = New System.Drawing.Point(505, 284)
        Me.TxtClassSize.Name = "TxtClassSize"
        Me.TxtClassSize.Size = New System.Drawing.Size(152, 20)
        Me.TxtClassSize.TabIndex = 27
        '
        'LblClassSize
        '
        Me.LblClassSize.AutoSize = True
        Me.LblClassSize.Location = New System.Drawing.Point(509, 268)
        Me.LblClassSize.Name = "LblClassSize"
        Me.LblClassSize.Size = New System.Drawing.Size(105, 13)
        Me.LblClassSize.TabIndex = 28
        Me.LblClassSize.Text = "Maximum Class Size:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CSCSApplication.My.Resources.Resources.light_usc_logo
        Me.PictureBox1.Location = New System.Drawing.Point(192, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PickSemCreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(777, 484)
        Me.Controls.Add(Me.LblClassSize)
        Me.Controls.Add(Me.TxtClassSize)
        Me.Controls.Add(Me.TxtCredits)
        Me.Controls.Add(Me.LblCredits)
        Me.Controls.Add(Me.LblBack)
        Me.Controls.Add(Me.LblNext)
        Me.Controls.Add(Me.LblDelete)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.CmbType)
        Me.Controls.Add(Me.LblCrsType)
        Me.Controls.Add(Me.LblCrsTitle)
        Me.Controls.Add(Me.LblCrsCode)
        Me.Controls.Add(Me.TxtCrsTitle)
        Me.Controls.Add(Me.TxtCrsCode)
        Me.Controls.Add(Me.LsbCourses)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "PickSemCreate"
        Me.Text = "Pick a Semester"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnSemester1 As RadioButton
    Friend WithEvents BtnSemester2 As RadioButton
    Friend WithEvents BtnSemester3 As RadioButton
    Friend WithEvents LsbCourses As ListBox
    Friend WithEvents TxtCrsCode As TextBox
    Friend WithEvents TxtCrsTitle As TextBox
    Friend WithEvents LblCrsCode As Label
    Friend WithEvents LblCrsTitle As Label
    Friend WithEvents LblCrsType As Label
    Friend WithEvents CmbType As ComboBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LblInstructions As Label
    Friend WithEvents LblDelete As Label
    Friend WithEvents LblNext As LinkLabel
    Friend WithEvents LblBack As LinkLabel
    Friend WithEvents LblCredits As Label
    Friend WithEvents TxtCredits As TextBox
    Friend WithEvents TxtClassSize As TextBox
    Friend WithEvents LblClassSize As Label
End Class
