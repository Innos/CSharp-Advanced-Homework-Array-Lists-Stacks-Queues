namespace _02SortWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortWords
    {
        public static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();
            Sort(words);
            Console.WriteLine(string.Join(" ",words));
        }

        public static void Sort<T>(List<T> collection) where T:IComparable<T>
        {
            Quicksort(collection, 0, collection.Count - 1);
        }

        private static void Swap<T>(List<T> collection, int indexA, int indexB)
        {
            T temp = collection[indexA];
            collection[indexA] = collection[indexB];
            collection[indexB] = temp;
        }

        private static void Quicksort<T>(List<T> collection, int start, int end) where T: IComparable<T>
        {
            if (start < end)
            {
                int pivot = Partition(collection, start, end);
                Quicksort(collection, start, pivot);
                Quicksort(collection, pivot + 1, end);
            }
        }

        private static int Partition<T>(List<T> collection, int start, int end) where T: IComparable<T>
        {
            // mid index is a better pivot point 
            int midIndex = (start + end) / 2;
            T pivot = collection[midIndex];
            int low = start - 1;
            int high = end + 1;
            while (true)
            {
                do
                {
                    low += 1;
                }
                while (collection[low].CompareTo(pivot) < 0);

                do
                {
                    high -= 1;
                }
                while (collection[high].CompareTo(pivot) > 0);

                if (low < high)
                {
                    Swap(collection, low, high);
                }
                else
                {
                    return high;
                }
            }

        }
    }
}
