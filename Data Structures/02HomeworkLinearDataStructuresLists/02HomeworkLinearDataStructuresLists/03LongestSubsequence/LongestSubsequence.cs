namespace _03LongestSubsequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LongestSubsequence
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var result = FindLongestSubsequence(numbers);
            Console.WriteLine(string.Join(" ", result));

        }

        public static List<int> FindLongestSubsequence(List<int> numbers)
        {
            var max = 1;
            var number = numbers[0];
            var current = 1;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    current++;
                    if (current > max)
                    {
                        number = numbers[i];
                        max = current;
                    }
                }
                else
                {             
                    current = 1;
                }
            }

            var list = new List<int>();
            for (int i = 0; i < max; i++)
            {
                list.Add(number);
            }
            return list;
        }
    }
}
