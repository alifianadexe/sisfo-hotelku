Public Class MainForm
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim log As New Login
        log.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim lk As New ListKamar
        lk.Show()
    End Sub
End Class