<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_login
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bttnHapus = New System.Windows.Forms.Button()
        Me.bttnSimpan = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.penjualan1.My.Resources.Resources.logo___Copy
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(355, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 96)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Consolas", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(394, 259)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(249, 41)
        Me.txtPassword.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Consolas", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(232, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 34)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtUsername.Font = New System.Drawing.Font("Consolas", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(394, 150)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(249, 41)
        Me.txtUsername.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Consolas", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(225, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 34)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Username"
        '
        'bttnHapus
        '
        Me.bttnHapus.BackgroundImage = Global.penjualan1.My.Resources.Resources.btn_polos
        Me.bttnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnHapus.ForeColor = System.Drawing.Color.White
        Me.bttnHapus.Location = New System.Drawing.Point(12, 398)
        Me.bttnHapus.Name = "bttnHapus"
        Me.bttnHapus.Size = New System.Drawing.Size(110, 40)
        Me.bttnHapus.TabIndex = 3
        Me.bttnHapus.Text = "Keluar"
        Me.bttnHapus.UseVisualStyleBackColor = True
        '
        'bttnSimpan
        '
        Me.bttnSimpan.BackgroundImage = Global.penjualan1.My.Resources.Resources.btn_polos
        Me.bttnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSimpan.ForeColor = System.Drawing.Color.White
        Me.bttnSimpan.Location = New System.Drawing.Point(355, 338)
        Me.bttnSimpan.Name = "bttnSimpan"
        Me.bttnSimpan.Size = New System.Drawing.Size(141, 47)
        Me.bttnSimpan.TabIndex = 2
        Me.bttnSimpan.Text = "Login"
        Me.bttnSimpan.UseVisualStyleBackColor = True
        '
        'Form_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.penjualan1.My.Resources.Resources.bg_menu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bttnHapus)
        Me.Controls.Add(Me.bttnSimpan)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents bttnHapus As Button
    Friend WithEvents bttnSimpan As Button
End Class
