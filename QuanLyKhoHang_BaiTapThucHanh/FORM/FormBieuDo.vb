Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class FormBieuDoTyLeNhapNCC
    Private Sub FormBieuDo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Xóa cũ
        Chart1.Series.Clear()
        Chart1.ChartAreas.Clear()
        Chart1.Titles.Clear()
        Chart1.Legends.Clear()

        ' Vùng vẽ chính
        Dim area As New ChartArea("PieArea")
        area.BackColor = Color.Transparent
        Chart1.ChartAreas.Add(area)

        ' Tiêu đề
        Dim title As New Title("TỈ LỆ NHẬP KHO THEO NHÀ CUNG CẤP", Docking.Top, New Font("Segoe UI", 14, FontStyle.Bold), Color.Navy)
        Chart1.Titles.Add(title)

        ' Thêm legend
        Dim legend As New Legend()
        legend.Docking = Docking.Right
        legend.Font = New Font("Segoe UI", 10)
        Chart1.Legends.Add(legend)

        ' Series
        Dim seriesPie As New Series("Tỉ lệ nhập")
        With seriesPie
            .ChartType = SeriesChartType.Pie
            .Font = New Font("Segoe UI", 9, FontStyle.Bold)
            .LabelForeColor = Color.White
            .IsValueShownAsLabel = True
            .Label = "#PERCENT{P1} - #VALX"
            .LegendText = "#VALX (#VAL)"
            .BorderWidth = 1
            .BorderColor = Color.White
            .BackSecondaryColor = Color.White
            .ShadowOffset = 2
            .CustomProperties = "PieLabelStyle=Outside, PieDrawingStyle=SoftEdge, CollectedThreshold=2"
        End With
        Chart1.Series.Add(seriesPie)

        ' Lấy dữ liệu từ CSDL
        Try
            conn.Open()
            Dim sql As String = "
            SELECT 
                ncc.TenNhaCungCap,
                SUM(gd.SoLuong) AS TongNhap
            FROM LichSuGiaoDich gd
            JOIN NhaCungCap ncc ON gd.MaNhaCungCap = ncc.MaNhaCungCap
            WHERE gd.LoaiGiaoDich = N'Nhap'
            GROUP BY ncc.TenNhaCungCap
            ORDER BY TongNhap DESC"
            Dim cmd As New SqlCommand(sql, conn)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            Dim totalNhap As Integer = 0
            Dim data As New List(Of KeyValuePair(Of String, Integer))

            ' Đọc dữ liệu vào danh sách và tính tổng
            While reader.Read()
                Dim tenNCC = reader("TenNhaCungCap").ToString()
                Dim tongNhap = Convert.ToInt32(reader("TongNhap"))
                data.Add(New KeyValuePair(Of String, Integer)(tenNCC, tongNhap))
                totalNhap += tongNhap
            End While
            reader.Close()

            ' Đưa dữ liệu vào biểu đồ và gắn phần trăm
            For Each item In data
                Dim tyLe As Double = item.Value * 100.0 / totalNhap
                Dim pIndex As Integer = seriesPie.Points.AddXY(item.Key, item.Value)

                ' Gắn phần trăm vào Legend và Label
                seriesPie.Points(pIndex).LegendText = $"{item.Key} ({item.Value}) - {tyLe:F1}%"
                seriesPie.Points(pIndex).Label = $"{tyLe:F1}% - {item.Key}"
            Next
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tải biểu đồ: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class