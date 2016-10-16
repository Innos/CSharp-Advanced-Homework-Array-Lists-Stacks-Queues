CREATE TABLE NotificationEmails (
Id INT NOT NULL IDENTITY(1,1),
Recipient VARCHAR(20) NOT NULL,
Subject VARCHAR(50) NOT NULL,
Body VARCHAR(max),
CONSTRAINT PK_NotificationEmails PRIMARY KEY(Id)
)

GO
CREATE TRIGGER tr_NotifyEmailOnBalanceChange
ON Logs
AFTER INSERT
AS
BEGIN

INSERT INTO NotificationEmails(Recipient,Subject,Body)
SELECT i.AccountId, CONCAT('Balance change for account: ',i.AccountId), CONCAT('On ',GETDATE(),' your balance was changed from ',i.OldSum,' to ',i.NewSum,'.') 
  FROM inserted AS i
END
