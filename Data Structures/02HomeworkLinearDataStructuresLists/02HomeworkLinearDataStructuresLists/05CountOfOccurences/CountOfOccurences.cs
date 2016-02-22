namespace _05CountOfOccurences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountOfOccurences
    {
        public static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();


            SortedDictionary<int, int> countOfNumbers = new SortedDictionary<int, int>();
            foreach (var num in list)
            {
                if (!countOfNumbers.ContainsKey(num))
                {
                    countOfNumbers.Add(num, 0);
                }

                countOfNumbers[num]++;
            }
            foreach (var number in countOfNumbers)
            {
                Console.WriteLine("{0} -> {1} times", number.Key, number.Value);
            }
        }
    }
}
