UPDATE Employees
SET Salary = Salary * 1.12
WHERE DepartmentID IN 
		(SELECT d.DepartmentID FROM Departments as d
		WHERE d.Name IN ('Engineering', 'Tool Design', 'Marketing', 'Information Services'));


SELECT e.Salary FROM Employees AS e