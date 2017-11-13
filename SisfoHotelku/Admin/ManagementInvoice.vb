Public Class ManagementInvoice
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader

    Private Sub ManagementInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()

        refreshData()

    End Sub

    Private Sub refreshData()
        Dim sql As String = "SELECT id_invoice, invoice_status as [Status], invoice_date as [Date], invoice_day as [Jumlah Hari] , total_pembayaran FROM tbl_invoice"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        adapter.Fill(dt)

        data_grid.DataSource = dt
        data_grid.Columns(4).DefaultCellStyle.Format = "##,##0.00"

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Try
            Dim sql As String = "SELECT id_invoice, invoice_status as [Status], invoice_date as [Date], invoice_day as [Jumlah Hari] , total_pembayaran FROM tbl_invoice WHERE id_invoice LIKE '% " + Me.txt_search.Text + "%' "
            Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
            Dim dt As New DataTable

            adapter.Fill(dt)

            data_grid.DataSource = dt
            data_grid.Columns(4).DefaultCellStyle.Format = "##,##0.00"

        Catch ex As Exception

        End Try
    End Sub

    Private Sub data_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_grid.CellClick
        If e.RowIndex >= 0 Then
            Dim id As String = data_grid.Rows(e.RowIndex).Cells(0).Value
            Dim sql As String = "SELECT id_reservation, nama_client, invoice_desc, total_pembayaran FROM tbl_invoice INNER JOIN tbl_client ON tbl_client.id_client = tbl_invoice.id_client WHERE tbl_invoice.id_invoice = '" + id + "' "
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)
            rd = cmnd.ExecuteReader
            rd.Read()

            If rd.HasRows Then

                Me.lbl_nama.Text = rd.Item("nama_client")
                Me.lbl_id.Text = rd.Item("id_reservation")
                Me.lbl_desc.Text = rd.Item("invoice_desc")
                Me.lbl_total.Text = "Rp." + Format(rd.Item("total_pembayaran"), "##,##0.00")


            End If
            rd.Close()

            adapter_room(Me.lbl_id.Text)
        End If
    End Sub

    Private Sub adapter_room(ByVal id As String)
        list_view.Clear()
        Dim sql As String = "SELECT id_room FROM tbl_room INNER JOIN tbl_reservation ON tbl_reservation.id_reservation = tbl_room.id_reservation WHERE tbl_reservation.id_reservation = '" + Me.lbl_id.Text + "' AND tbl_room.is_free = 0"
        Dim cmnd As New SqlClient.SqlCommand(sql, conn)
        rd = cmnd.ExecuteReader()

        While rd.Read()
            If rd.HasRows Then
                list_view.Items.Add(rd.Item("id_room"))
            End If
        End While
        rd.Close()
    End Sub
End Class