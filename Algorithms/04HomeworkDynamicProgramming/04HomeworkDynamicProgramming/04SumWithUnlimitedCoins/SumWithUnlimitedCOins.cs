namespace _04SumWithUnlimitedCoins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    // Answer to third zero test = 16 instead of 18 check the forum for more information
    // Generally the problem can be though of as finding all combinations of X(any amount of) elements from a sequence with repetitions that equal a specific sum, thus an algorithm that will iterate combinations not permutations is needed.
    public class SumWithUnlimitedCoins
    {
        private static int count = 0;

        private static int[] nums;

        //private static List<int> result = new List<int>();

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
            FindCombinations(targetSum, 0);
            Console.WriteLine(count);
        }

        private static void FindCombinations(int targetSum, int currentIndex)
        {
            if (targetSum == 0)
            {
                count++;
                //Console.WriteLine(string.Join(", ", result));
            }
            else if (targetSum > 0)
            {
                for (int i = currentIndex; i < nums.Length; i++)
                {
                    targetSum -= nums[i];
                    //result.Add(nums[i]);
                    FindCombinations(targetSum, i);
                    //result.Remove(nums[i]);
                    targetSum += nums[i];
                }
            }
        }
    }
}
