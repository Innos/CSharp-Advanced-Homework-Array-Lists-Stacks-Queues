using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04CompareDataStructures
{
    using System.Diagnostics;
    using System.IO;

    class CompareDataStructures
    {
        private static readonly Stopwatch Stopwatch = new Stopwatch();

        static void Main(string[] args)
        {
            //Control search and people amounts
            int amountOfSearches = 1000;
            int amountOfPeople = 1000000;

            char[] letters = new[]
                                 {
                                     'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q',
                                     'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
                                 };
            List<Person> phoneBook1 = new List<Person>();
            Dictionary<string,string> phoneBook2 = new Dictionary<string, string>();


            for (int i = 0; i < amountOfPeople; i++)
            {
                int numberOfLetters = (i / letters.Length) + 1;
                int character = letters[i % letters.Length];
                string name = new string((char)character,numberOfLetters);
                var person = new Person(name,i.ToString());
                phoneBook1.Add(person);
                phoneBook2.Add(name,i.ToString());
            }
            string[] times = new string[2];

            //List Search
            Stopwatch.Restart();
            for (int i = 0; i < amountOfSearches; i++)
            {
                Search(phoneBook1,"aa");
            }
            times[0] = Stopwatch.Elapsed.ToString();

            //Dictionary Search
            Stopwatch.Restart();
            for (int i = 0; i < amountOfSearches; i++)
            {
                Search(phoneBook2,"aa");
            }
            times[1] = Stopwatch.Elapsed.ToString();
            Store(times);

        }

        private static void Search(List<Person> phoneBook, string name)
        {
            var result = phoneBook.Find(p => p.Name == name);
        }

        private static void Search(Dictionary<string,string> phoneBook, string name)
        {
            var result = phoneBook[name];
        }

        private static void Store(string[] times)
        {
            using (var fs = new FileStream("Results.txt", FileMode.Append))
            {
                using (var writer = new StreamWriter(fs))
                {
                    writer.WriteLine("{0,-25}{1,-25}",times[0],times[1]);
                }
            }
        }
    }
}
