Imports System.Data.OleDb

Public Class Labs

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
        TabLabs.SelectedIndex = 0
        LoadData()
        LoadData2()
        LoadData3()
        LoadData4()
    End Sub


    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Add()
    End Sub

    Private Sub Add()
        myConnection.Open()
        Dim sqlCheck As New OleDbCommand("SELECT count(*) FROM labs WHERE LabID = '" & TxtLabID.Text & "'", myConnection)
        sqlCheck.Parameters.AddWithValue("LabID", TxtLabID.Text)

        dr = sqlCheck.ExecuteReader()
        If dr.HasRows = True Then
            dr.Read()
            If dr.Item(0) = 0 Then 'lecturer can be added

                Dim str As String
                str = "insert into labs ([LabID], [LabName], [SeatingCapacity])
               values (?, ?, ?)"
                Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
                cmd.Parameters.Add(New OleDbParameter("LabID", CType(TxtLabID.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("LabName", CType(TxtName.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("SeatingCapacity", CType(TxtSeating.Text, String)))

                Try
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    myConnection.Close()
                    MsgBox("Lab was successfully added.", MsgBoxStyle.OkOnly, "Success!")
                Catch ex As Exception
                    myConnection.Close()
                    MsgBox("Sorry the lab was not successfully added.", MsgBoxStyle.OkOnly, "Error")
                End Try

            Else
                myConnection.Close()
                MsgBox("The lecturer was already added.", MsgBoxStyle.OkOnly, "Already Added")

            End If
        End If

        TxtLabID.ResetText()
        TxtName.ResetText()
        TxtSeating.ResetText()


        LoadData()
        LoadData2()
        LoadData3()
        LoadData4()

    End Sub

    Private Sub LabID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtLabID.KeyPress

        If Char.IsLower(e.KeyChar) Then

            'Convert to uppercase, and put at the caret position in the TextBox.
            TxtLabID.SelectedText = Char.ToUpper(e.KeyChar)

            e.Handled = True
        End If
    End Sub

    Private Sub Seating_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSeating.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

    Private Sub LoadData()
        'Reads from database and fills data grid view
        myConnection.Open()
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("Select LabID, LabName, SeatingCapacity from [labs]", myConnection)
        da.Fill(ds, "labs")
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        Me.DgdLabs.DataSource = view
        myConnection.Close()
    End Sub

    Private Sub LoadData2()
        'Reads from database and fills data grid view
        myConnection.Open()
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("Select LabID, LabName, SeatingCapacity from [labs]", myConnection)
        da.Fill(ds, "labs")
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        Me.DgdLabs2.DataSource = view
        myConnection.Close()
    End Sub

    Private Sub LoadData3()
        'Reads from database and fills data grid view
        myConnection.Open()
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("Select LabID, LabName, SeatingCapacity from [labs]", myConnection)
        da.Fill(ds, "labs")
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        Me.DgdLabs3.DataSource = view
        myConnection.Close()
    End Sub

    Private Sub LoadData4()
        'Reads from database and fills data grid view
        myConnection.Open()
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("Select LabID, LabName, SeatingCapacity from [labs]", myConnection)
        da.Fill(ds, "labs")
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        Me.DgdLabs4.DataSource = view
        myConnection.Close()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Search()
    End Sub

    Private Sub Search()
        myConnection.Open()

        Dim str As String
        str = "SELECT LabName, SeatingCapacity FROM labs WHERE (LabID = '" & TxtLabID2.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Dim labFound As Boolean = False

        While dr.Read()
            labFound = True
            TxtName2.Text = dr("LabName").ToString
            TxtSeating2.Text = dr("SeatingCapacity").ToString
        End While

        If labFound = False Then
            MsgBox("Sorry, lab was not found", MsgBoxStyle.OkOnly, "Not Found")
        End If
        myConnection.Close()
    End Sub

    Private Sub LabID2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtLabID2.KeyPress

        If Char.IsLower(e.KeyChar) Then

            'Convert to uppercase, and put at the caret position in the TextBox.
            TxtLabID2.SelectedText = Char.ToUpper(e.KeyChar)

            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the BtnSearch_Click Event
            BtnSearch_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub Seating2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSeating2.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        UpdateLabs()
    End Sub

    Private Sub UpdateLabs()
        myConnection.Open()
        Dim str As String
        str = "update [labs] set [LabName] = '" & TxtName2.Text & "',[SeatingCapacity]= '" & TxtSeating2.Text & "' Where [LabID] = '" & TxtLabID2.Text & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            MsgBox("Lab has been updated", MsgBoxStyle.OkOnly, "Success!")

        Catch ex As Exception
            myConnection.Close()
            MsgBox("Sorry, lab could not be updated", MsgBoxStyle.OkOnly, "Error")
        End Try

        TxtLabID2.ResetText()
        TxtName2.ResetText()
        TxtSeating2.ResetText()


        LoadData2()
        LoadData3()
        LoadData4()
        LoadData()
    End Sub

    Private Sub LblHome1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblHome1.LinkClicked
        Hide()
        Main.Show()
    End Sub

    Private Sub LblHome2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblHome2.LinkClicked
        Hide()
        Main.Show()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Delete()
    End Sub

    Private Sub Delete()
        If DgdLabs4.Rows.Count > 0 Then
            If DgdLabs4.SelectedRows.Count > 0 Then
                Dim LabID As String = DgdLabs4.SelectedRows(0).Cells("LabID").Value

                Dim okToDelete As MsgBoxResult = MsgBox("Are you sure you want to delete the current record?", MsgBoxStyle.YesNo)
                If okToDelete = MsgBoxResult.Yes Then
                    myConnection.Open()
                    Dim str As String
                    str = "Delete from labs Where [LabID]= '" & LabID & "'"
                    Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
                    Try
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        myConnection.Close()
                        MsgBox("The lab was successfully deleted.", MsgBoxStyle.OkOnly, "Success!")
                        LoadData4()
                        LoadData3()
                        LoadData2()
                        LoadData()
                    Catch ex As Exception
                        MsgBox("Sorry the lab was not successfully deleted.", MsgBoxStyle.OkOnly, "Error")
                        myConnection.Close()
                    End Try
                ElseIf okToDelete = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub LblHome4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblHome4.LinkClicked
        Hide()
        Main.Show()
    End Sub

    Private Sub LblHome3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblHome3.LinkClicked
        Hide()
        Main.Show()
    End Sub

    Private Sub LblLogout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblLogout.LinkClicked
        Main.Logout()
    End Sub
End Class

