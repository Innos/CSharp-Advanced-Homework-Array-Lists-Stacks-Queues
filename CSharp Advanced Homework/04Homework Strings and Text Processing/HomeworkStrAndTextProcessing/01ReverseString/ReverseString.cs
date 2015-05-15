using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReverseString
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        input = string.Concat(input.Reverse());
        Console.WriteLine(input);
    }
}

