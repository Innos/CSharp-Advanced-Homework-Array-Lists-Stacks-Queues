using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01CustomLinqExtensionMethods
{
    class LinqExtensionTest
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>(){1,2,4,5,6,8,9,11,13,2,5,3,17};
            var filteredList = nums.WhereNot(number => number % 2 == 0);
            Console.WriteLine(string.Join(", ",filteredList));

            var students = new List<Student>()
            {
                new Student("Gosho", 20, 4.5),
                new Student("Pesho", 17, 2),
                new Student("Tanio", 23, 6.00),
                new Student("Ivan", 21, 5.5)
            };

            Console.WriteLine(students.Max(student=>student.AverageGrade));
            Console.WriteLine(students.Max(student => student.Age));
        }
    }
}
