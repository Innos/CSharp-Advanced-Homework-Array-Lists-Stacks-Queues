/* seconds from the date still count for the sorting so we use g.Start instead of Start */
SELECT TOP 50 g.Name, FORMAT(g.Start, 'yyyy-MM-dd') AS 'Start' FROM Games As g
WHERE YEAR(Start) IN (2011,2012)
ORDER BY g.Start, g.Name

/*
SELECT TOP 50 Name, 
       FORMAT(Start, 'yyyy-MM-dd') AS NewDate,
	   CONVERT(DATE, Start, 120) AS NewDate2
  FROM Games
 WHERE YEAR(Start) IN (2011, 2012)
 ORDER BY Start, Name
 */