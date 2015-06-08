using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SULS.Persons.Trainer
{
    class SeniorTrainer : Trainer
    {
        public SeniorTrainer(string firstName,string lastName,int age) : base(firstName,lastName,age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        public static void DeleteCourse(string courseName)
        {
            Console.WriteLine("Course {0} has been deleted!", courseName);
        }
    }
}
