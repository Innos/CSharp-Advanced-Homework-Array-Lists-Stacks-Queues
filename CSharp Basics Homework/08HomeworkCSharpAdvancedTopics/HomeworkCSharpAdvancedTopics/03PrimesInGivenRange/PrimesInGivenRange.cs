using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrimeCheck
{
    public int n { get; set; }

    public bool IsPrime(int n)
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
                if (n % i == 0)
                {
                    Prime = false;
                    return Prime;
                }
            }
            return Prime;
        }
    }
}

class PrimesInGivenRange
{
    static void Main(string[] args)
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        List<int> primes = FindPrimesInRange(start, end);
        foreach(var entry in primes)
        {
            if(entry != primes.Last()) Console.Write("{0}, ", entry);
            else Console.Write(entry);
        }
    }
    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primes = new List<int>();
        for (int i = startNum; i <= endNum; i++)
        {
            PrimeCheck check = new PrimeCheck() { n = i };
            if(check.IsPrime(check.n))
            {
                primes.Add(i);
            }
        }
        return primes;
    }
}

