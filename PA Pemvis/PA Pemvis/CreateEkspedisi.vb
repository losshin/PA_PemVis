Imports MySql.Data.MySqlClient

Public Class CreateEkspedisi
    Sub clear()
        txtAsal.Text = ""
        txtEstimasi.Text = ""
        txtHarga.Text = ""
        txtNama.Text = ""
        txtTujuan.Text = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtAsal.Text = "" Or txtEstimasi.Text = "" Or txtHarga.Text = "" Or txtNama.Text = "" Or txtTujuan.Text = "" Then
            MessageBox.Show("Form Belum Lengkap Mohon Dilengkapi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim tambah As String = "insert into tblekspedisi (asal, tujuan, nama, harga, estimasi) values('" & txtAsal.Text & "','" & txtTujuan.Text & "','" & txtNama.Text & "'," & txtHarga.Text & ",'" & txtEstimasi.Text & "')"
            CMD = New MySqlCommand(tambah, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Tambah Data Ekspedisi Sukses...........|", MsgBoxStyle.Information, "Perhatian")
            ReadEkspedisi.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        ReadEkspedisi.Show()
        Me.Close()

    End Sub

    Private Sub CreateEkspedisi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()

    End Sub

    Private Sub txtAsal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAsal.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            txtTujuan.Focus()
        End If
    End Sub

    Private Sub txtTujuan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTujuan.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            txtNama.Focus()
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            txtHarga.Focus()
        End If
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        If (Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar)) Then
            e.Handled = True ' Mencegah karakter dimasukkan ke TextBox
        End If
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            txtEstimasi.Focus()
        End If
    End Sub

    Private Sub txtEstimasi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEstimasi.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            btnTambah.Focus()
        End If
    End Sub
End Class