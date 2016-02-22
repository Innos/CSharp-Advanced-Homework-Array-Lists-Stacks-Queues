
namespace _04RemoveOddOccurences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveOddOccurences
    {
        public static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();


            Dictionary<int, int> countOfNumbers = new Dictionary<int, int>();
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
                if (number.Value % 2 == 1)
                {
                    list.RemoveAll(x => x == number.Key);
                }
            }

            Console.WriteLine(string.Join(" ", list));



            // With LINQ
            //var group = list.GroupBy(x => x);
            //foreach (var number in group)
            //{
            //    if (number.Count() % 2 == 1)
            //    {
            //        list.RemoveAll(x => x == number.Key);
            //    }
            //}

            //Console.WriteLine(string.Join(" ", list));
        }
    }
}
