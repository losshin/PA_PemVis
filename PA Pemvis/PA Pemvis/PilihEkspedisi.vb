Imports MySql.Data.MySqlClient

Public Class PilihEkspedisi
    Sub tampilData()

        Dim asal As String = CreatePesanan.cmbAsal.SelectedItem
        Dim tujuan As String = CreatePesanan.cmbTujuan.SelectedItem
        Dim sql As String = "SELECT * FROM tblekspedisi WHERE asal = @asal AND tujuan = @tujuan"

        DA = New MySqlDataAdapter(sql, CONN)
        DA.SelectCommand.Parameters.AddWithValue("@asal", asal)
        DA.SelectCommand.Parameters.AddWithValue("@tujuan", tujuan)

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

        Dim headers() As String = {"ID", "Asal", "Tujuan", "Nama", "Harga", "Estimasi"}
        For i As Integer = 0 To dgvEkspedisi.Columns.Count - 1
            dgvEkspedisi.Columns(i).HeaderText = headers(i)
        Next i
    End Sub
    Private Sub PilihEkspedisi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvEkspedisi.RowHeadersVisible = False
        Me.CenterToScreen()
        txtPilih.Enabled = False
        tampilData()
        aturGrid()

    End Sub


    Private Sub dgvEkspedisi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEkspedisi.CellClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvEkspedisi.Rows(e.RowIndex)
            txtPilih.Text = row.Cells(0).Value.ToString()
        End If

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If txtPilih.Text = "" Then
            MessageBox.Show("Belum Ada Ekspedisi Yang Dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            CreatePesanan.txtTotal.Text = ""
            CreatePesanan.txtIDekspedisi.Text = txtPilih.Text
            CreatePesanan.sinkronData()
            Me.Close()
            CreatePesanan.Show()

        End If


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()
        CreatePesanan.Show()

    End Sub

End Class