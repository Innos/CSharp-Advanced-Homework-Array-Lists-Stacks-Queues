SELECT SUM(Diff) as 'SumDifference' FROM
(SELECT (w.DepositAmount - (SELECT wn.DepositAmount FROM WizzardDeposits as wn WHERE wn.Id = w.Id + 1)) as 'Diff'
FROM WizzardDeposits as w) as di