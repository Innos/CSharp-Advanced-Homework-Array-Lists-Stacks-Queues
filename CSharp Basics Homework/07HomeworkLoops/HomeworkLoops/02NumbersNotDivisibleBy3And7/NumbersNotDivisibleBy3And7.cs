using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NumbersNotDivisibleBy3And7
{
    static void Main(string[] args)
    {
        Console.Write("Input a positive integer: ");
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            if(i % 3 != 0 && i % 7 != 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}

