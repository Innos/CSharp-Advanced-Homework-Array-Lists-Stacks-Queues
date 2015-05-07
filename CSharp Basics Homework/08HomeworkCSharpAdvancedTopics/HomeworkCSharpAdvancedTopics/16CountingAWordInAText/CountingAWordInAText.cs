using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;


class CountingAWordInAText
{
    static void Main(string[] args)
    {
        Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
        string word = Console.ReadLine().ToLower();
        string input = Console.ReadLine();
        string pattern = string.Format(@"\b{0}\b", word);
        Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
        Match m = r.Match(input);
        int matchCount = 0;
        while (m.Success)
        {
            matchCount++;
            m = m.NextMatch();
        }
        Console.WriteLine(matchCount);
    }
}

