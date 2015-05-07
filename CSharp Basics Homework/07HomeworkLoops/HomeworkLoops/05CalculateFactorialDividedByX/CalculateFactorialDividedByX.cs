using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class CalculateFactorialDividedByX
{
    static void Main(string[] args)
    {
        int factorial = 1;
        double sum = 1;
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            factorial = factorial * i;
            sum = sum + ((double)factorial/Math.Pow(x,i));
        }
        Console.WriteLine("{0:0.00000}",sum);
    }
}

