using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studentList;

class SortStudents
{
    static void Main(string[] args)
    {
        Console.WriteLine("Linq Query:\n");
        //Linq Query
        var sortedStudents = from student in ClassStudent.students
                             orderby student.FirstName descending,
                             student.LastName descending
                             select student;
        foreach (var student in sortedStudents)
        {
            Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
        }

        Console.WriteLine("\nLinq extension method:\n");
        //Linq Extension methods
        var sortedStudents2 = ClassStudent.students.OrderByDescending(student => student.FirstName).ThenByDescending(student => student.LastName);
        
        foreach (var student in sortedStudents2)
        {
            Console.WriteLine("{0} {1}",student.FirstName,student.LastName);
        }
    }
}

