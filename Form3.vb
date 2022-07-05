Imports MySql.Data.MySqlClient
Public Class Form3
    Dim connect As MySqlConnection
    Dim command As MySqlCommand

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        connect = New MySqlConnection
        connect.ConnectionString =
        "server = localhost; userid = root; password = qwerty@123@321; database = arsip_surat"
        Dim reader As MySqlDataReader

        Try
            connect.Open()
            Dim query As String
            query = "insert into arsip_surat.surat_masuk (id_msk, no_surat, tgl_surat, pengirim, perihal) values ('" & idmsk_box.Text & "', '" & no_box.Text & "', '" & tgl_box.Text & "', '" & pengirim_box.Text & "', '" & perihal_box.Text & "')"
            command = New MySqlCommand(query, connect)
            reader = command.ExecuteReader

            MessageBox.Show("Data telah disimpan!")
            connect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connect.Dispose()
        End Try
        load_table()
    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        connect = New MySqlConnection
        connect.ConnectionString =
        "server = localhost; userid = root; password = qwerty@123@321; database = arsip_surat"
        Dim reader As MySqlDataReader

        Try
            connect.Open()
            Dim query As String
            query = "update arsip_surat.surat_masuk set no_surat='" & no_box.Text & "',tgl_surat='" & tgl_box.Text & "', pengirim='" & pengirim_box.Text & "', perihal='" & perihal_box.Text & "' where id_msk ='" & idmsk_box.Text & "'"
            command = New MySqlCommand(query, connect)
            reader = command.ExecuteReader

            MessageBox.Show("Data telah diperbarui!")
            connect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connect.Dispose()
        End Try
        load_table()
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        connect = New MySqlConnection
        connect.ConnectionString =
        "server = localhost; userid = root; password = qwerty@123@321; database = arsip_surat"
        Dim reader As MySqlDataReader

        Try
            connect.Open()
            Dim query As String
            query = "delete from arsip_surat.surat_masuk where id_msk ='" & idmsk_box.Text & "'"
            command = New MySqlCommand(query, connect)
            reader = command.ExecuteReader

            MessageBox.Show("Data telah dihapus!")
            connect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connect.Dispose()
        End Try
        load_table()
    End Sub

    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub load_table()
        connect = New MySqlConnection
        connect.ConnectionString =
        "server = localhost; userid = root; password = qwerty@123@321; database = arsip_surat"
        Dim adapter As New MySqlDataAdapter
        Dim datatable As New DataTable
        Dim source As New BindingSource

        Try
            connect.Open()
            Dim query As String
            query = "select id_msk as 'ID Surat Masuk', no_surat as 'Nomor Surat', tgl_surat as 'Tanggal Surat', pengirim as 'Pengirim', perihal as 'Perihal' from arsip_surat.surat_masuk"
            command = New MySqlCommand(query, connect)
            adapter.SelectCommand = command
            adapter.Fill(datatable)
            source.DataSource = datatable
            DataGridView1.DataSource = source
            adapter.Update(datatable)

            connect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connect.Dispose()
        End Try
    End Sub
    Private Sub load_btn_Click(sender As Object, e As EventArgs) Handles load_btn.Click
        connect = New MySqlConnection
        connect.ConnectionString =
        "server = localhost; userid = root; password = qwerty@123@321; database = arsip_surat"
        Dim adapter As New MySqlDataAdapter
        Dim datatable As New DataTable
        Dim source As New BindingSource

        Try
            connect.Open()
            Dim query As String
            query = "select id_msk as 'ID Surat Masuk', no_surat as 'Nomor Surat', tgl_surat as 'Tanggal Surat', pengirim as 'Pengirim', perihal as 'Perihal' from arsip_surat.surat_masuk"
            command = New MySqlCommand(query, connect)
            adapter.SelectCommand = command
            adapter.Fill(datatable)
            source.DataSource = datatable
            DataGridView1.DataSource = source
            adapter.Update(datatable)

            connect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connect.Dispose()
        End Try
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_table()
    End Sub

    Private Sub search_box_TextChanged(sender As Object, e As EventArgs) Handles search_box.TextChanged
        Dim datatable As New DataTable
        Dim view As New DataView(DataTable)
        view.RowFilter = String.Format("perihal Like '%{0}%'", search_box.Text)
        DataGridView1.DataSource = view
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)

            idmsk_box.Text = row.Cells("ID Surat Masuk").Value.ToString
            no_box.Text = row.Cells("Nomor Surat").Value.ToString
            pengirim_box.Text = row.Cells("Pengirim").Value.ToString
            perihal_box.Text = row.Cells("Perihal").Value.ToString
        End If
    End Sub
    Private Sub exit2_btn_Click(sender As Object, e As EventArgs) Handles exit2_btn.Click
        If MessageBox.Show("Apakah anda yakin akan menutup aplikasi?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Apakah anda yakin akan menutup aplikasi?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub

End Class