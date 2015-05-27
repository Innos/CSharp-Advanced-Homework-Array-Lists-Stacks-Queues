using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studentList;


class FilterStudentsByEmail
{
    static void Main(string[] args)
    {
        var studentsWithAbvEmail = ClassStudent.students.Where(student => student.Email.Contains("@abv.bg"));

        foreach (var student in studentsWithAbvEmail)
        {
            Console.WriteLine("{0} {1} - Email: {2}", student.FirstName, student.LastName, student.Email);
        }
    }
}

