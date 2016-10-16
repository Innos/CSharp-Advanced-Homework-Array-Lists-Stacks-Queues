CREATE FUNCTION ufn_IsWordComprised(@setOfLetters nvarchar(20), @word nvarchar(20))
RETURNS Bit
AS
BEGIN
	DECLARE @index INT;
	DECLARE @letter nchar(1);
	SET @index = 1;

	WHILE @index <= LEN(@word)
	BEGIN
		SET @letter = SUBSTRING(@word,@index,1); 
		IF(CHARINDEX(@letter,@setOfLetters) = 0)
		RETURN 0;
		SET @index = @index + 1;
	END
	RETURN 1;
END

GO
SELECT dbo.ufn_IsWordComprised('oistmiahf','Sofia') 