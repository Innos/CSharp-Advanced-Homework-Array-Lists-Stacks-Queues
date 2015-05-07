using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DecimalToBinaryNumber
{
    static void Main(string[] args)
    {
        long number = long.Parse(Console.ReadLine());
        string binary = "";
        if(number == 0)
        {
            binary = "0";
        }
        while (number > 0)
        {
            binary = ((number % 2).ToString()) + binary;
            number = number / 2;
        }
        Console.WriteLine(binary);
    }
}

