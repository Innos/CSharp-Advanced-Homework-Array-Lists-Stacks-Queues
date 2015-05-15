using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


class Palindromes
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        //Regex solution with 2 cases for an        odd                        and              an even palindrome
        string pattern = @"(\b(?<N>[^\W_])*[^\W_](?<-N>\k<N>)*(?(N)(?!))\b" + @"|" + @"\b(?<N>[^\W_])+(?<-N>\k<N>)+(?(N)(?!))\b)";
        var matches = Regex.Matches(text,pattern).Cast<Match>().Select(m=>m.Value).OrderBy(x=>x);
        Console.WriteLine(String.Join(", ",matches));

    //String Solution:
    //    WritePalindromes(text);
    }

    //static void WritePalindromes(string text)
    //{
    //    string[] words = text.Split(new char[] { ' ', ',', '!', '?', '.', '-' }, StringSplitOptions.RemoveEmptyEntries);
    //    List<string> palindromes = new List<string>();
    //    foreach (var word in words)
    //    {
    //        if (IsPalindrome(word))
    //        {
    //            palindromes.Add(word);
    //        }
    //    }
    //    palindromes.Sort();
    //    Console.WriteLine(String.Join(", ", palindromes));
    //}

    //static bool IsPalindrome(string word)
    //{
    //    string reverse = String.Concat(word.Reverse());
    //    if(reverse == word)
    //    {
    //        return true;
    //    }
    //    return false;
    //}
}

