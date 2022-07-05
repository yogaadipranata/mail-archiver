Imports MySql.Data.MySqlClient
Public Class Form1
    Dim connect As MySqlConnection
    Dim command As MySqlCommand
    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        connect = New MySqlConnection
        connect.ConnectionString =
        "server = localhost; userid = root; password = qwerty@123@321; database = arsip_surat"
        Dim reader As MySqlDataReader

        Try
            connect.Open()
            Dim query As String
            query = "select * from arsip_surat.login where username ='" & name_box.Text & "' and password = '" & pass_box.Text & "'"
            command = New MySqlCommand(query, connect)
            reader = command.ExecuteReader

            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While

            If count = 1 Then
                MessageBox.Show("Selamat Datang di Sistem Informasi Arsip Surat")
                Form2.Show()
                Me.Hide()
            Else
                MessageBox.Show("Data Yang Anda Masukkan Salah!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connect.Dispose()
        End Try
    End Sub

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        If MessageBox.Show("Apakah anda yakin akan menutup aplikasi?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Apakah anda yakin akan menutup aplikasi?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            pass_box.UseSystemPasswordChar = False
        Else
            pass_box.UseSystemPasswordChar = True
        End If
    End Sub
End Class
