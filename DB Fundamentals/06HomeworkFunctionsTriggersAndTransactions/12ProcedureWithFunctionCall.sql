CREATE PROC usp_CalculateFutureValueForAccount(@accountId INT,@interestRate MONEY)
AS
BEGIN
	SELECT ac.Id,ac.FirstName,
	ac.LastName,
	a.Balance as 'Current Balance',
	[dbo].[ufn_CalculateFutureValue](a.Balance,@interestRate,5) as 'Balance in 5 years' 
	FROM AccountHolders ac
	INNER JOIN Accounts as a
	ON a.AccountHolderId = ac.Id
	WHERE ac.Id = @accountId
	RETURN
END

GO
EXEC usp_CalculateFutureValueForAccount 1, 0.1