Public Class MenuUser
    Private Sub MenuUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btnPesan_Click(sender As Object, e As EventArgs) Handles btnPesan.Click

        CreatePesanan.Show()
        Me.Close()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Login.loadData()
        Me.Close()
        Login.Show()

    End Sub

    Private Sub BtnPemesanan_Click(sender As Object, e As EventArgs) Handles BtnPemesanan.Click

        ReadPesanan.Show()
        Me.Close()

    End Sub
End Class