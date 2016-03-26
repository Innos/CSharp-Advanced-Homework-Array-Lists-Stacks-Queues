namespace _01StudentsAndCourses
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.RegularExpressions;

    public class StudentsAndCourses
    {
        public static void Main(string[] args)
        {
            var courses = new SortedDictionary<string, SortedSet<Student>>();

            using (StreamReader reader = new StreamReader(File.Open("../../students.txt", FileMode.Open)))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    var parameters = Regex.Split(line, @"\s+\|\s+");
                    var course = parameters[2];
                    var firstName = parameters[0];
                    var lastName = parameters[1];
                    if (!courses.ContainsKey(course))
                    {
                        courses.Add(course, new SortedSet<Student>());
                    }

                    courses[course].Add(new Student(firstName, lastName));
                    line = reader.ReadLine();
                }
            }

            foreach (var course in courses)
            {
                Console.WriteLine("{0}: {1}", course.Key, string.Join(", ", course.Value));
            }
        }
    }
}
