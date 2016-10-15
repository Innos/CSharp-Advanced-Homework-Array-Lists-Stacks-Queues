SELECT e.EmployeeID, e.FirstName, e.ManagerID, m.FirstName as 'ManagerName'  FROM Employees as e
INNER JOIN Employees as m
ON e.ManagerID = m.EmployeeID
WHERE e.ManagerID IN (3,7)
ORDER BY e.EmployeeID