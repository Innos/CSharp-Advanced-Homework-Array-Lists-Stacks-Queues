using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


class LittleJohn
{
    static void Main(string[] args)
    {
        //string smallArrow = ">----->";
        //string mediumArrow = ">>----->";
        //string largeArrow = ">>>----->>";
        int lArrows = 0;
        int mArrows = 0;
        int sArrows = 0;
        string text = "";
        for (int i = 0; i < 4; i++)
        {
            string input = Console.ReadLine();
            text = text + input + '\n';
        }
        string pattern = @"(>>>----->>)|(>>----->)|(>----->)";
        MatchCollection matches = Regex.Matches(text, pattern);
        foreach (Match match in matches)
        {
            if (match.Groups[1].Length > 0) lArrows++;
            if (match.Groups[2].Length > 0) mArrows++;
            if (match.Groups[3].Length > 0) sArrows++;
        }
        int arrows = int.Parse(String.Format("{0}{1}{2}", sArrows, mArrows, lArrows));

        string binaryArrows = Convert.ToString(arrows, 2);
        string reversedArrows = new string(binaryArrows.Reverse().ToArray());
        string codedMessage = binaryArrows + reversedArrows;

        long result = Convert.ToInt64(codedMessage, 2);

        Console.WriteLine(result);
    }
}

