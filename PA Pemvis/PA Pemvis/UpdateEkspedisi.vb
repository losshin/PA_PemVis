Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class UpdateEkspedisi

    Private Sub UpdateEkspedisi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim id_ekspedisi As String = Login.id_ekspedisi
        Call koneksi()
        CMD = New MySqlCommand("Select * From tblekspedisi where id_ekspedisi ='" & id_ekspedisi & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Dim asal As String = RD("asal").ToString()
            Dim tujuan As String = RD("tujuan").ToString()
            Dim nama As String = RD("nama").ToString()
            Dim harga As String = RD("harga").ToString()
            Dim estimasi As String = RD("estimasi").ToString()
            txtAsal.Text = asal
            txtTujuan.Text = tujuan
            txtNama.Text = nama
            txtHarga.Text = harga
            txtEstimasi.Text = estimasi
            RD.Close()
        ElseIf Not RD.HasRows Then
            RD.Close()
            MessageBox.Show("Data Gagal Diperoleh", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Close()
        ReadEkspedisi.Show()

    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtAsal.Text = ""
        txtEstimasi.Text = ""
        txtHarga.Text = ""
        txtNama.Text = ""
        txtTujuan.Text = ""
        txtTujuan.Text = ""

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtAsal.Text = "" Or txtEstimasi.Text = "" Or txtHarga.Text = "" Or txtNama.Text = "" Or txtTujuan.Text = "" Then
            MsgBox("Masih Ada Data Yang Kosong")
        Else
            Dim update As String = ("Update tblekspedisi set asal = '" & txtAsal.Text & "', tujuan = '" & txtTujuan.Text & "', nama = '" & txtNama.Text & "', harga = " & txtHarga.Text & ", estimasi = '" & txtEstimasi.Text & "' where id_ekspedisi =  '" & Login.id_ekspedisi & "'")
            CMD = New MySqlCommand(update, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ReadEkspedisi.Show()
            Me.Close()
        End If
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
            e.Handled = True
        End If
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            txtEstimasi.Focus()
        End If
    End Sub

    Private Sub txtEstimasi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEstimasi.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            btnUpdate.Focus()
        End If
    End Sub

    Private Sub txtAsal_GotFocus(sender As Object, e As EventArgs) Handles txtAsal.GotFocus
        If txtAsal.Text = "Asal" Then
            txtAsal.Text = ""
            txtAsal.ForeColor = Color.Black ' Set the text color to black
        End If
    End Sub

    Private Sub txtAsal_LostFocus(sender As Object, e As EventArgs) Handles txtAsal.LostFocus
        If txtAsal.Text = "" Then
            txtAsal.Text = "Asal"
            txtAsal.ForeColor = Color.Gray ' Set the text color to gray
        End If
    End Sub

    Private Sub txtEstimasi_GotFocus(sender As Object, e As EventArgs) Handles txtEstimasi.GotFocus
        If txtEstimasi.Text = "Estimasi" Then
            txtEstimasi.Text = ""
            txtEstimasi.ForeColor = Color.Black ' Set the text color to black
        End If
    End Sub

    Private Sub txtEstimasi_LostFocus(sender As Object, e As EventArgs) Handles txtEstimasi.LostFocus
        If txtEstimasi.Text = "" Then
            txtEstimasi.Text = "Estimasi"
            txtEstimasi.ForeColor = Color.Gray ' Set the text color to gray
        End If
    End Sub

    Private Sub txtHarga_GotFocus(sender As Object, e As EventArgs) Handles txtHarga.GotFocus
        If txtHarga.Text = "Harga" Then
            txtHarga.Text = ""
            txtHarga.ForeColor = Color.Black ' Set the text color to black
        End If
    End Sub

    Private Sub txtHarga_LostFocus(sender As Object, e As EventArgs) Handles txtHarga.LostFocus
        If txtHarga.Text = "" Then
            txtHarga.Text = "Harga"
            txtHarga.ForeColor = Color.Gray ' Set the text color to gray
        End If
    End Sub

    Private Sub txtNama_GotFocus(sender As Object, e As EventArgs) Handles txtNama.GotFocus
        If txtNama.Text = "Nama" Then
            txtNama.Text = ""
            txtNama.ForeColor = Color.Black ' Set the text color to black
        End If
    End Sub

    Private Sub txtNama_LostFocus(sender As Object, e As EventArgs) Handles txtNama.LostFocus
        If txtNama.Text = "" Then
            txtNama.Text = "Nama"
            txtNama.ForeColor = Color.Gray ' Set the text color to gray
        End If
    End Sub

    Private Sub txtTujuan_GotFocus(sender As Object, e As EventArgs) Handles txtTujuan.GotFocus
        If txtTujuan.Text = "Tujuan" Then
            txtTujuan.Text = ""
            txtTujuan.ForeColor = Color.Black ' Set the text color to black
        End If
    End Sub

    Private Sub txtTujuan_LostFocus(sender As Object, e As EventArgs) Handles txtTujuan.LostFocus
        If txtTujuan.Text = "" Then
            txtTujuan.Text = "Tujuan"
            txtTujuan.ForeColor = Color.Gray ' Set the text color to gray
        End If
    End Sub
End Class