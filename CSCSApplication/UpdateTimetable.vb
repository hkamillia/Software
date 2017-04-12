Imports System.Data.OleDb
Public Class UpdateTimetable
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Public myConnection As OleDbConnection = New OleDbConnection
    Dim da As OleDbDataAdapter
    Public dr As OleDbDataReader
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Public semester As String
    Public classSize As Integer
    Dim creditHrs As Integer
    Dim Fname As String
    Dim Lname As String

    Private Sub PickSemCreate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadForm()
    End Sub

    Private Sub LoadForm()
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "|DataDirectory|\Database\CSCSdb.mdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
    End Sub

    Private Sub BtnSemester1_CheckedChanged(sender As Object, e As EventArgs) Handles BtnSemester1.CheckedChanged
        semester = "1st"
        LoadData()
    End Sub

    Private Sub BtnSemester2_CheckedChanged(sender As Object, e As EventArgs) Handles BtnSemester2.CheckedChanged
        semester = "2nd"
        LoadData()
    End Sub

    Private Sub BtnSemester3_CheckedChanged(sender As Object, e As EventArgs) Handles BtnSemester3.CheckedChanged
        semester = "3rd"
        LoadData()
    End Sub

    Private Sub LoadData()
        'Reads from database and fills data grid view
        myConnection.Open()
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("Select CourseCode, CourseTitle, Credits, Days, Time, Lab, Lecturer from [timetable] WHERE Semester='" & semester & "'", myConnection)
        da.Fill(ds, "timetable")
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        Me.DgdTimetable.DataSource = view
        myConnection.Close()
    End Sub
    Private Sub CmbTimes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTimes.SelectedIndexChanged
        LoadLecturers()
    End Sub

    Private Sub LoadLecturers()

        CmbLecturers.Items.Clear()
        myConnection.Open()
        Dim str As String
        Dim str2 As String
        If CmbTimes.SelectedItem = "8:00AM-9:15AM" Or CmbTimes.SelectedItem = "9:25AM-10:40AM" Or CmbTimes.SelectedItem = "10:50AM-12:05PM" Then
            str = "SELECT [Fname], [Lname] FROM lecturers WHERE (TimeAvailable = '" & "Part Time-Morning (8:00AM-12:05PM)" & "')"
            str2 = "SELECT [Fname], [Lname] FROM lecturers WHERE (TimeAvailable = '" & "Full Time" & "')"
            Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
            dr = cmd.ExecuteReader
            Do While (dr.Read())
                CmbLecturers.Items.Add(dr.GetString(0) + " " + dr.GetString(1))
            Loop
            dr.Close()
            cmd.Dispose()


            Dim cmd2 As OleDbCommand = New OleDbCommand(str2, myConnection)
            dr = cmd2.ExecuteReader
            Do While (dr.Read())
                CmbLecturers.Items.Add(dr.GetString(0) + " " + dr.GetString(1))
            Loop
            dr.Close()
            cmd2.Dispose()
            myConnection.Close()

        ElseIf CmbTimes.SelectedItem = "12:15PM-1:30PM" Or CmbTimes.SelectedItem = "1:40PM-2:55PM" Or CmbTimes.SelectedItem = "3:05PM-4:20PM" Then
            str = "SELECT [Fname], [Lname] FROM lecturers WHERE (TimeAvailable = '" & "Part Time-Afternoon (12:15PM-4:20PM)" & "')"
            str2 = "SELECT [Fname], [Lname] FROM lecturers WHERE (TimeAvailable = '" & "Full Time" & "')"
            Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
            dr = cmd.ExecuteReader
            Do While (dr.Read())
                CmbLecturers.Items.Add(dr.GetString(0) + " " + dr.GetString(1))
            Loop
            dr.Close()
            cmd.Dispose()

            Dim cmd2 As OleDbCommand = New OleDbCommand(str2, myConnection)
            dr = cmd2.ExecuteReader
            Do While (dr.Read())
                CmbLecturers.Items.Add(dr.GetString(0) + " " + dr.GetString(1))
            Loop
            dr.Close()
            cmd2.Dispose()
            myConnection.Close()

        ElseIf CmbTimes.SelectedItem = "4:30PM-5:45PM" Or CmbTimes.SelectedItem = "5:55PM-7:10PM" Or CmbTimes.SelectedItem = "7:20PM-8:35PM" Then
            str = "SELECT [Fname], [Lname] FROM lecturers WHERE (TimeAvailable = '" & "Part Time-Evening (4:30PM-8:35PM)" & "')"
            str2 = "SELECT [Fname], [Lname] FROM lecturers WHERE (TimeAvailable = '" & "Full Time" & "')"
            Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
            dr = cmd.ExecuteReader
            Do While (dr.Read())
                CmbLecturers.Items.Add(dr.GetString(0) + " " + dr.GetString(1))

            Loop
            dr.Close()
            cmd.Dispose()

            Dim cmd2 As OleDbCommand = New OleDbCommand(str2, myConnection)
            dr = cmd2.ExecuteReader
            Do While (dr.Read())
                CmbLecturers.Items.Add(dr.GetString(0) + " " + dr.GetString(1))
            Loop
            dr.Close()
            cmd2.Dispose()
            myConnection.Close()
        End If
    End Sub

    Private Sub getMaxClass()

        myConnection.Open()
        Dim str As String
        str = "SELECT MaxClassSize FROM courses WHERE (CourseCode= '" & TxtCrsCode.Text & "' AND SemesterOffered = '" & semester & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Dim sizeFound As Boolean = False

        While dr.Read()
            sizeFound = True
            classSize = dr("MaxClassSize").ToString
        End While

        If sizeFound = False Then
            MsgBox("Sorry, course was not found", MsgBoxStyle.OkOnly, "Not Found")
        End If
        myConnection.Close()

        LoadLabs(classSize)

    End Sub

    Private Sub LoadLabs(classSize As Integer)
        CmbLabs.Items.Clear()

        myConnection.Open()
        Dim str As String
        Dim str2 As String
        str = "SELECT LabID FROM labs WHERE (SeatingCapacity >= " & classSize & " )"
        str2 = "SELECT LabID FROM labs WHERE(SeatingCapacity= 0)"

        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Do While (dr.Read())
            CmbLabs.Items.Add(dr.GetString(0))
        Loop
        dr.Close()
        cmd.Dispose()


        Dim cmd2 As OleDbCommand = New OleDbCommand(str2, myConnection)
        dr = cmd2.ExecuteReader
        Do While (dr.Read())
            CmbLabs.Items.Add(dr.GetString(0))
        Loop
        dr.Close()
        cmd.Dispose()
        myConnection.Close()
    End Sub



    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Search()
        getMaxClass()
    End Sub

    Private Sub Search()
        myConnection.Open()

        Dim str As String
        str = "SELECT CourseTitle, Credits, Days, Lecturer FROM timetable WHERE (CourseCode = '" & TxtCrsCode.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Dim courseFound As Boolean = False

        While dr.Read()
            courseFound = True
            TxtCrsTitle.Text = dr("CourseTitle").ToString
            TxtCredits.Text = dr("Credits").ToString
            CmbDays.Text = dr("Days").ToString
            TxtLecturer.Text = dr("Lecturer").ToString
        End While

        If courseFound = False Then
            MsgBox("Sorry, lecturer was not found", MsgBoxStyle.OkOnly, "Not Found")
        End If
        myConnection.Close()


    End Sub

    Private Sub Code_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCrsCode.KeyPress

        If Char.IsLower(e.KeyChar) Then

            'Convert to uppercase, and put at the caret position in the TextBox.
            TxtCrsCode.SelectedText = Char.ToUpper(e.KeyChar)

            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the BtnSearch_Click Event
            BtnSearch_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        UpdateCourse()
    End Sub

    Private Sub UpdateCourse()
        myConnection.Open()
        Dim str As String
        str = "update [timetable] set [CourseTitle]= '" & TxtCrsTitle.Text & "', [Credits]='" & TxtCredits.Text & "', [Days]='" & CmbDays.Text & "', [Time]='" & CmbTimes.Text & "', [Lab]='" & CmbLabs.Text & "', [Lecturer]='" & TxtLecturer.Text & "'   Where [CourseCode] = '" & TxtCrsCode.Text & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            MsgBox("Timetable has been updated", MsgBoxStyle.OkOnly, "Success!")

        Catch ex As Exception
            myConnection.Close()
            MsgBox("Sorry, timetable could not be updated", MsgBoxStyle.OkOnly, "Error")
        End Try


        LoadData()

    End Sub

    Private Sub BtnUpdateLect_Click(sender As Object, e As EventArgs) Handles BtnUpdateLect.Click
        retrieveLecturer()
        retrieveLecturer2()
    End Sub

    Private Sub retrieveLecturer()
        Dim str As String
        Dim strArr() As String

        str = CmbLecturers.SelectedItem
        strArr = str.Split(" ")

        Fname = strArr(0)
        Lname = strArr(1)

        myConnection.Open()
        Dim str2 As String
        str2 = "Select * from lecturers where (Fname= '" & Fname & "' and Lname = '" & Lname & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(str2, myConnection)
        dr = cmd.ExecuteReader
        Dim codefound As Boolean = False

        While dr.Read()
            codefound = True
            creditHrs = dr("UsedCreditHrs").ToString
        End While

        If codefound = False Then
            MsgBox("sorry, lecturer was not found", MsgBoxStyle.OkOnly, "not found")
        End If

        myConnection.Close()
        updateCreditHrs(creditHrs, Fname, Lname)
    End Sub

    Private Sub retrieveLecturer2()
        Dim str As String
        Dim strArr() As String

        str = TxtLecturer.Text
        strArr = str.Split(" ")

        Fname = strArr(0)
        Lname = strArr(1)

        myConnection.Open()
        Dim str2 As String
        str2 = "Select * from lecturers where (Fname= '" & Fname & "' and Lname = '" & Lname & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(str2, myConnection)
        dr = cmd.ExecuteReader
        Dim codefound As Boolean = False

        While dr.Read()
            codefound = True
            creditHrs = dr("UsedCreditHrs").ToString
        End While

        If codefound = False Then
            MsgBox("sorry, lecturer was not found", MsgBoxStyle.OkOnly, "not found")
        End If

        myConnection.Close()
        updateCreditHrs2(creditHrs, Fname, Lname)

    End Sub

    Private Sub updateCreditHrs(creditHrs As Integer, Fname As String, Lname As String)
        creditHrs = creditHrs + TxtCredits.Text

        myConnection.Open()
        Dim str As String
        str = "update [lecturers] set [UsedCreditHrs]='" & creditHrs & "'Where [Fname] = '" & Fname & "' AND [Lname]= '" & Lname & "' "
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            MsgBox("New lecturer's credit hours has been updated", MsgBoxStyle.OkOnly, "Success!")

        Catch ex As Exception
            myConnection.Close()
            MsgBox("Sorry, lecturer credit hours could not be updated", MsgBoxStyle.OkOnly, "Error")
        End Try
        updateLecturer()

    End Sub

    Private Sub updateLecturer()
        myConnection.Open()
        Dim str As String
        str = "update [timetable] set [Lecturer]='" & CmbLecturers.Text & "'   Where [CourseCode] = '" & TxtCrsCode.Text & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            MsgBox("Timetable has been updated", MsgBoxStyle.OkOnly, "Success!")

        Catch ex As Exception
            myConnection.Close()
            MsgBox("Sorry, timetable could not be updated", MsgBoxStyle.OkOnly, "Error")
        End Try


        LoadData()
    End Sub


    Private Sub updateCreditHrs2(creditHrs As Integer, Fname As String, Lname As String)
        creditHrs = creditHrs - TxtCredits.Text

        myConnection.Open()
        Dim str As String
        str = "update [lecturers] set [UsedCreditHrs]='" & creditHrs & "'Where [Fname] = '" & Fname & "' AND [Lname]= '" & Lname & "' "
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            MsgBox("Previous lecturer's credit hours has been updated", MsgBoxStyle.OkOnly, "Success!")

        Catch ex As Exception
            myConnection.Close()
            MsgBox("Sorry, lecturer credit hours could not be updated", MsgBoxStyle.OkOnly, "Error")
        End Try


        LoadData()
    End Sub

    Private Sub LblHome_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblHome.LinkClicked
        Hide()
        Main.Show()
    End Sub

    Private Sub LblLogout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblLogout.LinkClicked
        Main.Logout()
    End Sub
End Class