using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


class WordCount
{
    static void Main(string[] args)
    {
        Dictionary<string, int> matches = new Dictionary<string, int>();
        List<string> keyWords = new List<string>();

        string words = "../../words.txt";
        string source = "../../text.txt";
        string result = "../../result.txt";

        using (var reader = new StreamReader(words))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                keyWords.Add(line);
            }
        }

        using (var reader = new StreamReader(source))
        {
            using (var writer = new StreamWriter(result))
            {
                string text = reader.ReadToEnd();
                foreach (var keyWord in keyWords)
                {
                    Regex reg = new Regex(@"\b" + keyWord + @"\b",RegexOptions.IgnoreCase);
                    matches[keyWord] = reg.Matches(text).Count;
                }
                var sortedMatches = matches.OrderByDescending(entry => entry.Value);
                foreach (var line in sortedMatches)
                {
                    writer.WriteLine("{0} - {1}", line.Key, line.Value);
                }
            }
        }
    }
}

