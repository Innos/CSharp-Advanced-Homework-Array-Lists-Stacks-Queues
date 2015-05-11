using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;


class ActivityTracker
{
    static void Main(string[] args)
    {
        //Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        var tracker = new SortedDictionary<int,SortedDictionary<string,int>>();
        FillDictionary(tracker);
        Print(tracker);
    }

    static void FillDictionary(SortedDictionary<int,SortedDictionary<string,int>> tracker)
    {
        int dataLines = int.Parse(Console.ReadLine());
        CultureInfo ci = CultureInfo.CreateSpecificCulture("bg-BG");
        for (int i = 0; i < dataLines; i++)
        {
            //declaration and initialization
            string[] input = Console.ReadLine().Split();
            int month = DateTime.Parse(input[0], ci).Month;
            string name = input[1];
            int distance = int.Parse(input[2]);

            //actually adding to the dictionary while checking if entries with same names already exist

            if (!tracker.ContainsKey(month))
            {
                var names = new SortedDictionary<string,int>();
                names.Add(name, distance);
                tracker.Add(month, names);
            }
            else
            {
                if (!tracker[month].ContainsKey(name))
                {
                    tracker[month].Add(name, distance);
                }
                else
                {
                    tracker[month][name] = tracker[month][name] + distance;
                }
            }
        }
    }

    static void Print(SortedDictionary<int,SortedDictionary<string,int>> tracker)
    {
        foreach (var dict in tracker)
        {
            Console.Write("{0}: ",dict.Key);
            List<string> line = new List<string>();
            foreach (var dict2 in dict.Value)
            {
                line.Add(String.Format("{0}({1})", dict2.Key, dict2.Value));
                
            }
            Console.WriteLine(String.Join(", ", line));
        }
    }
}

