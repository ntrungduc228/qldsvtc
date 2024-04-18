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


