SELECT TOP 30 c.CountryName, c.Population FROM Countries as c
INNER JOIN Continents AS co
ON c.ContinentCode = co.ContinentCode
WHERE co.ContinentName = 'Europe'
ORDER BY c.Population DESC, c.CountryName ASC