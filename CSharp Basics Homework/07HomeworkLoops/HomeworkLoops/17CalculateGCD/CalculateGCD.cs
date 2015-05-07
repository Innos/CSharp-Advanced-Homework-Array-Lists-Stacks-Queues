using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CalculateGCD
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input 2 integers each on a seperate line:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        if(b>a)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        while(a % b != 0)
        {
            int temp = a % b;
            a = b;
            b = temp;
        }
        Console.WriteLine("GCD = {0}",b);
    }
}

