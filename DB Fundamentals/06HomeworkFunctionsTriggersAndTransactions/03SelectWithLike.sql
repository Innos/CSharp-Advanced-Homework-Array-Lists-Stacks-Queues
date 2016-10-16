CREATE PROC usp_GetTownsStartingWith (@prefix varchar(10))
AS
BEGIN
	SELECT t.Name FROM Towns as t
	WHERE t.Name LIKE @prefix + '%'
	RETURN
END
EXEC dbo.usp_GetTownsStartingWith 'b'
