CREATE PROC usp_GetHoldersFullName
AS
BEGIN
	SELECT CONCAT(ac.FirstName,' ',ac.LastName) as 'Full Name' FROM AccountHolders as ac
	RETURN
END

EXEC usp_GetHoldersFullName