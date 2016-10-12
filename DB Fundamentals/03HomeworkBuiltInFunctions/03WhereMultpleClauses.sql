/*
SELECT e.FirstName FROM Employees AS e
WHERE e.DepartmentID IN (3,10) AND e.HireDate BETWEEN '1995' AND '2005'
*/

/* People should really learn how to use OR */
SELECT e.FirstName FROM Employees AS e
WHERE e.DepartmentID = 3 OR (e.DepartmentID = 10 AND e.HireDate BETWEEN '1995' AND '2005')