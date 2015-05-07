using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NumbersFrom1ToN
{
    static void Main(string[] args)
    {
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}

