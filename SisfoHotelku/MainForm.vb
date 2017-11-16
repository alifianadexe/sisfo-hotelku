Public Class MainForm
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader

    Private Sub login_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim log As New Login
        log.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim lk As New ListKamar
        lk.Show()
        Me.Hide()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()

        checkData()
    End Sub

    Private Sub checkData()
        'Dim max As Integer = 0
        'Dim sql As String = "SELECT COUNT(id_reservation) as jumlah, id_reservation, check_out FROM tbl_reservation GROUP BY is_check_out"
        ' Dim cmnd As New SqlClient.SqlCommand(sql, conn)
        '  rd = cmnd.ExecuteReader

        'If rd.Read Then
        '    max = rd.Item("jumlah")
        ' End If
        ' rd.Close()

        '        Dim id_reservation(max) As String
        '        Dim check_out(max) As String
        '        Dim i As Integer = 0

        '        rd = cmnd.ExecuteReader

        '        While rd.Read
        '            id_reservation(i) = rd.Item("id_reservation")
        '            check_out(i) = rd.Item("check_out")
        '            i += 1
        '        End While

        '       rd.Close()


    End Sub

    Private Sub update_Data()

    End Sub

End Class