using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studentList;


class StudentsByAge
{
    static void Main(string[] args)
    {
        var studentsInAgeGroup = from student in ClassStudent.students
                                 where student.Age >= 18 && student.Age <= 24
                                 select new { student.FirstName, student.LastName, student.Age };
        foreach (var student in studentsInAgeGroup)
        {
            Console.WriteLine("{0} {1} - Age: {2}", student.FirstName, student.LastName, student.Age);
        }
    }
}

