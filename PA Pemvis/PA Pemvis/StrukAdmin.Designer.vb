<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StrukAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StrukAdmin))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblPengirim = New System.Windows.Forms.Label()
        Me.lblPenerima = New System.Windows.Forms.Label()
        Me.lblEkspedisi = New System.Windows.Forms.Label()
        Me.lblAsal = New System.Windows.Forms.Label()
        Me.lblAlamatAsal = New System.Windows.Forms.Label()
        Me.lblTujuan = New System.Windows.Forms.Label()
        Me.lblAlamatTujuan = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblBerat = New System.Windows.Forms.Label()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.lblTeleponPengirim = New System.Windows.Forms.Label()
        Me.lblTeleponPenerima = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(599, 297)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnCetak
        '
        Me.btnCetak.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnCetak.Location = New System.Drawing.Point(223, 318)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(75, 23)
        Me.btnCetak.TabIndex = 1
        Me.btnCetak.Text = "Cetak"
        Me.btnCetak.UseVisualStyleBackColor = False
        '
        'btnTutup
        '
        Me.btnTutup.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnTutup.Location = New System.Drawing.Point(314, 318)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(75, 23)
        Me.btnTutup.TabIndex = 2
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(24, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(218, 56)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(345, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "KRHI EXPEDITION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Pengirim : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Penerima : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(311, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Asal : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(311, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Alamat Asal : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(311, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Tujuan : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(311, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Alamat Tujuan : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(311, 274)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Harga : "
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(12, 98)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(286, 211)
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Location = New System.Drawing.Point(288, 98)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(323, 211)
        Me.PictureBox4.TabIndex = 14
        Me.PictureBox4.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Cursor = System.Windows.Forms.Cursors.UpArrow
        Me.Label10.Location = New System.Drawing.Point(311, 113)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Nama Ekspedisi : "
        '
        'lblPengirim
        '
        Me.lblPengirim.AutoSize = True
        Me.lblPengirim.Location = New System.Drawing.Point(21, 135)
        Me.lblPengirim.Name = "lblPengirim"
        Me.lblPengirim.Size = New System.Drawing.Size(45, 13)
        Me.lblPengirim.TabIndex = 16
        Me.lblPengirim.Text = "Label11"
        '
        'lblPenerima
        '
        Me.lblPenerima.AutoSize = True
        Me.lblPenerima.Location = New System.Drawing.Point(21, 233)
        Me.lblPenerima.Name = "lblPenerima"
        Me.lblPenerima.Size = New System.Drawing.Size(45, 13)
        Me.lblPenerima.TabIndex = 17
        Me.lblPenerima.Text = "Label11"
        '
        'lblEkspedisi
        '
        Me.lblEkspedisi.AutoSize = True
        Me.lblEkspedisi.Location = New System.Drawing.Point(399, 113)
        Me.lblEkspedisi.Name = "lblEkspedisi"
        Me.lblEkspedisi.Size = New System.Drawing.Size(45, 13)
        Me.lblEkspedisi.TabIndex = 18
        Me.lblEkspedisi.Text = "Label11"
        '
        'lblAsal
        '
        Me.lblAsal.AutoSize = True
        Me.lblAsal.Location = New System.Drawing.Point(344, 135)
        Me.lblAsal.Name = "lblAsal"
        Me.lblAsal.Size = New System.Drawing.Size(45, 13)
        Me.lblAsal.TabIndex = 19
        Me.lblAsal.Text = "Label11"
        '
        'lblAlamatAsal
        '
        Me.lblAlamatAsal.AutoSize = True
        Me.lblAlamatAsal.Location = New System.Drawing.Point(379, 160)
        Me.lblAlamatAsal.Name = "lblAlamatAsal"
        Me.lblAlamatAsal.Size = New System.Drawing.Size(45, 13)
        Me.lblAlamatAsal.TabIndex = 20
        Me.lblAlamatAsal.Text = "Label11"
        '
        'lblTujuan
        '
        Me.lblTujuan.AutoSize = True
        Me.lblTujuan.Location = New System.Drawing.Point(358, 186)
        Me.lblTujuan.Name = "lblTujuan"
        Me.lblTujuan.Size = New System.Drawing.Size(45, 13)
        Me.lblTujuan.TabIndex = 21
        Me.lblTujuan.Text = "Label11"
        '
        'lblAlamatTujuan
        '
        Me.lblAlamatTujuan.AutoSize = True
        Me.lblAlamatTujuan.Location = New System.Drawing.Point(393, 213)
        Me.lblAlamatTujuan.Name = "lblAlamatTujuan"
        Me.lblAlamatTujuan.Size = New System.Drawing.Size(45, 13)
        Me.lblAlamatTujuan.TabIndex = 22
        Me.lblAlamatTujuan.Text = "Label11"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(311, 244)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Berat Barang : "
        '
        'lblBerat
        '
        Me.lblBerat.AutoSize = True
        Me.lblBerat.Location = New System.Drawing.Point(390, 244)
        Me.lblBerat.Name = "lblBerat"
        Me.lblBerat.Size = New System.Drawing.Size(45, 13)
        Me.lblBerat.TabIndex = 23
        Me.lblBerat.Text = "Label11"
        '
        'lblHarga
        '
        Me.lblHarga.AutoSize = True
        Me.lblHarga.Location = New System.Drawing.Point(358, 274)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(45, 13)
        Me.lblHarga.TabIndex = 24
        Me.lblHarga.Text = "Label11"
        '
        'lblTeleponPengirim
        '
        Me.lblTeleponPengirim.AutoSize = True
        Me.lblTeleponPengirim.Location = New System.Drawing.Point(21, 160)
        Me.lblTeleponPengirim.Name = "lblTeleponPengirim"
        Me.lblTeleponPengirim.Size = New System.Drawing.Size(45, 13)
        Me.lblTeleponPengirim.TabIndex = 25
        Me.lblTeleponPengirim.Text = "Label11"
        '
        'lblTeleponPenerima
        '
        Me.lblTeleponPenerima.AutoSize = True
        Me.lblTeleponPenerima.Location = New System.Drawing.Point(21, 259)
        Me.lblTeleponPenerima.Name = "lblTeleponPenerima"
        Me.lblTeleponPenerima.Size = New System.Drawing.Size(45, 13)
        Me.lblTeleponPenerima.TabIndex = 26
        Me.lblTeleponPenerima.Text = "Label11"
        '
        'StrukAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(623, 350)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTeleponPenerima)
        Me.Controls.Add(Me.lblTeleponPengirim)
        Me.Controls.Add(Me.lblHarga)
        Me.Controls.Add(Me.lblBerat)
        Me.Controls.Add(Me.lblAlamatTujuan)
        Me.Controls.Add(Me.lblTujuan)
        Me.Controls.Add(Me.lblAlamatAsal)
        Me.Controls.Add(Me.lblAsal)
        Me.Controls.Add(Me.lblEkspedisi)
        Me.Controls.Add(Me.lblPenerima)
        Me.Controls.Add(Me.lblPengirim)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "StrukAdmin"
        Me.Text = "StrukAdmin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents btnTutup As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblPengirim As Label
    Friend WithEvents lblPenerima As Label
    Friend WithEvents lblEkspedisi As Label
    Friend WithEvents lblAsal As Label
    Friend WithEvents lblAlamatAsal As Label
    Friend WithEvents lblTujuan As Label
    Friend WithEvents lblAlamatTujuan As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblBerat As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents lblTeleponPengirim As Label
    Friend WithEvents lblTeleponPenerima As Label
End Class
