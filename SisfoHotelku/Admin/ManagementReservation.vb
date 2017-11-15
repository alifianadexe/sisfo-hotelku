Public Class ManagementReservation
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader

    Dim id_invoice As String = ""
    Dim id_reservation As String = ""
    Private Sub ManagementReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()

        refreshData()

    End Sub

    Private Sub refreshData()
        Dim sql As String = "SELECT tbl_reservation.id_reservation, check_in, check_out FROM tbl_reservation WHERE is_check_out = 0"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        adapter.Fill(dt)

        Me.data_grid.DataSource = dt
    End Sub

    Private Sub data_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_grid.CellClick
        If e.RowIndex >= 0 Then
            list_room.Clear()
            Me.id_reservation = data_grid.Rows(e.RowIndex).Cells(0).Value
            Dim sql As String = "SELECT tbl_room.id_room as id_room , tbl_client.id_client, nama_client, alamat, tanggal_lahir, no_hp, email FROM (tbl_reservation INNER JOIN tbl_room ON tbl_reservation.id_reservation = tbl_room.id_reservation) INNER JOIN tbl_client ON tbl_client.id_client = tbl_reservation.id_client WHERE tbl_reservation.id_reservation = '" + id_reservation + "' AND tbl_room.is_free = 0"
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)
            rd = cmnd.ExecuteReader

            While rd.Read
                If rd.HasRows Then

                    list_room.Items.Add(rd.Item("id_room"))
                    Me.lbl_name.Text = rd.Item("nama_client")
                    Me.lbl_id.Text = rd.Item("id_client")
                    Me.lbl_email.Text = rd.Item("email")
                    Me.lbl_alamat.Text = rd.Item("alamat")
                    Me.lbl_no.Text = rd.Item("no_hp")
                    Me.lbl_date.Text = rd.Item("tanggal_lahir")

                End If
            End While

            rd.Close()
        End If
    End Sub

    Private Sub check_out_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If Not id_reservation = "" Then
                If MessageBox.Show("Check Out this reservation?", "Check Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim sql As String = "SELECT id_room FROM tbl_room INNER JOIN tbl_reservation ON tbl_room.id_reservation = tbl_reservation.id_reservation WHERE tbl_reservation.id_reservation = '" + id_reservation + "'"
                    Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                    rd = cmnd.ExecuteReader

                    Dim max As Integer = list_room.Items.Count


                    Dim id_room(max) As String

                    For i As Integer = 0 To max - 1
                        rd.Read()

                        If rd.HasRows Then
                            id_room(i) = rd.Item("id_room")
                        End If
                        i += 1

                    Next
                    rd.Close()

                    For j As Integer = 0 To UBound(id_room)
                        up_free_room(id_room(j))
                    Next
                    up_check_out(id_reservation)

                End If
            End If
            MessageBox.Show("Reservasi berhasil di Check Out", "Selamat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            refreshData()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub up_free_room(ByVal id As String)
        Dim sql As String = "UPDATE tbl_room SET is_free = 1 WHERE id_room = '" + id + "'"
        Dim cmnd As New SqlClient.SqlCommand(sql, conn)
        cmnd.ExecuteNonQuery()
    End Sub

    Private Sub up_check_out(ByVal id As String)
        Dim sql As String = "UPDATE tbl_reservation SET is_check_out = 1 WHERE id_reservation = '" + id + "'"
        Dim cmnd As New SqlClient.SqlCommand(sql, conn)
        cmnd.ExecuteNonQuery()
    End Sub
End Class