using System;
using System.Collections.Generic;
using System.Linq;

class SortedSubsetSums
{
    static void Main()
    {
        bool solutionFound = false;
        int targetSum = int.Parse(Console.ReadLine());
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).Distinct().ToArray();
        //empty iterations of i(iterations that don't pass the where and thus don't select anything) will force the first select to return a null subset 
        //which will get written in subsets, carefull because a null entry doesn't have a first element and will cause an exception when you try to order it.
        //Having .Where(x=>x.Sum() == targetSum is usefull as it would filter the null entries
        var subsets = (from m in Enumerable.Range(1, (1 << numbers.Length) - 1)
                       select
                             (from i in Enumerable.Range(0, numbers.Length)
                              where (m & (1 << i)) != 0
                              select numbers[i])
                             .ToList())
                             .Where(x => x.Sum() == targetSum)
                             .OrderBy(l => l.Count)
                             .ThenBy(l => l.First())
                             .Select(l => l.OrderBy(z => z));
        foreach (var subset in subsets)
        {
            Console.WriteLine("{0} = {1}", String.Join(" + ", subset), targetSum);
            solutionFound = true;
        }
        if (solutionFound == false)
        {
            Console.WriteLine("No matching subsets.");
        }
    }
}