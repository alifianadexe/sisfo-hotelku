Public Class ManagementReservation
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader


    Private Sub ManagementReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()

        refreshData()

    End Sub

    Private Sub refreshData()
        Dim sql As String = "SELECT tbl_reservation.id_reservation, check_in, check_out FROM tbl_reservation "
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        adapter.Fill(dt)

        Me.data_grid.DataSource = dt
    End Sub

    Private Sub data_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_grid.CellClick
        If e.RowIndex >= 0 Then
            list_room.Clear()
            Dim id As String = data_grid.Rows(e.RowIndex).Cells(0).Value
            Dim sql As String = "SELECT tbl_room.id_room as id_room , tbl_client.id_client, nama_client, alamat, tanggal_lahir, no_hp, email FROM (tbl_reservation INNER JOIN tbl_room ON tbl_reservation.id_reservation = tbl_room.id_reservation) INNER JOIN tbl_client ON tbl_client.id_client = tbl_reservation.id_client WHERE tbl_reservation.id_reservation = '" + id + "'"
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

    End Sub
End Class