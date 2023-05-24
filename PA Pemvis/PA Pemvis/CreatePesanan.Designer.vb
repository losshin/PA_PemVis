<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreatePesanan
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
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.cmbAsal = New System.Windows.Forms.ComboBox()
        Me.cmbTujuan = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTelepon = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBerat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTeleponPenerima = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAlamatPenerima = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNamaPenerima = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtEkspedisi = New System.Windows.Forms.TextBox()
        Me.btnPilih = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtIDekspedisi = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(486, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 33)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buat Pesanan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Asal"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(212, 194)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(260, 26)
        Me.txtNama.TabIndex = 4
        '
        'cmbAsal
        '
        Me.cmbAsal.FormattingEnabled = True
        Me.cmbAsal.Location = New System.Drawing.Point(212, 63)
        Me.cmbAsal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbAsal.Name = "cmbAsal"
        Me.cmbAsal.Size = New System.Drawing.Size(260, 28)
        Me.cmbAsal.TabIndex = 5
        '
        'cmbTujuan
        '
        Me.cmbTujuan.FormattingEnabled = True
        Me.cmbTujuan.Location = New System.Drawing.Point(230, 49)
        Me.cmbTujuan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbTujuan.Name = "cmbTujuan"
        Me.cmbTujuan.Size = New System.Drawing.Size(260, 28)
        Me.cmbTujuan.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(17, 55)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 29)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tujuan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(8, 194)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 29)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nama"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(8, 259)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 29)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Alamat"
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(212, 263)
        Me.txtAlamat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(260, 26)
        Me.txtAlamat.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(8, 329)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(184, 29)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Nomor Telepon"
        '
        'txtTelepon
        '
        Me.txtTelepon.Location = New System.Drawing.Point(212, 329)
        Me.txtTelepon.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTelepon.Name = "txtTelepon"
        Me.txtTelepon.Size = New System.Drawing.Size(260, 26)
        Me.txtTelepon.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(8, 397)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 29)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Berat Barang"
        '
        'txtBerat
        '
        Me.txtBerat.Location = New System.Drawing.Point(212, 397)
        Me.txtBerat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBerat.Name = "txtBerat"
        Me.txtBerat.Size = New System.Drawing.Size(260, 26)
        Me.txtBerat.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(17, 249)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(184, 29)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Nomor Telepon"
        '
        'txtTeleponPenerima
        '
        Me.txtTeleponPenerima.Location = New System.Drawing.Point(230, 249)
        Me.txtTeleponPenerima.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTeleponPenerima.Name = "txtTeleponPenerima"
        Me.txtTeleponPenerima.Size = New System.Drawing.Size(260, 26)
        Me.txtTeleponPenerima.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(17, 184)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 29)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Alamat"
        '
        'txtAlamatPenerima
        '
        Me.txtAlamatPenerima.Location = New System.Drawing.Point(230, 180)
        Me.txtAlamatPenerima.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAlamatPenerima.Name = "txtAlamatPenerima"
        Me.txtAlamatPenerima.Size = New System.Drawing.Size(260, 26)
        Me.txtAlamatPenerima.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(17, 119)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 29)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Nama"
        '
        'txtNamaPenerima
        '
        Me.txtNamaPenerima.Location = New System.Drawing.Point(230, 115)
        Me.txtNamaPenerima.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNamaPenerima.Multiline = True
        Me.txtNamaPenerima.Name = "txtNamaPenerima"
        Me.txtNamaPenerima.Size = New System.Drawing.Size(260, 29)
        Me.txtNamaPenerima.TabIndex = 15
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnSubmit.Location = New System.Drawing.Point(472, 638)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(112, 35)
        Me.btnSubmit.TabIndex = 21
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(656, 638)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(112, 35)
        Me.btnClear.TabIndex = 22
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Button3.BackgroundImage = Global.PA_Pemvis.My.Resources.Resources.left_arrow__1_
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.Location = New System.Drawing.Point(22, 18)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 35)
        Me.Button3.TabIndex = 23
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(8, 125)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 29)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Ekspedisi"
        '
        'txtEkspedisi
        '
        Me.txtEkspedisi.Location = New System.Drawing.Point(212, 129)
        Me.txtEkspedisi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEkspedisi.Name = "txtEkspedisi"
        Me.txtEkspedisi.Size = New System.Drawing.Size(260, 26)
        Me.txtEkspedisi.TabIndex = 24
        '
        'btnPilih
        '
        Me.btnPilih.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnPilih.Location = New System.Drawing.Point(483, 125)
        Me.btnPilih.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPilih.Name = "btnPilih"
        Me.btnPilih.Size = New System.Drawing.Size(112, 35)
        Me.btnPilih.TabIndex = 26
        Me.btnPilih.Text = "Pilih"
        Me.btnPilih.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(8, 468)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(139, 29)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Total Harga"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(212, 468)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(260, 26)
        Me.txtTotal.TabIndex = 27
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnHitung)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.btnPilih)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtEkspedisi)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtBerat)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtTelepon)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtAlamat)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbAsal)
        Me.GroupBox1.Controls.Add(Me.txtNama)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 92)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(612, 526)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pengirim"
        '
        'btnHitung
        '
        Me.btnHitung.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnHitung.Location = New System.Drawing.Point(483, 392)
        Me.btnHitung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(112, 35)
        Me.btnHitung.TabIndex = 29
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtTeleponPenerima)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtAlamatPenerima)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtNamaPenerima)
        Me.GroupBox2.Controls.Add(Me.cmbTujuan)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(644, 92)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(546, 526)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Penerima"
        '
        'txtIDekspedisi
        '
        Me.txtIDekspedisi.Location = New System.Drawing.Point(1016, 29)
        Me.txtIDekspedisi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtIDekspedisi.Name = "txtIDekspedisi"
        Me.txtIDekspedisi.Size = New System.Drawing.Size(148, 26)
        Me.txtIDekspedisi.TabIndex = 31
        Me.txtIDekspedisi.Visible = False
        '
        'CreatePesanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1203, 700)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtIDekspedisi)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "CreatePesanan"
        Me.Text = "CreatePesanan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents cmbAsal As ComboBox
    Friend WithEvents cmbTujuan As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTelepon As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBerat As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTeleponPenerima As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAlamatPenerima As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtNamaPenerima As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtEkspedisi As TextBox
    Friend WithEvents btnPilih As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtIDekspedisi As TextBox
    Friend WithEvents btnHitung As Button
End Class
