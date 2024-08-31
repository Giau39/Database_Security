﻿create database QLBongDa
go 
use QLBongDa
go

create table QUOCGIA 
(	
    MAQG VARCHAR(5) primary key,
	TENQG NVARCHAR(60) not null
)
create table HUANLUYENVIEN
(
	MAHLV VARCHAR(5) primary key,
	TENHLV NVARCHAR(100) not null,
	NGAYSINH DATETIME,
	DIACHI NVARCHAR(200),
	DIENTHOAI NVARCHAR(20),
	MAQG VARCHAR(5) not null
)

create table SANVD
(
	MASAN  VARCHAR(5) primary key,
	TENSAN NVARCHAR(100) not null,
	DIACHI NVARCHAR(200) 
)

create table TINH
(
	MATINH  VARCHAR(5) primary key,
	TENTINH NVARCHAR(100) not null
)

create table CAULACBO
(
	MACLB VARCHAR(5) primary key,
	TENCLB NVARCHAR(100) not null,
	MASAN VARCHAR(5) not null references SANVD(MASAN),
	MATINH VARCHAR(5) not null references TINH(MATINH),
)

create table HLV_CLB
(
	MAHLV VARCHAR(5) not null references HUANLUYENVIEN(MAHLV),
	MACLB VARCHAR(5) not null references CAULACBO(MACLB) ,
	VAITRO NVARCHAR(100) not null,
)
create table CAUTHU
(
	MACT NUMERIC primary key IDENTITY(1,1) ,
	HOTEN NVARCHAR(100) not null,
	VITRI NVARCHAR(20) not null,
	NGAYSINH DATETIME,
	DIACHI	NVARCHAR(200),
	MACLB VARCHAR(5) not null references CAULACBO(MACLB),
	MAQG VARCHAR(5) not null,
	SO INT not null
)

create table TRANDAU 
(
	MATRAN NUMERIC primary key IDENTITY(1,1) ,
	NAM INT not null,
	VONG INT not null,
	NGAYTD	DATETIME not null,
	MACLB1 VARCHAR(5) not null,
	MACLB2 VARCHAR(5) not null,
	MASAN VARCHAR(5) not null references SANVD(MASAN),
	KETQUA VARCHAR(5) not null,
)

create table BANGXH 
(
	MACLB VARCHAR(5) not null,
	NAM INT not null,
	VONG INT not null,
	SOTRAN INT not null,
	THANG INT not null,
	HOA INT not null,
	THUA INT not null,
	HIEUSO VARCHAR(5) not null,
	DIEM INT not null,
	HANG INT not null,
)

ALTER TABLE BANGXH
ADD CONSTRAINT pk_BANGXH PRIMARY KEY (MACLB, NAM, VONG);
 
ALTER TABLE HLV_CLB
ADD CONSTRAINT pk_HLV_CLB PRIMARY KEY (MAHLV, MACLB);

alter table TRANDAU 
add constraint fk_TRANDAU_CAULACBO1
FOREIGN KEY (MACLB1)
references CAULACBO(MACLB)


alter table TRANDAU 
add constraint fk_TRANDAU_CAULACBO2
FOREIGN KEY (MACLB2)
references CAULACBO(MACLB)



alter table BANGXH
add constraint fk_BANGXH_CAULACBO
FOREIGN KEY (MACLB)
references CAULACBO(MACLB)



alter table HUANLUYENVIEN
add constraint fk_HUANLUYENVIEN_QUOCGIA
FOREIGN KEY (MAQG)
references QUOCGIA(MAQG)


insert into QUOCGIA(MAQG,TENQG) VALUES('VN',N'Việt Nam')
insert into QUOCGIA(MAQG,TENQG) VALUES('ANH',N'Anh Quốc')
insert into QUOCGIA(MAQG,TENQG) VALUES('TBN',N'Tây Ban Nha')
insert into QUOCGIA(MAQG,TENQG) VALUES('BDN',N'Bồ Đào Nha')
insert into QUOCGIA(MAQG,TENQG) VALUES('BRA',N'Brazil')
insert into QUOCGIA(MAQG,TENQG) VALUES('ITA',N'Ý')
insert into QUOCGIA(MAQG,TENQG) VALUES('THA',N'Thái Lan')


insert into HUANLUYENVIEN(MAHLV,TENHLV,NGAYSINH,DIACHI,DIENTHOAI,MAQG) VALUES('HLV01',N'Vital','10-15-1955',NULL,'0918011075','BDN')
insert into HUANLUYENVIEN(MAHLV,TENHLV,NGAYSINH,DIACHI,DIENTHOAI,MAQG) VALUES('HLV02',N'Lê Huỳnh Đức','05-20-1972',NULL,'01223456789','VN')
insert into HUANLUYENVIEN(MAHLV,TENHLV,NGAYSINH,DIACHI,DIENTHOAI,MAQG) VALUES('HLV03',N'Kiatisuk','12-11-1970',NULL,'01990123456','THA')
insert into HUANLUYENVIEN(MAHLV,TENHLV,NGAYSINH,DIACHI,DIENTHOAI,MAQG) VALUES('HLV04',N'Hoàng Anh Tuấn','06-10-1970',NULL,'0989112233','VN')
insert into HUANLUYENVIEN(MAHLV,TENHLV,NGAYSINH,DIACHI,DIENTHOAI,MAQG) VALUES('HLV05',N'Trần Công Minh','07-07-1973',NULL,'0909099990','VN')
insert into HUANLUYENVIEN(MAHLV,TENHLV,NGAYSINH,DIACHI,DIENTHOAI,MAQG) VALUES('HLV06',N'Trần Văn Phúc','03-02-1965',NULL,'01650101234','VN')


insert into SANVD(MASAN,TENSAN,DIACHI) VALUES('GD',N'Gò Đậu', N'123 QL1, TX Thủ Dầu Một, Bình Dương')
insert into SANVD(MASAN,TENSAN,DIACHI) VALUES('PL',N'Pleiku', N'22 Hồ Tùng Mậu, Thống Nhất, Thị xã Pleiku, Gia Lai')
insert into SANVD(MASAN,TENSAN,DIACHI) VALUES('CL',N'Chi Lăng', N'127 Võ Văn Tần, Đà Nắng')
insert into SANVD(MASAN,TENSAN,DIACHI) VALUES('NT',N'Nha Trang', N'128 Phan Chu Trinh, Nha Trang, Khánh Hòa')
insert into SANVD(MASAN,TENSAN,DIACHI) VALUES('TH',N'Tuy Hòa', N'57 Trường Chinh, Tuy Hòa, Phú Yên')
insert into SANVD(MASAN,TENSAN,DIACHI) VALUES('LA',N'Long An', N'102 Hùng Vương, Tp Tân An, Long An')

insert into TINH(MATINH,TENTINH) VALUES ('BD',N'Bình Dương')
insert into TINH(MATINH,TENTINH) VALUES ('GL',N'Gia Lai')
insert into TINH(MATINH,TENTINH) VALUES ('DN',N'Đà Nẵng')
insert into TINH(MATINH,TENTINH) VALUES ('KH',N'Khánh Hòa')
insert into TINH(MATINH,TENTINH) VALUES ('PY',N'Phú Yên')
insert into TINH(MATINH,TENTINH) VALUES ('LA',N'Long An')

insert into CAULACBO(MACLB,TENCLB,MASAN,MATINH) VALUES('BBD',N'BECAMEX BÌNH DƯƠNG','GD','BD')
insert into CAULACBO(MACLB,TENCLB,MASAN,MATINH) VALUES('HAGL',N'HOÀNG ANH GIA LAI','PL','GL')
insert into CAULACBO(MACLB,TENCLB,MASAN,MATINH) VALUES('SDN',N'SHB ĐÀ NẴNG','CL','DN')
insert into CAULACBO(MACLB,TENCLB,MASAN,MATINH) VALUES('KKH',N'KHATOCO KHÁNH HÒA','NT','KH')
insert into CAULACBO(MACLB,TENCLB,MASAN,MATINH) VALUES('TPY',N'THÉP PHÚ YÊN','TH','PY')
insert into CAULACBO(MACLB,TENCLB,MASAN,MATINH) VALUES('GDT',N'GẠCH ĐỒNG TÂM LONG AN','LA','LA')

insert into HLV_CLB(MAHLV,MACLB,VAITRO) VALUES('HLV01','BBD','HLV Chính')
insert into HLV_CLB(MAHLV,MACLB,VAITRO) VALUES('HLV02','SDN','HLV Chính')
insert into HLV_CLB(MAHLV,MACLB,VAITRO) VALUES('HLV03','HAGL','HLV Chính')
insert into HLV_CLB(MAHLV,MACLB,VAITRO) VALUES('HLV04','KKH','HLV Chính')
insert into HLV_CLB(MAHLV,MACLB,VAITRO) VALUES('HLV05','GDT','HLV Chính')
insert into HLV_CLB(MAHLV,MACLB,VAITRO) VALUES('HLV06','BBD','HLV thủ môn')


insert into CAUTHU(HOTEN,VITRI,NGAYSINH,DIACHI,MACLB,MAQG,SO) values(N'Nguyễn Vũ Phong',N'Tiền vệ','02-20-1990',NULL,'BBD','VN',17)
insert into CAUTHU(HOTEN,VITRI,NGAYSINH,DIACHI,MACLB,MAQG,SO) values(N'Nguyễn Công Vinh',N'Tiền đạo','03-10-1992',NULL,'HAGL','VN',9)
insert into CAUTHU(HOTEN,VITRI,NGAYSINH,DIACHI,MACLB,MAQG,SO) values(N'Trần Tấn Tài',N'Tiền vệ','11-12-1989',NULL,'BBD','VN',8)
insert into CAUTHU(HOTEN,VITRI,NGAYSINH,DIACHI,MACLB,MAQG,SO) values(N'Phạm Hồng Sơn',N'Thủ môn','06-10-1991',NULL,'HAGL','VN',1)
insert into CAUTHU(HOTEN,VITRI,NGAYSINH,DIACHI,MACLB,MAQG,SO) values(N'Ronaldo',N'Tiền vệ','12-12-1989',NULL,'SDN','BRA',7)
insert into CAUTHU(HOTEN,VITRI,NGAYSINH,DIACHI,MACLB,MAQG,SO) values(N'Robinho',N'Tiền vệ','10-12-1989',NULL,'SDN','BRA',8)
insert into CAUTHU(HOTEN,VITRI,NGAYSINH,DIACHI,MACLB,MAQG,SO) values(N'Vidic',N'Hậu vệ','10-15-1987',NULL,'HAGL','ANH',3)
insert into CAUTHU(HOTEN,VITRI,NGAYSINH,DIACHI,MACLB,MAQG,SO) values(N'Trần Văn Santos',N'Thủ môn','10-21-1990',NULL,'BBD','BRA',1)




insert into TRANDAU(NAM,VONG,NGAYTD,MACLB1,MACLB2,MASAN,KETQUA) values(2009, 1,'2-7-2009','BBD','SDN','GD','3-0')
insert into TRANDAU(NAM,VONG,NGAYTD,MACLB1,MACLB2,MASAN,KETQUA) values(2009, 1,'2-7-2009','KKH','GDT','NT','1-1')
insert into TRANDAU(NAM,VONG,NGAYTD,MACLB1,MACLB2,MASAN,KETQUA) values(2009, 2,'2-16-2009','SDN','KKH','CL','2-2')
insert into TRANDAU(NAM,VONG,NGAYTD,MACLB1,MACLB2,MASAN,KETQUA) values(2009, 2,'2-16-2009','TPY','BBD','TH','5-0')
insert into TRANDAU(NAM,VONG,NGAYTD,MACLB1,MACLB2,MASAN,KETQUA) values(2009, 3,'3-1-2009','TPY','GDT','TH','0-2')
insert into TRANDAU(NAM,VONG,NGAYTD,MACLB1,MACLB2,MASAN,KETQUA) values(2009, 3,'3-1-2009','KKH','BBD','NT','0-1')
insert into TRANDAU(NAM,VONG,NGAYTD,MACLB1,MACLB2,MASAN,KETQUA) values(2009, 4 ,'3-7-2009','KKH','TPY','NT','1-0')
insert into TRANDAU(NAM,VONG,NGAYTD,MACLB1,MACLB2,MASAN,KETQUA) values(2009, 4,'3-7-2009','BBD','GDT','GD','2-2')



insert into BANGXH(MACLB,NAM,VONG,SOTRAN,THANG,HOA,THUA,HIEUSO,DIEM,HANG) values('BBD',2009,1,1,1,0,0,'3-0',3,1)
insert into BANGXH(MACLB,NAM,VONG,SOTRAN,THANG,HOA,THUA,HIEUSO,DIEM,HANG) values('KKH',2009,1,1,0,1,0,'1-1',1,2)
insert into BANGXH(MACLB,NAM,VONG,SOTRAN,THANG,HOA,THUA,HIEUSO,DIEM,HANG) values('GDT',2009,1,1,0,1,0,'1-1',1,3)
insert into BANGXH(MACLB,NAM,VONG,SOTRAN,THANG,HOA,THUA,HIEUSO,DIEM,HANG) values('TPY',2009,1,0,0,0,0,'0-0',0,4)
insert into BANGXH(MACLB,NAM,VONG,SOTRAN,THANG,HOA,THUA,HIEUSO,DIEM,HANG) values('SDN',2009,1,1,0,0,1,'0-3',0,5)
insert into BANGXH(MACLB,NAM,VONG,SOTRAN,THANG,HOA,THUA,HIEUSO,DIEM,HANG) values('TPY',2009,2,1,1,0,0,'5-0',3,1)
insert into BANGXH(MACLB,NAM,VONG,SOTRAN,THANG,HOA,THUA,HIEUSO,DIEM,HANG) values('BBD',2009,2,2,1,0,1,'3-5',3,2)
insert into BANGXH(MACLB,NAM,VONG,SOTRAN,THANG,HOA,THUA,HIEUSO,DIEM,HANG) values('KKH',2009,2,2,0,2,0,'3-3',2,3)
insert into BANGXH(MACLB,NAM,VONG,SOTRAN,THANG,HOA,THUA,HIEUSO,DIEM,HANG) values('GDT',2009,2,1,0,1,0,'1-1',1,4)
insert into BANGXH(MACLB,NAM,VONG,SOTRAN,THANG,HOA,THUA,HIEUSO,DIEM,HANG) values('SDN',2009,2,2,1,1,0,'2-5',1,5)
insert into BANGXH(MACLB,NAM,VONG,SOTRAN,THANG,HOA,THUA,HIEUSO,DIEM,HANG) values('BBD',2009,3,3,2,0,1,'4-5',6,1)
insert into BANGXH(MACLB,NAM,VONG,SOTRAN,THANG,HOA,THUA,HIEUSO,DIEM,HANG) values('GDT',2009,3,2,1,1,0,'3-1',4,2)
insert into BANGXH(MACLB,NAM,VONG,SOTRAN,THANG,HOA,THUA,HIEUSO,DIEM,HANG) values('TPY',2009,3,2,1,0,1,'5-2',3,3)
insert into BANGXH(MACLB,NAM,VONG,SOTRAN,THANG,HOA,THUA,HIEUSO,DIEM,HANG) values('KKH',2009,3,3,0,2,1,'3-4',2,4)
insert into BANGXH(MACLB,NAM,VONG,SOTRAN,THANG,HOA,THUA,HIEUSO,DIEM,HANG) values('SDN',2009,3,2,1,1,0,'2-5',1,5)
insert into BANGXH(MACLB,NAM,VONG,SOTRAN,THANG,HOA,THUA,HIEUSO,DIEM,HANG) values('BBD',2009,4,4,2,1,1,'6-7',7,1)
insert into BANGXH(MACLB,NAM,VONG,SOTRAN,THANG,HOA,THUA,HIEUSO,DIEM,HANG) values('GDT',2009,4,3,1,2,0,'5-1',5,2)
insert into BANGXH(MACLB,NAM,VONG,SOTRAN,THANG,HOA,THUA,HIEUSO,DIEM,HANG) values('KKH',2009,4,4,1,2,1,'4-4',5,3)
insert into BANGXH(MACLB,NAM,VONG,SOTRAN,THANG,HOA,THUA,HIEUSO,DIEM,HANG) values('TPY',2009,4,3,1,0,2,'5-3',3,4)
insert into BANGXH(MACLB,NAM,VONG,SOTRAN,THANG,HOA,THUA,HIEUSO,DIEM,HANG) values('SDN',2009,4,2,1,1,0,'2-5',1,5)