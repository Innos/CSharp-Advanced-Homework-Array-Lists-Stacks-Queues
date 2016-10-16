CREATE FUNCTION ufn_CalculateFutureValue(@sum FLOAT, @yearlyInterest FLOAT, @numberOfYears INT)
RETURNS DECIMAL(18,4)
AS
BEGIN
	DECLARE @result MONEY;
	SET @result = @sum * (POWER((1 + @yearlyInterest),@numberOfYears))
	RETURN @result;
END

GO
SELECT dbo.ufn_CalculateFutureValue(1000,0.1,5)