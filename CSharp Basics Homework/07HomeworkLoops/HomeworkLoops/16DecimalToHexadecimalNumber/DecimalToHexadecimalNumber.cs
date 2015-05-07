using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DecimalToHexadecimalNumber
{
    static void Main(string[] args)
    {
        long digit = 0;
        long number = long.Parse(Console.ReadLine());
        string hexadecimal = "";
        if(number == 0)
        {
            hexadecimal = "0";
        }
        while(number > 0)
        {
            digit = (number % 16);
            switch(digit)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9: hexadecimal = digit.ToString() + hexadecimal; break;
                case 10: hexadecimal = "A" + hexadecimal; break;
                case 11: hexadecimal = "B" + hexadecimal; break;
                case 12: hexadecimal = "C" + hexadecimal; break;
                case 13: hexadecimal = "D" + hexadecimal; break;
                case 14: hexadecimal = "E" + hexadecimal; break;
                case 15: hexadecimal = "F" + hexadecimal; break;
            }
            number = number / 16;
        }
        Console.WriteLine(hexadecimal);
    }
}

