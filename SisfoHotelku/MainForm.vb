Public Class MainForm
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim log As New Login
        log.Show()
    End Sub
End Class