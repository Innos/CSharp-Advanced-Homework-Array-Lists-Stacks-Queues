/* after year 2000, excludes it, should be better written though */

CREATE VIEW V_EmployeesHiredAfter2000 AS
SELECT FirstName, LastName
FROM Employees
WHERE HireDate > '2001'