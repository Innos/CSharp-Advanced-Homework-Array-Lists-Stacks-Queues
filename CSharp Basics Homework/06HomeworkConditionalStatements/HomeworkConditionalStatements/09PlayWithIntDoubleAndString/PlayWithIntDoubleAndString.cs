using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PlayWithIntDoubleAndString
{
    static void Main(string[] args)
    {
        Console.Write("Please choose a type [1 -> Int; 2 -> Double; 3 -> String;]: ");
        int type = int.Parse(Console.ReadLine());
        if(type == 1)
        {
            Console.Write("Please enter an Integer: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(input + 1);
        }
        else if (type == 2)
        {
            Console.Write("Please enter a Double: ");
            double input = double.Parse(Console.ReadLine());
            Console.WriteLine(input + 1);
        }
        else if (type == 3)
        {
            Console.Write("Please enter a String: ");
            string input = Console.ReadLine();
            Console.WriteLine(input + "*");
        }
    }
}

