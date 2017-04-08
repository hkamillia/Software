Imports System.Data.OleDb

Public Class CreateTimetable

    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Public myConnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader


    Private Sub CreateTimetable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "|DataDirectory|\Database\CSCSdb.mdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString

        CmbCourses4.Visible = False
        CmbLecturers4.Visible = False
        CmbLabs4.Visible = False
        LoadCourses()
        LoadLabs()

    End Sub

    Private Sub LoadCourses()


        CmbCourses1.Items.Clear()
        CmbCourses2.Items.Clear()
        CmbCourses3.Items.Clear()
        CmbCourses4.Items.Clear()

        myConnection.Open()
        Dim str As String
        str = "SELECT CourseTitle FROM courses WHERE (SemesterOffered = '" & PickSemCreate.semester & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Do While (dr.Read())
            CmbCourses1.Items.Add(dr.GetString(0))
            CmbCourses2.Items.Add(dr.GetString(0))
            CmbCourses3.Items.Add(dr.GetString(0))
            CmbCourses4.Items.Add(dr.GetString(0))
        Loop
        dr.Close()
        cmd.Dispose()
        myConnection.Close()


    End Sub

    Private Sub LoadLecturers()

        CmbLecturers1.Items.Clear()
        CmbLecturers2.Items.Clear()
        CmbLecturers3.Items.Clear()
        CmbLecturers4.Items.Clear()

        myConnection.Open()
        Dim str As String
        Dim str2 As String
        If CmbTimes.SelectedItem = "8:00AM-9:15AM" Or CmbTimes.SelectedItem = "" Or CmbTimes.SelectedItem = "10:50AM-12:05PM" Then
            str = "SELECT [Fname], [Lname] FROM lecturers WHERE (TimeAvailable = '" & "Part Time-Morning (8:00AM-12:05PM)" & "')"
            str2 = "SELECT [Fname], [Lname] FROM lecturers WHERE (TimeAvailable = '" & "Full Time" & "')"
            Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
            dr = cmd.ExecuteReader
            Do While (dr.Read())
                CmbLecturers1.Items.Add(dr.GetString(0) + " " + dr.GetString(1))
                CmbLecturers2.Items.Add(dr.GetString(0) + " " + dr.GetString(1))
                CmbLecturers3.Items.Add(dr.GetString(0) + " " + dr.GetString(1))
                CmbLecturers4.Items.Add(dr.GetString(0) + " " + dr.GetString(1))
            Loop
            dr.Close()
            cmd.Dispose()


            Dim cmd2 As OleDbCommand = New OleDbCommand(str2, myConnection)
            dr = cmd2.ExecuteReader
            Do While (dr.Read())
                CmbLecturers1.Items.Add(dr.GetString(0) + " " + dr.GetString(1))
                CmbLecturers2.Items.Add(dr.GetString(0) + " " + dr.GetString(1))
                CmbLecturers3.Items.Add(dr.GetString(0) + " " + dr.GetString(1))
                CmbLecturers4.Items.Add(dr.GetString(0) + " " + dr.GetString(1))
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
                CmbLecturers1.Items.Add(dr.GetString(0) + " " + dr.GetString(1))
                CmbLecturers2.Items.Add(dr.GetString(0) + " " + dr.GetString(1))
                CmbLecturers3.Items.Add(dr.GetString(0) + " " + dr.GetString(1))
                CmbLecturers4.Items.Add(dr.GetString(0) + " " + dr.GetString(1))
            Loop
            dr.Close()
            cmd.Dispose()

            Dim cmd2 As OleDbCommand = New OleDbCommand(str2, myConnection)
            dr = cmd2.ExecuteReader
            Do While (dr.Read())
                CmbLecturers1.Items.Add(dr.GetString(0) + " " + dr.GetString(1))
                CmbLecturers2.Items.Add(dr.GetString(0) + " " + dr.GetString(1))
                CmbLecturers3.Items.Add(dr.GetString(0) + " " + dr.GetString(1))
                CmbLecturers4.Items.Add(dr.GetString(0) + " " + dr.GetString(1))
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
                CmbLecturers1.Items.Add(dr.GetString(0) + " " + dr.GetString(1))
                CmbLecturers2.Items.Add(dr.GetString(0) + " " + dr.GetString(1))
                CmbLecturers3.Items.Add(dr.GetString(0) + " " + dr.GetString(1))
                CmbLecturers4.Items.Add(dr.GetString(0) + " " + dr.GetString(1))
            Loop
            dr.Close()
            cmd.Dispose()

            Dim cmd2 As OleDbCommand = New OleDbCommand(str2, myConnection)
            dr = cmd2.ExecuteReader
            Do While (dr.Read())
                CmbLecturers1.Items.Add(dr.GetString(0) + " " + dr.GetString(1))
                CmbLecturers2.Items.Add(dr.GetString(0) + " " + dr.GetString(1))
                CmbLecturers3.Items.Add(dr.GetString(0) + " " + dr.GetString(1))
                CmbLecturers4.Items.Add(dr.GetString(0) + " " + dr.GetString(1))
            Loop
            dr.Close()
            cmd2.Dispose()
            myConnection.Close()
        End If
    End Sub

    Private Sub LblBack_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblBack.LinkCLicked
        Hide()
        PickSemCreate.Show()
    End Sub

    Private Sub CmbTimes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTimes.SelectedIndexChanged
        LoadLecturers()
    End Sub


    Private Sub LoadLabs()

        CmbLabs1.Items.Clear()
        CmbLabs2.Items.Clear()
        CmbLabs3.Items.Clear()
        CmbLabs4.Items.Clear()

        myConnection.Open()
        Dim str As String
        str = "SELECT LabID FROM labs"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Do While (dr.Read())
            CmbLabs1.Items.Add(dr.GetString(0))
            CmbLabs2.Items.Add(dr.GetString(0))
            CmbLabs3.Items.Add(dr.GetString(0))
            CmbLabs4.Items.Add(dr.GetString(0))
        Loop
        dr.Close()
        cmd.Dispose()
        myConnection.Close()

    End Sub


End Class