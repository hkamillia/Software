Imports System.Data.OleDb
Public Class ViewTimetableCreate

    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Public myConnection As OleDbConnection = New OleDbConnection
    Dim da As OleDbDataAdapter
    Public dr As OleDbDataReader
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Private Sub ViewTimetableCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadForm()
    End Sub

    Private Sub LoadForm()
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "|DataDirectory|\Database\CSCSdb.mdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        LoadData()
    End Sub

    Private Sub LoadData()
        'Reads from database and fills data grid view
        myConnection.Open()
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("Select CourseCode, CourseTitle, Credits, Days, Time, Lab, Lecturer from [timetable] WHERE Semester='" & PickSemCreate.semester & "'", myConnection)
        da.Fill(ds, "timetable")
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        Me.DgdTimetable.DataSource = view
        myConnection.Close()
    End Sub

    Private Sub LblBack_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblBack.LinkClicked
        Hide()
        Dim MyForm As New CreateTimetable
        MyForm.Show()
    End Sub
End Class