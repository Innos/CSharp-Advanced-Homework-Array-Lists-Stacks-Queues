namespace _01ReverseNumbersWithAStack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ReverseNumbersWithAStack
    {
        public static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            var line = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(line))
            {
                Console.WriteLine();
            }
            else
            {
                var input = line.Split().Select(int.Parse).ToArray();
                foreach (var num in input)
                {
                    stack.Push(num);
                }

                Console.WriteLine(string.Join(" ", stack));
            }           
        }
    }
}
