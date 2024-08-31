

/*----------------------------------------------------------
MASV: 21120396
HO TEN: Dao Thi Ngoc Giau
LAB: 04
NGAY: 30/5/2024
----------------------------------------------------------*/
-- CAU LENH TAO STORED PROCEDURE


use QLSV
go

create procedure SP_INS_ENCRYPT_SINHVIEN
@masv NVARCHAR(20), @hoten NVARCHAR(100), @ngaysinh DATETIME, @diachi NVARCHAR(200), @malop VARCHAR(20), @tendn NVARCHAR(100), @matkhau VARBINARY(MAX)
as
	insert SINHVIEN(MASV, HOTEN, NGAYSINH, DIACHI, MALOP, TENDN, MATKHAU)
	values(@masv, @hoten,@ngaysinh,@diachi,@malop,@tendn, @matkhau)
go

--DROP PROCEDURE SP_INS_ENCRYPT_SINHVIEN

select * from sinhvien

--delete sinhvien

--------------------------------------------------------------------------

create procedure SP_INS_ENCRYPT_NHANVIEN
@MANV VARCHAR(20),@HOTEN NVARCHAR(100),@EMAIL VARCHAR(20),@LUONG VARBINARY(MAX),@TENDN NVARCHAR(100),@MATKHAU VARBINARY(MAX)
as
	insert nhanvien(MANV, HOTEN, EMAIL, LUONG, TENDN, MATKHAU)
	values(@MANV, @HOTEN, @EMAIL, @LUONG, @TENDN, @MATKHAU)
go

EXEC SP_INS_ENCRYPT_NHANVIEN 'NV04', 'NGUYEN VAN A', 'NVA@', 0x004C85D612A8A04AA6DD6C8DAB58673C02000000D508161EFB17FBEAC977451BC813C116B55E53511BD8B08B00107489DD3EC0C9, 'NVA', 0x7C4A8D09CA3762AF61E59520943DC26494F8941B
select * from nhanvien
--delete nhanvien
-------------------------------------------------------------------------

create procedure SP_SEL_ENCRYPT_NHANVIEN
as
	SELECT MANV, HOTEN, EMAIL, LUONG
	FROM NHANVIEN 
GO

EXEC SP_SEL_ENCRYPT_NHANVIEN