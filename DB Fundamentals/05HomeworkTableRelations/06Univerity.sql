CREATE TABLE Subjects
(
SubjectID INT NOT NULL PRIMARY KEY,
SubjectName varchar(50)
)

CREATE TABLE Majors
(
MajorID INT NOT NULL PRIMARY KEY,
Name varchar(50)
)

CREATE TABLE Students
(
StudentID INT NOT NULL PRIMARY KEY,
StudentNumber char(10),
StudentName varchar(50),
MajorID INT NOT NULL,
Constraint FK_Students_Majors Foreign Key (MajorID) References Majors(MajorID)
)

CREATE TABLE Agenda
(
StudentID INT NOT NULL,
SubjectID INT NOT NULL,
Constraint PK_Agenda PRIMARY KEY (StudentID,SubjectID),
Constraint FK_Agenda_Students Foreign Key (StudentID) References Students(StudentID),
Constraint FK_Agenda_Subjects Foreign Key (SubjectID) References Subjects(SubjectID),
)

CREATE TABLE Payments
(
PaymentID INT NOT NULL PRIMARY KEY,
PaymentDate DATE,
PaymentAmount DECIMAL(18,2),
StudentID INT,
Constraint FK_Payments_Students Foreign Key (StudentID) References Students(StudentID)
)


