Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D

Public Class FormDangNhap
    Private Sub FormDangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.ForeColor = Color.White
        txtUsername.Font = New Font("Segoe UI", 10, FontStyle.Regular)

        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.ForeColor = Color.White
        txtPassword.Font = New Font("Segoe UI", 10, FontStyle.Regular)

        txtPassword.UseSystemPasswordChar = True

        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.BackColor = Color.Teal
        btnLogin.ForeColor = Color.White
        btnLogin.Font = New Font("Segoe UI", 12, FontStyle.Bold)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        Try
            conn.Open()
            Dim query As String = "SELECT HoTen FROM Admin WHERE TenDangNhap = @user AND MatKhau = @pass"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@user", username)
            cmd.Parameters.AddWithValue("@pass", password)

            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing Then
                Dim hoTen As String = result.ToString()
                Dim ngayDangNhap As DateTime = DateTime.Now

                Dim formTrangChu As New FormTrangChu(hoTen, ngayDangNhap)
                Me.Hide()
                formTrangChu.Show()
            Else
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class