SELECT e.DepartmentID, MIN(e.Salary) as 'MinimumSalary' FROM Employees as e
WHERE e.DepartmentID IN (2,5,7) AND e.HireDate > '2000/01/01'
GROUP BY e.DepartmentID