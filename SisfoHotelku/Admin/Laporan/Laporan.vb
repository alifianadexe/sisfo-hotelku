Public Class Laporan

    Private Sub Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LaporanKeuangan.Show()

    End Sub

    Private Sub Laporan_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        NavigationAdmin.Show()
    End Sub
End Class