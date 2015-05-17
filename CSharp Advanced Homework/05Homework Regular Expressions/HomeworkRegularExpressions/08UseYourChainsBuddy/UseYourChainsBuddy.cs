using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


class UseYourChainsBuddy
{
    static void Main(string[] args)
    {
        Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
        StringBuilder textSB = new StringBuilder();
        string input = Console.ReadLine();
        string pattern = @"(?<=<p>).*?(?=</p>)";
        MatchCollection matches = Regex.Matches(input, pattern);
        MatchEvaluator evaluator = new MatchEvaluator(SwitchLetter);
        foreach(Match match in matches)
        {
            var text = match.Value;
            text = Regex.Replace(text, @"[^a-z0-9]+", " ");
            text = Regex.Replace(text, @"\s+", " ");
            text = Regex.Replace(text, @"([a-z])", evaluator);
            textSB.Append(text);
        }
        var result = textSB.ToString();
        Console.WriteLine(result);
        
    }

    static string SwitchLetter(Match match)
    {
        char letter = match.Value.First();
        if(letter < 'n')
        {
            letter = (char)(letter + 13);
        }
        else
        {
            letter = (char)(letter - 13);
        }
        return letter.ToString();
    }
}

