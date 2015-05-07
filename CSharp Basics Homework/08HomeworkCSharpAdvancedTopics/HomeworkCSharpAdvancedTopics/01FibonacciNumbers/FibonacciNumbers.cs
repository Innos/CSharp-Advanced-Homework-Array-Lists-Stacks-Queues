using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class FibonacciNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Fib(n));
    }
    private static BigInteger Fib(int n)
    {
        BigInteger fibN = 0;
        BigInteger fib0 = 1;
        BigInteger fib1 = 1;
        if (n == 0 || n == 1) return fib1;
        else
        {
            for (int i = 2; i <= n; i++)
            {
                fibN = fib0 + fib1;
                fib0 = fib1;
                fib1 = fibN;
            }
            return fibN;
        }
        
    }
}

