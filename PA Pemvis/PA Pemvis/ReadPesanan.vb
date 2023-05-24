Imports MySql.Data.MySqlClient

Public Class ReadPesanan
    Sub tampilData()

        Dim sql As String
        If Login.pengguna = "User" Then
            sql = "SELECT * FROM tblpesanan WHERE id_akun = @id_akun "
        Else
            sql = "SELECT * FROM tblpesanan"
        End If

        DA = New MySqlDataAdapter(sql, CONN)
        DA.SelectCommand.Parameters.AddWithValue("@id_akun", (Login.id_akun).ToString)

        DS = New DataSet
        DA.Fill(DS, "tblekspedisi")
        dgvEkspedisi.DataSource = DS.Tables("tblekspedisi")
        dgvEkspedisi.Refresh()

    End Sub

    Sub aturGrid()
        dgvEkspedisi.Columns(0).Width = 30
        dgvEkspedisi.Columns(1).Width = 40
        dgvEkspedisi.Columns(2).Width = 40
        dgvEkspedisi.Columns(3).Width = 150
        dgvEkspedisi.Columns(4).Width = 150
        dgvEkspedisi.Columns(5).Width = 150
        dgvEkspedisi.Columns(6).Width = 150
        dgvEkspedisi.Columns(7).Width = 150
        dgvEkspedisi.Columns(8).Width = 150
        dgvEkspedisi.Columns(9).Width = 150
        dgvEkspedisi.Columns(10).Width = 150
        dgvEkspedisi.Columns(11).Width = 150
        dgvEkspedisi.Columns(0).HeaderText = "ID"
        dgvEkspedisi.Columns(1).HeaderText = "ID Ekspedisi"
        dgvEkspedisi.Columns(2).HeaderText = "ID Akun"
        dgvEkspedisi.Columns(3).HeaderText = "Nama Pengirim"
        dgvEkspedisi.Columns(4).HeaderText = "Alamat Pengirim"
        dgvEkspedisi.Columns(5).HeaderText = "Telepon Pengirim"
        dgvEkspedisi.Columns(6).HeaderText = "Berat"
        dgvEkspedisi.Columns(7).HeaderText = "Nama Penerima"
        dgvEkspedisi.Columns(8).HeaderText = "Alamat Penerima"
        dgvEkspedisi.Columns(9).HeaderText = "Telepon Penerima"
        dgvEkspedisi.Columns(10).HeaderText = "Total Harga"
        dgvEkspedisi.Columns(11).HeaderText = "Validasi"
    End Sub

    Private Sub dgvEkspedisi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEkspedisi.CellClick

        If Login.pengguna = "Admin" Then
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvEkspedisi.Rows(e.RowIndex)
                Login.id_pesanan = row.Cells(0).Value.ToString()
                Login.id_ekspedisi = row.Cells(1).Value.ToString()

                Dim cellValue As String = row.Cells(11).Value.ToString()
                If cellValue = "Belum" Then
                    btnValidasi.Enabled = True
                Else
                    btnValidasi.Enabled = False
                End If

                btnHapus.Enabled = True
                btnUpdate.Enabled = True
            End If
        Else
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvEkspedisi.Rows(e.RowIndex)
                Login.id_pesanan = row.Cells(0).Value.ToString()
                Login.id_ekspedisi = row.Cells(1).Value.ToString()

                Dim cellValue As String = row.Cells(11).Value.ToString()
                If cellValue = "Belum" Then
                    btnUpdate.Enabled = True
                    btnHapus.Enabled = True
                    btnValidasi.Enabled = False
                Else
                    btnValidasi.Enabled = True
                    btnUpdate.Enabled = False
                    btnHapus.Enabled = False
                End If

            End If

        End If


    End Sub
    Private Sub ReadPesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvEkspedisi.RowHeadersVisible = False
        If Login.pengguna = "Admin" Then
            btnValidasi.Enabled = False
            dgvEkspedisi.ReadOnly = True
            btnHapus.Enabled = False
            btnUpdate.Enabled = False
            Call koneksi()
            Call tampilData()
            Call aturGrid()
            Me.CenterToScreen()
        Else
            btnValidasi.Enabled = False
            btnValidasi.Text = "Cetak Nota"
            dgvEkspedisi.ReadOnly = True
            btnHapus.Enabled = False
            btnUpdate.Enabled = False
            Call koneksi()
            Call tampilData()
            Call aturGrid()
            Me.CenterToScreen()
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        UpdatePesanan.txtIDekspedisi.Text = Login.id_ekspedisi
        Me.Close()
        UpdatePesanan.Show()

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        If Login.pengguna = "Admin" Then
            Me.Close()
            MenuAdmin.Show()
        Else
            Me.Close()
            MenuUser.Show()
        End If

    End Sub



    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        If Login.id_pesanan = "" Then
            MsgBox("Belum Ada Data Yang Dipilih")
        Else
            If MessageBox.Show("Yakin Ingin Menghapus Data Ini Dengan Id " + Login.id_pesanan + "?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                CMD = New MySqlCommand("Delete from tblpesanan where id_pesanan = '" & Login.id_pesanan & "'", CONN)
                CMD.ExecuteNonQuery()
                Call tampilData()
            End If
        End If

    End Sub

    Private Sub btnValidasi_Click(sender As Object, e As EventArgs) Handles btnValidasi.Click

        If Login.pengguna = "Admin" Then
            Call koneksi()
            If MessageBox.Show("Yakin Ingin Menghapus Data Ini Dengan Id " + Login.id_pesanan + "?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim updateQuery As String = "UPDATE tblpesanan SET validasi = 'Sudah' WHERE id_pesanan = @id_pesanan"
                CMD = New MySqlCommand(updateQuery, CONN)
                CMD.Parameters.AddWithValue("@id_pesanan", Login.id_pesanan)

                CMD.ExecuteNonQuery()
                MsgBox("Data berhasil diperbarui", MsgBoxStyle.Information, "Perhatian")
                tampilData()
            End If
        Else
                Me.Close()
            StrukAdmin.Show()
        End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim field As String
        If cmbPilihan.Text = "" Then
            MsgBox("Combo box belum terisi", MsgBoxStyle.Information, "Perhatian")
        Else
            Dim index As Integer = cmbPilihan.SelectedIndex
            If index = 0 Then
                field = "id_pesanan"
            ElseIf index = 1 Then
                field = "id_ekspedisi"
            ElseIf index = 2 Then
                field = "id_akun"
            ElseIf index = 3 Then
                field = "nama_pengirim"
            ElseIf index = 4 Then
                field = "alamat_pengirim"
            ElseIf index = 5 Then
                field = "telepon_pengirim"
            ElseIf index = 6 Then
                field = "berat"
            ElseIf index = 7 Then
                field = "nama_penerima"
            ElseIf index = 8 Then
                field = "alamat_penerima"
            ElseIf index = 9 Then
                field = "telepon_penerima"
            ElseIf index = 10 Then
                field = "total"
            End If

            CMD = New MySqlCommand("SELECT * FROM tblpesanan WHERE " & field & " LIKE '%" & txtSearch.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then
                RD.Close()
                DA = New MySqlDataAdapter("SELECT * FROM tblpesanan WHERE " & field & " LIKE '%" & txtSearch.Text & "%'", CONN)
                DS = New DataSet
                DA.Fill(DS, "Ditemukan")
                dgvEkspedisi.DataSource = DS.Tables("Ditemukan")
                dgvEkspedisi.ReadOnly = True
            Else
                RD.Close()
                MsgBox("Data Tidak Ditemukan")
            End If
        End If

    End Sub

End Class