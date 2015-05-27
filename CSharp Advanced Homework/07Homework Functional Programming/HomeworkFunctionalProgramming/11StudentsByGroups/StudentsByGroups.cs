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
        var studentGroups = ClassStudent.students.GroupBy(student => student.GroupName);

        foreach (var group in studentGroups)
        {
            Console.WriteLine(group.Key);
            foreach (var student in group)
            {
                Console.WriteLine(" {0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}

