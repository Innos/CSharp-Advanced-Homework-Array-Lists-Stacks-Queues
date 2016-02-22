namespace _01SumAndAverage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumAndAverage
    {
        public static void Main(string[] args)
        {
            string line = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(line))
            {
                Console.WriteLine("Sum=0; Average=0;");
            }
            else
            {
                List<int> numbers = line.Split().Select(int.Parse).ToList();
                Console.WriteLine("Sum={0}; Average={1};", CalculateSum(numbers), CalculateAverage(numbers));

                // Or we could just use LINQ
                //Console.WriteLine("Sum={0}; Average={1};", numbers.Sum(), numbers.Average());
            }
        }

        private static long CalculateSum(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                return 0;
            }
            long sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        private static double CalculateAverage(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                return 0;
            }
            double sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            return sum / numbers.Count;
        }
    }
}
