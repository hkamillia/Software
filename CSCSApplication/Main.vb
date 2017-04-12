Public Class Main
    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Hide()
        PickSemCreate.Show()
    End Sub

    Private Sub BtnLecturers_Click(sender As Object, e As EventArgs) Handles BtnLecturers.Click
        Hide()
        Lecturers.Show()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Hide()
        UpdateTimetable.Show()
    End Sub

    Private Sub BtnLabs_Click(sender As Object, e As EventArgs) Handles BtnLabs.Click
        Hide()
        Labs.Show()
    End Sub

    Private Sub BtnView_Click(sender As Object, e As EventArgs) Handles BtnView.Click
        Hide()
        ViewTimetables.Show()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Hide()
        DeleteTimetable.Show()
    End Sub

    Private Sub LblLogout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblLogout.LinkClicked
        Logout()
    End Sub
    Public Sub Logout()
        Dim Success As Boolean
        Do
            Success = True
            Try
                For Each f As Form In My.Application.OpenForms
                    If f.Name <> "Login" Then f.Close()
                Next f
            Catch ex As Exception
                Success = False
            End Try
        Loop Until Success
        Login.TxtUsername.ResetText()
        Login.TxtPassword.ResetText()
        Login.Show()

    End Sub
End Class