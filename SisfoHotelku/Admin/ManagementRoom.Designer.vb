<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagementRoom
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_standard = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_vip = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_room_type = New System.Windows.Forms.ComboBox()
        Me.txt_free = New System.Windows.Forms.RadioButton()
        Me.txt_free_2 = New System.Windows.Forms.RadioButton()
        Me.lbl_vip = New System.Windows.Forms.Label()
        Me.lbl_standard = New System.Windows.Forms.Label()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.data_grid = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.data_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_add)
        Me.GroupBox1.Controls.Add(Me.btn_delete)
        Me.GroupBox1.Controls.Add(Me.btn_insert)
        Me.GroupBox1.Controls.Add(Me.btn_edit)
        Me.GroupBox1.Controls.Add(Me.lbl_vip)
        Me.GroupBox1.Controls.Add(Me.lbl_standard)
        Me.GroupBox1.Controls.Add(Me.txt_free_2)
        Me.GroupBox1.Controls.Add(Me.txt_free)
        Me.GroupBox1.Controls.Add(Me.txt_room_type)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_vip)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_standard)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(451, 292)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Room Identity"
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(127, 19)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_id.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID Room"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Room Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Standard Price"
        '
        'txt_standard
        '
        Me.txt_standard.Enabled = False
        Me.txt_standard.Location = New System.Drawing.Point(127, 71)
        Me.txt_standard.Name = "txt_standard"
        Me.txt_standard.Size = New System.Drawing.Size(187, 20)
        Me.txt_standard.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "VIP Price"
        '
        'txt_vip
        '
        Me.txt_vip.Enabled = False
        Me.txt_vip.Location = New System.Drawing.Point(127, 97)
        Me.txt_vip.Name = "txt_vip"
        Me.txt_vip.Size = New System.Drawing.Size(187, 20)
        Me.txt_vip.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "is Free"
        '
        'txt_room_type
        '
        Me.txt_room_type.Enabled = False
        Me.txt_room_type.FormattingEnabled = True
        Me.txt_room_type.Items.AddRange(New Object() {"Standard Mini Room 5x6"" ", "Exclusive Athena Room 10x8""", "Premium Barbar Room 8x9""", "Micro Habit Room 9x9""", "Adexe Golden Room 20x20"""})
        Me.txt_room_type.Location = New System.Drawing.Point(127, 44)
        Me.txt_room_type.Name = "txt_room_type"
        Me.txt_room_type.Size = New System.Drawing.Size(153, 21)
        Me.txt_room_type.TabIndex = 10
        '
        'txt_free
        '
        Me.txt_free.AutoSize = True
        Me.txt_free.Enabled = False
        Me.txt_free.Location = New System.Drawing.Point(127, 126)
        Me.txt_free.Name = "txt_free"
        Me.txt_free.Size = New System.Drawing.Size(46, 17)
        Me.txt_free.TabIndex = 11
        Me.txt_free.TabStop = True
        Me.txt_free.Text = "Free"
        Me.txt_free.UseVisualStyleBackColor = True
        '
        'txt_free_2
        '
        Me.txt_free_2.AutoSize = True
        Me.txt_free_2.Enabled = False
        Me.txt_free_2.Location = New System.Drawing.Point(202, 126)
        Me.txt_free_2.Name = "txt_free_2"
        Me.txt_free_2.Size = New System.Drawing.Size(62, 17)
        Me.txt_free_2.TabIndex = 12
        Me.txt_free_2.TabStop = True
        Me.txt_free_2.Text = "In-Used"
        Me.txt_free_2.UseVisualStyleBackColor = True
        '
        'lbl_vip
        '
        Me.lbl_vip.AutoSize = True
        Me.lbl_vip.Location = New System.Drawing.Point(333, 100)
        Me.lbl_vip.Name = "lbl_vip"
        Me.lbl_vip.Size = New System.Drawing.Size(51, 13)
        Me.lbl_vip.TabIndex = 14
        Me.lbl_vip.Text = "VIP Price"
        '
        'lbl_standard
        '
        Me.lbl_standard.AutoSize = True
        Me.lbl_standard.Location = New System.Drawing.Point(333, 74)
        Me.lbl_standard.Name = "lbl_standard"
        Me.lbl_standard.Size = New System.Drawing.Size(77, 13)
        Me.lbl_standard.TabIndex = 13
        Me.lbl_standard.Text = "Standard Price"
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(93, 166)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(134, 45)
        Me.btn_edit.TabIndex = 15
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_insert
        '
        Me.btn_insert.Location = New System.Drawing.Point(233, 217)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(134, 45)
        Me.btn_insert.TabIndex = 16
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(93, 217)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(134, 45)
        Me.btn_delete.TabIndex = 17
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(233, 166)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(134, 45)
        Me.btn_add.TabIndex = 18
        Me.btn_add.Text = "Add "
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'data_grid
        '
        Me.data_grid.AllowUserToAddRows = False
        Me.data_grid.AllowUserToDeleteRows = False
        Me.data_grid.AllowUserToOrderColumns = True
        Me.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid.Location = New System.Drawing.Point(12, 310)
        Me.data_grid.Name = "data_grid"
        Me.data_grid.ReadOnly = True
        Me.data_grid.Size = New System.Drawing.Size(599, 216)
        Me.data_grid.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(471, 214)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 60)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Management Type Room"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ManagementRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 538)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.data_grid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ManagementRoom"
        Me.Text = "ManagementRoom"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.data_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_free_2 As RadioButton
    Friend WithEvents txt_free As RadioButton
    Friend WithEvents txt_room_type As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_vip As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_standard As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_vip As Label
    Friend WithEvents lbl_standard As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents data_grid As DataGridView
    Friend WithEvents Button1 As Button
End Class
