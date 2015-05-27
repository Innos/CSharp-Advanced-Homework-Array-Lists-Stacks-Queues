using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studentList;

class ExcellentStudents
{
    static void Main(string[] args)
    {
        var excellentStudents = ClassStudent.students.Where(student => student.Marks.Contains(6)).Select(student => new { FullName = student.FirstName + " " + student.LastName, Marks = student.Marks });

        foreach (var student in excellentStudents)
        {
            Console.WriteLine("{0} - Marks: {1}",student.FullName,String.Join(", ",student.Marks));
        }
    }
}

