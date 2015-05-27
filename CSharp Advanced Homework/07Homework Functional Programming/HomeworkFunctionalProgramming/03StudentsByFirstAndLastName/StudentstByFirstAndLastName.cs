using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studentList;


class StudentstByFirstAndLastName
{
    static void Main(string[] args)
    {
        var firstBeforeLast = from student in ClassStudent.students
                              where student.FirstName.CompareTo(student.LastName) < 0
                              select student;
        foreach (var student in firstBeforeLast)
        {
            Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
        }

    }
}

