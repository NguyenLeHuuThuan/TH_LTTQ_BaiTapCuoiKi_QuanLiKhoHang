<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuanLiNCC
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_LamMoi = New System.Windows.Forms.Button()
        Me.btn_Sua = New System.Windows.Forms.Button()
        Me.btn_Xoa = New System.Windows.Forms.Button()
        Me.btn_Them = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_TenNCC = New System.Windows.Forms.TextBox()
        Me.txt_SDT = New System.Windows.Forms.TextBox()
        Me.txt_MaSoNCC = New System.Windows.Forms.TextBox()
        Me.txt_MaNCC = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NhaCungCapBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuanLyKhoHangDataSet2 = New QuanLyKhoHang_BaiTapThucHanh.QuanLyKhoHangDataSet2()
        Me.NhaCungCapTableAdapter = New QuanLyKhoHang_BaiTapThucHanh.QuanLyKhoHangDataSet2TableAdapters.NhaCungCapTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnThongKe = New System.Windows.Forms.Button()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.NhaCungCapBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuanLyKhoHangDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnTimKiem)
        Me.Panel1.Controls.Add(Me.btnThongKe)
        Me.Panel1.Controls.Add(Me.btn_LamMoi)
        Me.Panel1.Controls.Add(Me.btn_Sua)
        Me.Panel1.Controls.Add(Me.btn_Xoa)
        Me.Panel1.Controls.Add(Me.btn_Them)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(1, -2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(232, 650)
        Me.Panel1.TabIndex = 0
        '
        'btn_LamMoi
        '
        Me.btn_LamMoi.Location = New System.Drawing.Point(51, 407)
        Me.btn_LamMoi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_LamMoi.Name = "btn_LamMoi"
        Me.btn_LamMoi.Size = New System.Drawing.Size(112, 36)
        Me.btn_LamMoi.TabIndex = 3
        Me.btn_LamMoi.Text = "Làm Mới"
        Me.btn_LamMoi.UseVisualStyleBackColor = True
        '
        'btn_Sua
        '
        Me.btn_Sua.Location = New System.Drawing.Point(51, 318)
        Me.btn_Sua.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Sua.Name = "btn_Sua"
        Me.btn_Sua.Size = New System.Drawing.Size(112, 36)
        Me.btn_Sua.TabIndex = 2
        Me.btn_Sua.Text = "Sửa"
        Me.btn_Sua.UseVisualStyleBackColor = True
        '
        'btn_Xoa
        '
        Me.btn_Xoa.Location = New System.Drawing.Point(51, 237)
        Me.btn_Xoa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Xoa.Name = "btn_Xoa"
        Me.btn_Xoa.Size = New System.Drawing.Size(112, 36)
        Me.btn_Xoa.TabIndex = 2
        Me.btn_Xoa.Text = "Xoá"
        Me.btn_Xoa.UseVisualStyleBackColor = True
        '
        'btn_Them
        '
        Me.btn_Them.Location = New System.Drawing.Point(51, 151)
        Me.btn_Them.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Them.Name = "btn_Them"
        Me.btn_Them.Size = New System.Drawing.Size(112, 34)
        Me.btn_Them.TabIndex = 1
        Me.btn_Them.Text = "Thêm"
        Me.btn_Them.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 39)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "MENU"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txt_TenNCC)
        Me.Panel2.Controls.Add(Me.txt_SDT)
        Me.Panel2.Controls.Add(Me.txt_MaSoNCC)
        Me.Panel2.Controls.Add(Me.txt_MaNCC)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(251, 122)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(876, 149)
        Me.Panel2.TabIndex = 1
        '
        'txt_TenNCC
        '
        Me.txt_TenNCC.Location = New System.Drawing.Point(585, 29)
        Me.txt_TenNCC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_TenNCC.Name = "txt_TenNCC"
        Me.txt_TenNCC.Size = New System.Drawing.Size(166, 22)
        Me.txt_TenNCC.TabIndex = 4
        '
        'txt_SDT
        '
        Me.txt_SDT.Location = New System.Drawing.Point(585, 88)
        Me.txt_SDT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_SDT.Name = "txt_SDT"
        Me.txt_SDT.Size = New System.Drawing.Size(166, 22)
        Me.txt_SDT.TabIndex = 4
        '
        'txt_MaSoNCC
        '
        Me.txt_MaSoNCC.Location = New System.Drawing.Point(260, 86)
        Me.txt_MaSoNCC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_MaSoNCC.Name = "txt_MaSoNCC"
        Me.txt_MaSoNCC.Size = New System.Drawing.Size(129, 22)
        Me.txt_MaSoNCC.TabIndex = 4
        '
        'txt_MaNCC
        '
        Me.txt_MaNCC.Location = New System.Drawing.Point(260, 29)
        Me.txt_MaNCC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_MaNCC.Name = "txt_MaNCC"
        Me.txt_MaNCC.Size = New System.Drawing.Size(129, 22)
        Me.txt_MaNCC.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(493, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "SDT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(493, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Tên NCC"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(144, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Mã Số NCC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(144, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Mã NCC"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(463, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(446, 39)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "QUẢN LÍ NHÀ CUNG CẤP"
        '
        'NhaCungCapBindingSource
        '
        Me.NhaCungCapBindingSource.DataMember = "NhaCungCap"
        Me.NhaCungCapBindingSource.DataSource = Me.QuanLyKhoHangDataSet2
        '
        'QuanLyKhoHangDataSet2
        '
        Me.QuanLyKhoHangDataSet2.DataSetName = "QuanLyKhoHangDataSet2"
        Me.QuanLyKhoHangDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NhaCungCapTableAdapter
        '
        Me.NhaCungCapTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(251, 276)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(876, 372)
        Me.DataGridView1.TabIndex = 3
        '
        'btnThongKe
        '
        Me.btnThongKe.Location = New System.Drawing.Point(51, 481)
        Me.btnThongKe.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnThongKe.Name = "btnThongKe"
        Me.btnThongKe.Size = New System.Drawing.Size(112, 36)
        Me.btnThongKe.TabIndex = 4
        Me.btnThongKe.Text = "Thống kê"
        Me.btnThongKe.UseVisualStyleBackColor = True
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(51, 552)
        Me.btnTimKiem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(112, 36)
        Me.btnTimKiem.TabIndex = 5
        Me.btnTimKiem.Text = "Tìm kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'QuanLiNCC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1139, 659)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "QuanLiNCC"
        Me.Text = "QuanLiNCC"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.NhaCungCapBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuanLyKhoHangDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents QuanLyKhoHangDataSet2 As QuanLyKhoHangDataSet2
    Friend WithEvents NhaCungCapBindingSource As BindingSource
    Friend WithEvents NhaCungCapTableAdapter As QuanLyKhoHangDataSet2TableAdapters.NhaCungCapTableAdapter
    Friend WithEvents btn_Sua As Button
    Friend WithEvents btn_Xoa As Button
    Friend WithEvents btn_Them As Button
    Friend WithEvents txt_TenNCC As TextBox
    Friend WithEvents txt_SDT As TextBox
    Friend WithEvents txt_MaSoNCC As TextBox
    Friend WithEvents txt_MaNCC As TextBox
    Friend WithEvents btn_LamMoi As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnThongKe As Button
    Friend WithEvents btnTimKiem As Button
End Class
