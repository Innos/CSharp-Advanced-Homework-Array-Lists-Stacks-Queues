CREATE TABLE Logs (
LogId INT NOT NULL IDENTITY(1,1),
AccountId INT NOT NULL,
OldSum MONEY NOT NULL,
NewSum MONEY NOT NULL,
CONSTRAINT PK_Logs PRIMARY KEY(LogId)
)

GO
CREATE TRIGGER tr_LogRecords
ON Accounts
AFTER UPDATE
AS
BEGIN

INSERT INTO Logs(AccountId,OldSum,NewSum)
SELECT i.Id, d.Balance, i.Balance 
  FROM inserted AS i
  INNER JOIN deleted as d
  ON i.Id = d.Id
END
