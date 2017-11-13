<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NavigationAdmin
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
        Me.FRE = New System.Windows.Forms.Button()
        Me.tbl = New System.Windows.Forms.GroupBox()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_no_hp = New System.Windows.Forms.Label()
        Me.lbl_hotel = New System.Windows.Forms.Label()
        Me.lbl_nama = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tbl.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FRE
        '
        Me.FRE.Location = New System.Drawing.Point(13, 19)
        Me.FRE.Name = "FRE"
        Me.FRE.Size = New System.Drawing.Size(200, 57)
        Me.FRE.TabIndex = 0
        Me.FRE.Text = "Management Room"
        Me.FRE.UseVisualStyleBackColor = True
        '
        'tbl
        '
        Me.tbl.Controls.Add(Me.PictureBox1)
        Me.tbl.Controls.Add(Me.lbl_status)
        Me.tbl.Controls.Add(Me.lbl_date)
        Me.tbl.Controls.Add(Me.lbl_no_hp)
        Me.tbl.Controls.Add(Me.lbl_hotel)
        Me.tbl.Controls.Add(Me.lbl_nama)
        Me.tbl.Controls.Add(Me.lbl_id)
        Me.tbl.Controls.Add(Me.Label6)
        Me.tbl.Controls.Add(Me.Label7)
        Me.tbl.Controls.Add(Me.Label4)
        Me.tbl.Controls.Add(Me.Label5)
        Me.tbl.Controls.Add(Me.Label3)
        Me.tbl.Controls.Add(Me.Label2)
        Me.tbl.Location = New System.Drawing.Point(12, 58)
        Me.tbl.Name = "tbl"
        Me.tbl.Size = New System.Drawing.Size(632, 219)
        Me.tbl.TabIndex = 1
        Me.tbl.TabStop = False
        Me.tbl.Text = "Data Diri"
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_status.Location = New System.Drawing.Point(360, 185)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(45, 13)
        Me.lbl_status.TabIndex = 11
        Me.lbl_status.Text = "Label8"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(360, 150)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(45, 13)
        Me.lbl_date.TabIndex = 10
        Me.lbl_date.Text = "Label9"
        '
        'lbl_no_hp
        '
        Me.lbl_no_hp.AutoSize = True
        Me.lbl_no_hp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_no_hp.Location = New System.Drawing.Point(360, 117)
        Me.lbl_no_hp.Name = "lbl_no_hp"
        Me.lbl_no_hp.Size = New System.Drawing.Size(52, 13)
        Me.lbl_no_hp.TabIndex = 9
        Me.lbl_no_hp.Text = "Label10"
        '
        'lbl_hotel
        '
        Me.lbl_hotel.AutoSize = True
        Me.lbl_hotel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hotel.Location = New System.Drawing.Point(360, 85)
        Me.lbl_hotel.Name = "lbl_hotel"
        Me.lbl_hotel.Size = New System.Drawing.Size(52, 13)
        Me.lbl_hotel.TabIndex = 8
        Me.lbl_hotel.Text = "Label11"
        '
        'lbl_nama
        '
        Me.lbl_nama.AutoSize = True
        Me.lbl_nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nama.Location = New System.Drawing.Point(360, 51)
        Me.lbl_nama.Name = "lbl_nama"
        Me.lbl_nama.Size = New System.Drawing.Size(52, 13)
        Me.lbl_nama.TabIndex = 7
        Me.lbl_nama.Text = "Label12"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(360, 16)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(52, 13)
        Me.lbl_id.TabIndex = 6
        Me.lbl_id.Text = "Label13"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(279, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(279, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Tanggal Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(279, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "No Hp"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(279, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Hotel"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(279, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(279, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.FRE)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 283)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(632, 219)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Menu"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(218, 145)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(201, 57)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Laporan"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(12, 145)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(200, 57)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "Management Hotel"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(218, 82)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(201, 57)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Management Petugas"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(218, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(201, 57)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Management Client"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 82)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 57)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Management Reservation"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.OrangeRed
        Me.Label1.Font = New System.Drawing.Font("Forte", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(-7, -6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(670, 61)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Admin Navigation"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(425, 145)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 57)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Management Bill"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(425, 82)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(201, 57)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "Management Invoice"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(425, 19)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(201, 57)
        Me.Button8.TabIndex = 6
        Me.Button8.Text = "Management Lokasi"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SisfoHotelku.My.Resources.Resources.icon_user_default
        Me.PictureBox1.Location = New System.Drawing.Point(86, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(162, 179)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'NavigationAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 514)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.tbl)
        Me.Name = "NavigationAdmin"
        Me.tbl.ResumeLayout(False)
        Me.tbl.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FRE As Button
    Friend WithEvents tbl As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_status As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents lbl_no_hp As Label
    Friend WithEvents lbl_hotel As Label
    Friend WithEvents lbl_nama As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
End Class
