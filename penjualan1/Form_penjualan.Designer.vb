<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_penjualan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GrpBoxGrand = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtGrandTotal = New System.Windows.Forms.TextBox()
        Me.GrpBoxTransaksi = New System.Windows.Forms.GroupBox()
        Me.txtKasir = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTanggal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtJam = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoFaktur = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GrpBoxPembayaran = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.bttnHapus = New System.Windows.Forms.Button()
        Me.bttnTutup = New System.Windows.Forms.Button()
        Me.txtKembalian = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bttnSimpan = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDibayar = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtKodeBarang = New System.Windows.Forms.TextBox()
        Me.txtNamaBarang = New System.Windows.Forms.TextBox()
        Me.txtJenisBarang = New System.Windows.Forms.TextBox()
        Me.txtSatuan = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.TxtQty = New System.Windows.Forms.TextBox()
        Me.txtTotalHarga = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GrpBoxGrand.SuspendLayout()
        Me.GrpBoxTransaksi.SuspendLayout()
        Me.GrpBoxPembayaran.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button7
        '
        Me.Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button7.BackgroundImage = Global.penjualan1.My.Resources.Resources.Warna
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(2457, -1)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(38, 38)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "X"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.penjualan1.My.Resources.Resources.bg_menu5
        Me.GroupBox1.Controls.Add(Me.GrpBoxGrand)
        Me.GroupBox1.Controls.Add(Me.GrpBoxTransaksi)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1386, 182)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'GrpBoxGrand
        '
        Me.GrpBoxGrand.BackgroundImage = Global.penjualan1.My.Resources.Resources.bg_menu5
        Me.GrpBoxGrand.Controls.Add(Me.Label16)
        Me.GrpBoxGrand.Controls.Add(Me.txtGrandTotal)
        Me.GrpBoxGrand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpBoxGrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBoxGrand.ForeColor = System.Drawing.Color.White
        Me.GrpBoxGrand.Location = New System.Drawing.Point(495, 22)
        Me.GrpBoxGrand.Name = "GrpBoxGrand"
        Me.GrpBoxGrand.Size = New System.Drawing.Size(888, 157)
        Me.GrpBoxGrand.TabIndex = 9
        Me.GrpBoxGrand.TabStop = False
        Me.GrpBoxGrand.Text = "Grand Total"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Black
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 80.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Lime
        Me.Label16.Location = New System.Drawing.Point(6, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(217, 120)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "Rp."
        '
        'txtGrandTotal
        '
        Me.txtGrandTotal.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGrandTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 90.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrandTotal.ForeColor = System.Drawing.Color.Lime
        Me.txtGrandTotal.Location = New System.Drawing.Point(3, 22)
        Me.txtGrandTotal.Multiline = True
        Me.txtGrandTotal.Name = "txtGrandTotal"
        Me.txtGrandTotal.ReadOnly = True
        Me.txtGrandTotal.Size = New System.Drawing.Size(882, 132)
        Me.txtGrandTotal.TabIndex = 33
        Me.txtGrandTotal.Text = "0"
        Me.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GrpBoxTransaksi
        '
        Me.GrpBoxTransaksi.BackgroundImage = Global.penjualan1.My.Resources.Resources.bg_menu5
        Me.GrpBoxTransaksi.Controls.Add(Me.txtKasir)
        Me.GrpBoxTransaksi.Controls.Add(Me.Label3)
        Me.GrpBoxTransaksi.Controls.Add(Me.txtTanggal)
        Me.GrpBoxTransaksi.Controls.Add(Me.Label4)
        Me.GrpBoxTransaksi.Controls.Add(Me.txtJam)
        Me.GrpBoxTransaksi.Controls.Add(Me.Label1)
        Me.GrpBoxTransaksi.Controls.Add(Me.txtNoFaktur)
        Me.GrpBoxTransaksi.Controls.Add(Me.Label2)
        Me.GrpBoxTransaksi.Dock = System.Windows.Forms.DockStyle.Left
        Me.GrpBoxTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBoxTransaksi.ForeColor = System.Drawing.Color.White
        Me.GrpBoxTransaksi.Location = New System.Drawing.Point(3, 22)
        Me.GrpBoxTransaksi.Name = "GrpBoxTransaksi"
        Me.GrpBoxTransaksi.Size = New System.Drawing.Size(492, 157)
        Me.GrpBoxTransaksi.TabIndex = 9
        Me.GrpBoxTransaksi.TabStop = False
        Me.GrpBoxTransaksi.Text = "Transaksi"
        '
        'txtKasir
        '
        Me.txtKasir.Location = New System.Drawing.Point(254, 115)
        Me.txtKasir.Name = "txtKasir"
        Me.txtKasir.ReadOnly = True
        Me.txtKasir.Size = New System.Drawing.Size(225, 26)
        Me.txtKasir.TabIndex = 18
        Me.txtKasir.Text = "Ujang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(250, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 24)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Kasir"
        '
        'txtTanggal
        '
        Me.txtTanggal.Location = New System.Drawing.Point(254, 51)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.ReadOnly = True
        Me.txtTanggal.Size = New System.Drawing.Size(225, 26)
        Me.txtTanggal.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(250, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 24)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Tanggal"
        '
        'txtJam
        '
        Me.txtJam.Location = New System.Drawing.Point(13, 115)
        Me.txtJam.Name = "txtJam"
        Me.txtJam.ReadOnly = True
        Me.txtJam.Size = New System.Drawing.Size(231, 26)
        Me.txtJam.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Jam"
        '
        'txtNoFaktur
        '
        Me.txtNoFaktur.Location = New System.Drawing.Point(13, 51)
        Me.txtNoFaktur.Name = "txtNoFaktur"
        Me.txtNoFaktur.ReadOnly = True
        Me.txtNoFaktur.Size = New System.Drawing.Size(231, 26)
        Me.txtNoFaktur.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 24)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "No. Faktur"
        '
        'GrpBoxPembayaran
        '
        Me.GrpBoxPembayaran.BackgroundImage = Global.penjualan1.My.Resources.Resources.bg_menu5
        Me.GrpBoxPembayaran.Controls.Add(Me.Label18)
        Me.GrpBoxPembayaran.Controls.Add(Me.Label17)
        Me.GrpBoxPembayaran.Controls.Add(Me.bttnHapus)
        Me.GrpBoxPembayaran.Controls.Add(Me.bttnTutup)
        Me.GrpBoxPembayaran.Controls.Add(Me.txtKembalian)
        Me.GrpBoxPembayaran.Controls.Add(Me.Label5)
        Me.GrpBoxPembayaran.Controls.Add(Me.bttnSimpan)
        Me.GrpBoxPembayaran.Controls.Add(Me.Label6)
        Me.GrpBoxPembayaran.Controls.Add(Me.txtDibayar)
        Me.GrpBoxPembayaran.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrpBoxPembayaran.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBoxPembayaran.ForeColor = System.Drawing.Color.White
        Me.GrpBoxPembayaran.Location = New System.Drawing.Point(0, 629)
        Me.GrpBoxPembayaran.Name = "GrpBoxPembayaran"
        Me.GrpBoxPembayaran.Size = New System.Drawing.Size(1386, 159)
        Me.GrpBoxPembayaran.TabIndex = 9
        Me.GrpBoxPembayaran.TabStop = False
        Me.GrpBoxPembayaran.Text = "Pembayaran"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Black
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Yellow
        Me.Label18.Location = New System.Drawing.Point(599, 53)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(74, 39)
        Me.Label18.TabIndex = 51
        Me.Label18.Text = "Rp."
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Black
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label17.Location = New System.Drawing.Point(19, 52)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 39)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "Rp."
        '
        'bttnHapus
        '
        Me.bttnHapus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnHapus.BackColor = System.Drawing.Color.Red
        Me.bttnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnHapus.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnHapus.ForeColor = System.Drawing.Color.White
        Me.bttnHapus.Location = New System.Drawing.Point(1244, 29)
        Me.bttnHapus.Name = "bttnHapus"
        Me.bttnHapus.Size = New System.Drawing.Size(118, 47)
        Me.bttnHapus.TabIndex = 31
        Me.bttnHapus.Text = "Hapus"
        Me.bttnHapus.UseVisualStyleBackColor = False
        '
        'bttnTutup
        '
        Me.bttnTutup.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnTutup.BackgroundImage = Global.penjualan1.My.Resources.Resources.bg_menu
        Me.bttnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnTutup.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnTutup.ForeColor = System.Drawing.Color.White
        Me.bttnTutup.Location = New System.Drawing.Point(1100, 92)
        Me.bttnTutup.Name = "bttnTutup"
        Me.bttnTutup.Size = New System.Drawing.Size(262, 47)
        Me.bttnTutup.TabIndex = 32
        Me.bttnTutup.Text = "Tutup"
        Me.bttnTutup.UseVisualStyleBackColor = True
        '
        'txtKembalian
        '
        Me.txtKembalian.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtKembalian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKembalian.Font = New System.Drawing.Font("Consolas", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKembalian.ForeColor = System.Drawing.Color.Yellow
        Me.txtKembalian.Location = New System.Drawing.Point(597, 52)
        Me.txtKembalian.Name = "txtKembalian"
        Me.txtKembalian.ReadOnly = True
        Me.txtKembalian.Size = New System.Drawing.Size(415, 51)
        Me.txtKembalian.TabIndex = 22
        Me.txtKembalian.Text = "2222222"
        Me.txtKembalian.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(593, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 24)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Kembalian"
        '
        'bttnSimpan
        '
        Me.bttnSimpan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnSimpan.BackColor = System.Drawing.Color.Lime
        Me.bttnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttnSimpan.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSimpan.ForeColor = System.Drawing.Color.White
        Me.bttnSimpan.Location = New System.Drawing.Point(1100, 29)
        Me.bttnSimpan.Name = "bttnSimpan"
        Me.bttnSimpan.Size = New System.Drawing.Size(117, 47)
        Me.bttnSimpan.TabIndex = 30
        Me.bttnSimpan.Text = "Simpan"
        Me.bttnSimpan.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 24)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Dibayar"
        '
        'txtDibayar
        '
        Me.txtDibayar.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtDibayar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDibayar.Font = New System.Drawing.Font("Consolas", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDibayar.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtDibayar.Location = New System.Drawing.Point(13, 51)
        Me.txtDibayar.Name = "txtDibayar"
        Me.txtDibayar.Size = New System.Drawing.Size(539, 51)
        Me.txtDibayar.TabIndex = 20
        Me.txtDibayar.Text = "2222222"
        Me.txtDibayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 360)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1890, 570)
        Me.DataGridView1.TabIndex = 33
        '
        'Column1
        '
        Me.Column1.HeaderText = "Kode Barang"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 250
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nama Barang"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 450
        '
        'Column3
        '
        Me.Column3.HeaderText = "Jenis Barang"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 200
        '
        'Column4
        '
        Me.Column4.HeaderText = "Satuan"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 160
        '
        'Column5
        '
        Me.Column5.HeaderText = "Harga"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 300
        '
        'Column6
        '
        Me.Column6.HeaderText = "QTY"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 160
        '
        'Column7
        '
        Me.Column7.HeaderText = "Total Harga"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 315
        '
        'txtKodeBarang
        '
        Me.txtKodeBarang.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtKodeBarang.BackColor = System.Drawing.Color.White
        Me.txtKodeBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeBarang.ForeColor = System.Drawing.Color.Black
        Me.txtKodeBarang.Location = New System.Drawing.Point(324, 241)
        Me.txtKodeBarang.Name = "txtKodeBarang"
        Me.txtKodeBarang.Size = New System.Drawing.Size(166, 26)
        Me.txtKodeBarang.TabIndex = 19
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtNamaBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaBarang.ForeColor = System.Drawing.Color.White
        Me.txtNamaBarang.Location = New System.Drawing.Point(324, 298)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.ReadOnly = True
        Me.txtNamaBarang.Size = New System.Drawing.Size(166, 26)
        Me.txtNamaBarang.TabIndex = 34
        '
        'txtJenisBarang
        '
        Me.txtJenisBarang.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtJenisBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJenisBarang.ForeColor = System.Drawing.Color.White
        Me.txtJenisBarang.Location = New System.Drawing.Point(615, 241)
        Me.txtJenisBarang.Name = "txtJenisBarang"
        Me.txtJenisBarang.ReadOnly = True
        Me.txtJenisBarang.Size = New System.Drawing.Size(162, 26)
        Me.txtJenisBarang.TabIndex = 35
        '
        'txtSatuan
        '
        Me.txtSatuan.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtSatuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSatuan.ForeColor = System.Drawing.Color.White
        Me.txtSatuan.Location = New System.Drawing.Point(615, 299)
        Me.txtSatuan.Name = "txtSatuan"
        Me.txtSatuan.ReadOnly = True
        Me.txtSatuan.Size = New System.Drawing.Size(162, 26)
        Me.txtSatuan.TabIndex = 36
        '
        'txtHarga
        '
        Me.txtHarga.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHarga.Location = New System.Drawing.Point(928, 246)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.ReadOnly = True
        Me.txtHarga.Size = New System.Drawing.Size(182, 26)
        Me.txtHarga.TabIndex = 37
        Me.txtHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtQty
        '
        Me.TxtQty.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TxtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQty.Location = New System.Drawing.Point(928, 298)
        Me.TxtQty.Name = "TxtQty"
        Me.TxtQty.Size = New System.Drawing.Size(182, 26)
        Me.TxtQty.TabIndex = 38
        Me.TxtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalHarga
        '
        Me.txtTotalHarga.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtTotalHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalHarga.Location = New System.Drawing.Point(1256, 271)
        Me.txtTotalHarga.Name = "txtTotalHarga"
        Me.txtTotalHarga.ReadOnly = True
        Me.txtTotalHarga.Size = New System.Drawing.Size(249, 26)
        Me.txtTotalHarga.TabIndex = 39
        Me.txtTotalHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(219, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 15)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Kode Barang"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(214, 304)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 15)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Nama Barang"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(544, 247)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 15)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Jenis"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(544, 299)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 15)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Satuan"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(852, 250)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 15)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Harga"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(852, 299)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 15)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Quantity"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(1170, 277)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 15)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "Total harga"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(1257, 274)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 20)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "Rp."
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(932, 249)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 20)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "Rp."
        '
        'Form_penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.penjualan1.My.Resources.Resources.bg_menu5
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1386, 788)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTotalHarga)
        Me.Controls.Add(Me.TxtQty)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtSatuan)
        Me.Controls.Add(Me.txtJenisBarang)
        Me.Controls.Add(Me.txtNamaBarang)
        Me.Controls.Add(Me.txtKodeBarang)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GrpBoxPembayaran)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_penjualan"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button7 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GrpBoxGrand As GroupBox
    Friend WithEvents GrpBoxTransaksi As GroupBox
    Friend WithEvents GrpBoxPembayaran As GroupBox
    Friend WithEvents txtKasir As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTanggal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtJam As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNoFaktur As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtKembalian As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDibayar As TextBox
    Friend WithEvents bttnHapus As Button
    Friend WithEvents bttnTutup As Button
    Friend WithEvents bttnSimpan As Button
    Friend WithEvents txtGrandTotal As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents txtKodeBarang As TextBox
    Friend WithEvents txtNamaBarang As TextBox
    Friend WithEvents txtJenisBarang As TextBox
    Friend WithEvents txtSatuan As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents TxtQty As TextBox
    Friend WithEvents txtTotalHarga As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
End Class
