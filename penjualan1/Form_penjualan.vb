﻿Imports System.Data.OleDb

Public Class Form_penjualan

    Sub no_faktur()
        cmd = New OleDbCommand("SELECT * FROM tbl_jual WHERE faktur_jual in(SELECT MAX(faktur_jual) FROM tbl_jual) ORDER BY faktur_jual DESC", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            txtNoFaktur.Text = Format(Now, "yyMMdd") + "0001"
        Else
            If Microsoft.VisualBasic.Left(rd.GetString(0), 6) <> Format(Now, "yyMMdd") Then
                txtNoFaktur.Text = Format(Now, "yyMMdd") + "0001"
            Else
                txtNoFaktur.Text = rd.Item("faktur_jual") + 1

            End If
        End If


    End Sub
    Sub grandTotal()
        Dim jumlah As Decimal = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            jumlah = jumlah + DataGridView1.Rows(i).Cells(6).Value
            txtGrandTotal.Text = jumlah

        Next
        If txtGrandTotal.Text = "" Then
            txtGrandTotal.Text = "0"
        End If


    End Sub
    Sub kotakBersih()
        txtKodeBarang.Clear()
        txtNamaBarang.Clear()
        txtJenisBarang.Clear()
        txtSatuan.Clear()
        txtHarga.Clear()
        TxtQty.Clear()
        txtTotalHarga.Clear()
        txtKodeBarang.Focus()

    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        End
    End Sub

    Private Sub GrpBoxTransaksi_Enter(sender As Object, e As EventArgs) Handles GrpBoxTransaksi.Enter

    End Sub

    Private Sub bttnTutup_Click(sender As Object, e As EventArgs) Handles bttnTutup.Click
        Me.Close()
    End Sub

    Private Sub Form_penjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDibayar.Text = "0"
        txtKembalian.Text = "0"
        Call koneksi()
        Call no_faktur()
        txtKodeBarang.Focus()
        Call grandTotal()
        txtKasir.Text = form_menu.lblNamaUser.Text

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtTanggal.Text = Format(Now, "dd/MM/yyyy")
        txtJam.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub txtKodeBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeBarang.KeyPress
        If e.KeyChar = Chr(13) Then
            cmd = New OleDbCommand("SELECT * FROM tbl_barang WHERE kode_barang= '" & txtKodeBarang.Text & "' ", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                txtNamaBarang.Text = rd("nama_barang")
                txtJenisBarang.Text = rd("jenis_barang")
                txtSatuan.Text = rd("satuan_barang")
                txtHarga.Text = rd("harga_jual")
                TxtQty.Focus()
            Else
                Call kotakBersih()


                MessageBox.Show("barang tidak ditemukan.")

            End If
        End If
    End Sub





    Private Sub TxtQty_TextChanged(sender As Object, e As EventArgs) Handles TxtQty.TextChanged
        Try
            txtTotalHarga.Text = Val(TxtQty.Text) * Val(txtHarga.Text)

        Catch ex As Exception
            txtTotalHarga.Text = ""
        End Try
    End Sub

    Private Sub TxtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtQty.KeyPress
        If e.KeyChar = Chr(13) Then
            DataGridView1.Rows.Add(txtKodeBarang.Text, txtNamaBarang.Text, txtJenisBarang.Text, txtSatuan.Text, txtHarga.Text, TxtQty.Text, txtTotalHarga.Text)
            Call kotakBersih()
            Call grandTotal()


        End If
    End Sub

    Private Sub txtDibayar_TextChanged(sender As Object, e As EventArgs) Handles txtDibayar.TextChanged
        Try
            Dim kembalian As Decimal
            kembalian = Val(txtDibayar.Text) - Val(txtGrandTotal.Text)
            txtKembalian.Text = kembalian


        Catch ex As Exception

        End Try
    End Sub

    Private Sub bttnSimpan_Click(sender As Object, e As EventArgs) Handles bttnSimpan.Click
        If txtGrandTotal.Text = "0" Then
            MessageBox.Show("Tidak ada barang diinput")
        Else
            If Val(txtDibayar.Text) < Val(txtGrandTotal.Text) Then
                MessageBox.Show("Pembayaran Masih Kurang")
            Else
                Call koneksi()
                cmd = New OleDbCommand("INSERT INTO tbl_jual(faktur_jual,tgl_jual,jam,grand_total,dibayar,kembalian,kasir) values('" & txtNoFaktur.Text &
                                       "','" & txtTanggal.Text & "','" & txtJam.Text & "','" & txtGrandTotal.Text & "','" & txtDibayar.Text & "','" & txtKembalian.Text & "','" & txtKasir.Text & "')", conn)
                cmd.ExecuteNonQuery()
                For baris As Integer = 0 To DataGridView1.Rows.Count - 2
                    cmd = New OleDbCommand("INSERT INTO tbl_rinci_jual VALUES('" & txtNoFaktur.Text & "', '" & DataGridView1.Rows(baris).Cells(0).Value & "', '" & DataGridView1.Rows(baris).Cells(5).Value &
                                           "', '" & DataGridView1.Rows(baris).Cells(6).Value & "')", conn)
                    cmd.ExecuteNonQuery()
                    'stok dikurang
                    cmd = New OleDbCommand("SELECT * FROM tbl_barang WHERE kode_barang='" & DataGridView1.Rows(baris).Cells(0).Value & "' ", conn)
                    rd = cmd.ExecuteReader
                    rd.Read()
                    If rd.HasRows = True Then
                        cmd = New OleDbCommand("UPDATE tbl_barang SET stock='" & rd.Item("stock") - Val(DataGridView1.Rows(baris).Cells(5).Value) &
                                               "' WHERE kode_barang='" & DataGridView1.Rows(baris).Cells(0).Value & "'", conn)
                        cmd.ExecuteNonQuery()
                    End If
                Next
                MessageBox.Show("Transaksi berhasil disimpan")
                DataGridView1.Rows.Clear()
                txtGrandTotal.Text = "0"
                txtKembalian.Text = "0"
                txtDibayar.Text = "0"
                Call no_faktur()
                Call kotakBersih()

            End If

        End If
    End Sub

    Private Sub DataGridView1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DataGridView1.KeyPress
        If e.KeyChar = Chr(27) Then
            Dim baris As Integer
            baris = DataGridView1.CurrentCell.RowIndex
            Try
                DataGridView1.Rows.RemoveAt(baris)
                Call grandTotal()

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txtDibayar_Click(sender As Object, e As EventArgs) Handles txtDibayar.Click
        txtDibayar.Text = ""
    End Sub
End Class