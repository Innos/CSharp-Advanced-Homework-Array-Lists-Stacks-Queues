using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LargerThanNeighbours
{
    static void Main(string[] args)
    {
        //Uncoment to check the null tests

        //Console.Write("Example:");
        //int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
        //Console.WriteLine("[{0}]",String.Join(", ", numbers));
        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    Console.WriteLine(IsLargerThanNeighbours(i,numbers));
        //}
        //Console.WriteLine();

        Console.WriteLine("Input a sequence on a single line, each entry seperated by a whitespace");
        int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(i,nums));
        }
    }
    static bool IsLargerThanNeighbours(int position, int[] numbers)
    {
        if ((position == 0 && numbers[position + 1] < numbers[position]) ||
            (position == numbers.Length - 1 && numbers[position - 1] < numbers[position]) ||
            ((position != 0 && position != numbers.Length - 1) && 
            numbers[position] > numbers[position - 1] && numbers[position] > numbers[position + 1]))
        {
            return true;
        }
        return false;
    }
}

