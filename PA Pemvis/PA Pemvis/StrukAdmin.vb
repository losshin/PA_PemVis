Imports MySql.Data.MySqlClient

Public Class StrukAdmin
    Sub masukData()
        Dim id_pesanan As String = Login.id_pesanan
        Dim id_ekspedisi As String = Login.id_ekspedisi
        Call koneksi()
        CMD = New MySqlCommand("SELECT * FROM tblekspedisi, tblpesanan WHERE tblekspedisi.id_ekspedisi = '" & id_ekspedisi & "' And tblpesanan.id_pesanan = '" & id_pesanan & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Dim asal As String = RD("asal").ToString()
            Dim namaekspedisi As String = RD("nama").ToString()
            Dim tujuan As String = RD("tujuan").ToString()
            Dim nama As String = RD("nama_pengirim").ToString()
            Dim alamat As String = RD("alamat_pengirim").ToString()
            Dim telepon As String = RD("telepon_pengirim").ToString()
            Dim berat As String = RD("berat").ToString()
            Dim nama_penerima As String = RD("nama_penerima").ToString()
            Dim alamat_penerima As String = RD("alamat_penerima").ToString()
            Dim telepon_penerima As String = RD("telepon_penerima").ToString()
            Dim total As String = RD("total").ToString()
            lblAsal.Text = asal
            lblTujuan.Text = tujuan
            lblEkspedisi.Text = namaekspedisi
            lblPengirim.Text = nama
            lblAlamatAsal.Text = alamat
            lblTeleponPengirim.Text = telepon
            lblBerat.Text = berat
            lblPenerima.Text = nama_penerima
            lblAlamatTujuan.Text = alamat_penerima
            lblTeleponPenerima.Text = telepon_penerima
            lblHarga.Text = total
            RD.Close()
        ElseIf Not RD.HasRows Then
            RD.Close()
            MessageBox.Show("Data Gagal Diperoleh", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        If Login.pengguna = "Admin" Then
            Me.Close()
            CreatePesanan.Close()
            MenuAdmin.Show()
        Else
            Me.Close()
            ReadPesanan.Show()
            CreatePesanan.Close()
        End If


    End Sub

    Private Sub StrukAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        If Login.pengguna = "Admin" Then
            lblAsal.Text = CreatePesanan.cmbAsal.Text
            lblTujuan.Text = CreatePesanan.cmbTujuan.Text
            lblEkspedisi.Text = CreatePesanan.txtEkspedisi.Text
            lblPengirim.Text = CreatePesanan.txtNama.Text
            lblAlamatAsal.Text = CreatePesanan.txtAlamat.Text
            lblTeleponPengirim.Text = CreatePesanan.txtTelepon.Text
            lblBerat.Text = CreatePesanan.txtBerat.Text
            lblPenerima.Text = CreatePesanan.txtNamaPenerima.Text
            lblAlamatTujuan.Text = CreatePesanan.txtAlamatPenerima.Text
            lblTeleponPenerima.Text = CreatePesanan.txtTeleponPenerima.Text
            lblHarga.Text = CreatePesanan.txtTotal.Text
        Else
            masukData()
        End If


    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

    End Sub

End Class