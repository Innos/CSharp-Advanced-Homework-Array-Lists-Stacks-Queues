using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LastDigitOfNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine(GetLastDigitAsWord(512));
        Console.WriteLine(GetLastDigitAsWord(1024));
        Console.WriteLine(GetLastDigitAsWord(12309));
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

