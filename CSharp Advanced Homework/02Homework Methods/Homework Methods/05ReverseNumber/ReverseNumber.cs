using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReverseNumber
{
    static void Main(string[] args)
    {
        //double n1 = 256;
        //double n2 = 123.45;
        //double n3 = 0.12;
        double num = double.Parse(Console.ReadLine());
        double reversed = GetReversedNumber(num);

        Console.WriteLine(reversed);
    }

    static double GetReversedNumber(double num)
    {
        var reverse = num.ToString().Reverse();
        string number = String.Join("", reverse);
        num = double.Parse(number);
        return num;
    }
}

