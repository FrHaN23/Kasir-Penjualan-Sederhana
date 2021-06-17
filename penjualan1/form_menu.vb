Public Class form_menu
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If MessageBox.Show("Apakah Anda ingin Log out?", "Log out", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
            Form_login.txtUsername.Clear()
            Form_login.txtPassword.Clear()
            Form_login.Show()
            Form_login.txtUsername.Focus()
        End If
    End Sub

    Private Sub bttnBarang_Click(sender As Object, e As EventArgs)
        Form_barang.ShowDialog()
    End Sub

    Private Sub bttnPenjualan_Click(sender As Object, e As EventArgs)
        Form_penjualan.ShowDialog()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click


    End Sub

    Private Sub bttnUser_Click(sender As Object, e As EventArgs)
        Form_user.ShowDialog()

    End Sub

    Private Sub form_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If lblLevelUser.Text = "Kasir" Then
            PictureBox1.Enabled = False
            PictureBox4.Enabled = False

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

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter

    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.Image = My.Resources.btn_data_barang1_hover1
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = My.Resources.btn_data_barang1_fix

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form_barang.ShowDialog()
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        PictureBox2.Image = My.Resources.btn_kasir_hover
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Image = My.Resources.btn_kasir
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form_penjualan.ShowDialog()
    End Sub

    Private Sub PictureBox4_MouseHover(sender As Object, e As EventArgs) Handles PictureBox4.MouseHover
        PictureBox4.Image = My.Resources.btn_user_hover
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Image = My.Resources.btn_user
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Form_user.ShowDialog()
    End Sub
End Class