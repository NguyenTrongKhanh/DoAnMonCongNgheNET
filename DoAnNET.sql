CREATE DATABASE QLShopQuanAo
GO
USE QLShopQuanAo
GO
CREATE TABLE [dbo].[LOAISANPHAM]
(
	MaLoai NVARCHAR(50) PRIMARY KEY NOT NULL,
	TenLoaiSanPham NVARCHAR(50),
)
CREATE TABLE [dbo].[SANPHAM]
(
	MaSP NVARCHAR(50),
	TenSP NVARCHAR(100),
	HinhAnh NVARCHAR(100),
	TrangThai NVARCHAR(20),
	DonGia INT,
	SoLuongTon INT,
	MaChatLieu NVARCHAR(50),
	MaLoai NVARCHAR(50),
	MaNSX NVARCHAR(50),
	CONSTRAINT [PK_SANPHAM] PRIMARY KEY (MaSP)
)
CREATE TABLE [dbo].[CHATLIEU]
(
	MaChatLieu NVARCHAR(50) PRIMARY KEY NOT NULL,
	TenChatLieu NVARCHAR(50),
)

CREATE TABLE [dbo].[NHASANXUAT]
(
	MaNSX NVARCHAR(50) PRIMARY KEY NOT NULL,
	TenNSX NVARCHAR(50),
)
CREATE TABLE [dbo].[NHANVIEN]
(
	MaNV NVARCHAR(50),
	TenNV NVARCHAR(50),
	GioiTinh NCHAR(3),
	DiaChi NVARCHAR(50),
	SDT NVARCHAR(100),
	ChucVu NVARCHAR(50),
	CONSTRAINT [PK_NhanVien] PRIMARY KEY (MaNV)
)
CREATE TABLE [dbo].[KHACHHANG]
(
	MaKH NVARCHAR(50),
	TenKH NVARCHAR(50),
	SDT NVARCHAR(100),
	DiaChi NVARCHAR(50),
	MaLoaiKH NVARCHAR(50),
	CONSTRAINT [PK_KhachHang] PRIMARY KEY (MaKH)
)
CREATE TABLE [dbo].[LOAIKHACHHANG]
(
	MaLoaiKH NVARCHAR(50),
	TenLoai NVARCHAR(50),
	MoTa NVARCHAR(100),
	CONSTRAINT [PK_LoaiKhachHang] PRIMARY KEY (MaLoaiKH)
)
CREATE TABLE [dbo].[NGUOIDUNG]
(
	MaNguoiDung NVARCHAR(50),
	TenDangNhap VARCHAR(20),
	MatKhau VARCHAR(20),
	Quyen NVARCHAR(50),
	MaNV NVARCHAR(50),
	CONSTRAINT [PK_NguoiDung] PRIMARY KEY (MaNguoiDung)
)
CREATE TABLE [dbo].[HOADON]
(
	MaHD NVARCHAR(50),
	MaNV NVARCHAR(50),
	MaKH NVARCHAR(50),
	ThoiGian DATETIME,
	CONSTRAINT [PK_HoaDon] PRIMARY KEY (MaHD)
)
CREATE TABLE [dbo].[CHITIETHOADON]
(
	MaCTHoaDon NVARCHAR(50),
	MaHD NVARCHAR(50),
	MaSP NVARCHAR(50),
	SoLuong INT,
	DonGia INT,
	GiamGia NVARCHAR(50),
	CONSTRAINT [PK_CTHoaDon] PRIMARY KEY (MaCTHoaDon,MaHD)
)
CREATE TABLE [dbo].[GIAMGIA]
(
	MaGiamGia NVARCHAR(50),
	MoTa NVARCHAR(max),
	TiLeGiam INT,
	CONSTRAINT [PK_GiamGia] PRIMARY KEY (MaGiamGia)
)
CREATE TABLE [dbo].[DOITRA]
(
	MaDoiTra NVARCHAR(50),
	MaSP VARCHAR(10), 
	MoTa NVARCHAR(50), 
	SoLuong INT,
	CONSTRAINT [PK_DoiTra] PRIMARY KEY (MaDoiTra)
)
CREATE TABLE [dbo].[CHITIETDOITRA]
(
	MaCTDoiTra NVARCHAR(50),
	MaDoiTra NVARCHAR(50),
	MaSP NVARCHAR(50), 
	
	CONSTRAINT [PK_ChiTietDoiTra] PRIMARY KEY (MaCTDoiTra)
)	
GO
INSERT [dbo].[LOAISANPHAM] ([MaLoai], [TenLoaiSanPham]) VALUES (N'LT', N'Loại sản phẩm tốt')
INSERT [dbo].[LOAISANPHAM] ([MaLoai], [TenLoaiSanPham]) VALUES (N'LBT', N'Loại sản phẩm bình thường')
INSERT [dbo].[LOAISANPHAM] ([MaLoai], [TenLoaiSanPham]) VALUES (N'LCC', N'Loại sản phẩm cao cấp')

INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [HinhAnh],[TrangThai],[DonGia],[SoLuongTon],[MaChatLieu],[MaLoai],[MaNSX]) VALUES (N'SP001', N'Tee-Shirt',N'Tee.jpg', N'Có sẵn',150000,10,N'T001',N'LT',N'VN001')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [HinhAnh],[TrangThai],[DonGia],[SoLuongTon],[MaChatLieu],[MaLoai],[MaNSX]) VALUES (N'SP002', N'Áo Jacket',N'Jacket.jpg', N'Không có sẵn',250000,5,N'C001',N'LBT',N'M002')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [HinhAnh],[TrangThai],[DonGia],[SoLuongTon],[MaChatLieu],[MaLoai],[MaNSX]) VALUES (N'SP003', N'Quần Shorts',N'Shorts.jpg', N'Có sẵn',150000,15,N'L001',N'LT',N'U003')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [HinhAnh],[TrangThai],[DonGia],[SoLuongTon],[MaChatLieu],[MaLoai],[MaNSX]) VALUES (N'SP004',N'Áo Hoodie',N'Hoodie.jpg', N'Có sẵn ',200000,10,N'N001',N'LCC',N'N004')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [HinhAnh],[TrangThai],[DonGia],[SoLuongTon],[MaChatLieu],[MaLoai],[MaNSX]) VALUES (N'SP005', N'Áo Khoác',N'Khoac.jpg', N'Không có sẵn',150000,10,N'K001',N'LBT',N'D005')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [HinhAnh],[TrangThai],[DonGia],[SoLuongTon],[MaChatLieu],[MaLoai],[MaNSX]) VALUES (N'SP006',N'Quần Jean',N'Jean.jpg', N'Có sẵn tại',200000,25,N'J001',N'LCC',N'N001')

INSERT [dbo].[CHATLIEU] ([MaChatLieu], [TenChatLieu]) VALUES (N'T001', N'Vải Thun cao cấp')
INSERT [dbo].[CHATLIEU] ([MaChatLieu], [TenChatLieu]) VALUES (N'C001', N'Vải cotton cao cấp')
INSERT [dbo].[CHATLIEU] ([MaChatLieu], [TenChatLieu]) VALUES (N'L001', N'Vải Len cao cấp')
INSERT [dbo].[CHATLIEU] ([MaChatLieu], [TenChatLieu]) VALUES (N'N001', N'Vải Nỉ cao cấp')
INSERT [dbo].[CHATLIEU] ([MaChatLieu], [TenChatLieu]) VALUES (N'K001', N'Vải Ka Ki cao cấp')
INSERT [dbo].[CHATLIEU] ([MaChatLieu], [TenChatLieu]) VALUES (N'J001', N'Vải Jean cao cấp')


INSERT [dbo].[NHASANXUAT] ([MaNSX], [TenNSX]) VALUES (N'NSX001', N'Nhà sản xuất HUGU')
INSERT [dbo].[NHASANXUAT] ([MaNSX], [TenNSX]) VALUES (N'NSX002', N'Nhà sản xuất NIKE')
INSERT [dbo].[NHASANXUAT] ([MaNSX], [TenNSX]) VALUES (N'NSX003', N'Nhà sản xuất ADDIDAS')
INSERT [dbo].[NHASANXUAT] ([MaNSX], [TenNSX]) VALUES (N'NSX004', N'Nhà sản xuất CHANNEL')
INSERT [dbo].[NHASANXUAT] ([MaNSX], [TenNSX]) VALUES (N'NSX005', N'Nhà sản xuất HADES')



INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV],[GioiTinh],[DiaChi],[SDT],[ChucVu]) VALUES (N'NV001', N'Nguyễn Trọng Khánh',N'Nam',N'123/21/2 Điện Biên Phủ',N'9785213488',N'Quản Lý Shop')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV],[GioiTinh],[DiaChi],[SDT],[ChucVu]) VALUES (N'NV002',  N'Hứa Thị Mai',N'Nữ', N'234 Lê Trọng Tấn',N'978521234',N'Quản Lý Thu Ngân')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV],[GioiTinh],[DiaChi],[SDT],[ChucVu]) VALUES (N'NV003', N'Trần NGọc Thảo',N'Nữ',N'435 Âu Cơ',N'97852134867',N'Nhân viên bán hàng')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV],[GioiTinh],[DiaChi],[SDT],[ChucVu]) VALUES (N'NV004', N'Nguyễn Văn Ba',N'Nam',N'45 Nguyễn Thái Học',N'097852134872',N'Nhân viên bán hàng')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV],[GioiTinh],[DiaChi],[SDT],[ChucVu]) VALUES (N'NV005', N'Hà Thị Dung',N'Nữ',N'21/78 Bùi Xuân Khoái',N'97852134843',N'Nhân viên kiểm tra chất lượng')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV],[GioiTinh],[DiaChi],[SDT],[ChucVu]) VALUES (N'NV006', N'Hà Mỹ Tiên',N'Nữ',N'1748/56 CMT8',N'97852134889',N'Nhân viên bán hàng')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV],[GioiTinh],[DiaChi],[SDT],[ChucVu]) VALUES (N'NV007', N'Đặng Huỳnh Đức',N'Nam',N'234 Lê Trọng Tấn',N'9785213482',N'Quản Lý Kho')


INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH],[SDT],[DiaChi],[MaLoaiKH]) VALUES (N'KH001',  N'Nguyễn Hà Giang',N'919878732',N'25 Núi Thành',N'TT001')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH],[SDT],[DiaChi],[MaLoaiKH]) VALUES (N'KH002',N'Trần Thanh Tùng',N'0842364',N'857/48 Ba Vân',N'TN001')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH],[SDT],[DiaChi],[MaLoaiKH]) VALUES (N'KH003',  N'Nguyễn Văn Tuấn',N'087635298',N'435 Âu Cơ',N'GTN001')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH],[SDT],[DiaChi],[MaLoaiKH]) VALUES (N'KH004', N'Trần Thanh Thảo',N'08678234',N'1748/56 CMT8',N'TC001')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH],[SDT],[DiaChi],[MaLoaiKH]) VALUES (N'KH005', N'NGuyễn Thị Mùi',N'0987822341',N'234 Lê Trọng Tấn',N'TC001')

INSERT [dbo].[LOAIKHACHHANG] ([MaLoai], [TenLoai],[MoTa]) VALUES (N'TT001', N'Khách hàng trung thành',N'Luôn luôn mua đồ tại shop thường xuyên')
INSERT [dbo].[LOAIKHACHHANG] ([MaLoai], [TenLoai],[MoTa]) VALUES (N'TN001', N'Khách hàng tiềm năng',N'Lấy hàng với số lượng lớn theo lô hàng')
INSERT [dbo].[LOAIKHACHHANG] ([MaLoai], [TenLoai],[MoTa]) VALUES (N'GTN001', N'Khách hàng giá trị nhỏ',N'Mua lẻ tẻ theo ngày')
INSERT [dbo].[LOAIKHACHHANG] ([MaLoai], [TenLoai],[MoTa]) VALUES (N'TC001', N'Khách hàng tiêu cực',N'Không mua đánh giá shop kém chất lượng')

Set DateForMat DMY
INSERT [dbo].[HOADON] ([MaHD], [MaNV],[MaKH],[ThoiGian]) VALUES (N'HD001', N'NV001',N'KH004',N' 20/10/2021')
INSERT [dbo].[HOADON] ([MaHD], [MaNV],[MaKH],[ThoiGian]) VALUES (N'HD002', N'NV002',N'KH001',N' 02/10/2021')
INSERT [dbo].[HOADON] ([MaHD], [MaNV],[MaKH],[ThoiGian]) VALUES (N'HD003', N'NV003',N'KH003',N' 21/11/2021')
INSERT [dbo].[HOADON] ([MaHD], [MaNV],[MaKH],[ThoiGian]) VALUES (N'HD004', N'NV004',N'KH004',N' 20/10/2020')
INSERT [dbo].[HOADON] ([MaHD], [MaNV],[MaKH],[ThoiGian]) VALUES (N'HD005', N'NV005',N'KH005',N' 24/04/2021')
INSERT [dbo].[HOADON] ([MaHD], [MaNV],[MaKH],[ThoiGian]) VALUES (N'HD006', N'NV006',N'KH002',N' 06/10/2021')
INSERT [dbo].[HOADON] ([MaHD], [MaNV],[MaKH],[ThoiGian]) VALUES (N'HD007', N'NV003',N'KH004',N' 27/12/2021')
INSERT [dbo].[HOADON] ([MaHD], [MaNV],[MaKH],[ThoiGian]) VALUES (N'HD008', N'NV002',N'KH002',N' 07/09/2020')
INSERT [dbo].[HOADON] ([MaHD], [MaNV],[MaKH],[ThoiGian]) VALUES (N'HD009', N'NV003',N'KH001',N' 20/10/2019')

INSERT [dbo].[NGUOIDUNG] ([MaNguoiDung], [TenDangNhap],[MatKhau],[Quyen],[MaNV]) VALUES (N'ND001', N'Admin001',N'1234',N'Quản lý',N'NV001')
INSERT [dbo].[NGUOIDUNG] ([MaNguoiDung], [TenDangNhap],[MatKhau],[Quyen],[MaNV]) VALUES(N'ND002', N'Admin002',N'12345',N'Bán hàng',N'NV003')
INSERT [dbo].[NGUOIDUNG] ([MaNguoiDung], [TenDangNhap],[MatKhau],[Quyen],[MaNV]) VALUES (N'ND003', N'Admin003',N'123',N'Quản lý kinh doanh',N'NV002')
INSERT [dbo].[NGUOIDUNG] ([MaNguoiDung], [TenDangNhap],[MatKhau],[Quyen],[MaNV]) VALUES (N'ND004', N'Admin004',N'1234',N'Quản lý kho hàng',N'NV007')


INSERT [dbo].[CHITIETHOADON] ([MaCTHoaDon], [MaHD],[MaSP],[SoLuong],[DonGia],[GiamGia]) VALUES (N'CTHD001', N'HD001',N'SP001',5,750.000,N'Giảm giá 20%')
INSERT [dbo].[CHITIETHOADON] ([MaCTHoaDon], [MaHD],[MaSP],[SoLuong],[DonGia],[GiamGia]) VALUES (N'CTHD002', N'HD002',N'SP002',2,500.000,N'Giảm giá 25%')
INSERT [dbo].[CHITIETHOADON] ([MaCTHoaDon], [MaHD],[MaSP],[SoLuong],[DonGia],[GiamGia]) VALUES (N'CTHD003', N'HD003',N'SP003',1,150.000,N'Giảm giá 20%')
INSERT [dbo].[CHITIETHOADON] ([MaCTHoaDon], [MaHD],[MaSP],[SoLuong],[DonGia],[GiamGia]) VALUES (N'CTHD004', N'HD004',N'SP004',3,600.000,N'Giảm giá 30%')
INSERT [dbo].[CHITIETHOADON] ([MaCTHoaDon], [MaHD],[MaSP],[SoLuong],[DonGia],[GiamGia]) VALUES (N'CTHD005', N'HD005',N'SP005',5,750.000,N'Giảm giá 20%')

INSERT [dbo].[GIAMGIA] ([MaGiamGia], [MoTa],[TiLeGiam]) VALUES (N'GG001', N'Giảm giá khách trung thành',25)
INSERT [dbo].[GIAMGIA] ([MaGiamGia], [MoTa],[TiLeGiam]) VALUES (N'GG002', N'Giảm giá khách tiềm năng',30)
INSERT [dbo].[GIAMGIA] ([MaGiamGia], [MoTa],[TiLeGiam]) VALUES (N'GG003', N'Giảm giá khách giá trị nhỏ',20)
INSERT [dbo].[GIAMGIA] ([MaGiamGia], [MoTa],[TiLeGiam]) VALUES (N'GG004', N'Khách tiêu cực',5)


INSERT [dbo].[DOITRA] ([MaDoiTra], [MaSP], [MoTa], [SoLuong]) VALUES (N'DT001', N'SP001',N'Giảm giá khách trung thành' ,2)
INSERT [dbo].[DOITRA] ([MaDoiTra], [MaSP], [MoTa], [SoLuong]) VALUES (N'DT002', N'SP002',N'Giảm giá khách tiểm năng' ,1)
INSERT [dbo].[DOITRA] ([MaDoiTra], [MaSP], [MoTa], [SoLuong]) VALUES (N'DT003', N'SP003',N'Giảm giá khách giá trị nhỏ' ,1)
INSERT [dbo].[DOITRA] ([MaDoiTra], [MaSP], [MoTa], [SoLuong]) VALUES (N'DT004', N'SP004',N'Khách tiêu cực' ,3)

INSERT [dbo].[CHITIETDOITRA] ([MaCTDoiTra],[MaDoiTra], [MaSP]) VALUES (N'CTDT001',N'DT001', N'SP001')
INSERT [dbo].[CHITIETDOITRA] ([MaCTDoiTra],[MaDoiTra], [MaSP]) VALUES (N'CTDT002',N'DT002', N'SP002')
INSERT [dbo].[CHITIETDOITRA] ([MaCTDoiTra],[MaDoiTra], [MaSP]) VALUES (N'CTDT003',N'DT003', N'SP003')
INSERT [dbo].[CHITIETDOITRA] ([MaCTDoiTra],[MaDoiTra], [MaSP]) VALUES (N'CTDT004',N'DT004', N'SP004')

ALTER TABLE [dbo].[SANPHAM]
ADD CONSTRAINT [FK_SANPHAM_LOAISANPHAM] FOREIGN KEY (MaLoai) REFERENCES LOAISANPHAM(MaLoai)
ALTER TABLE [dbo].[SANPHAM]
ADD CONSTRAINT [FK_SANPHAM_NHASANXUAT] FOREIGN KEY (MaNSX) REFERENCES NHASANXUAT(MaNSX)
ALTER TABLE [dbo].[SANPHAM]
ADD CONSTRAINT [FK_SANPHAM_ChatLieu] FOREIGN KEY (MaChatLieu) REFERENCES CHATLIEU(MaChatLieu)
ALTER TABLE [dbo].[CHITIETHOADON]
ADD CONSTRAINT [FK_CTHoaDon_SanPham] FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
ALTER TABLE [dbo].[NGUOIDUNG]
ADD CONSTRAINT [FK_NguoiDung_NhanVien] FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
ALTER TABLE [dbo].[HOADON] 
ADD CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
ALTER TABLE [dbo].[HOADON] 
ADD CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
ALTER TABLE [dbo].[KHACHHANG]
ADD CONSTRAINT [FK_KhachHang_LoaiKhach] FOREIGN KEY (MaLoaiKH) REFERENCES LOAIKHACHHANG(MaLoaiKH)
ALTER TABLE [dbo].[DOITRA]
ADD CONSTRAINT [FK_DoiTra_SanPham] FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
ALTER TABLE [dbo].[CHITIETHOADON]
ADD CONSTRAINT [FK_CTHoaDon_GiamGia] FOREIGN KEY (GiamGia) REFERENCES GiamGia(MaGiamGia)
ALTER TABLE [dbo].[CHITIETHOADON]
ADD CONSTRAINT [FK_CTHoaDon_HoaDon] FOREIGN KEY (MaHD) REFERENCES HOADON(MaHD)