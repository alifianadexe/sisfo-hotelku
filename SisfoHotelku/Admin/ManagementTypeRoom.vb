Public Class ManagementTypeRoom
    Dim id As String = ""
    Dim conn As New SqlClient.SqlConnection()
    Dim rd As SqlClient.SqlDataReader

    Private Sub ManagementTypeRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()

        refreshData()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If Not Me.txt_id.Text = "" Then

        End If
    End Sub

    Private Sub is_enabled(ByVal bool As Boolean)

        Me.txt_nama.Enabled = bool
        Me.txt_desc.Enabled = bool

        Me.btn_browser.Enabled = bool
    End Sub

    Private Sub is_clear()

        Me.txt_id.Clear()
        Me.txt_nama.Clear()
        Me.txt_desc.Clear()

    End Sub

    Private Sub refreshData()
        Dim sql As String = "SELECT * FROM tbl_type_room"
        Dim dt As New DataTable
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)

        adapter.fill(dt)

        Me.txt_tipe.DataSource = dt
        Me.txt_tipe.DisplayMember = "nama"
        Me.txt_tipe.ValueMember = "id_type_room"

    End Sub

    Private Sub browse_Click(sender As Object, e As EventArgs) Handles btn_browser.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

        Me.btn_insert.Text = "Update"
        is_enabled(True)
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Try

            Dim ms As New IO.MemoryStream
            PictureBox1.Image.Save(ms, Imaging.ImageFormat.Png)
            Dim arr_image() As Byte = ms.GetBuffer

            If btn_insert.Text = "Insert" Then
                If cekEmptyTextbox(Me.txt_desc, Me.txt_id, Me.txt_nama) Then
                    Dim sql As String = "INSERT INTO tbl_type_room (id_type_room,nama,picture,deskripsi) VALUES (@v1,@v2,@v3,@v4)"
                    Using cmnd As New SqlClient.SqlCommand(sql, conn)

                        cmnd.Parameters.AddWithValue("@v1", Me.txt_id.Text)
                        cmnd.Parameters.AddWithValue("@v2", Me.txt_nama.Text)
                        cmnd.Parameters.AddWithValue("@v3", arr_image)
                        cmnd.Parameters.AddWithValue("@v4", Me.txt_desc.Text)

                        If MessageBox.Show("Apakah anda ingin memasukkan data tersetbut?", "Apakah?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            cmnd.ExecuteNonQuery()
                            MessageBox.Show("Selamat Data Berhasil Ditambahkan", "Wow", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        End If
                    End Using
                End If
            ElseIf btn_insert.Text = "Update" Then
                If cekEmptyTextbox(Me.txt_desc, Me.txt_id, Me.txt_nama) Then
                    Dim sql As String = "UPDATE tbl_type_room SET nama = @v2, picture = @v3, deskripsi = @v4 WHERE id_type_room = @v1"

                    Using cmnd As New SqlClient.SqlCommand(sql, conn)
                        cmnd.Parameters.AddWithValue("@v1", Me.txt_id.Text)
                        cmnd.Parameters.AddWithValue("@v2", Me.txt_nama.Text)
                        cmnd.Parameters.AddWithValue("@v3", arr_image)
                        cmnd.Parameters.AddWithValue("@v4", Me.txt_desc.Text)

                        If MessageBox.Show("Apakah anda ingin Mengupdate data tersetbut?", "Apakah?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
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

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        is_clear()
        Me.txt_id.Text = generateID("id_type_room", conn)
        is_enabled(True)
    End Sub

    Private Sub txt_tipe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_tipe.SelectedIndexChanged
        Try

            Dim sql As String = "SELECT * FROM tbl_type_room WHERE id_type_room = '" + Me.txt_tipe.SelectedValue + "'"
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)
            rd = cmnd.ExecuteReader
            rd.Read()

            If rd.HasRows Then

                Me.txt_id.Text = rd.Item("id_type_room")
                Me.txt_nama.Text = rd.Item("nama")
                Me.txt_desc.Text = rd.Item("deskripsi")

                Dim arr_image() As Byte = rd.Item("picture")
                Dim ms As New IO.MemoryStream(arr_image)
                PictureBox1.Image = Image.FromStream(ms)

            End If
            rd.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class