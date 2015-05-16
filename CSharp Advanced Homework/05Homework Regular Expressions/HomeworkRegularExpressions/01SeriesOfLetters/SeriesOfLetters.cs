using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


class SeriesOfLetters
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string pattern = @"(\w)\1*";
        Regex reg = new Regex(pattern);
        var a = Regex.Replace(input, pattern, "$1");
        Console.WriteLine(a);
    }
}

