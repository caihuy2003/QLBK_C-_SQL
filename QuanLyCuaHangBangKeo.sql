use master
create database QLBangKeo
go
use QLBangKeo

/*==============================================================*/
/* Table: KHACHHANG                                             */
/*==============================================================*/
create table KHACHHANG (
   MaKH                 char(10)     not null,
   TenKH                nvarchar(50)      not null,
   DiaChiKH             nvarchar(150)     not null,
   SDT_KH               varchar(10)       not null,
   GioiTinhKH           nvarchar(5)        not null,
   constraint PK_KHACHHANG primary key nonclustered (MaKH)
)
/*==============================================================*/
/* Table: NHANVIEN                                              */
/*==============================================================*/
create table NHANVIEN (
   MaNV                 char(10)     not null,
   TenNV                nvarchar(50)      not null,
   DiaChiNV             nvarchar(150)     not null,
   SDT_NV               varchar(10)       not null,
   ChucVu               nvarchar(50)          null,
   NgayVaoLam           datetime             null,
   GioiTinh             nvarchar(5)       not null,
   MatKhau              char(16)          null,
   constraint PK_NHANVIEN primary key nonclustered (MaNV)
)
/*==============================================================*/
/* Table: NHACUNGCAP                                            */
/*==============================================================*/
create table NHACUNGCAP (
   MaNCC                char(10)     not null,
   TenNCC               nvarchar(50)      not null,
   DiaChiNCC            varchar(150)      not null,
   SDTNCC               varchar(10)       not null,
   constraint PK_NHACUNGCAP primary key nonclustered (MaNCC)
)
/*==============================================================*/
/* Table: SANPHAM                                               */
/*==============================================================*/
create table SANPHAM (
   MaSP                 char(10)        not null,
   MaNCC                char(10)          not null,
   MaLSP                char(10)          not null,
   TenSP                nvarchar(50)      not null,
   SoLuongSP            int                  null,
   HinhAnh              image                null,
   DonGiaNhap           decimal(18,2)        null,
   DonGiaBan            decimal(18,2)        null,
   constraint PK_SANPHAM primary key nonclustered (MaSP),
   constraint FK_SANPHAM_CUNGCAP_NHACUNGC foreign key (MaNCC)
      references NHACUNGCAP (MaNCC),
)
create index ThuocLoaiSanPham_FK on SANPHAM (
MaLSP ASC
)
create index CungCap_FK on SANPHAM (
MaNCC ASC
)
/*==============================================================*/
/* Table: LOAISANPHAM                                           */
/*==============================================================*/
create table LOAISANPHAM (
   MaLSP                char(10)        not null,
   TenLSP               nvarchar(50)     not null,
   MoTa                 nvarchar(150)         null,
   constraint PK_LOAISANPHAM primary key nonclustered (MaLSP)
)
/*==============================================================*/
/* Table: HOADONBANHANG                                         */
/*==============================================================*/
create table HOADONBANHANG (
   MaHDB                char(10)     not null,
   MaNV                 char(10)          not null,
   MaKH                 char(10)          not null,
   NgayXuatHDB          datetime             null,
   TongTienBan          decimal(18,2)                  null,
   ChiPhiKhac           decimal(18,2)                  null,
   constraint PK_HOADONBANHANG primary key nonclustered (MaHDB),
   constraint FK_HOADONBA_LAP_NHANVIEN foreign key (MaNV)
      references NHANVIEN (MaNV),
	constraint FK_HOADONBA_NHAN_KHACHHAN foreign key (MaKH)
      references KHACHHANG (MaKH)
)
create index Lap_FK on HOADONBANHANG (
MaNV ASC
)
create index Nhan_FK on HOADONBANHANG (
MaKH ASC
)
/*==============================================================*/
/* Table: HOADONNHAPHANG                                        */
/*==============================================================*/
create table HOADONNHAPHANG (
   MaHDN                char(10)      not null,
   MaNV                 char(10)          not null,
   NgayXuatHDN          datetime             null,
   TongTienNhap         decimal(18,2)                  null,
   constraint PK_HOADONNHAPHANG primary key nonclustered (MaHDN),
   constraint FK_HOADONNH_XUAT_NHANVIEN foreign key (MaNV)
      references NHANVIEN (MaNV)
)
create index Xuat_FK on HOADONNHAPHANG (
MaNV ASC
)
/*==============================================================*/
/* Table: ChiTietHDB                                            */
/*==============================================================*/
create table ChiTietHDB (
   MaSP                 char(10)      not null,
   MaHDB                char(10)          not null,
   SLBan                int                  null,
   GiaBan               decimal(18,2)        null,
   MaNVBan              int          null,
   GiamGia              float             null,
   ThanhTien            decimal(18,2)     null,
   constraint PK_CHITIETHDB primary key (MaSP, MaHDB),
   constraint FK_CHITIETH_CHITIETHD_SANPHAM foreign key (MaSP)
      references SANPHAM (MaSP),
	constraint FK_CHITIETH_CHITIETHD_HOADONBA foreign key (MaHDB)
      references HOADONBANHANG (MaHDB)
)
create index ChiTietHDB_FK on ChiTietHDB (
MaSP ASC
)
create index ChiTietHDB2_FK on ChiTietHDB (
MaHDB ASC
)
/*==============================================================*/
/* Table: ChiTietNhap                                           */
/*==============================================================*/
create table ChiTietNhap (
   MaSP                 char(10)     not null,
   MaHDN                char(10)          not null,
   SLNhap               int                  null,
   GiaNhap              decimal(18,2)        null,
   ThanhTien            decimal(18,2)     null,
   constraint PK_CHITIETNHAP primary key (MaSP, MaHDN),
   constraint FK_CHITIETN_CHITIETNH_SANPHAM foreign key (MaSP)
      references SANPHAM (MaSP),
	constraint FK_CHITIETN_CHITIETNH_HOADONNH foreign key (MaHDN)
      references HOADONNHAPHANG (MaHDN)
)
create index ChiTietNhap_FK on ChiTietNhap (
MaSP ASC
)
create index ChiTietNhap2_FK on ChiTietNhap (
MaHDN ASC
)

alter table SANPHAM
   add constraint FK_SANPHAM_THUOCLOAI_SANPHAM foreign key (MaLSP)
      references LOAISANPHAM (MaLSP)

alter table SANPHAM add DVT nvarchar(20)

alter table SANPHAM alter column DonGiaNhap int
alter table SANPHAM alter column DonGiaBan int

alter table NHANVIEN add NgaySinh date
alter table NHANVIEN alter column NgayVaoLam date

alter table CHITIETHDB drop column MaNVBan
alter table HOADONBANHANG drop column ChiPhiKhac
alter table HOADONBANHANG alter column NgayXuatHDB date
alter table HOADONBANHANG alter column TongTienBan int
alter table CHITIETHDB alter column GiaBan int
alter table CHITIETHDB alter column ThanhTien int 

alter table CHITIETNHAP add TenSP nvarchar(50)
alter table HOADONNHAPHANG alter column TongTienNhap int
alter table CHITIETNHAP alter column GiaNhap int
alter table CHITIETNHAP alter column ThanhTien int 

CREATE PROCEDURE GetHoaDonBanHangByMonth
	@Thang int,
	@Nam int
AS
	SELECT MaHDB,MaNV,MaKH,NgayXuatHDB,TongTienBan
	FROM [dbo].[HOADONBANHANG]
	WHERE Month(NgayXuatHDB) = @Thang and YEAR(NgayXuatHDB)=@Nam

CREATE PROCEDURE GetHoaDonBanHangByDay
	@Ngay datetime
AS
	SELECT MaHDB,MaNV,MaKH,NgayXuatHDB,TongTienBan
	FROM [dbo].[HOADONBANHANG]
	WHERE NgayXuatHDB=@Ngay

CREATE PROCEDURE GetHoaDonBanHangByYear
	@Nam int
AS
	SELECT MaHDB,MaNV,MaKH,NgayXuatHDB,TongTienBan
	FROM [dbo].[HOADONBANHANG]
	WHERE YEAR(NgayXuatHDB)=@Nam

CREATE PROCEDURE GetHoaDonNhapHangByMonth
	@Thang int,
	@Nam int
AS
	SELECT MaHDN,MaNV,NgayXuatHDN,TongTienNhap
	FROM [dbo].[HOADONNHAPHANG]
	WHERE Month(NgayXuatHDN) = @Thang and YEAR(NgayXuatHDN)=@Nam

CREATE PROCEDURE GetHoaDonNhapHangByDay
	@Ngay datetime
AS
	SELECT MaHDN,MaNV,NgayXuatHDN,TongTienNhap
	FROM [dbo].[HOADONNHAPHANG]
	WHERE NgayXuatHDN=@Ngay

CREATE PROCEDURE GetHoaDonNhapHangByYear
	@Nam int
AS
	SELECT MaHDN,MaNV,NgayXuatHDN,TongTienNhap
	FROM [dbo].[HOADONNHAPHANG]
	WHERE YEAR(NgayXuatHDN)=@Nam

exec [dbo].[GetHoaDonNhapHangByMonth] 4,2024
CREATE PROCEDURE GetHoaDonBanHangByTotalAmountRange
    @MinTotalMoney int,
    @MaxTotalMoney int
AS
BEGIN
    SELECT MaHDB, MaNV, MaKH, NgayXuatHDB, TongTienBan
    FROM HOADONBANHANG
    WHERE TongTienBan BETWEEN @MinTotalMoney AND @MaxTotalMoney
END
CREATE PROCEDURE GetHoaDonNhapHangByTotalAmountRange
    @MinTotalMoney int,
    @MaxTotalMoney int
AS
BEGIN
    SELECT MaHDN, MaNV, NgayXuatHDN, TongTienNhap
    FROM HOADONNHAPHANG
    WHERE TongTienNhap BETWEEN @MinTotalMoney AND @MaxTotalMoney
END