<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Labs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Labs))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblLogout = New System.Windows.Forms.LinkLabel()
        Me.LblCSCS = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblManage = New System.Windows.Forms.Label()
        Me.TabLabs = New System.Windows.Forms.TabControl()
        Me.AddLab = New System.Windows.Forms.TabPage()
        Me.LblHome1 = New System.Windows.Forms.LinkLabel()
        Me.LblAllLabs = New System.Windows.Forms.Label()
        Me.DgdLabs = New System.Windows.Forms.DataGridView()
        Me.LblSeating = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblLabID = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.TxtSeating = New System.Windows.Forms.TextBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtLabID = New System.Windows.Forms.TextBox()
        Me.UpdateLab = New System.Windows.Forms.TabPage()
        Me.LblHome2 = New System.Windows.Forms.LinkLabel()
        Me.LblAllLecturers2 = New System.Windows.Forms.Label()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.TxtSeating2 = New System.Windows.Forms.TextBox()
        Me.LblSeating2 = New System.Windows.Forms.Label()
        Me.TxtName2 = New System.Windows.Forms.TextBox()
        Me.LblName2 = New System.Windows.Forms.Label()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.TxtLabID2 = New System.Windows.Forms.TextBox()
        Me.LblLabID2 = New System.Windows.Forms.Label()
        Me.DgdLabs2 = New System.Windows.Forms.DataGridView()
        Me.ViewLabs = New System.Windows.Forms.TabPage()
        Me.LblHome3 = New System.Windows.Forms.LinkLabel()
        Me.LblLabs3 = New System.Windows.Forms.Label()
        Me.DgdLabs3 = New System.Windows.Forms.DataGridView()
        Me.DeleteLab = New System.Windows.Forms.TabPage()
        Me.LblHome4 = New System.Windows.Forms.LinkLabel()
        Me.LablLabs4 = New System.Windows.Forms.Label()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.LblDelete = New System.Windows.Forms.Label()
        Me.DgdLabs4 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabLabs.SuspendLayout()
        Me.AddLab.SuspendLayout()
        CType(Me.DgdLabs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UpdateLab.SuspendLayout()
        CType(Me.DgdLabs2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ViewLabs.SuspendLayout()
        CType(Me.DgdLabs3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DeleteLab.SuspendLayout()
        CType(Me.DgdLabs4, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 3
        '
        'LblLogout
        '
        Me.LblLogout.ActiveLinkColor = System.Drawing.Color.OliveDrab
        Me.LblLogout.AutoSize = True
        Me.LblLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLogout.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LblLogout.LinkColor = System.Drawing.Color.OliveDrab
        Me.LblLogout.Location = New System.Drawing.Point(683, 18)
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
        Me.Panel2.Controls.Add(Me.LblManage)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 49)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(777, 37)
        Me.Panel2.TabIndex = 5
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
        'TabLabs
        '
        Me.TabLabs.Controls.Add(Me.AddLab)
        Me.TabLabs.Controls.Add(Me.UpdateLab)
        Me.TabLabs.Controls.Add(Me.ViewLabs)
        Me.TabLabs.Controls.Add(Me.DeleteLab)
        Me.TabLabs.Location = New System.Drawing.Point(3, 92)
        Me.TabLabs.Name = "TabLabs"
        Me.TabLabs.SelectedIndex = 0
        Me.TabLabs.Size = New System.Drawing.Size(774, 395)
        Me.TabLabs.TabIndex = 6
        '
        'AddLab
        '
        Me.AddLab.Controls.Add(Me.LblHome1)
        Me.AddLab.Controls.Add(Me.LblAllLabs)
        Me.AddLab.Controls.Add(Me.DgdLabs)
        Me.AddLab.Controls.Add(Me.LblSeating)
        Me.AddLab.Controls.Add(Me.LblName)
        Me.AddLab.Controls.Add(Me.LblLabID)
        Me.AddLab.Controls.Add(Me.BtnAdd)
        Me.AddLab.Controls.Add(Me.TxtSeating)
        Me.AddLab.Controls.Add(Me.TxtName)
        Me.AddLab.Controls.Add(Me.TxtLabID)
        Me.AddLab.Location = New System.Drawing.Point(4, 22)
        Me.AddLab.Name = "AddLab"
        Me.AddLab.Padding = New System.Windows.Forms.Padding(3)
        Me.AddLab.Size = New System.Drawing.Size(766, 369)
        Me.AddLab.TabIndex = 0
        Me.AddLab.Text = "Add Lab"
        Me.AddLab.UseVisualStyleBackColor = True
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
        'LblAllLabs
        '
        Me.LblAllLabs.AutoSize = True
        Me.LblAllLabs.Location = New System.Drawing.Point(520, 18)
        Me.LblAllLabs.Name = "LblAllLabs"
        Me.LblAllLabs.Size = New System.Drawing.Size(44, 13)
        Me.LblAllLabs.TabIndex = 11
        Me.LblAllLabs.Text = "All Labs"
        '
        'DgdLabs
        '
        Me.DgdLabs.AllowUserToAddRows = False
        Me.DgdLabs.AllowUserToDeleteRows = False
        Me.DgdLabs.AllowUserToOrderColumns = True
        Me.DgdLabs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdLabs.Location = New System.Drawing.Point(322, 34)
        Me.DgdLabs.Name = "DgdLabs"
        Me.DgdLabs.ReadOnly = True
        Me.DgdLabs.Size = New System.Drawing.Size(438, 327)
        Me.DgdLabs.TabIndex = 10
        '
        'LblSeating
        '
        Me.LblSeating.AutoSize = True
        Me.LblSeating.Location = New System.Drawing.Point(21, 148)
        Me.LblSeating.Name = "LblSeating"
        Me.LblSeating.Size = New System.Drawing.Size(90, 13)
        Me.LblSeating.TabIndex = 8
        Me.LblSeating.Text = "Seating Capacity:"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Location = New System.Drawing.Point(21, 97)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(78, 13)
        Me.LblName.TabIndex = 7
        Me.LblName.Text = "Lab Full Name:"
        '
        'LblLabID
        '
        Me.LblLabID.AutoSize = True
        Me.LblLabID.Location = New System.Drawing.Point(21, 47)
        Me.LblLabID.Name = "LblLabID"
        Me.LblLabID.Size = New System.Drawing.Size(88, 13)
        Me.LblLabID.TabIndex = 6
        Me.LblLabID.Text = "Lab ID/Acronym:"
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(128, 200)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 5
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'TxtSeating
        '
        Me.TxtSeating.Location = New System.Drawing.Point(128, 145)
        Me.TxtSeating.Name = "TxtSeating"
        Me.TxtSeating.Size = New System.Drawing.Size(90, 20)
        Me.TxtSeating.TabIndex = 2
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(128, 97)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(146, 20)
        Me.TxtName.TabIndex = 1
        '
        'TxtLabID
        '
        Me.TxtLabID.Location = New System.Drawing.Point(128, 47)
        Me.TxtLabID.Name = "TxtLabID"
        Me.TxtLabID.Size = New System.Drawing.Size(121, 20)
        Me.TxtLabID.TabIndex = 0
        '
        'UpdateLab
        '
        Me.UpdateLab.Controls.Add(Me.LblHome2)
        Me.UpdateLab.Controls.Add(Me.LblAllLecturers2)
        Me.UpdateLab.Controls.Add(Me.BtnSearch)
        Me.UpdateLab.Controls.Add(Me.TxtSeating2)
        Me.UpdateLab.Controls.Add(Me.LblSeating2)
        Me.UpdateLab.Controls.Add(Me.TxtName2)
        Me.UpdateLab.Controls.Add(Me.LblName2)
        Me.UpdateLab.Controls.Add(Me.BtnUpdate)
        Me.UpdateLab.Controls.Add(Me.TxtLabID2)
        Me.UpdateLab.Controls.Add(Me.LblLabID2)
        Me.UpdateLab.Controls.Add(Me.DgdLabs2)
        Me.UpdateLab.Location = New System.Drawing.Point(4, 22)
        Me.UpdateLab.Name = "UpdateLab"
        Me.UpdateLab.Padding = New System.Windows.Forms.Padding(3)
        Me.UpdateLab.Size = New System.Drawing.Size(766, 369)
        Me.UpdateLab.TabIndex = 1
        Me.UpdateLab.Text = "Update Lab"
        Me.UpdateLab.UseVisualStyleBackColor = True
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
        Me.LblAllLecturers2.Location = New System.Drawing.Point(526, 18)
        Me.LblAllLecturers2.Name = "LblAllLecturers2"
        Me.LblAllLecturers2.Size = New System.Drawing.Size(44, 13)
        Me.LblAllLecturers2.TabIndex = 24
        Me.LblAllLecturers2.Text = "All Labs"
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
        'TxtSeating2
        '
        Me.TxtSeating2.Location = New System.Drawing.Point(116, 133)
        Me.TxtSeating2.Name = "TxtSeating2"
        Me.TxtSeating2.Size = New System.Drawing.Size(94, 20)
        Me.TxtSeating2.TabIndex = 18
        '
        'LblSeating2
        '
        Me.LblSeating2.AutoSize = True
        Me.LblSeating2.Location = New System.Drawing.Point(19, 140)
        Me.LblSeating2.Name = "LblSeating2"
        Me.LblSeating2.Size = New System.Drawing.Size(90, 13)
        Me.LblSeating2.TabIndex = 17
        Me.LblSeating2.Text = "Seating Capacity:"
        '
        'TxtName2
        '
        Me.TxtName2.Location = New System.Drawing.Point(113, 89)
        Me.TxtName2.Name = "TxtName2"
        Me.TxtName2.Size = New System.Drawing.Size(146, 20)
        Me.TxtName2.TabIndex = 16
        '
        'LblName2
        '
        Me.LblName2.AutoSize = True
        Me.LblName2.Location = New System.Drawing.Point(19, 96)
        Me.LblName2.Name = "LblName2"
        Me.LblName2.Size = New System.Drawing.Size(78, 13)
        Me.LblName2.TabIndex = 15
        Me.LblName2.Text = "Lab Full Name:"
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(125, 198)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 14
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'TxtLabID2
        '
        Me.TxtLabID2.Location = New System.Drawing.Point(113, 44)
        Me.TxtLabID2.Name = "TxtLabID2"
        Me.TxtLabID2.Size = New System.Drawing.Size(121, 20)
        Me.TxtLabID2.TabIndex = 13
        '
        'LblLabID2
        '
        Me.LblLabID2.AutoSize = True
        Me.LblLabID2.Location = New System.Drawing.Point(19, 47)
        Me.LblLabID2.Name = "LblLabID2"
        Me.LblLabID2.Size = New System.Drawing.Size(88, 13)
        Me.LblLabID2.TabIndex = 12
        Me.LblLabID2.Text = "Lab ID/Acronym:"
        '
        'DgdLabs2
        '
        Me.DgdLabs2.AllowUserToAddRows = False
        Me.DgdLabs2.AllowUserToDeleteRows = False
        Me.DgdLabs2.AllowUserToOrderColumns = True
        Me.DgdLabs2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdLabs2.Location = New System.Drawing.Point(322, 34)
        Me.DgdLabs2.Name = "DgdLabs2"
        Me.DgdLabs2.ReadOnly = True
        Me.DgdLabs2.Size = New System.Drawing.Size(438, 327)
        Me.DgdLabs2.TabIndex = 11
        '
        'ViewLabs
        '
        Me.ViewLabs.Controls.Add(Me.LblHome3)
        Me.ViewLabs.Controls.Add(Me.LblLabs3)
        Me.ViewLabs.Controls.Add(Me.DgdLabs3)
        Me.ViewLabs.Location = New System.Drawing.Point(4, 22)
        Me.ViewLabs.Name = "ViewLabs"
        Me.ViewLabs.Padding = New System.Windows.Forms.Padding(3)
        Me.ViewLabs.Size = New System.Drawing.Size(766, 369)
        Me.ViewLabs.TabIndex = 2
        Me.ViewLabs.Text = "View Labs"
        Me.ViewLabs.UseVisualStyleBackColor = True
        '
        'LblHome3
        '
        Me.LblHome3.AutoSize = True
        Me.LblHome3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHome3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LblHome3.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblHome3.Location = New System.Drawing.Point(15, 343)
        Me.LblHome3.Name = "LblHome3"
        Me.LblHome3.Size = New System.Drawing.Size(132, 18)
        Me.LblHome3.TabIndex = 29
        Me.LblHome3.TabStop = True
        Me.LblHome3.Text = "<<Return to Home"
        '
        'LblLabs3
        '
        Me.LblLabs3.AutoSize = True
        Me.LblLabs3.Location = New System.Drawing.Point(356, 15)
        Me.LblLabs3.Name = "LblLabs3"
        Me.LblLabs3.Size = New System.Drawing.Size(44, 13)
        Me.LblLabs3.TabIndex = 25
        Me.LblLabs3.Text = "All Labs"
        '
        'DgdLabs3
        '
        Me.DgdLabs3.AllowUserToAddRows = False
        Me.DgdLabs3.AllowUserToDeleteRows = False
        Me.DgdLabs3.AllowUserToOrderColumns = True
        Me.DgdLabs3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdLabs3.Location = New System.Drawing.Point(18, 31)
        Me.DgdLabs3.Name = "DgdLabs3"
        Me.DgdLabs3.ReadOnly = True
        Me.DgdLabs3.Size = New System.Drawing.Size(731, 296)
        Me.DgdLabs3.TabIndex = 0
        '
        'DeleteLab
        '
        Me.DeleteLab.Controls.Add(Me.LblHome4)
        Me.DeleteLab.Controls.Add(Me.LablLabs4)
        Me.DeleteLab.Controls.Add(Me.BtnDelete)
        Me.DeleteLab.Controls.Add(Me.LblDelete)
        Me.DeleteLab.Controls.Add(Me.DgdLabs4)
        Me.DeleteLab.Location = New System.Drawing.Point(4, 22)
        Me.DeleteLab.Name = "DeleteLab"
        Me.DeleteLab.Padding = New System.Windows.Forms.Padding(3)
        Me.DeleteLab.Size = New System.Drawing.Size(766, 369)
        Me.DeleteLab.TabIndex = 3
        Me.DeleteLab.Text = "Delete Lab"
        Me.DeleteLab.UseVisualStyleBackColor = True
        '
        'LblHome4
        '
        Me.LblHome4.AutoSize = True
        Me.LblHome4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHome4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LblHome4.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblHome4.Location = New System.Drawing.Point(22, 330)
        Me.LblHome4.Name = "LblHome4"
        Me.LblHome4.Size = New System.Drawing.Size(132, 18)
        Me.LblHome4.TabIndex = 29
        Me.LblHome4.TabStop = True
        Me.LblHome4.Text = "<<Return to Home"
        '
        'LablLabs4
        '
        Me.LablLabs4.AutoSize = True
        Me.LablLabs4.Location = New System.Drawing.Point(461, 8)
        Me.LablLabs4.Name = "LablLabs4"
        Me.LablLabs4.Size = New System.Drawing.Size(44, 13)
        Me.LablLabs4.TabIndex = 26
        Me.LablLabs4.Text = "All Labs"
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
        'DgdLabs4
        '
        Me.DgdLabs4.AllowUserToAddRows = False
        Me.DgdLabs4.AllowUserToDeleteRows = False
        Me.DgdLabs4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdLabs4.Location = New System.Drawing.Point(195, 24)
        Me.DgdLabs4.Name = "DgdLabs4"
        Me.DgdLabs4.ReadOnly = True
        Me.DgdLabs4.Size = New System.Drawing.Size(555, 324)
        Me.DgdLabs4.TabIndex = 0
        '
        'Labs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(777, 484)
        Me.Controls.Add(Me.TabLabs)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Labs"
        Me.Text = "Labs"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabLabs.ResumeLayout(False)
        Me.AddLab.ResumeLayout(False)
        Me.AddLab.PerformLayout()
        CType(Me.DgdLabs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UpdateLab.ResumeLayout(False)
        Me.UpdateLab.PerformLayout()
        CType(Me.DgdLabs2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ViewLabs.ResumeLayout(False)
        Me.ViewLabs.PerformLayout()
        CType(Me.DgdLabs3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DeleteLab.ResumeLayout(False)
        Me.DeleteLab.PerformLayout()
        CType(Me.DgdLabs4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblCSCS As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LblManage As Label
    Friend WithEvents TabLabs As TabControl
    Friend WithEvents AddLab As TabPage
    Friend WithEvents LblHome1 As LinkLabel
    Friend WithEvents LblAllLabs As Label
    Friend WithEvents DgdLabs As DataGridView
    Friend WithEvents LblSeating As Label
    Friend WithEvents LblName As Label
    Friend WithEvents LblLabID As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents TxtSeating As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtLabID As TextBox
    Friend WithEvents UpdateLab As TabPage
    Friend WithEvents LblHome2 As LinkLabel
    Friend WithEvents LblAllLecturers2 As Label
    Friend WithEvents BtnSearch As Button
    Friend WithEvents TxtSeating2 As TextBox
    Friend WithEvents LblSeating2 As Label
    Friend WithEvents TxtName2 As TextBox
    Friend WithEvents LblName2 As Label
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents TxtLabID2 As TextBox
    Friend WithEvents LblLabID2 As Label
    Friend WithEvents DgdLabs2 As DataGridView
    Friend WithEvents ViewLabs As TabPage
    Friend WithEvents LblLabs3 As Label
    Friend WithEvents DgdLabs3 As DataGridView
    Friend WithEvents DeleteLab As TabPage
    Friend WithEvents BtnDelete As Button
    Friend WithEvents LblDelete As Label
    Friend WithEvents DgdLabs4 As DataGridView
    Friend WithEvents LablLabs4 As Label
    Friend WithEvents LblHome3 As LinkLabel
    Friend WithEvents LblHome4 As LinkLabel
    Friend WithEvents LblLogout As LinkLabel
End Class
