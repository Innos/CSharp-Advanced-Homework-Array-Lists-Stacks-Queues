using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CountSymbols
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        SortedSet<char> set = new SortedSet<char>(input);
        var result = input.GroupBy(x => x).OrderBy(x => x.First());

   
        //LINQ does it in one line and without the logical checks

        //SortedDictionary<char, int> dict = new SortedDictionary<char, int>();
        //for (int i = 0; i < input.Length; i++)
        //{
        //    if (!dict.Keys.Contains(input[i]))
        //    {
        //        dict.Add(input[i], 1);
        //    }
        //    else
        //    {
        //        dict[input[i]] = dict[input[i]] + 1;
        //    }
        //}


        foreach (var item in result)
        {
            Console.WriteLine("{0}: {1} time/s", item.First(),item.Count());
        }
    }
}

