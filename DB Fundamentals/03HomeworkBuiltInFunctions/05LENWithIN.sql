SELECT t.Name FROM Towns as t
WHERE LEN(t.Name) IN (5,6)
ORDER BY t.Name