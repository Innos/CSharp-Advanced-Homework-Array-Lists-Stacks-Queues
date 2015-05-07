using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CountLetters
{
    static void Main(string[] args)
    {
        List<char> list1 = Console.ReadLine().Where(x=>!Char.IsWhiteSpace(x)).ToList();
        list1.Sort();
        foreach (var character in list1.Distinct())
        {
            Console.WriteLine("{0} -> {1}", character, list1.Count(x => x == character));
        }
    }
}

