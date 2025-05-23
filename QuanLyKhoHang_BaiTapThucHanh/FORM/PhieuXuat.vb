Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class PhieuXuat
    Dim currentRowIndex As Integer = -1
    Private Sub PhieuXuat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QuanLyKhoHangDataSet4.pro_PhieuXuat' table. You can move, or remove it, as needed.
        'Me.Pro_PhieuXuatTableAdapter.Fill(Me.QuanLyKhoHangDataSet4.pro_PhieuXuat)
        LoadDataToCombobox()
        LoadPhieuXuat()
        LoadSanPhamToComboBox()
    End Sub


    Private Sub LoadPhieuXuat()
        Dim query = "pro_PhieuXuat"

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()

                Dim cmd As New SqlCommand(query, conn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                DataGridView1.Columns.Clear()
                DataGridView1.Rows.Clear()
                DataGridView1.AutoGenerateColumns = False

                DataGridView1.Columns.Add("MaGiaoDich", "Mã Giao Dịch")
                DataGridView1.Columns.Add("MaSanPham", "Mã Sản Phẩm")
                DataGridView1.Columns.Add("LoaiGiaoDich", "Loại Giao Dịch")
                DataGridView1.Columns.Add("SoLuong", "Số Lượng")
                DataGridView1.Columns.Add("NgayGiaoDich", "Ngày Giao Dịch")
                DataGridView1.Columns.Add("MaNhaCungCap", "Mã Nhà Cung Cấp")
                DataGridView1.Columns.Add("TenNhaCungCap", "Tên Nhà Cung Cấp")
                DataGridView1.Columns.Add("GhiChu", "Ghi Chú")

                While reader.Read()
                    Dim maNCC As String = If(IsDBNull(reader("MaNhaCungCap")), "Không có", reader("MaNhaCungCap").ToString())
                    Dim tenNCC As String = If(IsDBNull(reader("TenNhaCungCap")), "Đối tác nội bộ", reader("TenNhaCungCap").ToString())

                    DataGridView1.Rows.Add(
                        reader("MaGiaoDich"),
                        reader("MaSanPham"),
                        reader("LoaiGiaoDich"),
                        reader("SoLuong"),
                        CDate(reader("NgayGiaoDich")).ToString("yyyy-MM-dd"),
                        maNCC,
                        tenNCC,
                        reader("GhiChu").ToString()
                        )
                End While

                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Lỗi khi tải dữ liệu phiếu xuất: " & ex.Message)
            End Try
        End Using
    End Sub


    ' combobox của sản phẩm



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


    ' comboxbox của mã nhà cung cấp
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
        Dim MaNhaCungCap As Object ' Có thể DBNull.Value
        Dim NgayGiaoDich As DateTime
        Dim SoLuong As Integer
        Dim GhiChu As String = txt_GhiChu.Text.Trim()
        Dim ngayLuuTru As String

        ' Trích xuất MaSanPham từ cb_Ma_TenSP, vd: "1.NguyenA"
        Dim parts() As String = MaSanPham.Split("."c)
        If parts.Length > 0 Then
            MaSanPham = parts(0).Trim()
        Else
            MessageBox.Show("Mã sản phẩm không đúng định dạng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Xử lý ngày nhập theo định dạng yyyy-MM-dd
        If Not DateTime.TryParseExact(txt_NgayGiaoDich.Text.Trim(), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, NgayGiaoDich) Then
            MessageBox.Show("Vui lòng nhập ngày theo định dạng yyyy-MM-dd", "Lỗi định dạng ngày", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            ngayLuuTru = NgayGiaoDich.ToString("yyyy-MM-dd")
        End If

        ' Xử lý số lượng
        If Not Integer.TryParse(txt_SoLuong.Text.Trim(), SoLuong) Then
            MessageBox.Show("Vui lòng nhập số lượng hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not Integer.TryParse(txt_SoLuong.Text.Trim(), SoLuong) OrElse SoLuong <= 0 Then
            MessageBox.Show("Vui lòng nhập số lượng xuất hợp lệ (> 0).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim soLuongTon As Integer = LaySoLuongTon(MaSanPham)
        If SoLuong > soLuongTon Then
            MessageBox.Show($"Không thể xuất {SoLuong} vì chỉ còn {soLuongTon} trong kho.", "Lỗi tồn kho", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Xử lý MaNhaCungCap
        If String.IsNullOrWhiteSpace(cb_MaNCC.Text) Then
            MaNhaCungCap = DBNull.Value
        Else
            Dim partsNCC() As String = cb_MaNCC.Text.Split("."c)
            If partsNCC.Length > 0 Then
                MaNhaCungCap = partsNCC(0).Trim()
            Else
                MessageBox.Show("Mã nhà cung cấp không đúng định dạng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        Try
            Using con As New SqlConnection(connectionString)
                Dim query As String = "INSERT INTO LichSuGiaoDich (MaSanPham, LoaiGiaoDich, SoLuong, NgayGiaoDich, MaNhaCungCap, GhiChu)" &
                                  " VALUES (@MaSanPham, @LoaiGiaoDich, @SoLuong, @NgayGiaoDich, @MaNhaCungCap, @GhiChu)"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@MaSanPham", MaSanPham)
                    cmd.Parameters.AddWithValue("@LoaiGiaoDich", "Xuat") ' hoặc có thể lấy từ UI nếu có
                    cmd.Parameters.AddWithValue("@SoLuong", SoLuong)
                    cmd.Parameters.AddWithValue("@NgayGiaoDich", ngayLuuTru)
                    cmd.Parameters.AddWithValue("@MaNhaCungCap", MaNhaCungCap)
                    cmd.Parameters.AddWithValue("@GhiChu", GhiChu)

                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LoadPhieuXuat()
            clearText()

        Catch ex As Exception
            MessageBox.Show("Lỗi khi lưu: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function LaySoLuongTon(maSanPham As String) As Integer
        Dim soLuongTon As Integer = 0
        Dim query As String = "SELECT SoLuongTon FROM SanPham WHERE MaSanPham = @MaSanPham"

        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@MaSanPham", maSanPham)
                con.Open()
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso IsNumeric(result) Then
                    soLuongTon = Convert.ToInt32(result)
                End If
            End Using
        End Using

        Return soLuongTon
    End Function
    Private Sub btn_Xoa_Click(sender As Object, e As EventArgs) Handles btn_Xoa.Click
        Dim MaGiaoDich As Integer
        If Not Integer.TryParse(txt_MaGiaoDich.Text.Trim(), MaGiaoDich) Then
            MessageBox.Show("Mã giao dịch không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result = MessageBox.Show("Bạn có chắc chắn muốn xóa giao dịch này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result <> DialogResult.Yes Then Return

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
            LoadPhieuXuat()

        Catch ex As Exception
            MessageBox.Show("Lỗi khi xóa: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
                    ' Lấy dữ liệu cũ để kiểm tra chênh lệch số lượng
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

                    ' Tính chênh lệch số lượng
                    Dim chenhLech As Integer = SoLuongMoi
                    If MaSanPhamMoi = MaSanPhamCu Then
                        chenhLech = SoLuongMoi - SoLuongCu
                    Else
                        ' Nếu đổi mã sản phẩm thì coi như xuất mới nên chênh lệch = số lượng mới
                        chenhLech = SoLuongMoi
                    End If

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

                    ' Kiểm tra tồn kho nếu xuất nhiều hơn trước
                    If chenhLech > 0 AndAlso chenhLech > soLuongTon Then
                        MessageBox.Show($"Không đủ tồn kho để xuất thêm {chenhLech} đơn vị. Tồn kho hiện có: {soLuongTon}.", "Lỗi tồn kho", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        tran.Rollback()
                        Exit Sub
                    End If

                    ' Chỉ update dữ liệu phiếu, trigger sẽ tự cập nhật tồn kho
                    Dim queryUpdatePhieu As String = "
                    UPDATE LichSuGiaoDich 
                    SET MaSanPham=@MaSanPham, SoLuong=@SoLuong, NgayGiaoDich=@NgayGiaoDich, MaNhaCungCap=@MaNhaCungCap, GhiChu=@GhiChu 
                    WHERE MaGiaoDich=@MaGiaoDich"
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
                    LoadPhieuXuat()
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

            ' Mã giao dịch
            txt_MaGiaoDich.Text = If(row.Cells(0).Value IsNot Nothing, row.Cells(0).Value.ToString(), "")

            ' Mã sản phẩm (hoặc mã + tên nếu bạn dùng định dạng đó)
            cb_Ma_TenSP.Text = If(row.Cells(1).Value IsNot Nothing, row.Cells(1).Value.ToString(), "")

            ' Số lượng
            txt_SoLuong.Text = If(row.Cells(3).Value IsNot Nothing, row.Cells(3).Value.ToString(), "")

            ' Ngày giao dịch
            Dim ngayGiaoDichValue As Object = row.Cells(4).Value
            If ngayGiaoDichValue IsNot Nothing AndAlso TypeOf ngayGiaoDichValue Is Date Then
                txt_NgayGiaoDich.Text = DirectCast(ngayGiaoDichValue, Date).ToString("yyyy-MM-dd")
            ElseIf ngayGiaoDichValue IsNot Nothing Then
                txt_NgayGiaoDich.Text = ngayGiaoDichValue.ToString()
            Else
                txt_NgayGiaoDich.Text = ""
            End If

            ' Mã nhà cung cấp
            Dim maNCC As String = If(row.Cells(5).Value IsNot Nothing, row.Cells(5).Value.ToString(), "")
            ' Nếu mã nhà cung cấp bằng "Không có" hoặc rỗng thì gán rỗng cho combobox
            If String.IsNullOrEmpty(maNCC) OrElse maNCC = "Không có" Then
                cb_MaNCC.Text = ""
            Else
                cb_MaNCC.Text = maNCC
            End If

            ' Ghi chú
            txt_GhiChu.Text = If(row.Cells(7).Value IsNot Nothing, row.Cells(7).Value.ToString(), "")
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