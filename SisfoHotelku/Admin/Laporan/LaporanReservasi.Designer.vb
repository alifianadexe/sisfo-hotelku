<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanReservasi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.chart_reservasi = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.date_bulan = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.date_tahun = New System.Windows.Forms.DateTimePicker()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        CType(Me.chart_reservasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'chart_reservasi
        '
        ChartArea2.Name = "ChartArea1"
        Me.chart_reservasi.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chart_reservasi.Legends.Add(Legend2)
        Me.chart_reservasi.Location = New System.Drawing.Point(12, 117)
        Me.chart_reservasi.Name = "chart_reservasi"
        Me.chart_reservasi.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones
        Series2.BorderWidth = 5
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Legend = "Legend1"
        Series2.Name = "Client"
        Me.chart_reservasi.Series.Add(Series2)
        Me.chart_reservasi.Size = New System.Drawing.Size(766, 352)
        Me.chart_reservasi.TabIndex = 0
        Me.chart_reservasi.Text = "STATISTIKA RESERVASI"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Tomato
        Me.Label1.Font = New System.Drawing.Font("Consolas", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(-5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(799, 48)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "STATISTIKA RESERVASI"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'date_bulan
        '
        Me.date_bulan.Location = New System.Drawing.Point(6, 19)
        Me.date_bulan.Name = "date_bulan"
        Me.date_bulan.Size = New System.Drawing.Size(113, 20)
        Me.date_bulan.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.date_bulan)
        Me.GroupBox1.Location = New System.Drawing.Point(506, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(132, 51)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bulan"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.date_tahun)
        Me.GroupBox2.Location = New System.Drawing.Point(644, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(146, 51)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tahun"
        '
        'date_tahun
        '
        Me.date_tahun.Location = New System.Drawing.Point(6, 19)
        Me.date_tahun.Name = "date_tahun"
        Me.date_tahun.Size = New System.Drawing.Size(127, 20)
        Me.date_tahun.TabIndex = 6
        '
        'btn_print
        '
        Me.btn_print.Location = New System.Drawing.Point(650, 475)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(121, 42)
        Me.btn_print.TabIndex = 9
        Me.btn_print.Text = "Print"
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'LaporanReservasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 529)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chart_reservasi)
        Me.Name = "LaporanReservasi"
        Me.Text = "LaporanReservasi"
        CType(Me.chart_reservasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents chart_reservasi As DataVisualization.Charting.Chart
    Friend WithEvents Label1 As Label
    Friend WithEvents date_bulan As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents date_tahun As DateTimePicker
    Friend WithEvents btn_print As Button
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
