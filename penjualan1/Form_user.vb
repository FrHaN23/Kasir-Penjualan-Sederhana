Imports System.Data.OleDb
Imports BCrypt
Public Class Form_user
    Private Sub bttnSimpan_Click(sender As Object, e As EventArgs) Handles bttnSimpan.Click
        If txtKodeUser.Text = "" Or txtNamaUser.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Or cmbLevel.Text = "" Then
            MessageBox.Show("Data Harus Diisi!")
        Else
            cmd = New OleDbCommand("SELECT * FROM tbl_user WHERE kode_user= @kodeUser", conn)
            cmd.Parameters.AddWithValue("@kodeUser", txtKodeUser.Text)
            rd = cmd.ExecuteReader
            rd.Read()
            Dim passwordHash As Object = Net.BCrypt.HashPassword(txtPassword.Text)
            'jika kosong
            If rd.HasRows = False Then

                'input data
                cmd = New OleDbCommand("INSERT INTO tbl_user values (@kodeUser, @namaUser, @userName,@passWord,@level)", conn)
                cmd.Parameters.AddWithValue("@kodeUser", txtKodeUser.Text)
                cmd.Parameters.AddWithValue("@namaUser", txtNamaUser.Text)
                cmd.Parameters.AddWithValue("@userName", txtUsername.Text)
                cmd.Parameters.AddWithValue("@passWord", passwordHash)
                cmd.Parameters.AddWithValue("@level", cmbLevel.Text)
                'eksekusi queri
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Disimpan")
                Call bersih()
                Call tampil_user()

            Else
                'edit
                cmd = New OleDbCommand("UPDATE tbl_user SET nama_user=@namaUser,user_name=@userName,pwd=@passWord,lvl=@level
                                        WHERE kode_user=@kodeUser", conn)
                cmd.Parameters.AddWithValue("@kodeUser", txtKodeUser.Text)
                cmd.Parameters.AddWithValue("@namaUser", txtNamaUser.Text)
                cmd.Parameters.AddWithValue("@passWord", passwordHash)
                cmd.Parameters.AddWithValue("@level", cmbLevel.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Diubah")
                Call bersih()
                Call tampil_user()
            End If
        End If
    End Sub

    Private Sub bttnTutup_Click(sender As Object, e As EventArgs) Handles bttnTutup.Click
        Me.Close()
    End Sub

    Sub tampil_user()
        Call koneksi()
        cmd = New OleDbCommand("SELECT * FROM tbl_user", conn)
        rd = cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        Do While rd.Read = True
            DataGridView1.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4))
        Loop
    End Sub
    Sub bersih()
        txtKodeUser.Clear()
        txtNamaUser.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        cmbLevel.Text = ""
        txtKodeUser.Focus()

    End Sub

    Private Sub Form_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampil_user()
        Call bersih()
    End Sub

    Private Sub bttnBersih_Click(sender As Object, e As EventArgs) Handles bttnBersih.Click
        Call bersih()
    End Sub

    Private Sub txtKodeUser_TextChanged(sender As Object, e As EventArgs) Handles txtKodeUser.TextChanged
        'panggil data
        cmd = New OleDbCommand("SELECT * FROM tbl_user WHERE kode_user=@kodeUser", conn)
        cmd.Parameters.AddWithValue("@kodeUser", txtKodeUser.Text)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            txtNamaUser.Text = rd(1)
            txtUsername.Text = rd(2)
            cmbLevel.Text = rd(4)
        Else
            txtNamaUser.Clear()
            txtUsername.Clear()
            txtPassword.Clear()
            cmbLevel.Text = ""
            txtKodeUser.Focus()
        End If
    End Sub

    Private Sub bttnHapus_Click(sender As Object, e As EventArgs) Handles bttnHapus.Click
        If MessageBox.Show("Apakah Anda ingin menghapus data?", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            cmd = New OleDbCommand("DELETE FROM tbl_user WHERE kode_user=@kodeUser", conn)
            cmd.Parameters.AddWithValue("@kodeUser", txtKodeUser.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil dihapus.")
            Call bersih()
            Call tampil_user()
        End If
    End Sub

End Class