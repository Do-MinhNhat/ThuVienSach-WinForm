create database ThuVienSach
go
use ThuVienSach
go
create table ChucVu(
MaCV int not null IDENTITY,
TenCV nvarchar(20) not null,
TrangThai bit not null,
primary key (MaCV)
)
create table NhanVien
(
MaNV int not null IDENTITY,
MaCV int not null,
TenNV nvarchar(50) not null,
GioiTinh nvarchar(3) not null,
DChi nvarchar(100) not null,
SDT varchar(10) not null,
TrangThai bit not null,
NgaySinh date not null,
Luong float not null,
UserName varchar(30) not null,
PassWord varchar(30)  not null,
primary key (MaNV),
Foreign key (MaCV) references ChucVu(MaCV)
)
create table KhachHang
(
MaKH int not null IDENTITY,
TenKH nvarchar(50) not null,
DChi nvarchar(100) not null,
SDT varchar(10) not null,
Email varchar(50),
TrangThai bit not null,
NgayLapThe date not null,
NgaySinh date not null,
GioiTinh nvarchar(3) not null,
primary key (MaKH),
)
create table HoaDon
(
MaHD int not null IDENTITY,
MaNV int,
MaKH int,
NgayLap date,
TongTien float,
TrangThai bit,
primary key (MaHD),
Foreign key (MaNV) references NhanVien(MaNV),
Foreign key (MaKH) references KhachHang(MaKH)
)
create table TheLoaiSach
(
MaTL int not null IDENTITY,
TenTL nvarchar(30) not null,
TrangThai bit not null
primary key (MaTL)
)
create table TacGia
(
MaTG int not null IDENTITY,
TenTG nvarchar(50) not null,
TrangThai bit not null
primary key (MaTG)
)
create table NCC
(
MaNCC int not null IDENTITY,
TenNCC nvarchar(50) not null,
DChi nvarchar(100) not null,
SDT varchar(10) not null,
TrangThai bit not null,
primary key(MaNCC)
)
create table Sach
(
MaSach int not null IDENTITY,
TenSach nvarchar(100) not null,
MaTL int not null,
MaTG int not null,
MaNCC int not null,
NhaXB nvarchar(50) not null,
GiaNhap float not null,
SoLuong int not null,
MoTa nvarchar(max) not null,
HinhAnh varchar(50) not null,
TrangThai bit not null,
primary key (MaSach),
Foreign key (MaTG) references TacGia(MaTG),
Foreign key (MaTL) references TheLoaiSach(MaTL),
Foreign key (MaNCC) references NCC(MaNCC)
)
create table CTHoaDon
(
MaHD int not null,
MaSach int not null,
SoLuong int not null,
DonGia float not null,
TrangThai bit not null,
primary key (MaHD,MaSach),
Foreign key (MaHD) references HoaDon(MaHD),
Foreign key (MaSach) references Sach(MaSach)
)
create table LoaiHD
(
MaLHD int not null,
TenLHD nvarchar(30) not null,
primary key (MaLHD)
)
create table LHD_HoaDon
(
MaLHD int not null,
MaHD int not null,
NgayMuon date,
HanTra date,
NgayTra date,
PhiTraMuon float,
primary key (MaHD,MaLHD),
Foreign key (MaHD) references HoaDon(MaHD),
Foreign key (MaLHD) references LoaiHD(MaLHD)
)
create table HDNhapSach
(
MaNS int not null IDENTITY,
MaSach int not null,
MaNCC int not null,
NgayLap date not null,
SoLuong int not null,
DonGia float not null,
TongTien float not null,
Primary key (MaNS),
Foreign key (MaSach) references Sach(MaSach),
Foreign key (MaNCC) references NCC(MaNCC)
)

insert into ChucVu values (N'Quản lý',1)
insert into ChucVu values (N'Nhân viên',1)
insert into ChucVu values (N'Không có',1)

insert into LoaiHD values (1,N'Mua')
insert into LoaiHD values (2,N'Mượn')

insert into NhanVien Values (1,N'Nhật',N'Nam',N'Đồng nai','0362689284',1,'6-19-2005','10000000','nhat','123')


SET IDENTITY_INSERT HoaDon ON
insert into HoaDon(MaHD) Values (0)
SET IDENTITY_INSERT HoaDon OFF

SET IDENTITY_INSERT KhachHang ON
INSERT INTO KhachHang (MaKH, TenKH, DChi, SDT, Email, TrangThai, NgayLapThe, NgaySinh, GioiTinh) Values (0,N'Khách vãng lai',1,1,1,1,'1/1/1','1/1/1',1)
SET IDENTITY_INSERT KhachHang OFF
