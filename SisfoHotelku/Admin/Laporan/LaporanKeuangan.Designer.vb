<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanKeuangan
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
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.chart_keuangan = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.data_grid = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        CType(Me.chart_keuangan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chart_keuangan
        '
        ChartArea4.Name = "ChartArea1"
        Me.chart_keuangan.ChartAreas.Add(ChartArea4)
        Legend4.BackColor = System.Drawing.Color.Transparent
        Legend4.Name = "Legend1"
        Me.chart_keuangan.Legends.Add(Legend4)
        Me.chart_keuangan.Location = New System.Drawing.Point(449, 100)
        Me.chart_keuangan.Name = "chart_keuangan"
        Me.chart_keuangan.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones
        Series4.ChartArea = "ChartArea1"
        Series4.IsValueShownAsLabel = True
        Series4.LabelFormat = "##,##0.00"
        Series4.Legend = "Legend1"
        Series4.Name = "Uang"
        Me.chart_keuangan.Series.Add(Series4)
        Me.chart_keuangan.Size = New System.Drawing.Size(618, 357)
        Me.chart_keuangan.TabIndex = 0
        Me.chart_keuangan.Text = "Chart1"
        '
        'data_grid
        '
        Me.data_grid.AllowUserToAddRows = False
        Me.data_grid.AllowUserToDeleteRows = False
        Me.data_grid.AllowUserToOrderColumns = True
        Me.data_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.data_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid.Location = New System.Drawing.Point(12, 100)
        Me.data_grid.Name = "data_grid"
        Me.data_grid.ReadOnly = True
        Me.data_grid.Size = New System.Drawing.Size(415, 357)
        Me.data_grid.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(821, 469)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 50)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Tomato
        Me.Label1.Font = New System.Drawing.Font("Consolas", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(2, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1083, 48)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "LAPORAN KEUANGAN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(229, 72)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(198, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(188, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Hari : "
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'LaporanKeuangan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 531)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.data_grid)
        Me.Controls.Add(Me.chart_keuangan)
        Me.Name = "LaporanKeuangan"
        Me.Text = "LaporanKeuangan"
        CType(Me.chart_keuangan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chart_keuangan As DataVisualization.Charting.Chart
    Friend WithEvents data_grid As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
