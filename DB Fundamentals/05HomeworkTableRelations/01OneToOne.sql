CREATE TABLE Passports
(
PassportID INT NOT Null Identity(101,1),
PassportNumber char(8) Not null,
Constraint PK_Passport PRIMARY KEY(PassportID)
)

CREATE TABLE Persons(
PersonID INT NOT NULL IDENTITY(1,1),
FirstName NVARCHAR(50),
Salary DECIMAL(18,2),
PassportID INT NOT NULL,
CONSTRAINT PK_Person PRIMARY KEY(PersonID),
CONSTRAINT FK_Persons_Passports
FOREIGN KEY (PassportID)
REFERENCES Passports(PassportID)
)

INSERT INTO Passports (PassportNumber) VALUES
('N34FG21B'),('K65LO4R7'),('ZE657QP2')

INSERT INTO Persons (FirstName,Salary,PassportID) VALUES
('Roberto',43300.00,102),
('Tom',56100.00,103),
('Yana',60200.00,101)
