Imports System.Data.OleDb

Public Class Users
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Public myConnection As OleDbConnection = New OleDbConnection
    Dim da As OleDbDataAdapter
    Public dr As OleDbDataReader


    Private Sub Users_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadForm()
    End Sub

    Private Sub LoadForm()
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "|DataDirectory|\Database\CSCSdb.mdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        TabUsers.SelectedIndex = 0
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Submit()
    End Sub

    Private Sub Submit()
        If (TxtPassword.Text = TxtPasswordRetype.Text) Then
            myConnection.Open()
            Dim sqlCheck As New OleDbCommand("SELECT count(*) FROM users WHERE Fname = '" & TxtFname.Text & "' AND Lname= '" & TxtLname.Text & "'", myConnection)
            sqlCheck.Parameters.AddWithValue("Fname", TxtFname.Text)
            sqlCheck.Parameters.AddWithValue("Lname", TxtLname.Text)

            dr = sqlCheck.ExecuteReader()
            If dr.HasRows = True Then
                dr.Read()
                If dr.Item(0) = 0 Then 'username is available

                    Dim str As String
                    str = "insert into users ([username], [password], [Fname], [Lname])
               values (?, ?, ?, ?)"
                    Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
                    cmd.Parameters.Add(New OleDbParameter("username", CType("admin", String)))
                    cmd.Parameters.Add(New OleDbParameter("password", CType(TxtPasswordRetype.Text, String)))
                    cmd.Parameters.Add(New OleDbParameter("Fname", CType(TxtFname.Text, String)))
                    cmd.Parameters.Add(New OleDbParameter("Lname", CType(TxtLname.Text, String)))

                    Try
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        myConnection.Close()
                        MsgBox("Your account was successsfully activated.Please note your Username is 'admin'. Please return to Login page to sign in.", MsgBoxStyle.OkOnly, "Success!")
                        Hide()
                        Login.Show()

                    Catch ex As Exception
                        MsgBox("Sorry your account could not be activated", MsgBoxStyle.OkOnly, "Error")
                    End Try

                Else
                    MsgBox("Your account is already activated. Please return to Login page to sign in.", MsgBoxStyle.OkOnly, "Account Already Activated")
                    Hide()
                    Login.Show()
                End If
            End If

        Else
            MsgBox("The passwords you entered do not match", MsgBoxStyle.OkOnly, "Password")
            TxtPassword.ResetText()
            TxtPasswordRetype.ResetText()
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Delete()
    End Sub

    Private Sub Delete()
        Dim okToDelete As MsgBoxResult = MsgBox("Are you sure you want to remove your account?", MsgBoxStyle.YesNo)
        If okToDelete = MsgBoxResult.Yes Then
            myConnection.Open()
            Dim str As String
            str = "Delete from users Where [Fname]= '" & TxtFname2.Text & "' AND [Lname] = '" & TxtLname2.Text & "' AND [Password] = '" & TxtPassword2.Text & "'"
            Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                myConnection.Close()
                MsgBox("The user was successfully deleted. Thank you for using the application!", MsgBoxStyle.OkOnly, "Success!")
            Catch ex As Exception
                MsgBox("Sorry the user could not be found and deleted.", MsgBoxStyle.OkOnly, "Error")
                myConnection.Close()
            End Try
        ElseIf okToDelete = MsgBoxResult.No Then
        End If

        TxtFname2.ResetText()
        TxtLname2.ResetText()
        TxtPassword2.ResetText()

    End Sub
    Private Sub Password_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPasswordRetype.KeyPress

        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key

            BtnSubmit_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub LblLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblLogin.LinkClicked
        Hide()
        Login.Show()
    End Sub
End Class