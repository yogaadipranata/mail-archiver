Imports MySql.Data.MySqlClient
Public Class Form4
    Dim connect As MySqlConnection
    Dim command As MySqlCommand

    Private Sub save_btn_Click_1(sender As Object, e As EventArgs) Handles save_btn.Click
        connect = New MySqlConnection
        connect.ConnectionString =
        "server = localhost; userid = root; password = qwerty@123@321; database = arsip_surat"
        Dim reader As MySqlDataReader

        Try
            connect.Open()
            Dim query As String
            query = "insert into arsip_surat.surat_keluar (id_klr, no_surat, tgl_surat, penerima, perihal) values ('" & idklr_box.Text & "', '" & no_box.Text & "', '" & tgl_box.Text & "', '" & penerima_box.Text & "', '" & perihal_box.Text & "')"
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

    Private Sub update_btn_Click_1(sender As Object, e As EventArgs) Handles update_btn.Click
        connect = New MySqlConnection
        connect.ConnectionString =
        "server = localhost; userid = root; password = qwerty@123@321; database = arsip_surat"
        Dim reader As MySqlDataReader

        Try
            connect.Open()
            Dim query As String
            query = "update arsip_surat.surat_keluar set no_surat='" & no_box.Text & "',tgl_surat='" & tgl_box.Text & "', penerima='" & penerima_box.Text & "', perihal='" & perihal_box.Text & "' where id_klr ='" & idklr_box.Text & "'"
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
            query = "delete from arsip_surat.surat_keluar where id_klr ='" & idklr_box.Text & "'"
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
            query = "select id_klr as 'ID Surat Keluar', no_surat as 'Nomor Surat', tgl_surat as 'Tanggal Surat', penerima as 'Penerima', perihal as 'Perihal' from arsip_surat.surat_keluar"
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
            query = "select id_klr as 'ID Surat Keluar', no_surat as 'Nomor Surat', tgl_surat as 'Tanggal Surat', penerima as 'Penerima', perihal as 'Perihal' from arsip_surat.surat_keluar"
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

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            idklr_box.Text = row.Cells("ID Surat Keluar").Value.ToString
            no_box.Text = row.Cells("Nomor Surat").Value.ToString
            penerima_box.Text = row.Cells("Penerima").Value.ToString
            perihal_box.Text = row.Cells("Perihal").Value.ToString
        End If
    End Sub

    Private Sub exit2_btn_Click(sender As Object, e As EventArgs) Handles exit2_btn.Click
        If MessageBox.Show("Apakah anda yakin akan menutup aplikasi?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub Form4_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Apakah anda yakin akan menutup aplikasi?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub


End Class