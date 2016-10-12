SELECT * FROM Towns as t
WHERE LEFT(t.Name,1) NOT IN ('R','D','B')
ORDER BY t.Name