
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
