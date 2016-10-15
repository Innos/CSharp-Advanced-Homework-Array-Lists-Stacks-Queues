SELECT mc.CountryCode, m.MountainRange,p.PeakName,p.Elevation FROM MountainsCountries as mc
INNER JOIN Mountains as m
ON m.Id = mc.MountainId
INNER JOIN Peaks as p
ON p.MountainId = m.Id
WHERE mc.CountryCode = 'BG' AND p.Elevation > 2835
ORDER BY p.Elevation DESC