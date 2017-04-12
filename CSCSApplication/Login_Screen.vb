Imports System.Data.OleDb
Public Class Login

    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection



    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Login()
    End Sub

    Private Sub Login()
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        dataFile = "|DataDirectory|\Database\CSCSdb.mdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()

        'the query:
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [users] WHERE [username] = '" & TxtUsername.Text & "' AND [password] = '" & TxtPassword.Text & "'", myConnection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        ' the following variable holds true if user is found, and false if user is not found
        Dim userFound As Boolean = False
        ' the following variables will hold the user first and last name if found as well as the current timestamp.
        Dim Fname As String = ""
        Dim Lname As String = ""
        Dim regDate As DateTime = DateTime.Now
        Dim strDate As String = regDate.ToString("yyyy-MM-dd HH:mm:ss")

        'if user is found:
        While dr.Read
            userFound = True
            Fname = dr("Fname").ToString
            Lname = dr("Lname").ToString
            Dim str As String
            str = "update [users] set [LastLogin] = '" & strDate & "'Where [username] = '" & TxtUsername.Text & "'"
            Dim newcmd As OleDbCommand = New OleDbCommand(str, myConnection)
            newcmd.ExecuteNonQuery()
            newcmd.Dispose()
        End While

        If userFound = True Then
            Hide()
            Main.Show()
            Main.LblAdmin.Text = "Welcome" & " " & Fname & " " & Lname

        Else
            MsgBox("Sorry, username or password not found", MsgBoxStyle.OkOnly, "Invalid Login")
            TxtPassword.ResetText()
        End If

        myConnection.Close()
    End Sub

    Private Sub Username_Leave(sender As Object, e As EventArgs) Handles TxtUsername.Leave
        If TxtUsername.Text = "" Then
            TxtUsername.Text = "Username (ID number)"
            TxtUsername.ForeColor = Color.Silver

        End If
    End Sub

    Private Sub Username_Enter(sender As Object, e As EventArgs) Handles TxtUsername.Enter
        TxtUsername.Text = ""
        TxtUsername.ForeColor = Color.Black

    End Sub
    Private Sub Password_Leave(sender As Object, e As EventArgs) Handles TxtPassword.Leave
        If TxtPassword.Text = "" Then
            TxtPassword.Text = "Password"
            TxtPassword.PasswordChar = ControlChars.NullChar
            TxtPassword.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub Password_Enter(sender As Object, e As EventArgs) Handles TxtPassword.Enter
        TxtPassword.Text = ""
        TxtPassword.ForeColor = Color.Black
        TxtPassword.PasswordChar = "•"c
    End Sub


    Private Sub Password_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPassword.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            'Runs the BtnLogin_Click Event
            BtnLogin_Click(Me, EventArgs.Empty)
        End If
    End Sub



    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim response As MsgBoxResult
        response = MsgBox("Are you sure that you want to exit this application?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
        If response = MsgBoxResult.Yes Then
            Application.Exit()
        ElseIf response = MsgBoxResult.No Then
            e.Cancel = True
            Exit Sub
        End If

    End Sub
End Class

