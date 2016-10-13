SELECT TOP 10 FirstName, LastName, DepartmentID FROM Employees as m
WHERE Salary > 	(SELECT AVG(Salary) FROM Employees AS e
				WHERE e.DepartmentID = m.DepartmentID)
ORDER BY m.DepartmentID
