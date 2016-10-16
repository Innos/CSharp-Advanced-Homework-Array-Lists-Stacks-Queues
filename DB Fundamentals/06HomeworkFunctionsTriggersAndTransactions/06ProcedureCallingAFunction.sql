CREATE PROC usp_EmployeesBySalaryLevel(@salaryLevel varchar(10))
AS
BEGIN
	SELECT e.FirstName,e.LastName FROM Employees as e
	WHERE dbo.ufn_GetSalaryLevel(e.Salary) = @salaryLevel
	RETURN
END

GO
usp_EmployeesBySalaryLevel 'low'