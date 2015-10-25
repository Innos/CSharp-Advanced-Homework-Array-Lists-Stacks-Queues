namespace _05SumWithLimitedCoins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumWithLimitedCoins
    {
        private static int count = 0;

        private static int[] nums;

        private static List<int> result = new List<int>();

        private static List<List<int>> results = new List<List<int>>();

        public static void Main(string[] args)
        {
            int targetSum = int.Parse(Console.ReadLine().Substring(4));
            string coinsString = Console.ReadLine();
            int firstDelimiter = coinsString.IndexOf("{");
            int lastDelimiter = coinsString.IndexOf("}");
            int length = lastDelimiter - firstDelimiter - 1;
            coinsString = coinsString.Substring(firstDelimiter + 1, length);
            nums =
                coinsString.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Array.Sort(nums);
            FindCombinations(targetSum, 0);
            Console.WriteLine(count);
        }

        private static void FindCombinations(int targetSum, int currentIndex)
        {
            if (targetSum == 0)
            {
                if (!Contains(results,result))
                {
                    results.Add(new List<int>(result));
                    count++;
                    Console.WriteLine(string.Join(", ", result));
                }
            }
            else if (targetSum > 0)
            {
                for (int i = currentIndex; i < nums.Length; i++)
                {
                    targetSum -= nums[i];
                    result.Add(nums[i]);
                    FindCombinations(targetSum, i + 1);
                    result.Remove(nums[i]);
                    targetSum += nums[i];
                }
            }
        }

        //keep in mind sequence equals takes into account order (thats why we sort the array with coins in the start)
        private static bool Contains(List<List<int>> containingList ,List<int> listToCheck)
        {
            foreach (var list in containingList)
            {
                if (list.SequenceEqual(listToCheck))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
