Public Class Splash_Screen
    Private Sub Splash_Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar.Visible = False

        Dim a, b As Decimal
        For a = 0 To 80
            b = a / 80
            Me.Opacity = b
            Me.Refresh()

        Next

        Timer1.Enabled = True
        Timer1.Interval = 5000

        Timer2.Enabled = True
        Timer2.Interval = 2000




    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Hide()
        Main.Show()
        Timer1.Enabled = False



    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ProgressBar.Visible = True
        Timer2.Enabled = False

        ProgressBar.Minimum = 0
        ProgressBar.Maximum = 300
        ProgressBar.Value = 299
        Me.Controls.Add(ProgressBar)



    End Sub
End Class