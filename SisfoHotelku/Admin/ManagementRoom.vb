Public Class ManagementRoom
    Dim conn As New SqlClient.SqlConnection()
    Dim rd As SqlClient.SqlDataReader

    Private Sub ManagementRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()

        Dim sql As String = "SELECT * FROM tbl_type_room"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        adapter.Fill(dt)

        Me.txt_room_type.DataSource = dt
        Me.txt_room_type.DisplayMember = "nama"
        Me.txt_room_type.ValueMember = "id_type_room"

        refreshData()
    End Sub

    Private Sub refreshData()
        Dim sql As String = "SELECT id_room, tbl_type_room.nama as type_room , room_price_standard, room_price_premium FROM tbl_room INNER JOIN tbl_type_room ON tbl_room.id_type_room = tbl_type_room.id_type_room"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable

        adapter.Fill(dt)
        data_grid.DataSource = dt


    End Sub

    Private Sub is_enabled(ByVal bool As Boolean)

        Me.txt_free.Enabled = bool
        Me.txt_free_2.Enabled = bool
        Me.txt_room_type.Enabled = bool
        Me.txt_standard.Enabled = bool
        Me.txt_vip.Enabled = bool

    End Sub

    Private Sub is_clear()
        Me.txt_id.Clear()
        Me.txt_standard.Clear()
        Me.txt_vip.Clear()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        is_clear()
        Me.txt_id.Text = generateID("id_room", conn)
        is_enabled(True)
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Try
            If Not Me.txt_id.Text = "" Then
                Dim sql As String = "DELETE FROM tbl_room WHERE id_room = '" + Me.txt_id.Text + "'"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                If MessageBox.Show("Apakah anda ingin menghapus data tersetbut?", "Apakah?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    cmnd.ExecuteNonQuery()
                    MessageBox.Show("Selamat Data Berhasil Dihapus", "Wow", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Wow", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Try
            If btn_insert.Text = "Insert" Then
                If cekEmptyTextbox(Me.txt_room_type, Me.txt_standard, Me.txt_vip) Then
                    Dim free As Integer = 0
                    Dim sql As String = "INSERT INTO tbl_room (id_room,id_type_room,room_price_standard,room_price_premium,is_free) VALUES (@v1,@v2,@v3,@v4,@v5)"
                    Using cmnd As New SqlClient.SqlCommand(sql, conn)
                        cmnd.Parameters.AddWithValue("@v1", Me.txt_id.Text)
                        cmnd.Parameters.AddWithValue("@v2", Me.txt_room_type.SelectedValue)
                        cmnd.Parameters.AddWithValue("@v3", Me.txt_standard.Text)
                        cmnd.Parameters.AddWithValue("@v4", Me.txt_vip.Text)

                        If Me.txt_free.Checked Then
                            free = 1
                        Else
                            free = 0
                        End If

                        cmnd.Parameters.AddWithValue("@v5", free)
                        If MessageBox.Show("Apakah anda ingin memasukkan data tersetbut?", "Apakah?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            cmnd.ExecuteNonQuery()
                            MessageBox.Show("Selamat Data Berhasil Ditambahkan", "Wow", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        End If
                    End Using
                End If
            ElseIf btn_insert.Text = "Update" Then
                If cekEmptyTextbox(Me.txt_room_type, Me.txt_standard, Me.txt_vip) Then
                    Dim free As Integer = 0
                    Dim sql As String = "UPDATE tbl_room SET id_type_room = @v2, room_price_standard = @v3, room_price_premium = @v4 WHERE id_room = @v1"
                    Using cmnd As New SqlClient.SqlCommand(sql, conn)
                        cmnd.Parameters.AddWithValue("@v1", Me.txt_id.Text)
                        cmnd.Parameters.AddWithValue("@v2", Me.txt_room_type.SelectedValue)
                        cmnd.Parameters.AddWithValue("@v3", Me.txt_standard.Text)
                        cmnd.Parameters.AddWithValue("@v4", Me.txt_vip.Text)

                        If Me.txt_free.Checked Then
                            free = 1
                        Else
                            free = 0
                        End If

                        cmnd.Parameters.AddWithValue("@v5", free)
                        If MessageBox.Show("Apakah anda ingin mengupdate data tersetbut?", "Apakah?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            cmnd.ExecuteNonQuery()
                            MessageBox.Show("Selamat Data Berhasil Diupdate", "Wow", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        End If
                    End Using

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try

        Me.btn_insert.Text = "Insert"

        is_enabled(False)
        is_clear()
        refreshData()

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        is_enabled(True)
        Me.btn_insert.Text = "Update"
    End Sub

    Private Sub data_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_grid.CellClick
        If e.RowIndex >= 0 Then
            Me.txt_id.Text = data_grid.Rows(e.RowIndex).Cells(0).Value.ToString
            Dim sql As String = "SELECT tbl_type_room.nama as nama,room_price_standard,room_price_premium,is_free FROM tbl_room INNER JOIN tbl_type_room ON tbl_room.id_type_room = tbl_type_room.id_type_room WHERE id_room = '" + Me.txt_id.Text + "'"
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)
            rd = cmnd.ExecuteReader
            rd.Read()

            If rd.HasRows Then

                Me.txt_room_type.Text = rd.Item("nama")
                Me.txt_standard.Text = rd.Item("room_price_standard")
                Me.txt_vip.Text = rd.Item("room_price_premium")

                If rd.Item("is_free") = 1 Then
                    Me.txt_free.Checked = True
                Else
                    Me.txt_free_2.Checked = True
                End If

            End If
            rd.Close()
        End If
    End Sub

    Private Sub txt_standard_TextChanged(sender As Object, e As EventArgs) Handles txt_standard.TextChanged
        Try
            Me.lbl_standard.Text = "Rp." + Format(Integer.Parse(Me.txt_standard.Text), "##,##0.00")

        Catch ex As Exception
        End Try
    End Sub

    Private Sub txt_vip_TextChanged(sender As Object, e As EventArgs) Handles txt_vip.TextChanged
        Try
            Me.lbl_vip.Text = "Rp." + Format(Integer.Parse(Me.txt_vip.Text), "##,##0.00")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ManagementTypeRoom.Show()
    End Sub
End Class