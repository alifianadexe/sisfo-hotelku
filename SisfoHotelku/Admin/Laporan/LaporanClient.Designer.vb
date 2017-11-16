<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanClient
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
        Me.data_grid = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.asdas = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        CType(Me.data_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'data_grid
        '
        Me.data_grid.AllowUserToAddRows = False
        Me.data_grid.AllowUserToDeleteRows = False
        Me.data_grid.AllowUserToOrderColumns = True
        Me.data_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.data_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid.Location = New System.Drawing.Point(12, 97)
        Me.data_grid.Name = "data_grid"
        Me.data_grid.ReadOnly = True
        Me.data_grid.Size = New System.Drawing.Size(740, 342)
        Me.data_grid.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Tomato
        Me.Label1.Font = New System.Drawing.Font("Consolas", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(-6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(779, 48)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "LAPORAN CLIENT"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_print
        '
        Me.btn_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_print.Location = New System.Drawing.Point(637, 445)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(115, 41)
        Me.btn_print.TabIndex = 7
        Me.btn_print.Text = "Print"
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'asdas
        '
        Me.asdas.AutoSize = True
        Me.asdas.Location = New System.Drawing.Point(472, 74)
        Me.asdas.Name = "asdas"
        Me.asdas.Size = New System.Drawing.Size(74, 13)
        Me.asdas.TabIndex = 9
        Me.asdas.Text = "Daftar Client : "
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(552, 71)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 10
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'LaporanClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 498)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.asdas)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.data_grid)
        Me.Name = "LaporanClient"
        Me.Text = "LaporanClient"
        CType(Me.data_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents data_grid As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_print As Button
    Friend WithEvents asdas As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
