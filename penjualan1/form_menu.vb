Public Class form_menu
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        End
    End Sub

    Private Sub bttnBarang_Click(sender As Object, e As EventArgs) Handles bttnBarang.Click
        Form_barang.ShowDialog()
    End Sub

    Private Sub bttnPenjualan_Click(sender As Object, e As EventArgs) Handles bttnPenjualan.Click
        Form_penjualan.ShowDialog()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Form_profile.ShowDialog()

    End Sub

    Private Sub bttnUser_Click(sender As Object, e As EventArgs) Handles bttnUser.Click
        Form_user.ShowDialog()

    End Sub

    Private Sub form_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If lblLevelUser.Text = "Kasir" Then
            bttnBarang.Enabled = False
            bttnUser.Enabled = False

        End If
    End Sub

    Private Sub bttnLogout_Click(sender As Object, e As EventArgs) Handles bttnLogout.Click
        If MessageBox.Show("Apakah Anda ingin Log out?", "Log out", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
            Form_login.txtUsername.Clear()
            Form_login.txtPassword.Clear()
            Form_login.Show()
            Form_login.txtUsername.Focus()


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End

    End Sub
End Class