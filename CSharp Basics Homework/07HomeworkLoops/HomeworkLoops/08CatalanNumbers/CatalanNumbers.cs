using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class CatalanNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorial2N = 1;
        BigInteger catalanNumberN = 1;
        for (int i = 1; i <= (2 * n); i++)
        {
            factorial2N = factorial2N * i;
            if (i <= n)
            {
                factorialN = factorialN * i;
            }
        }
        catalanNumberN = factorial2N / ((factorialN * (n + 1)) * factorialN);
        Console.WriteLine(catalanNumberN);
    }
}

