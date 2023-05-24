<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReadPesanan
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnValidasi = New System.Windows.Forms.Button()
        Me.dgvEkspedisi = New System.Windows.Forms.DataGridView()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmbPilihan = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        CType(Me.dgvEkspedisi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(346, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 24)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Daftar Pesanan"
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnHapus.Location = New System.Drawing.Point(507, 411)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(85, 51)
        Me.btnHapus.TabIndex = 10
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnUpdate.Location = New System.Drawing.Point(365, 411)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(85, 51)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnValidasi
        '
        Me.btnValidasi.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnValidasi.Location = New System.Drawing.Point(231, 411)
        Me.btnValidasi.Name = "btnValidasi"
        Me.btnValidasi.Size = New System.Drawing.Size(82, 51)
        Me.btnValidasi.TabIndex = 8
        Me.btnValidasi.Text = "Validasi"
        Me.btnValidasi.UseVisualStyleBackColor = False
        '
        'dgvEkspedisi
        '
        Me.dgvEkspedisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEkspedisi.Location = New System.Drawing.Point(12, 75)
        Me.dgvEkspedisi.Name = "dgvEkspedisi"
        Me.dgvEkspedisi.RowHeadersWidth = 62
        Me.dgvEkspedisi.Size = New System.Drawing.Size(821, 330)
        Me.dgvEkspedisi.TabIndex = 7
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.BtnBack.BackgroundImage = Global.PA_Pemvis.My.Resources.Resources.left_arrow__1_
        Me.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnBack.Location = New System.Drawing.Point(12, 12)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(75, 23)
        Me.BtnBack.TabIndex = 6
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Search :"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(86, 51)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(425, 20)
        Me.txtSearch.TabIndex = 13
        '
        'cmbPilihan
        '
        Me.cmbPilihan.FormattingEnabled = True
        Me.cmbPilihan.Items.AddRange(New Object() {"ID Pesanan", "ID Ekspedisi", "ID Akun", "Nama Pengirim", "Alamat Pengirim", "Telepon Pengirim", "Berat", "Nama Penerima", "Alamat Penerima", "Telepon Penerima", "Total"})
        Me.cmbPilihan.Location = New System.Drawing.Point(517, 51)
        Me.cmbPilihan.Name = "cmbPilihan"
        Me.cmbPilihan.Size = New System.Drawing.Size(225, 21)
        Me.cmbPilihan.TabIndex = 14
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(748, 49)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(85, 23)
        Me.btnSearch.TabIndex = 15
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'ReadPesanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(845, 482)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.cmbPilihan)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnValidasi)
        Me.Controls.Add(Me.dgvEkspedisi)
        Me.Controls.Add(Me.BtnBack)
        Me.Name = "ReadPesanan"
        Me.Text = "ReadPesanan"
        CType(Me.dgvEkspedisi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnValidasi As Button
    Friend WithEvents dgvEkspedisi As DataGridView
    Friend WithEvents BtnBack As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmbPilihan As ComboBox
    Friend WithEvents btnSearch As Button
End Class
