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
        Dim MaNhaCungCap As String = cb_MaNCC.Text.Trim()
        Dim NgayGiaoDich As DateTime
        Dim SoLuong As Integer
        Dim GhiChu As String = txt_GhiChu.Text.Trim()
        Dim ngayLuuTru As String

        ' Trích xuất Mã Sản Phẩm từ chuỗi "1.NguyenA", "2.NguyenB", ...
        Dim parts() As String = MaSanPham.Split("."c)
        If parts.Length > 0 Then
            MaSanPham = parts(0).Trim()
        Else
            MessageBox.Show("Mã sản phẩm không đúng định dạng. Vui lòng chọn lại.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Trích xuất Mã Nhà Cung Cấp từ chuỗi
        Dim MaNCCC() As String = MaNhaCungCap.Split("."c)
        If MaNCCC.Length > 0 Then
            MaNhaCungCap = MaNCCC(0).Trim()
        Else
            MessageBox.Show("Mã nhà cung cấp không đúng định dạng. Vui lòng chọn lại.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Xử lý ngày tháng
        If DateTime.TryParseExact(txt_NgayGiaoDich.Text.Trim(), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, NgayGiaoDich) Then
            ngayLuuTru = NgayGiaoDich.ToString("yyyy-MM-dd")
        Else
            MessageBox.Show("Vui lòng nhập ngày theo định dạng yyyy-MM-dd.", "Lỗi định dạng ngày", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Xử lý số lượng
        If Not Integer.TryParse(txt_SoLuong.Text.Trim(), SoLuong) Then
            MessageBox.Show("Vui lòng nhập số lượng hợp lệ (số nguyên).", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Using con As New SqlConnection(connectionString)
                Dim query As String = "INSERT INTO LichSuGiaoDich (MaSanPham, LoaiGiaoDich, SoLuong, NgayGiaoDich, MaNhaCungCap, GhiChu) " &
                                  "VALUES (@MaSanPham, @LoaiGiaoDich, @SoLuong, @NgayGiaoDich, @MaNhaCungCap, @GhiChu)"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@MaSanPham", MaSanPham)
                    cmd.Parameters.AddWithValue("@LoaiGiaoDich", "Nhap")
                    cmd.Parameters.AddWithValue("@SoLuong", SoLuong)
                    cmd.Parameters.AddWithValue("@NgayGiaoDich", ngayLuuTru)
                    cmd.Parameters.AddWithValue("@MaNhaCungCap", MaNhaCungCap)
                    cmd.Parameters.AddWithValue("@GhiChu", GhiChu)

                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Thêm phiếu nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadPhieuNhap()
            clearText()

        Catch ex As Exception
            MessageBox.Show("Đã xảy ra lỗi khi lưu dữ liệu: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btn_Xoa_Click(sender As Object, e As EventArgs) Handles btn_Xoa.Click
        Dim MaGiaoDich As Integer
        If Not Integer.TryParse(txt_MaGiaoDich.Text.Trim(), MaGiaoDich) Then
            MessageBox.Show("Vui lòng chọn giao dịch hợp lệ để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using con As New SqlConnection(connectionString)
            con.Open()
            Using tran = con.BeginTransaction()
                Try
                    ' Lấy thông tin phiếu nhập cần xóa
                    Dim queryGet As String = "SELECT MaSanPham, SoLuong, LoaiGiaoDich FROM LichSuGiaoDich WHERE MaGiaoDich = @MaGiaoDich"
                    Dim MaSanPham As Integer = 0
                    Dim SoLuong As Integer = 0
                    Dim LoaiGiaoDich As String = ""
                    Using cmdGet As New SqlCommand(queryGet, con, tran)
                        cmdGet.Parameters.AddWithValue("@MaGiaoDich", MaGiaoDich)
                        Using reader = cmdGet.ExecuteReader()
                            If reader.Read() Then
                                MaSanPham = Convert.ToInt32(reader("MaSanPham"))
                                SoLuong = Convert.ToInt32(reader("SoLuong"))
                                LoaiGiaoDich = reader("LoaiGiaoDich").ToString()
                            Else
                                MessageBox.Show("Không tìm thấy giao dịch để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                tran.Rollback()
                                Return
                            End If
                        End Using
                    End Using

                    ' Chỉ kiểm tra tồn kho nếu xóa phiếu NHẬP (vì xóa phiếu nhập sẽ làm giảm tồn)
                    If LoaiGiaoDich = "Nhap" Then
                        ' Lấy tồn kho hiện tại
                        Dim queryTon As String = "SELECT SoLuongTon FROM SanPham WHERE MaSanPham = @MaSanPham"
                        Dim soLuongTon As Integer = 0
                        Using cmdTon As New SqlCommand(queryTon, con, tran)
                            cmdTon.Parameters.AddWithValue("@MaSanPham", MaSanPham)
                            Dim result = cmdTon.ExecuteScalar()
                            If result IsNot Nothing Then
                                soLuongTon = Convert.ToInt32(result)
                            End If
                        End Using

                        ' Kiểm tra tồn kho nếu xóa nhập làm tồn < 0
                        If soLuongTon - SoLuong < 0 Then
                            MessageBox.Show("Không thể xóa phiếu nhập này vì sẽ làm tồn kho âm.", "Lỗi tồn kho", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            tran.Rollback()
                            Return
                        End If
                    End If

                    ' Thực hiện xóa
                    Dim queryDelete As String = "DELETE FROM LichSuGiaoDich WHERE MaGiaoDich = @MaGiaoDich"
                    Using cmdDelete As New SqlCommand(queryDelete, con, tran)
                        cmdDelete.Parameters.AddWithValue("@MaGiaoDich", MaGiaoDich)
                        cmdDelete.ExecuteNonQuery()
                    End Using

                    tran.Commit()
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadPhieuNhap() ' Hoặc LoadPhieuXuat() tùy bạn
                Catch ex As Exception
                    tran.Rollback()
                    MessageBox.Show("Lỗi khi xóa: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btn_Sua_Click(sender As Object, e As EventArgs) Handles btn_Sua.Click
        Dim GhiChu As String = txt_GhiChu.Text.Trim()
        Dim MaGiaoDich As Integer

        If Not Integer.TryParse(txt_MaGiaoDich.Text.Trim(), MaGiaoDich) Then
            MessageBox.Show("Mã giao dịch không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Lấy mã sản phẩm mới và tách mã
        Dim MaSanPhamMoi As String = cb_Ma_TenSP.Text.Trim()
        Dim parts() As String = MaSanPhamMoi.Split("."c)
        If parts.Length > 0 Then
            MaSanPhamMoi = parts(0).Trim()
        Else
            MessageBox.Show("Mã sản phẩm không đúng định dạng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Xử lý ngày tháng
        Dim NgayGiaoDich As DateTime
        Dim ngayLuuTru As String = ""
        If DateTime.TryParseExact(txt_NgayGiaoDich.Text.Trim(), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, Globalization.DateTimeStyles.None, NgayGiaoDich) Then
            ngayLuuTru = NgayGiaoDich.ToString("yyyy-MM-dd")
        ElseIf DateTime.TryParseExact(txt_NgayGiaoDich.Text.Trim(), "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture, Globalization.DateTimeStyles.None, NgayGiaoDich) Then
            ngayLuuTru = NgayGiaoDich.ToString("yyyy-MM-dd")
        Else
            MessageBox.Show("Vui lòng nhập ngày theo định dạng yyyy-MM-dd hoặc dd-MM-yyyy.", "Lỗi định dạng ngày", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Xử lý số lượng
        Dim SoLuongMoi As Integer
        If Not Integer.TryParse(txt_SoLuong.Text.Trim(), SoLuongMoi) OrElse SoLuongMoi <= 0 Then
            MessageBox.Show("Vui lòng nhập số lượng hợp lệ (lớn hơn 0).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Xử lý mã nhà cung cấp
        Dim MaNhaCungCap As Object
        If String.IsNullOrWhiteSpace(cb_MaNCC.Text) Then
            MaNhaCungCap = DBNull.Value
        Else
            Dim MaNCC() As String = cb_MaNCC.Text.Split("."c)
            If MaNCC.Length > 0 Then
                MaNhaCungCap = MaNCC(0).Trim()
            Else
                MessageBox.Show("Mã nhà cung cấp không đúng định dạng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        Using con As New SqlConnection(connectionString)
            con.Open()
            Using tran = con.BeginTransaction()
                Try
                    ' Lấy dữ liệu phiếu nhập cũ
                    Dim queryOld = "SELECT MaSanPham, SoLuong FROM LichSuGiaoDich WHERE MaGiaoDich = @MaGiaoDich"
                    Dim MaSanPhamCu As String = ""
                    Dim SoLuongCu As Integer = 0
                    Using cmdOld As New SqlCommand(queryOld, con, tran)
                        cmdOld.Parameters.AddWithValue("@MaGiaoDich", MaGiaoDich)
                        Using reader = cmdOld.ExecuteReader()
                            If reader.Read() Then
                                MaSanPhamCu = reader("MaSanPham").ToString()
                                SoLuongCu = Convert.ToInt32(reader("SoLuong"))
                            Else
                                MessageBox.Show("Không tìm thấy giao dịch cần sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                tran.Rollback()
                                Exit Sub
                            End If
                        End Using
                    End Using

                    ' Lấy tồn kho hiện tại của sản phẩm mới
                    Dim queryTon As String = "SELECT SoLuongTon FROM SanPham WHERE MaSanPham = @MaSanPham"
                    Dim soLuongTon As Integer = 0
                    Using cmdTon As New SqlCommand(queryTon, con, tran)
                        cmdTon.Parameters.AddWithValue("@MaSanPham", MaSanPhamMoi)
                        Dim result = cmdTon.ExecuteScalar()
                        If result IsNot Nothing Then
                            soLuongTon = Convert.ToInt32(result)
                        End If
                    End Using

                    ' Tính tồn kho sau khi sửa phiếu nhập
                    ' Nếu đổi mã sản phẩm, tồn mới = tồn kho sản phẩm mới - số lượng nhập mới
                    ' và tồn cũ của sản phẩm cũ cộng lại số lượng cũ (tránh mất tồn kho cũ)
                    Dim tonSauSua As Integer
                    If MaSanPhamMoi = MaSanPhamCu Then
                        tonSauSua = soLuongTon - SoLuongMoi + SoLuongCu
                    Else
                        ' Kiểm tra tồn kho sản phẩm cũ để cộng lại số lượng cũ
                        Dim queryTonCu = "SELECT SoLuongTon FROM SanPham WHERE MaSanPham = @MaSanPham"
                        Dim soLuongTonCu As Integer = 0
                        Using cmdTonCu As New SqlCommand(queryTonCu, con, tran)
                            cmdTonCu.Parameters.AddWithValue("@MaSanPham", MaSanPhamCu)
                            Dim resultCu = cmdTonCu.ExecuteScalar()
                            If resultCu IsNot Nothing Then
                                soLuongTonCu = Convert.ToInt32(resultCu)
                            End If
                        End Using

                        tonSauSua = soLuongTon - SoLuongMoi ' tồn sản phẩm mới trừ đi số nhập mới
                        ' Không cập nhật tồn sản phẩm cũ ở đây vì trigger sẽ xử lý tự động
                        ' Chỉ kiểm tra tồn kho sản phẩm mới thôi
                    End If

                    If tonSauSua < 0 Then
                        MessageBox.Show("Không thể sửa vì sẽ làm tồn kho âm.", "Lỗi tồn kho", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        tran.Rollback()
                        Exit Sub
                    End If

                    ' Cập nhật phiếu nhập
                    Dim queryUpdatePhieu As String = "UPDATE LichSuGiaoDich SET MaSanPham=@MaSanPham, SoLuong=@SoLuong, NgayGiaoDich=@NgayGiaoDich, MaNhaCungCap=@MaNhaCungCap, GhiChu=@GhiChu WHERE MaGiaoDich=@MaGiaoDich"
                    Using cmdUpdatePhieu As New SqlCommand(queryUpdatePhieu, con, tran)
                        cmdUpdatePhieu.Parameters.AddWithValue("@MaSanPham", MaSanPhamMoi)
                        cmdUpdatePhieu.Parameters.AddWithValue("@SoLuong", SoLuongMoi)
                        cmdUpdatePhieu.Parameters.AddWithValue("@NgayGiaoDich", ngayLuuTru)
                        cmdUpdatePhieu.Parameters.AddWithValue("@MaNhaCungCap", MaNhaCungCap)
                        cmdUpdatePhieu.Parameters.AddWithValue("@GhiChu", GhiChu)
                        cmdUpdatePhieu.Parameters.AddWithValue("@MaGiaoDich", MaGiaoDich)
                        cmdUpdatePhieu.ExecuteNonQuery()
                    End Using

                    tran.Commit()
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadPhieuNhap()
                Catch ex As Exception
                    tran.Rollback()
                    MessageBox.Show("Lỗi khi sửa: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
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
