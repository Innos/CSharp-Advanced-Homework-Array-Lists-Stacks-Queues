using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class UnicodeCharacters
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        Encoding enc8 = Encoding.UTF8;
        foreach (var character in input)
        {

            Console.Write(@"\u{0:X4}",(int)character);
        }
        Console.WriteLine();
    }
}

