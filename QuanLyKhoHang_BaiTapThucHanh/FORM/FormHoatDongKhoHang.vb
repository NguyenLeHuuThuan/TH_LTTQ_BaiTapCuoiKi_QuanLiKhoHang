Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class FormHoatDongKhoHang
    Private Sub FormHoatDongKhoHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Dọn dẹp biểu đồ
        Chart1.Series.Clear()
        Chart1.ChartAreas.Clear()
        Chart1.Titles.Clear()
        Chart1.Legends.Clear()

        ' VÙNG VẼ (ChartArea)
        Dim area As New ChartArea("Main")
        With area
            .BackColor = Color.WhiteSmoke
            .AxisX.LabelStyle.Angle = -45
            .AxisX.Interval = 1
            .AxisX.Title = "Tên sản phẩm"
            .AxisX.TitleFont = New Font("Segoe UI", 11, FontStyle.Bold)
            .AxisX.MajorGrid.LineColor = Color.LightGray

            .AxisY.Title = "Số lượng"
            .AxisY.TitleFont = New Font("Segoe UI", 11, FontStyle.Bold)
            .AxisY.MajorGrid.LineColor = Color.LightGray
        End With
        Chart1.ChartAreas.Add(area)

        ' TIÊU ĐỀ
        Chart1.Titles.Add(New Title("Biểu đồ kết hợp: Nhập (Cột) & Xuất (Đường) theo sản phẩm",
                             Docking.Top,
                             New Font("Segoe UI", 14, FontStyle.Bold),
                             Color.FromArgb(30, 60, 120)))

        ' CHÚ THÍCH (Legend)
        Dim legend As New Legend With {
            .Docking = Docking.Top,
            .Alignment = StringAlignment.Center,
            .Font = New Font("Segoe UI", 10, FontStyle.Regular)
        }
        Chart1.Legends.Add(legend)

        ' SERIES NHẬP – CỘT
        Dim seriesNhap As New Series("Nhập") With {
            .ChartType = SeriesChartType.Column,
            .Color = Color.FromArgb(70, 130, 180), ' SteelBlue
            .IsValueShownAsLabel = True,
            .Font = New Font("Segoe UI", 9, FontStyle.Bold),
            .BorderWidth = 1,
            .ShadowOffset = 2
        }

        ' SERIES XUẤT – ĐƯỜNG
        Dim seriesXuat As New Series("Xuất") With {
            .ChartType = SeriesChartType.Line,
            .Color = Color.FromArgb(220, 50, 50), ' Red
            .BorderWidth = 3,
            .IsValueShownAsLabel = True,
            .Font = New Font("Segoe UI", 9, FontStyle.Bold),
            .MarkerStyle = MarkerStyle.Circle,
            .MarkerSize = 9
        }

        ' Thêm series vào biểu đồ
        Chart1.Series.Add(seriesNhap)
        Chart1.Series.Add(seriesXuat)

        ' Lấy dữ liệu từ cơ sở dữ liệu
        Try
            conn.Open()
            Dim sql As String = "
            SELECT 
                sp.TenSanPham,
                ISNULL(SUM(CASE WHEN gd.LoaiGiaoDich = N'Nhap' THEN gd.SoLuong END), 0) AS TongNhap,
                ISNULL(SUM(CASE WHEN gd.LoaiGiaoDich = N'Xuat' THEN gd.SoLuong END), 0) AS TongXuat
            FROM SanPham sp
            LEFT JOIN LichSuGiaoDich gd ON sp.MaSanPham = gd.MaSanPham
            GROUP BY sp.TenSanPham
            ORDER BY sp.TenSanPham"

            Dim cmd As New SqlCommand(sql, conn)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim tenSP = reader("TenSanPham").ToString()
                Dim tongNhap = Convert.ToInt32(reader("TongNhap"))
                Dim tongXuat = Convert.ToInt32(reader("TongXuat"))

                seriesNhap.Points.AddXY(tenSP, tongNhap)
                seriesXuat.Points.AddXY(tenSP, tongXuat)
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tải dữ liệu: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class