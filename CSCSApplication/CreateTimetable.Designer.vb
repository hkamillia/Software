<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateTimetable
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblCSCS = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnMW = New System.Windows.Forms.RadioButton()
        Me.BtnTuTh = New System.Windows.Forms.RadioButton()
        Me.CmbCourses1 = New System.Windows.Forms.ComboBox()
        Me.CmbCourses2 = New System.Windows.Forms.ComboBox()
        Me.CmbCourses3 = New System.Windows.Forms.ComboBox()
        Me.CmbLecturers1 = New System.Windows.Forms.ComboBox()
        Me.CmbLecturers2 = New System.Windows.Forms.ComboBox()
        Me.CmbLecturers3 = New System.Windows.Forms.ComboBox()
        Me.CmbLabs1 = New System.Windows.Forms.ComboBox()
        Me.CmbLabs2 = New System.Windows.Forms.ComboBox()
        Me.CmbLabs3 = New System.Windows.Forms.ComboBox()
        Me.CmbLabs4 = New System.Windows.Forms.ComboBox()
        Me.CmbLecturers4 = New System.Windows.Forms.ComboBox()
        Me.CmbCourses4 = New System.Windows.Forms.ComboBox()
        Me.BtnAddNew = New System.Windows.Forms.Button()
        Me.CmbTimes = New System.Windows.Forms.ComboBox()
        Me.LblTime = New System.Windows.Forms.Label()
        Me.LblCourses = New System.Windows.Forms.Label()
        Me.LblLecturers = New System.Windows.Forms.Label()
        Me.LblLabs = New System.Windows.Forms.Label()
        Me.LblBack = New System.Windows.Forms.LinkLabel()
        Me.BtnCheck = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LblCSCS)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(777, 49)
        Me.Panel1.TabIndex = 4
        '
        'LblCSCS
        '
        Me.LblCSCS.AutoSize = True
        Me.LblCSCS.Font = New System.Drawing.Font("Times New Roman", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCSCS.ForeColor = System.Drawing.Color.Ivory
        Me.LblCSCS.Location = New System.Drawing.Point(272, 10)
        Me.LblCSCS.Name = "LblCSCS"
        Me.LblCSCS.Size = New System.Drawing.Size(375, 28)
        Me.LblCSCS.TabIndex = 1
        Me.LblCSCS.Text = "Computer Science Course Scheduler"
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(777, 43)
        Me.Panel2.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(294, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Create Timetable"
        '
        'BtnMW
        '
        Me.BtnMW.AutoSize = True
        Me.BtnMW.Location = New System.Drawing.Point(36, 91)
        Me.BtnMW.Name = "BtnMW"
        Me.BtnMW.Size = New System.Drawing.Size(125, 17)
        Me.BtnMW.TabIndex = 6
        Me.BtnMW.TabStop = True
        Me.BtnMW.Text = "Monday/Wednesday"
        Me.BtnMW.UseVisualStyleBackColor = True
        '
        'BtnTuTh
        '
        Me.BtnTuTh.AutoSize = True
        Me.BtnTuTh.Location = New System.Drawing.Point(202, 91)
        Me.BtnTuTh.Name = "BtnTuTh"
        Me.BtnTuTh.Size = New System.Drawing.Size(115, 17)
        Me.BtnTuTh.TabIndex = 7
        Me.BtnTuTh.TabStop = True
        Me.BtnTuTh.Text = "Tuesday/Thursday"
        Me.BtnTuTh.UseVisualStyleBackColor = True
        '
        'CmbCourses1
        '
        Me.CmbCourses1.FormattingEnabled = True
        Me.CmbCourses1.Location = New System.Drawing.Point(252, 149)
        Me.CmbCourses1.Name = "CmbCourses1"
        Me.CmbCourses1.Size = New System.Drawing.Size(192, 21)
        Me.CmbCourses1.TabIndex = 9
        '
        'CmbCourses2
        '
        Me.CmbCourses2.FormattingEnabled = True
        Me.CmbCourses2.Location = New System.Drawing.Point(252, 188)
        Me.CmbCourses2.Name = "CmbCourses2"
        Me.CmbCourses2.Size = New System.Drawing.Size(192, 21)
        Me.CmbCourses2.TabIndex = 10
        '
        'CmbCourses3
        '
        Me.CmbCourses3.FormattingEnabled = True
        Me.CmbCourses3.Location = New System.Drawing.Point(252, 231)
        Me.CmbCourses3.Name = "CmbCourses3"
        Me.CmbCourses3.Size = New System.Drawing.Size(192, 21)
        Me.CmbCourses3.TabIndex = 11
        '
        'CmbLecturers1
        '
        Me.CmbLecturers1.FormattingEnabled = True
        Me.CmbLecturers1.Location = New System.Drawing.Point(477, 149)
        Me.CmbLecturers1.Name = "CmbLecturers1"
        Me.CmbLecturers1.Size = New System.Drawing.Size(121, 21)
        Me.CmbLecturers1.TabIndex = 13
        '
        'CmbLecturers2
        '
        Me.CmbLecturers2.FormattingEnabled = True
        Me.CmbLecturers2.Location = New System.Drawing.Point(477, 188)
        Me.CmbLecturers2.Name = "CmbLecturers2"
        Me.CmbLecturers2.Size = New System.Drawing.Size(121, 21)
        Me.CmbLecturers2.TabIndex = 14
        '
        'CmbLecturers3
        '
        Me.CmbLecturers3.FormattingEnabled = True
        Me.CmbLecturers3.Location = New System.Drawing.Point(477, 231)
        Me.CmbLecturers3.Name = "CmbLecturers3"
        Me.CmbLecturers3.Size = New System.Drawing.Size(121, 21)
        Me.CmbLecturers3.TabIndex = 15
        '
        'CmbLabs1
        '
        Me.CmbLabs1.FormattingEnabled = True
        Me.CmbLabs1.Location = New System.Drawing.Point(630, 149)
        Me.CmbLabs1.Name = "CmbLabs1"
        Me.CmbLabs1.Size = New System.Drawing.Size(121, 21)
        Me.CmbLabs1.TabIndex = 17
        '
        'CmbLabs2
        '
        Me.CmbLabs2.FormattingEnabled = True
        Me.CmbLabs2.Location = New System.Drawing.Point(630, 188)
        Me.CmbLabs2.Name = "CmbLabs2"
        Me.CmbLabs2.Size = New System.Drawing.Size(121, 21)
        Me.CmbLabs2.TabIndex = 18
        '
        'CmbLabs3
        '
        Me.CmbLabs3.FormattingEnabled = True
        Me.CmbLabs3.Location = New System.Drawing.Point(630, 231)
        Me.CmbLabs3.Name = "CmbLabs3"
        Me.CmbLabs3.Size = New System.Drawing.Size(121, 21)
        Me.CmbLabs3.TabIndex = 19
        '
        'CmbLabs4
        '
        Me.CmbLabs4.FormattingEnabled = True
        Me.CmbLabs4.Location = New System.Drawing.Point(630, 275)
        Me.CmbLabs4.Name = "CmbLabs4"
        Me.CmbLabs4.Size = New System.Drawing.Size(121, 21)
        Me.CmbLabs4.TabIndex = 20
        '
        'CmbLecturers4
        '
        Me.CmbLecturers4.FormattingEnabled = True
        Me.CmbLecturers4.Location = New System.Drawing.Point(477, 275)
        Me.CmbLecturers4.Name = "CmbLecturers4"
        Me.CmbLecturers4.Size = New System.Drawing.Size(121, 21)
        Me.CmbLecturers4.TabIndex = 16
        '
        'CmbCourses4
        '
        Me.CmbCourses4.FormattingEnabled = True
        Me.CmbCourses4.Location = New System.Drawing.Point(252, 275)
        Me.CmbCourses4.Name = "CmbCourses4"
        Me.CmbCourses4.Size = New System.Drawing.Size(192, 21)
        Me.CmbCourses4.TabIndex = 12
        '
        'BtnAddNew
        '
        Me.BtnAddNew.Location = New System.Drawing.Point(66, 188)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(111, 32)
        Me.BtnAddNew.TabIndex = 21
        Me.BtnAddNew.Text = "Add Another Course"
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'CmbTimes
        '
        Me.CmbTimes.FormattingEnabled = True
        Me.CmbTimes.Items.AddRange(New Object() {"8:00AM-9:15AM", "9:25AM-10:40AM", "10:50AM-12:05PM", "12:15PM-1:30PM", "1:40PM-2:55PM", "3:05PM-4:20PM", "4:30PM-5:45PM", "5:55PM-7:10PM", "7:20PM-8:35PM"})
        Me.CmbTimes.Location = New System.Drawing.Point(23, 146)
        Me.CmbTimes.Name = "CmbTimes"
        Me.CmbTimes.Size = New System.Drawing.Size(188, 21)
        Me.CmbTimes.TabIndex = 22
        '
        'LblTime
        '
        Me.LblTime.AutoSize = True
        Me.LblTime.Location = New System.Drawing.Point(91, 130)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(33, 13)
        Me.LblTime.TabIndex = 23
        Me.LblTime.Text = "Time:"
        '
        'LblCourses
        '
        Me.LblCourses.AutoSize = True
        Me.LblCourses.Location = New System.Drawing.Point(295, 127)
        Me.LblCourses.Name = "LblCourses"
        Me.LblCourses.Size = New System.Drawing.Size(48, 13)
        Me.LblCourses.TabIndex = 24
        Me.LblCourses.Text = "Courses:"
        '
        'LblLecturers
        '
        Me.LblLecturers.AutoSize = True
        Me.LblLecturers.Location = New System.Drawing.Point(503, 127)
        Me.LblLecturers.Name = "LblLecturers"
        Me.LblLecturers.Size = New System.Drawing.Size(54, 13)
        Me.LblLecturers.TabIndex = 25
        Me.LblLecturers.Text = "Lecturers:"
        '
        'LblLabs
        '
        Me.LblLabs.AutoSize = True
        Me.LblLabs.Location = New System.Drawing.Point(672, 127)
        Me.LblLabs.Name = "LblLabs"
        Me.LblLabs.Size = New System.Drawing.Size(33, 13)
        Me.LblLabs.TabIndex = 26
        Me.LblLabs.Text = "Labs:"
        '
        'LblBack
        '
        Me.LblBack.AutoSize = True
        Me.LblBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBack.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LblBack.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblBack.Location = New System.Drawing.Point(90, 387)
        Me.LblBack.Name = "LblBack"
        Me.LblBack.Size = New System.Drawing.Size(63, 20)
        Me.LblBack.TabIndex = 27
        Me.LblBack.TabStop = True
        Me.LblBack.Text = "<<Back"
        '
        'BtnCheck
        '
        Me.BtnCheck.Location = New System.Drawing.Point(288, 326)
        Me.BtnCheck.Name = "BtnCheck"
        Me.BtnCheck.Size = New System.Drawing.Size(75, 23)
        Me.BtnCheck.TabIndex = 28
        Me.BtnCheck.Text = "Check"
        Me.BtnCheck.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(406, 326)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 29
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'CreateTimetable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(777, 484)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnCheck)
        Me.Controls.Add(Me.LblBack)
        Me.Controls.Add(Me.LblLabs)
        Me.Controls.Add(Me.LblLecturers)
        Me.Controls.Add(Me.LblCourses)
        Me.Controls.Add(Me.LblTime)
        Me.Controls.Add(Me.CmbTimes)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.CmbLabs4)
        Me.Controls.Add(Me.CmbLabs3)
        Me.Controls.Add(Me.CmbLabs2)
        Me.Controls.Add(Me.CmbLabs1)
        Me.Controls.Add(Me.CmbLecturers4)
        Me.Controls.Add(Me.CmbLecturers3)
        Me.Controls.Add(Me.CmbLecturers2)
        Me.Controls.Add(Me.CmbLecturers1)
        Me.Controls.Add(Me.CmbCourses4)
        Me.Controls.Add(Me.CmbCourses3)
        Me.Controls.Add(Me.CmbCourses2)
        Me.Controls.Add(Me.CmbCourses1)
        Me.Controls.Add(Me.BtnTuTh)
        Me.Controls.Add(Me.BtnMW)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CreateTimetable"
        Me.Text = "Create Timetable"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblCSCS As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnMW As RadioButton
    Friend WithEvents BtnTuTh As RadioButton
    Friend WithEvents CmbCourses1 As ComboBox
    Friend WithEvents CmbCourses2 As ComboBox
    Friend WithEvents CmbCourses3 As ComboBox
    Friend WithEvents CmbLecturers1 As ComboBox
    Friend WithEvents CmbLecturers2 As ComboBox
    Friend WithEvents CmbLecturers3 As ComboBox
    Friend WithEvents CmbLabs1 As ComboBox
    Friend WithEvents CmbLabs2 As ComboBox
    Friend WithEvents CmbLabs3 As ComboBox
    Friend WithEvents CmbLabs4 As ComboBox
    Friend WithEvents CmbLecturers4 As ComboBox
    Friend WithEvents CmbCourses4 As ComboBox
    Friend WithEvents BtnAddNew As Button
    Friend WithEvents CmbTimes As ComboBox
    Friend WithEvents LblTime As Label
    Friend WithEvents LblCourses As Label
    Friend WithEvents LblLecturers As Label
    Friend WithEvents LblLabs As Label
    Friend WithEvents LblBack As LinkLabel
    Friend WithEvents BtnCheck As Button
    Friend WithEvents BtnSave As Button
End Class
