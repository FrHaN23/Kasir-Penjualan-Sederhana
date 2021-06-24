Imports System.Data.OleDb
Imports BCrypt
Public Class Form_login
    Private Sub bttnHapus_Click(sender As Object, e As EventArgs) Handles bttnHapus.Click
        End
    End Sub
    Sub login()
        Call koneksi()
        cmd = New OleDbCommand("SELECT * FROM tbl_user WHERE user_name ='" & txtUsername.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        Dim isHashedPassValid As Boolean = Net.BCrypt.Verify(txtPassword.Text, rd.Item("pwd"))
        If rd.HasRows = True And isHashedPassValid = True Then
            form_menu.lblNamaUser.Text = rd.Item("nama_user")
            form_menu.lblLevelUser.Text = rd.Item("lvl")
            Me.Hide()
            form_menu.Show()
        Else
            MessageBox.Show("Username/Password anda masukkan salah.")
        End If

    End Sub

    Private Sub bttnSimpan_Click(sender As Object, e As EventArgs) Handles bttnSimpan.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Silakan Masukan Username dan Password")
        Else
            Call login()
        End If

    End Sub



    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If e.KeyChar = Chr(13) Then
            Call login()
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            Call login()
        End If
    End Sub

    Private Sub Form_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Clear()
        txtPassword.Clear()
        txtUsername.Focus()
    End Sub
End Class