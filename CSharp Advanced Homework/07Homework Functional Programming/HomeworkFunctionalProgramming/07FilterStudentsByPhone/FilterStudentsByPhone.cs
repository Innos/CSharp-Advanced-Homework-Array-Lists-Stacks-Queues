using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studentList;

class FilterStudentsByPhone
{
    static void Main(string[] args)
    {
        var studentsByPhone = ClassStudent.students.Where(student => student.Phone.StartsWith("02") || student.Phone.StartsWith("+3592") || student.Phone.StartsWith("+359 2"));

        foreach (var student in studentsByPhone)
        {
            Console.WriteLine("{0} {1} - Phone: {2}", student.FirstName, student.LastName, student.Phone);
        }
    }
}

