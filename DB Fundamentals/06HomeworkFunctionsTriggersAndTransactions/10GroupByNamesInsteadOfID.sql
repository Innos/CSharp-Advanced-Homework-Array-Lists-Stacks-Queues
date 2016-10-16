CREATE PROC usp_GetHoldersWithBalanceHigherThan(@money MONEY)
AS
BEGIN
	SELECT ac.FirstName,ac.LastName FROM AccountHolders as ac
	INNER JOIN Accounts as a
	ON a.AccountHolderId = ac.Id
	GROUP BY ac.FirstName, ac.LastName
	HAVING SUM(a.Balance) > @money
	RETURN
END

EXEC usp_GetHoldersWithBalanceHigherThan 50000