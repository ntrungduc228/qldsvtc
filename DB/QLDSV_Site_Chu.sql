/****** Object:  View [dbo].[V_DSPM]    ******/
CREATE VIEW V_DS_PHANMANH
AS
SELECT    PUBS.description AS TENKHOA, SUBS.subscriber_server AS TENSERVER
FROM         dbo.sysmergepublications AS PUBS INNER JOIN
                      dbo.sysmergesubscriptions AS SUBS ON PUBS.pubid = SUBS.pubid AND PUBS.publisher <> SUBS.subscriber_server


CREATE PROC SP_Lay_Thong_Tin_GV_Tu_Login
 @TENLOGIN NVARCHAR(100)
 AS
 DECLARE @UID INT
 DECLARE @MAGV NVARCHAR(100)
 SELECT @UID = uid, @MAGV = name FROM SYS.sysusers
	WHERE sid = SUSER_SID(@TENLOGIN)
 SELECT MAGV = @MAGV,
		HOTEN = (SELECT HO+ ' '+TEN FROM dbo.GIANGVIEN WHERE MAGV=@MAGV),
		TENNHOM= name
		FROM SYS.sysusers
		WHERE uid = (SELECT groupuid FROM SYS.sysmembers WHERE memberuid = @UID)


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