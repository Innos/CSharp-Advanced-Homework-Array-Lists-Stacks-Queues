SELECT mc.CountryCode, COUNT(m.MountainRange) as 'MountainRanges' FROM MountainsCountries as mc
INNER JOIN Mountains as m
ON m.Id = mc.MountainId
WHERE mc.CountryCode IN ('BG','US','RU')
GROUP BY mc.CountryCode