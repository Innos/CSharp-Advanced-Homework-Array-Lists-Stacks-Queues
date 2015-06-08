using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SULS.Persons;
using SULS.Persons.Trainer;
using SULS.Persons.Student;
using SULS.Persons.Student.CurrentStudent;


namespace SULS
{
    class SULSTest
    {
        static void Main(string[] args)
        {
            //Person asen = new Person("Asen", "Asenov", 23);
            //Trainer pesho = new Trainer("Pesho", "Peshev", 21);
            //Trainer.CreateCourse("Regex");
            //Student goshko = new Student("Goshko", "Goshev", 33,"111222333",55.8);
            //DropoutStudent ico = new DropoutStudent("Ico", "Icev", 25, "222333444", 22.2, "Lazy");
            //ico.Reapply();

            List<Person> students = new List<Person>()
            {
                new Person("Asen", "Asenov", 23),
                new Trainer("Pesho", "Peshev", 21),
                new SeniorTrainer("Doncho","Donchev",36),
                new Student("Goshko", "Goshev", 33,"111222333",55.8),
                new OnlineStudent("Simeon","Simeonov",33,"000111222",178.88,"OOP"),
                new DropoutStudent("Ico", "Icev", 25, "222333444", 22.2, "Lazy"),
                new CurrentStudent("Iordan","Iordanov",44,"333444555",387.55,"Advanced C#"),
                new OnsiteStudent("Gicho","Gichev",38,"444555666",255.98,"C# Basics",11),
                new CurrentStudent("Jelio","Jelev",77,"555666777",244.44,"Advanced C#")
            };

            var result = students.Where(student => student is CurrentStudent).Cast<CurrentStudent>().OrderBy(student => student.AverageGrade).ToList();
            Console.WriteLine(String.Join("\n",result));
        }
    }
}
