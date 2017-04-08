Public Class Main
    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Hide()
        PickSemCreate.Show()
    End Sub

    Private Sub BtnLecturers_Click(sender As Object, e As EventArgs) Handles BtnLecturers.Click
        Hide()
        Lecturers.Show()
    End Sub
End Class