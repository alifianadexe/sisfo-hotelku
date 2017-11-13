Public Class ReservationForm

    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader

    Dim id_reservation As String = ""
    Dim id_invoice As String = ""


    Dim total_harga As Integer = 0

    Private Sub ReservationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()


        Me.txt_id.Text = generateID("id_client", conn)
        id_reservation = generateID("id_reservation", conn)
        id_invoice = generateID("id_invoice", conn)
    End Sub

    Private Sub btn_pesan_Click(sender As Object, e As EventArgs) Handles btn_pesan.Click
        'Try
        If cekEmptyTextbox(Me.txt_alamat, Me.txt_id, Me.txt_jenis_kamar, Me.txt_jumlah_kamar, Me.txt_nama, Me.txt_no_hp) Then
                Dim sql As String = "INSERT INTO tbl_client (id_client, nama_client , alamat, tanggal_lahir, no_hp, email) VALUES (@v1,@v2,@v3,@v4,@v5,@v6)"
                Using cmnd As New SqlClient.SqlCommand(sql, conn)
                    cmnd.Parameters.AddWithValue("@v1", Me.txt_id.Text)
                    cmnd.Parameters.AddWithValue("@v2", Me.txt_nama.Text)
                    cmnd.Parameters.AddWithValue("@v3", Me.txt_alamat.Text)
                    cmnd.Parameters.AddWithValue("@v4", Me.txt_tanggal.Value)
                    cmnd.Parameters.AddWithValue("@v5", Me.txt_no_hp.Text)
                    cmnd.Parameters.AddWithValue("@v6", Me.txt_email.Text)


                    If MessageBox.Show("Apakah Anda ingin memesan Kamar dengan Tipe Ini?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        ins_reservation()
                        cmnd.ExecuteNonQuery()
                        MessageBox.Show("Selamat, Anda berhasil memesan kamar ini ", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    End If

                End Using
            End If
        ' Catch ex As Exception
        'MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ' End Try
    End Sub

    Private Sub ins_reservation()
        Dim sql As String = "INSERT INTO tbl_reservation (id_reservation,id_client,check_in,check_out) VALUES (@v1,@v2,@v3,@v4)"
        Using cmnd As New SqlClient.SqlCommand(sql, conn)

            cmnd.Parameters.AddWithValue("@v1", id_reservation)
            cmnd.Parameters.AddWithValue("@v2", Me.txt_id.Text)
            cmnd.Parameters.AddWithValue("@v3", Date.Now)
            cmnd.Parameters.AddWithValue("@v4", Date.Parse(DateTime.Now.AddDays(Me.txt_hari.Value)))


            up_room_res(id_reservation)


            cmnd.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub up_room_res(ByVal id As String)


        For i As Integer = 0 To Me.txt_jumlah_kamar.Value

            Dim sql_select As String = "SELECT * FROM tbl_room WHERE is_free = 1 AND id_type_room = '" + Me.txt_jenis_kamar.Tag + "'"

            Dim harga As Integer = 0
            Dim id_room As String = ""
            Dim cmnd As New SqlClient.SqlCommand(sql_select, conn)

            rd = cmnd.ExecuteReader
            rd.Read()

            If rd.HasRows Then
                id_room = rd.Item("id_room")
                If Me.txt_price.Checked Then
                    harga = rd.Item("room_price_standard")
                Else
                    harga = rd.Item("room_price_premium")
                End If
                total_harga += harga

            End If

            rd.Close()


            Dim sql_update As String = "UPDATE tbl_room SET id_reservation = @v1 , is_free = 0 WHERE id_room = @v2"
            Using cmnd_update As New SqlClient.SqlCommand(sql_update, conn)
                cmnd_update.Parameters.AddWithValue("@v1", id)
                cmnd_update.Parameters.AddWithValue("@v2", id_room)


                cmnd_update.ExecuteNonQuery()
            End Using

            insert_bill(id_room)
        Next
    End Sub

    Private Sub insert_invoice(ByVal id_reservation As String)

        Dim status As String = ""

        Dim sql As String = "INSERT INTO tbl_invoice (id_invoice , id_client, id_reservation, invoice_status, invoice_date, invoice_day, invoice_desc, total_pembayaran) VALUES (@v1,@v2,@v3,@v4,@v5,@v6,@v7,@v8)"
        Using cmnd As New SqlClient.SqlCommand(sql, conn)
            cmnd.Parameters.AddWithValue("@v1", id_invoice)
            cmnd.Parameters.AddWithValue("@v2", Me.txt_id.Text)
            cmnd.Parameters.AddWithValue("@v3", id_reservation)

            If Me.txt_price.Checked Then
                status = "Standard"
            Else
                status = "Premium"
            End If

            cmnd.Parameters.AddWithValue("@v4", status)
            cmnd.Parameters.AddWithValue("@v5", Date.Now)
            cmnd.Parameters.AddWithValue("@v6", Me.txt_hari.Value)
            cmnd.Parameters.AddWithValue("@v7", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.")
            cmnd.Parameters.AddWithValue("@v8", total_harga)

            cmnd.ExecuteNonQuery()
        End Using

    End Sub


    Private Sub insert_bill(ByVal id_room As String)
        Dim sql As String = "INSERT INTO tbl_tagihan (id_tagihan, id_invoice, biaya, id_room) VALUES (@v1,@v2,@v3,@v4)"
        Using cmnd As New SqlClient.SqlCommand(sql, conn)
            cmnd.Parameters.AddWithValue("@v1", generateID("id_tagihan", conn))
            cmnd.Parameters.AddWithValue("@v2", id_invoice)
            cmnd.Parameters.AddWithValue("@v3", total_harga)
            cmnd.Parameters.AddWithValue("@v4", id_room)

            cmnd.ExecuteNonQuery()

        End Using
    End Sub
End Class