Imports System.Data.OleDb
Public Class Lecturers
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Public myConnection As OleDbConnection = New OleDbConnection
    Dim da As OleDbDataAdapter
    Public dr As OleDbDataReader
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource

    Private Sub Lecturers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadForm()
    End Sub

    Private Sub LoadForm()
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "|DataDirectory|\Database\CSCSdb.mdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        TabLecturers.SelectedIndex = 0
        LoadData()
        LoadData2()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Add()
    End Sub

    Private Sub Add()
        myConnection.Open()
        Dim sqlCheck As New OleDbCommand("SELECT count(*) FROM lecturers WHERE LecturerID = '" & TxtLecturerID.Text & "'", myConnection)
        sqlCheck.Parameters.AddWithValue("LecturerID", TxtLecturerID.Text)

        dr = sqlCheck.ExecuteReader()
        If dr.HasRows = True Then
            dr.Read()
            If dr.Item(0) = 0 Then 'lecturer can be added

                Dim str As String
                str = "insert into lecturers ([LecturerID], [Fname], [Lname], [UsedCreditHrs],[TimeAvailable])
               values (?, ?, ?, ?, ?)"
                Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
                cmd.Parameters.Add(New OleDbParameter("LecturerID", CType(TxtLecturerID.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("Fname", CType(TxtFname.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("Lname", CType(TxtLname.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("UsedCreditHrs", CType("0", String)))
                cmd.Parameters.Add(New OleDbParameter("TimeAvailable", CType(CmbTimes.Text, String)))

                Try
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    myConnection.Close()
                    MsgBox("Lecturer was successfully added.", MsgBoxStyle.OkOnly, "Success!")
                Catch ex As Exception
                    myConnection.Close()
                    MsgBox("Sorry the lecturer was not successfully added.", MsgBoxStyle.OkOnly, "Error")
                End Try

            Else
                myConnection.Close()
                MsgBox("The lecturer was already added.", MsgBoxStyle.OkOnly, "Already Added")

            End If
        End If

        TxtLecturerID.ResetText()
        TxtFname.ResetText()
        TxtLname.ResetText()
        CmbTimes.SelectedIndex = -1

        LoadData()
        LoadData2()

    End Sub

    Private Sub LoadData()
        'Reads from database and fills data grid view
        myConnection.Open()
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("Select LecturerID, Fname, Lname, UsedCreditHrs, TimeAvailable from [lecturers]", myConnection)
        da.Fill(ds, "lecturers")
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        Me.DgdLecturers.DataSource = view
        myConnection.Close()


    End Sub

    Private Sub LoadData2()
        'Reads from database and fills data grid view
        myConnection.Open()
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("Select LecturerID, Fname, Lname, UsedCreditHrs, TimeAvailable from [lecturers]", myConnection)
        da.Fill(ds, "lecturers")
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        Me.DgdLecturers2.DataSource = view
        myConnection.Close()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Search()
    End Sub

    Private Sub Search()
        myConnection.Open()

        Dim str As String
        str = "SELECT Fname, Lname, UsedCreditHrs, TimeAvailable FROM lecturers WHERE (LecturerID = '" & TxtLecturerID2.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Dim lecturerFound As Boolean = False

        While dr.Read()
            lecturerFound = True
            TxtFname2.Text = dr("Fname").ToString
            TxtLname2.Text = dr("Lname").ToString
            TxtUsedCredits.Text = dr("UsedCreditHrs").ToString
            CmbTimes2.Text = dr("TimeAvailable").ToString
        End While

        If lecturerFound = False Then
            MsgBox("Sorry, lecturer was not found", MsgBoxStyle.OkOnly, "Not Found")
        End If
        myConnection.Close()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        UpdateLect()
    End Sub

    Private Sub UpdateLect()
        myConnection.Open()
        Dim str As String
        str = "update [lecturers] set [Fname] = '" & TxtFname2.Text & "',[Lname]= '" & TxtLname2.Text & "', [UsedCreditHrs]='" & TxtUsedCredits.Text & "', [TimeAvailable]='" & CmbTimes2.Text & "'Where [LecturerID] = '" & TxtLecturerID2.Text & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            MsgBox("Lecturer has been updated", MsgBoxStyle.OkOnly, "Success!")

        Catch ex As Exception
            myConnection.Close()
            MsgBox("Sorry, lecturer could not be updated", MsgBoxStyle.OkOnly, "Error")
        End Try

        TxtLecturerID2.ResetText()
        TxtFname2.ResetText()
        TxtLname2.ResetText()
        TxtUsedCredits.ResetText()
        CmbTimes2.SelectedIndex = -1

        LoadData2()
        LoadData()
    End Sub
End Class