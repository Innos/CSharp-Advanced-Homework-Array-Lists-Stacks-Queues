using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studentList;

class StudentsEnrolledIn2014
{
    static void Main(string[] args)
    {
        var studentsEnrolledIn2014 = ClassStudent.students.Where(student => student.FacultyNumber.EndsWith("14"));

        foreach (var student in studentsEnrolledIn2014)
        {
            Console.WriteLine("{0} {1} - Marks: {2}",student.FirstName, student.LastName, String.Join(", ",student.Marks));
        }
    }
}

