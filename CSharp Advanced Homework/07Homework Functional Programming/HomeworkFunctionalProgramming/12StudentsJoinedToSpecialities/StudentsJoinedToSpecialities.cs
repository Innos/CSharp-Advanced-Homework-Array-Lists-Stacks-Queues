using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studentList;

class StudentsByGroups
{
    static void Main(string[] args)
    {
        List<StudentSpeciality> studentSpecialities = new List<StudentSpeciality>()
        {
            new StudentSpeciality("Web Developer","257514"),
            new StudentSpeciality("PHP Developer", "255309"),
            new StudentSpeciality("QA Engineer", "266412"),
            new StudentSpeciality("Web Developer", "267513"),
            new StudentSpeciality("QA Engineer", "257814")
        };

        var studentsBySpeciality = ClassStudent.students.Join(studentSpecialities,
            student => student.FacultyNumber,
            speciality => speciality.FacultyNumber,
            (student, speciality) => new
            {
                Name = student.FirstName + " " + student.LastName,
                FacultyNumber = student.FacultyNumber,
                Speciality = speciality.Speciality
            });

        foreach (var student in studentsBySpeciality)
        {
            Console.WriteLine("Name: {0,15} | Faculty Number: {1,5} | Speciality: {2,15} |", student.Name, student.FacultyNumber, student.Speciality);
        }
    }
}

