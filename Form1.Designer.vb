<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.login_btn = New System.Windows.Forms.Button()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.name_box = New System.Windows.Forms.TextBox()
        Me.pass_box = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'login_btn
        '
        Me.login_btn.BackColor = System.Drawing.Color.Transparent
        Me.login_btn.Font = New System.Drawing.Font("Montserrat", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.login_btn.Location = New System.Drawing.Point(498, 416)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(102, 37)
        Me.login_btn.TabIndex = 0
        Me.login_btn.Text = "LOGIN"
        Me.login_btn.UseVisualStyleBackColor = False
        '
        'exit_btn
        '
        Me.exit_btn.Font = New System.Drawing.Font("Montserrat", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.exit_btn.Location = New System.Drawing.Point(705, 416)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(102, 37)
        Me.exit_btn.TabIndex = 0
        Me.exit_btn.Text = "EXIT"
        Me.exit_btn.UseVisualStyleBackColor = True
        '
        'name_box
        '
        Me.name_box.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.name_box.Location = New System.Drawing.Point(547, 224)
        Me.name_box.Name = "name_box"
        Me.name_box.Size = New System.Drawing.Size(260, 32)
        Me.name_box.TabIndex = 2
        '
        'pass_box
        '
        Me.pass_box.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pass_box.Location = New System.Drawing.Point(547, 312)
        Me.pass_box.Name = "pass_box"
        Me.pass_box.Size = New System.Drawing.Size(260, 32)
        Me.pass_box.TabIndex = 2
        Me.pass_box.UseSystemPasswordChar = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Montserrat", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckBox1.Location = New System.Drawing.Point(642, 352)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(177, 29)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.arsip_surat.My.Resources.Resources.ui1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(835, 497)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.pass_box)
        Me.Controls.Add(Me.name_box)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.login_btn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents login_btn As Button
    Friend WithEvents exit_btn As Button
    Friend WithEvents name_box As TextBox
    Friend WithEvents pass_box As TextBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
