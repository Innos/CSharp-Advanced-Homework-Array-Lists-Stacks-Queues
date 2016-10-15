SELECT TOP 5 c.CountryName,r.RiverName FROM Countries as c
INNER JOIN Continents as co
ON co.ContinentCode = c.ContinentCode AND co.ContinentName = 'Africa'
LEFT JOIN CountriesRivers as cr
ON cr.CountryCode = c.CountryCode
LEFT JOIN Rivers as r
ON cr.RiverId = r.Id
ORDER BY c.CountryName