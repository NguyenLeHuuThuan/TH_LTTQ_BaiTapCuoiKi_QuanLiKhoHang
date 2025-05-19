<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTrangChu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblNgayDangNhap = New System.Windows.Forms.Label()
        Me.lblTenNguoiDung = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDangXuat = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TrangChủToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrangChủToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NhàCungCấpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KhoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhiếuNhậpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhiêuXuấtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThốngKêBáoCáoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BáoCáoKhoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BiểuĐồToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TỷLệNhậpHàngTheoNhàCungCấpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoSánhSốLượngNhậpXuấtVàTồnKhoCủaTừngSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThốngKêHoạtĐộngKhoHàngTheoSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblNgayDangNhap)
        Me.Panel1.Controls.Add(Me.lblTenNguoiDung)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnDangXuat)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(321, 868)
        Me.Panel1.TabIndex = 0
        '
        'lblNgayDangNhap
        '
        Me.lblNgayDangNhap.AutoSize = True
        Me.lblNgayDangNhap.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNgayDangNhap.ForeColor = System.Drawing.Color.Transparent
        Me.lblNgayDangNhap.Location = New System.Drawing.Point(11, 495)
        Me.lblNgayDangNhap.Name = "lblNgayDangNhap"
        Me.lblNgayDangNhap.Size = New System.Drawing.Size(140, 20)
        Me.lblNgayDangNhap.TabIndex = 6
        Me.lblNgayDangNhap.Text = "Ngày đăng nhập: "
        '
        'lblTenNguoiDung
        '
        Me.lblTenNguoiDung.AutoSize = True
        Me.lblTenNguoiDung.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenNguoiDung.ForeColor = System.Drawing.Color.Transparent
        Me.lblTenNguoiDung.Location = New System.Drawing.Point(11, 439)
        Me.lblTenNguoiDung.Name = "lblTenNguoiDung"
        Me.lblTenNguoiDung.Size = New System.Drawing.Size(137, 20)
        Me.lblTenNguoiDung.TabIndex = 5
        Me.lblTenNguoiDung.Text = "Tên người dùng: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(45, 348)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 41)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Quản Trị viên"
        '
        'btnDangXuat
        '
        Me.btnDangXuat.BackColor = System.Drawing.Color.Transparent
        Me.btnDangXuat.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDangXuat.ForeColor = System.Drawing.Color.Red
        Me.btnDangXuat.Image = Global.QuanLyKhoHang_BaiTapThucHanh.My.Resources.Resources.logout
        Me.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDangXuat.Location = New System.Drawing.Point(39, 774)
        Me.btnDangXuat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDangXuat.Name = "btnDangXuat"
        Me.btnDangXuat.Size = New System.Drawing.Size(242, 69)
        Me.btnDangXuat.TabIndex = 3
        Me.btnDangXuat.Text = "Đăng xuất"
        Me.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDangXuat.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.QuanLyKhoHang_BaiTapThucHanh.My.Resources.Resources.User_icon_cp_svg
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(65, 110)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(181, 200)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.PanelMain)
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Location = New System.Drawing.Point(323, 2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1310, 865)
        Me.Panel2.TabIndex = 1
        '
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelMain.Location = New System.Drawing.Point(3, 39)
        Me.PanelMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(1299, 818)
        Me.PanelMain.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrangChủToolStripMenuItem, Me.TrangChủToolStripMenuItem1, Me.KhoToolStripMenuItem, Me.ThốngKêBáoCáoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1306, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TrangChủToolStripMenuItem
        '
        Me.TrangChủToolStripMenuItem.Image = Global.QuanLyKhoHang_BaiTapThucHanh.My.Resources.Resources.home
        Me.TrangChủToolStripMenuItem.Name = "TrangChủToolStripMenuItem"
        Me.TrangChủToolStripMenuItem.Size = New System.Drawing.Size(124, 29)
        Me.TrangChủToolStripMenuItem.Text = "Trang chủ"
        '
        'TrangChủToolStripMenuItem1
        '
        Me.TrangChủToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SảnPhẩmToolStripMenuItem, Me.NhàCungCấpToolStripMenuItem})
        Me.TrangChủToolStripMenuItem1.Image = Global.QuanLyKhoHang_BaiTapThucHanh.My.Resources.Resources.pngtree_vector_users_icon_png_image_856952
        Me.TrangChủToolStripMenuItem1.Name = "TrangChủToolStripMenuItem1"
        Me.TrangChủToolStripMenuItem1.Size = New System.Drawing.Size(109, 29)
        Me.TrangChủToolStripMenuItem1.Text = "Quản lý"
        '
        'SảnPhẩmToolStripMenuItem
        '
        Me.SảnPhẩmToolStripMenuItem.Image = Global.QuanLyKhoHang_BaiTapThucHanh.My.Resources.Resources.box
        Me.SảnPhẩmToolStripMenuItem.Name = "SảnPhẩmToolStripMenuItem"
        Me.SảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(223, 34)
        Me.SảnPhẩmToolStripMenuItem.Text = "Sản phẩm"
        '
        'NhàCungCấpToolStripMenuItem
        '
        Me.NhàCungCấpToolStripMenuItem.Image = Global.QuanLyKhoHang_BaiTapThucHanh.My.Resources.Resources.User_icon_cp_svg
        Me.NhàCungCấpToolStripMenuItem.Name = "NhàCungCấpToolStripMenuItem"
        Me.NhàCungCấpToolStripMenuItem.Size = New System.Drawing.Size(223, 34)
        Me.NhàCungCấpToolStripMenuItem.Text = "Nhà cung cấp"
        '
        'KhoToolStripMenuItem
        '
        Me.KhoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PhiếuNhậpToolStripMenuItem, Me.PhiêuXuấtToolStripMenuItem})
        Me.KhoToolStripMenuItem.Image = Global.QuanLyKhoHang_BaiTapThucHanh.My.Resources.Resources.warehouse
        Me.KhoToolStripMenuItem.Name = "KhoToolStripMenuItem"
        Me.KhoToolStripMenuItem.Size = New System.Drawing.Size(79, 29)
        Me.KhoToolStripMenuItem.Text = "Kho"
        '
        'PhiếuNhậpToolStripMenuItem
        '
        Me.PhiếuNhậpToolStripMenuItem.Image = Global.QuanLyKhoHang_BaiTapThucHanh.My.Resources.Resources.transport
        Me.PhiếuNhậpToolStripMenuItem.Name = "PhiếuNhậpToolStripMenuItem"
        Me.PhiếuNhậpToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.PhiếuNhậpToolStripMenuItem.Text = "Phiếu nhập"
        '
        'PhiêuXuấtToolStripMenuItem
        '
        Me.PhiêuXuấtToolStripMenuItem.Image = Global.QuanLyKhoHang_BaiTapThucHanh.My.Resources.Resources.product__1_
        Me.PhiêuXuấtToolStripMenuItem.Name = "PhiêuXuấtToolStripMenuItem"
        Me.PhiêuXuấtToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.PhiêuXuấtToolStripMenuItem.Text = "Phiêu xuất"
        '
        'ThốngKêBáoCáoToolStripMenuItem
        '
        Me.ThốngKêBáoCáoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BáoCáoKhoToolStripMenuItem, Me.BiểuĐồToolStripMenuItem})
        Me.ThốngKêBáoCáoToolStripMenuItem.Image = Global.QuanLyKhoHang_BaiTapThucHanh.My.Resources.Resources.analytics
        Me.ThốngKêBáoCáoToolStripMenuItem.Name = "ThốngKêBáoCáoToolStripMenuItem"
        Me.ThốngKêBáoCáoToolStripMenuItem.Size = New System.Drawing.Size(203, 29)
        Me.ThốngKêBáoCáoToolStripMenuItem.Text = "Thống kê - báo cáo"
        '
        'BáoCáoKhoToolStripMenuItem
        '
        Me.BáoCáoKhoToolStripMenuItem.Image = Global.QuanLyKhoHang_BaiTapThucHanh.My.Resources.Resources.report
        Me.BáoCáoKhoToolStripMenuItem.Name = "BáoCáoKhoToolStripMenuItem"
        Me.BáoCáoKhoToolStripMenuItem.Size = New System.Drawing.Size(212, 34)
        Me.BáoCáoKhoToolStripMenuItem.Text = "Báo cáo kho"
        '
        'BiểuĐồToolStripMenuItem
        '
        Me.BiểuĐồToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TỷLệNhậpHàngTheoNhàCungCấpToolStripMenuItem, Me.SoSánhSốLượngNhậpXuấtVàTồnKhoCủaTừngSảnPhẩmToolStripMenuItem, Me.ThốngKêHoạtĐộngKhoHàngTheoSảnPhẩmToolStripMenuItem})
        Me.BiểuĐồToolStripMenuItem.Image = Global.QuanLyKhoHang_BaiTapThucHanh.My.Resources.Resources.product_selling
        Me.BiểuĐồToolStripMenuItem.Name = "BiểuĐồToolStripMenuItem"
        Me.BiểuĐồToolStripMenuItem.Size = New System.Drawing.Size(212, 34)
        Me.BiểuĐồToolStripMenuItem.Text = "Biểu đồ"
        '
        'TỷLệNhậpHàngTheoNhàCungCấpToolStripMenuItem
        '
        Me.TỷLệNhậpHàngTheoNhàCungCấpToolStripMenuItem.Name = "TỷLệNhậpHàngTheoNhàCungCấpToolStripMenuItem"
        Me.TỷLệNhậpHàngTheoNhàCungCấpToolStripMenuItem.Size = New System.Drawing.Size(597, 34)
        Me.TỷLệNhậpHàngTheoNhàCungCấpToolStripMenuItem.Text = "Tỷ lệ nhập hàng theo nhà cung cấp"
        '
        'SoSánhSốLượngNhậpXuấtVàTồnKhoCủaTừngSảnPhẩmToolStripMenuItem
        '
        Me.SoSánhSốLượngNhậpXuấtVàTồnKhoCủaTừngSảnPhẩmToolStripMenuItem.Name = "SoSánhSốLượngNhậpXuấtVàTồnKhoCủaTừngSảnPhẩmToolStripMenuItem"
        Me.SoSánhSốLượngNhậpXuấtVàTồnKhoCủaTừngSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(597, 34)
        Me.SoSánhSốLượngNhậpXuấtVàTồnKhoCủaTừngSảnPhẩmToolStripMenuItem.Text = "So sánh số lượng Nhập, Xuất và Tồn kho của từng sản phẩm"
        '
        'ThốngKêHoạtĐộngKhoHàngTheoSảnPhẩmToolStripMenuItem
        '
        Me.ThốngKêHoạtĐộngKhoHàngTheoSảnPhẩmToolStripMenuItem.Name = "ThốngKêHoạtĐộngKhoHàngTheoSảnPhẩmToolStripMenuItem"
        Me.ThốngKêHoạtĐộngKhoHàngTheoSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(597, 34)
        Me.ThốngKêHoạtĐộngKhoHàngTheoSảnPhẩmToolStripMenuItem.Text = "Thống kê hoạt động kho hàng theo sản phẩm"
        '
        'FormTrangChu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1637, 871)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormTrangChu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormTrangChu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TrangChủToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelMain As Panel
    Friend WithEvents btnDangXuat As Button
    Friend WithEvents TrangChủToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SảnPhẩmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NhàCungCấpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KhoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PhiếuNhậpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PhiêuXuấtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThốngKêBáoCáoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BáoCáoKhoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BiểuĐồToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTenNguoiDung As Label
    Friend WithEvents lblNgayDangNhap As Label
    Friend WithEvents TỷLệNhậpHàngTheoNhàCungCấpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SoSánhSốLượngNhậpXuấtVàTồnKhoCủaTừngSảnPhẩmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThốngKêHoạtĐộngKhoHàngTheoSảnPhẩmToolStripMenuItem As ToolStripMenuItem
End Class
