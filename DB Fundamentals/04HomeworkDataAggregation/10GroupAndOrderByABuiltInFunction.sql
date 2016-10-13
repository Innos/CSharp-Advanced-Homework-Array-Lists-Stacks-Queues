SELECT LEFT(w.FirstName,1) as 'first_letter' FROM WizzardDeposits as w
WHERE w.DepositGroup = 'Troll Chest'
GROUP BY LEFT(w.FirstName,1)
ORDER BY LEFT(w.FirstName,1)