using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HexadecimalToDecimalNumber
{
    static void Main(string[] args)
    {
        long Decimal = 0;
        int increment = 0;
        string input = Console.ReadLine();
        while(input.Length > 0)
        {
            int digit = 0;
            char element = input[input.Length - 1];
            input = input.Remove(input.Length - 1);
            switch (element)
            {
                case 'A': digit = 10; break;
                case 'B': digit = 11; break;
                case 'C': digit = 12; break;
                case 'D': digit = 13; break;
                case 'E': digit = 14; break;
                case 'F': digit = 15; break;
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9': digit = int.Parse(element.ToString()); break;
            }
            Decimal = (long)(Decimal + digit*Math.Pow(16,increment));
            increment++;
        }
        Console.WriteLine(Decimal);
    }
}

