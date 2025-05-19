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
        Dim fl As New FormBaoCaoThongKe()
        LoadChildForm(fl)
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