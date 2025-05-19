IF EXISTS (SELECT * From SYS.DATABASES WHERE NAME = 'QuanLyKhoHang' )
BEGIN
-- su dung database master de xoa database tren
	use master
-- dong tat ca cac ket noi den co so, du lieu chuyen sang che do simggle use
	alter database QuanLyKhoHang set single_user with rollback immediate
	drop database QuanLyKhoHang;
END
-- Tạo database
CREATE DATABASE QuanLyKhoHang;
GO
USE QuanLyKhoHang;
GO
CREATE TABLE Admin (
    MaAdmin INT PRIMARY KEY IDENTITY(1,1),
    TenDangNhap NVARCHAR(50) UNIQUE NOT NULL,
    MatKhau NVARCHAR(100) NOT NULL, -- Nên mã hóa mật khẩu
    HoTen NVARCHAR(100),
    NgayTao DATE NOT NULL DEFAULT GETDATE(),
    TrangThai BIT NOT NULL DEFAULT 1 
);
-- Bảng Sản phẩm
CREATE TABLE SanPham (
    MaSanPham INT PRIMARY KEY IDENTITY(1,1),
    MaSoSanPham NVARCHAR(20) UNIQUE NOT NULL,
    TenSanPham NVARCHAR(100) NOT NULL,
    MoTa NVARCHAR(MAX),
    DonVi NVARCHAR(20) NOT NULL,
    SoLuongTon INT NOT NULL DEFAULT 0
);
-- Bảng Kho
CREATE TABLE NhaCungCap (
    MaNhaCungCap INT PRIMARY KEY IDENTITY(1,1),
    MaSoNhaCungCap NVARCHAR(20) UNIQUE NOT NULL,
    TenNhaCungCap NVARCHAR(100) NOT NULL,
    SoDienThoai NVARCHAR(100)
);
--Bang nhập xuất kho
CREATE TABLE LichSuGiaoDich (
    MaGiaoDich INT PRIMARY KEY IDENTITY(1,1),
    MaSanPham INT NOT NULL,
    LoaiGiaoDich NVARCHAR(10) NOT NULL CHECK (LoaiGiaoDich IN ('Nhap', 'Xuat')),
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    NgayGiaoDich DATE NOT NULL,
    MaNhaCungCap INT NULL, -- chỉ có khi là Nhập kho
    GhiChu NVARCHAR(200),
    CONSTRAINT FK_GiaoDich_SanPham FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham),
    CONSTRAINT FK_GiaoDich_NCC FOREIGN KEY (MaNhaCungCap) REFERENCES NhaCungCap(MaNhaCungCap)
);

INSERT INTO SanPham (MaSoSanPham, TenSanPham, MoTa, DonVi, SoLuongTon)
VALUES 
(N'SP001', N'Bút bi xanh', N'Bút viết trơn màu xanh', N'Cây', 50),
(N'SP002', N'Bút chì', N'Bút chì gỗ 2B', N'Cây', 30),
(N'SP003', N'Vở 96 trang', N'Vở học sinh', N'Cuốn', 100),
(N'SP004', N'Thước kẻ 20cm', N'Thước nhựa trong suốt', N'Cái', 70),
(N'SP005', N'Tẩy', N'Cục gôm học sinh', N'Cái', 40),
(N'SP006', N'Compas', N'Compas kim loại', N'Cái', 0),
(N'SP007', N'Bảng trắng mini', N'Bảng viết mini cho học sinh', N'Cái', 0),
(N'SP008', N'Mực bút máy', N'Mực xanh', N'Lọ', 20),
(N'SP009', N'Hộp màu sáp', N'Hộp 12 màu sáp', N'Hộp', 10),
(N'SP010', N'Giấy A4', N'Giấy trắng in A4', N'Ram', 200);

INSERT INTO NhaCungCap (MaSoNhaCungCap, TenNhaCungCap, SoDienThoai)
VALUES 
(N'NCC001', N'Thiên Long', N'0909123456'),
(N'NCC002', N'Fahasa', N'0912345678'),
(N'NCC003', N'An Bình', N'0988888888');

-- 10 giao dịch NHẬP
INSERT INTO LichSuGiaoDich (MaSanPham, LoaiGiaoDich, SoLuong, NgayGiaoDich, MaNhaCungCap, GhiChu)
VALUES 
(1, N'Nhap', 100, '2025-05-01', 1, N'Nhập bút bi'),
(2, N'Nhap', 50, '2025-05-01', 1, N'Nhập bút chì'),
(3, N'Nhap', 120, '2025-05-02', 2, N'Nhập vở'),
(4, N'Nhap', 80, '2025-05-02', 2, N'Nhập thước'),
(5, N'Nhap', 60, '2025-05-03', 3, N'Nhập tẩy'),
(8, N'Nhap', 30, '2025-05-04', 1, N'Nhập mực'),
(9, N'Nhap', 25, '2025-05-04', 2, N'Nhập màu'),
(10, N'Nhap', 250, '2025-05-05', 3, N'Nhập giấy'),
(1, N'Nhap', 50, '2025-05-06', 1, N'Nhập thêm bút bi'),
(3, N'Nhap', 80, '2025-05-06', 2, N'Nhập thêm vở');

-- 10 giao dịch XUẤT
INSERT INTO LichSuGiaoDich (MaSanPham, LoaiGiaoDich, SoLuong, NgayGiaoDich, MaNhaCungCap, GhiChu)
VALUES 
(1, N'Xuat', 70, '2025-05-07', NULL, N'Xuất bút bi'),
(2, N'Xuat', 20, '2025-05-07', NULL, N'Xuất bút chì'),
(3, N'Xuat', 100, '2025-05-08', NULL, N'Xuất vở'),
(4, N'Xuat', 30, '2025-05-08', NULL, N'Xuất thước'),
(5, N'Xuat', 20, '2025-05-09', NULL, N'Xuất tẩy'),
(8, N'Xuat', 10, '2025-05-10', NULL, N'Xuất mực'),
(9, N'Xuat', 5, '2025-05-10', NULL, N'Xuất màu'),
(10, N'Xuat', 100, '2025-05-10', NULL, N'Xuất giấy'),
(1, N'Xuat', 30, '2025-05-11', NULL, N'Xuất thêm bút bi'),
(4, N'Xuat', 20, '2025-05-11', NULL, N'Xuất thêm thước');

INSERT INTO Admin (TenDangNhap, MatKhau, HoTen)
VALUES 
(N'admin', N'admin123', N'Nguyễn Phương');
go
CREATE TRIGGER trg_Update_TonKho
ON LichSuGiaoDich
AFTER INSERT
AS
BEGIN
    UPDATE sp
    SET SoLuongTon = 
        SoLuongTon + 
        ISNULL((
            SELECT SUM(CASE 
                        WHEN i.LoaiGiaoDich = N'Nhap' THEN i.SoLuong 
                        WHEN i.LoaiGiaoDich = N'Xuat' THEN -i.SoLuong 
                        ELSE 0 
                    END)
            FROM inserted i
            WHERE i.MaSanPham = sp.MaSanPham
        ), 0)
    FROM SanPham sp
    WHERE EXISTS (
        SELECT 1 FROM inserted i WHERE i.MaSanPham = sp.MaSanPham
    )
END

create procedure pro_PhieuNhap
as
begin
	select *
	from LichSuGiaoDich
	where LoaiGiaoDich = N'Nhap'
end
create procedure pro_PhieuXuat
as
begin
	select *
	from LichSuGiaoDich
	where LoaiGiaoDich = N'Xuat'
end
exec pro_PhieuNhap
SELECT MaNhaCungCap FROM NhaCungCap
select * from LichSuGiaoDich

update LichSuGiaoDich set MaSanPham = 4 ,
                                      SoLuong = 20,
                                      NgayGiaoDich = N'2025-05-11', 
                                      MaNhaCungCap = 1, 
                                      GhiChu = N'tsst thử thoi' 
                                      where MaGiaoDich = 20