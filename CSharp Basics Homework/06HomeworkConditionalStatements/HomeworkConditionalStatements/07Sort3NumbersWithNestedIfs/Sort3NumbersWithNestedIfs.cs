using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Sort3NumbersWithNestedIfs
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input 3 numbers each on a seperate line: ");
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        double num3 = double.Parse(Console.ReadLine());
        if(num1 - num2 == 0 && num2 - num3 == 0)
        {
            Console.WriteLine("{0} {1} {2}",num1,num2,num3);
        }
        else if (num1 - num2 == 0)
        {
            if (num1 > num3)
            {
                Console.WriteLine("{0} {1} {2}", num1, num2, num3);
            }
            else if(num1 < num3)
            {
                Console.WriteLine("{2} {0} {1}", num1, num2, num3);
            }
        }
        else if (num2 - num3 == 0)
        {
            if (num1 > num2)
            {
                Console.WriteLine("{0} {1} {2}", num1, num2, num3);
            }
            else if (num1 < num2)
            {
                Console.WriteLine("{1} {2} {0}", num1, num2, num3);
            }
        }
        else if(num1 > num2 && num1 > num3)
        {
            if(num2 > num3)
            {
                Console.WriteLine("{0} {1} {2}",num1,num2,num3);
            }
            else if(num3 > num2)
            {
                Console.WriteLine("{0} {2} {1}", num1, num2, num3);
            }
        }
        else if(num2 > num1 && num2 > num3)
        {
            if (num1 > num3)
            {
                Console.WriteLine("{1} {0} {2}", num1, num2, num3);
            }
            else if (num3 > num1)
            {
                Console.WriteLine("{1} {2} {0}", num1, num2, num3);
            }
        }
        else if (num3 > num1 && num3 > num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine("{2} {0} {1}", num1, num2, num3);
            }
            else if (num2 > num1)
            {
                Console.WriteLine("{2} {1} {0}", num1, num2, num3);
            }
        }
    }
}

