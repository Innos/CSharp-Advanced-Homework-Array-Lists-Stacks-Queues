namespace _02GeneratePermutationsIteratively
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    // Generate permutations without repetition
    public class GeneratePermutationsIteratively
    {
        public static void Main(string[] args)
        {
            Console.Write("Input ammount of elements:");
            int ammount = int.Parse(Console.ReadLine());
            int[] numbers = Enumerable.Range(1, ammount).ToArray();

            //GeneratePermutations(numbers, ammount);
            Print(GeneratePermutations(new List<int>(numbers)));
        }

        private static void GeneratePermutations(int[] numbers, int ammount)
        {
            int[] permutation = new int[ammount];
            int i = 1;
            Console.WriteLine(string.Join(", ", numbers));
            while (i < ammount)
            {
                if (permutation[i] < i)
                {
                    int j = 0;

                    // is odd
                    if (i % 2 == 1)
                    {
                        j = permutation[i];
                    }

                    Swap(ref numbers[i], ref numbers[j]);
                    Console.WriteLine(string.Join(", ", numbers));
                    permutation[i]++;
                    i = 1;
                }
                else
                {
                    permutation[i] = 0;
                    i++;
                }

            }
        }

        private static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        // alternative way to iteratively generate permutations without repetition using lists
        private static List<List<T>> GeneratePermutations<T>(List<T> source)
        {
            List<List<T>> permutations = new List<List<T>>();
            permutations.Add(new List<T>());
            permutations[0].Add(source[0]);
            for (int i = 1; i < source.Count; i++)
            {
                T element = source[i];

                for (int j = permutations.Count - 1; j >= 0; j--)
                {
                    List<T> permList = permutations[j];
                    permutations.RemoveAt(j);

                    for (int k = permList.Count; k >= 0; k--)
                    {
                        List<T> tempPermutation = new List<T>(permList);
                        tempPermutation.Insert(k, element);
                        permutations.Add(tempPermutation);
                    }
                }
            }
            return permutations;
        }
        // printing for iterative list method
        private static void Print<T>(List<List<T>> result)
        {
            foreach (var list in result)
            {
                Console.WriteLine(string.Join(", ", list));
            }
        }
    }
}
