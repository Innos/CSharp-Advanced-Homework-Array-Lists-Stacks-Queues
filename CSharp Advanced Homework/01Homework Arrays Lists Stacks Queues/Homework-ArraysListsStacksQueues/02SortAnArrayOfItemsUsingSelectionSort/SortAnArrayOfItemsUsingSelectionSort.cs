using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace az
{


    class SortAnArrayOfItemsUsingSelectionSort
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            SelectionSort(input);
            Console.WriteLine(String.Join(" ", input));
        }
        static void SelectionSort(int[] numbers)
        {

            for (int firstUnsortedPosition = 0; firstUnsortedPosition < numbers.Length - 1; firstUnsortedPosition++)
            {
                int min = numbers[firstUnsortedPosition];
                int position = firstUnsortedPosition;
                for (int l = firstUnsortedPosition + 1; l < numbers.Length; l++)
                {
                    if (numbers[l] < min)
                    {
                        min = numbers[l];
                        position = l;
                    }
                }
                int swap = numbers[firstUnsortedPosition];
                numbers[firstUnsortedPosition] = min;
                numbers[position] = swap;
            }
        }
    }
}

