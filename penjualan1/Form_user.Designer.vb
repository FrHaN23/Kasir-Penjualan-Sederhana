<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_user
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbLevel = New System.Windows.Forms.ComboBox()
        Me.txtNamaUser = New System.Windows.Forms.TextBox()
        Me.txtKodeUser = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bttnTutup = New System.Windows.Forms.Button()
        Me.bttnBersih = New System.Windows.Forms.Button()
        Me.bttnHapus = New System.Windows.Forms.Button()
        Me.bttnSimpan = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(397, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 37)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "USER"
        '
        'cmbLevel
        '
        Me.cmbLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLevel.FormattingEnabled = True
        Me.cmbLevel.Items.AddRange(New Object() {"ADMIN", "Kasir"})
        Me.cmbLevel.Location = New System.Drawing.Point(301, 255)
        Me.cmbLevel.Name = "cmbLevel"
        Me.cmbLevel.Size = New System.Drawing.Size(148, 32)
        Me.cmbLevel.TabIndex = 30
        '
        'txtNamaUser
        '
        Me.txtNamaUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaUser.Location = New System.Drawing.Point(301, 124)
        Me.txtNamaUser.Name = "txtNamaUser"
        Me.txtNamaUser.Size = New System.Drawing.Size(378, 29)
        Me.txtNamaUser.TabIndex = 29
        '
        'txtKodeUser
        '
        Me.txtKodeUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeUser.Location = New System.Drawing.Point(301, 89)
        Me.txtKodeUser.Name = "txtKodeUser"
        Me.txtKodeUser.Size = New System.Drawing.Size(233, 29)
        Me.txtKodeUser.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(136, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 24)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Level"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(136, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 24)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Nama User"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(136, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 24)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Kode User"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(301, 166)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(378, 29)
        Me.txtUsername.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(136, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 24)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Username"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(301, 211)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(378, 29)
        Me.txtPassword.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(136, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 24)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Password"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(49, 362)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(864, 282)
        Me.DataGridView1.TabIndex = 35
        '
        'Column1
        '
        Me.Column1.HeaderText = "Kode User"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nama User"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "Username"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 200
        '
        'Column4
        '
        Me.Column4.HeaderText = "Password"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 170
        '
        'Column5
        '
        Me.Column5.HeaderText = "Level"
        Me.Column5.Name = "Column5"
        '
        'bttnTutup
        '
        Me.bttnTutup.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttnTutup.BackgroundImage = Global.penjualan1.My.Resources.Resources.Warna
        Me.bttnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnTutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnTutup.ForeColor = System.Drawing.Color.White
        Me.bttnTutup.Location = New System.Drawing.Point(824, 664)
        Me.bttnTutup.Name = "bttnTutup"
        Me.bttnTutup.Size = New System.Drawing.Size(108, 34)
        Me.bttnTutup.TabIndex = 39
        Me.bttnTutup.Text = "Tutup"
        Me.bttnTutup.UseVisualStyleBackColor = True
        '
        'bttnBersih
        '
        Me.bttnBersih.BackgroundImage = Global.penjualan1.My.Resources.Resources.Warna
        Me.bttnBersih.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnBersih.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnBersih.ForeColor = System.Drawing.Color.White
        Me.bttnBersih.Location = New System.Drawing.Point(680, 295)
        Me.bttnBersih.Name = "bttnBersih"
        Me.bttnBersih.Size = New System.Drawing.Size(121, 47)
        Me.bttnBersih.TabIndex = 38
        Me.bttnBersih.Text = "Bersihkan"
        Me.bttnBersih.UseVisualStyleBackColor = True
        '
        'bttnHapus
        '
        Me.bttnHapus.BackgroundImage = Global.penjualan1.My.Resources.Resources.Warna
        Me.bttnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnHapus.ForeColor = System.Drawing.Color.White
        Me.bttnHapus.Location = New System.Drawing.Point(447, 295)
        Me.bttnHapus.Name = "bttnHapus"
        Me.bttnHapus.Size = New System.Drawing.Size(120, 47)
        Me.bttnHapus.TabIndex = 37
        Me.bttnHapus.Text = "Hapus"
        Me.bttnHapus.UseVisualStyleBackColor = True
        '
        'bttnSimpan
        '
        Me.bttnSimpan.BackgroundImage = Global.penjualan1.My.Resources.Resources.Warna
        Me.bttnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSimpan.ForeColor = System.Drawing.Color.White
        Me.bttnSimpan.Location = New System.Drawing.Point(184, 295)
        Me.bttnSimpan.Name = "bttnSimpan"
        Me.bttnSimpan.Size = New System.Drawing.Size(133, 47)
        Me.bttnSimpan.TabIndex = 36
        Me.bttnSimpan.Text = "Simpan"
        Me.bttnSimpan.UseVisualStyleBackColor = True
        '
        'Form_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.penjualan1.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(944, 710)
        Me.Controls.Add(Me.bttnTutup)
        Me.Controls.Add(Me.bttnBersih)
        Me.Controls.Add(Me.bttnHapus)
        Me.Controls.Add(Me.bttnSimpan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbLevel)
        Me.Controls.Add(Me.txtNamaUser)
        Me.Controls.Add(Me.txtKodeUser)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_user"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_user"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbLevel As ComboBox
    Friend WithEvents txtNamaUser As TextBox
    Friend WithEvents txtKodeUser As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents bttnTutup As Button
    Friend WithEvents bttnBersih As Button
    Friend WithEvents bttnHapus As Button
    Friend WithEvents bttnSimpan As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
