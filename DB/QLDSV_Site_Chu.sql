/****** Object:  View [dbo].[V_DSPM]    ******/
CREATE VIEW V_DS_PHANMANH
AS
SELECT    PUBS.description AS TENKHOA, SUBS.subscriber_server AS TENSERVER
FROM         dbo.sysmergepublications AS PUBS INNER JOIN
                      dbo.sysmergesubscriptions AS SUBS ON PUBS.pubid = SUBS.pubid AND PUBS.publisher <> SUBS.subscriber_server



