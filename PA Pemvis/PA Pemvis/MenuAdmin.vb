Public Class MenuAdmin

    Private Sub btnEkspedisi_Click(sender As Object, e As EventArgs) Handles btnEkspedisi.Click
        Me.Close()
        ReadEkspedisi.Show()
    End Sub

    Private Sub BtnPemesanan_Click(sender As Object, e As EventArgs) Handles BtnPemesanan.Click

        Me.Close()
        ReadPesanan.Show()

    End Sub

    Private Sub btnPesan_Click(sender As Object, e As EventArgs) Handles btnPesan.Click
        Me.Close()
        CreatePesanan.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()
        Login.loadData()
        Login.Show()

    End Sub

    Private Sub MenuAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

End Class