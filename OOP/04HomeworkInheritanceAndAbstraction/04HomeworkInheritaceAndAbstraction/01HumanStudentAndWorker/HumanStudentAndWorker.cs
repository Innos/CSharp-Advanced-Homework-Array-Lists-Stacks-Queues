using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanStudentAndWorker.Humans;

namespace HumanStudentAndWorker
{
    class HumanStudentAndWorker
    {
        static void Main(string[] args)
        {
            List<Human> all = new List<Human>();
            List<Student> students = new List<Student>() 
            {
                new Student("pesho1","peshev","00001"),
                new Student("pesho3","peshev","00003"),
                new Student("pesho4","peshev","00004"),
                new Student("pesho5","peshev","00005"),
                new Student("pesho6","peshev","00006"),
                new Student("pesho7","peshev","00007"),
                new Student("pesho8","peshev","00008"),
                new Student("pesho9","peshev","00009"),
                new Student("pesho10","peshev","00010"),
                new Student("pesho2","peshev","00002"),

            };
            List<Worker> workers = new List<Worker>()
            {
                new Worker("gosho1","goshev",100m,10),
                new Worker("gosho2","goshev",110m,10),
                new Worker("gosho3","goshev",120m,10),
                new Worker("gosho4","goshev",130m,10),
                new Worker("gosho5","goshev",140m,10),
                new Worker("gosho6","goshev",150m,10),
                new Worker("gosho7","goshev",160m,10),
                new Worker("gosho8","goshev",170m,10),
                new Worker("gosho9","goshev",180m,10),
                new Worker("gosho10","goshev",190m,10),
            };

            students = students.OrderBy(student => student.StudentNumber).ToList();
            workers = workers.OrderByDescending(worker => worker.MoneyPerHour()).ToList();
            all.AddRange(students);
            all.AddRange(workers);
            Console.WriteLine("Students:");
            all = all.OrderBy(human => human.FirstName).ThenBy(human => human.LastName).ToList();
            Console.WriteLine(String.Join("\n",students));
            Console.WriteLine("\nWorkers:");
            Console.WriteLine(String.Join("\n",workers));
            Console.WriteLine("\nAll Humans:");
            Console.WriteLine(String.Join("\n",all));
        }
    }
}
