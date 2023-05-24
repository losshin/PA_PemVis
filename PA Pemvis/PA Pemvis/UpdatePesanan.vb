Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class UpdatePesanan
    Dim harga As Decimal

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
            cmbAsal.Text = asal
            cmbTujuan.Text = tujuan
            txtEkspedisi.Text = namaekspedisi
            txtNama.Text = nama
            txtAlamat.Text = alamat
            txtTelepon.Text = telepon
            txtBerat.Text = berat
            txtNamaPenerima.Text = nama_penerima
            txtAlamatPenerima.Text = alamat_penerima
            txtTeleponPenerima.Text = telepon_penerima
            txtTotal.Text = total
            RD.Close()
        ElseIf Not RD.HasRows Then
            RD.Close()
            MessageBox.Show("Data Gagal Diperoleh", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Sub sinkronData()
        Dim id_ekspedisi As String = txtIDekspedisi.Text
        Dim sql As String = "SELECT * FROM tblekspedisi WHERE id_ekspedisi = @id"

        Try
            Call koneksi()
            CMD = New MySqlCommand(sql, CONN)
            CMD.Parameters.AddWithValue("@id", id_ekspedisi)
            RD = CMD.ExecuteReader()

            While RD.Read()
                txtEkspedisi.Text = RD("nama").ToString()
                harga = RD("harga").ToString()
            End While

            RD.Close() ' Close the DataReader after reading the data

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If CONN.State = ConnectionState.Open Then
                CONN.Close()
            End If
        End Try
    End Sub
    Sub tampilTujuan()
        Dim sql As String = "SELECT DISTINCT tujuan FROM tblekspedisi WHERE asal = '" & cmbAsal.SelectedItem.ToString() & "'"

        Try
            cmbTujuan.Items.Clear()
            Call koneksi()
            CMD = New MySqlCommand(sql, CONN)
            RD = CMD.ExecuteReader()

            While RD.Read()
                cmbTujuan.Items.Add(RD.GetString("tujuan"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If CONN.State = ConnectionState.Open Then
                CONN.Close()
            End If
        End Try
    End Sub

    Sub tampilAsal()
        Dim sql As String = "SELECT DISTINCT asal FROM tblekspedisi"

        Try
            cmbAsal.Items.Clear()
            Call koneksi()
            CMD = New MySqlCommand(sql, CONN)
            RD = CMD.ExecuteReader()

            While RD.Read()
                cmbAsal.Items.Add(RD.GetString("asal"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If CONN.State = ConnectionState.Open Then
                CONN.Close()
            End If
        End Try
    End Sub

    Private Sub UpdatePesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        masukData()
        tampilAsal()
        txtEkspedisi.Enabled = False
        cmbTujuan.Enabled = False
        txtTotal.Enabled = False
        Me.CenterToScreen()

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAsal.SelectedIndexChanged
        tampilTujuan()
        cmbTujuan.Enabled = True
        cmbTujuan.Text = ""
        txtEkspedisi.Text = ""
        txtTotal.Text = ""

        If cmbTujuan.SelectedIndex <> -1 Then
            ' Memindahkan fokus ke TextBox berikutnya
            txtNamaPenerima.Focus()
        End If
    End Sub
    Private Sub btnPilih_Click(sender As Object, e As EventArgs) Handles btnPilih.Click

        Me.Hide()
        PilihEkspedisiUpdate.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Close()
        ReadPesanan.Show()

    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim total As Decimal = Val(txtBerat.Text) * harga
        If txtBerat.Text = "" Then
        Else
            txtTotal.Text = total
        End If
    End Sub

    Private Sub cmbTujuan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTujuan.SelectedIndexChanged
        txtEkspedisi.Text = ""
        txtTotal.Text = ""
        If cmbTujuan.SelectedIndex <> -1 Then
            ' Memindahkan fokus ke TextBox berikutnya
            txtNamaPenerima.Focus()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If cmbAsal.Text = "" Or cmbTujuan.Text = "" Or txtAlamat.Text = "" Or txtAlamatPenerima.Text = "" Or txtBerat.Text = "" Or txtEkspedisi.Text = "" Or txtNama.Text = "" Or txtNamaPenerima.Text = "" Or txtTelepon.Text = "" Or txtTeleponPenerima.Text = "" Or txtTotal.Text = "" Then
            MessageBox.Show("Form Belum Lengkap Mohon Dilengkapi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Call koneksi()
                Dim updateQuery As String = "UPDATE tblpesanan SET id_ekspedisi = @id_ekspedisi, nama_pengirim = @nama_pengirim, alamat_pengirim = @alamat_pengirim, telepon_pengirim = @telepon_pengirim, berat = @berat, nama_penerima = @nama_penerima, alamat_penerima = @alamat_penerima, telepon_penerima = @telepon_penerima, total = @total WHERE id_pesanan = @id_pesanan"
                CMD = New MySqlCommand(updateQuery, CONN)
                CMD.Parameters.AddWithValue("@nama_pengirim", txtNama.Text)
                CMD.Parameters.AddWithValue("@alamat_pengirim", txtAlamat.Text)
                CMD.Parameters.AddWithValue("@telepon_pengirim", txtTelepon.Text)
                CMD.Parameters.AddWithValue("@berat", txtBerat.Text)
                CMD.Parameters.AddWithValue("@nama_penerima", txtNamaPenerima.Text)
                CMD.Parameters.AddWithValue("@alamat_penerima", txtAlamatPenerima.Text)
                CMD.Parameters.AddWithValue("@telepon_penerima", txtTeleponPenerima.Text)
                CMD.Parameters.AddWithValue("@total", txtTotal.Text)
                CMD.Parameters.AddWithValue("@id_ekspedisi", txtIDekspedisi.Text)
                CMD.Parameters.AddWithValue("@id_pesanan", Login.id_pesanan)

                CMD.ExecuteNonQuery()
                MsgBox("Data berhasil diperbarui", MsgBoxStyle.Information, "Perhatian")
                Me.Close()
                ReadPesanan.Show()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If CONN.State = ConnectionState.Open Then
                    CONN.Close()
                End If
            End Try
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cmbAsal.Text = ""
        cmbTujuan.Text = ""
        txtAlamat.Text = ""
        txtAlamatPenerima.Text = ""
        txtBerat.Text = ""
        txtEkspedisi.Text = ""
        txtNama.Text = ""
        txtNamaPenerima.Text = ""
        txtTelepon.Text = ""
        txtTeleponPenerima.Text = ""
        txtTotal.Text = ""
    End Sub

    Private Sub txtBerat_TextChanged(sender As Object, e As EventArgs) Handles txtBerat.TextChanged
        txtTotal.Text = ""
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            txtAlamat.Focus()
        End If
    End Sub

    Private Sub txtAlamat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAlamat.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            txtTelepon.Focus()
        End If
    End Sub

    Private Sub txtTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelepon.KeyPress
        If (Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar)) Then
            e.Handled = True
        End If
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            txtBerat.Focus()
        End If
    End Sub

    Private Sub txtBerat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBerat.KeyPress
        Dim keyChar As Char = e.KeyChar

        If (Not Char.IsDigit(keyChar) AndAlso keyChar <> "."c AndAlso Not Char.IsControl(keyChar)) Then
            e.Handled = True
        End If

        If (keyChar = "."c AndAlso txtBerat.Text.Contains(".")) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNamaPenerima_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaPenerima.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            txtAlamatPenerima.Focus()
        End If
    End Sub

    Private Sub txtAlamatPenerima_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAlamatPenerima.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            txtTeleponPenerima.Focus()
        End If
    End Sub

    Private Sub txtTeleponPenerima_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTeleponPenerima.KeyPress
        If (Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar)) Then
            e.Handled = True
        End If
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            btnSubmit.Focus()
        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class