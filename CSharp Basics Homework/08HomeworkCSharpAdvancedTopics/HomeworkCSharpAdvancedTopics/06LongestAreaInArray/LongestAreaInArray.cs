using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class LongestAreaInArray
{
    static void Main(string[] args)
    {
        int maxStart = 0;
        int max = 0;
        int length = 1;
        int N = int.Parse(Console.ReadLine());
        string[] Filelist = new string[N];
        for (int i = 0; i < N; i++)
        {
            Filelist[i] = Console.ReadLine();
        }
        for (int i = 0; i < Filelist.Length; i++)
        {
            if (i - 1 >= 0 && Filelist[i] == Filelist[i - 1])
                length++;
            else
            {
                length = 1;
            }
            if (length > max)
            {
                max = length;
                maxStart = i - (length - 1);
            }
            
        }
        Console.WriteLine(max);
        for (int i = 0; i < max; i++)
        {
            Console.WriteLine(Filelist[maxStart + i]);
        }
        //string[] Filelist = new string[] { "pear","banana","apple", "banana", "pear" };
        //var list = Filelist.Select((n, i) => new { Value = n, Index = i })
        //    .OrderBy(s => s.Value)
        //    .Select((o, i) => new { Value = o.Value, Diff = i - o.Index })
        //    .GroupBy(s => new { s.Value, s.Diff })
        //    .OrderByDescending(g => g.Count())
        //    .First()
        //    .Select(f => f.Value)
        //    .ToArray();
        //foreach (var entry in list)
        //{
        //    Console.WriteLine(entry);
        //}

        //Select takes all values n and indexes i and instead assigns to this entry an annonymous type (single object read only type, 
        //compiler automaticly assigns types of variables used in it)
        //OrderBy orders the array by a predicate in this situation Value is the value of an entry in the array (ex."apple","banana")
        //Since the entries are strings they are ordered by alphabetical order, numbers would be ordered in ascending fashion (like .Sort())
        //Select the anonymous types and make a new anonymous type (which has Value = the Value variable of the old anonymous type and 
        //Diff = i(current index of the entry) - o.Index(the index of the previous Select and in this case of the original values) 
        //ex. "pear" index 0 gets sorted to position 3 after the .OrderBy so the new index i would be 3, 
        //but o.Inxed which stores it's original index position is 0, so Diff = 0 - 3 = -3 
        //(used to properly group sequences even if sequences with same value exist) i.e. 2 sequences of "apple","apple" will
        //get grouped to different groups because they have different Diff's
        //GroupBy groups the elements in some sort of IEnumerable of type IGrouping(which works like a Dictionary i guess) by Values and Diff's (same Value but different Diffs
        //go into different groups, same Value and same Diff go into same group). The grouping is done so the arrays can be sorted by
        //OrderByDescending with a predicate .Count() (in this situation Count counts the number of entries in a group) and orders them by descending
        //i.e. largest group goes on first position.
        //First returns the first element of the IEnumerable<IGrouping>
        //Selects only the Value variable (because the entries are anonymous types that hold Value and Diff) 
        //ToArray seperates the entries into an array.
    }
}

