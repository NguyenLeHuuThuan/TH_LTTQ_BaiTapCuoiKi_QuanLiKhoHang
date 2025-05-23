Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class FormTrangChu


    Private hoTenNguoiDung As String
    Private ngayDangNhap As DateTime

    Public Sub New(ByVal hoTen As String, ByVal loginTime As DateTime)
        InitializeComponent()
        hoTenNguoiDung = hoTen
        ngayDangNhap = loginTime
    End Sub
    Private Sub FormTrangChu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fl As New FormLoad()
        LoadChildForm(fl)
        lblTenNguoiDung.Text = "Tên người dùng: " & hoTenNguoiDung
        lblNgayDangNhap.Text = "Ngày đăng nhập: " & ngayDangNhap.ToString("dd/MM/yyyy HH:mm:ss")
    End Sub

    Private Sub LoadChildForm(childForm As Form)
        PanelMain.Controls.Clear()
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelMain.Controls.Add(childForm)
        childForm.Show()
    End Sub

    Private Sub TrangChủToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrangChủToolStripMenuItem.Click
        Dim fl As New FormLoad()
        LoadChildForm(fl)
    End Sub

    Private Sub BáoCáoKhoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BáoCáoKhoToolStripMenuItem.Click
        Dim choice As String = InputBox("Chọn báo cáo:" & vbCrLf &
                                        "1. Sản phẩm còn trong kho" & vbCrLf &
                                        "2. Sản phẩm được xuất nhiều nhất" & vbCrLf &
                                        "3. Sản phẩm được xuất ít nhất", "Chọn báo cáo")
        If String.IsNullOrWhiteSpace(choice) Then
            Return
        End If
        Select Case choice.Trim()
            Case "1"
                ShowReport("Report_SanPhamTonKho.rdlc", GetDataSanPhamConTrongKho())
            Case "2"
                ShowReport("rptSanPhamXuatNhieuNhat.rdlc", GetDataSanPhamXuatNhieuNhat())
            Case "3"
                ShowReport("rptSanPhamXuatItNhat.rdlc", GetDataSanPhamXuatItNhat())
            Case Else
                MessageBox.Show("Lựa chọn không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Select
    End Sub
    Private Function GetDataSanPhamConTrongKho() As DataTable
        Dim query As String = "SELECT TenSanPham, SoLuongTon FROM SanPham WHERE SoLuongTon > 0"
        Return GetDataTable(query)
    End Function
    Private Function GetDataSanPhamXuatNhieuNhat() As DataTable
        Dim query As String = "
        SELECT sp.MaSanPham, sp.TenSanPham, SUM(ls.SoLuong) AS TongSoLuongXuat
        FROM LichSuGiaoDich ls
        INNER JOIN SanPham sp ON ls.MaSanPham = sp.MaSanPham
        WHERE ls.LoaiGiaoDich = N'Xuat'
        GROUP BY sp.MaSanPham,  sp.TenSanPham
        ORDER BY TongSoLuongXuat DESC"
        Return GetDataTable(query)
    End Function

    Private Function GetDataSanPhamXuatItNhat() As DataTable
        Dim query As String = "
        SELECT TOP 10 sp.MaSanPham, sp.TenSanPham, SUM(ls.SoLuong) AS TongSoLuongXuat
        FROM LichSuGiaoDich ls
        INNER JOIN SanPham sp ON ls.MaSanPham = sp.MaSanPham
        WHERE ls.LoaiGiaoDich = N'Xuat'
        GROUP BY sp.MaSanPham,sp.TenSanPham
        ORDER BY TongSoLuongXuat ASC"
        Return GetDataTable(query)
    End Function
    Private Function GetDataTable(query As String) As DataTable
        Dim dt As New DataTable()
        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                con.Open()
                dt.Load(cmd.ExecuteReader())
            End Using
        End Using
        Return dt
    End Function

    Public Sub ShowReport(reportName As String, dt As DataTable)
        ' Tạo Form mới để chứa ReportViewer
        Dim frm As New Form With {
                .Width = 800,
                .Height = 600,
                .Text = "Xem báo cáo"
                }

        ' Tạo ReportViewer
        Dim reportViewer As New ReportViewer With {
                .Dock = DockStyle.Fill,
                .ProcessingMode = ProcessingMode.Local
                }

        ' Thêm ReportViewer vào form
        frm.Controls.Add(reportViewer)

        ' Đường dẫn tới report file
        Dim reportFolder = System.IO.Path.Combine(Application.StartupPath, "Report")
        Dim reportPath = System.IO.Path.Combine(reportFolder, reportName)
        ' Thiết lập báo cáo
        reportViewer.LocalReport.ReportPath = reportPath
        ' Clear các DataSource cũ
        reportViewer.LocalReport.DataSources.Clear()
        ' Thêm DataSource mới, tên DataSource phải trùng với tên đã định trong report (ví dụ: "DataSet1")
        reportViewer.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", dt))
        reportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        reportViewer.ZoomPercent = 100
        ' Tải lại báo cáo
        reportViewer.RefreshReport()
        ' Hiển thị form
        frm.ShowDialog()
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnDangXuat_Click(sender As Object, e As EventArgs) Handles btnDangXuat.Click
        Dim result = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Hide()
            Dim formLogin As New FormDangNhap()
            formLogin.Show()
        End If
    End Sub
    Private Sub btnDangXuat_MouseEnter(sender As Object, e As EventArgs) Handles btnDangXuat.MouseEnter
        btnDangXuat.BackColor = Color.FromArgb(255, 80, 80) ' Đỏ nhạt khi hover
        btnDangXuat.ForeColor = Color.White
    End Sub

    Private Sub btnDangXuat_MouseLeave(sender As Object, e As EventArgs) Handles btnDangXuat.MouseLeave
        btnDangXuat.BackColor = Color.White ' Màu gốc khi rời chuột
        btnDangXuat.ForeColor = Color.Red
    End Sub

    Private Sub TỷLệNhậpHàngTheoNhàCungCấpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TỷLệNhậpHàngTheoNhàCungCấpToolStripMenuItem.Click
        Dim fl As New FormBieuDoTyLeNhapNCC()
        LoadChildForm(fl)
    End Sub

    Private Sub SoSánhSốLượngNhậpXuấtVàTồnKhoCủaTừngSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoSánhSốLượngNhậpXuấtVàTồnKhoCủaTừngSảnPhẩmToolStripMenuItem.Click
        Dim fl As New FormBieuDoNhapXuatKho()
        LoadChildForm(fl)
    End Sub

    Private Sub ThốngKêHoạtĐộngKhoHàngTheoSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThốngKêHoạtĐộngKhoHàngTheoSảnPhẩmToolStripMenuItem.Click
        Dim fl As New FormHoatDongKhoHang()
        LoadChildForm(fl)
    End Sub

    Private Sub SảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SảnPhẩmToolStripMenuItem.Click
        Dim fl As New QuanLiSanPham()
        LoadChildForm(fl)
    End Sub

    Private Sub NhàCungCấpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhàCungCấpToolStripMenuItem.Click
        Dim fl As New QuanLiNCC()
        LoadChildForm(fl)
    End Sub

    Private Sub KhoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KhoToolStripMenuItem.Click

    End Sub

    Private Sub PhiếuNhậpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhiếuNhậpToolStripMenuItem.Click
        Dim fl As New PhieuNhap()
        LoadChildForm(fl)
    End Sub

    Private Sub PhiêuXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhiêuXuấtToolStripMenuItem.Click
        Dim fl As New PhieuXuat()
        LoadChildForm(fl)
    End Sub
End Class