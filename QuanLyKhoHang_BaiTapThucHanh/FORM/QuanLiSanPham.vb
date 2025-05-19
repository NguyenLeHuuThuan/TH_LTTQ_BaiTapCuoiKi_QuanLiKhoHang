Imports System.Data.SqlClient
Public Class QuanLiSanPham
    Dim ketNoiSQL As String = Database.connectionString
    Dim currentRowIndex As Integer = -1
    Private Sub QuanLiSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QuanLyKhoHangDataSet1.SanPham' table. You can move, or remove it, as needed.
        Me.SanPhamTableAdapter.Fill(Me.QuanLyKhoHangDataSet1.SanPham)

    End Sub
    Private Sub clearText()
        txt_DonVi.Text = ""
        txt_MaSanPham.Text = ""
        txt_TenSanPham.Text = ""
        txt_MaSoSanPham.Text = ""
        txt_SoLuong.Text = ""
        txt_MoTa.Text = ""
    End Sub
    Private Sub HienThiDuLieuHienTai()
        If currentRowIndex >= 0 AndAlso currentRowIndex < DataGridView1.Rows.Count Then
            Dim row As DataGridViewRow = DataGridView1.Rows(currentRowIndex)
            txt_MaSanPham.Text = row.Cells(0).Value.ToString()
            txt_MaSoSanPham.Text = row.Cells(1).Value.ToString()
            txt_TenSanPham.Text = row.Cells(2).Value.ToString()
            txt_MoTa.Text = row.Cells(3).Value.ToString()
            txt_DonVi.Text = row.Cells(4).Value.ToString()
            txt_SoLuong.Text = row.Cells(5).Value.ToString()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            currentRowIndex = e.RowIndex
            HienThiDuLieuHienTai()
        End If
    End Sub

    Private Sub btn_Them_Click(sender As Object, e As EventArgs) Handles btn_Them.Click
        Dim MaSoSanPham As String = txt_MaSoSanPham.Text.Trim()
        Dim TenSanPham As String = txt_TenSanPham.Text.Trim()
        Dim MoTa As String = txt_MoTa.Text.Trim()
        Dim DonVi As String = txt_DonVi.Text.Trim()
        Dim SoLuong As Integer = txt_SoLuong.Text.Trim()

        Try
            Using con As New SqlConnection(connectionString)
                Dim query As String = "INSERT INTO SanPham (MaSoSanPham, TenSanPham, MoTa, DonVi, SoLuongTon)" &
                                                          " VALUES (@MaSoSanPham, @TenSanPham, @MoTa, @DonVi, @SoLuong)"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@MaSoSanPham", MaSoSanPham)
                    cmd.Parameters.AddWithValue("@TenSanPham", TenSanPham)
                    cmd.Parameters.AddWithValue("@MoTa", MoTa)
                    cmd.Parameters.AddWithValue("@DonVi", DonVi)
                    cmd.Parameters.AddWithValue("@SoLuong", SoLuong)
                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Cập nhật lại DataGridView
            Me.SanPhamTableAdapter.Fill(Me.QuanLyKhoHangDataSet1.SanPham)

            clearText()

        Catch ex As Exception
            MessageBox.Show("Lỗi khi lưu: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_Xoa_Click(sender As Object, e As EventArgs) Handles btn_Xoa.Click
        Try
            Dim MaSanPham As String = txt_MaSanPham.Text.Trim()
            If String.IsNullOrEmpty(MaSanPham) Then
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Using con As New SqlConnection(connectionString)
                Dim query As String = "delete from SanPham where MaSanPham = @MaSanPham"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@MaSanPham", MaSanPham)

                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Cập nhật lại DataGridView
            Me.SanPhamTableAdapter.Fill(Me.QuanLyKhoHangDataSet1.SanPham)

            clearText()

        Catch ex As Exception
            MessageBox.Show("Lỗi khi Xoá: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_Sua_Click(sender As Object, e As EventArgs) Handles btn_Sua.Click
        Try
            Dim MaSanPham As String = txt_MaSanPham.Text.Trim()
            Dim MaSoSanPham As String = txt_MaSoSanPham.Text.Trim()
            Dim TenSanPham As String = txt_TenSanPham.Text.Trim()
            Dim MoTa As String = txt_MoTa.Text.Trim()
            Dim DonVi As String = txt_DonVi.Text.Trim()
            Dim SoLuong As Integer = txt_SoLuong.Text.Trim()

            If String.IsNullOrEmpty(MaSanPham) Then
                MessageBox.Show("Vui lòng chọn sản phẩm để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Using con As New SqlConnection(connectionString)
                Dim query As String = "update SanPham set MaSoSanPham = @MaSoSanPham ," &
                                                          "TenSanPham = @TenSanPham, " &
                                                          "MoTa = @MoTa, " &
                                                           "DonVi = @DonVi, " &
                                                           "SoLuongTon = @SoLuong " &
                                                           "where MaSanPham = @MaSanPham"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@MaSanPham", MaSanPham)
                    cmd.Parameters.AddWithValue("@MaSoSanPham", MaSoSanPham)
                    cmd.Parameters.AddWithValue("@TenSanPham", TenSanPham)
                    cmd.Parameters.AddWithValue("@MoTa", MoTa)
                    cmd.Parameters.AddWithValue("@DonVi", DonVi)
                    cmd.Parameters.AddWithValue("@SoLuong", SoLuong)
                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("update thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Cập nhật lại DataGridView
            Me.SanPhamTableAdapter.Fill(Me.QuanLyKhoHangDataSet1.SanPham)
            clearText()

        Catch ex As Exception
            MessageBox.Show("Lỗi khi update: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function GetSanPhamHetHang() As DataTable
        Dim dt As New DataTable()
        Try
            Using con As New SqlConnection(connectionString)
                Dim query As String = "SELECT * FROM SanPham WHERE SoLuongTon = 0"
                Using cmd As New SqlCommand(query, con)
                    con.Open()
                    Dim adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi khi lấy sản phẩm hết hàng: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Private Sub btn_ThongKe_Click(sender As Object, e As EventArgs) Handles btn_ThongKe.Click
        ' Lấy dữ liệu sản phẩm hết hàng
        Dim dtHetHang As DataTable = GetSanPhamHetHang()

        ' Gán DataTable làm nguồn dữ liệu cho DataGridView
        DataGridView1.DataSource = dtHetHang
    End Sub

    Private Sub btn_LamMoi_Click(sender As Object, e As EventArgs) Handles btn_LamMoi.Click
        clearText()
        Try
            ' Tải lại dữ liệu vào DataSet
            Me.SanPhamTableAdapter.Fill(Me.QuanLyKhoHangDataSet1.SanPham)

            ' Gán lại nguồn dữ liệu cho DataGridView1 là bảng SanPham trong DataSet
            DataGridView1.DataSource = Me.QuanLyKhoHangDataSet1.SanPham

        Catch ex As Exception
            MessageBox.Show("Lỗi khi làm mới dữ liệu: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class