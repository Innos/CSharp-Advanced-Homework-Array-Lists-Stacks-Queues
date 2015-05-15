using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


class CountingSubstringOcurrences
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine().ToLower();
        string pattern = Console.ReadLine().ToLower();
        int matches = 0;
        
        //Regex solution
        Regex reg = new Regex(pattern);
        Match match = reg.Match(text);
        while (match.Success)
        {
            match = reg.Match(text, match.Index + 1);
            matches++;
        }

        //String Solution
        //for (int i = 0; i <= text.Length-match.Length; i++)
        //{
        //    string check = text.Substring(i, match.Length);
        //    if (check == match) matches++;
        //}
        Console.WriteLine(matches);
    }
}

