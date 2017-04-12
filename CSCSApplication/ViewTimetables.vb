Imports System.Data.OleDb
Public Class ViewTimetables
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

    Private Sub ViewTimetables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub LblLogout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblLogout.LinkClicked
        Main.Logout()
    End Sub
End Class