<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PhieuNhap
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
        Me.components = New System.ComponentModel.Container()
        Me.Pro_PhieuNhapTableAdapter = New QuanLyKhoHang_BaiTapThucHanh.QuanLyKhoHangDataSet3TableAdapters.pro_PhieuNhapTableAdapter()
        Me.btn_Sua = New System.Windows.Forms.Button()
        Me.btn_Xoa = New System.Windows.Forms.Button()
        Me.btn_Them = New System.Windows.Forms.Button()
        Me.ProPhieuNhapBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuanLyKhoHangDataSet3 = New QuanLyKhoHang_BaiTapThucHanh.QuanLyKhoHangDataSet3()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_LamMoi = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProPhieuXuatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuanLyKhoHangDataSet4 = New QuanLyKhoHang_BaiTapThucHanh.QuanLyKhoHangDataSet4()
        Me.Pro_PhieuXuatTableAdapter = New QuanLyKhoHang_BaiTapThucHanh.QuanLyKhoHangDataSet4TableAdapters.pro_PhieuXuatTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cb_MaNCC = New System.Windows.Forms.ComboBox()
        Me.txt_NgayGiaoDich = New System.Windows.Forms.TextBox()
        Me.txt_GhiChu = New System.Windows.Forms.TextBox()
        Me.txt_SoLuong = New System.Windows.Forms.TextBox()
        Me.txt_MaSanPham = New System.Windows.Forms.TextBox()
        Me.txt_MaGiaoDich = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MaGiaoDichDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaSanPhamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoaiGiaoDichDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuongDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayGiaoDichDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaNhaCungCapDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GhiChuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ProPhieuNhapBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuanLyKhoHangDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ProPhieuXuatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuanLyKhoHangDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pro_PhieuNhapTableAdapter
        '
        Me.Pro_PhieuNhapTableAdapter.ClearBeforeFill = True
        '
        'btn_Sua
        '
        Me.btn_Sua.Location = New System.Drawing.Point(49, 367)
        Me.btn_Sua.Name = "btn_Sua"
        Me.btn_Sua.Size = New System.Drawing.Size(124, 51)
        Me.btn_Sua.TabIndex = 1
        Me.btn_Sua.Text = "Sửa"
        Me.btn_Sua.UseVisualStyleBackColor = True
        '
        'btn_Xoa
        '
        Me.btn_Xoa.Location = New System.Drawing.Point(49, 268)
        Me.btn_Xoa.Name = "btn_Xoa"
        Me.btn_Xoa.Size = New System.Drawing.Size(124, 51)
        Me.btn_Xoa.TabIndex = 1
        Me.btn_Xoa.Text = "Xoá"
        Me.btn_Xoa.UseVisualStyleBackColor = True
        '
        'btn_Them
        '
        Me.btn_Them.Location = New System.Drawing.Point(49, 168)
        Me.btn_Them.Name = "btn_Them"
        Me.btn_Them.Size = New System.Drawing.Size(124, 51)
        Me.btn_Them.TabIndex = 1
        Me.btn_Them.Text = "Thêm"
        Me.btn_Them.UseVisualStyleBackColor = True
        '
        'ProPhieuNhapBindingSource
        '
        Me.ProPhieuNhapBindingSource.DataMember = "pro_PhieuNhap"
        Me.ProPhieuNhapBindingSource.DataSource = Me.QuanLyKhoHangDataSet3
        '
        'QuanLyKhoHangDataSet3
        '
        Me.QuanLyKhoHangDataSet3.DataSetName = "QuanLyKhoHangDataSet3"
        Me.QuanLyKhoHangDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_LamMoi)
        Me.Panel1.Controls.Add(Me.btn_Sua)
        Me.Panel1.Controls.Add(Me.btn_Xoa)
        Me.Panel1.Controls.Add(Me.btn_Them)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(232, 715)
        Me.Panel1.TabIndex = 11
        '
        'btn_LamMoi
        '
        Me.btn_LamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_LamMoi.Location = New System.Drawing.Point(49, 469)
        Me.btn_LamMoi.Name = "btn_LamMoi"
        Me.btn_LamMoi.Size = New System.Drawing.Size(124, 51)
        Me.btn_LamMoi.TabIndex = 1
        Me.btn_LamMoi.Text = "    Làm Mới"
        Me.btn_LamMoi.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 46)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "MENU"
        '
        'ProPhieuXuatBindingSource
        '
        Me.ProPhieuXuatBindingSource.DataMember = "pro_PhieuXuat"
        Me.ProPhieuXuatBindingSource.DataSource = Me.QuanLyKhoHangDataSet4
        '
        'QuanLyKhoHangDataSet4
        '
        Me.QuanLyKhoHangDataSet4.DataSetName = "QuanLyKhoHangDataSet4"
        Me.QuanLyKhoHangDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Pro_PhieuXuatTableAdapter
        '
        Me.Pro_PhieuXuatTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Mã Sản Phẩm"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.cb_MaNCC)
        Me.Panel2.Controls.Add(Me.txt_NgayGiaoDich)
        Me.Panel2.Controls.Add(Me.txt_GhiChu)
        Me.Panel2.Controls.Add(Me.txt_SoLuong)
        Me.Panel2.Controls.Add(Me.txt_MaSanPham)
        Me.Panel2.Controls.Add(Me.txt_MaGiaoDich)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(249, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(872, 212)
        Me.Panel2.TabIndex = 12
        '
        'cb_MaNCC
        '
        Me.cb_MaNCC.FormattingEnabled = True
        Me.cb_MaNCC.Location = New System.Drawing.Point(594, 110)
        Me.cb_MaNCC.Name = "cb_MaNCC"
        Me.cb_MaNCC.Size = New System.Drawing.Size(186, 28)
        Me.cb_MaNCC.TabIndex = 7
        '
        'txt_NgayGiaoDich
        '
        Me.txt_NgayGiaoDich.Location = New System.Drawing.Point(594, 46)
        Me.txt_NgayGiaoDich.Name = "txt_NgayGiaoDich"
        Me.txt_NgayGiaoDich.Size = New System.Drawing.Size(186, 26)
        Me.txt_NgayGiaoDich.TabIndex = 6
        '
        'txt_GhiChu
        '
        Me.txt_GhiChu.Location = New System.Drawing.Point(594, 167)
        Me.txt_GhiChu.Name = "txt_GhiChu"
        Me.txt_GhiChu.Size = New System.Drawing.Size(186, 26)
        Me.txt_GhiChu.TabIndex = 6
        '
        'txt_SoLuong
        '
        Me.txt_SoLuong.Location = New System.Drawing.Point(184, 167)
        Me.txt_SoLuong.Name = "txt_SoLuong"
        Me.txt_SoLuong.Size = New System.Drawing.Size(139, 26)
        Me.txt_SoLuong.TabIndex = 6
        '
        'txt_MaSanPham
        '
        Me.txt_MaSanPham.Location = New System.Drawing.Point(184, 107)
        Me.txt_MaSanPham.Name = "txt_MaSanPham"
        Me.txt_MaSanPham.Size = New System.Drawing.Size(139, 26)
        Me.txt_MaSanPham.TabIndex = 6
        '
        'txt_MaGiaoDich
        '
        Me.txt_MaGiaoDich.Location = New System.Drawing.Point(184, 40)
        Me.txt_MaGiaoDich.Name = "txt_MaGiaoDich"
        Me.txt_MaGiaoDich.Size = New System.Drawing.Size(139, 26)
        Me.txt_MaGiaoDich.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(439, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 20)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Ngày Giao Dịch"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(439, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Ghi Chú"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(439, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Mã Nhà Cung Cấp"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Số Lượng"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã Giao Dịch"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(537, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 46)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "PHIẾU NHẬP"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaGiaoDichDataGridViewTextBoxColumn, Me.MaSanPhamDataGridViewTextBoxColumn, Me.LoaiGiaoDichDataGridViewTextBoxColumn, Me.SoLuongDataGridViewTextBoxColumn, Me.NgayGiaoDichDataGridViewTextBoxColumn, Me.MaNhaCungCapDataGridViewTextBoxColumn, Me.GhiChuDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProPhieuNhapBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(252, 322)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(868, 391)
        Me.DataGridView1.TabIndex = 13
        '
        'MaGiaoDichDataGridViewTextBoxColumn
        '
        Me.MaGiaoDichDataGridViewTextBoxColumn.DataPropertyName = "MaGiaoDich"
        Me.MaGiaoDichDataGridViewTextBoxColumn.HeaderText = "MaGiaoDich"
        Me.MaGiaoDichDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MaGiaoDichDataGridViewTextBoxColumn.Name = "MaGiaoDichDataGridViewTextBoxColumn"
        Me.MaGiaoDichDataGridViewTextBoxColumn.ReadOnly = True
        Me.MaGiaoDichDataGridViewTextBoxColumn.Width = 150
        '
        'MaSanPhamDataGridViewTextBoxColumn
        '
        Me.MaSanPhamDataGridViewTextBoxColumn.DataPropertyName = "MaSanPham"
        Me.MaSanPhamDataGridViewTextBoxColumn.HeaderText = "MaSanPham"
        Me.MaSanPhamDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MaSanPhamDataGridViewTextBoxColumn.Name = "MaSanPhamDataGridViewTextBoxColumn"
        Me.MaSanPhamDataGridViewTextBoxColumn.Width = 150
        '
        'LoaiGiaoDichDataGridViewTextBoxColumn
        '
        Me.LoaiGiaoDichDataGridViewTextBoxColumn.DataPropertyName = "LoaiGiaoDich"
        Me.LoaiGiaoDichDataGridViewTextBoxColumn.HeaderText = "LoaiGiaoDich"
        Me.LoaiGiaoDichDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.LoaiGiaoDichDataGridViewTextBoxColumn.Name = "LoaiGiaoDichDataGridViewTextBoxColumn"
        Me.LoaiGiaoDichDataGridViewTextBoxColumn.Width = 150
        '
        'SoLuongDataGridViewTextBoxColumn
        '
        Me.SoLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong"
        Me.SoLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong"
        Me.SoLuongDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SoLuongDataGridViewTextBoxColumn.Name = "SoLuongDataGridViewTextBoxColumn"
        Me.SoLuongDataGridViewTextBoxColumn.Width = 150
        '
        'NgayGiaoDichDataGridViewTextBoxColumn
        '
        Me.NgayGiaoDichDataGridViewTextBoxColumn.DataPropertyName = "NgayGiaoDich"
        Me.NgayGiaoDichDataGridViewTextBoxColumn.HeaderText = "NgayGiaoDich"
        Me.NgayGiaoDichDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NgayGiaoDichDataGridViewTextBoxColumn.Name = "NgayGiaoDichDataGridViewTextBoxColumn"
        Me.NgayGiaoDichDataGridViewTextBoxColumn.Width = 150
        '
        'MaNhaCungCapDataGridViewTextBoxColumn
        '
        Me.MaNhaCungCapDataGridViewTextBoxColumn.DataPropertyName = "MaNhaCungCap"
        Me.MaNhaCungCapDataGridViewTextBoxColumn.HeaderText = "MaNhaCungCap"
        Me.MaNhaCungCapDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MaNhaCungCapDataGridViewTextBoxColumn.Name = "MaNhaCungCapDataGridViewTextBoxColumn"
        Me.MaNhaCungCapDataGridViewTextBoxColumn.Width = 150
        '
        'GhiChuDataGridViewTextBoxColumn
        '
        Me.GhiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu"
        Me.GhiChuDataGridViewTextBoxColumn.HeaderText = "GhiChu"
        Me.GhiChuDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.GhiChuDataGridViewTextBoxColumn.Name = "GhiChuDataGridViewTextBoxColumn"
        Me.GhiChuDataGridViewTextBoxColumn.Width = 150
        '
        'PhieuNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1172, 720)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PhieuNhap"
        Me.Text = "PhieuNhap"
        CType(Me.ProPhieuNhapBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuanLyKhoHangDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ProPhieuXuatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuanLyKhoHangDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pro_PhieuNhapTableAdapter As QuanLyKhoHangDataSet3TableAdapters.pro_PhieuNhapTableAdapter
    Friend WithEvents btn_Sua As Button
    Friend WithEvents btn_Xoa As Button
    Friend WithEvents btn_Them As Button
    Friend WithEvents ProPhieuNhapBindingSource As BindingSource
    Friend WithEvents QuanLyKhoHangDataSet3 As QuanLyKhoHangDataSet3
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_LamMoi As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ProPhieuXuatBindingSource As BindingSource
    Friend WithEvents QuanLyKhoHangDataSet4 As QuanLyKhoHangDataSet4
    Friend WithEvents Pro_PhieuXuatTableAdapter As QuanLyKhoHangDataSet4TableAdapters.pro_PhieuXuatTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cb_MaNCC As ComboBox
    Friend WithEvents txt_NgayGiaoDich As TextBox
    Friend WithEvents txt_GhiChu As TextBox
    Friend WithEvents txt_SoLuong As TextBox
    Friend WithEvents txt_MaSanPham As TextBox
    Friend WithEvents txt_MaGiaoDich As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MaGiaoDichDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaSanPhamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoaiGiaoDichDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoLuongDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgayGiaoDichDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaNhaCungCapDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GhiChuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
