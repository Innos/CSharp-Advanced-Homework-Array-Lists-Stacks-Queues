WITH
    DepartmentIdSalaryRows
AS
(
    SELECT
        e.DepartmentID,
        e.Salary,
        ROW_NUMBER() OVER(PARTITION BY e.DepartmentID ORDER BY e.Salary DESC) AS RowNumber
    FROM
        Employees e
)
SELECT
    di.DepartmentID,
    di.Salary AS ThirdHighestSalary
from
    DepartmentIdSalaryRows di
where
    RowNumber = 3