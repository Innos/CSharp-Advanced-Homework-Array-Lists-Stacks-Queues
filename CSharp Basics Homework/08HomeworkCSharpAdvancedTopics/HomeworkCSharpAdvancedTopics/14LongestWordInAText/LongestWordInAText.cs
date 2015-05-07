using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LongestWordInAText
{
    static void Main(string[] args)
    {
        List<string> input = Console.ReadLine().Split(' ','.',',').ToList();
        var result = input.OrderByDescending(a => a.Count());
        Console.WriteLine(result.First());
    }
}

