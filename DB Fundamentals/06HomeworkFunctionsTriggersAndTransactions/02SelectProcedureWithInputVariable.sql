CREATE PROC usp_GetEmployeesSalaryAboveNumber(@salary MONEY)
AS
BEGIN
	SELECT e.FirstName,e.LastName FROM Employees as e
	WHERE e.Salary >= @salary
	RETURN
END
EXEC dbo.usp_GetEmployeesSalaryAboveNumber 48100
