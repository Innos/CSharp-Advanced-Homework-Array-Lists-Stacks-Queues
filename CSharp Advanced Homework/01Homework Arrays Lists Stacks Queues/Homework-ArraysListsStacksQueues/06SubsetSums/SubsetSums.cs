using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SubsetSums
{
    static void Main(string[] args)
    {
        bool solutionFound = false;
        int targetSum = int.Parse(Console.ReadLine());
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        numbers = numbers.Distinct().ToArray();
        var subsets = from m in Enumerable.Range(0, 1 << numbers.Length)
                      select
                            from i in Enumerable.Range(0, numbers.Length)
                            where (m & (1 << i)) != 0
                            select numbers[i];
        foreach (var item in subsets)
        {
            if (item.Sum() == targetSum)
            {
                Console.WriteLine("{0} = {1}", String.Join(" + ", item), targetSum);
                solutionFound = true;
            }

        }
        if (solutionFound == false)
        {
            Console.WriteLine("No matching subsets.");
        }

    }
}

