<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QuanLiSanPham
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_LamMoi = New System.Windows.Forms.Button()
        Me.btn_ThongKe = New System.Windows.Forms.Button()
        Me.btn_Sua = New System.Windows.Forms.Button()
        Me.btn_Xoa = New System.Windows.Forms.Button()
        Me.btn_Them = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_TenSanPham = New System.Windows.Forms.TextBox()
        Me.txt_MaSoSanPham = New System.Windows.Forms.TextBox()
        Me.txt_SoLuong = New System.Windows.Forms.TextBox()
        Me.txt_DonVi = New System.Windows.Forms.TextBox()
        Me.txt_MoTa = New System.Windows.Forms.TextBox()
        Me.txt_MaSanPham = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SanPhamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuanLyKhoHangDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuanLyKhoHangDataSet1 = New QuanLyKhoHang_BaiTapThucHanh.QuanLyKhoHangDataSet1()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.QuanLyKhoHangDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SanPhamTableAdapter = New QuanLyKhoHang_BaiTapThucHanh.QuanLyKhoHangDataSet1TableAdapters.SanPhamTableAdapter()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SanPhamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuanLyKhoHangDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuanLyKhoHangDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuanLyKhoHangDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.Controls.Add(Me.btnTimKiem)
        Me.Panel1.Controls.Add(Me.btn_LamMoi)
        Me.Panel1.Controls.Add(Me.btn_ThongKe)
        Me.Panel1.Controls.Add(Me.btn_Sua)
        Me.Panel1.Controls.Add(Me.btn_Xoa)
        Me.Panel1.Controls.Add(Me.btn_Them)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(210, 650)
        Me.Panel1.TabIndex = 0
        '
        'btn_LamMoi
        '
        Me.btn_LamMoi.Location = New System.Drawing.Point(36, 478)
        Me.btn_LamMoi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_LamMoi.Name = "btn_LamMoi"
        Me.btn_LamMoi.Size = New System.Drawing.Size(139, 36)
        Me.btn_LamMoi.TabIndex = 2
        Me.btn_LamMoi.Text = "Làm Mới"
        Me.btn_LamMoi.UseVisualStyleBackColor = True
        '
        'btn_ThongKe
        '
        Me.btn_ThongKe.Location = New System.Drawing.Point(36, 406)
        Me.btn_ThongKe.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_ThongKe.Name = "btn_ThongKe"
        Me.btn_ThongKe.Size = New System.Drawing.Size(139, 36)
        Me.btn_ThongKe.TabIndex = 1
        Me.btn_ThongKe.Text = "Thống Kê "
        Me.btn_ThongKe.UseVisualStyleBackColor = True
        '
        'btn_Sua
        '
        Me.btn_Sua.Location = New System.Drawing.Point(36, 324)
        Me.btn_Sua.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Sua.Name = "btn_Sua"
        Me.btn_Sua.Size = New System.Drawing.Size(139, 36)
        Me.btn_Sua.TabIndex = 1
        Me.btn_Sua.Text = "Sửa"
        Me.btn_Sua.UseVisualStyleBackColor = True
        '
        'btn_Xoa
        '
        Me.btn_Xoa.Location = New System.Drawing.Point(36, 247)
        Me.btn_Xoa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Xoa.Name = "btn_Xoa"
        Me.btn_Xoa.Size = New System.Drawing.Size(139, 36)
        Me.btn_Xoa.TabIndex = 1
        Me.btn_Xoa.Text = "Xoá"
        Me.btn_Xoa.UseVisualStyleBackColor = True
        '
        'btn_Them
        '
        Me.btn_Them.Location = New System.Drawing.Point(36, 177)
        Me.btn_Them.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Them.Name = "btn_Them"
        Me.btn_Them.Size = New System.Drawing.Size(139, 36)
        Me.btn_Them.TabIndex = 1
        Me.btn_Them.Text = "Thêm"
        Me.btn_Them.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MENU"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txt_TenSanPham)
        Me.Panel2.Controls.Add(Me.txt_MaSoSanPham)
        Me.Panel2.Controls.Add(Me.txt_SoLuong)
        Me.Panel2.Controls.Add(Me.txt_DonVi)
        Me.Panel2.Controls.Add(Me.txt_MoTa)
        Me.Panel2.Controls.Add(Me.txt_MaSanPham)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(217, 80)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(903, 150)
        Me.Panel2.TabIndex = 1
        '
        'txt_TenSanPham
        '
        Me.txt_TenSanPham.Location = New System.Drawing.Point(257, 108)
        Me.txt_TenSanPham.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_TenSanPham.Name = "txt_TenSanPham"
        Me.txt_TenSanPham.Size = New System.Drawing.Size(136, 22)
        Me.txt_TenSanPham.TabIndex = 3
        '
        'txt_MaSoSanPham
        '
        Me.txt_MaSoSanPham.Location = New System.Drawing.Point(257, 62)
        Me.txt_MaSoSanPham.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_MaSoSanPham.Name = "txt_MaSoSanPham"
        Me.txt_MaSoSanPham.Size = New System.Drawing.Size(136, 22)
        Me.txt_MaSoSanPham.TabIndex = 3
        '
        'txt_SoLuong
        '
        Me.txt_SoLuong.Location = New System.Drawing.Point(577, 110)
        Me.txt_SoLuong.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_SoLuong.Name = "txt_SoLuong"
        Me.txt_SoLuong.Size = New System.Drawing.Size(136, 22)
        Me.txt_SoLuong.TabIndex = 3
        '
        'txt_DonVi
        '
        Me.txt_DonVi.Location = New System.Drawing.Point(577, 67)
        Me.txt_DonVi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_DonVi.Name = "txt_DonVi"
        Me.txt_DonVi.Size = New System.Drawing.Size(136, 22)
        Me.txt_DonVi.TabIndex = 3
        '
        'txt_MoTa
        '
        Me.txt_MoTa.Location = New System.Drawing.Point(577, 18)
        Me.txt_MoTa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_MoTa.Name = "txt_MoTa"
        Me.txt_MoTa.Size = New System.Drawing.Size(136, 22)
        Me.txt_MoTa.TabIndex = 3
        '
        'txt_MaSanPham
        '
        Me.txt_MaSanPham.Location = New System.Drawing.Point(257, 16)
        Me.txt_MaSanPham.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_MaSanPham.Name = "txt_MaSanPham"
        Me.txt_MaSanPham.Size = New System.Drawing.Size(136, 22)
        Me.txt_MaSanPham.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(121, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Tên Sản Phẩm"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(490, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Số Lượng"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(121, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Mã Số Sản Phẩm"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(490, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Đơn Vị"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(490, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Mô Tả"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(121, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Mã Sản Phẩm"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(217, 234)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(903, 405)
        Me.DataGridView1.TabIndex = 2
        '
        'SanPhamBindingSource
        '
        Me.SanPhamBindingSource.DataMember = "SanPham"
        Me.SanPhamBindingSource.DataSource = Me.QuanLyKhoHangDataSet1BindingSource
        '
        'QuanLyKhoHangDataSet1BindingSource
        '
        Me.QuanLyKhoHangDataSet1BindingSource.DataSource = Me.QuanLyKhoHangDataSet1
        Me.QuanLyKhoHangDataSet1BindingSource.Position = 0
        '
        'QuanLyKhoHangDataSet1
        '
        Me.QuanLyKhoHangDataSet1.DataSetName = "QuanLyKhoHangDataSet1"
        Me.QuanLyKhoHangDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(490, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(358, 39)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "QUẢN LÍ SẢN PHẨM"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'QuanLyKhoHangDataSetBindingSource
        '
        Me.QuanLyKhoHangDataSetBindingSource.DataSource = GetType(QuanLyKhoHang_BaiTapThucHanh.QuanLyKhoHangDataSet1)
        Me.QuanLyKhoHangDataSetBindingSource.Position = 0
        '
        'SanPhamTableAdapter
        '
        Me.SanPhamTableAdapter.ClearBeforeFill = True
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(36, 554)
        Me.btnTimKiem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(139, 36)
        Me.btnTimKiem.TabIndex = 3
        Me.btnTimKiem.Text = "Tìm Kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'QuanLiSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 650)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "QuanLiSanPham"
        Me.Text = "QuanLiSanPham"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SanPhamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuanLyKhoHangDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuanLyKhoHangDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuanLyKhoHangDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_MaSanPham As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_TenSanPham As TextBox
    Friend WithEvents txt_MaSoSanPham As TextBox
    Friend WithEvents txt_SoLuong As TextBox
    Friend WithEvents txt_DonVi As TextBox
    Friend WithEvents txt_MoTa As TextBox
    Friend WithEvents btn_ThongKe As Button
    Friend WithEvents btn_Sua As Button
    Friend WithEvents btn_Xoa As Button
    Friend WithEvents btn_Them As Button
    Friend WithEvents QuanLyKhoHangDataSetBindingSource As BindingSource
    Friend WithEvents QuanLyKhoHangDataSet1BindingSource As BindingSource
    Friend WithEvents QuanLyKhoHangDataSet1 As QuanLyKhoHangDataSet1
    Friend WithEvents SanPhamBindingSource As BindingSource
    Friend WithEvents SanPhamTableAdapter As QuanLyKhoHangDataSet1TableAdapters.SanPhamTableAdapter
    Friend WithEvents btn_LamMoi As Button
    Friend WithEvents btnTimKiem As Button
End Class
