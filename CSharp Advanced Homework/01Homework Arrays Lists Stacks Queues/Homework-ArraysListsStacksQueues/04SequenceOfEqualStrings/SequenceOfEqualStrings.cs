using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SequenceOfEqualStrings
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        var list = input.GroupBy(x=>x.ToLower());
        foreach (var sequence in list)
        {
            Console.WriteLine(String.Join(" ", sequence));
        }
    }
}

