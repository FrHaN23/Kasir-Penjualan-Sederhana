Imports System.Data.OleDb
Public Class Form_input_barang

    Sub clearBox()
        txtKodeBarang.Clear()
        txtNamaBarang.Clear()
        txtHargaBeli.Clear()
        txtHargaJual.Clear()
        txtStok.Clear()
        cmbJenisBarang.Text = ""
        cmbSatuan.Text = ""
        txtKodeBarang.Focus()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtHargaBeli.TextChanged

    End Sub

    Private Sub bttnTutup_Click(sender As Object, e As EventArgs) Handles bttnTutup.Click
        Me.Close()

    End Sub

    Private Sub bttnBersih_Click(sender As Object, e As EventArgs) Handles bttnBersih.Click
        Call clearBox()

    End Sub

    Private Sub Form_input_barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call clearBox()

    End Sub

    Private Sub bttnSimpan_Click(sender As Object, e As EventArgs) Handles bttnSimpan.Click
        'mengecek kekosongan
        If txtKodeBarang.Text = "" Or txtNamaBarang.Text = "" Or txtHargaBeli.Text = "" Or txtHargaJual.Text = "" Or txtStok.Text = "" Or cmbJenisBarang.Text = "" Or cmbSatuan.Text = "" Then
            MessageBox.Show("Data Harus Diisi!")
        Else
            cmd = New OleDbCommand("SELECT * FROM tbl_barang WHERE kode_barang= '" & txtKodeBarang.Text & "' ", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            'jika kosong
            If rd.HasRows = False Then
                'input data
                cmd = New OleDbCommand("INSERT INTO tbl_barang values ('" & txtKodeBarang.Text &
                                       "', '" & txtNamaBarang.Text &
                                       "', '" & cmbJenisBarang.Text &
                                       "','" & cmbSatuan.Text &
                                       "','" & txtHargaBeli.Text &
                                       "','" & txtHargaJual.Text &
                                       "','" & txtStok.Text &
                                       "')", conn)
                'eksekusi queri
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Disimpan")
                Call clearBox()
                Call Form_barang.tampil_barang()
                'jika kode barang ada isi, dapat di Update/edit
            Else
                'edit
                cmd = New OleDbCommand("UPDATE tbl_barang SET nama_barang='" & txtNamaBarang.Text &
                                       "',jenis_barang='" & cmbJenisBarang.Text &
                                        "',satuan_barang='" & cmbSatuan.Text &
                                        "',harga_beli='" & txtHargaBeli.Text &
                                        "',harga_jual='" & txtHargaJual.Text &
                                        "',stock='" & txtStok.Text &
                                        "' WHERE kode_barang='" & txtKodeBarang.Text & "' ", conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Diubah")
                Call clearBox()
                Call Form_barang.tampil_barang()
            End If
        End If
    End Sub

    Private Sub txtKodeBarang_TextChanged(sender As Object, e As EventArgs) Handles txtKodeBarang.TextChanged
        'panggil data
        cmd = New OleDbCommand("SELECT * FROM tbl_barang WHERE kode_barang='" & txtKodeBarang.Text & "' ", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            txtNamaBarang.Text = rd(1)
            cmbJenisBarang.Text = rd(2)
            cmbSatuan.Text = rd(3)
            txtHargaBeli.Text = rd(4)
            txtHargaJual.Text = rd(5)
            txtStok.Text = rd(6)
        Else
            txtNamaBarang.Clear()
            txtHargaBeli.Clear()
            txtHargaJual.Clear()
            txtStok.Clear()
            cmbJenisBarang.Text = ""
            cmbSatuan.Text = ""
            txtKodeBarang.Focus()
        End If
    End Sub

    Private Sub bttnHapus_Click(sender As Object, e As EventArgs) Handles bttnHapus.Click
        If MessageBox.Show("Apakah Anda ingin menghapus data?", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            cmd = New OleDbCommand("DELETE FROM tbl_barang WHERE kode_barang='" & txtKodeBarang.Text & "'", conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil dihapus.")
            Call clearBox()
            Call Form_barang.tampil_barang()
        End If

    End Sub
End Class