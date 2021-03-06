-- Created by Vertabelo (http://vertabelo.com)
-- Last modification date: 2015-06-11 08:14:55.999




-- tables
-- Table: ChiTietHoaDon
CREATE TABLE ChiTietHoaDon (
    SoLuong int  NOT NULL,
    MaCTHD int  NOT NULL,
    HoaDon_MaHoaDon nvarchar(30)  NOT NULL,
    SanPham_MaSP nvarchar(30)  NOT NULL,
    CONSTRAINT ChiTietHoaDon_pk PRIMARY KEY (MaCTHD)
)
;





-- Table: HoaDon
CREATE TABLE HoaDon (
    MaHoaDon nvarchar(30)  NOT NULL,
    tongtien int  NOT NULL,
    NgayLap datetime  NOT NULL,
    KhachHang_MaKhachHang nvarchar(30)  NOT NULL,
    CONSTRAINT HoaDon_pk PRIMARY KEY (MaHoaDon)
)
;





-- Table: KhachHang
CREATE TABLE KhachHang (
    MaKhachHang nvarchar(30)  NOT NULL,
    TenKhachHang nvarchar(50)  NOT NULL,
    SoDT int  NOT NULL,
    DiaChi nvarchar(30)  NOT NULL,
    CONSTRAINT KhachHang_pk PRIMARY KEY (MaKhachHang)
)
;








-- Table: LoaiSanPham
CREATE TABLE LoaiSanPham (
    MaLoai nvarchar(30)  NOT NULL,
    TenLoai nvarchar(50)  NOT NULL,
    CONSTRAINT LoaiSanPham_pk PRIMARY KEY (MaLoai)
)
;





-- Table: NhanVien
CREATE TABLE NhanVien (
    MaNhanVien nvarchar(20)  NOT NULL,
    password nvarchar(20)  NOT NULL,
    TenNhanVien nvarchar(50)  NOT NULL,
    HoaDon_MaHoaDon nvarchar(30)  NOT NULL,
    CONSTRAINT NhanVien_pk PRIMARY KEY (MaNhanVien)
)
;





-- Table: SanPham
CREATE TABLE SanPham (
    MaSP nvarchar(30)  NOT NULL,
    TenSP nvarchar(50)  NOT NULL,
    DonGia int  NOT NULL,
    SoLuong int  NOT NULL,
    ChiTietSP nvarchar(50)  NOT NULL,
    LoaiSanPham_MaLoai nvarchar(30)  NOT NULL,
    CONSTRAINT SanPham_pk PRIMARY KEY (MaSP)
)
;









-- foreign keys
-- Reference:  ChiTietHoaDon_HoaDon (table: ChiTietHoaDon)


ALTER TABLE ChiTietHoaDon ADD CONSTRAINT ChiTietHoaDon_HoaDon 
    FOREIGN KEY (HoaDon_MaHoaDon)
    REFERENCES HoaDon (MaHoaDon)
;

-- Reference:  ChiTietHoaDon_SanPham (table: ChiTietHoaDon)


ALTER TABLE ChiTietHoaDon ADD CONSTRAINT ChiTietHoaDon_SanPham 
    FOREIGN KEY (SanPham_MaSP)
    REFERENCES SanPham (MaSP)
;

-- Reference:  HoaDon_KhachHang (table: HoaDon)


ALTER TABLE HoaDon ADD CONSTRAINT HoaDon_KhachHang 
    FOREIGN KEY (KhachHang_MaKhachHang)
    REFERENCES KhachHang (MaKhachHang)
;

-- Reference:  NhanVien_HoaDon (table: NhanVien)


ALTER TABLE NhanVien ADD CONSTRAINT NhanVien_HoaDon 
    FOREIGN KEY (HoaDon_MaHoaDon)
    REFERENCES HoaDon (MaHoaDon)
;

-- Reference:  SanPham_LoaiSanPham (table: SanPham)


ALTER TABLE SanPham ADD CONSTRAINT SanPham_LoaiSanPham 
    FOREIGN KEY (LoaiSanPham_MaLoai)
    REFERENCES LoaiSanPham (MaLoai)
;





-- End of file.
-- bang khach hang
insert into  dbo.KhachHang
values(N'KH1',N'lê anh tiến',01265204970,N'quận 3')
insert into  dbo.KhachHang
values(N'KH2',N'châu tấn bảo',0908336444,N'quận 2')
insert into  dbo.KhachHang
values(N'KH3',N'lầu ngọc phi',01265204970,N'quận 5')
insert into  dbo.KhachHang
values(N'KH4',N'trần như trí',01267685970,N'quận 7')
insert into  dbo.KhachHang
values(N'KH5',N'võ văn khôi',0124683370,N'quận 1')
--bang loai san pham
insert into  dbo.LoaiSanPham
values(N'SP1',N'Điện thoại')
insert into  dbo.LoaiSanPham
values(N'SP2',N'laptop')
insert into  dbo.LoaiSanPham
values(N'SP3',N'máy vi tính')
insert into  dbo.LoaiSanPham
values(N'SP4',N'Tay nghe')
insert into  dbo.LoaiSanPham
values(N'SP5',N'USB')

--bang san pham

insert into SanPham values('DT1',N'Nokia',30000000,2,N'sản phẩm cấp cao',N'SP1')
insert into SanPham values('TN1',N'taynghe Tako TA71',10000000,4,N'Tai nghe thời trang, jack cắm thiết bị âm nhạc','SP4')
insert into SanPham values('MVT1',N'AcerX2631G',80000000,10,N'máy vi tính giá rẻ chất lượng cao','SP3')
insert into SanPham values('MVT2',N'ECSLIVAX',40000000,5,N'Máy tính siêu nhỏ','SP3')
insert into SanPham values('USB',N'USB 3.0Kingston',30000000,2,N'Bh 2 năm','SP5')
--bang hoa don
insert into dbo.HoaDon values('MHD1',10050000,'11-11-2014',N'KH1')
insert into dbo.HoaDon values('MHD2',20050000,'1-12-2014',N'KH1')
insert into dbo.HoaDon values('MHD3',30050000,'5-3-2015',N'KH3')
insert into dbo.HoaDon values('MHD4',40050000,'11-23-2014',N'KH2')
insert into dbo.HoaDon values('MHD5',50050000,'5-20-2015',N'KH5')

--bang chi tiet hoa don
insert into ChiTietHoaDon values(3,100,'MHD1','DT1')
insert into ChiTietHoaDon values(11,200,'MHD3','DT1')
insert into ChiTietHoaDon values(4,300,'MHD4','TN1')
insert into ChiTietHoaDon values(20,400,'MHD1','TN1')
insert into ChiTietHoaDon values(10,500,'MHD2','USB')

--bang nhan vien

insert into NhanVien values('NV1',N'NV1',N'Hồ Ngọc Hoài Vũ','MHD1')
insert into NhanVien values('NV2',N'NV2',N'Châu Hoàn Vũ','MHD2')
insert into NhanVien values('NV3',N'NV3',N'Đặng Mạnh Linh','MHD2')
insert into NhanVien values('NV4',N'NV4',N'Nguyễn Tăng Duy Quang','MHD4')
insert into NhanVien values('NV5',N'NV5',N'Trịnh Nguyễn thái Tài','MHD5')


