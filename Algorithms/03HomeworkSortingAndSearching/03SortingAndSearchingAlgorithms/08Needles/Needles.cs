namespace _08Needles
{
    using System;
    using System.Linq;

    public class Needles
    {
        public static void Main(string[] args)
        {
            string tokens = Console.ReadLine();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] needles = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < needles.Length; i++)
            {
                int zeroes = 0;
                bool isFound = false;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (needles[i] <= numbers[j])
                    {
                        Console.Write(j - zeroes + " ");
                        isFound = true;
                        break;
                    }

                    if (numbers[j] == 0)
                    {
                        zeroes++;
                    }
                    else
                    {
                        zeroes = 0;
                    }
                }
                if (!isFound)
                {
                    Console.Write(numbers.Length-zeroes + " ");
                }
            }
        }
    }
}
