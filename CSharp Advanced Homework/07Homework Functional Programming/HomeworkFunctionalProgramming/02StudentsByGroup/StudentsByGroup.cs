using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studentList;


class StudentsByGroup
{
    static void Main(string[] args)
    {
        var studentsByGroup = from student in ClassStudent.students
                              where student.GroupNumber == 2
                              orderby student.FirstName
                              select student;
        foreach (var student in studentsByGroup)
        {
            Console.WriteLine("{0} {1} - Group: {2}",student.FirstName, student.LastName, student.GroupNumber);
        }
    }
}

