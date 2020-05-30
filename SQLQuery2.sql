
 
--ALTER PROC sp_Get_Enteries_Month 
--@Month INT
--AS
--BEGIN
--	SELECT COALESCE(SUM(oib.QUANTITY * (oib.PRICE - (oib.PRICE * oib.DISCOUNT))),0) AS [SUM] FROM dbo.oInvertoryHeader AS oih
--	JOIN dbo.oInvertoryBody AS oib ON oib.HEADERID = oih.INVERTORYID
--	WHERE YEAR(oih.DOCDATE) = YEAR(GETDATE()) AND MONTH(oih.DOCDATE) = @Month
--	AND oih.DOCTYPEID = 2
--END

ALTER PROC sp_Get_Enteries_Week
@Day NVARCHAR(50)
AS
BEGIN
	SELECT COALESCE(SUM(oib.QUANTITY * (oib.PRICE - (oib.PRICE * oib.DISCOUNT))),0) AS [SUM]  FROM dbo.oInvertoryHeader AS oih 
	JOIN dbo.oInvertoryBody AS oib ON oib.HEADERID = oih.INVERTORYID
	WHERE DATENAME(WEEK,oih.DOCDATE) = DATENAME(WEEK,GETDATE()) AND DATENAME(WEEKDAY,oih.DOCDATE) = @Day
	AND oih.DOCTYPEID = 2
END	
 
--CREATE PROC sp_Get_Enteries_Day
--@Date DATE
--AS
--BEGIN
--	SELECT COALESCE(SUM(oib.QUANTITY * (oib.PRICE - (oib.PRICE * oib.DISCOUNT))),0) FROM dbo.oInvertoryHeader AS oih 
--	JOIN dbo.oInvertoryBody AS oib ON oib.HEADERID = oih.INVERTORYID
--	WHERE YEAR(oih.DOCDATE) = YEAR(@Date) AND MONTH(oih.DOCDATE) = MONTH(@Date) AND DAY(oih.DOCDATE) = DAY(@Date)
--	AND oih.DOCTYPEID = 2
--END

--CREATE PROC sp_Get_Enteries_Client_Month
--@ClientName NVARCHAR(50),
--@Month INT
--AS
--BEGIN
--	SELECT COALESCE(SUM(oib.QUANTITY * (oib.PRICE - (oib.PRICE * oib.DISCOUNT))),0) FROM dbo.oInvertoryHeader AS oih 
--	JOIN dbo.oInvertoryBody AS oib ON oib.HEADERID = oih.INVERTORYID
--	JOIN dbo.oSupplier AS os ON os.SUPPLIERID = oih.SUPPLIERID
--	WHERE YEAR(oih.DOCDATE) = YEAR(GETDATE()) AND MONTH(oih.DOCDATE) = MONTH(@Month)
--	AND os.NAME = @ClientName
--	AND oih.DOCTYPEID = 2
--END


--CREATE PROC sp_Get_Enteries_Client_Week
--@Day NVARCHAR(50),
--@ClientName NVARCHAR(50)
--AS
--BEGIN
--	SELECT COALESCE(SUM(oib.QUANTITY * (oib.PRICE - (oib.PRICE * oib.DISCOUNT))),0) FROM dbo.oInvertoryHeader AS oih 
--	JOIN dbo.oInvertoryBody AS oib ON oib.HEADERID = oih.INVERTORYID
--	JOIN dbo.oSupplier AS os ON os.SUPPLIERID = oih.SUPPLIERID
--	WHERE DATENAME(WEEKDAY,oih.DOCDATE) = @Day and Datename(WEEK,oih.DOCDATE) = DATENAME(WEEK,GETDATE())
--	AND os.NAME = @ClientName
--	AND oih.DOCTYPEID = 2
--END


CREATE PROC sp_Get_Enteries_Client_Day
@Date DATE,
@ClientName NVARCHAR(50)
AS
BEGIN
	SELECT COALESCE(SUM(oib.QUANTITY * (oib.PRICE - (oib.PRICE * oib.DISCOUNT))),0) FROM dbo.oInvertoryHeader AS oih 
	JOIN dbo.oInvertoryBody AS oib ON oib.HEADERID = oih.INVERTORYID
	JOIN dbo.oSupplier AS os ON os.SUPPLIERID = oih.SUPPLIERID
	WHERE YEAR(oih.DOCDATE) = YEAR(@Date) AND MONTH(oih.DOCDATE) = MONTH(@Date) AND DAY(oih.DOCDATE) = DAY(@Date)
	AND os.NAME = @ClientName
	AND oih.DOCTYPEID = 2
END




 
