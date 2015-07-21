namespace Assertions_Homework
{
    using System;
    using System.Collections;
    using System.Diagnostics;

    public class Assertions
    {
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            // precondition checks
            Debug.Assert(arr != null, "Array is null!");
            Debug.Assert(arr.Length > 0, "Array does not contain elements!");
            var testInput = arr as IEnumerable;
            Debug.Assert(testInput != null, "The given object is not enumerable!");

            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);

                var expectedResult = arr[minElementIndex];
                Swap(ref arr[index], ref arr[minElementIndex]);
            }

            bool isSorted = true;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i].CompareTo(arr[i + 1]) > 0)
                {
                    isSorted = false;
                    break;
                }
            }

            // postcondition checks
            Debug.Assert(isSorted, "Array did not sort!");
        }

        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            // precondition checks
            Debug.Assert(arr != null, "Array is null!");
            Debug.Assert(arr.Length > 0, "Array does not contain elements!");
            var testInput = arr as IEnumerable;
            Debug.Assert(testInput != null, "The given object is not enumerable!");
            bool isSorted = true;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i].CompareTo(arr[i + 1]) > 0)
                {
                    isSorted = false;
                    break;
                }
            }

            Debug.Assert(isSorted, "The given Array is not sorted!");

            int searchedIndex = BinarySearch(arr, value, 0, arr.Length - 1);

            // postcondition checks
            Debug.Assert(searchedIndex >= -1 && searchedIndex < arr.Length, "The returned index was incorrect");
            return searchedIndex;
        }

        public static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            SelectionSort(new int[0]); // Test sorting empty array
            SelectionSort(new int[1]); // Test sorting single element array

            Console.WriteLine(BinarySearch(arr, -1000));
            Console.WriteLine(BinarySearch(arr, 0));
            Console.WriteLine(BinarySearch(arr, 17));
            Console.WriteLine(BinarySearch(arr, 10));
            Console.WriteLine(BinarySearch(arr, 1000));
        }

        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            return minElementIndex;
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            T oldX = x;
            x = y;
            y = oldX;
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }
                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            // Searched value not found
            return -1;
        }
    }
}

