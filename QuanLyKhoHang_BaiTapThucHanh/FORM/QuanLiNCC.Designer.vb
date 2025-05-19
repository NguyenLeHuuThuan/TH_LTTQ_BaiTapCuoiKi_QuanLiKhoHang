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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MaNhaCungCapDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaSoNhaCungCapDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenNhaCungCapDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoDienThoaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NhaCungCapBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuanLyKhoHangDataSet2 = New QuanLyKhoHang_BaiTapThucHanh.QuanLyKhoHangDataSet2()
        Me.NhaCungCapTableAdapter = New QuanLyKhoHang_BaiTapThucHanh.QuanLyKhoHangDataSet2TableAdapters.NhaCungCapTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NhaCungCapBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuanLyKhoHangDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_LamMoi)
        Me.Panel1.Controls.Add(Me.btn_Sua)
        Me.Panel1.Controls.Add(Me.btn_Xoa)
        Me.Panel1.Controls.Add(Me.btn_Them)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(1, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(265, 686)
        Me.Panel1.TabIndex = 0
        '
        'btn_LamMoi
        '
        Me.btn_LamMoi.Location = New System.Drawing.Point(57, 509)
        Me.btn_LamMoi.Name = "btn_LamMoi"
        Me.btn_LamMoi.Size = New System.Drawing.Size(126, 45)
        Me.btn_LamMoi.TabIndex = 3
        Me.btn_LamMoi.Text = "Làm Mới"
        Me.btn_LamMoi.UseVisualStyleBackColor = True
        '
        'btn_Sua
        '
        Me.btn_Sua.Location = New System.Drawing.Point(57, 397)
        Me.btn_Sua.Name = "btn_Sua"
        Me.btn_Sua.Size = New System.Drawing.Size(126, 45)
        Me.btn_Sua.TabIndex = 2
        Me.btn_Sua.Text = "Sửa"
        Me.btn_Sua.UseVisualStyleBackColor = True
        '
        'btn_Xoa
        '
        Me.btn_Xoa.Location = New System.Drawing.Point(57, 296)
        Me.btn_Xoa.Name = "btn_Xoa"
        Me.btn_Xoa.Size = New System.Drawing.Size(126, 45)
        Me.btn_Xoa.TabIndex = 2
        Me.btn_Xoa.Text = "Xoá"
        Me.btn_Xoa.UseVisualStyleBackColor = True
        '
        'btn_Them
        '
        Me.btn_Them.Location = New System.Drawing.Point(57, 189)
        Me.btn_Them.Name = "btn_Them"
        Me.btn_Them.Size = New System.Drawing.Size(126, 42)
        Me.btn_Them.TabIndex = 1
        Me.btn_Them.Text = "Thêm"
        Me.btn_Them.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 46)
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
        Me.Panel2.Location = New System.Drawing.Point(282, 153)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(881, 186)
        Me.Panel2.TabIndex = 1
        '
        'txt_TenNCC
        '
        Me.txt_TenNCC.Location = New System.Drawing.Point(552, 34)
        Me.txt_TenNCC.Name = "txt_TenNCC"
        Me.txt_TenNCC.Size = New System.Drawing.Size(186, 26)
        Me.txt_TenNCC.TabIndex = 4
        '
        'txt_SDT
        '
        Me.txt_SDT.Location = New System.Drawing.Point(552, 108)
        Me.txt_SDT.Name = "txt_SDT"
        Me.txt_SDT.Size = New System.Drawing.Size(186, 26)
        Me.txt_SDT.TabIndex = 4
        '
        'txt_MaSoNCC
        '
        Me.txt_MaSoNCC.Location = New System.Drawing.Point(187, 105)
        Me.txt_MaSoNCC.Name = "txt_MaSoNCC"
        Me.txt_MaSoNCC.Size = New System.Drawing.Size(145, 26)
        Me.txt_MaSoNCC.TabIndex = 4
        '
        'txt_MaNCC
        '
        Me.txt_MaNCC.Location = New System.Drawing.Point(187, 34)
        Me.txt_MaNCC.Name = "txt_MaNCC"
        Me.txt_MaNCC.Size = New System.Drawing.Size(145, 26)
        Me.txt_MaNCC.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(449, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "SDT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(449, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Tên NCC"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Mã Số NCC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Mã NCC"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(449, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(518, 46)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "QUẢN LÍ NHÀ CUNG CẤP"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaNhaCungCapDataGridViewTextBoxColumn, Me.MaSoNhaCungCapDataGridViewTextBoxColumn, Me.TenNhaCungCapDataGridViewTextBoxColumn, Me.SoDienThoaiDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.NhaCungCapBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(289, 366)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(873, 285)
        Me.DataGridView1.TabIndex = 3
        '
        'MaNhaCungCapDataGridViewTextBoxColumn
        '
        Me.MaNhaCungCapDataGridViewTextBoxColumn.DataPropertyName = "MaNhaCungCap"
        Me.MaNhaCungCapDataGridViewTextBoxColumn.HeaderText = "MaNhaCungCap"
        Me.MaNhaCungCapDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MaNhaCungCapDataGridViewTextBoxColumn.Name = "MaNhaCungCapDataGridViewTextBoxColumn"
        Me.MaNhaCungCapDataGridViewTextBoxColumn.ReadOnly = True
        Me.MaNhaCungCapDataGridViewTextBoxColumn.Width = 150
        '
        'MaSoNhaCungCapDataGridViewTextBoxColumn
        '
        Me.MaSoNhaCungCapDataGridViewTextBoxColumn.DataPropertyName = "MaSoNhaCungCap"
        Me.MaSoNhaCungCapDataGridViewTextBoxColumn.HeaderText = "MaSoNhaCungCap"
        Me.MaSoNhaCungCapDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MaSoNhaCungCapDataGridViewTextBoxColumn.Name = "MaSoNhaCungCapDataGridViewTextBoxColumn"
        Me.MaSoNhaCungCapDataGridViewTextBoxColumn.Width = 150
        '
        'TenNhaCungCapDataGridViewTextBoxColumn
        '
        Me.TenNhaCungCapDataGridViewTextBoxColumn.DataPropertyName = "TenNhaCungCap"
        Me.TenNhaCungCapDataGridViewTextBoxColumn.HeaderText = "TenNhaCungCap"
        Me.TenNhaCungCapDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TenNhaCungCapDataGridViewTextBoxColumn.Name = "TenNhaCungCapDataGridViewTextBoxColumn"
        Me.TenNhaCungCapDataGridViewTextBoxColumn.Width = 150
        '
        'SoDienThoaiDataGridViewTextBoxColumn
        '
        Me.SoDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoai"
        Me.SoDienThoaiDataGridViewTextBoxColumn.HeaderText = "SoDienThoai"
        Me.SoDienThoaiDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SoDienThoaiDataGridViewTextBoxColumn.Name = "SoDienThoaiDataGridViewTextBoxColumn"
        Me.SoDienThoaiDataGridViewTextBoxColumn.Width = 150
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
        'QuanLiNCC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1175, 680)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "QuanLiNCC"
        Me.Text = "QuanLiNCC"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NhaCungCapBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuanLyKhoHangDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents QuanLyKhoHangDataSet2 As QuanLyKhoHangDataSet2
    Friend WithEvents NhaCungCapBindingSource As BindingSource
    Friend WithEvents NhaCungCapTableAdapter As QuanLyKhoHangDataSet2TableAdapters.NhaCungCapTableAdapter
    Friend WithEvents MaNhaCungCapDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaSoNhaCungCapDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenNhaCungCapDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoDienThoaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btn_Sua As Button
    Friend WithEvents btn_Xoa As Button
    Friend WithEvents btn_Them As Button
    Friend WithEvents txt_TenNCC As TextBox
    Friend WithEvents txt_SDT As TextBox
    Friend WithEvents txt_MaSoNCC As TextBox
    Friend WithEvents txt_MaNCC As TextBox
    Friend WithEvents btn_LamMoi As Button
End Class
