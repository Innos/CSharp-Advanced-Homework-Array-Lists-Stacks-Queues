SELECT TOP 5 x.CountryName,
ISNULL(x.PeakName,'(no highest peak)'),
ISNULL(x.Elevation,0),
ISNULL(x.MountainRange,'(no mountain)')
FROM
(SELECT c.CountryName,
p.Elevation,
p.PeakName,
m.MountainRange,
RANK() over (PARTITION BY c.CountryName ORDER BY p.Elevation DESC) as rank
FROM Countries as c
LEFT JOIN MountainsCountries as mc
ON c.CountryCode = mc.CountryCode
LEFT JOIN Mountains as m
ON mc.MountainId = m.Id
LEFT JOIN Peaks as p
ON p.MountainId = mc.MountainId) as x
WHERE x.rank = 1
ORDER BY x.CountryName, x.PeakName
