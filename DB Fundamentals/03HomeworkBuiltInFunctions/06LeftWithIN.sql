SELECT * FROM Towns as t
WHERE LEFT(t.Name,1) IN ('M','K','B','E')
ORDER BY t.Name