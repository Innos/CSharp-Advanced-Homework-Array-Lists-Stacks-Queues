using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BinaryToDecimalNumber
{
    static void Main(string[] args)
    {
        long Decimal = 0;
        int increment = 0;
        string input = Console.ReadLine();
        while(input.Length > 0)
        {
            int digit = int.Parse(input[input.Length - 1].ToString());
            input = input.Remove(input.Length - 1);
            Decimal = (long)(Decimal + digit * Math.Pow(2, increment));
            increment++;
        }
        Console.WriteLine(Decimal);
    }
}

