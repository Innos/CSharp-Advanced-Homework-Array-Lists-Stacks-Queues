SELECT DepositGroup FROM
(SELECT DepositGroup,AVG(MagicWandSize) As AvgWandSize
FROM WizzardDeposits
GROUP BY DepositGroup) as avgw
WHERE AvgWandSize = (SELECT MIN(AvgWandSize) AS MinAvgWandSize
					FROM 
					(SELECT w.DepositGroup, AVG(w.MagicWandSize) As AvgWandSize
					FROM WizzardDeposits as w
					GROUP BY w.DepositGroup) as mavgw)