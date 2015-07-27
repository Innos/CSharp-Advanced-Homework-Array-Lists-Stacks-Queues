namespace Exams
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Exceptions
    {
        public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
        {
            if (startIndex < 0 || startIndex > arr.Length - 1)
            {
                throw new ArgumentOutOfRangeException("startIndex", "Starting index must be withing the length of the array.");
            }

            if (count < 0 || startIndex + count > arr.Length)
            {
                throw new ArgumentOutOfRangeException("count", "Count must be a non-negative number, and startingIndex + count must be less or equal to the length of the array.");
            }

            List<T> result = new List<T>();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }

            return result.ToArray();
        }

        public static string ExtractEnding(string str, int count)
        {
            if (count > str.Length)
            {
                throw new ArgumentOutOfRangeException("count", "Count must be between 0 and string's length.");
            }

            StringBuilder result = new StringBuilder();
            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }

            return result.ToString();
        }

        public static bool CheckPrime(int number)
        {
            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static void Main()
        {
            try
            {
                var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
                Console.WriteLine(substr);

                var subarr = Subsequence(new[] { -1, 3, 2, 1 }, 0, 2);
                Console.WriteLine(string.Join(" ", subarr));

                var allarr = Subsequence(new[] { -1, 3, 2, 1 }, 0, 4);
                Console.WriteLine(string.Join(" ", allarr));

                var emptyarr = Subsequence(new[] { -1, 3, 2, 1 }, 0, 0);
                Console.WriteLine(string.Join(" ", emptyarr));

                CheckPrime(23);
                Console.WriteLine("23 is prime.");

                Console.WriteLine(ExtractEnding("I love C#", 2));
                Console.WriteLine(ExtractEnding("Nakov", 4));
                Console.WriteLine(ExtractEnding("beer", 4));
                Console.WriteLine(ExtractEnding("Hi", 100));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            List<Exam> peterExams = new List<Exam>()
            {
                new SimpleMathExam(2),
                new CSharpExam(55),
                new CSharpExam(100),
                new SimpleMathExam(1),
                new CSharpExam(0),
            };
            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
    }


}