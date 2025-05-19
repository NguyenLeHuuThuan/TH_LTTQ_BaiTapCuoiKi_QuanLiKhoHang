Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports Microsoft.Office.Interop
Public Class FormBieuDoNhapXuatKho
    Private Sub FormBieuDoNhapXuatKho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Xóa các phần cũ
        Chart1.Series.Clear()
        Chart1.ChartAreas.Clear()
        Chart1.Titles.Clear()
        Chart1.Legends.Clear()

        ' Vùng vẽ chính
        Dim area As New ChartArea("Main")
        With area
            .AxisX.LabelStyle.Angle = -45
            .AxisX.Interval = 1
            .AxisX.IsLabelAutoFit = True
            .AxisX.Title = "Sản phẩm"
            .AxisX.TitleFont = New Font("Segoe UI", 11, FontStyle.Bold)
            .AxisY.Title = "Số lượng"
            .AxisY.TitleFont = New Font("Segoe UI", 11, FontStyle.Bold)
            .BackColor = Color.WhiteSmoke
            .AxisX.MajorGrid.LineColor = Color.LightGray
            .AxisY.MajorGrid.LineColor = Color.LightGray
        End With
        Chart1.ChartAreas.Add(area)

        ' Tiêu đề
        Chart1.Titles.Add(New Title("Thống kê Nhập - Xuất - Tồn kho theo sản phẩm", Docking.Top,
            New Font("Segoe UI", 14, FontStyle.Bold), Color.Navy))

        ' Legend (chú thích)
        Dim legend As New Legend()
        legend.Docking = Docking.Top
        legend.Font = New Font("Segoe UI", 10)
        Chart1.Legends.Add(legend)

        ' Series: nhập, xuất, tồn
        Dim seriesNhap As New Series("Nhập") With {
            .ChartType = SeriesChartType.Column,
            .IsValueShownAsLabel = True,
            .Color = Color.SteelBlue,
            .Font = New Font("Segoe UI", 9, FontStyle.Bold)
        }

        Dim seriesXuat As New Series("Xuất") With {
            .ChartType = SeriesChartType.Column,
            .IsValueShownAsLabel = True,
            .Color = Color.OrangeRed,
            .Font = New Font("Segoe UI", 9, FontStyle.Bold)
        }

        Dim seriesTon As New Series("Tồn kho") With {
            .ChartType = SeriesChartType.Column,
            .IsValueShownAsLabel = True,
            .Color = Color.SeaGreen,
            .Font = New Font("Segoe UI", 9, FontStyle.Bold)
        }

        ' Thêm series vào biểu đồ
        Chart1.Series.Add(seriesNhap)
        Chart1.Series.Add(seriesXuat)
        Chart1.Series.Add(seriesTon)

        ' Làm mảnh các cột
        For Each s In Chart1.Series
            s("PointWidth") = "0.5"
            s.ShadowOffset = 2 ' đổ bóng nhẹ
        Next

        ' Truy vấn dữ liệu
        Try
            conn.Open()
            Dim sql As String = "
        SELECT 
            sp.TenSanPham,
            ISNULL(SUM(CASE WHEN gd.LoaiGiaoDich = N'Nhap' THEN gd.SoLuong END), 0) AS TongNhap,
            ISNULL(SUM(CASE WHEN gd.LoaiGiaoDich = N'Xuat' THEN gd.SoLuong END), 0) AS TongXuat,
            sp.SoLuongTon
        FROM SanPham sp
        LEFT JOIN LichSuGiaoDich gd ON sp.MaSanPham = gd.MaSanPham
        GROUP BY sp.TenSanPham, sp.SoLuongTon
        ORDER BY sp.TenSanPham"

            Using cmd As New SqlCommand(sql, conn)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim tenSP = reader("TenSanPham").ToString()
                        Dim tongNhap = Convert.ToInt32(reader("TongNhap"))
                        Dim tongXuat = Convert.ToInt32(reader("TongXuat"))
                        Dim tonKho = Convert.ToInt32(reader("SoLuongTon"))

                        seriesNhap.Points.AddXY(tenSP, tongNhap)
                        seriesXuat.Points.AddXY(tenSP, tongXuat)
                        seriesTon.Points.AddXY(tenSP, tonKho)
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnInExcel_Click(sender As Object, e As EventArgs) Handles btnInExcel.Click
        ' Hộp thoại chọn nơi lưu
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Title = "Chọn nguồn lưu file Excel"
        saveDialog.Filter = "Excel Workbook|*.xlsx"
        saveDialog.FileName = "ThongKe_Nhap_Xuat_Ton.xlsx"

        If saveDialog.ShowDialog() = DialogResult.OK Then
            Dim excelApp As New Excel.Application
            Dim workbook As Excel.Workbook = excelApp.Workbooks.Add()
            Dim sheet As Excel.Worksheet = workbook.Sheets(1)
            sheet.Name = "ThongKeNhapXuatTon"

            ' Ghi tiêu đề
            sheet.Cells(1, 1).Value = "Tên sản phẩm"
            sheet.Cells(1, 2).Value = "Số lượng Nhập"
            sheet.Cells(1, 3).Value = "Số lượng Xuất"
            sheet.Cells(1, 4).Value = "Tồn kho"

            ' ✅ Lấy Series từ biểu đồ (nếu không khai báo toàn cục)
            Dim seriesNhap = Chart1.Series("Nhập")
            Dim seriesXuat = Chart1.Series("Xuất")
            Dim seriesTon = Chart1.Series("Tồn kho")

            ' Ghi dữ liệu
            Dim row As Integer = 2
            For i = 0 To seriesNhap.Points.Count - 1
                Dim tenSP As String = seriesNhap.Points(i).AxisLabel
                Dim nhap = seriesNhap.Points(i).YValues(0)
                Dim xuat = seriesXuat.Points(i).YValues(0)
                Dim ton = seriesTon.Points(i).YValues(0)

                sheet.Cells(row, 1).Value = tenSP
                sheet.Cells(row, 2).Value = nhap
                sheet.Cells(row, 3).Value = xuat
                sheet.Cells(row, 4).Value = ton
                row += 1
            Next

            ' Định dạng
            sheet.Range("A1:D1").Font.Bold = True
            sheet.Columns.AutoFit()

            ' Lưu
            workbook.SaveAs(saveDialog.FileName)

            ' Đóng và giải phóng
            workbook.Close(False)
            excelApp.Quit()
            releaseObject(sheet)
            releaseObject(workbook)
            releaseObject(excelApp)

            MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private originalBackColor As Color = Color.LightSteelBlue
    Private hoverBackColor As Color = Color.MediumSeaGreen
    Private originalBorderColor As Color = Color.SteelBlue
    Private hoverBorderColor As Color = Color.SeaGreen

    Private Sub btnInExcel_MouseEnter(sender As Object, e As EventArgs) Handles btnInExcel.MouseEnter
        btnInExcel.BackColor = hoverBackColor
        btnInExcel.FlatAppearance.BorderColor = hoverBorderColor
    End Sub

    Private Sub btnInExcel_MouseLeave(sender As Object, e As EventArgs) Handles btnInExcel.MouseLeave
        btnInExcel.BackColor = originalBackColor
        btnInExcel.FlatAppearance.BorderColor = originalBorderColor
    End Sub
End Class