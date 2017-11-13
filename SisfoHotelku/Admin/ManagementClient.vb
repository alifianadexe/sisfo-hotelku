Public Class ManagementClient
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader
    Private Sub ManagementClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()

        refreshData()
    End Sub

    Private Sub refreshData()
        Dim sql As String = "SELECT * FROM tbl_client"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable

        adapter.Fill(dt)

        data_grid.DataSource = dt

    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Try
            Dim sql As String = "SELECT * FROM tbl_client WHERE nama_client LIKE '%" + Me.txt_search.Text + "%'"
            Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
            Dim dt As New DataTable

            adapter.Fill(dt)
            data_grid.DataSource = dt

        Catch ex As Exception

        End Try
    End Sub


    Private Sub data_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_grid.CellClick
        If e.RowIndex >= 0 Then
            Me.txt_id.Text = data_grid.Rows(e.RowIndex).Cells(0).Value

            adapter_room(Me.txt_id.Text)

            Dim sql As String = "SELECT * FROM tbl_client WHERE id_client = '" + Me.txt_id.Text + "'"
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)

            rd = cmnd.ExecuteReader
            rd.Read()

            If rd.HasRows Then
                Me.txt_alamat.Text = rd.Item("alamat")
                Me.txt_email.Text = rd.Item("email")
                Me.txt_nama.Text = rd.Item("nama_client")
                Me.txt_no_hp.Text = rd.Item("no_hp")
                Me.txt_tanggal_lahir.Value = Date.Parse(rd.Item("tanggal_lahir"))

            End If
            rd.Close()



        End If
    End Sub

    Private Sub adapter_room(ByVal id As String)
        list_room.Clear()
        Dim Sql As String = "SELECT tbl_room.id_room as id_room FROM (tbl_room INNER JOIN tbl_reservation ON tbl_reservation.id_reservation = tbl_room.id_reservation ) INNER JOIN tbl_client ON tbl_client.id_client = tbl_reservation.id_client WHERE tbl_client.id_client = '" + Me.txt_id.Text + "'"
        Dim cmnd As New SqlClient.SqlCommand(sql, conn)
        rd = cmnd.ExecuteReader

        While rd.Read()
            If rd.HasRows Then
                list_room.Items.Add(rd.Item("id_room"))
            End If
        End While

        rd.Close()
    End Sub
End Class