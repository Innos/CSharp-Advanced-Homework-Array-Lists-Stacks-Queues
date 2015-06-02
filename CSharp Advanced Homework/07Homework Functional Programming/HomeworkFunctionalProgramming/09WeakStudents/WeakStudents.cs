using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studentList;


class WeakStudents
{
    static void Main(string[] args)
    {
        var weakStudents = ClassStudent.students
            .Where(student => student.Marks
                .Count(mark => mark == 2) == 2)
            .Select(student => new { FullName = student.FirstName + " " + student.LastName, Marks = student.Marks });

        foreach (var student in weakStudents)
        {
            Console.WriteLine("{0} - Marks: {1}",student.FullName,String.Join(", ",student.Marks));
        }
    }
    
}

