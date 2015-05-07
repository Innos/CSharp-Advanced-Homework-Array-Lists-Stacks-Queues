using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TheBiggestOfFiveNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input 5 numbers each at a seperate line:");
        double[] num = new double[5];
        for (int i = 0; i < num.Length; i++)
        {
            num[i] = double.Parse(Console.ReadLine());
        }
        //Console.WriteLine(num.Max());     //Solution with one line, but oh well have your ifs
        if(num[0]>num[1] && num[0] > num[2] && num[0] > num[3] && num[0] > num[4])
        {
            Console.WriteLine(num[0]);
        }
        else if (num[1] > num[0] && num[1] > num[2] && num[1] > num[3] && num[1] > num[4])
        {
            Console.WriteLine(num[1]);
        }
        else if (num[2] > num[0] && num[2] > num[1] && num[2] > num[3] && num[2] > num[4])
        {
            Console.WriteLine(num[2]);
        }
        else if (num[3] > num[0] && num[3] > num[1] && num[3] > num[2] && num[3] > num[4])
        {
            Console.WriteLine(num[3]);
        }
        else if (num[4] > num[0] && num[4] > num[1] && num[4] > num[2] && num[4] > num[3])
        {
            Console.WriteLine(num[4]);
        }
    }
}

