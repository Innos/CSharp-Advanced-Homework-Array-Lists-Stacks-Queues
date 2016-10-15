SELECT COUNT(c.CountryCode) as 'CountryCode' FROM Countries as c
LEFT JOIN MountainsCountries mc
ON mc.CountryCode = c.CountryCode
WHERE mc.MountainId IS NULL