SELECT c.CountryName, c.CountryCode, IIF(c.CurrencyCode = 'EUR','Euro','Not Euro') AS 'Currency' FROM Countries as c
ORDER BY c.CountryName ASC