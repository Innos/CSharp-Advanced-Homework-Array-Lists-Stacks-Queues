using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


class ExtractHyperlinks
{
    static void Main(string[] args)
    {
        StringBuilder textSB = new StringBuilder();
        string input = Console.ReadLine();
        string pattern = @"(?<=<a\s+(?:[^>]+\s+)?href\s*=\s*)(?:""([^""]*)""|'([^']*)'|([^\s>]+))(?=[^>]*>)";
        while(input != "END")
        {
            textSB.Append(input);
            input = Console.ReadLine();
        }
        string text = textSB.ToString();
        var matches = Regex.Matches(text,pattern);
        foreach (Match hyperlink in matches)
        {
            Console.WriteLine(hyperlink.Value.Trim(new char[]{'\'','\"'}));
        }
    }
}

