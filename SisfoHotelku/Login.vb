Public Class Login
    Dim conn As New SqlClient.SqlConnection()
    Dim rd As SqlClient.SqlDataReader

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If cekEmptyTextbox(Me.txt_username, Me.txt_password) Then
                Dim sql As String = "SELECT * FROM tbl_petugas WHERE username = '" + Me.txt_username.Text + "'"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If rd.HasRows Then
                    If rd.Item("password") = Me.txt_password.Text Then
                        If rd.Item("status") = "Admin" Then
                            Dim na As New NavigationAdmin
                            na.Tag = rd.Item("id_petugas")
                            na.Show()
                        End If
                    Else
                        MessageBox.Show("Maaf password salah!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    End If
                Else
                    MessageBox.Show("Maaf anda belum terdaftar!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                End If
                rd.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub
End Class