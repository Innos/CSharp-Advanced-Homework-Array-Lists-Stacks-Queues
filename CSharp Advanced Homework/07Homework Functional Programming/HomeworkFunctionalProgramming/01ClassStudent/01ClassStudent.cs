using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentList
{
    public class ClassStudent
    {
        public static List<Student> students = new List<Student>()
        { 
            new Student("Adam","Jones",22,"257514","+359 888 111 111","a.jones@gmail.com",new List<int>(){3, 5, 3, 5}, 2,"alpha"),
            new Student("John","Smith", 37, "255309", "+359 889 222 222","j.smith@blaa.com",new List<int>(){6,5,4,6}, 1,"beta"), 
            new Student("Sheryl","Nome", 25, "266412", "+359 2 98 333 333", "s.nome@abv.bg", new List<int>(){4,2,5,2},3,"gamma"),
            new Student("Greg","Billow", 29, "267513", "+359 887 444 444", "g.billow@blaa.com", new List<int>(){2,3,5,4},3,"gamma"),
            new Student("Janna", "Dafrey", 21, "257814", "+359 2 96 555 555", "j.dafrey@blaa.com", new List<int>(){3,5,6,5},1,"beta")
        };
	    static void Main()
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
