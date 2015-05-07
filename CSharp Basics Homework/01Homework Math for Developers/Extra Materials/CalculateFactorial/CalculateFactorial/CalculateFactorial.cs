using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input factorial you want to calculate: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger sum = 1;
        for (int i = 1; i <= n; i++)
        {
            sum *= i;
        }
        Console.WriteLine(sum);
    }
}

