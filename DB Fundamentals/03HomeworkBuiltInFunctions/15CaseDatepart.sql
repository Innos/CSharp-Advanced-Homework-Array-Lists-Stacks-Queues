SELECT g.Name, 'Part of Day' =
CASE
	WHEN DATEPART(HOUR,g.Start) >= 0 AND DATEPART(HOUR,g.Start) < 12 THEN 'Morning'
	WHEN DATEPART(HOUR,g.Start) >= 12 AND DATEPART(HOUR,g.Start) < 18 THEN 'Afternoon'
	ELSE 'Evening'
END,
'Duration' = 
CASE
	WHEN g.Duration <= 3 THEN 'Extra Short'
	WHEN g.Duration >=4 AND g.Duration <= 6 THEN 'Short'
	WHEN g.Duration >6 THEN 'Long'
	ELSE 'Extra Long'
END
FROM Games as g
ORDER BY g.Name,Duration,[Part of Day]