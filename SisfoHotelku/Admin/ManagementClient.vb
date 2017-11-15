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
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub btn_ad_Click(sender As Object, e As EventArgs) Handles btn_ad.Click
        is_clear()
        Me.txt_id.Text = generateID("id_client", conn)
        is_enabled(True)
    End Sub

    Private Sub btn_ins_Click(sender As Object, e As EventArgs) Handles btn_ins.Click
        Try
            If cekEmptyTextbox(Me.txt_alamat, Me.txt_email, Me.txt_nama, Me.txt_no_hp) Then
                If Me.btn_ins.Text = "Insert" Then
                    Dim sql As String = "INSERT INTO tbl_client (id_client, nama_client , alamat, tanggal_lahir, no_hp, email) VALUES (@v1,@v2,@v3,@v4,@v5,@v6)"
                    Using cmnd As New SqlClient.SqlCommand(sql, conn)
                        cmnd.Parameters.AddWithValue("@v1", Me.txt_id.Text)
                        cmnd.Parameters.AddWithValue("@v2", Me.txt_nama.Text)
                        cmnd.Parameters.AddWithValue("@v3", Me.txt_alamat.Text)
                        cmnd.Parameters.AddWithValue("@v4", Me.txt_tanggal_lahir.Value)
                        cmnd.Parameters.AddWithValue("@v5", Me.txt_no_hp.Text)
                        cmnd.Parameters.AddWithValue("@v6", Me.txt_email.Text)

                        If MessageBox.Show("Apakah Anda memasukkan data?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            cmnd.ExecuteNonQuery()
                            MessageBox.Show("Selamat, data berhasil dimasukkan ", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        End If

                    End Using
                ElseIf Me.btn_ins.Text = "Update" Then
                    Dim sql As String = "UPDATE tbl_client SET nama_client = @v2, alamat = @v3, tanggal_lahir = @v4, no_hp = @v5, email = @v6 WHERE id_client = @v1"
                    Using cmnd As New SqlClient.SqlCommand(sql, conn)
                        cmnd.Parameters.AddWithValue("@v1", Me.txt_id.Text)
                        cmnd.Parameters.AddWithValue("@v2", Me.txt_nama.Text)
                        cmnd.Parameters.AddWithValue("@v3", Me.txt_alamat.Text)
                        cmnd.Parameters.AddWithValue("@v4", Me.txt_tanggal_lahir.Value)
                        cmnd.Parameters.AddWithValue("@v5", Me.txt_no_hp.Text)
                        cmnd.Parameters.AddWithValue("@v6", Me.txt_email.Text)

                        If MessageBox.Show("Update Data ini?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            cmnd.ExecuteNonQuery()
                            MessageBox.Show("Selamat, data berhasil diupdate ", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        End If

                    End Using
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        is_clear()
        is_enabled(False)
        Me.btn_ins.Text = "Insert"

        refreshData()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        is_enabled(True)
        Me.btn_ins.Text = "Insert"
    End Sub

    Private Sub btn_dele_Click(sender As Object, e As EventArgs) Handles btn_dele.Click
        If Not Me.txt_id.Text = "" Then
            Dim sql As String = "DELETE FROM tbl_client WHERE id_client = '" + Me.txt_id.Text + "'"
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)
            If MessageBox.Show("Hapus data ini?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                cmnd.ExecuteNonQuery()
            End If
        End If

    End Sub

    Private Sub is_clear()

        Me.txt_alamat.Clear()
        Me.txt_email.Clear()
        Me.txt_nama.Clear()
        Me.txt_no_hp.Clear()

    End Sub

    Private Sub is_enabled(ByVal bool As Boolean)

        Me.txt_alamat.Enabled = bool
        Me.txt_email.Enabled = bool
        Me.txt_nama.Enabled = bool
        Me.txt_no_hp.Enabled = bool

    End Sub
End Class