SELECT TOP 10 FirstName, LastName, DepartmentID FROM Employees as m
WHERE Salary > 	(SELECT AVG(Salary) AS AvgSalary FROM Employees AS e
				WHERE e.DepartmentID = m.DepartmentID
				GROUP BY DepartmentID)
ORDER BY m.DepartmentID
