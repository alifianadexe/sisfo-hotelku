Public Class ReservationForm

    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader



    Private Sub ReservationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()



    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles txt_jumlah_kamar.ValueChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class