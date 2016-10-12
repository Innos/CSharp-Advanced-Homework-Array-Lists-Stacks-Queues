SELECT c.CountryName, c.IsoCode FROM Countries as c
WHERE LOWER(c.CountryName) LIKE('%a%a%a%')
ORDER BY c.IsoCode