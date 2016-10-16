CREATE PROC usp_GetEmployeesSalaryAbove35000
AS
BEGIN
	SELECT e.FirstName,e.LastName FROM Employees as e
	WHERE e.Salary > 35000
	RETURN
END
EXEC dbo.usp_GetEmployeesSalaryAbove35000;
