using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RandomNumbersInGivenRange
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter 3 integers (n,min and max) each on a seperate line (min<=max): ");
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        Random rndGenerator = new Random();
        for (int i = 1; i <= n; i++)
        {
            Console.Write(rndGenerator.Next(min,max+1) + " ");
        }
        Console.WriteLine();
    }
}

