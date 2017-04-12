<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteTimetable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeleteTimetable))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblLogout = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblDeleteTimetable = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnDeleteAll = New System.Windows.Forms.Button()
        Me.LblDeleteAll = New System.Windows.Forms.Label()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.LblDelete = New System.Windows.Forms.Label()
        Me.LblInstructions = New System.Windows.Forms.Label()
        Me.BtnSemester1 = New System.Windows.Forms.RadioButton()
        Me.BtnSemester2 = New System.Windows.Forms.RadioButton()
        Me.BtnSemester3 = New System.Windows.Forms.RadioButton()
        Me.DgdTimetable = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DgdTimetable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LblLogout)
        Me.Panel1.Controls.Add(Me.Label1)
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
        Me.LblLogout.TabIndex = 29
        Me.LblLogout.TabStop = True
        Me.LblLogout.Text = "LOGOUT"
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
        Me.Panel2.Controls.Add(Me.LblDeleteTimetable)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 49)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(777, 43)
        Me.Panel2.TabIndex = 8
        '
        'LblDeleteTimetable
        '
        Me.LblDeleteTimetable.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblDeleteTimetable.AutoSize = True
        Me.LblDeleteTimetable.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDeleteTimetable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.LblDeleteTimetable.Location = New System.Drawing.Point(318, 3)
        Me.LblDeleteTimetable.Name = "LblDeleteTimetable"
        Me.LblDeleteTimetable.Size = New System.Drawing.Size(168, 24)
        Me.LblDeleteTimetable.TabIndex = 0
        Me.LblDeleteTimetable.Text = "Delete Timetable"
        Me.LblDeleteTimetable.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.BtnDeleteAll)
        Me.Panel3.Controls.Add(Me.LblDeleteAll)
        Me.Panel3.Controls.Add(Me.BtnDelete)
        Me.Panel3.Controls.Add(Me.LblDelete)
        Me.Panel3.Controls.Add(Me.LblInstructions)
        Me.Panel3.Controls.Add(Me.BtnSemester1)
        Me.Panel3.Controls.Add(Me.BtnSemester2)
        Me.Panel3.Controls.Add(Me.BtnSemester3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 92)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(167, 392)
        Me.Panel3.TabIndex = 24
        '
        'BtnDeleteAll
        '
        Me.BtnDeleteAll.Location = New System.Drawing.Point(46, 287)
        Me.BtnDeleteAll.Name = "BtnDeleteAll"
        Me.BtnDeleteAll.Size = New System.Drawing.Size(75, 23)
        Me.BtnDeleteAll.TabIndex = 28
        Me.BtnDeleteAll.Text = "DeleteAll"
        Me.BtnDeleteAll.UseVisualStyleBackColor = True
        '
        'LblDeleteAll
        '
        Me.LblDeleteAll.AutoSize = True
        Me.LblDeleteAll.Location = New System.Drawing.Point(10, 259)
        Me.LblDeleteAll.Name = "LblDeleteAll"
        Me.LblDeleteAll.Size = New System.Drawing.Size(140, 13)
        Me.LblDeleteAll.TabIndex = 27
        Me.LblDeleteAll.Text = "Select to delete all Records:"
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(46, 217)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 26
        Me.BtnDelete.Text = "Delete "
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'LblDelete
        '
        Me.LblDelete.AutoSize = True
        Me.LblDelete.Location = New System.Drawing.Point(10, 190)
        Me.LblDelete.Name = "LblDelete"
        Me.LblDelete.Size = New System.Drawing.Size(146, 13)
        Me.LblDelete.TabIndex = 25
        Me.LblDelete.Text = "Select Row then click delete:"
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
        'DgdTimetable
        '
        Me.DgdTimetable.AllowUserToAddRows = False
        Me.DgdTimetable.AllowUserToDeleteRows = False
        Me.DgdTimetable.AllowUserToOrderColumns = True
        Me.DgdTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdTimetable.Dock = System.Windows.Forms.DockStyle.Right
        Me.DgdTimetable.Location = New System.Drawing.Point(164, 92)
        Me.DgdTimetable.Name = "DgdTimetable"
        Me.DgdTimetable.ReadOnly = True
        Me.DgdTimetable.Size = New System.Drawing.Size(613, 392)
        Me.DgdTimetable.TabIndex = 25
        '
        'DeleteTimetable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 484)
        Me.Controls.Add(Me.DgdTimetable)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DeleteTimetable"
        Me.Text = "Delete Timetable"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DgdTimetable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LblDeleteTimetable As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LblInstructions As Label
    Friend WithEvents BtnSemester1 As RadioButton
    Friend WithEvents BtnSemester2 As RadioButton
    Friend WithEvents BtnSemester3 As RadioButton
    Friend WithEvents DgdTimetable As DataGridView
    Friend WithEvents LblDelete As Label
    Friend WithEvents BtnDeleteAll As Button
    Friend WithEvents LblDeleteAll As Label
    Friend WithEvents BtnDelete As Button
    Friend WithEvents LblLogout As LinkLabel
End Class
