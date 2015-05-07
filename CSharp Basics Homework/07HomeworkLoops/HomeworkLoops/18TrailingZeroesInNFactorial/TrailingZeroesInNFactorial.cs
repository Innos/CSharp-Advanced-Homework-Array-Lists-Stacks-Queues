using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class TrailingZeroesInNFactorial
{
    static void Main(string[] args)
    {
        Console.Write("Input an integer n: ");
        BigInteger factorOf5 = 0;
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        while (n > 1)
        {
            factorOf5 = factorOf5 + (n / 5);
            n = n / 5;
        }
        Console.WriteLine("Number of zeroes: {0}", factorOf5);
    }
}

