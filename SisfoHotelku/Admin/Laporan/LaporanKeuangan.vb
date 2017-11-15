Public Class LaporanKeuangan

    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader



    Private Sub LaporanKeuangan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()

        refreshData()
        refreshDataChart()
    End Sub

    Private Sub refreshData()
        Dim sql As String = "SELECT id_invoice as [ID Invoice] ,invoice_date as [Tanggal Pesanan], total_pembayaran as [Total Pembayaran (Rp.)] FROM tbl_invoice WHERE invoice_date = '" + Me.DateTimePicker1.Value + "' AND is_accept = 1"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        adapter.Fill(dt)

        data_grid.DataSource = dt
        data_grid.Columns(2).DefaultCellStyle.Format = "##,##0.00"
        data_grid.Columns(2).Width = 100
    End Sub

    Private Sub refreshDataChart()
        Dim sql As String = "SELECT SUM(total_pembayaran) as [total], invoice_date as [tanggal] FROM tbl_invoice WHERE is_accept = 1 GROUP BY invoice_date "
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable

        adapter.Fill(dt)

        chart_keuangan.DataSource = dt
        chart_keuangan.Series("Uang").XValueMember = "tanggal"
        chart_keuangan.Series("Uang").YValueMembers = "total"
        chart_keuangan.Series("Uang").LabelFormat = "##,##0.00"


    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        refreshData()
    End Sub
End Class