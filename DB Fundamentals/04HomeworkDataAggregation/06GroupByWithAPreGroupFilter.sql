SELECT w.DepositGroup, SUM(w.DepositAmount) as 'Total Sum' FROM WizzardDeposits as w
WHERE w.MagicWandCreator = 'Ollivander family'
GROUP BY w.DepositGroup