CREATE PROC usp_TransferMoney (@firstAcc INT, @secondAcc INT, @money MONEY)
AS
BEGIN
	BEGIN TRAN

		UPDATE Accounts
		SET Balance = Balance - @money
		WHERE Id = @firstAcc

		UPDATE Accounts
		SET Balance = Balance + @money
		WHERE Id = @secondAcc

		IF (EXISTS(SELECT TOP 1 a.Balance FROM Accounts as a WHERE Id = @firstAcc) AND
			EXISTS(SELECT TOP 1 a.Balance FROM Accounts as a WHERE Id = @secondAcc) AND
			@money > 0)
		BEGIN
			COMMIT
		END
		ELSE
		BEGIN
			RAISERROR('Money didnt transfer',16,1)
			ROLLBACK
		END
		RETURN
END

GO
EXEC usp_TransferMoney 2,1,20


