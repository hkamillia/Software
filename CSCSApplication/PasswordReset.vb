Imports System.Data.OleDb

Public Class PasswordReset
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Public myConnection As OleDbConnection = New OleDbConnection
    Dim da As OleDbDataAdapter
    Public dr As OleDbDataReader

    Private Sub PasswordReset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadForm()
    End Sub

    Private Sub LoadForm()
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "|DataDirectory|\Database\CSCSdb.mdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        ResetPassword()
    End Sub

    Private Sub ResetPassword()
        If (TxtPassword.Text = TxtPasswordRetype.Text) Then
            myConnection.Open()
            Dim str As String
            str = "update [users] set [password] = '" & TxtPasswordRetype.Text & "' Where [Fname] = '" & TxtFname.Text & "' AND [Lname]='" & TxtLname.Text & "'"
            Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                myConnection.Close()
                MsgBox("Your password has successfully been reset. Please return to Login page to sign in.", MsgBoxStyle.OkOnly, "Success!")
                Hide()
                Login.Show()

            Catch ex As Exception
                MsgBox("Sorry your password could not reset", MsgBoxStyle.OkOnly, "Error")
            End Try
        Else
            MsgBox("The passwords you entered do not match", MsgBoxStyle.OkOnly, "Password")
            TxtPassword.ResetText()
            TxtPasswordRetype.ResetText()
        End If
    End Sub

    Private Sub Password_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPasswordRetype.KeyPress

        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key

            BtnReset_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub LblLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblLogin.LinkClicked
        Hide()
        Login.Show()
    End Sub
End Class