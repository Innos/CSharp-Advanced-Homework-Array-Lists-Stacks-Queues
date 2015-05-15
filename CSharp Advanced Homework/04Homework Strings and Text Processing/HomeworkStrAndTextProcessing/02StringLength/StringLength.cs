using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StringLength
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        if(input.Length > 20)
        {
            input = input.Substring(0, 20);
        }
        else if (input.Length < 20)
        {
            input = input.PadRight(20, '*');
        }
        Console.WriteLine(input);
    }
}
