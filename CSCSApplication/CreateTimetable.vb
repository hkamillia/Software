Imports System.Data.OleDb

Public Class CreateTimetable

    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Public myConnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader
    Dim days As String
    Dim classSize As Integer
    Dim priority As Integer
    Dim priorities(4) As Integer
    Dim lecturers(4) As String
    Dim labs(4) As String
    Dim courseCode As String
    Dim credits As Integer


    Private Sub CreateTimetable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "|DataDirectory|\Database\CSCSdb.mdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString

        CmbCourses4.Visible = False
        CmbLecturers4.Visible = False
        CmbLabs4.Visible = False
        BtnSave4.Visible = False
    End Sub

    Private Sub BtnAddNew_Click(sender As Object, e As EventArgs) Handles BtnAddNew.Click
        BtnRemove.Enabled = True
        CmbCourses4.Visible = True
        CmbLecturers4.Visible = True
        CmbLabs4.Visible = True
        BtnSave4.Visible = True
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        CmbCourses4.Visible = False
        CmbLecturers4.Visible = False
        CmbLabs4.Visible = False
        BtnSave4.Visible = False
        BtnRemove.Enabled = False
    End Sub

    Private Sub BtnMW_CheckedChanged(sender As Object, e As EventArgs) Handles BtnMW.CheckedChanged
        LoadCourses()
        days = "M/W"
    End Sub

    Private Sub BtnTuTh_CheckedChanged(sender As Object, e As EventArgs) Handles BtnTuTh.CheckedChanged
        LoadCourses()
        days = "Tu/Th"
    End Sub
    Private Sub CmbTimes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTimes.SelectedIndexChanged
        LoadLecturers()
    End Sub
    Private Sub CmbCourses1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCourses1.SelectedIndexChanged
        getMaxClass1()
    End Sub

    Private Sub CmbCourses2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCourses2.SelectedIndexChanged
        getMaxClass2()
    End Sub

    Private Sub CmbCourses3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCourses3.SelectedIndexChanged
        getMaxClass3()
    End Sub

    Private Sub CmbCourses4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCourses4.SelectedIndexChanged
        getMaxClass4()
    End Sub

    Private Sub getMaxClass1()

        myConnection.Open()
        Dim str As String
        str = "SELECT MaxClassSize FROM courses WHERE (CourseTitle= '" & CmbCourses1.SelectedItem & "' AND SemesterOffered = '" & PickSemCreate.semester & "')"
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

        LoadLabs1(classSize)

    End Sub

    Private Sub getMaxClass2()

        myConnection.Open()
        Dim str As String
        str = "SELECT MaxClassSize FROM courses WHERE (CourseTitle= '" & CmbCourses2.SelectedItem & "' AND SemesterOffered = '" & PickSemCreate.semester & "')"
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

        LoadLabs2(classSize)
    End Sub

    Private Sub getMaxClass3()

        myConnection.Open()
        Dim str As String
        str = "SELECT MaxClassSize FROM courses WHERE (CourseTitle= '" & CmbCourses3.SelectedItem & "' AND SemesterOffered = '" & PickSemCreate.semester & "')"
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

        LoadLabs3(classSize)
    End Sub

    Private Sub getMaxClass4()

        myConnection.Open()
        Dim str As String
        str = "SELECT MaxClassSize FROM courses WHERE (CourseTitle= '" & CmbCourses4.SelectedItem & "' AND SemesterOffered = '" & PickSemCreate.semester & "')"
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

        LoadLabs4(classSize)

    End Sub



    Private Sub LoadLabs1(classSize As Integer)
        CmbLabs1.Items.Clear()

        myConnection.Open()
        Dim str As String
        Dim str2 As String
        str = "SELECT LabID FROM labs WHERE (SeatingCapacity >= " & classSize & " )"
        str2 = "SELECT LabID FROM labs WHERE(SeatingCapacity= 0)"

        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Do While (dr.Read())
            CmbLabs1.Items.Add(dr.GetString(0))
        Loop
        dr.Close()
        cmd.Dispose()


        Dim cmd2 As OleDbCommand = New OleDbCommand(str2, myConnection)
        dr = cmd2.ExecuteReader
        Do While (dr.Read())
            CmbLabs1.Items.Add(dr.GetString(0))
        Loop
        dr.Close()
        cmd.Dispose()
        myConnection.Close()
    End Sub

    Private Sub LoadLabs2(classSize As Integer)
        CmbLabs2.Items.Clear()

        myConnection.Open()
        Dim str As String
        Dim str2 As String
        str = "SELECT LabID FROM labs WHERE (SeatingCapacity >= " & classSize & " )"
        str2 = "SELECT LabID FROM labs WHERE(SeatingCapacity= 0)"

        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Do While (dr.Read())
            CmbLabs2.Items.Add(dr.GetString(0))
        Loop
        dr.Close()
        cmd.Dispose()


        Dim cmd2 As OleDbCommand = New OleDbCommand(str2, myConnection)
        dr = cmd2.ExecuteReader
        Do While (dr.Read())
            CmbLabs2.Items.Add(dr.GetString(0))
        Loop
        dr.Close()
        cmd.Dispose()
        myConnection.Close()
    End Sub

    Private Sub LoadLabs3(classSize As Integer)
        CmbLabs3.Items.Clear()

        myConnection.Open()
        Dim str As String
        Dim str2 As String
        str = "SELECT LabID FROM labs WHERE (SeatingCapacity >= " & classSize & " )"
        str2 = "SELECT LabID FROM labs WHERE(SeatingCapacity= 0)"

        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Do While (dr.Read())
            CmbLabs3.Items.Add(dr.GetString(0))
        Loop
        dr.Close()
        cmd.Dispose()


        Dim cmd2 As OleDbCommand = New OleDbCommand(str2, myConnection)
        dr = cmd2.ExecuteReader
        Do While (dr.Read())
            CmbLabs3.Items.Add(dr.GetString(0))
        Loop
        dr.Close()
        cmd.Dispose()
        myConnection.Close()
    End Sub

    Private Sub LoadLabs4(classSize As Integer)
        CmbLabs4.Items.Clear()

        myConnection.Open()
        Dim str As String
        Dim str2 As String
        str = "SELECT LabID FROM labs WHERE (SeatingCapacity >= " & classSize & " )"
        str2 = "SELECT LabID FROM labs WHERE(SeatingCapacity= 0)"

        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Do While (dr.Read())
            CmbLabs4.Items.Add(dr.GetString(0))
        Loop
        dr.Close()
        cmd.Dispose()


        Dim cmd2 As OleDbCommand = New OleDbCommand(str2, myConnection)
        dr = cmd2.ExecuteReader
        Do While (dr.Read())
            CmbLabs4.Items.Add(dr.GetString(0))
        Loop
        dr.Close()
        cmd.Dispose()
        myConnection.Close()
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
        If CmbTimes.SelectedItem = "8:00AM-9:15AM" Or CmbTimes.SelectedItem = "9:25AM-10:40AM" Or CmbTimes.SelectedItem = "10:50AM-12:05PM" Then
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

    Private Sub BtnCheckCourses_Click(sender As Object, e As EventArgs) Handles BtnCheckCourses.Click
        getPriority1()
    End Sub

    Private Sub getPriority1()
        myConnection.Open()
        Dim str As String
        str = "SELECT Priority FROM courses WHERE (CourseTitle= '" & CmbCourses1.SelectedItem & "' AND SemesterOffered = '" & PickSemCreate.semester & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Dim priorityFound As Boolean = False

        While dr.Read()
            priorityFound = True
            priority = dr("Priority").ToString
        End While

        If priorityFound = False Then
            MsgBox("Sorry, course was not found", MsgBoxStyle.OkOnly, "Not Found")
        End If
        myConnection.Close()

        setPriority1(priority)
    End Sub

    Private Sub setPriority1(priority As Integer)
        priorities(0) = priority
        getPriority2()
    End Sub
    Private Sub getPriority2()
        myConnection.Open()
        Dim str As String
        str = "SELECT Priority FROM courses WHERE (CourseTitle= '" & CmbCourses2.SelectedItem & "' AND SemesterOffered = '" & PickSemCreate.semester & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Dim priorityFound As Boolean = False

        While dr.Read()
            priorityFound = True
            priority = dr("Priority").ToString
        End While

        If priorityFound = False Then
            MsgBox("Sorry, course was not found", MsgBoxStyle.OkOnly, "Not Found")
        End If
        myConnection.Close()

        setPriority2(priority)
    End Sub

    Private Sub setPriority2(priority As Integer)
        priorities(1) = priority
        getPriority3()
    End Sub

    Private Sub getPriority3()
        myConnection.Open()
        Dim str As String
        str = "SELECT Priority FROM courses WHERE (CourseTitle= '" & CmbCourses3.SelectedItem & "' AND SemesterOffered = '" & PickSemCreate.semester & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Dim priorityFound As Boolean = False

        While dr.Read()
            priorityFound = True
            priority = dr("Priority").ToString
        End While

        If priorityFound = False Then
            MsgBox("Sorry, course was not found", MsgBoxStyle.OkOnly, "Not Found")
        End If
        myConnection.Close()

        setPriority3(priority)
    End Sub

    Private Sub setPriority3(priority As Integer)
        priorities(2) = priority
        If CmbCourses4.Visible = True Then
            getPriority4()
        Else
            checkCourses(priorities)
        End If
    End Sub

    Private Sub getPriority4()
        myConnection.Open()
        Dim str As String
        str = "SELECT Priority FROM courses WHERE (CourseTitle= '" & CmbCourses4.SelectedItem & "' AND SemesterOffered = '" & PickSemCreate.semester & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Dim priorityFound As Boolean = False

        While dr.Read()
            priorityFound = True
            priority = dr("Priority").ToString
        End While

        If priorityFound = False Then
            MsgBox("Sorry, course was not found", MsgBoxStyle.OkOnly, "Not Found")
        End If
        myConnection.Close()

        setPriority4(priority)
    End Sub

    Private Sub setPriority4(priority As Integer)
        priorities(3) = priority
        checkCourses(priorities)

    End Sub

    Private Sub checkCourses(priorities() As Integer)

        If CmbCourses4.Visible Then

            If priorities(0) = 3 Then
                If priorities(1) = priorities(2) Or priorities(1) = priorities(3) Or priorities(2) = priorities(3) Then

                    MsgBox("A clash may take place!", MsgBoxStyle.OkOnly, "Flag")
                Else
                    MsgBox("No clashes spotted!", MsgBoxStyle.OkOnly, "Proceed")
                End If
            ElseIf priorities(1) = 3 Then
                If priorities(0) = priorities(2) Or priorities(0) = priorities(3) Or priorities(2) = priorities(3) Then

                    MsgBox("A clash may take place!", MsgBoxStyle.OkOnly, "Flag")
                Else
                    MsgBox("No clashes spotted!", MsgBoxStyle.OkOnly, "Proceed")
                End If
            ElseIf priorities(2) = 3 Then
                If priorities(0) = priorities(1) Or priorities(0) = priorities(3) Or priorities(1) = priorities(3) Then

                    MsgBox("A clash may take place!", MsgBoxStyle.OkOnly, "Flag")
                Else
                    MsgBox("No clashes spotted!", MsgBoxStyle.OkOnly, "Proceed")
                End If
            ElseIf priorities(3) = 3 Then
                If priorities(0) = priorities(2) Or priorities(0) = priorities(1) Or priorities(1) = priorities(2) Then

                    MsgBox("A clash may take place!", MsgBoxStyle.OkOnly, "Flag")
                Else
                    MsgBox("No clashes spotted!", MsgBoxStyle.OkOnly, "Proceed")
                End If
            Else
                If priorities(0) = priorities(1) Or priorities(0) = priorities(2) Or priorities(0) = priorities(3) Or priorities(1) = priorities(2) Or priorities(1) = priorities(3) Or priorities(2) = priorities(3) Then

                    MsgBox("A clash may take place!", MsgBoxStyle.OkOnly, "Flag")
                Else
                    MsgBox("No clashes spotted!", MsgBoxStyle.OkOnly, "Proceed")
                End If
            End If
        Else

            If priorities(0) = 3 Then
                If priorities(1) = priorities(2) Then

                    MsgBox("A clash may take place!", MsgBoxStyle.OkOnly, "Flag")
                Else
                    MsgBox("No clashes spotted!", MsgBoxStyle.OkOnly, "Proceed")
                End If
            ElseIf priorities(1) = 3 Then
                If priorities(0) = priorities(2) Then

                    MsgBox("A clash may take place!", MsgBoxStyle.OkOnly, "Flag")
                Else
                    MsgBox("No clashes spotted!", MsgBoxStyle.OkOnly, "Proceed")
                End If
            ElseIf priorities(2) = 3 Then
                If priorities(0) = priorities(1) Then

                    MsgBox("A clash may take place!", MsgBoxStyle.OkOnly, "Flag")
                Else
                    MsgBox("No clashes spotted!", MsgBoxStyle.OkOnly, "Proceed")
                End If
            Else
                If priorities(0) = priorities(1) Or priorities(0) = priorities(2) Or priorities(1) = priorities(2) Then
                    MsgBox("A clash may take place!", MsgBoxStyle.OkOnly, "Flag")
                Else
                    MsgBox("No clashes spotted!", MsgBoxStyle.OkOnly, "Proceed")
                End If
            End If
        End If
    End Sub

    Private Sub BtnCheckLecturers_Click(sender As Object, e As EventArgs) Handles BtnCheckLecturers.Click
        setLecturer1()
    End Sub

    Private Sub setLecturer1()
        lecturers(0) = CmbLecturers1.SelectedItem
        setLecturer2()
    End Sub

    Private Sub setLecturer2()
        lecturers(1) = CmbLecturers2.SelectedItem
        setLecturer3()
    End Sub

    Private Sub setLecturer3()
        lecturers(2) = CmbLecturers3.SelectedItem
        If CmbCourses4.Visible = True Then
            setLecturer4()
        Else
            checkLecturers(lecturers)
        End If
    End Sub

    Private Sub setLecturer4()
        lecturers(3) = CmbLecturers4.SelectedItem
        checkLecturers(lecturers)
    End Sub


    Private Sub checkLecturers(lecturers() As String)
        If CmbCourses4.Visible Then
            If lecturers(0) = lecturers(1) Or lecturers(0) = lecturers(2) Or lecturers(0) = lecturers(3) Or lecturers(1) = lecturers(2) Or lecturers(1) = lecturers(3) Or lecturers(2) = lecturers(3) Then

                MsgBox("Same lecturer chosen more than once!", MsgBoxStyle.OkOnly, "Flag")
            Else
                MsgBox("Good to go!", MsgBoxStyle.OkOnly, "Proceed")

            End If
        Else
            If lecturers(0) = lecturers(1) Or lecturers(0) = lecturers(2) Or lecturers(1) = lecturers(2) Then

                MsgBox("Same lecturer chosen more than once!", MsgBoxStyle.OkOnly, "Flag")
            Else
                MsgBox("Good to go!", MsgBoxStyle.OkOnly, "Proceed")

            End If
        End If
    End Sub

    Private Sub BtnCheckLabs_Click(sender As Object, e As EventArgs) Handles BtnCheckLabs.Click
        setLab1()
    End Sub


    Private Sub setLab1()
        labs(0) = CmbLabs1.SelectedItem
        setLab2()
    End Sub

    Private Sub setLab2()
        labs(1) = CmbLabs2.SelectedItem
        setLab3()
    End Sub

    Private Sub setLab3()
        labs(2) = CmbLabs3.SelectedItem
        If CmbCourses4.Visible = True Then
            setLab4()
        Else
            checkLabs(labs)
        End If
    End Sub

    Private Sub setLab4()
        labs(3) = CmbLabs4.SelectedItem
        checkLabs(labs)
    End Sub

    Private Sub checkLabs(labs() As String)
        If CmbCourses4.Visible Then

            If labs(0) = "NO LAB" Then
                If labs(1) = labs(2) Or labs(1) = labs(3) Or labs(2) = labs(3) Then

                    MsgBox("Lab chosen more than once!", MsgBoxStyle.OkOnly, "Flag")
                Else
                    MsgBox("Proceed!", MsgBoxStyle.OkOnly, "Proceed")
                End If
            ElseIf labs(1) = "NO LAB" Then
                If labs(0) = labs(2) Or labs(0) = labs(3) Or labs(2) = labs(3) Then

                    MsgBox("Lab chosen more than once!", MsgBoxStyle.OkOnly, "Flag")
                Else
                    MsgBox("Proceed!", MsgBoxStyle.OkOnly, "Proceed")
                End If
            ElseIf labs(2) = "NO LAB" Then
                If labs(0) = labs(1) Or labs(0) = priorities(3) Or labs(1) = labs(3) Then

                    MsgBox("Lab chosen more than once!", MsgBoxStyle.OkOnly, "Flag")
                Else
                    MsgBox("Proceed!", MsgBoxStyle.OkOnly, "Proceed")
                End If
            ElseIf labs(3) = "NO LAB" Then
                If labs(0) = labs(2) Or labs(0) = labs(1) Or labs(1) = labs(2) Then

                    MsgBox("Lab chosen more than once!", MsgBoxStyle.OkOnly, "Flag")
                Else
                    MsgBox("Proceed!", MsgBoxStyle.OkOnly, "Proceed")
                End If
            Else
                If labs(0) = labs(1) Or labs(0) = labs(2) Or labs(0) = labs(3) Or labs(1) = labs(2) Or labs(1) = labs(3) Or labs(2) = labs(3) Then

                    MsgBox("Lab chosen more than once!", MsgBoxStyle.OkOnly, "Flag")
                Else
                    MsgBox("Proceed!", MsgBoxStyle.OkOnly, "Proceed")
                End If
            End If
        Else

            If labs(0) = "NO LAB" Then
                If labs(1) = labs(2) Then

                    MsgBox("Lab chosen more than once!", MsgBoxStyle.OkOnly, "Flag")
                Else
                    MsgBox("Proceed!", MsgBoxStyle.OkOnly, "Proceed")
                End If
            ElseIf labs(1) = "NO LAB" Then
                If labs(0) = labs(2) Then

                    MsgBox("Lab chosen more than once!", MsgBoxStyle.OkOnly, "Flag")
                Else
                    MsgBox("Proceed!", MsgBoxStyle.OkOnly, "Proceed")
                End If
            ElseIf labs(2) = "NO LAB" Then
                If labs(0) = labs(1) Then

                    MsgBox("Lab chosen more than once!", MsgBoxStyle.OkOnly, "Flag")
                Else
                    MsgBox("Proceed!", MsgBoxStyle.OkOnly, "Proceed")
                End If
            Else
                If labs(0) = labs(1) Or labs(0) = labs(2) Or labs(1) = labs(2) Then
                    MsgBox("Lab chosen more than once!", MsgBoxStyle.OkOnly, "Flag")
                Else
                    MsgBox("Proceed!", MsgBoxStyle.OkOnly, "Proceed")
                End If
            End If
        End If
    End Sub

    Private Sub BtnSave1_Click(sender As Object, e As EventArgs) Handles BtnSave1.Click
        getCourseCode1()
    End Sub

    Private Sub getCourseCode1()
        myConnection.Open()
        Dim str As String
        str = "Select * from courses where (CourseTitle= '" & CmbCourses1.SelectedItem & "' and SemesterOffered = '" & PickSemCreate.semester & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Dim codefound As Boolean = False

        While dr.Read()
            codefound = True
            courseCode = dr("CourseCode").ToString
            credits = dr("Credits").ToString
        End While

        If codefound = False Then
            MsgBox("sorry, course was not found", MsgBoxStyle.OkOnly, "not found")
        End If
        myConnection.Close()
        Save1(courseCode, credits)

    End Sub

    Private Sub Save1(courseCode As String, credits As Integer)
        myConnection.Open()
        Dim sqlCheck As New OleDbCommand("SELECT count(*) FROM timetable WHERE CourseCode = '" & courseCode & "' AND [Semester] = '" & PickSemCreate.semester & "'", myConnection)
        sqlCheck.Parameters.AddWithValue("CourseCode", courseCode)
        sqlCheck.Parameters.AddWithValue("Semester", PickSemCreate.semester)

        dr = sqlCheck.ExecuteReader()
        If dr.HasRows = True Then
            dr.Read()
            If dr.Item(0) = 0 Then 'Course can be added
                Dim str As String
                str = "insert into timetable ([CourseCode], [CourseTitle],[Credits], [Days], [Time],[Lab], [Lecturer], [Semester])
               values (?, ?, ?, ?, ?, ?, ?, ?)"
                Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
                cmd.Parameters.Add(New OleDbParameter("CourseCode", CType(courseCode, String)))
                cmd.Parameters.Add(New OleDbParameter("CourseTitle", CType(CmbCourses1.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("Credits", CType(credits, String)))
                cmd.Parameters.Add(New OleDbParameter("Days", CType(days, String)))
                cmd.Parameters.Add(New OleDbParameter("Time", CType(CmbTimes.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("Lab", CType(CmbLabs1.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("Lecturer", CType(CmbLecturers1.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("Semester", CType(PickSemCreate.semester, String)))

                Try
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    myConnection.Close()
                    MsgBox("The course was successfully added.", MsgBoxStyle.OkOnly, "Success!")
                Catch ex As Exception
                    MsgBox("Sorry, the course could not be added.", MsgBoxStyle.OkOnly, "Success!")
                    myConnection.Close()
                End Try
            Else
                MsgBox("The course was already added.", MsgBoxStyle.OkOnly, "Already Added")
                myConnection.Close()
            End If
        End If
    End Sub

    Private Sub BtnSave2_Click(sender As Object, e As EventArgs) Handles BtnSave2.Click
        getCourseCode2()
    End Sub

    Private Sub getCourseCode2()
        myConnection.Open()
        Dim str As String
        str = "Select * from courses where (CourseTitle= '" & CmbCourses2.SelectedItem & "' and SemesterOffered = '" & PickSemCreate.semester & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Dim codefound As Boolean = False

        While dr.Read()
            codefound = True
            courseCode = dr("CourseCode").ToString
            credits = dr("Credits").ToString
        End While

        If codefound = False Then
            MsgBox("sorry, course was not found", MsgBoxStyle.OkOnly, "not found")
        End If
        myConnection.Close()
        Save2(courseCode, credits)
    End Sub

    Private Sub Save2(courseCode As String, credits As Integer)
        myConnection.Open()
        Dim sqlCheck As New OleDbCommand("SELECT count(*) FROM timetable WHERE CourseCode = '" & courseCode & "' AND [Semester] = '" & PickSemCreate.semester & "'", myConnection)
        sqlCheck.Parameters.AddWithValue("CourseCode", courseCode)
        sqlCheck.Parameters.AddWithValue("Semester", PickSemCreate.semester)

        dr = sqlCheck.ExecuteReader()
        If dr.HasRows = True Then
            dr.Read()
            If dr.Item(0) = 0 Then 'Course can be added
                Dim str As String
                str = "insert into timetable ([CourseCode], [CourseTitle],[Credits], [Days], [Time],[Lab], [Lecturer], [Semester])
               values (?, ?, ?, ?, ?, ?, ?, ?)"
                Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
                cmd.Parameters.Add(New OleDbParameter("CourseCode", CType(courseCode, String)))
                cmd.Parameters.Add(New OleDbParameter("CourseTitle", CType(CmbCourses2.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("Credits", CType(credits, String)))
                cmd.Parameters.Add(New OleDbParameter("Days", CType(days, String)))
                cmd.Parameters.Add(New OleDbParameter("Time", CType(CmbTimes.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("Lab", CType(CmbLabs2.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("Lecturer", CType(CmbLecturers2.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("Semester", CType(PickSemCreate.semester, String)))

                Try
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    myConnection.Close()
                    MsgBox("The course was successfully added.", MsgBoxStyle.OkOnly, "Success!")
                Catch ex As Exception
                    MsgBox("Sorry, the course could not be added.", MsgBoxStyle.OkOnly, "Success!")
                    myConnection.Close()
                End Try
            Else
                MsgBox("The course was already added.", MsgBoxStyle.OkOnly, "Already Added")
                myConnection.Close()
            End If
        End If
    End Sub

    Private Sub BtnSave3_Click(sender As Object, e As EventArgs) Handles BtnSave3.Click
        getCourseCode3()
    End Sub

    Private Sub getCourseCode3()
        myConnection.Open()
        Dim str As String
        str = "Select * from courses where (CourseTitle= '" & CmbCourses3.SelectedItem & "' and SemesterOffered = '" & PickSemCreate.semester & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Dim codefound As Boolean = False

        While dr.Read()
            codefound = True
            courseCode = dr("CourseCode").ToString
            credits = dr("Credits").ToString
        End While

        If codefound = False Then
            MsgBox("sorry, course was not found", MsgBoxStyle.OkOnly, "not found")
        End If
        myConnection.Close()
        Save3(courseCode, credits)
    End Sub

    Private Sub Save3(courseCode As String, credits As Integer)
        myConnection.Open()
        Dim sqlCheck As New OleDbCommand("SELECT count(*) FROM timetable WHERE CourseCode = '" & courseCode & "' AND [Semester] = '" & PickSemCreate.semester & "'", myConnection)
        sqlCheck.Parameters.AddWithValue("CourseCode", courseCode)
        sqlCheck.Parameters.AddWithValue("Semester", PickSemCreate.semester)

        dr = sqlCheck.ExecuteReader()
        If dr.HasRows = True Then
            dr.Read()
            If dr.Item(0) = 0 Then 'Course can be added
                Dim str As String
                str = "insert into timetable ([CourseCode], [CourseTitle],[Credits], [Days], [Time],[Lab], [Lecturer], [Semester])
               values (?, ?, ?, ?, ?, ?, ?, ?)"
                Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
                cmd.Parameters.Add(New OleDbParameter("CourseCode", CType(courseCode, String)))
                cmd.Parameters.Add(New OleDbParameter("CourseTitle", CType(CmbCourses3.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("Credits", CType(credits, String)))
                cmd.Parameters.Add(New OleDbParameter("Days", CType(days, String)))
                cmd.Parameters.Add(New OleDbParameter("Time", CType(CmbTimes.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("Lab", CType(CmbLabs3.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("Lecturer", CType(CmbLecturers3.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("Semester", CType(PickSemCreate.semester, String)))

                Try
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    myConnection.Close()
                    MsgBox("The course was successfully added.", MsgBoxStyle.OkOnly, "Success!")
                Catch ex As Exception
                    MsgBox("Sorry, the course could not be added.", MsgBoxStyle.OkOnly, "Success!")
                    myConnection.Close()
                End Try
            Else
                myConnection.Close()
                MsgBox("The course was already added.", MsgBoxStyle.OkOnly, "Already Added")
            End If
        End If
    End Sub

    Private Sub BtnSave4_Click(sender As Object, e As EventArgs) Handles BtnSave4.Click
        getCourseCode4()
    End Sub

    Private Sub getCourseCode4()
        myConnection.Open()
        Dim str As String
        str = "Select * from courses where (CourseTitle= '" & CmbCourses4.SelectedItem & "' and SemesterOffered = '" & PickSemCreate.semester & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Dim codefound As Boolean = False

        While dr.Read()
            codefound = True
            courseCode = dr("CourseCode").ToString
            credits = dr("Credits").ToString
        End While

        If codefound = False Then
            MsgBox("sorry, course was not found", MsgBoxStyle.OkOnly, "not found")
        End If
        myConnection.Close()
        Save4(courseCode, credits)
    End Sub

    Private Sub Save4(courseCode As String, credits As Integer)
        myConnection.Open()
        Dim sqlCheck As New OleDbCommand("SELECT count(*) FROM timetable WHERE CourseCode = '" & courseCode & "' AND [Semester] = '" & PickSemCreate.semester & "'", myConnection)
        sqlCheck.Parameters.AddWithValue("CourseCode", courseCode)
        sqlCheck.Parameters.AddWithValue("Semester", PickSemCreate.semester)

        dr = sqlCheck.ExecuteReader()
        If dr.HasRows = True Then
            dr.Read()
            If dr.Item(0) = 0 Then 'Course can be added
                Dim str As String
                str = "insert into timetable ([CourseCode], [CourseTitle],[Credits], [Days], [Time],[Lab], [Lecturer], [Semester])
               values (?, ?, ?, ?, ?, ?, ?, ?)"
                Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
                cmd.Parameters.Add(New OleDbParameter("CourseCode", CType(courseCode, String)))
                cmd.Parameters.Add(New OleDbParameter("CourseTitle", CType(CmbCourses4.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("Credits", CType(credits, String)))
                cmd.Parameters.Add(New OleDbParameter("Days", CType(days, String)))
                cmd.Parameters.Add(New OleDbParameter("Time", CType(CmbTimes.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("Lab", CType(CmbLabs4.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("Lecturer", CType(CmbLecturers4.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("Semester", CType(PickSemCreate.semester, String)))

                Try
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    myConnection.Close()
                    MsgBox("The course was successfully added.", MsgBoxStyle.OkOnly, "Success!")
                Catch ex As Exception
                    MsgBox("Sorry, the course could not be added.", MsgBoxStyle.OkOnly, "Success!")
                    myConnection.Close()
                End Try
            Else
                MsgBox("The course was already added.", MsgBoxStyle.OkOnly, "Already Added")
                myConnection.Close()
            End If
        End If
    End Sub


    Private Sub LblBack_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblBack.LinkClicked
        Hide()
        PickSemCreate.Show()
    End Sub


    Private Sub LblNext_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblNext.LinkClicked
        Hide()
        Dim MyForm As New ViewTimetableCreate
        MyForm.Show()

    End Sub
End Class