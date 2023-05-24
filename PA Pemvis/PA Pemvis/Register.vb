Imports MySql.Data.MySqlClient

Public Class Register

    Sub clear()
        txtNama.Text = ""
        txtPassword.Text = ""
        txtKonfirmasi.Text = ""
        txtNama.Text = ""
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtNama.Text = "" Or txtUser.Text = "" Or txtPassword.Text = "" Or txtKonfirmasi.Text = "" Then
            MessageBox.Show("Form Register Belum Lengkap Mohon Dilengkapi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Call koneksi()
            CMD = New MySqlCommand("Select * From tblAkun where username ='" & txtUser.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                RD.Close()
                CMD.Dispose()

                MessageBox.Show("Username Telah Terdaftar Gunakan Username Lain", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not RD.HasRows Then
                RD.Close()
                CMD.Dispose()

                If txtPassword.Text = txtKonfirmasi.Text Then
                    Dim register As String = "insert into tblakun (username, password, nama, role) values('" & txtUser.Text & "','" & txtPassword.Text & "','" & txtNama.Text & "','User')"
                    CMD = New MySqlCommand(register, CONN)
                    CMD.ExecuteNonQuery()
                    CMD.Dispose()

                    MsgBox("Register Sukses...........|", MsgBoxStyle.Information, "Perhatian")
                    clear()
                    Me.Close()
                    Login.loadData()
                    Login.Show()
                Else
                    MessageBox.Show("Password Dan Konfirmasi Password Tidak Sama", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtPassword.Text = ""
                    txtKonfirmasi.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        txtPassword.PasswordChar = "*"c
    End Sub

    Private Sub txtKonfirmasi_TextChanged(sender As Object, e As EventArgs) Handles txtKonfirmasi.TextChanged
        txtKonfirmasi.PasswordChar = "*"c
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
        Login.loadData()
        Login.Show()
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            txtNama.Focus()
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            txtPassword.Focus()
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            txtKonfirmasi.Focus()
        End If
    End Sub

    Private Sub txtKonfirmasi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKonfirmasi.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            btnSubmit.Focus()
        End If
    End Sub

End Class