CREATE VIEW V_EmployeesNameJobTitle AS
SELECT 
CASE WHEN MiddleName IS NULL
THEN CONCAT(FirstName,'  ',LastName)
ELSE CONCAT(FirstName,' ', MiddleName, ' ',LastName)
END AS 'Full Name',JobTitle AS 'JobTitle'

FROM Employees;