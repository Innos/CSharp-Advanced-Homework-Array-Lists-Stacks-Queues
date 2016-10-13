SELECT w.DepositGroup, SUM(w.DepositAmount) as 'Total Sum' FROM WizzardDeposits as w
GROUP BY w.DepositGroup