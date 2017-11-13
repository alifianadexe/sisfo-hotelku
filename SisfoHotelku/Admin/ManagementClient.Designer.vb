<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagementClient
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
        Me.sadasd = New System.Windows.Forms.GroupBox()
        Me.txt_tanggal_lahir = New System.Windows.Forms.DateTimePicker()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_no_hp = New System.Windows.Forms.TextBox()
        Me.txt_alamat = New System.Windows.Forms.TextBox()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_ad = New System.Windows.Forms.Button()
        Me.btn_ins = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_dele = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.list_room = New System.Windows.Forms.ListView()
        CType(Me.data_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sadasd.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'data_grid
        '
        Me.data_grid.AllowUserToAddRows = False
        Me.data_grid.AllowUserToDeleteRows = False
        Me.data_grid.AllowUserToOrderColumns = True
        Me.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid.Location = New System.Drawing.Point(12, 264)
        Me.data_grid.Name = "data_grid"
        Me.data_grid.ReadOnly = True
        Me.data_grid.Size = New System.Drawing.Size(465, 176)
        Me.data_grid.TabIndex = 1
        '
        'sadasd
        '
        Me.sadasd.Controls.Add(Me.txt_tanggal_lahir)
        Me.sadasd.Controls.Add(Me.txt_email)
        Me.sadasd.Controls.Add(Me.txt_no_hp)
        Me.sadasd.Controls.Add(Me.txt_alamat)
        Me.sadasd.Controls.Add(Me.txt_nama)
        Me.sadasd.Controls.Add(Me.txt_id)
        Me.sadasd.Controls.Add(Me.Label11)
        Me.sadasd.Controls.Add(Me.Label10)
        Me.sadasd.Controls.Add(Me.Label8)
        Me.sadasd.Controls.Add(Me.Label6)
        Me.sadasd.Controls.Add(Me.Label4)
        Me.sadasd.Controls.Add(Me.Label1)
        Me.sadasd.Location = New System.Drawing.Point(12, 26)
        Me.sadasd.Name = "sadasd"
        Me.sadasd.Size = New System.Drawing.Size(382, 202)
        Me.sadasd.TabIndex = 5
        Me.sadasd.TabStop = False
        Me.sadasd.Text = "Data Client"
        '
        'txt_tanggal_lahir
        '
        Me.txt_tanggal_lahir.Enabled = False
        Me.txt_tanggal_lahir.Location = New System.Drawing.Point(93, 117)
        Me.txt_tanggal_lahir.Name = "txt_tanggal_lahir"
        Me.txt_tanggal_lahir.Size = New System.Drawing.Size(200, 20)
        Me.txt_tanggal_lahir.TabIndex = 17
        '
        'txt_email
        '
        Me.txt_email.Enabled = False
        Me.txt_email.Location = New System.Drawing.Point(93, 166)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(199, 20)
        Me.txt_email.TabIndex = 16
        '
        'txt_no_hp
        '
        Me.txt_no_hp.Enabled = False
        Me.txt_no_hp.Location = New System.Drawing.Point(93, 143)
        Me.txt_no_hp.Name = "txt_no_hp"
        Me.txt_no_hp.Size = New System.Drawing.Size(175, 20)
        Me.txt_no_hp.TabIndex = 15
        '
        'txt_alamat
        '
        Me.txt_alamat.Enabled = False
        Me.txt_alamat.Location = New System.Drawing.Point(93, 70)
        Me.txt_alamat.Multiline = True
        Me.txt_alamat.Name = "txt_alamat"
        Me.txt_alamat.Size = New System.Drawing.Size(258, 41)
        Me.txt_alamat.TabIndex = 13
        '
        'txt_nama
        '
        Me.txt_nama.Enabled = False
        Me.txt_nama.Location = New System.Drawing.Point(93, 45)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(199, 20)
        Me.txt_nama.TabIndex = 12
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(93, 22)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(87, 20)
        Me.txt_id.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "ID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Tanggal  Lahir"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "No Hp"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Alamat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'btn_ad
        '
        Me.btn_ad.Location = New System.Drawing.Point(499, 251)
        Me.btn_ad.Name = "btn_ad"
        Me.btn_ad.Size = New System.Drawing.Size(160, 45)
        Me.btn_ad.TabIndex = 6
        Me.btn_ad.Text = "Add"
        Me.btn_ad.UseVisualStyleBackColor = True
        '
        'btn_ins
        '
        Me.btn_ins.Location = New System.Drawing.Point(499, 299)
        Me.btn_ins.Name = "btn_ins"
        Me.btn_ins.Size = New System.Drawing.Size(160, 45)
        Me.btn_ins.TabIndex = 7
        Me.btn_ins.Text = "Insert"
        Me.btn_ins.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(499, 346)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(160, 45)
        Me.btn_edit.TabIndex = 8
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_dele
        '
        Me.btn_dele.Location = New System.Drawing.Point(499, 395)
        Me.btn_dele.Name = "btn_dele"
        Me.btn_dele.Size = New System.Drawing.Size(160, 45)
        Me.btn_dele.TabIndex = 9
        Me.btn_dele.Text = "Delete"
        Me.btn_dele.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 237)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Search : "
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(286, 234)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(191, 20)
        Me.txt_search.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.list_room)
        Me.GroupBox1.Location = New System.Drawing.Point(400, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(85, 202)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List Kamar"
        '
        'list_room
        '
        Me.list_room.Location = New System.Drawing.Point(6, 19)
        Me.list_room.Name = "list_room"
        Me.list_room.Size = New System.Drawing.Size(71, 167)
        Me.list_room.TabIndex = 13
        Me.list_room.UseCompatibleStateImageBehavior = False
        '
        'ManagementClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 452)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_dele)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_ins)
        Me.Controls.Add(Me.btn_ad)
        Me.Controls.Add(Me.sadasd)
        Me.Controls.Add(Me.data_grid)
        Me.Name = "ManagementClient"
        Me.Text = "ManagementClient"
        CType(Me.data_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sadasd.ResumeLayout(False)
        Me.sadasd.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents data_grid As DataGridView
    Friend WithEvents sadasd As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_ad As Button
    Friend WithEvents btn_ins As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_dele As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_alamat As TextBox
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_no_hp As TextBox
    Friend WithEvents txt_tanggal_lahir As DateTimePicker
    Friend WithEvents list_room As ListView
End Class
