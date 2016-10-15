CREATE TABLE Teachers
(
TeacherID INT NOT Null Identity(101,1),
Name varchar(50) Not null,
ManagerID INT,
Constraint PK_Teachers PRIMARY KEY(TeacherID),
Constraint FK_Teachers_Managers 
FOREIGN KEY(ManagerID)
REFERENCES Teachers(TeacherID)
)

INSERT INTO Teachers (Name,ManagerID) VALUES
('John',NULL),
('Maya',106),
('Silvia',106),
('Ted',105),
('Mark',101),
('Greta',101)
