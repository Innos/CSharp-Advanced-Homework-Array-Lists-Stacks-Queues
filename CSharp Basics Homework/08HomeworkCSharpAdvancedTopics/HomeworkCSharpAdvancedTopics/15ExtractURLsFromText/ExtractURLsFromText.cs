using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ExtractURLsFromText
{
    static void Main(string[] args)
    {
        List<string> input = Console.ReadLine().Split(' ').ToList();
        foreach (var item in input.Where(a=> a.Contains("http://") || a.Contains("www.")))
        {
            Console.WriteLine(item);
        }
    }
}

