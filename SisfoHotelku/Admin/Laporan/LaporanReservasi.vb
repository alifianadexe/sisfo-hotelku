Imports System.Drawing.Printing

Public Class LaporanReservasi

    Dim conn As New SqlClient.SqlConnection


    Private Sub LaporanReservasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()

        refreshData()

        date_bulan.Format = DateTimePickerFormat.Custom
        date_bulan.CustomFormat = "MMMM"

        date_tahun.Format = DateTimePickerFormat.Custom
        date_tahun.CustomFormat = "yyy"

    End Sub

    Private Sub refreshData()
        Dim sql As String = "SELECT COUNT(tbl_client.id_client) as Total, invoice_date as [Tanggal] FROM tbl_invoice INNER JOIN tbl_client ON tbl_client.id_client = tbl_invoice.id_client GROUP BY invoice_date"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        adapter.Fill(dt)

        chart_reservasi.DataSource = dt
        chart_reservasi.Series("Client").XValueMember = "Tanggal"
        chart_reservasi.Series("Client").YValueMembers = "Total"

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
        Dim fn As New Font("Courier New", 12)

        Dim myRec As New Rectangle(10, 20, 800, 400)

        gp.DrawString("---------------------- LAPORAN RESERVASI -----------------------", fn, New SolidBrush(Color.Black), 10, 10)
        chart_reservasi.Printing.PrintPaint(ev.Graphics, myRec)
        gp.DrawString("----------------------------------------------------------------", fn, New SolidBrush(Color.Black), 10, 210)

    End Sub
End Class