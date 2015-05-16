using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


class SentenceExtractor
{
    static void Main(string[] args)
    {
        string key = Console.ReadLine();
        string pattern = @"([^!.?]*\b" + key + @"\b[^!.?]*[!.?])";
        Regex reg = new Regex(pattern);
        
        string input = Console.ReadLine();
        Match m = reg.Match(input);
        while (m.Success)
        {
            Console.WriteLine(m.Value.Trim());
            m = m.NextMatch();
        }
    }
}

