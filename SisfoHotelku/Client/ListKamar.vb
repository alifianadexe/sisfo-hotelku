Public Class ListKamar

    Dim conn As New SqlClient.SqlConnection()
    Dim rd As SqlClient.SqlDataReader

    Private Sub ListKamar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()



        Dim sql As String = "SELECT * FROM tbl_type_room"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        adapter.Fill(dt)

        Me.txt_tipe.DataSource = dt
        Me.txt_tipe.DisplayMember = "nama"
        Me.txt_tipe.ValueMember = "id_type_room"



        refreshData()

    End Sub

    Private Sub refreshData()
        Dim sql As String = "SELECT id_room, room_price_standard as [Standard Price (Rp.)],room_price_premium as [Premium Price (Rp.)] FROM tbl_room INNER JOIN tbl_type_room ON tbl_room.id_type_room = tbl_type_room.id_type_room WHERE tbl_room.id_type_room = '" + Me.txt_tipe.SelectedValue.ToString + "' AND is_free = '1'"

        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable

        adapter.Fill(dt)
        data_grid.DataSource = dt

        data_grid.Columns(1).DefaultCellStyle.Format = "##,##0.00"
        data_grid.Columns(2).DefaultCellStyle.Format = "##,##0.00"

    End Sub

    Private Sub txt_tipe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_tipe.SelectedIndexChanged
        Try
            Dim sql As String = "SELECT * FROM tbl_type_room WHERE id_type_room = '" + Me.txt_tipe.SelectedValue.ToString + "'"
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)
            rd = cmnd.ExecuteReader
            rd.Read()

            If rd.HasRows Then
                Me.lbl_nama.Text = rd.Item("nama")
                Me.lbl_desc.Text = rd.Item("deskripsi")

                Dim array_image() As Byte = rd.Item("picture")
                Dim ms As New IO.MemoryStream(array_image)
                PictureBox1.Image = Image.FromStream(ms)

            End If
            rd.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        refreshData()
    End Sub

End Class