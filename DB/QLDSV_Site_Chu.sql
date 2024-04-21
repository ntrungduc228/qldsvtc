/****** Object:  View [dbo].[V_DSPM]    ******/
CREATE VIEW V_DS_PHANMANH
AS
SELECT    PUBS.description AS TENKHOA, SUBS.subscriber_server AS TENSERVER
FROM         dbo.sysmergepublications AS PUBS INNER JOIN
                      dbo.sysmergesubscriptions AS SUBS ON PUBS.pubid = SUBS.pubid AND PUBS.publisher <> SUBS.subscriber_server

end

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

end

create procedure LayTTSV_TuSiteHocPhi
@MASV nchar(10)
as
begin
select HOTEN = HO + ' ' + TEN, MALOP from SINHVIEN where MASV = @MASV
end


ALTER PROCEDURE [dbo].[LAY_DS_DONGHOCPHI_SV] 
@MASV nchar(10)
AS
BEGIN
    -- Tạo bảng tạm để lưu trữ danh sách đóng học phí
    DECLARE @DS_DONGHOCPHI TABLE (
        NIENKHOA nchar(9),
        HOCKY int,
        HOCPHI int,
        SOTIENCANDONG int,
        SOTIENDADONG int
    )

    -- Lấy danh sách các niên khóa và học kỳ đã đóng học phí của sinh viên
    INSERT INTO @DS_DONGHOCPHI (NIENKHOA, HOCKY, HOCPHI, SOTIENCANDONG, SOTIENDADONG)
    SELECT H.NIENKHOA, H.HOCKY, H.HOCPHI, 
    CASE WHEN H.HOCPHI - ISNULL(SUM(D.SOTIENDONG), 0) < 0 THEN 0 ELSE H.HOCPHI - ISNULL(SUM(D.SOTIENDONG), 0) END , ISNULL(SUM(D.SOTIENDONG), 0)
    FROM HOCPHI H
    LEFT JOIN CT_DONGHOCPHI D ON H.MASV = D.MASV AND H.HOCKY = D.HOCKY AND H.NIENKHOA = D.NIENKHOA
    WHERE H.MASV = @MASV
    GROUP BY H.NIENKHOA, H.HOCKY, H.HOCPHI

    -- Trả về danh sách đóng học phí của các niên khóa
    SELECT NIENKHOA, HOCKY, HOCPHI, SOTIENCANDONG, SOTIENDADONG
    FROM @DS_DONGHOCPHI

END

create procedure [dbo].[LOADCTHP_SV]
@MASV nchar(10), @NIENKHOA nchar(9), @HOCKY int
as
begin
	select NGAYDONG, SOTIENDONG from CT_DONGHOCPHI where MASV = @MASV and NIENKHOA = @NIENKHOA and HOCKY = @HOCKY;
end

create procedure [dbo].[TAO_THONGTINHOCPHI]
@MASV nchar(10), @NIENKHOA nchar(9), @HOCKY int, @HOCPHI int
as
begin
	insert into HOCPHI(MASV, NIENKHOA, HOCKY, HOCPHI)
	values(@MASV, @NIENKHOA, @HOCKY, @HOCPHI)
end


create PROCEDURE [dbo].[SV_DONGTIEN]
    @MASV nchar(10),
    @NIENKHOA nchar(9),
    @HOCKY int,
    @SOTIENDONG int
AS
BEGIN
    DECLARE @CurrentDate date;
    SET @CurrentDate = CONVERT(date, GETDATE());

    INSERT INTO CT_DONGHOCPHI (MASV, NIENKHOA, HOCKY, NGAYDONG, SOTIENDONG)
    VALUES (@MASV, @NIENKHOA, @HOCKY, @CurrentDate, @SOTIENDONG);
END


ALTER procedure [dbo].[TAO_THONGTINHOCPHI]
@MASV nchar(10), @NIENKHOA nchar(9), @HOCKY int, @HOCPHI int
as
begin
	insert into HOCPHI(MASV, NIENKHOA, HOCKY, HOCPHI)
	values(@MASV, @NIENKHOA, @HOCKY, @HOCPHI)
end
