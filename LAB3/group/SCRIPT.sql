﻿/*-------------------------------------------------
MSSV: 21120396 - 21120419 - 21120446
HO TEN CAC THANH VIEN NHOM:
							DAO THI NGOC GIAU
							VU THANH CONG
							KIEN DINH MY HANH
LAB: 03 - NHOM
NGAY: 24/04/2024
--------------------------------------------------*/
--CAU LENH TAO DATABASE
CREATE DATABASE QLSVNhom
GO
USE QLSVNhom
GO

/*-------------------------------------------------
MSSV: 21120396 - 21120419 - 21120446
HO TEN CAC THANH VIEN NHOM:
							DAO THI NGOC GIAU
							VU THANH CONG
							KIEN DINH MY HANH
LAB: 03 - NHOM
NGAY: 24/04/2024
--------------------------------------------------*/
--CAC CAU LENH TAO TABLE
USE QLSVNhom
GO

CREATE TABLE NHANVIEN
(
	MANV VARCHAR(20) NOT NULL PRIMARY KEY,
	HOTEN NVARCHAR(100) NOT NULL,
	EMAIL VARCHAR(20),
	LUONG VARBINARY(MAX),
	TENDN NVARCHAR(100) NOT NULL,
	MATKHAU VARBINARY(MAX) NOT NULL,
	PUBKEY VARCHAR(20) NOT NULL
)

CREATE TABLE LOP
(
	MALOP VARCHAR(20) PRIMARY KEY,
	TENLOP NVARCHAR(100) NOT NULL,
	MANV VARCHAR(20),
	FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV)
)

CREATE TABLE SINHVIEN
(
	MASV VARCHAR(20) PRIMARY KEY,
	HOTEN NVARCHAR(100) NOT NULL,
	NGAYSINH DATETIME,
	DIACHI NVARCHAR(200),
	MALOP VARCHAR(20),
	TENDN NVARCHAR(100) NOT NULL,
	MATKHAU VARBINARY(MAX) NOT NULL,
	FOREIGN KEY(MALOP) REFERENCES LOP(MALOP)
)

CREATE TABLE HOCPHAN
(
	MAHP VARCHAR(20) PRIMARY KEY,
	TENHP NVARCHAR(100) NOT NULL,
	SOTC INT
)

CREATE TABLE BANGDIEM
(
	MASV VARCHAR(20),
	MAHP VARCHAR(20),
	DIEMTHI VARBINARY(MAX),
	PRIMARY KEY(MASV, MAHP),
	FOREIGN KEY(MASV) REFERENCES SINHVIEN(MASV),
	FOREIGN KEY(MAHP) REFERENCES HOCPHAN(MAHP)
)

/*-------------------------------------------------
MSSV: 21120396 - 21120419 - 21120446
HO TEN CAC THANH VIEN NHOM:
							DAO THI NGOC GIAU
							VU THANH CONG
							KIEN DINH MY HANH
LAB: 03 - NHOM
NGAY: 24/04/2024
--------------------------------------------------*/
--CAU LENH TAO STORE PROCEDURE

--i)
GO
CREATE PROCEDURE SP_INS_PUBLIC_NHANVIEN @MANV VARCHAR(20), @HOTEN NVARCHAR(100),
										@EMAIL VARCHAR(20), @LUONG INT,
										@TENDN NVARCHAR(100), @MATKHAU VARCHAR(32)

AS  
BEGIN  
	DECLARE @PUBKEY VARCHAR(20)
	SET @PUBKEY = @MANV

	DECLARE @AKEY NVARCHAR(MAX)
	SET @AKEY = 'CREATE ASYMMETRIC KEY '+@MANV+' WITH ALGORITHM = RSA_2048 ENCRYPTION BY PASSWORD = '''+@MATKHAU+''''
	EXEC(@AKEY)
    INSERT INTO NHANVIEN(MANV, HOTEN, EMAIL, LUONG, TENDN, MATKHAU, PUBKEY)
    VALUES (@MANV, @HOTEN, @EMAIL,
			ENCRYPTBYASYMKEY(ASYMKEY_ID(@PUBKEY), CONVERT(VARBINARY(MAX),@LUONG)),
			@TENDN,CONVERT(VARBINARY, HASHBYTES('SHA1', @MATKHAU)),
			@PUBKEY)
END

EXEC SP_INS_PUBLIC_NHANVIEN 'NV04', N'NGUYEN VAN A', 'NVd@', 3000000, 'NV04', 'abcd12'

SELECT* FROM NHANVIEN

--ii)
GO
CREATE PROCEDURE SP_SEL_PUBLIC_NHANVIEN @TENDN NVARCHAR(100),@MATKHAU VARCHAR(100)
AS
BEGIN
	SELECT MANV,HOTEN,EMAIL,
			LUONGCB = CONVERT(INT, DECRYPTBYASYMKEY(ASYMKEY_ID(MANV), LUONG, CONVERT(NVARCHAR, @MATKHAU)))
	FROM NHANVIEN
	WHERE CONVERT(NVARCHAR, @TENDN) = TENDN AND MATKHAU = HASHBYTES('SHA1', @MATKHAU)
END

EXEC SP_SEL_PUBLIC_NHANVIEN 'NV04', 'abcd12'

/*-------------------------------------------------
MSSV: 21120396 - 21120419 - 21120446
HO TEN CAC THANH VIEN NHOM:
							DAO THI NGOC GIAU
							VU THANH CONG
							KIEN DINH MY HANH
LAB: 03 - NHOM
NGAY: 24/04/2024
--------------------------------------------------*/
EXEC SP_INS_PUBLIC_NHANVIEN 'NV01', 'NGUYEN VAN A', 'nva@yahoo.com', 3000000, 'NVA', '123456'
EXEC SP_INS_PUBLIC_NHANVIEN 'NV02', 'NGUYEN VAN B', 'nvb@yahoo.com', 2000000, 'NVB', '1234567'

--nhap cac thong tin lien quan 
insert into LOP(MALOP, TENLOP, MANV)
values	('CNTTA',N'Công nghệ thông tin','NV01'),
('CNTTB',N'Công nghệ thông tin','NV02')
go

insert into SINHVIEN(MASV,HOTEN,NGAYSINH,DIACHI, MALOP, TENDN, MATKHAU)
VALUES	('21120396',N'Đào Thị Ngọc Giàu','1/1/1999',N'HCM','CNTTA','21120396',convert(varbinary,'mk')),
		('21120419',N'Vũ Thành Công','1/1/1999',N'HCM','CNTTB','21120419',convert(varbinary,'mk'))

insert into HOCPHAN(MAHP, TENHP, SOTC)
VALUES	('KTLT', N'Kỹ Thuật Lập Trình',2),
		('CTDL',N'Cấu trúc dữ liệu và giải thuật',4),
		('CSDL',N'Cơ sở dữ liệu',3),
		('KTXLVB',N'Khai thác xử lý văn bản',3),
		('CNTT',N'Công nghệ tri thức',3),
		('TNT',N'Trí tuệ nhân tạo',3),
		('ĐPTTT',N'Độ phức tạp thuật toán',3)
		
go

insert into BANGDIEM(MASV,MAHP,DIEMTHI)
VALUES	('21120396','CTDL',convert(varbinary,10)),
		('21120419','KTLT',convert(varbinary,5))
