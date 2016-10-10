/* + operator treats NULL as NULL */
SELECT (e.FirstName + ' ' + e.MiddleName + ' ' + e.LastName) AS 'Full Name' FROM Employees as e
WHERE e.Salary IN (25000, 14000, 12500, 23600)

/* CONCAT exchanges NULL for empty string */
SELECT (e.FirstName + ' ' + e.MiddleName + ' ' + e.LastName) AS 'Full Name' FROM Employees as e
WHERE e.Salary IN (25000, 14000, 12500, 23600)