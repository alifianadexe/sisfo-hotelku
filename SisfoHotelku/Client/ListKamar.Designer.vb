<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListKamar
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_tipe = New System.Windows.Forms.ComboBox()
        Me.lbl_nama = New System.Windows.Forms.Label()
        Me.asd = New System.Windows.Forms.GroupBox()
        Me.lbl_desc = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.data_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.asd.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'data_grid
        '
        Me.data_grid.AllowUserToAddRows = False
        Me.data_grid.AllowUserToDeleteRows = False
        Me.data_grid.AllowUserToOrderColumns = True
        Me.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid.Location = New System.Drawing.Point(477, 130)
        Me.data_grid.Name = "data_grid"
        Me.data_grid.ReadOnly = True
        Me.data_grid.Size = New System.Drawing.Size(363, 396)
        Me.data_grid.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Font = New System.Drawing.Font("Forte", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(-7, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(847, 47)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "List Kamar"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.lbl_nama)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 298)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Info Kamar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_tipe)
        Me.GroupBox2.Location = New System.Drawing.Point(474, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(366, 52)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pilih Type Kamar"
        '
        'txt_tipe
        '
        Me.txt_tipe.FormattingEnabled = True
        Me.txt_tipe.Location = New System.Drawing.Point(6, 19)
        Me.txt_tipe.Name = "txt_tipe"
        Me.txt_tipe.Size = New System.Drawing.Size(354, 21)
        Me.txt_tipe.TabIndex = 0
        '
        'lbl_nama
        '
        Me.lbl_nama.BackColor = System.Drawing.Color.OliveDrab
        Me.lbl_nama.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nama.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_nama.Location = New System.Drawing.Point(6, 19)
        Me.lbl_nama.Name = "lbl_nama"
        Me.lbl_nama.Size = New System.Drawing.Size(435, 31)
        Me.lbl_nama.TabIndex = 3
        Me.lbl_nama.Text = "Pilih Tipe Kamar"
        Me.lbl_nama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'asd
        '
        Me.asd.Controls.Add(Me.lbl_desc)
        Me.asd.Location = New System.Drawing.Point(12, 353)
        Me.asd.Name = "asd"
        Me.asd.Size = New System.Drawing.Size(456, 173)
        Me.asd.TabIndex = 7
        Me.asd.TabStop = False
        Me.asd.Text = "Info"
        '
        'lbl_desc
        '
        Me.lbl_desc.Location = New System.Drawing.Point(12, 16)
        Me.lbl_desc.Name = "lbl_desc"
        Me.lbl_desc.Size = New System.Drawing.Size(429, 154)
        Me.lbl_desc.TabIndex = 6
        Me.lbl_desc.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(474, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Daftar Kamar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(6, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(435, 229)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.BlueViolet
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(357, 532)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 54)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Reservasi"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ListKamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 598)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.asd)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.data_grid)
        Me.Name = "ListKamar"
        Me.Text = "ListKamar"
        CType(Me.data_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.asd.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents data_grid As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_tipe As ComboBox
    Friend WithEvents lbl_nama As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_desc As Label
    Friend WithEvents asd As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
