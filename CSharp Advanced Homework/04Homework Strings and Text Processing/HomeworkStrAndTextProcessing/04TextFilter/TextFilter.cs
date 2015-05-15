using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


class TextFilter
{
    static void Main(string[] args)
    {
        string[] bannedWords = Console.ReadLine().Split(new string[]{", "},StringSplitOptions.RemoveEmptyEntries);
        string text = Console.ReadLine();

        //Regex Solution:
        string pattern = "(" + String.Join("|",bannedWords) + ")";
        MatchEvaluator evaluator = new MatchEvaluator(Censor);
        text = Regex.Replace(text, pattern, evaluator);

        //String solution:
        //for (int i = 0; i < bannedWords.Length; i++)
        //    {
        //        text = text.Replace(bannedWords[i],new string('*',bannedWords[i].Length));
        //    }

        Console.WriteLine(text);

   
    }

    static string Censor(Match match)
    {
        string censor = new string('*', match.Length);
        return censor;
    }
}

