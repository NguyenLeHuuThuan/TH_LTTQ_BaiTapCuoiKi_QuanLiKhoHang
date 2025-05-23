Imports System.Data.SqlClient

Public Class QuanLiNCC
    Dim ketNoiSQL As String = Database.connectionString
    Dim currentRowIndex As Integer = -1
    Private Sub QuanLiNCC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QuanLyKhoHangDataSet2.NhaCungCap' table. You can move, or remove it, as needed.
        ''Me.NhaCungCapTableAdapter.Fill(Me.QuanLyKhoHangDataSet2.NhaCungCap)
        LoadNhaCungCap()
    End Sub
    Private Sub LoadNhaCungCap()

        Dim query As String = "SELECT MaNhaCungCap, MaSoNhaCungCap, TenNhaCungCap, SoDienThoai FROM NhaCungCap"

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New SqlCommand(query, conn)
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                ' Xóa cột và dòng hiện tại nếu có
                DataGridView1.Columns.Clear()
                DataGridView1.Rows.Clear()
                DataGridView1.AutoGenerateColumns = False

                ' Tạo các cột thủ công
                DataGridView1.Columns.Add("MaNhaCungCap", "Mã Nhà Cung Cấp")
                DataGridView1.Columns.Add("MaSoNhaCungCap", "Mã Số NCC")
                DataGridView1.Columns.Add("TenNhaCungCap", "Tên Nhà Cung Cấp")
                DataGridView1.Columns.Add("SoDienThoai", "Số Điện Thoại")

                ' Đổ dữ liệu từng dòng vào DataGridView
                While reader.Read()
                    DataGridView1.Rows.Add(
                    reader("MaNhaCungCap"),
                    reader("MaSoNhaCungCap"),
                    reader("TenNhaCungCap"),
                    reader("SoDienThoai")
                )
                End While

                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Lỗi khi tải dữ liệu NCC: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub clearText()
        txt_MaNCC.Text = ""
        txt_MaSoNCC.Text = ""
        txt_TenNCC.Text = ""
        txt_SDT.Text = ""
    End Sub
    Private Sub HienThiDuLieuHienTai()
        If currentRowIndex >= 0 AndAlso currentRowIndex < DataGridView1.Rows.Count Then
            Dim row As DataGridViewRow = DataGridView1.Rows(currentRowIndex)
            txt_MaNCC.Text = row.Cells(0).Value.ToString()
            txt_MaSoNCC.Text = row.Cells(1).Value.ToString()
            txt_TenNCC.Text = row.Cells(2).Value.ToString()
            txt_SDT.Text = row.Cells(3).Value.ToString()

        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            currentRowIndex = e.RowIndex
            HienThiDuLieuHienTai()
        End If
    End Sub

    Private Sub btn_Them_Click(sender As Object, e As EventArgs) Handles btn_Them.Click
        Dim MaSoNhaCungCap As String = txt_MaSoNCC.Text.Trim()
        Dim TenNhaCungCap As String = txt_TenNCC.Text.Trim()
        Dim SDT As String = txt_SDT.Text.Trim()


        Try
            Using con As New SqlConnection(connectionString)
                Dim query As String = "INSERT INTO NhaCungCap (MaSoNhaCungCap, TenNhaCungCap, SoDienThoai)" &
                                                          " VALUES (@MaSoNhaCungCap, @TenNhaCungCap, @SoDienThoai)"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@MaSoNhaCungCap", MaSoNhaCungCap)
                    cmd.Parameters.AddWithValue("@TenNhaCungCap", TenNhaCungCap)
                    cmd.Parameters.AddWithValue("@SoDienThoai", SDT)

                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Cập nhật lại DataGridView
            'Me.NhaCungCapTableAdapter.Fill(Me.QuanLyKhoHangDataSet2.NhaCungCap)
            clearText()
            LoadNhaCungCap()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi lưu: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_Xoa_Click(sender As Object, e As EventArgs) Handles btn_Xoa.Click
        Try
            Dim MaNCC As String = txt_MaNCC.Text.Trim()
            If String.IsNullOrEmpty(MaNCC) Then
                MessageBox.Show("Vui lòng chọn nhà cung cấp để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Using con As New SqlConnection(connectionString)
                Dim query As String = "delete from NhaCungCap where MaNhaCungCap = @MaNhaCungCap"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@MaNhaCungCap", MaNCC)

                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Cập nhật lại DataGridView
            'Me.NhaCungCapTableAdapter.Fill(Me.QuanLyKhoHangDataSet2.NhaCungCap)
            clearText()
            LoadNhaCungCap()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi Xoá: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_Sua_Click(sender As Object, e As EventArgs) Handles btn_Sua.Click
        Try
            Dim MaNCC As String = txt_MaNCC.Text.Trim()
            Dim MaSoNCC As String = txt_MaSoNCC.Text.Trim()
            Dim TenNCC As String = txt_TenNCC.Text.Trim()
            Dim SDT As String = txt_SDT.Text.Trim()


            If String.IsNullOrEmpty(MaNCC) Then
                MessageBox.Show("Vui lòng chọn sản phẩm để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Using con As New SqlConnection(connectionString)
                Dim query As String = "update NhaCungCap set MaSoNhaCungCap = @MaSoNCC ," &
                                                          "TenNhaCungCap = @TenNCC, " &
                                                          "SoDienThoai = @SDT " &
                                                           "where MaNhaCungCap = @MaNCC"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@MaSoNCC", MaSoNCC)
                    cmd.Parameters.AddWithValue("@TenNCC", TenNCC)
                    cmd.Parameters.AddWithValue("@SDT", SDT)
                    cmd.Parameters.AddWithValue("@MaNCC", MaNCC)

                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("update thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Cập nhật lại DataGridView
            'Me.NhaCungCapTableAdapter.Fill(Me.QuanLyKhoHangDataSet2.NhaCungCap)
            clearText()
            LoadNhaCungCap()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi update: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_LamMoi_Click(sender As Object, e As EventArgs) Handles btn_LamMoi.Click
        clearText()
        LoadNhaCungCap()
    End Sub

    Private Sub btnThongKe_Click(sender As Object, e As EventArgs) Handles btnThongKe.Click
        Dim input As String = InputBox("Chọn chức năng thống kê:" & vbCrLf &
                                  "0 - Tổng số lượng sản phẩm nhập theo nhà cung cấp" & vbCrLf &
                                  "1 - Số loại sản phẩm đã nhập theo nhà cung cấp", "Chọn Thống Kê", "0")

        If String.IsNullOrWhiteSpace(input) Then Return ' Bấm Cancel hoặc bỏ trống thì thoát

        Dim choice As Integer
        If Integer.TryParse(input, choice) AndAlso (choice = 0 Or choice = 1) Then
            Select Case choice
                Case 0
                    ThongKeTongSoLuongNhapTheoNhaCungCap()
                Case 1
                    ThongKeSoLoaiSanPhamDaNhapTheoNhaCungCap()
            End Select
        Else
            MessageBox.Show("Vui lòng nhập 0 hoặc 1 để chọn chức năng thống kê.", "Lỗi chọn chức năng", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ThongKeTongSoLuongNhapTheoNhaCungCap()
        Dim query As String = "
        SELECT ncc.MaNhaCungCap, ncc.TenNhaCungCap, ncc.SoDienThoai, 
               ISNULL(SUM(lsgd.SoLuong), 0) AS TongSoLuongNhap
        FROM NhaCungCap ncc
        LEFT JOIN LichSuGiaoDich lsgd ON ncc.MaNhaCungCap = lsgd.MaNhaCungCap 
            AND lsgd.LoaiGiaoDich = N'Nhap'
        GROUP BY ncc.MaNhaCungCap, ncc.TenNhaCungCap, ncc.SoDienThoai
        ORDER BY TongSoLuongNhap DESC
    "

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        DataGridView1.Columns.Clear()
                        DataGridView1.Rows.Clear()
                        DataGridView1.AutoGenerateColumns = False

                        DataGridView1.Columns.Add("MaNhaCungCap", "Mã Nhà Cung Cấp")
                        DataGridView1.Columns.Add("TenNhaCungCap", "Tên Nhà Cung Cấp")
                        DataGridView1.Columns.Add("SoDienThoai", "Số Điện Thoại")
                        DataGridView1.Columns.Add("TongSoLuongNhap", "Tổng Số Lượng Nhập")

                        While reader.Read()
                            DataGridView1.Rows.Add(
                            reader("MaNhaCungCap"),
                            reader("TenNhaCungCap"),
                            reader("SoDienThoai"),
                            reader("TongSoLuongNhap")
                        )
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Lỗi khi thống kê: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub ThongKeSoLoaiSanPhamDaNhapTheoNhaCungCap()
        Dim query As String = "
        SELECT ncc.MaNhaCungCap, ncc.TenNhaCungCap, ncc.SoDienThoai,
               COUNT(DISTINCT lsgd.MaSanPham) AS SoLoaiSanPhamDaNhap
        FROM NhaCungCap ncc
        LEFT JOIN LichSuGiaoDich lsgd ON ncc.MaNhaCungCap = lsgd.MaNhaCungCap 
            AND lsgd.LoaiGiaoDich = N'Nhap'
        GROUP BY ncc.MaNhaCungCap, ncc.TenNhaCungCap, ncc.SoDienThoai
        ORDER BY SoLoaiSanPhamDaNhap DESC
    "

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        DataGridView1.Columns.Clear()
                        DataGridView1.Rows.Clear()
                        DataGridView1.AutoGenerateColumns = False

                        DataGridView1.Columns.Add("MaNhaCungCap", "Mã Nhà Cung Cấp")
                        DataGridView1.Columns.Add("TenNhaCungCap", "Tên Nhà Cung Cấp")
                        DataGridView1.Columns.Add("SoDienThoai", "Số Điện Thoại")
                        DataGridView1.Columns.Add("SoLoaiSanPhamDaNhap", "Số Loại Sản Phẩm Đã Nhập")

                        While reader.Read()
                            DataGridView1.Rows.Add(
                            reader("MaNhaCungCap"),
                            reader("TenNhaCungCap"),
                            reader("SoDienThoai"),
                            reader("SoLoaiSanPhamDaNhap")
                        )
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Lỗi khi thống kê: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim keyword As String = InputBox("Nhập tên nhà cung cấp cần tìm:", "Tìm Kiếm Nhà Cung Cấp")

        If String.IsNullOrWhiteSpace(keyword) Then
            Return ' Nếu bấm Cancel hoặc để trống thì không làm gì
        End If

        Dim query As String = "
        SELECT MaNhaCungCap, MaSoNhaCungCap, TenNhaCungCap, SoDienThoai
        FROM NhaCungCap
        WHERE TenNhaCungCap LIKE '%' + @Keyword + '%'
    "

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Keyword", keyword)

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        DataGridView1.Columns.Clear()
                        DataGridView1.Rows.Clear()
                        DataGridView1.AutoGenerateColumns = False

                        DataGridView1.Columns.Add("MaNhaCungCap", "Mã Nhà Cung Cấp")
                        DataGridView1.Columns.Add("MaSoNhaCungCap", "Mã Số Nhà Cung Cấp")
                        DataGridView1.Columns.Add("TenNhaCungCap", "Tên Nhà Cung Cấp")
                        DataGridView1.Columns.Add("SoDienThoai", "Số Điện Thoại")

                        While reader.Read()
                            DataGridView1.Rows.Add(
                                reader("MaNhaCungCap"),
                                reader("MaSoNhaCungCap"),
                                reader("TenNhaCungCap"),
                                reader("SoDienThoai")
                                )
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Lỗi khi tìm kiếm: " & ex.Message)
            End Try
        End Using
    End Sub
End Class