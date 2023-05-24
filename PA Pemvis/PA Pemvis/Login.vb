Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Login

    Public Sub loadData()
        txtPassword.Text = ""
        txtUser.Text = ""
        Me.CenterToScreen()
    End Sub
    Public Property id_akun As String
    Public Property id_ekspedisi As String
    Public Property id_pesanan As String
    Public Property pengguna As String = ""
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUser.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Username Atau Password Masih Kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Call koneksi()
            CMD = New MySqlCommand("Select * From tblAkun where username ='" & txtUser.Text & "' and password='" & txtPassword.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                Dim role As String = RD("role").ToString()
                id_akun = RD("id_akun").ToString
                If role = "Admin" Then
                    Me.Visible = False
                    pengguna = "Admin"
                    MenuAdmin.Show()
                    RD.Close()
                ElseIf role = "User" Then
                    Me.Visible = False
                    pengguna = "User"
                    MenuUser.Show()
                    RD.Close()
                End If

            ElseIf Not RD.HasRows Then
                RD.Close()
                MessageBox.Show("Periksa Kembali User Dan Password", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUser.Focus()
                txtUser.Text = ""
                txtPassword.Text = ""
            End If
        End If


    End Sub

    Private Sub btnRegis_Click(sender As Object, e As EventArgs) Handles btnRegis.Click

        Me.Hide()
        Register.Show()

    End Sub

    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            txtPassword.Focus()
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            btnLogin.Focus()
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        txtPassword.PasswordChar = "*"c
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
        txtUser.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
