namespace _07Words
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Words
    {
        private static char[] word;

        private static int counter;

        public static void Main(string[] args)
        {
            word = Console.ReadLine().ToCharArray();
            counter = 0;
            Array.Sort(word);
            PermuteWithRepeatingElements(word);
            Console.WriteLine(counter);

        }

        // finds the unique permutations in lexicographical order of a sorted sequence
        private static void PermuteWithRepeatingElements(char[] elements)
        {
            while (true)
            {
                if (IsCorrect(elements))
                {
                    counter++;
                }

                int firstElement = elements.Length - 2;

                while (firstElement >= 0 && elements[firstElement].CompareTo(elements[firstElement + 1]) >= 0)
                {
                    firstElement--;
                }

                if (firstElement < 0)
                {
                    break;
                }

                int secondElement = elements.Length - 1;
                while (secondElement > firstElement && elements[secondElement].CompareTo(elements[firstElement]) <= 0)
                {
                    secondElement--;
                }

                Swap(ref elements[firstElement], ref elements[secondElement]);

                ReverseArrayInPlace(elements, firstElement + 1, elements.Length - 1);
            }

        }

        private static void ReverseArrayInPlace<T>(T[] array, int start, int end)
        {
            while (start < end)
            {
                T temp = array[start];
                array[start] = array[end];
                array[end] = temp;
                start++;
                end--;
            }
        }

        private static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        private static bool IsCorrect(char[] elements)
        {
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] == elements[i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
