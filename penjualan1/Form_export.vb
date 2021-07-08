Public Class Form_export

    Sub tampilExport()
        Call koneksi()

        cmd = New OleDb.OleDbCommand("SELECT * FROM tbl_jual WHERE tgl_jual LIKE '%" & Form_laporan.txtPencarianLaporan.Text & "%'", conn)
        rd = cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        Do While rd.Read = True
            DataGridView1.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4), rd(5), rd(6))
        Loop
    End Sub

    Private Sub Form_export_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilExport()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub
End Class