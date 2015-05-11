using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FirstLargerThanNeighbours
{
    static void Main(string[] args)
    {
        //Uncoment to check the null tests

        //int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
        //int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
        //int[] sequenceThree = { 1, 1, 1 };

        //Console.WriteLine("Examples:");
        //Console.WriteLine("[{0}]",String.Join(", ",sequenceOne));
        //Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceOne));
        //Console.WriteLine();
        //Console.WriteLine("[{0}]", String.Join(", ", sequenceTwo));
        //Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceTwo));
        //Console.WriteLine();
        //Console.WriteLine("[{0}]", String.Join(", ", sequenceThree));
        //Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceThree));
        //Console.WriteLine();

        Console.WriteLine("Input a sequence on a single line, each entry seperated by a whitespace: ");
        int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(nums));
    }

    static int GetIndexOfFirstElementLargerThanNeighbours(int[] numbers)
    {
        for (int position = 0; position < numbers.Length; position++)
        {
            if ((position == 0 && numbers[position + 1] < numbers[position]) ||
               (position == numbers.Length - 1 && numbers[position - 1] < numbers[position]) ||
               ((position != 0 && position != numbers.Length - 1) &&
               numbers[position] > numbers[position - 1] && numbers[position] > numbers[position + 1]))
            {
                return position;
            }
        }
        return -1;
    }
}

