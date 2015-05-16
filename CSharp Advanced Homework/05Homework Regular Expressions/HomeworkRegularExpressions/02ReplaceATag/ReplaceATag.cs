using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


class ReplaceATag
{
    static void Main(string[] args)
    {
        string input = "<ul> <li> <a href=http://softuni.bg>SoftUni</a> </li> </ul>";
        string pattern = @"<a href=(?:(?<link>[^>]*))>(?:(?<name>\w*))<\/a>";
        Regex reg = new Regex(pattern);
        var result = Regex.Replace(input, pattern, "[URL href=${link}]${name}[/URL]");
        Console.WriteLine(result);
    }
}

