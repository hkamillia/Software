<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateTimetable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateTimetable))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblLogout = New System.Windows.Forms.LinkLabel()
        Me.LblCSCS = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblUpdateTimetable = New System.Windows.Forms.Label()
        Me.BtnSemester1 = New System.Windows.Forms.RadioButton()
        Me.BtnSemester2 = New System.Windows.Forms.RadioButton()
        Me.BtnSemester3 = New System.Windows.Forms.RadioButton()
        Me.DgdTimetable = New System.Windows.Forms.DataGridView()
        Me.TxtCrsCode = New System.Windows.Forms.TextBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.LblCrsCode = New System.Windows.Forms.Label()
        Me.TxtCrsTitle = New System.Windows.Forms.TextBox()
        Me.LblCrsTitle = New System.Windows.Forms.Label()
        Me.TxtCredits = New System.Windows.Forms.TextBox()
        Me.LblCredits = New System.Windows.Forms.Label()
        Me.LblDays = New System.Windows.Forms.Label()
        Me.CmbDays = New System.Windows.Forms.ComboBox()
        Me.LblTime = New System.Windows.Forms.Label()
        Me.CmbTimes = New System.Windows.Forms.ComboBox()
        Me.LblLab = New System.Windows.Forms.Label()
        Me.CmbLabs = New System.Windows.Forms.ComboBox()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.LblLecturer = New System.Windows.Forms.Label()
        Me.TxtLecturer = New System.Windows.Forms.TextBox()
        Me.CmbLecturers = New System.Windows.Forms.ComboBox()
        Me.LblNewLecturer = New System.Windows.Forms.Label()
        Me.BtnUpdateLect = New System.Windows.Forms.Button()
        Me.LblHome = New System.Windows.Forms.LinkLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DgdTimetable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LblLogout)
        Me.Panel1.Controls.Add(Me.LblCSCS)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(862, 49)
        Me.Panel1.TabIndex = 5
        '
        'LblLogout
        '
        Me.LblLogout.ActiveLinkColor = System.Drawing.Color.OliveDrab
        Me.LblLogout.AutoSize = True
        Me.LblLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLogout.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LblLogout.LinkColor = System.Drawing.Color.OliveDrab
        Me.LblLogout.Location = New System.Drawing.Point(749, 16)
        Me.LblLogout.Name = "LblLogout"
        Me.LblLogout.Size = New System.Drawing.Size(82, 20)
        Me.LblLogout.TabIndex = 9
        Me.LblLogout.TabStop = True
        Me.LblLogout.Text = "LOGOUT"
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
        Me.Panel2.Controls.Add(Me.LblUpdateTimetable)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 49)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(862, 43)
        Me.Panel2.TabIndex = 6
        '
        'LblUpdateTimetable
        '
        Me.LblUpdateTimetable.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblUpdateTimetable.AutoSize = True
        Me.LblUpdateTimetable.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUpdateTimetable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.LblUpdateTimetable.Location = New System.Drawing.Point(294, 11)
        Me.LblUpdateTimetable.Name = "LblUpdateTimetable"
        Me.LblUpdateTimetable.Size = New System.Drawing.Size(174, 24)
        Me.LblUpdateTimetable.TabIndex = 0
        Me.LblUpdateTimetable.Text = "Update Timetable"
        Me.LblUpdateTimetable.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnSemester1
        '
        Me.BtnSemester1.AutoSize = True
        Me.BtnSemester1.Location = New System.Drawing.Point(12, 124)
        Me.BtnSemester1.Name = "BtnSemester1"
        Me.BtnSemester1.Size = New System.Drawing.Size(86, 17)
        Me.BtnSemester1.TabIndex = 2
        Me.BtnSemester1.Text = "1st Semester"
        Me.BtnSemester1.UseVisualStyleBackColor = True
        '
        'BtnSemester2
        '
        Me.BtnSemester2.AutoSize = True
        Me.BtnSemester2.Location = New System.Drawing.Point(127, 124)
        Me.BtnSemester2.Name = "BtnSemester2"
        Me.BtnSemester2.Size = New System.Drawing.Size(90, 17)
        Me.BtnSemester2.TabIndex = 3
        Me.BtnSemester2.Text = "2nd Semester"
        Me.BtnSemester2.UseVisualStyleBackColor = True
        '
        'BtnSemester3
        '
        Me.BtnSemester3.AutoSize = True
        Me.BtnSemester3.Location = New System.Drawing.Point(248, 124)
        Me.BtnSemester3.Name = "BtnSemester3"
        Me.BtnSemester3.Size = New System.Drawing.Size(87, 17)
        Me.BtnSemester3.TabIndex = 4
        Me.BtnSemester3.Text = "3rd Semester"
        Me.BtnSemester3.UseVisualStyleBackColor = True
        '
        'DgdTimetable
        '
        Me.DgdTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdTimetable.Location = New System.Drawing.Point(368, 137)
        Me.DgdTimetable.Name = "DgdTimetable"
        Me.DgdTimetable.Size = New System.Drawing.Size(482, 335)
        Me.DgdTimetable.TabIndex = 7
        '
        'TxtCrsCode
        '
        Me.TxtCrsCode.Location = New System.Drawing.Point(96, 165)
        Me.TxtCrsCode.Name = "TxtCrsCode"
        Me.TxtCrsCode.Size = New System.Drawing.Size(146, 20)
        Me.TxtCrsCode.TabIndex = 8
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(248, 163)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(75, 23)
        Me.BtnSearch.TabIndex = 9
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'LblCrsCode
        '
        Me.LblCrsCode.AutoSize = True
        Me.LblCrsCode.Location = New System.Drawing.Point(19, 168)
        Me.LblCrsCode.Name = "LblCrsCode"
        Me.LblCrsCode.Size = New System.Drawing.Size(71, 13)
        Me.LblCrsCode.TabIndex = 10
        Me.LblCrsCode.Text = "Course Code:"
        '
        'TxtCrsTitle
        '
        Me.TxtCrsTitle.Location = New System.Drawing.Point(96, 207)
        Me.TxtCrsTitle.Name = "TxtCrsTitle"
        Me.TxtCrsTitle.Size = New System.Drawing.Size(203, 20)
        Me.TxtCrsTitle.TabIndex = 11
        '
        'LblCrsTitle
        '
        Me.LblCrsTitle.AutoSize = True
        Me.LblCrsTitle.Location = New System.Drawing.Point(19, 210)
        Me.LblCrsTitle.Name = "LblCrsTitle"
        Me.LblCrsTitle.Size = New System.Drawing.Size(66, 13)
        Me.LblCrsTitle.TabIndex = 12
        Me.LblCrsTitle.Text = "Course Title:"
        '
        'TxtCredits
        '
        Me.TxtCredits.Location = New System.Drawing.Point(96, 251)
        Me.TxtCredits.Name = "TxtCredits"
        Me.TxtCredits.Size = New System.Drawing.Size(86, 20)
        Me.TxtCredits.TabIndex = 13
        '
        'LblCredits
        '
        Me.LblCredits.AutoSize = True
        Me.LblCredits.Location = New System.Drawing.Point(19, 254)
        Me.LblCredits.Name = "LblCredits"
        Me.LblCredits.Size = New System.Drawing.Size(42, 13)
        Me.LblCredits.TabIndex = 14
        Me.LblCredits.Text = "Credits:"
        '
        'LblDays
        '
        Me.LblDays.AutoSize = True
        Me.LblDays.Location = New System.Drawing.Point(19, 297)
        Me.LblDays.Name = "LblDays"
        Me.LblDays.Size = New System.Drawing.Size(34, 13)
        Me.LblDays.TabIndex = 15
        Me.LblDays.Text = "Days:"
        '
        'CmbDays
        '
        Me.CmbDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDays.FormattingEnabled = True
        Me.CmbDays.Items.AddRange(New Object() {"M/W", "Tu/Th"})
        Me.CmbDays.Location = New System.Drawing.Point(96, 297)
        Me.CmbDays.Name = "CmbDays"
        Me.CmbDays.Size = New System.Drawing.Size(121, 21)
        Me.CmbDays.TabIndex = 16
        '
        'LblTime
        '
        Me.LblTime.AutoSize = True
        Me.LblTime.Location = New System.Drawing.Point(19, 341)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(33, 13)
        Me.LblTime.TabIndex = 17
        Me.LblTime.Text = "Time:"
        '
        'CmbTimes
        '
        Me.CmbTimes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTimes.FormattingEnabled = True
        Me.CmbTimes.Items.AddRange(New Object() {"8:00AM-9:15AM", "9:25AM-10:40AM", "10:50AM-12:05PM", "12:15PM-1:30PM", "1:40PM-2:55PM", "3:05PM-4:20PM", "4:30PM-5:45PM", "5:55PM-7:10PM", "7:20PM-8:35PM"})
        Me.CmbTimes.Location = New System.Drawing.Point(96, 338)
        Me.CmbTimes.Name = "CmbTimes"
        Me.CmbTimes.Size = New System.Drawing.Size(188, 21)
        Me.CmbTimes.TabIndex = 23
        '
        'LblLab
        '
        Me.LblLab.AutoSize = True
        Me.LblLab.Location = New System.Drawing.Point(20, 383)
        Me.LblLab.Name = "LblLab"
        Me.LblLab.Size = New System.Drawing.Size(28, 13)
        Me.LblLab.TabIndex = 24
        Me.LblLab.Text = "Lab:"
        '
        'CmbLabs
        '
        Me.CmbLabs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbLabs.FormattingEnabled = True
        Me.CmbLabs.Location = New System.Drawing.Point(96, 383)
        Me.CmbLabs.Name = "CmbLabs"
        Me.CmbLabs.Size = New System.Drawing.Size(121, 21)
        Me.CmbLabs.TabIndex = 25
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(248, 383)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 26
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'LblLecturer
        '
        Me.LblLecturer.AutoSize = True
        Me.LblLecturer.Location = New System.Drawing.Point(20, 428)
        Me.LblLecturer.Name = "LblLecturer"
        Me.LblLecturer.Size = New System.Drawing.Size(49, 13)
        Me.LblLecturer.TabIndex = 27
        Me.LblLecturer.Text = "Lecturer:"
        '
        'TxtLecturer
        '
        Me.TxtLecturer.Location = New System.Drawing.Point(96, 425)
        Me.TxtLecturer.Name = "TxtLecturer"
        Me.TxtLecturer.Size = New System.Drawing.Size(146, 20)
        Me.TxtLecturer.TabIndex = 28
        '
        'CmbLecturers
        '
        Me.CmbLecturers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbLecturers.FormattingEnabled = True
        Me.CmbLecturers.Location = New System.Drawing.Point(96, 451)
        Me.CmbLecturers.Name = "CmbLecturers"
        Me.CmbLecturers.Size = New System.Drawing.Size(146, 21)
        Me.CmbLecturers.TabIndex = 29
        '
        'LblNewLecturer
        '
        Me.LblNewLecturer.AutoSize = True
        Me.LblNewLecturer.Location = New System.Drawing.Point(19, 459)
        Me.LblNewLecturer.Name = "LblNewLecturer"
        Me.LblNewLecturer.Size = New System.Drawing.Size(74, 13)
        Me.LblNewLecturer.TabIndex = 30
        Me.LblNewLecturer.Text = "New Lecturer:"
        '
        'BtnUpdateLect
        '
        Me.BtnUpdateLect.Location = New System.Drawing.Point(248, 449)
        Me.BtnUpdateLect.Name = "BtnUpdateLect"
        Me.BtnUpdateLect.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdateLect.TabIndex = 31
        Me.BtnUpdateLect.Text = "Update"
        Me.BtnUpdateLect.UseVisualStyleBackColor = True
        '
        'LblHome
        '
        Me.LblHome.AutoSize = True
        Me.LblHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHome.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LblHome.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblHome.Location = New System.Drawing.Point(19, 95)
        Me.LblHome.Name = "LblHome"
        Me.LblHome.Size = New System.Drawing.Size(132, 18)
        Me.LblHome.TabIndex = 32
        Me.LblHome.TabStop = True
        Me.LblHome.Text = "<<Return to Home"
        '
        'UpdateTimetable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(862, 503)
        Me.Controls.Add(Me.LblHome)
        Me.Controls.Add(Me.BtnUpdateLect)
        Me.Controls.Add(Me.LblNewLecturer)
        Me.Controls.Add(Me.CmbLecturers)
        Me.Controls.Add(Me.TxtLecturer)
        Me.Controls.Add(Me.LblLecturer)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.CmbLabs)
        Me.Controls.Add(Me.LblLab)
        Me.Controls.Add(Me.CmbTimes)
        Me.Controls.Add(Me.LblTime)
        Me.Controls.Add(Me.CmbDays)
        Me.Controls.Add(Me.LblDays)
        Me.Controls.Add(Me.LblCredits)
        Me.Controls.Add(Me.TxtCredits)
        Me.Controls.Add(Me.LblCrsTitle)
        Me.Controls.Add(Me.TxtCrsTitle)
        Me.Controls.Add(Me.LblCrsCode)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TxtCrsCode)
        Me.Controls.Add(Me.DgdTimetable)
        Me.Controls.Add(Me.BtnSemester3)
        Me.Controls.Add(Me.BtnSemester2)
        Me.Controls.Add(Me.BtnSemester1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UpdateTimetable"
        Me.Text = "Update Timetable"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DgdTimetable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblCSCS As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LblUpdateTimetable As Label
    Friend WithEvents BtnSemester1 As RadioButton
    Friend WithEvents BtnSemester2 As RadioButton
    Friend WithEvents BtnSemester3 As RadioButton
    Friend WithEvents DgdTimetable As DataGridView
    Friend WithEvents TxtCrsCode As TextBox
    Friend WithEvents BtnSearch As Button
    Friend WithEvents LblCrsCode As Label
    Friend WithEvents TxtCrsTitle As TextBox
    Friend WithEvents LblCrsTitle As Label
    Friend WithEvents TxtCredits As TextBox
    Friend WithEvents LblCredits As Label
    Friend WithEvents LblDays As Label
    Friend WithEvents CmbDays As ComboBox
    Friend WithEvents LblTime As Label
    Friend WithEvents CmbTimes As ComboBox
    Friend WithEvents LblLab As Label
    Friend WithEvents CmbLabs As ComboBox
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents LblLecturer As Label
    Friend WithEvents TxtLecturer As TextBox
    Friend WithEvents CmbLecturers As ComboBox
    Friend WithEvents LblNewLecturer As Label
    Friend WithEvents BtnUpdateLect As Button
    Friend WithEvents LblHome As LinkLabel
    Friend WithEvents LblLogout As LinkLabel
End Class
