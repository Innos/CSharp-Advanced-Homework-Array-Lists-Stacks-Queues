using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class PrimeChecker
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(IsPrime(n));
    }
    public static bool IsPrime(int n)
    {
        bool Prime = true;
        if (n == 0 || n == 1)
        {
            Prime = false;
            return Prime;
        }
        else
        {
            for (int i = 2; i <= (Math.Sqrt((double)n)); i++)
            {
                if(n % i == 0)
                {
                    Prime = false;
                    return Prime;
                }
            }
            return Prime;
        }
    }
}

