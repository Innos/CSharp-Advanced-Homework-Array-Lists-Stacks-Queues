SELECT u.Username, SUBSTRING(u.Email, CHARINDEX('@',u.Email) + 1,LEN(u.Email)) AS 'Email Provider' FROM Users as u
ORDER BY [Email Provider], u.Username