Public Class Form_laporan

    Sub tampilLaporan()
        Call koneksi()
        cmd = New OleDb.OleDbCommand("SELECT * FROM tbl_jual", conn)
        rd = cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        Do While rd.Read = True
            DataGridView1.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4), rd(5), rd(6))
        Loop
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtPencarianLaporan.TextChanged
        cmd = New OleDb.OleDbCommand("SELECT * FROM tbl_jual WHERE tgl_jual LIKE '%" & txtPencarianLaporan.Text & "%'", conn)
        rd = cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        Do While rd.Read = True
            DataGridView1.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4), rd(5), rd(6))
        Loop
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilLaporan()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_export.ShowDialog()
    End Sub
End Class