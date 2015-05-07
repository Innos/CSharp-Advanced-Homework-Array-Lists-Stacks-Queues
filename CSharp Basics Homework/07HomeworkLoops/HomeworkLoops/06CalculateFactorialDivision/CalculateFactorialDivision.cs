using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class CalculateFactorialDivision
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        for (int i = 1; i <= n; i++)
        {
            factorialN = factorialN * i;
            if (i <= k)
            {
                factorialK = factorialK * i;
            }
        }
        Console.WriteLine(factorialN/factorialK);
    }
}

