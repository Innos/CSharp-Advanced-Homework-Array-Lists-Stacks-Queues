CREATE TABLE Students
(
StudentID INT NOT Null Identity(1,1),
Name varchar(50) Not null,
Constraint PK_Students PRIMARY KEY(StudentID)
)

CREATE TABLE Exams
(
ExamID INT NOT Null Identity(101,1),
Name varchar(50) Not null,
Constraint PK_Exams PRIMARY KEY(ExamID)
)

CREATE TABLE StudentsExams
(
StudentID INT NOT Null,
ExamID INT NOT Null,
Constraint PK_StudentsExams PRIMARY KEY(StudentID,ExamID),
Constraint FK_StudentsExams_Students
Foreign key (StudentID)
REFERENCES Students(StudentID),
Constraint FK_StudentsExams_Exams
Foreign key (ExamID)
REFERENCES Exams(ExamID)
)


INSERT INTO Students (Name) VALUES
('Mila'),
('Toni'),
('Ron')

INSERT INTO Exams (Name) VALUES
('Spring MVC'),
('Neo4j'),
('Oracle 11g')

INSERT INTO StudentsExams (StudentID,ExamID) VALUES
(1,101),
(1,102),
(2,101),
(3,103),
(2,102),
(2,103)
