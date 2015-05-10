using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ActivityTracker
{
    static void Main(string[] args)
    {
        var tracker = new SortedDictionary<int,SortedDictionary<string,List<int>>>();
        int dataLines = int.Parse(Console.ReadLine());
        FillDictionary(tracker, dataLines);
        Print(tracker);
    }

    static void FillDictionary(SortedDictionary<int,SortedDictionary<string,List<int>>> tracker, int dataLines)
    {
        for (int i = 0; i < dataLines; i++)
        {
            //declaration and initialization
            string[] input = Console.ReadLine().Split();
            int month = DateTime.Parse(input[0],new System.Globalization.CultureInfo("bg-BG")).Month;
            string name = input[1];
            int distance = int.Parse(input[2]);
            var names = new SortedDictionary<string, List<int>>();
            var distances = new List<int>();

            //actually adding to the dictionary while checking if entries with same names already exist
            distances.Add(distance);
            names.Add(name, distances);
            if (!tracker.Keys.Contains(month))
            {
                tracker.Add(month, names);
            }
            else
            {
                if (!tracker[month].Keys.Contains(name))
                {
                    tracker[month].Add(name, distances);
                }
                else
                {
                    tracker[month][name].Add(distance);
                }
            }
        }
    }

    static void Print(SortedDictionary<int,SortedDictionary<string,List<int>>> tracker)
    {
        foreach (var dict in tracker)
        {
            Console.Write("{0}: ",dict.Key);
            List<string> line = new List<string>();
            foreach (var dict2 in dict.Value)
            {
                line.Add(String.Format("{0}({1})", dict2.Key, dict2.Value.Sum()));
                
            }
            Console.WriteLine(String.Join(", ", line));
        }
    }
}

