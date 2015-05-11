using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BiggerNumber
{
    static void Main(string[] args)
    {
        //Uncoment to check the null tests

        //int a = 4;
        //int b = -5;
        //int c = GetMax(a, b);
        //Console.WriteLine(c);

        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int max = GetMax(firstNumber, secondNumber);
        Console.WriteLine(max);
    }

    static int GetMax(int x, int y)
    {
        return Math.Max(x, y);
    }
}

