Imports System.Drawing.Printing
Public Class LaporanClient
    Dim conn As New SqlClient.SqlConnection

    Private Sub LaporanClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()
        refreshData()



    End Sub

    Private Sub refreshData()
        Dim sql As String = "SELECT nama_client, alamat, no_hp, email, invoice_date FROM tbl_client INNER JOIN tbl_invoice ON tbl_invoice.id_client = tbl_client.id_client ORDER BY nama_client"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable

        adapter.Fill(dt)

        data_grid.DataSource = dt




    End Sub
    Private Sub refreshData(ByVal tanggal As Date)
        Dim sql As String = "SELECT nama_client, alamat, no_hp, email, invoice_date FROM tbl_client INNER JOIN tbl_invoice ON tbl_invoice.id_client = tbl_client.id_client WHERE invoice_date = '" + Me.DateTimePicker1.Value + "' ORDER BY nama_client"

        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable

        adapter.Fill(dt)

        data_grid.DataSource = dt




    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        refreshData(Me.DateTimePicker1.Value)
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        Dim pd As New PrintDocument
        AddHandler pd.PrintPage, AddressOf Me.print_page
        PrintDialog1.Document = pd
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            pd.Print()
        End If
    End Sub

    Private Sub print_page(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim gp As Graphics = ev.Graphics
        Dim bm As New Bitmap(Me.data_grid.Width, Me.data_grid.Height)
        Dim rec As New Rectangle(0, 0, Me.data_grid.Width, Me.data_grid.Height)

        data_grid.DrawToBitmap(bm, rec)

        gp.DrawString("--------------------------- LAPORAN CLIENT ------------------------", New Font("Courier New", 20), New SolidBrush(Color.Black), 10, 10)
        gp.DrawImage(bm, 50, 10)

    End Sub
End Class