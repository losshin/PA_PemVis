Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class CreatePesanan

    Dim harga As Decimal

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

    Private Sub CreatePesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        If cmbAsal.SelectedIndex <> -1 Then
            cmbTujuan.Focus()
        End If
    End Sub

    Private Sub btnPilih_Click(sender As Object, e As EventArgs) Handles btnPilih.Click

        Me.Hide()
        PilihEkspedisi.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Login.pengguna = "Admin" Then
            Me.Close()
            MenuAdmin.Show()
        Else
            Me.Close()
            MenuUser.Show()
        End If


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

            btnPilih.Focus()
        End If
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If cmbAsal.Text = "" Or cmbTujuan.Text = "" Or txtAlamat.Text = "" Or txtAlamatPenerima.Text = "" Or txtBerat.Text = "" Or txtEkspedisi.Text = "" Or txtNama.Text = "" Or txtNamaPenerima.Text = "" Or txtTelepon.Text = "" Or txtTeleponPenerima.Text = "" Or txtTotal.Text = "" Then
            MessageBox.Show("Form Belum Lengkap Mohon Dilengkapi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Call koneksi() ' Ensure database connection is valid and open
                Dim tambah As String
                If Login.pengguna = "User" Then
                    tambah = "INSERT INTO tblpesanan (id_ekspedisi,id_akun, nama_pengirim, alamat_pengirim, telepon_pengirim , berat, nama_penerima, alamat_penerima, telepon_penerima, total, validasi) VALUES (" & txtIDekspedisi.Text & "," & Login.id_akun & ",'" & txtNama.Text & "','" & txtAlamat.Text & "'," & txtTelepon.Text & "," & txtBerat.Text & ",'" & txtNamaPenerima.Text & "','" & txtAlamatPenerima.Text & "'," & txtTeleponPenerima.Text & "," & txtTotal.Text & ", 'Belum')"
                Else
                    tambah = "INSERT INTO tblpesanan (id_ekspedisi,id_akun, nama_pengirim, alamat_pengirim, telepon_pengirim , berat, nama_penerima, alamat_penerima, telepon_penerima, total, validasi) VALUES (" & txtIDekspedisi.Text & "," & Login.id_akun & ",'" & txtNama.Text & "','" & txtAlamat.Text & "'," & txtTelepon.Text & "," & txtBerat.Text & ",'" & txtNamaPenerima.Text & "','" & txtAlamatPenerima.Text & "'," & txtTeleponPenerima.Text & "," & txtTotal.Text & ", 'Sudah')"
                End If
                CMD = New MySqlCommand(tambah, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Membuat Pesanan Sukses...........|", MsgBoxStyle.Information, "Perhatian")
                If Login.pengguna = "Admin" Then
                    Me.Hide()
                    StrukAdmin.Show()
                Else
                    Me.Close()
                    MenuUser.Show()
                End If
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
End Class