Imports System.Data.SqlClient
Imports System.Globalization
Public Class PhieuNhap
    Dim currentRowIndex As Integer = -1
    Private Sub PhieuNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Pro_PhieuNhapTableAdapter.Fill(Me.QuanLyKhoHangDataSet3.pro_PhieuNhap)
        LoadDataToCombobox()
        LoadPhieuNhap()
        LoadSanPhamToComboBox()
    End Sub
    Private Sub LoadPhieuNhap()

        Dim query = "pro_PhieuNhap"

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()

                Dim cmd As New SqlCommand(query, conn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                ' Xóa các cột & dòng cũ
                DataGridView1.Columns.Clear()
                DataGridView1.Rows.Clear()
                DataGridView1.AutoGenerateColumns = False

                ' Tạo các cột thủ công
                DataGridView1.Columns.Add("MaGiaoDich", "Mã Giao Dịch")
                DataGridView1.Columns.Add("MaSanPham", "Mã Sản Phẩm")
                DataGridView1.Columns.Add("LoaiGiaoDich", "Loại Giao Dịch")
                DataGridView1.Columns.Add("SoLuong", "Số Lượng")
                DataGridView1.Columns.Add("NgayGiaoDich", "Ngày Giao Dịch")
                DataGridView1.Columns.Add("MaNhaCungCap", "Mã Nhà Cung Cấp")
                DataGridView1.Columns.Add("GhiChu", "Ghi Chú")

                ' Đổ dữ liệu dòng theo reader
                While reader.Read()
                    DataGridView1.Rows.Add(
                    reader("MaGiaoDich"),
                    reader("MaSanPham"),
                    reader("LoaiGiaoDich"),
                    reader("SoLuong"),
                    CDate(reader("NgayGiaoDich")).ToString("yyyy-MM-dd"),
                    If(IsDBNull(reader("MaNhaCungCap")), "", reader("MaNhaCungCap")),
                    reader("GhiChu").ToString()
                )
                End While

                reader.Close()

            Catch ex As Exception
                MessageBox.Show("Lỗi khi tải dữ liệu phiếu nhập: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadSanPhamToComboBox()


        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT MaSanPham, TenSanPham FROM SanPham"
                Dim cmd As New SqlCommand(query, conn)
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                cb_Ma_TenSP.Items.Clear()

                While reader.Read()
                    Dim ma As Integer = reader("MaSanPham")
                    Dim ten As String = reader("TenSanPham").ToString()
                    cb_Ma_TenSP.Items.Add(ma & ". " & ten)
                End While

                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Lỗi khi tải sản phẩm: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadDataToCombobox()
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT MaNhaCungCap, TenNhaCungCap FROM NhaCungCap"
                Dim cmd As New SqlCommand(query, conn)
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                cb_MaNCC.Items.Clear()

                While reader.Read()
                    Dim ma As Integer = reader("MaNhaCungCap")
                    Dim ten As String = reader("TenNhaCungCap").ToString()
                    cb_MaNCC.Items.Add(ma & ". " & ten)
                End While

                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Lỗi khi tải nhà cung cấp: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub clearText()
        cb_Ma_TenSP.Text = ""
        txt_MaGiaoDich.Text = ""
        txt_SoLuong.Text = ""
        txt_NgayGiaoDich.Text = ""
        txt_GhiChu.Text = ""
        cb_MaNCC.Text = ""
    End Sub

    Private Sub btn_Them_Click(sender As Object, e As EventArgs) Handles btn_Them.Click
        Dim MaSanPham As String = cb_Ma_TenSP.Text.Trim()
        Dim MaNhaCungCap As String = cb_MaNCC.Text.Trim() ' Sử dụng Object để có thể gán DBNull.Value
        Dim NgayGiaoDich As DateTime
        Dim SoLuong As Integer
        Dim GhiChu As String = txt_GhiChu.Text.Trim()
        Dim ngayLuuTru As String

        ' Trích xuất MaSanPham từ chuỗi "1.NguyenA", "2.NguyenB", ...
        Dim parts() As String = MaSanPham.Split("."c) ' Tách chuỗi dựa vào dấu chấm
        If parts.Length > 0 Then
            MaSanPham = parts(0).Trim() ' Lấy phần tử đầu tiên (số) và loại bỏ khoảng trắng
        Else
            MessageBox.Show("Mã sản phẩm không đúng định dạng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'trích suất mã nhà cung cấp
        Dim MaNCCC() As String = MaNhaCungCap.Split("."c) ' Tách chuỗi dựa vào dấu chấm
        If MaNCCC.Length > 0 Then
            MaNhaCungCap = MaNCCC(0).Trim() ' Lấy phần tử đầu tiên (số) và loại bỏ khoảng trắng
        Else
            MessageBox.Show("Mã nhà cung cấp không đúng định dạng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        ' Xử lý ngày tháng
        If DateTime.TryParseExact(txt_NgayGiaoDich.Text.Trim(), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, NgayGiaoDich) Then
            ngayLuuTru = NgayGiaoDich.ToString("yyyy-MM-dd")
        Else
            MessageBox.Show("Vui lòng nhập ngày theo định dạng<\ctrl3348>-MM-dd ", "Lỗi định dạng ngày", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub ' Dừng việc xử lý nếu định dạng ngày không hợp lệ
        End If

        ' Xử lý số lượng
        If Not Integer.TryParse(txt_SoLuong.Text.Trim(), SoLuong) Then
            MessageBox.Show("Vui lòng nhập số lượng hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        MessageBox.Show("MaNhaCungCap: " & MaNhaCungCap.ToString())
        Debug.WriteLine("MaNhaCungCap: " & MaNhaCungCap.ToString())
        Try
            Using con As New SqlConnection(connectionString)
                Dim query As String = "INSERT INTO LichSuGiaoDich (MaSanPham, LoaiGiaoDich, SoLuong, NgayGiaoDich, MaNhaCungCap, GhiChu)" &
                                    " VALUES (@MaSanPham, @LoaiGiaoDich, @SoLuong, @NgayGiaoDich, @MaNhaCungCap, @GhiChu)"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@MaSanPham", MaSanPham)
                    cmd.Parameters.AddWithValue("@LoaiGiaoDich", "Nhap")
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
            'Me.Pro_PhieuNhapTableAdapter.Fill(Me.QuanLyKhoHangDataSet3.pro_PhieuNhap)
            LoadPhieuNhap()
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
            'Me.Pro_PhieuNhapTableAdapter.Fill(Me.QuanLyKhoHangDataSet3.pro_PhieuNhap)
            LoadPhieuNhap()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi Xoá: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_Sua_Click(sender As Object, e As EventArgs) Handles btn_Sua.Click
        Dim MaGiaoDich As String = txt_MaGiaoDich.Text.Trim()
        Dim MaSanPham As String = cb_Ma_TenSP.Text.Trim()
        Dim MaNhaCungCap As String = cb_MaNCC.Text.Trim()
        Dim NgayGiaoDich As DateTime
        Dim SoLuong As Integer
        Dim GhiChu As String = txt_GhiChu.Text.Trim()
        Dim ngayLuuTru As String = "" ' Khai báo biến để lưu trữ ngày đã định dạng

        ' Xử lý MaNhaCungCap để có thể nhận giá trị NULL
        Dim MaNCC() As String = MaNhaCungCap.Split("."c) ' Tách chuỗi dựa vào dấu chấm
        If MaNCC.Length > 0 Then
            MaNhaCungCap = MaNCC(0).Trim() ' Lấy phần tử đầu tiên (số) và loại bỏ khoảng trắng
        Else
            MessageBox.Show("Mã sản phẩm không đúng định dạng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        ' Trích xuất MaSanPham từ chuỗi "1.NguyenA", "2.NguyenB", ...
        Dim parts() As String = MaSanPham.Split("."c) ' Tách chuỗi dựa vào dấu chấm
        If parts.Length > 0 Then
            MaSanPham = parts(0).Trim() ' Lấy phần tử đầu tiên (số) và loại bỏ khoảng trắng
        Else
            MessageBox.Show("Mã sản phẩm không đúng định dạng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
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
            'Me.Pro_PhieuNhapTableAdapter.Fill(Me.QuanLyKhoHangDataSet3.pro_PhieuNhap)
            LoadPhieuNhap()
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
            cb_Ma_TenSP.Text = row.Cells(1).Value.ToString()
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class
