<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.idmsk_box = New System.Windows.Forms.TextBox()
        Me.no_box = New System.Windows.Forms.TextBox()
        Me.pengirim_box = New System.Windows.Forms.TextBox()
        Me.perihal_box = New System.Windows.Forms.TextBox()
        Me.tgl_box = New System.Windows.Forms.DateTimePicker()
        Me.back_btn = New System.Windows.Forms.Button()
        Me.exit2_btn = New System.Windows.Forms.Button()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.update_btn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.load_btn = New System.Windows.Forms.Button()
        Me.search_box = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(18, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Surat Masuk"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(18, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 27)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nomor Surat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(18, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 27)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tanggal Surat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(18, 330)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 27)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Pengirim"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(18, 398)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 27)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Perihal"
        '
        'idmsk_box
        '
        Me.idmsk_box.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.idmsk_box.Location = New System.Drawing.Point(200, 124)
        Me.idmsk_box.Name = "idmsk_box"
        Me.idmsk_box.Size = New System.Drawing.Size(268, 32)
        Me.idmsk_box.TabIndex = 1
        '
        'no_box
        '
        Me.no_box.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.no_box.Location = New System.Drawing.Point(200, 192)
        Me.no_box.Name = "no_box"
        Me.no_box.Size = New System.Drawing.Size(268, 32)
        Me.no_box.TabIndex = 1
        '
        'pengirim_box
        '
        Me.pengirim_box.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pengirim_box.Location = New System.Drawing.Point(200, 327)
        Me.pengirim_box.Name = "pengirim_box"
        Me.pengirim_box.Size = New System.Drawing.Size(268, 32)
        Me.pengirim_box.TabIndex = 1
        '
        'perihal_box
        '
        Me.perihal_box.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.perihal_box.Location = New System.Drawing.Point(200, 395)
        Me.perihal_box.Name = "perihal_box"
        Me.perihal_box.Size = New System.Drawing.Size(268, 32)
        Me.perihal_box.TabIndex = 1
        '
        'tgl_box
        '
        Me.tgl_box.CustomFormat = "yyyy-MM-dd"
        Me.tgl_box.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tgl_box.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tgl_box.Location = New System.Drawing.Point(200, 257)
        Me.tgl_box.Name = "tgl_box"
        Me.tgl_box.Size = New System.Drawing.Size(268, 32)
        Me.tgl_box.TabIndex = 2
        Me.tgl_box.Value = New Date(2022, 6, 1, 0, 0, 0, 0)
        '
        'back_btn
        '
        Me.back_btn.BackColor = System.Drawing.Color.Transparent
        Me.back_btn.Font = New System.Drawing.Font("Montserrat", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.back_btn.Location = New System.Drawing.Point(18, 526)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(102, 37)
        Me.back_btn.TabIndex = 4
        Me.back_btn.Text = "BACK"
        Me.back_btn.UseVisualStyleBackColor = False
        '
        'exit2_btn
        '
        Me.exit2_btn.Font = New System.Drawing.Font("Montserrat", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.exit2_btn.Location = New System.Drawing.Point(964, 526)
        Me.exit2_btn.Name = "exit2_btn"
        Me.exit2_btn.Size = New System.Drawing.Size(102, 37)
        Me.exit2_btn.TabIndex = 5
        Me.exit2_btn.Text = "EXIT"
        Me.exit2_btn.UseVisualStyleBackColor = True
        '
        'save_btn
        '
        Me.save_btn.BackColor = System.Drawing.Color.Transparent
        Me.save_btn.Font = New System.Drawing.Font("Montserrat", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.save_btn.Location = New System.Drawing.Point(18, 449)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(102, 37)
        Me.save_btn.TabIndex = 4
        Me.save_btn.Text = "SAVE"
        Me.save_btn.UseVisualStyleBackColor = False
        '
        'delete_btn
        '
        Me.delete_btn.BackColor = System.Drawing.Color.Transparent
        Me.delete_btn.Font = New System.Drawing.Font("Montserrat", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.delete_btn.Location = New System.Drawing.Point(366, 449)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(102, 37)
        Me.delete_btn.TabIndex = 4
        Me.delete_btn.Text = "DELETE"
        Me.delete_btn.UseVisualStyleBackColor = False
        '
        'update_btn
        '
        Me.update_btn.BackColor = System.Drawing.Color.Transparent
        Me.update_btn.Font = New System.Drawing.Font("Montserrat", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.update_btn.Location = New System.Drawing.Point(199, 449)
        Me.update_btn.Name = "update_btn"
        Me.update_btn.Size = New System.Drawing.Size(102, 37)
        Me.update_btn.TabIndex = 4
        Me.update_btn.Text = "UPDATE"
        Me.update_btn.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(510, 171)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(556, 256)
        Me.DataGridView1.TabIndex = 6
        '
        'load_btn
        '
        Me.load_btn.BackColor = System.Drawing.Color.Transparent
        Me.load_btn.Font = New System.Drawing.Font("Montserrat", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.load_btn.Location = New System.Drawing.Point(964, 449)
        Me.load_btn.Name = "load_btn"
        Me.load_btn.Size = New System.Drawing.Size(102, 37)
        Me.load_btn.TabIndex = 4
        Me.load_btn.Text = "LOAD"
        Me.load_btn.UseVisualStyleBackColor = False
        '
        'search_box
        '
        Me.search_box.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.search_box.Location = New System.Drawing.Point(831, 124)
        Me.search_box.Name = "search_box"
        Me.search_box.Size = New System.Drawing.Size(235, 32)
        Me.search_box.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(774, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 27)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Cari"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.arsip_surat.My.Resources.Resources.search_interface_symbol
        Me.PictureBox2.Location = New System.Drawing.Point(740, 124)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Montserrat SemiBold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(95, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(327, 39)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "FORM SURAT MASUK"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Montserrat SemiBold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(650, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(318, 39)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "DATA SURAT MASUK"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.arsip_surat.My.Resources.Resources.arsip
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1082, 583)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.exit2_btn)
        Me.Controls.Add(Me.update_btn)
        Me.Controls.Add(Me.load_btn)
        Me.Controls.Add(Me.delete_btn)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.tgl_box)
        Me.Controls.Add(Me.perihal_box)
        Me.Controls.Add(Me.pengirim_box)
        Me.Controls.Add(Me.no_box)
        Me.Controls.Add(Me.search_box)
        Me.Controls.Add(Me.idmsk_box)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Surat Masuk"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents idmsk_box As TextBox
    Friend WithEvents no_box As TextBox
    Friend WithEvents pengirim_box As TextBox
    Friend WithEvents perihal_box As TextBox
    Friend WithEvents tgl_box As DateTimePicker
    Friend WithEvents back_btn As Button
    Friend WithEvents exit2_btn As Button
    Friend WithEvents save_btn As Button
    Friend WithEvents delete_btn As Button
    Friend WithEvents update_btn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents load_btn As Button
    Friend WithEvents search_box As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
End Class
