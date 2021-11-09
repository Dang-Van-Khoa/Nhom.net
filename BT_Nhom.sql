use master
drop database QLBH

create database QLBH
ON   
( 
	NAME = QLBH_data,  
    FILENAME = 'D:\NEU\SQL\QLBH_data.mdf',  
    SIZE = 10,  
    MAXSIZE = 50,  
    FILEGROWTH = 5 
)  
LOG ON  
( 
	NAME = QLBH_log,  
    FILENAME = 'D:\NEU\SQL\QLBH_log.ldf',  
    SIZE = 5MB,  
    MAXSIZE = 25MB, -- unlimited  
    FILEGROWTH = 5MB 
);  
GO
use QLBH

CREATE TABLE DANGNHAP (
TaiKhoa nchar (10) NOT NULL PRIMARY KEY, 
MatKhau [nvarchar](50) NULL)
-- drop table DANGNHAP


CREATE TABLE NguoiDung (

  Id_NguoiDung char(4) NOT NULL PRIMARY KEY,

  VaiTro bit not null default '0',

  Ten varchar(50) NOT NULL,

  Email varchar(50) NOT NULL,

  DienThoai varchar(15) NOT NULL,

  DiaChi varchar(128) NOT NULL,

  MatKhau varchar(40) NOT NULL,

  NgayTao date NOT NULL,

)
-- drop table NguoiDung


create table Nhacc
(
MaNhacc char(3) not null primary key,
TenNhacc nvarchar(100) not null,
DiaChi nvarchar(200) not null,
DienThoai varchar(10) check (dienthoai like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
)

insert into Nhacc values ('Ao', N'Công ty Áo chất lượng cao', N'123 Hà Nội', '0123456789');
insert into Nhacc values ('Gi', N'Công ty Giày chất lượng cao', N'143 Hà Nội','0445566777');
insert into Nhacc values ('Mu', N'Công ty Mũ chất lượng cao', N'53 Hà Nội', '0333456788');
insert into Nhacc values ('Kh', N'Công ty Khăn chất lượng cao', N'53 Hà Nội', '0338886777');

select * from Nhacc;
-- drop table Nhacc


CREATE TABLE SanPham (

  Id_SanPham char(4) NOT NULL PRIMARY KEY,

  MaNhacc char(3) not null,

  Ten varchar(100) NOT NULL,

  Gia float NOT NULL,

  NoiDung text NOT NULL,

  GiamGia int NOT NULL,

  Anh image NOT NULL,

  NgayTao date NOT NULL,

  LuotXem int NOT NULL DEFAULT '0'

  foreign key (MaNhacc) references Nhacc(MaNhacc),
  
)
-- drop table SanPham


create table DanhMuc(
  Id_SanPham char(4) not null,
  Ten nvarchar(50) not null,
  MoTa char(50) not null
  foreign key (Id_SanPham) references SanPham(Id_SanPham)
)
-- drop table DanhMuc


CREATE TABLE GiaoDich (

  Id_GiaoDich char(4) NOT NULL PRIMARY KEY,

  TrangThai int NOT NULL DEFAULT '0',

  Id_NguoiDung char(4) NOT NULL,

  Ten varchar(50) NOT NULL,

  Email varchar(50) NOT NULL,

  DienThoai varchar(20) NOT NULL,

  TongTien float NOT NULL DEFAULT '0.0000',

  HinhThucTra varchar(32) NOT NULL,

  NgayTao date NOT NULL,

  foreign key (Id_NguoiDung) references NguoiDung(Id_NguoiDung)

)
-- drop table GiaoDich


CREATE TABLE DatHang (

  Id_GiaoDich char(4) NOT NULL,

  Id_NguoiDung char(4) NOT NULL,

  Id_SanPham char(4) NOT NULL,

  SoLuongMua int NOT NULL DEFAULT '0',

  Gia float NOT NULL,

  TongTien as Gia * SoLuongMua,

  TrangThai int NOT NULL DEFAULT '0',

  foreign key (Id_GiaoDich) references GiaoDich(Id_GiaoDich),
  foreign key (Id_NguoiDung) references NguoiDung(Id_NguoiDung),
  foreign key (Id_SanPham) references SanPham(Id_SanPham)
)
-- drop table DatHang


create table TonKho
(
Ngay date not null,
Id_SanPham char(4) not null,
Sldau int not null check(sldau > 0),
Slnhap int not null check(Slnhap > 0),
Slxuat int not null check(Slxuat > 0),
SlCuoi AS SlDau + Slnhap - Slxuat,
foreign key (Id_SanPham) references SanPham(Id_SanPham)
)
-- drop table TonKho

Create Proc ThongTinSP @Ten varchar(100)
as
begin
select Id_SanPham, Ten, Gia, Anh, SanPham.MaNhacc, TenNhacc
from SanPham, Nhacc
where SanPham.Id_SanPham = Nhacc.MaNhacc and @Ten= Ten
end;



DROP PROC ThongTinSP
EXEC ThongTinSP ''

select * from DatHang
