using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LastDigitOfNumber
{
    static void Main(string[] args)
    {
        //Uncoment to check the null tests

        //int a = 512;
        //int b = 1024;
        //int c = 12309;
        //Console.WriteLine("Examples:");
        //Console.WriteLine(a);
        //Console.WriteLine(GetLastDigitAsWord(a));
        //Console.WriteLine();
        //Console.WriteLine(b);
        //Console.WriteLine(GetLastDigitAsWord(b));
        //Console.WriteLine();
        //Console.WriteLine(c);
        //Console.WriteLine(GetLastDigitAsWord(c));
        //Console.WriteLine();

        Console.Write("Input a number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(GetLastDigitAsWord(num));

    }

    static string GetLastDigitAsWord(int x)
    {
        char lastDigit = x.ToString().Last();
        string word = "";
        switch(lastDigit)
        {
            case '0': word = "zero"; break;
            case '1': word = "one"; break;
            case '2': word = "two"; break;
            case '3': word = "three"; break;
            case '4': word = "four"; break;
            case '5': word = "five"; break;
            case '6': word = "six"; break;
            case '7': word = "seven"; break;
            case '8': word = "eight"; break;
            case '9': word = "nine"; break;
        }
        return word;
    }
}

