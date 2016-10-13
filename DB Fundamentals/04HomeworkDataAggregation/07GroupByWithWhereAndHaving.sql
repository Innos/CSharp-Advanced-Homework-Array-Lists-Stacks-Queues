SELECT w.DepositGroup, SUM(w.DepositAmount) as 'Total Sum' FROM WizzardDeposits as w
WHERE w.MagicWandCreator = 'Ollivander family'
GROUP BY w.DepositGroup
HAVING SUM(w.DepositAmount) < 150000
ORDER BY [Total Sum] DESC