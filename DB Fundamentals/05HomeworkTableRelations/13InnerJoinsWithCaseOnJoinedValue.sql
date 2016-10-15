SELECT e.EmployeeID, e.FirstName,
CASE 
	WHEN p.StartDate > '2005' THEN NULL
	ELSE p.Name
END as [ProjectName]
FROM Employees as e
INNER JOIN EmployeesProjects as ep
ON e.EmployeeID = ep.EmployeeID
INNER JOIN Projects as p
ON ep.ProjectID = p.ProjectID
WHERE e.EmployeeID = 24
ORDER BY e.EmployeeID