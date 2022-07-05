<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.exit2_btn = New System.Windows.Forms.Button()
        Me.update_btn = New System.Windows.Forms.Button()
        Me.load_btn = New System.Windows.Forms.Button()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.back_btn = New System.Windows.Forms.Button()
        Me.tgl_box = New System.Windows.Forms.DateTimePicker()
        Me.perihal_box = New System.Windows.Forms.TextBox()
        Me.penerima_box = New System.Windows.Forms.TextBox()
        Me.no_box = New System.Windows.Forms.TextBox()
        Me.search_box = New System.Windows.Forms.TextBox()
        Me.idklr_box = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Montserrat SemiBold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(642, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(329, 39)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "DATA SURAT KELUAR"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Montserrat SemiBold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(87, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(338, 39)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "FORM SURAT KELUAR"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.arsip_surat.My.Resources.Resources.search_interface_symbol
        Me.PictureBox2.Location = New System.Drawing.Point(739, 124)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(509, 171)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(556, 256)
        Me.DataGridView1.TabIndex = 27
        '
        'exit2_btn
        '
        Me.exit2_btn.Font = New System.Drawing.Font("Montserrat", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.exit2_btn.Location = New System.Drawing.Point(963, 526)
        Me.exit2_btn.Name = "exit2_btn"
        Me.exit2_btn.Size = New System.Drawing.Size(102, 37)
        Me.exit2_btn.TabIndex = 26
        Me.exit2_btn.Text = "EXIT"
        Me.exit2_btn.UseVisualStyleBackColor = True
        '
        'update_btn
        '
        Me.update_btn.BackColor = System.Drawing.Color.Transparent
        Me.update_btn.Font = New System.Drawing.Font("Montserrat", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.update_btn.Location = New System.Drawing.Point(198, 449)
        Me.update_btn.Name = "update_btn"
        Me.update_btn.Size = New System.Drawing.Size(102, 37)
        Me.update_btn.TabIndex = 24
        Me.update_btn.Text = "UPDATE"
        Me.update_btn.UseVisualStyleBackColor = False
        '
        'load_btn
        '
        Me.load_btn.BackColor = System.Drawing.Color.Transparent
        Me.load_btn.Font = New System.Drawing.Font("Montserrat", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.load_btn.Location = New System.Drawing.Point(963, 449)
        Me.load_btn.Name = "load_btn"
        Me.load_btn.Size = New System.Drawing.Size(102, 37)
        Me.load_btn.TabIndex = 23
        Me.load_btn.Text = "LOAD"
        Me.load_btn.UseVisualStyleBackColor = False
        '
        'delete_btn
        '
        Me.delete_btn.BackColor = System.Drawing.Color.Transparent
        Me.delete_btn.Font = New System.Drawing.Font("Montserrat", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.delete_btn.Location = New System.Drawing.Point(365, 449)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(102, 37)
        Me.delete_btn.TabIndex = 22
        Me.delete_btn.Text = "DELETE"
        Me.delete_btn.UseVisualStyleBackColor = False
        '
        'save_btn
        '
        Me.save_btn.BackColor = System.Drawing.Color.Transparent
        Me.save_btn.Font = New System.Drawing.Font("Montserrat", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.save_btn.Location = New System.Drawing.Point(17, 449)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(102, 37)
        Me.save_btn.TabIndex = 21
        Me.save_btn.Text = "SAVE"
        Me.save_btn.UseVisualStyleBackColor = False
        '
        'back_btn
        '
        Me.back_btn.BackColor = System.Drawing.Color.Transparent
        Me.back_btn.Font = New System.Drawing.Font("Montserrat", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.back_btn.Location = New System.Drawing.Point(17, 526)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(102, 37)
        Me.back_btn.TabIndex = 25
        Me.back_btn.Text = "BACK"
        Me.back_btn.UseVisualStyleBackColor = False
        '
        'tgl_box
        '
        Me.tgl_box.CustomFormat = "yyyy-MM-dd"
        Me.tgl_box.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tgl_box.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tgl_box.Location = New System.Drawing.Point(199, 257)
        Me.tgl_box.Name = "tgl_box"
        Me.tgl_box.Size = New System.Drawing.Size(268, 32)
        Me.tgl_box.TabIndex = 20
        Me.tgl_box.Value = New Date(2022, 6, 1, 0, 0, 0, 0)
        '
        'perihal_box
        '
        Me.perihal_box.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.perihal_box.Location = New System.Drawing.Point(199, 395)
        Me.perihal_box.Name = "perihal_box"
        Me.perihal_box.Size = New System.Drawing.Size(268, 32)
        Me.perihal_box.TabIndex = 19
        '
        'penerima_box
        '
        Me.penerima_box.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.penerima_box.Location = New System.Drawing.Point(199, 327)
        Me.penerima_box.Name = "penerima_box"
        Me.penerima_box.Size = New System.Drawing.Size(268, 32)
        Me.penerima_box.TabIndex = 18
        '
        'no_box
        '
        Me.no_box.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.no_box.Location = New System.Drawing.Point(199, 192)
        Me.no_box.Name = "no_box"
        Me.no_box.Size = New System.Drawing.Size(268, 32)
        Me.no_box.TabIndex = 17
        '
        'search_box
        '
        Me.search_box.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.search_box.Location = New System.Drawing.Point(830, 124)
        Me.search_box.Name = "search_box"
        Me.search_box.Size = New System.Drawing.Size(235, 32)
        Me.search_box.TabIndex = 16
        '
        'idklr_box
        '
        Me.idklr_box.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.idklr_box.Location = New System.Drawing.Point(199, 124)
        Me.idklr_box.Name = "idklr_box"
        Me.idklr_box.Size = New System.Drawing.Size(268, 32)
        Me.idklr_box.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(17, 398)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 27)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Perihal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(17, 330)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 27)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Penerima"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(17, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 27)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Tanggal Surat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(17, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 27)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nomor Surat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(773, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 27)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Cari"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(17, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 27)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ID Surat Keluar"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.arsip_surat.My.Resources.Resources.keluar
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
        Me.Controls.Add(Me.penerima_box)
        Me.Controls.Add(Me.no_box)
        Me.Controls.Add(Me.search_box)
        Me.Controls.Add(Me.idklr_box)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Surat Keluar"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents exit2_btn As Button
    Friend WithEvents update_btn As Button
    Friend WithEvents load_btn As Button
    Friend WithEvents delete_btn As Button
    Friend WithEvents save_btn As Button
    Friend WithEvents back_btn As Button
    Friend WithEvents tgl_box As DateTimePicker
    Friend WithEvents perihal_box As TextBox
    Friend WithEvents penerima_box As TextBox
    Friend WithEvents no_box As TextBox
    Friend WithEvents search_box As TextBox
    Friend WithEvents idklr_box As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
End Class
