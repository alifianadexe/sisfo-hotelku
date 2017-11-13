Public Class NavigationAdmin
    Dim conn As New SqlClient.SqlConnection()
    Dim rd As SqlClient.SqlDataReader

    Private Sub NavigationAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()

        Dim sql As String = "SELECT * FROM tbl_petugas WHERE id_petugas = '" + Me.Tag + "'"
        Dim cmnd As New SqlClient.SqlCommand(sql, conn)
        rd = cmnd.ExecuteReader
        rd.Read()

        If rd.HasRows Then
            Me.lbl_id.Text = rd.Item("id_petugas")
            Me.lbl_nama.Text = rd.Item("nama_petugas")
            Me.lbl_date.Text = rd.Item("tanggal_lahir")
            Me.lbl_no_hp.Text = rd.Item("no_hp")
            Me.lbl_status.Text = rd.Item("status")
            Me.lbl_hotel.Text = rd.Item("id_hotel")

            'Dim arr_image() As Byte = rd.Item("picture")
            'Dim ms As New IO.MemoryStream(arr_image)
            'PictureBox1.Image = Image.FromStream(ms)

        End If

        rd.Close()
    End Sub

    Private Sub FRE_Click(sender As Object, e As EventArgs) Handles FRE.Click
        Dim mr As New ManagementRoom
        mr.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rs As New ManagementReservation
        rs.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim mnc As New ManagementClient
        mnc.Show()
    End Sub
End Class