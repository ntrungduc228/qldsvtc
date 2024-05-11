﻿
CREATE PROCEDURE SP_KTTenLop @tenLop nvarchar(50)
AS
	BEGIN
		IF EXISTS(SELECT * FROM dbo.LOP WHERE dbo.LOP.TENLOP = @tenLop)
			RETURN 1;
	
		ELSE IF EXISTS(SELECT * FROM LINK0.QLDSV_TC.dbo.LOP AS LOP WHERE LOP.TENLOP = @tenLop)
			RETURN 2;
	END

CREATE PROCEDURE SP_KTMaLopHoc @maLop nchar(10)
AS
BEGIN
	IF EXISTS(SELECT MALOP FROM DBO.LOP WHERE DBO.LOP.MALOP = @maLop)
		RETURN 1;
	ELSE IF EXISTS(SELECT * FROM LINK0.QLDSV_TC.dbo.LOP AS LOP WHERE LOP.MALOP = @maLop)
		RETURN 2;
END

create procedure CheckExist_MonHoc_ChiNhanhKhac
@MAMH nchar(10)
AS
BEGIN
	if exists(select * from LOPTINCHI where MAMH = @MAMH)
		return 1
	if exists(select * from LINK1.QLDSV_TC.DBO.LOPTINCHI where MAMH = @MAMH)
		return 2
	else
		return 0
END

create PROCEDURE SP_CHECKMONHOC_ID_NAME
    @MAMH NCHAR(10),
    @TENMH NVARCHAR(50)
AS
BEGIN
    DECLARE @KT_NAME  INT, @KT_MAMH int;
    
    IF EXISTS(SELECT * FROM dbo.MONHOC WHERE MAMH = @MAMH)
        SET @KT_MAMH = 1;
	ELSE
        SET @KT_MAMH = 0;
    IF EXISTS(SELECT * FROM dbo.MONHOC WHERE TENMH = @TENMH)
        SET @KT_NAME = 1;
	 ELSE
        SET @KT_NAME = 0;
	IF(@KT_MAMH = 1 and @KT_NAME = 1)
		RETURN 1   
	IF(@KT_MAMH = 1)
		RETURN 2;
	IF(@KT_NAME = 1)
		RETURN 3;
    RETURN 0; -- Không bị trùng được thêm
END

create PROCEDURE checkExistsGV_MH
    @MAGV nchar(10), @TENGV nvarchar(100),
    @MAMH nchar(9), @TENMH nvarchar(50)
AS
BEGIN
	DECLARE @KT_MAMH  INT, @KT_MAGV int;
    IF EXISTS (SELECT * FROM GIANGVIEN WHERE MAGV = @MAGV and HO + ' ' + TEN = @TENGV)
        SET @KT_MAGV = 1
    IF EXISTS (SELECT * FROM MONHOC WHERE MAMH = @MAMH and TENMH = @TENMH)
        SET @KT_MAMH = 2
	IF(@KT_MAGV = 1 and @KT_MAMH = 2)
		return 1
	else if(@KT_MAGV = 1 )
		return 2
	else if(@KT_MAMH = 2)
		return 3
	else
		return 0

END

create PROCEDURE checkExistLTC
	@NIENKHOA nchar(9),
	@HOCKY int,
	@MAMH nchar(9),
	@NHOM int
AS
Begin
	if exists( select *
	From LOPTINCHI
	where @NIENKHOA = NIENKHOA and @HOCKY = HOCKY and @MAMH = MAMH and @NHOM = NHOM)
		return 1;
	else
		return 0;
end

create PROCEDURE SP_LayDSGV AS
BEGIN
	SELECT MAGV,HOTEN = HO+' '+TEN FROM dbo.GIANGVIEN 
END


create PROC [dbo].[SP_LayDSHocKy] @NIENKHOA NCHAR(9)  AS 
SELECT HOCKY FROM LOPTINCHI WHERE NIENKHOA= @NIENKHOA GROUP BY HOCKY

CREATE VIEW [dbo].[LayDSNienKhoa] AS 
SELECT NIENKHOA FROM LOPTINCHI GROUP BY NIENKHOA

CREATE PROCEDURE [dbo].[SP_InDanhSachLopTinChi] @NienKhoa varchar(9), @HocKy int
AS
with SOSVDK (MALTC,MAMH,MAGV,NHOM,SOSVTOITHIEU,AMOUNT) as
(select LOPTINCHI.MALTC,MAMH,MAGV,NHOM,SOSVTOITHIEU,count(DANGKY.MALTC) from LOPTINCHI 
left join DANGKY
on DANGKY.MALTC = LOPTINCHI.MALTC 
where HUYLOP=0 AND LOPTINCHI.NIENKHOA = @NienKhoa AND LOPTINCHI.HOCKY = @HocKy 
group by LOPTINCHI.MALTC,MAMH,MAGV,NHOM,SOSVTOITHIEU)
select A.MALTC,TENMH,NHOM,HOTEN,SOSVTOITHIEU,AMOUNT
from (select MALTC,TENMH from SOSVDK,MONHOC where SOSVDK.MAMH = MONHOC.MAMH) as A,
(select MALTC,NHOM,HOTEN=HO+' '+TEN,SOSVDK.SOSVTOITHIEU,AMOUNT from SOSVDK,GIANGVIEN where SOSVDK.MAGV=GIANGVIEN.MAGV) as B
where A.MALTC=B.MALTC

CREATE PROCEDURE [dbo].[SP_SVDangKyLTC] @NienKhoa VARCHAR(9),
@HocKy int , @Nhom int, @MaMh nvarchar(50)
as
declare @LOPTINCHI int
select @LOPTINCHI = MALTC  from LOPTINCHI,MONHOC
where LOPTINCHI.NIENKHOA=@NienKhoa AND LOPTINCHI.HOCKY = @HocKy
AND LOPTINCHI.NHOM = @Nhom AND MONHOC.MAMH = @MaMh AND LOPTINCHI.MAMH = MONHOC.MAMH
select SINHVIEN.MASV,HOTEN=HO+' '+TEN,PHAI = IIF(PHAI=1,N'Nữ',N'Nam'),MALOP from SINHVIEN,DANGKY
where DANGKY.MASV = SINHVIEN.MASV AND DANGKY.MALTC = @LOPTINCHI AND HUYDANGKY = 0
order by TEN,HO

create proc [dbo].[GetAllNhom] @NIENKHOA varchar(9), @HOCKI int
as select NHOM FROM LOPTINCHI where @NIENKHOA = NIENKHOA AND HOCKY = @HOCKI group by NHOM

create proc [dbo].[SP_LayDSMonHoc] @NIENKHOA varchar(9), @HOCKI int
as select distinct MONHOC.MAMH as MAMH,TENMH FROM MONHOC join LOPTINCHI 
on MONHOC.MAMH = LOPTINCHI.MAMH where @NIENKHOA = NIENKHOA AND HOCKY = @HOCKI




CREATE PROC [dbo].SP_LayThongTinSVTuLogin
@masv NCHAR(10),@password NVARCHAR(40)
AS
BEGIN
	SELECT MASV,HOTEN = HO+' '+TEN FROM dbo.SINHVIEN WHERE MASV = @masv AND PASSWORD = @password
END

CREATE PROCEDURE [dbo].[SP_BDMH] @NienKhoa varchar(9), @HocKy int, @Nhom int,@MonHoc nvarchar(50)
as
declare @LOPTINCHI int
select @LOPTINCHI= MALTC from LOPTINCHI,MONHOC
where LOPTINCHI.NIENKHOA = @NienKhoa AND LOPTINCHI.HOCKY = @HocKy AND LOPTINCHI.NHOM = @Nhom
AND MONHOC.TENMH = @MonHoc AND LOPTINCHI.MAMH = MONHOC.MAMH
select MALC=@LOPTINCHI,SINHVIEN.MASV,HOTEN=HO+' '+TEN,DIEM_CC,DIEM_GK,DIEM_CK,DIEM_TK= DIEM_CC*0.1 + DIEM_GK*0.3 + DIEM_CK*0.6 from DANGKY,SINHVIEN
where  DANGKY.MASV = SINHVIEN.MASV AND DANGKY.MALTC = @LOPTINCHI AND HUYDANGKY = 0
order by TEN,HO

CREATE PROC [dbo].[SP_XULY_DIEM]
@MSSV varchar(20),
@MALTC int,
@DIEMCC float,
@DIEMGK float,
@DIEMCK float
as 
BEGIN
	IF EXISTS (Select 1 From DANGKY where MASV = @MSSV AND MALTC = @MALTC)
	BEGIN
		UPDATE DANGKY
		SET DIEM_CC = @DIEMCC, DIEM_GK = @DIEMGK, DIEM_CK = @DIEMCK
		WHERE MASV = @MSSV AND MALTC = @MALTC
	END
	ELSE 
	RAISERROR(N'THÔNG TIN ĐĂNG KÝ KHÔNG TỒN TẠI',16,1)
	END