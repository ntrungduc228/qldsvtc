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
