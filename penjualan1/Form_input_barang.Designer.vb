<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_input_barang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtKodeBarang = New System.Windows.Forms.TextBox()
        Me.txtNamaBarang = New System.Windows.Forms.TextBox()
        Me.txtHargaBeli = New System.Windows.Forms.TextBox()
        Me.txtHargaJual = New System.Windows.Forms.TextBox()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.cmbJenisBarang = New System.Windows.Forms.ComboBox()
        Me.cmbSatuan = New System.Windows.Forms.ComboBox()
        Me.bttnSimpan = New System.Windows.Forms.Button()
        Me.bttnHapus = New System.Windows.Forms.Button()
        Me.bttnBersih = New System.Windows.Forms.Button()
        Me.bttnTutup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(367, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 37)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Input Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 24)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Kode Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 24)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Nama Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 24)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Jenis Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(44, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 24)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Satuan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(44, 273)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 24)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Harga Beli"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(44, 315)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 24)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Harga Jual"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(44, 363)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 24)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Stok"
        '
        'txtKodeBarang
        '
        Me.txtKodeBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeBarang.Location = New System.Drawing.Point(214, 71)
        Me.txtKodeBarang.Name = "txtKodeBarang"
        Me.txtKodeBarang.Size = New System.Drawing.Size(266, 29)
        Me.txtKodeBarang.TabIndex = 17
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaBarang.Location = New System.Drawing.Point(214, 128)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.Size = New System.Drawing.Size(378, 29)
        Me.txtNamaBarang.TabIndex = 18
        '
        'txtHargaBeli
        '
        Me.txtHargaBeli.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHargaBeli.Location = New System.Drawing.Point(214, 273)
        Me.txtHargaBeli.Name = "txtHargaBeli"
        Me.txtHargaBeli.Size = New System.Drawing.Size(174, 29)
        Me.txtHargaBeli.TabIndex = 21
        '
        'txtHargaJual
        '
        Me.txtHargaJual.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHargaJual.Location = New System.Drawing.Point(214, 315)
        Me.txtHargaJual.Name = "txtHargaJual"
        Me.txtHargaJual.Size = New System.Drawing.Size(174, 29)
        Me.txtHargaJual.TabIndex = 22
        '
        'txtStok
        '
        Me.txtStok.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStok.Location = New System.Drawing.Point(214, 358)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(126, 29)
        Me.txtStok.TabIndex = 23
        '
        'cmbJenisBarang
        '
        Me.cmbJenisBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbJenisBarang.FormattingEnabled = True
        Me.cmbJenisBarang.Items.AddRange(New Object() {"Makanan", "Minuman", "ATK", "Kebutuhan Pokok", "Kebutuhan Dapur", "Peralatan Rumah Tangga", "Kebersihan", "Ciki"})
        Me.cmbJenisBarang.Location = New System.Drawing.Point(214, 173)
        Me.cmbJenisBarang.Name = "cmbJenisBarang"
        Me.cmbJenisBarang.Size = New System.Drawing.Size(266, 32)
        Me.cmbJenisBarang.TabIndex = 24
        '
        'cmbSatuan
        '
        Me.cmbSatuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSatuan.FormattingEnabled = True
        Me.cmbSatuan.Items.AddRange(New Object() {"PCS", "Lusin", "Renceng", "Toples", "kodi", "Bungkus", "Pack"})
        Me.cmbSatuan.Location = New System.Drawing.Point(214, 221)
        Me.cmbSatuan.Name = "cmbSatuan"
        Me.cmbSatuan.Size = New System.Drawing.Size(174, 32)
        Me.cmbSatuan.TabIndex = 25
        '
        'bttnSimpan
        '
        Me.bttnSimpan.BackgroundImage = Global.penjualan1.My.Resources.Resources.Warna
        Me.bttnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSimpan.ForeColor = System.Drawing.Color.White
        Me.bttnSimpan.Location = New System.Drawing.Point(45, 409)
        Me.bttnSimpan.Name = "bttnSimpan"
        Me.bttnSimpan.Size = New System.Drawing.Size(170, 47)
        Me.bttnSimpan.TabIndex = 26
        Me.bttnSimpan.Text = "Simpan"
        Me.bttnSimpan.UseVisualStyleBackColor = True
        '
        'bttnHapus
        '
        Me.bttnHapus.BackgroundImage = Global.penjualan1.My.Resources.Resources.Warna
        Me.bttnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnHapus.ForeColor = System.Drawing.Color.White
        Me.bttnHapus.Location = New System.Drawing.Point(272, 409)
        Me.bttnHapus.Name = "bttnHapus"
        Me.bttnHapus.Size = New System.Drawing.Size(170, 47)
        Me.bttnHapus.TabIndex = 27
        Me.bttnHapus.Text = "Hapus"
        Me.bttnHapus.UseVisualStyleBackColor = True
        '
        'bttnBersih
        '
        Me.bttnBersih.BackgroundImage = Global.penjualan1.My.Resources.Resources.Warna
        Me.bttnBersih.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnBersih.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnBersih.ForeColor = System.Drawing.Color.White
        Me.bttnBersih.Location = New System.Drawing.Point(490, 409)
        Me.bttnBersih.Name = "bttnBersih"
        Me.bttnBersih.Size = New System.Drawing.Size(170, 47)
        Me.bttnBersih.TabIndex = 28
        Me.bttnBersih.Text = "Bersihkan"
        Me.bttnBersih.UseVisualStyleBackColor = True
        '
        'bttnTutup
        '
        Me.bttnTutup.BackgroundImage = Global.penjualan1.My.Resources.Resources.Warna
        Me.bttnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnTutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnTutup.ForeColor = System.Drawing.Color.White
        Me.bttnTutup.Location = New System.Drawing.Point(710, 409)
        Me.bttnTutup.Name = "bttnTutup"
        Me.bttnTutup.Size = New System.Drawing.Size(170, 47)
        Me.bttnTutup.TabIndex = 29
        Me.bttnTutup.Text = "Tutup"
        Me.bttnTutup.UseVisualStyleBackColor = True
        '
        'Form_input_barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.penjualan1.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(951, 539)
        Me.Controls.Add(Me.bttnTutup)
        Me.Controls.Add(Me.bttnBersih)
        Me.Controls.Add(Me.bttnHapus)
        Me.Controls.Add(Me.bttnSimpan)
        Me.Controls.Add(Me.cmbSatuan)
        Me.Controls.Add(Me.cmbJenisBarang)
        Me.Controls.Add(Me.txtStok)
        Me.Controls.Add(Me.txtHargaJual)
        Me.Controls.Add(Me.txtHargaBeli)
        Me.Controls.Add(Me.txtNamaBarang)
        Me.Controls.Add(Me.txtKodeBarang)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form_input_barang"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Barang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtKodeBarang As TextBox
    Friend WithEvents txtNamaBarang As TextBox
    Friend WithEvents txtHargaBeli As TextBox
    Friend WithEvents txtHargaJual As TextBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents cmbJenisBarang As ComboBox
    Friend WithEvents cmbSatuan As ComboBox
    Friend WithEvents bttnSimpan As Button
    Friend WithEvents bttnHapus As Button
    Friend WithEvents bttnBersih As Button
    Friend WithEvents bttnTutup As Button
End Class
