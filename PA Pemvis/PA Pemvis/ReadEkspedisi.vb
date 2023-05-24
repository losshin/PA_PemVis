Imports MySql.Data.MySqlClient

Public Class ReadEkspedisi
    Sub tampilData()
        DA = New MySqlDataAdapter("Select * From tblekspedisi", CONN)
        DS = New DataSet

        DA.Fill(DS, "tblekspedisi")
        dgvEkspedisi.DataSource = DS.Tables("tblekspedisi")
        dgvEkspedisi.Refresh()
    End Sub

    Sub aturGrid()
        dgvEkspedisi.Columns(0).Width = 50
        dgvEkspedisi.Columns(1).Width = 150
        dgvEkspedisi.Columns(2).Width = 150
        dgvEkspedisi.Columns(3).Width = 150
        dgvEkspedisi.Columns(4).Width = 150
        dgvEkspedisi.Columns(5).Width = 150
        dgvEkspedisi.Columns(0).HeaderText = "ID"
        dgvEkspedisi.Columns(1).HeaderText = "Asal"
        dgvEkspedisi.Columns(2).HeaderText = "Nama"
        dgvEkspedisi.Columns(3).HeaderText = "Tujuan"
        dgvEkspedisi.Columns(4).HeaderText = "Harga"
        dgvEkspedisi.Columns(5).HeaderText = "Estimasi"
    End Sub

    Private Sub ReadEkspedisi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvEkspedisi.RowHeadersVisible = False

        dgvEkspedisi.ReadOnly = True
        Call koneksi()
        Call tampilData()
        Call aturGrid()
        Me.CenterToScreen()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Me.Close()
        CreateEkspedisi.Show()
    End Sub

    Private Sub dgvEkspedisi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEkspedisi.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvEkspedisi.Rows(e.RowIndex)
            Login.id_ekspedisi = row.Cells(0).Value.ToString()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Me.Close()
        UpdateEkspedisi.Show()

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Close()
        MenuAdmin.Show()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If Login.id_ekspedisi = "" Then
            MsgBox("Belum Ada Data Yang Dipilih")
        Else
            If MessageBox.Show("Yakin Ingin Menghapus Data Ini Dengan Id " + Login.id_ekspedisi + "?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                CMD = New MySqlCommand("Delete from tblekspedisi where id_ekspedisi = '" & Login.id_ekspedisi & "'", CONN)
                CMD.ExecuteNonQuery()
                Call tampilData()
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim field As String
        If cmbPilihan.Text = "" Then
            MsgBox("Combo box belum terisi", MsgBoxStyle.Information, "Perhatian")
        Else
            Dim index As Integer = cmbPilihan.SelectedIndex
            If index = 0 Then
                field = "id_ekspedisi"
            ElseIf index = 1 Then
                field = "asal"
            ElseIf index = 2 Then
                field = "nama"
            ElseIf index = 3 Then
                field = "tujuan"
            ElseIf index = 4 Then
                field = "harga"
            ElseIf index = 5 Then
                field = "estimasi"
            End If

            CMD = New MySqlCommand("SELECT * FROM tblekspedisi WHERE " & field & " LIKE '%" & txtSearch.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then
                RD.Close()
                DA = New MySqlDataAdapter("SELECT * FROM tblekspedisi WHERE " & field & " LIKE '%" & txtSearch.Text & "%'", CONN)
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