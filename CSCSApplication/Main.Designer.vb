<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblCSCS = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnLecturers = New System.Windows.Forms.Button()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.BtnView = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnLabs = New System.Windows.Forms.Button()
        Me.LblAdmin = New System.Windows.Forms.Label()
        Me.LblLogout = New System.Windows.Forms.LinkLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 0
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
        'BtnLecturers
        '
        Me.BtnLecturers.Location = New System.Drawing.Point(38, 107)
        Me.BtnLecturers.Name = "BtnLecturers"
        Me.BtnLecturers.Size = New System.Drawing.Size(145, 40)
        Me.BtnLecturers.TabIndex = 1
        Me.BtnLecturers.Text = "Manage Lecturers"
        Me.BtnLecturers.UseVisualStyleBackColor = True
        '
        'BtnCreate
        '
        Me.BtnCreate.Location = New System.Drawing.Point(38, 192)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(145, 40)
        Me.BtnCreate.TabIndex = 2
        Me.BtnCreate.Text = "Create Timetable"
        Me.BtnCreate.UseVisualStyleBackColor = True
        '
        'BtnView
        '
        Me.BtnView.Location = New System.Drawing.Point(223, 192)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(145, 40)
        Me.BtnView.TabIndex = 3
        Me.BtnView.Text = "View Timetable"
        Me.BtnView.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(411, 192)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(145, 40)
        Me.BtnUpdate.TabIndex = 4
        Me.BtnUpdate.Text = "Update Timetable"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(597, 192)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(145, 40)
        Me.BtnDelete.TabIndex = 5
        Me.BtnDelete.Text = "Delete Timetable"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnLabs
        '
        Me.BtnLabs.Location = New System.Drawing.Point(38, 277)
        Me.BtnLabs.Name = "BtnLabs"
        Me.BtnLabs.Size = New System.Drawing.Size(145, 40)
        Me.BtnLabs.TabIndex = 6
        Me.BtnLabs.Text = "Manage Labs"
        Me.BtnLabs.UseVisualStyleBackColor = True
        '
        'LblAdmin
        '
        Me.LblAdmin.AutoSize = True
        Me.LblAdmin.Location = New System.Drawing.Point(88, 65)
        Me.LblAdmin.Name = "LblAdmin"
        Me.LblAdmin.Size = New System.Drawing.Size(39, 13)
        Me.LblAdmin.TabIndex = 7
        Me.LblAdmin.Text = "Label2"
        '
        'LblLogout
        '
        Me.LblLogout.ActiveLinkColor = System.Drawing.Color.OliveDrab
        Me.LblLogout.AutoSize = True
        Me.LblLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLogout.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LblLogout.LinkColor = System.Drawing.Color.OliveDrab
        Me.LblLogout.Location = New System.Drawing.Point(674, 16)
        Me.LblLogout.Name = "LblLogout"
        Me.LblLogout.Size = New System.Drawing.Size(82, 20)
        Me.LblLogout.TabIndex = 8
        Me.LblLogout.TabStop = True
        Me.LblLogout.Text = "LOGOUT"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(777, 484)
        Me.Controls.Add(Me.LblAdmin)
        Me.Controls.Add(Me.BtnLabs)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnView)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.BtnLecturers)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "Main"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblCSCS As Label
    Friend WithEvents BtnLecturers As Button
    Friend WithEvents BtnCreate As Button
    Friend WithEvents BtnView As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnLabs As Button
    Friend WithEvents LblAdmin As Label
    Friend WithEvents LblLogout As LinkLabel
End Class
