SELECT TOP 10  e.FirstName, e.LastName, e.DepartmentID
FROM Employees AS e
JOIN
(SELECT e.DepartmentID, avg(e.Salary) AS avgs
FROM Employees AS e
GROUP BY e.DepartmentID) AS avgSalaries
on e.DepartmentID = avgSalaries.DepartmentID
where e.Salary > avgSalaries.avgs
order by e.DepartmentID