using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04StudentClass
{
    class StudentClass
    {
        static void Main()
        {
            Student student = new Student("Peter",22);

            student.StudentChanged += (sender, args) =>
            {
                Console.WriteLine("Property changed: {0} (from {1} to {2})",
                    args.PropertyName, args.OldValue, args.NewValue);
            };

            student.Name = "Maria";
            student.Age = 19;

        }
    }
}
