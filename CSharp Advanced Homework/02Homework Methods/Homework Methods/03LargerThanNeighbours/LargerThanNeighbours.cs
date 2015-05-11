using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LargerThanNeighbours
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(i,numbers));
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

