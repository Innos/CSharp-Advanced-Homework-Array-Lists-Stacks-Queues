namespace _05PermutationsWithRepetition
{
    using System;
    using System.Runtime.InteropServices;

    public class PermutationsWithRepetition
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input elements in a single line seperated by space");
            string[] numbers = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //for testing purposes
            //string[] numbers = new[] { "1", "3", "5", "5" };

            // it is important that the collection is sorted
            Array.Sort(numbers);

            PermuteWithRepeatingElements(numbers);
        }

        private static void PermuteWithRepeatingElements<T>(T[] elements) where T : IComparable<T>
        {
            while (true)
            {
                Print(elements);

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
                while (elements[secondElement].CompareTo(elements[firstElement]) < 0)
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

        private static void Print<T>(T[] elements)
        {
            Console.WriteLine(string.Join(", ", elements));
        }
    }
}
