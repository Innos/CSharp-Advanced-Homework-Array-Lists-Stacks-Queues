SELECT w.DepositGroup, w.MagicWandCreator, MIN(w.DepositCharge) as 'MinDepositCharge'
FROM WizzardDeposits as w
GROUP BY w.DepositGroup, w.MagicWandCreator
ORDER BY w.MagicWandCreator, w.DepositGroup