SELECT e.FirstName,e.LastName FROM Employees AS e
WHERE LEFT(e.FirstName,2) = 'SA'