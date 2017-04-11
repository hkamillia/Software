Imports System.Data.OleDb
Public Class PickSemCreate
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Public myConnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader
    Public semester As String


    Private Sub PickSemCreate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadForm()
    End Sub

    Private Sub LoadForm()
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "|DataDirectory|\Database\CSCSdb.mdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString

        LsbCourses.Visible = False
        LblCrsCode.Visible = False
        TxtCrsCode.Visible = False
        LblCrsTitle.Visible = False
        TxtCrsTitle.Visible = False
        LblCredits.Visible = False
        TxtCredits.Visible = False
        LblCrsType.Visible = False
        CmbType.Visible = False
        LblClassSize.Visible = False
        TxtClassSize.Visible = False
        BtnAdd.Visible = False
        BtnDelete.Visible = False
        LblDelete.Visible = False
        LblNext.Visible = False
    End Sub
    Private Sub BtnSemester1_CheckedChanged(sender As Object, e As EventArgs) Handles BtnSemester1.CheckedChanged
        LoadCourses1()
    End Sub

    Public Sub LoadCourses1()
        LsbCourses.Visible = True
        LblCrsCode.Visible = True
        TxtCrsCode.Visible = True
        LblCrsTitle.Visible = True
        TxtCrsTitle.Visible = True
        LblCredits.Visible = True
        TxtCredits.Visible = True
        LblCrsType.Visible = True
        CmbType.Visible = True
        LblClassSize.Visible = True
        TxtClassSize.Visible = True
        BtnAdd.Visible = True
        BtnDelete.Visible = True
        LblDelete.Visible = True
        LblNext.Visible = True
        semester = "1st"

        LsbCourses.Items.Clear()
        myConnection.Open()
        Dim str As String
        str = "SELECT CourseTitle FROM courses WHERE (SemesterOffered = '" & semester & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Do While (dr.Read())
            LsbCourses.Items.Add(dr.GetString(0))
        Loop
        dr.Close()
        cmd.Dispose()
        myConnection.Close()
    End Sub

    Private Sub Btnsemester2_checkedchanged(sender As Object, e As EventArgs) Handles BtnSemester2.CheckedChanged
        LoadCourses2()
    End Sub

    Public Sub LoadCourses2()
        LsbCourses.Visible = True
        LblCrsCode.Visible = True
        TxtCrsCode.Visible = True
        LblCrsTitle.Visible = True
        TxtCrsTitle.Visible = True
        LblCredits.Visible = True
        TxtCredits.Visible = True
        LblCrsType.Visible = True
        CmbType.Visible = True
        LblClassSize.Visible = True
        TxtClassSize.Visible = True
        BtnAdd.Visible = True
        BtnDelete.Visible = True
        LblDelete.Visible = True
        LblNext.Visible = True
        semester = "2nd"

        LsbCourses.Items.Clear()
        myConnection.Open()
        Dim str As String
        str = "select CourseTitle from courses where (SemesterOffered = '" & semester & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Do While (dr.Read())
            LsbCourses.Items.Add(dr.GetString(0))
        Loop
        dr.Close()
        cmd.Dispose()
        myConnection.Close()
    End Sub

    Private Sub BtnSemester3_CheckedChanged(sender As Object, e As EventArgs) Handles BtnSemester3.CheckedChanged
        LoadCourses3()
    End Sub
    Private Sub LoadCourses3()
        LsbCourses.Visible = True
        LblCrsCode.Visible = True
        TxtCrsCode.Visible = True
        LblCrsTitle.Visible = True
        TxtCrsTitle.Visible = True
        LblCredits.Visible = True
        TxtCredits.Visible = True
        LblCrsType.Visible = True
        CmbType.Visible = True
        LblClassSize.Visible = True
        TxtClassSize.Visible = True
        BtnAdd.Visible = True
        BtnDelete.Visible = True
        LblDelete.Visible = True
        LblNext.Visible = True
        semester = "3rd"


        LsbCourses.Items.Clear()
        myConnection.Open()
        Dim str As String
        str = "SELECT CourseTitle FROM courses WHERE (SemesterOffered = '" & semester & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Do While (dr.Read())
            LsbCourses.Items.Add(dr.GetString(0))
        Loop
        dr.Close()
        cmd.Dispose()
        myConnection.Close()

    End Sub


    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        AddCourse()
    End Sub
    Private Sub AddCourse()
        myConnection.Open()
        Dim sqlCheck As New OleDbCommand("SELECT count(*) FROM courses WHERE CourseCode = '" & TxtCrsCode.Text & "' AND [SemesterOffered] = '" & semester & "'", myConnection)
        sqlCheck.Parameters.AddWithValue("CourseCode", TxtCrsCode.Text)
        sqlCheck.Parameters.AddWithValue("SemesterOffered", semester)


        dr = sqlCheck.ExecuteReader()
        If dr.HasRows = True Then
            dr.Read()
            If dr.Item(0) = 0 Then 'Course can be added
                Dim str As String
                str = "insert into courses ([CourseCode], [CourseTitle],[Credits], [Type], [Priority],[MaxClassSize], [SemesterOffered])
               values (?, ?, ?, ?, ?, ?, ?)"
                Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
                cmd.Parameters.Add(New OleDbParameter("CourseCode", CType(TxtCrsCode.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("CourseTitle", CType(TxtCrsTitle.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("Credits", CType(TxtCredits.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("Type", CType(CmbType.Text, String)))

                If CmbType.Text = "Core" Or CmbType.Text = "Cognate" Then
                    cmd.Parameters.Add(New OleDbParameter("Priority", CType("1", String)))
                ElseIf CmbType.Text = "Emphasis" Or CmbType.Text = "Elective" Then
                    cmd.Parameters.Add(New OleDbParameter("Priority", CType("2", String)))
                Else
                    cmd.Parameters.Add(New OleDbParameter("Priority", CType("3", String)))
                End If

                cmd.Parameters.Add(New OleDbParameter("MaxClassSize", CType(TxtClassSize.Text, String)))

                If semester = "1st" Then
                    cmd.Parameters.Add(New OleDbParameter("SemesterOffered", CType("1st", String)))
                ElseIf semester = "2nd" Then
                    cmd.Parameters.Add(New OleDbParameter("SemesterOffered", CType("2nd", String)))
                Else
                    cmd.Parameters.Add(New OleDbParameter("SemesterOffered", CType("3rd", String)))
                End If
                Try
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    myConnection.Close()
                    MsgBox("The course was successfully added.", MsgBoxStyle.OkOnly, "Success!")
                Catch ex As Exception
                    myConnection.Close()
                    MsgBox("Sorry the course was not successfully added.", MsgBoxStyle.OkOnly, "Error")
                End Try

            Else
                myConnection.Close()
                MsgBox("The course was already added.", MsgBoxStyle.OkOnly, "Already Added")

            End If
        End If

        TxtCrsCode.ResetText()
        TxtCrsTitle.ResetText()
        TxtCredits.ResetText()
        CmbType.SelectedIndex = -1
        TxtClassSize.ResetText()


        If semester = "1st" Then
            LoadCourses1()
        ElseIf semester = "2nd" Then
            LoadCourses2()
        Else
            LoadCourses3()
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        DeleteCourse()
    End Sub

    Private Sub DeleteCourse()
        If LsbCourses.SelectedIndex > -1 Then
            Dim okToDelete As MsgBoxResult = MsgBox("Are you sure you want to delete the current record?", MsgBoxStyle.YesNo)
            If okToDelete = MsgBoxResult.Yes Then
                myConnection.Open()
                Dim str As String
                str = "Delete from courses Where [CourseTitle]= '" & LsbCourses.SelectedItem & "' AND [SemesterOffered] = '" & semester & "'"
                Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
                Try
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    myConnection.Close()
                    MsgBox("The course was successfully deleted.", MsgBoxStyle.OkOnly, "Success!")
                Catch ex As Exception
                    MsgBox("Sorry the course was not successfully deleted.", MsgBoxStyle.OkOnly, "Error")
                    myConnection.Close()
                End Try
            ElseIf okToDelete = MsgBoxResult.No Then
            End If
        End If
        TxtCrsCode.ResetText()
        TxtCrsTitle.ResetText()
        TxtCredits.ResetText()
        CmbType.SelectedIndex = -1
        TxtClassSize.ResetText()

        If semester = "1st" Then
            LoadCourses1()
        ElseIf semester = "2nd" Then
            LoadCourses2()
        Else
            LoadCourses3()
        End If
    End Sub

    Private Sub TxtCrsCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCrsCode.KeyPress

        If Char.IsLower(e.KeyChar) Then

            'Convert to uppercase, and put at the caret position in the TextBox.
            TxtCrsCode.SelectedText = Char.ToUpper(e.KeyChar)

            e.Handled = True
        End If
    End Sub

    Private Sub LblNext_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblNext.LinkClicked
        Hide()
        Dim MyForm As New CreateTimetable
        MyForm.Show()
    End Sub

    Private Sub LblHome_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblHome.LinkClicked
        Hide()
        Main.Show()
    End Sub
End Class