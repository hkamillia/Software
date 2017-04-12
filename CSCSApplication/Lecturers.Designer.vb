<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Lecturers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lecturers))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblLogout = New System.Windows.Forms.LinkLabel()
        Me.LblCSCS = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabLecturers = New System.Windows.Forms.TabControl()
        Me.AddLecturer = New System.Windows.Forms.TabPage()
        Me.LblHome1 = New System.Windows.Forms.LinkLabel()
        Me.LblAllLecturers = New System.Windows.Forms.Label()
        Me.DgdLecturers = New System.Windows.Forms.DataGridView()
        Me.LblTimes = New System.Windows.Forms.Label()
        Me.LblLname = New System.Windows.Forms.Label()
        Me.LblFname = New System.Windows.Forms.Label()
        Me.LblLecturerID = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.CmbTimes = New System.Windows.Forms.ComboBox()
        Me.TxtLname = New System.Windows.Forms.TextBox()
        Me.TxtFname = New System.Windows.Forms.TextBox()
        Me.TxtLecturerID = New System.Windows.Forms.TextBox()
        Me.UpdateLecturer = New System.Windows.Forms.TabPage()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.LblHome2 = New System.Windows.Forms.LinkLabel()
        Me.LblAllLecturers2 = New System.Windows.Forms.Label()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.CmbTimes2 = New System.Windows.Forms.ComboBox()
        Me.LblTimeAvailable = New System.Windows.Forms.Label()
        Me.TxtUsedCredits = New System.Windows.Forms.TextBox()
        Me.LblUsedCredits = New System.Windows.Forms.Label()
        Me.TxtLname2 = New System.Windows.Forms.TextBox()
        Me.LblLname2 = New System.Windows.Forms.Label()
        Me.TxtFname2 = New System.Windows.Forms.TextBox()
        Me.LblFname2 = New System.Windows.Forms.Label()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.TxtLecturerID2 = New System.Windows.Forms.TextBox()
        Me.LblLecturerID2 = New System.Windows.Forms.Label()
        Me.DgdLecturers2 = New System.Windows.Forms.DataGridView()
        Me.ViewLecturers = New System.Windows.Forms.TabPage()
        Me.LblHome3 = New System.Windows.Forms.LinkLabel()
        Me.LblAllLecturers3 = New System.Windows.Forms.Label()
        Me.DgdLecturers3 = New System.Windows.Forms.DataGridView()
        Me.DeleteLecturer = New System.Windows.Forms.TabPage()
        Me.LblHome4 = New System.Windows.Forms.LinkLabel()
        Me.LblAllLecturers4 = New System.Windows.Forms.Label()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.LblDelete = New System.Windows.Forms.Label()
        Me.DgdLecturers4 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblManage = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabLecturers.SuspendLayout()
        Me.AddLecturer.SuspendLayout()
        CType(Me.DgdLecturers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UpdateLecturer.SuspendLayout()
        CType(Me.DgdLecturers2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ViewLecturers.SuspendLayout()
        CType(Me.DgdLecturers3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DeleteLecturer.SuspendLayout()
        CType(Me.DgdLecturers4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(777, 49)
        Me.Panel1.TabIndex = 2
        '
        'LblLogout
        '
        Me.LblLogout.ActiveLinkColor = System.Drawing.Color.OliveDrab
        Me.LblLogout.AutoSize = True
        Me.LblLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLogout.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LblLogout.LinkColor = System.Drawing.Color.OliveDrab
        Me.LblLogout.Location = New System.Drawing.Point(683, 16)
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
        'TabLecturers
        '
        Me.TabLecturers.Controls.Add(Me.AddLecturer)
        Me.TabLecturers.Controls.Add(Me.UpdateLecturer)
        Me.TabLecturers.Controls.Add(Me.ViewLecturers)
        Me.TabLecturers.Controls.Add(Me.DeleteLecturer)
        Me.TabLecturers.Location = New System.Drawing.Point(0, 89)
        Me.TabLecturers.Name = "TabLecturers"
        Me.TabLecturers.SelectedIndex = 0
        Me.TabLecturers.Size = New System.Drawing.Size(774, 395)
        Me.TabLecturers.TabIndex = 3
        '
        'AddLecturer
        '
        Me.AddLecturer.Controls.Add(Me.LblHome1)
        Me.AddLecturer.Controls.Add(Me.LblAllLecturers)
        Me.AddLecturer.Controls.Add(Me.DgdLecturers)
        Me.AddLecturer.Controls.Add(Me.LblTimes)
        Me.AddLecturer.Controls.Add(Me.LblLname)
        Me.AddLecturer.Controls.Add(Me.LblFname)
        Me.AddLecturer.Controls.Add(Me.LblLecturerID)
        Me.AddLecturer.Controls.Add(Me.BtnAdd)
        Me.AddLecturer.Controls.Add(Me.CmbTimes)
        Me.AddLecturer.Controls.Add(Me.TxtLname)
        Me.AddLecturer.Controls.Add(Me.TxtFname)
        Me.AddLecturer.Controls.Add(Me.TxtLecturerID)
        Me.AddLecturer.Location = New System.Drawing.Point(4, 22)
        Me.AddLecturer.Name = "AddLecturer"
        Me.AddLecturer.Padding = New System.Windows.Forms.Padding(3)
        Me.AddLecturer.Size = New System.Drawing.Size(766, 369)
        Me.AddLecturer.TabIndex = 0
        Me.AddLecturer.Text = "Add Lecturer"
        Me.AddLecturer.UseVisualStyleBackColor = True
        '
        'LblHome1
        '
        Me.LblHome1.AutoSize = True
        Me.LblHome1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHome1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LblHome1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblHome1.Location = New System.Drawing.Point(21, 326)
        Me.LblHome1.Name = "LblHome1"
        Me.LblHome1.Size = New System.Drawing.Size(132, 18)
        Me.LblHome1.TabIndex = 29
        Me.LblHome1.TabStop = True
        Me.LblHome1.Text = "<<Return to Home"
        '
        'LblAllLecturers
        '
        Me.LblAllLecturers.AutoSize = True
        Me.LblAllLecturers.Location = New System.Drawing.Point(489, 18)
        Me.LblAllLecturers.Name = "LblAllLecturers"
        Me.LblAllLecturers.Size = New System.Drawing.Size(102, 13)
        Me.LblAllLecturers.TabIndex = 11
        Me.LblAllLecturers.Text = "All Current Lecturers"
        '
        'DgdLecturers
        '
        Me.DgdLecturers.AllowUserToAddRows = False
        Me.DgdLecturers.AllowUserToDeleteRows = False
        Me.DgdLecturers.AllowUserToOrderColumns = True
        Me.DgdLecturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdLecturers.Location = New System.Drawing.Point(322, 34)
        Me.DgdLecturers.Name = "DgdLecturers"
        Me.DgdLecturers.ReadOnly = True
        Me.DgdLecturers.Size = New System.Drawing.Size(438, 327)
        Me.DgdLecturers.TabIndex = 10
        '
        'LblTimes
        '
        Me.LblTimes.AutoSize = True
        Me.LblTimes.Location = New System.Drawing.Point(18, 195)
        Me.LblTimes.Name = "LblTimes"
        Me.LblTimes.Size = New System.Drawing.Size(79, 13)
        Me.LblTimes.TabIndex = 9
        Me.LblTimes.Text = "Time Available:"
        '
        'LblLname
        '
        Me.LblLname.AutoSize = True
        Me.LblLname.Location = New System.Drawing.Point(21, 145)
        Me.LblLname.Name = "LblLname"
        Me.LblLname.Size = New System.Drawing.Size(61, 13)
        Me.LblLname.TabIndex = 8
        Me.LblLname.Text = "Last Name:"
        '
        'LblFname
        '
        Me.LblFname.AutoSize = True
        Me.LblFname.Location = New System.Drawing.Point(21, 97)
        Me.LblFname.Name = "LblFname"
        Me.LblFname.Size = New System.Drawing.Size(60, 13)
        Me.LblFname.TabIndex = 7
        Me.LblFname.Text = "First Name:"
        '
        'LblLecturerID
        '
        Me.LblLecturerID.AutoSize = True
        Me.LblLecturerID.Location = New System.Drawing.Point(21, 47)
        Me.LblLecturerID.Name = "LblLecturerID"
        Me.LblLecturerID.Size = New System.Drawing.Size(63, 13)
        Me.LblLecturerID.TabIndex = 6
        Me.LblLecturerID.Text = "Lecturer ID:"
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(137, 239)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 5
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'CmbTimes
        '
        Me.CmbTimes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTimes.FormattingEnabled = True
        Me.CmbTimes.Items.AddRange(New Object() {"Full Time", "Part Time-Morning (8:00AM-12:05PM)", "Part Time-Afternoon (12:15PM-4:20PM)", "Part Time-Evening (4:30PM-8:35PM)"})
        Me.CmbTimes.Location = New System.Drawing.Point(103, 187)
        Me.CmbTimes.Name = "CmbTimes"
        Me.CmbTimes.Size = New System.Drawing.Size(199, 21)
        Me.CmbTimes.TabIndex = 4
        '
        'TxtLname
        '
        Me.TxtLname.Location = New System.Drawing.Point(103, 138)
        Me.TxtLname.Name = "TxtLname"
        Me.TxtLname.Size = New System.Drawing.Size(146, 20)
        Me.TxtLname.TabIndex = 2
        '
        'TxtFname
        '
        Me.TxtFname.Location = New System.Drawing.Point(103, 94)
        Me.TxtFname.Name = "TxtFname"
        Me.TxtFname.Size = New System.Drawing.Size(146, 20)
        Me.TxtFname.TabIndex = 1
        '
        'TxtLecturerID
        '
        Me.TxtLecturerID.Location = New System.Drawing.Point(103, 47)
        Me.TxtLecturerID.Name = "TxtLecturerID"
        Me.TxtLecturerID.Size = New System.Drawing.Size(146, 20)
        Me.TxtLecturerID.TabIndex = 0
        '
        'UpdateLecturer
        '
        Me.UpdateLecturer.Controls.Add(Me.BtnReset)
        Me.UpdateLecturer.Controls.Add(Me.LblHome2)
        Me.UpdateLecturer.Controls.Add(Me.LblAllLecturers2)
        Me.UpdateLecturer.Controls.Add(Me.BtnSearch)
        Me.UpdateLecturer.Controls.Add(Me.CmbTimes2)
        Me.UpdateLecturer.Controls.Add(Me.LblTimeAvailable)
        Me.UpdateLecturer.Controls.Add(Me.TxtUsedCredits)
        Me.UpdateLecturer.Controls.Add(Me.LblUsedCredits)
        Me.UpdateLecturer.Controls.Add(Me.TxtLname2)
        Me.UpdateLecturer.Controls.Add(Me.LblLname2)
        Me.UpdateLecturer.Controls.Add(Me.TxtFname2)
        Me.UpdateLecturer.Controls.Add(Me.LblFname2)
        Me.UpdateLecturer.Controls.Add(Me.BtnUpdate)
        Me.UpdateLecturer.Controls.Add(Me.TxtLecturerID2)
        Me.UpdateLecturer.Controls.Add(Me.LblLecturerID2)
        Me.UpdateLecturer.Controls.Add(Me.DgdLecturers2)
        Me.UpdateLecturer.Location = New System.Drawing.Point(4, 22)
        Me.UpdateLecturer.Name = "UpdateLecturer"
        Me.UpdateLecturer.Padding = New System.Windows.Forms.Padding(3)
        Me.UpdateLecturer.Size = New System.Drawing.Size(766, 369)
        Me.UpdateLecturer.TabIndex = 1
        Me.UpdateLecturer.Text = "Update Lecturer"
        Me.UpdateLecturer.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(241, 178)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(75, 23)
        Me.BtnReset.TabIndex = 29
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'LblHome2
        '
        Me.LblHome2.AutoSize = True
        Me.LblHome2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHome2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LblHome2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblHome2.Location = New System.Drawing.Point(19, 322)
        Me.LblHome2.Name = "LblHome2"
        Me.LblHome2.Size = New System.Drawing.Size(132, 18)
        Me.LblHome2.TabIndex = 28
        Me.LblHome2.TabStop = True
        Me.LblHome2.Text = "<<Return to Home"
        '
        'LblAllLecturers2
        '
        Me.LblAllLecturers2.AutoSize = True
        Me.LblAllLecturers2.Location = New System.Drawing.Point(482, 18)
        Me.LblAllLecturers2.Name = "LblAllLecturers2"
        Me.LblAllLecturers2.Size = New System.Drawing.Size(102, 13)
        Me.LblAllLecturers2.TabIndex = 24
        Me.LblAllLecturers2.Text = "All Current Lecturers"
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(241, 42)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(75, 23)
        Me.BtnSearch.TabIndex = 23
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'CmbTimes2
        '
        Me.CmbTimes2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTimes2.FormattingEnabled = True
        Me.CmbTimes2.Items.AddRange(New Object() {"Full Time", "Part Time-Morning (8:00AM-12:05PM)", "Part Time-Afternoon (12:15PM-4:20PM)", "Part Time-Evening (4:30PM-8:35PM)"})
        Me.CmbTimes2.Location = New System.Drawing.Point(104, 229)
        Me.CmbTimes2.Name = "CmbTimes2"
        Me.CmbTimes2.Size = New System.Drawing.Size(199, 21)
        Me.CmbTimes2.TabIndex = 22
        '
        'LblTimeAvailable
        '
        Me.LblTimeAvailable.AutoSize = True
        Me.LblTimeAvailable.Location = New System.Drawing.Point(19, 232)
        Me.LblTimeAvailable.Name = "LblTimeAvailable"
        Me.LblTimeAvailable.Size = New System.Drawing.Size(79, 13)
        Me.LblTimeAvailable.TabIndex = 21
        Me.LblTimeAvailable.Text = "Time Available:"
        '
        'TxtUsedCredits
        '
        Me.TxtUsedCredits.Location = New System.Drawing.Point(116, 180)
        Me.TxtUsedCredits.Name = "TxtUsedCredits"
        Me.TxtUsedCredits.Size = New System.Drawing.Size(118, 20)
        Me.TxtUsedCredits.TabIndex = 20
        '
        'LblUsedCredits
        '
        Me.LblUsedCredits.AutoSize = True
        Me.LblUsedCredits.Location = New System.Drawing.Point(19, 187)
        Me.LblUsedCredits.Name = "LblUsedCredits"
        Me.LblUsedCredits.Size = New System.Drawing.Size(81, 13)
        Me.LblUsedCredits.TabIndex = 19
        Me.LblUsedCredits.Text = "Used CreditHrs:"
        '
        'TxtLname2
        '
        Me.TxtLname2.Location = New System.Drawing.Point(88, 137)
        Me.TxtLname2.Name = "TxtLname2"
        Me.TxtLname2.Size = New System.Drawing.Size(146, 20)
        Me.TxtLname2.TabIndex = 18
        '
        'LblLname2
        '
        Me.LblLname2.AutoSize = True
        Me.LblLname2.Location = New System.Drawing.Point(19, 140)
        Me.LblLname2.Name = "LblLname2"
        Me.LblLname2.Size = New System.Drawing.Size(61, 13)
        Me.LblLname2.TabIndex = 17
        Me.LblLname2.Text = "Last Name:"
        '
        'TxtFname2
        '
        Me.TxtFname2.Location = New System.Drawing.Point(88, 89)
        Me.TxtFname2.Name = "TxtFname2"
        Me.TxtFname2.Size = New System.Drawing.Size(146, 20)
        Me.TxtFname2.TabIndex = 16
        '
        'LblFname2
        '
        Me.LblFname2.AutoSize = True
        Me.LblFname2.Location = New System.Drawing.Point(19, 96)
        Me.LblFname2.Name = "LblFname2"
        Me.LblFname2.Size = New System.Drawing.Size(60, 13)
        Me.LblFname2.TabIndex = 15
        Me.LblFname2.Text = "First Name:"
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(126, 279)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 14
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'TxtLecturerID2
        '
        Me.TxtLecturerID2.Location = New System.Drawing.Point(88, 44)
        Me.TxtLecturerID2.Name = "TxtLecturerID2"
        Me.TxtLecturerID2.Size = New System.Drawing.Size(146, 20)
        Me.TxtLecturerID2.TabIndex = 13
        '
        'LblLecturerID2
        '
        Me.LblLecturerID2.AutoSize = True
        Me.LblLecturerID2.Location = New System.Drawing.Point(19, 47)
        Me.LblLecturerID2.Name = "LblLecturerID2"
        Me.LblLecturerID2.Size = New System.Drawing.Size(63, 13)
        Me.LblLecturerID2.TabIndex = 12
        Me.LblLecturerID2.Text = "Lecturer ID:"
        '
        'DgdLecturers2
        '
        Me.DgdLecturers2.AllowUserToAddRows = False
        Me.DgdLecturers2.AllowUserToDeleteRows = False
        Me.DgdLecturers2.AllowUserToOrderColumns = True
        Me.DgdLecturers2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdLecturers2.Location = New System.Drawing.Point(322, 34)
        Me.DgdLecturers2.Name = "DgdLecturers2"
        Me.DgdLecturers2.ReadOnly = True
        Me.DgdLecturers2.Size = New System.Drawing.Size(438, 327)
        Me.DgdLecturers2.TabIndex = 11
        '
        'ViewLecturers
        '
        Me.ViewLecturers.Controls.Add(Me.LblHome3)
        Me.ViewLecturers.Controls.Add(Me.LblAllLecturers3)
        Me.ViewLecturers.Controls.Add(Me.DgdLecturers3)
        Me.ViewLecturers.Location = New System.Drawing.Point(4, 22)
        Me.ViewLecturers.Name = "ViewLecturers"
        Me.ViewLecturers.Padding = New System.Windows.Forms.Padding(3)
        Me.ViewLecturers.Size = New System.Drawing.Size(766, 369)
        Me.ViewLecturers.TabIndex = 2
        Me.ViewLecturers.Text = "View Lecturers"
        Me.ViewLecturers.UseVisualStyleBackColor = True
        '
        'LblHome3
        '
        Me.LblHome3.AutoSize = True
        Me.LblHome3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHome3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LblHome3.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblHome3.Location = New System.Drawing.Point(24, 346)
        Me.LblHome3.Name = "LblHome3"
        Me.LblHome3.Size = New System.Drawing.Size(132, 18)
        Me.LblHome3.TabIndex = 30
        Me.LblHome3.TabStop = True
        Me.LblHome3.Text = "<<Return to Home"
        '
        'LblAllLecturers3
        '
        Me.LblAllLecturers3.AutoSize = True
        Me.LblAllLecturers3.Location = New System.Drawing.Point(335, 15)
        Me.LblAllLecturers3.Name = "LblAllLecturers3"
        Me.LblAllLecturers3.Size = New System.Drawing.Size(102, 13)
        Me.LblAllLecturers3.TabIndex = 25
        Me.LblAllLecturers3.Text = "All Current Lecturers"
        '
        'DgdLecturers3
        '
        Me.DgdLecturers3.AllowUserToAddRows = False
        Me.DgdLecturers3.AllowUserToDeleteRows = False
        Me.DgdLecturers3.AllowUserToOrderColumns = True
        Me.DgdLecturers3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdLecturers3.Location = New System.Drawing.Point(18, 31)
        Me.DgdLecturers3.Name = "DgdLecturers3"
        Me.DgdLecturers3.ReadOnly = True
        Me.DgdLecturers3.Size = New System.Drawing.Size(731, 299)
        Me.DgdLecturers3.TabIndex = 0
        '
        'DeleteLecturer
        '
        Me.DeleteLecturer.Controls.Add(Me.LblHome4)
        Me.DeleteLecturer.Controls.Add(Me.LblAllLecturers4)
        Me.DeleteLecturer.Controls.Add(Me.BtnDelete)
        Me.DeleteLecturer.Controls.Add(Me.LblDelete)
        Me.DeleteLecturer.Controls.Add(Me.DgdLecturers4)
        Me.DeleteLecturer.Location = New System.Drawing.Point(4, 22)
        Me.DeleteLecturer.Name = "DeleteLecturer"
        Me.DeleteLecturer.Padding = New System.Windows.Forms.Padding(3)
        Me.DeleteLecturer.Size = New System.Drawing.Size(766, 369)
        Me.DeleteLecturer.TabIndex = 3
        Me.DeleteLecturer.Text = "Delete Lecturer"
        Me.DeleteLecturer.UseVisualStyleBackColor = True
        '
        'LblHome4
        '
        Me.LblHome4.AutoSize = True
        Me.LblHome4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHome4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LblHome4.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblHome4.Location = New System.Drawing.Point(22, 313)
        Me.LblHome4.Name = "LblHome4"
        Me.LblHome4.Size = New System.Drawing.Size(132, 18)
        Me.LblHome4.TabIndex = 29
        Me.LblHome4.TabStop = True
        Me.LblHome4.Text = "<<Return to Home"
        '
        'LblAllLecturers4
        '
        Me.LblAllLecturers4.AutoSize = True
        Me.LblAllLecturers4.Location = New System.Drawing.Point(429, 21)
        Me.LblAllLecturers4.Name = "LblAllLecturers4"
        Me.LblAllLecturers4.Size = New System.Drawing.Size(102, 13)
        Me.LblAllLecturers4.TabIndex = 26
        Me.LblAllLecturers4.Text = "All Current Lecturers"
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(46, 83)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 25
        Me.BtnDelete.Text = "Delete "
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'LblDelete
        '
        Me.LblDelete.AutoSize = True
        Me.LblDelete.Location = New System.Drawing.Point(22, 54)
        Me.LblDelete.Name = "LblDelete"
        Me.LblDelete.Size = New System.Drawing.Size(146, 13)
        Me.LblDelete.TabIndex = 24
        Me.LblDelete.Text = "Select Row then click delete:"
        '
        'DgdLecturers4
        '
        Me.DgdLecturers4.AllowUserToAddRows = False
        Me.DgdLecturers4.AllowUserToDeleteRows = False
        Me.DgdLecturers4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdLecturers4.Location = New System.Drawing.Point(195, 37)
        Me.DgdLecturers4.Name = "DgdLecturers4"
        Me.DgdLecturers4.ReadOnly = True
        Me.DgdLecturers4.Size = New System.Drawing.Size(555, 311)
        Me.DgdLecturers4.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.LblManage)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 49)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(777, 37)
        Me.Panel2.TabIndex = 4
        '
        'LblManage
        '
        Me.LblManage.AutoSize = True
        Me.LblManage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblManage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.LblManage.Location = New System.Drawing.Point(307, 6)
        Me.LblManage.Name = "LblManage"
        Me.LblManage.Size = New System.Drawing.Size(178, 24)
        Me.LblManage.TabIndex = 0
        Me.LblManage.Text = "Manage Lecturers"
        '
        'Lecturers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(777, 484)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TabLecturers)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Lecturers"
        Me.Text = "Lecturers"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabLecturers.ResumeLayout(False)
        Me.AddLecturer.ResumeLayout(False)
        Me.AddLecturer.PerformLayout()
        CType(Me.DgdLecturers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UpdateLecturer.ResumeLayout(False)
        Me.UpdateLecturer.PerformLayout()
        CType(Me.DgdLecturers2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ViewLecturers.ResumeLayout(False)
        Me.ViewLecturers.PerformLayout()
        CType(Me.DgdLecturers3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DeleteLecturer.ResumeLayout(False)
        Me.DeleteLecturer.PerformLayout()
        CType(Me.DgdLecturers4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblCSCS As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabLecturers As TabControl
    Friend WithEvents AddLecturer As TabPage
    Friend WithEvents UpdateLecturer As TabPage
    Friend WithEvents CmbTimes As ComboBox
    Friend WithEvents TxtLname As TextBox
    Friend WithEvents TxtFname As TextBox
    Friend WithEvents TxtLecturerID As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LblManage As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents LblLecturerID As Label
    Friend WithEvents LblTimes As Label
    Friend WithEvents LblLname As Label
    Friend WithEvents LblFname As Label
    Friend WithEvents DgdLecturers As DataGridView
    Friend WithEvents LblAllLecturers As Label
    Friend WithEvents BtnSearch As Button
    Friend WithEvents CmbTimes2 As ComboBox
    Friend WithEvents LblTimeAvailable As Label
    Friend WithEvents TxtUsedCredits As TextBox
    Friend WithEvents LblUsedCredits As Label
    Friend WithEvents TxtLname2 As TextBox
    Friend WithEvents LblLname2 As Label
    Friend WithEvents TxtFname2 As TextBox
    Friend WithEvents LblFname2 As Label
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents TxtLecturerID2 As TextBox
    Friend WithEvents LblLecturerID2 As Label
    Friend WithEvents DgdLecturers2 As DataGridView
    Friend WithEvents LblAllLecturers2 As Label
    Friend WithEvents LblHome2 As LinkLabel
    Friend WithEvents LblHome1 As LinkLabel
    Friend WithEvents ViewLecturers As TabPage
    Friend WithEvents DgdLecturers3 As DataGridView
    Friend WithEvents LblAllLecturers3 As Label
    Friend WithEvents DeleteLecturer As TabPage
    Friend WithEvents DgdLecturers4 As DataGridView
    Friend WithEvents LblDelete As Label
    Friend WithEvents BtnDelete As Button
    Friend WithEvents LblAllLecturers4 As Label
    Friend WithEvents LblHome4 As LinkLabel
    Friend WithEvents LblHome3 As LinkLabel
    Friend WithEvents BtnReset As Button
    Friend WithEvents LblLogout As LinkLabel
End Class
