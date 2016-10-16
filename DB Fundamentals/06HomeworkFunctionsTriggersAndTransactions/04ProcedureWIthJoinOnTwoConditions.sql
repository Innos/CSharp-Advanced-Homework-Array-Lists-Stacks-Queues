CREATE PROC usp_GetEmployeesFromTown(@town varchar(20))
AS
BEGIN
	SELECT e.FirstName,e.LastName FROM Employees as e
	INNER JOIN Addresses as a
	ON a.AddressID = e.AddressID
	INNER JOIN Towns as t
	ON t.TownID = a.TownID AND t.Name = @town
	RETURN
END
EXEC usp_GetEmployeesFromTown 'Sofia'
