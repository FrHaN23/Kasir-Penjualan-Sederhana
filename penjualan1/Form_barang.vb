Imports System.Data.OleDb
Public Class Form_barang
    Sub tampil_barang()
        Call koneksi()
        cmd = New OleDb.OleDbCommand("SELECT * FROM tbl_barang", conn)
        rd = cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        Do While rd.Read = True
            DataGridView1.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4), rd(5), rd(6))
        Loop
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        End
    End Sub

    Private Sub bttnTutup_Click(sender As Object, e As EventArgs) Handles bttnTutup.Click
        Me.Close()

    End Sub

    Private Sub Form_barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampil_barang()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        cmd = New OleDb.OleDbCommand("SELECT * FROM tbl_barang WHERE nama_barang LIKE '%" & txtCari.Text & "%'", conn)
        rd = cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        Do While rd.Read = True
            DataGridView1.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4), rd(5), rd(6))
        Loop
    End Sub

    Private Sub bttnTambah_Click(sender As Object, e As EventArgs) Handles bttnTambah.Click
        Form_input_barang.ShowDialog()


    End Sub
End Class