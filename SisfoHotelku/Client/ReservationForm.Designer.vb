<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReservationForm
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
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.txt_alamat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_tanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_no_hp = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_jenis_kamar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.RadioButton()
        Me.txt_price_2 = New System.Windows.Forms.RadioButton()
        Me.txt_jumlah_kamar = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_pesan = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txt_jumlah_kamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(86, 19)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(98, 20)
        Me.txt_id.TabIndex = 1
        '
        'txt_nama
        '
        Me.txt_nama.Location = New System.Drawing.Point(86, 45)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(237, 20)
        Me.txt_nama.TabIndex = 2
        '
        'txt_alamat
        '
        Me.txt_alamat.Location = New System.Drawing.Point(86, 71)
        Me.txt_alamat.Multiline = True
        Me.txt_alamat.Name = "txt_alamat"
        Me.txt_alamat.Size = New System.Drawing.Size(264, 47)
        Me.txt_alamat.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Font = New System.Drawing.Font("Forte", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(-8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(495, 47)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Reservation Form"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_no_hp)
        Me.GroupBox1.Controls.Add(Me.txt_tanggal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_nama)
        Me.GroupBox1.Controls.Add(Me.txt_alamat)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(455, 209)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Diri"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nama "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tanggal Lahir"
        '
        'txt_tanggal
        '
        Me.txt_tanggal.Location = New System.Drawing.Point(86, 123)
        Me.txt_tanggal.Name = "txt_tanggal"
        Me.txt_tanggal.Size = New System.Drawing.Size(200, 20)
        Me.txt_tanggal.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "No HP"
        '
        'txt_no_hp
        '
        Me.txt_no_hp.Location = New System.Drawing.Point(86, 149)
        Me.txt_no_hp.Name = "txt_no_hp"
        Me.txt_no_hp.Size = New System.Drawing.Size(200, 20)
        Me.txt_no_hp.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Email"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(86, 175)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(237, 20)
        Me.TextBox5.TabIndex = 14
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_jumlah_kamar)
        Me.GroupBox2.Controls.Add(Me.txt_price_2)
        Me.GroupBox2.Controls.Add(Me.txt_price)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txt_jenis_kamar)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 285)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(455, 105)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Kamar"
        '
        'txt_jenis_kamar
        '
        Me.txt_jenis_kamar.Location = New System.Drawing.Point(84, 19)
        Me.txt_jenis_kamar.Name = "txt_jenis_kamar"
        Me.txt_jenis_kamar.Size = New System.Drawing.Size(237, 20)
        Me.txt_jenis_kamar.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Jenis Kamar"
        '
        'txt_price
        '
        Me.txt_price.AutoSize = True
        Me.txt_price.Location = New System.Drawing.Point(84, 71)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(68, 17)
        Me.txt_price.TabIndex = 17
        Me.txt_price.TabStop = True
        Me.txt_price.Text = "Standard"
        Me.txt_price.UseVisualStyleBackColor = True
        '
        'txt_price_2
        '
        Me.txt_price_2.AutoSize = True
        Me.txt_price_2.Location = New System.Drawing.Point(158, 71)
        Me.txt_price_2.Name = "txt_price_2"
        Me.txt_price_2.Size = New System.Drawing.Size(65, 17)
        Me.txt_price_2.TabIndex = 18
        Me.txt_price_2.TabStop = True
        Me.txt_price_2.Text = "Premium"
        Me.txt_price_2.UseVisualStyleBackColor = True
        '
        'txt_jumlah_kamar
        '
        Me.txt_jumlah_kamar.Location = New System.Drawing.Point(86, 45)
        Me.txt_jumlah_kamar.Name = "txt_jumlah_kamar"
        Me.txt_jumlah_kamar.Size = New System.Drawing.Size(100, 20)
        Me.txt_jumlah_kamar.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Jumlah Kamar"
        '
        'btn_pesan
        '
        Me.btn_pesan.Location = New System.Drawing.Point(154, 396)
        Me.btn_pesan.Name = "btn_pesan"
        Me.btn_pesan.Size = New System.Drawing.Size(144, 40)
        Me.btn_pesan.TabIndex = 10
        Me.btn_pesan.Text = "Pesan"
        Me.btn_pesan.UseVisualStyleBackColor = True
        '
        'ReservationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 448)
        Me.Controls.Add(Me.btn_pesan)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ReservationForm"
        Me.Text = "ReservationForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txt_jumlah_kamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents txt_alamat As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_tanggal As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_no_hp As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_jenis_kamar As TextBox
    Friend WithEvents txt_price_2 As RadioButton
    Friend WithEvents txt_price As RadioButton
    Friend WithEvents txt_jumlah_kamar As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_pesan As Button
End Class
