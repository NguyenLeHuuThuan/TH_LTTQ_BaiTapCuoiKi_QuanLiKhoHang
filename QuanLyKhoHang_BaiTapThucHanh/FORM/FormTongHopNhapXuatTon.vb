Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient

Public Class FormTongHopNhapXuatTon
    Private Sub FormTongHopNhapXuatTon_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            ' Mở kết nối nếu chưa mở
            If conn.State <> ConnectionState.Open Then conn.Open()

            ' Câu lệnh SQL lấy tổng Nhập, Xuất, Tồn
            Dim sql As String = "
        SELECT 
            sp.TenSanPham,
            ISNULL(SUM(CASE WHEN lg.LoaiGiaoDich = N'Nhap' THEN lg.SoLuong END), 0) AS TongNhap,
            ISNULL(SUM(CASE WHEN lg.LoaiGiaoDich = N'Xuat' THEN lg.SoLuong END), 0) AS TongXuat,
            sp.SoLuongTon
        FROM SanPham sp
        LEFT JOIN LichSuGiaoDich lg ON sp.MaSanPham = lg.MaSanPham
        GROUP BY sp.TenSanPham, sp.SoLuongTon
    "

            ' Đổ dữ liệu vào DataTable từ .xsd
            Dim da As New SqlDataAdapter(sql, conn)
        Dim dt As New DataSetNhapTonXuatSanPham.DataTable1DataTable()
        da.Fill(dt)

        ' Gán vào ReportViewer
        ReportViewer1.LocalReport.ReportPath = "E:\IT\VBNET\QuanLyKhoHang_BaiTapThucHanh\QuanLyKhoHang_BaiTapThucHanh\Report\Report_TongHopNhapXuatTon.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", CType(dt, DataTable)))
            ReportViewer1.RefreshReport()

            ' Đóng kết nối nếu không dùng tiếp
            conn.Close()
        End Sub
End Class