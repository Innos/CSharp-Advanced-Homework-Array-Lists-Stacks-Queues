Select TOP 5 c.CountryName,
MAX(p.Elevation),
MAX(r.Length)
FROM Countries as c
LEFT JOIN MountainsCountries as mc
ON mc.CountryCode = c.CountryCode
LEFT JOIN Peaks as p
ON mc.MountainId = p.MountainId
LEFT JOIN CountriesRivers as cr
ON cr.CountryCode = c.CountryCode
LEFT JOIN Rivers as r
ON r.Id = cr.RiverId
GROUP BY c.CountryName
ORDER BY MAX(p.Elevation) DESC, MAX(r.Length) DESC, c.CountryName