Imports System.Data.SqlClient
Imports System.Globalization
Public Class PhieuXuat
    Dim currentRowIndex As Integer = -1
    Private Sub PhieuXuat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QuanLyKhoHangDataSet4.pro_PhieuXuat' table. You can move, or remove it, as needed.
        Me.Pro_PhieuXuatTableAdapter.Fill(Me.QuanLyKhoHangDataSet4.pro_PhieuXuat)
        LoadDataToCombobox()
    End Sub
    Private Sub LoadDataToCombobox()
        Dim query As String = "SELECT MaNhaCungCap FROM NhaCungCap"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                Try
                    connection.Open()
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            ' Thay thế YourColumnName bằng tên cột bạn muốn hiển thị trong ComboBox
                            cb_MaNCC.Items.Add(reader("MaNhaCungCap").ToString())
                        End While
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Lỗi khi tải dữ liệu: " & ex.Message)
                Finally
                    If connection.State = ConnectionState.Open Then
                        connection.Close()
                    End If
                End Try
            End Using
        End Using
    End Sub

    Private Sub clearText()
        txt_MaSanPham.Text = ""
        txt_MaGiaoDich.Text = ""
        txt_SoLuong.Text = ""
        txt_NgayGiaoDich.Text = ""
        txt_GhiChu.Text = ""
        cb_MaNCC.Text = ""
    End Sub

    Private Sub btn_Them_Click(sender As Object, e As EventArgs) Handles btn_Them.Click
        Dim MaSanPham As String = txt_MaSanPham.Text.Trim()
        Dim MaNhaCungCap As Object ' Sử dụng Object để có thể gán DBNull.Value
        Dim NgayGiaoDich As DateTime
        Dim SoLuong As Integer
        Dim GhiChu As String = txt_GhiChu.Text.Trim()
        Dim ngayLuuTru As String

        ' Xử lý ngày tháng
        If DateTime.TryParseExact(txt_NgayGiaoDich.Text.Trim(), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, NgayGiaoDich) Then
            ngayLuuTru = NgayGiaoDich.ToString("yyyy-MM-dd")
        Else
            MessageBox.Show("Vui lòng nhập ngày theo định dạng<ctrl3348>-MM-dd ", "Lỗi định dạng ngày", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub ' Dừng việc xử lý nếu định dạng ngày không hợp lệ
        End If

        ' Xử lý số lượng
        If Not Integer.TryParse(txt_SoLuong.Text.Trim(), SoLuong) Then
            MessageBox.Show("Vui lòng nhập số lượng hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Xử lý MaNhaCungCap để có thể nhận giá trị NULL
        If String.IsNullOrWhiteSpace(cb_MaNCC.Text) Then
            MaNhaCungCap = DBNull.Value ' Gán DBNull.Value nếu ComboBox rỗng
        Else
            MaNhaCungCap = cb_MaNCC.Text.Trim() ' Lấy giá trị đã chọn/nhập
        End If

        Try
            Using con As New SqlConnection(connectionString)
                Dim query As String = "INSERT INTO LichSuGiaoDich (MaSanPham, LoaiGiaoDich, SoLuong, NgayGiaoDich, MaNhaCungCap, GhiChu)" &
                                        " VALUES (@MaSanPham, @LoaiGiaoDich, @SoLuong, @NgayGiaoDich, @MaNhaCungCap, @GhiChu)"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@MaSanPham", MaSanPham)
                    cmd.Parameters.AddWithValue("@LoaiGiaoDich", "Xuat")
                    cmd.Parameters.AddWithValue("@SoLuong", SoLuong)
                    cmd.Parameters.AddWithValue("@NgayGiaoDich", ngayLuuTru)
                    cmd.Parameters.AddWithValue("@MaNhaCungCap", MaNhaCungCap) ' Sử dụng biến MaNhaCungCap đã xử lý
                    cmd.Parameters.AddWithValue("@GhiChu", GhiChu)

                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Cập nhật lại DataGridView
            Me.Pro_PhieuXuatTableAdapter.Fill(Me.QuanLyKhoHangDataSet4.pro_PhieuXuat)

            clearText()

        Catch ex As Exception
            MessageBox.Show("Lỗi khi lưu: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btn_Xoa_Click(sender As Object, e As EventArgs) Handles btn_Xoa.Click
        Dim MaGiaoDich As String = txt_MaGiaoDich.Text.Trim()
        If String.IsNullOrEmpty(MaGiaoDich) Then
            MessageBox.Show("Vui lòng chọn giao dịch để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Try
            Using con As New SqlConnection(connectionString)
                Dim query As String = "DELETE FROM LichSuGiaoDich WHERE MaGiaoDich = @MaGiaoDich"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@MaGiaoDich", MaGiaoDich)
                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Pro_PhieuXuatTableAdapter.Fill(Me.QuanLyKhoHangDataSet4.pro_PhieuXuat)
        Catch ex As Exception
            MessageBox.Show("Lỗi khi Xoá: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_Sua_Click(sender As Object, e As EventArgs) Handles btn_Sua.Click
        Dim MaGiaoDich As String = txt_MaGiaoDich.Text.Trim()
        Dim MaSanPham As String = txt_MaSanPham.Text.Trim()
        Dim MaNhaCungCap As Object ' Sử dụng Object để có thể gán DBNull.Value
        Dim NgayGiaoDich As DateTime
        Dim SoLuong As Integer
        Dim GhiChu As String = txt_GhiChu.Text.Trim()
        Dim ngayLuuTru As String = "" ' Khai báo biến để lưu trữ ngày đã định dạng

        ' Xử lý ngày tháng
        If DateTime.TryParseExact(txt_NgayGiaoDich.Text.Trim(), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, NgayGiaoDich) Then
            ' Chuyển đổi thành công theo định dạng<ctrl98>-MM-dd
            ngayLuuTru = NgayGiaoDich.ToString("yyyy-MM-dd")

        ElseIf DateTime.TryParseExact(txt_NgayGiaoDich.Text.Trim(), "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, NgayGiaoDich) Then
            ' Chuyển đổi thành công theo định dạng dd-MM-yyyy
            ngayLuuTru = NgayGiaoDich.ToString("yyyy-MM-dd") ' Chuyển đổi về<ctrl98>-MM-dd

        Else
            MessageBox.Show("Vui lòng nhập ngày theo định dạng<ctrl98>-MM-dd hoặc dd-MM-yyyy.", "Lỗi định dạng ngày", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub ' Dừng việc xử lý nếu định dạng ngày không hợp lệ
        End If

        ' Xử lý số lượng
        If Not Integer.TryParse(txt_SoLuong.Text.Trim(), SoLuong) Then
            MessageBox.Show("Vui lòng nhập số lượng hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Xử lý MaNhaCungCap để có thể nhận giá trị NULL
        If String.IsNullOrWhiteSpace(cb_MaNCC.Text) Then
            MaNhaCungCap = DBNull.Value ' Gán DBNull.Value nếu ComboBox rỗng
        Else
            MaNhaCungCap = cb_MaNCC.Text.Trim() ' Lấy giá trị đã chọn/nhập
        End If

        If String.IsNullOrEmpty(MaGiaoDich) Then
            MessageBox.Show("Vui lòng chọn giao dịch để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using con As New SqlConnection(connectionString)
                Dim query As String = "UPDATE LichSuGiaoDich SET MaSanPham = @MaSanPham ," &
                                    "SoLuong = @SoLuong, " &
                                    "NgayGiaoDich = @NgayGiaoDich, " &
                                    "MaNhaCungCap = @MaNhaCungCap, " &
                                    "GhiChu = @GhiChu " &
                                    "WHERE MaGiaoDich = @MaGiaoDich"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@MaSanPham", MaSanPham)
                    cmd.Parameters.AddWithValue("@SoLuong", SoLuong)
                    cmd.Parameters.AddWithValue("@NgayGiaoDich", ngayLuuTru)
                    cmd.Parameters.AddWithValue("@MaNhaCungCap", MaNhaCungCap) ' Sử dụng biến MaNhaCungCap đã xử lý
                    cmd.Parameters.AddWithValue("@GhiChu", GhiChu)
                    cmd.Parameters.AddWithValue("@MaGiaoDich", MaGiaoDich)
                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Pro_PhieuXuatTableAdapter.Fill(Me.QuanLyKhoHangDataSet4.pro_PhieuXuat)
        Catch ex As Exception
            MessageBox.Show("Lỗi khi sửa: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_LamMoi_Click(sender As Object, e As EventArgs) Handles btn_LamMoi.Click
        clearText()
    End Sub

    Private Sub HienThiDuLieuHienTai()
        If currentRowIndex >= 0 AndAlso currentRowIndex < DataGridView1.Rows.Count Then
            Dim row As DataGridViewRow = DataGridView1.Rows(currentRowIndex)
            txt_MaGiaoDich.Text = row.Cells(0).Value.ToString()
            txt_MaSanPham.Text = row.Cells(1).Value.ToString()
            txt_SoLuong.Text = row.Cells(3).Value.ToString()
            ' Lấy giá trị ngày từ DataGridView (giả sử cột ngày có index 2 HOẶC 4 - bạn đang gán cho txt_NgayGiaoDich hai lần)
            Dim ngayGiaoDichValue As Object = row.Cells(4).Value ' Hoặc row.Cells(4).Value tùy thuộc vào cột ngày thực tế


            If ngayGiaoDichValue IsNot Nothing AndAlso TypeOf ngayGiaoDichValue Is Date Then
                Dim ngayDaDinhDang As String = DirectCast(ngayGiaoDichValue, Date).ToString("yyyy-MM-dd")
                txt_NgayGiaoDich.Text = ngayDaDinhDang
            Else

                txt_NgayGiaoDich.Text = ngayGiaoDichValue?.ToString()
            End If



            cb_MaNCC.Text = row.Cells(5).Value.ToString()
            txt_GhiChu.Text = row.Cells(6).Value.ToString()

        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            currentRowIndex = e.RowIndex
            HienThiDuLieuHienTai()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class