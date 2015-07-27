using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03CompareSortingAlgorithms
{
    using System.Diagnostics;
    using System.IO;
    using System.Security.Cryptography.X509Certificates;

    public class CompareSortingAlgorithms
    {
        private static readonly Stopwatch Stopwatch = new Stopwatch();

        private static readonly Random Random = new Random();

        static void Main(string[] args)
        {
            //some tests may stall indefinitely and no results will be writen so an easy way to miss bigger tests
            int amountOfTestsRun = 1;

            //Tests with random filled Arrays
            int[][] tests = new int[8][];

            tests[0] = new int[10];
            tests[1] = new int[50];
            tests[2] = new int[100];
            tests[3] = new int[1000];
            tests[4] = new int[10000];
            tests[5] = new int[100000];
            //tests[6] = new int[1000000];
            //tests[7] = new int[10000000];

            FillArrayRepeating(tests[0]);
            FillArrayRepeating(tests[1]);
            FillArrayRepeating(tests[2]);
            FillArrayRepeating(tests[3]);
            FillArrayRepeating(tests[4]);
            FillArrayRepeating(tests[5]);
            //FillArrayRepeating(tests[6]);
            //FillArrayRepeating(tests[7]);

            string[] times = new string[amountOfTestsRun];
            //Create();

            for (int i = 0; i < amountOfTestsRun; i++)
            {
                Stopwatch.Restart();
                QuickSortRecursive(tests[i],0,tests[i].Length-1);
                times[i] = Stopwatch.Elapsed.ToString();
            }

            Store("QuickRepeating",times);
        }

        public static void Create()
        {
            using (var fs = new FileStream("Results.txt", FileMode.Create))
            {
                using (var writer = new StreamWriter(fs))
                {
                    writer.WriteLine("{0,10}{1,30}{2,30}{3,30}{4,30}{5,30}{6,30}{7,30}{8,30}", "Method", "n=10", "n=50", "n=100", "n=1000", "n=10000", "n=100000", "n=1000000", "n=10000000");
                }
            }
        }

        public static void Store(string tabName, string[]times)
        {
            using (var fs = new FileStream("Results.txt", FileMode.Append))
            {
                using (var writer = new StreamWriter(fs))
                {
                    writer.Write("{0,5}", tabName);
                    foreach (string time in times)
                    {
                        writer.Write("{0,20}",time);
                    }
                    writer.WriteLine();
                }
            }
        }

        public static void FillArrayRandom(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Random.Next(0, 10000000);
            }
        }

        public static void FillArrayReverse(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array.Length - i;
            }
        }

        public static void FillArrayRepeating(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Random.Next(1, 3);
            }
        }

        public static void InsertionSort(int[] array)
        {
            int max = array.Length;
            for (int i = 1; i < max; i++)
            {
                int j = i;
                while (j > 0)
                {
                    if (array[j - 1] > array[j])
                    {
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                        j--;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        public static void SelectSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                var positionOfMin = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[positionOfMin])
                    {
                        //positionOfMin will keep track of the index that min is in, this is needed when a swap happens
                        positionOfMin = j;
                    }
                }
                //if positionOfMin no longer equals i than a smaller value must have been found, so a swap must occur
                if (positionOfMin != i)
                {
                    var temp = array[i];
                    array[i] = array[positionOfMin];
                    array[positionOfMin] = temp;
                }
            }
        }

        static public void MergeSort(int[] array, int left, int right)
        {
            if (right > left)
            {
                var mid = (right + left) / 2;
                MergeSort(array, left, mid);
                MergeSort(array, (mid + 1), right);
                MainMerge(array, left, (mid + 1), right);

            }

        }

        static public void QuickSortRecursive(int[] array, int left, int right)
        {
            // For Recusrion
            if (left < right)
            {
                int pivot = Partition(array, left, right);
                if (pivot > 1)
                {
                    QuickSortRecursive(array, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSortRecursive(array, pivot + 1, right);
                }
            }
        }

        static private int Partition(int[] numbers, int left, int right)
        {
            int pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot)
                {
                    left++;
                }
                while (numbers[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        static private void MainMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[numbers.Length];
            var eol = (mid - 1);
            var pos = left;
            var num = (right - left + 1);
            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid]) temp[pos++] = numbers[left++];
                else
                {
                    temp[pos++] = numbers[mid++];
                }
            }
            while (left <= eol)
            {
                temp[pos++] = numbers[left++];
            }
            while (mid <= right)
            {
                temp[pos++] = numbers[mid++];
            }
            for (int i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
    }
}
