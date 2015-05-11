using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;


class GenericArraySort
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("bg-BG");

        //Uncomment for null tests

        //Console.WriteLine("Examples:");
        //int[]numbers = {1,2,3,4,5,1,0,5};
        //string[] strings = { "zaz", "cba", "baa", "azis"};
        //DateTime[] dates = { new DateTime(2002, 3, 1), new DateTime(2015, 5, 6), new DateTime(2014, 1, 1) };
        //Console.WriteLine(String.Join(", ", numbers));
        //Console.WriteLine(String.Join(", ", strings));
        //Console.WriteLine(String.Join(", ", dates));
        //Console.WriteLine();

        //BubbleSort(ref numbers);
        //BubbleSort(ref strings);
        //BubbleSort(ref dates);

        //Console.WriteLine("After Sort:");
        //Console.WriteLine(String.Join(", ",numbers));
        //Console.WriteLine(String.Join(", ", strings));
        //Console.WriteLine(String.Join(", ", dates));
        //Console.WriteLine();

        Console.WriteLine("Choose an array type: \n1.Integer\n2.String\n3.DateTime(BG format)");
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine("Input the array on a single line, each entry seperated by a whitespace:");
        int[] a;
        string[] b;
        DateTime[] c;
        switch(choice)
        {
            case 1: 
                a = Console.ReadLine().Split().Select(int.Parse).ToArray();
                BubbleSort(ref a);
                Console.WriteLine(String.Join(", ", a));
                break;

            case 2:
                b = Console.ReadLine().Split();
                BubbleSort(ref b);
                Console.WriteLine(String.Join(", ", b));
                break;

            case 3:
                c = Console.ReadLine().Split().Select(DateTime.Parse).ToArray();
                BubbleSort(ref c);
                Console.WriteLine(String.Join(", ", c));
                break;

            default: Console.WriteLine("Incorrect Input");
                break;
        }
        
    }
    static void BubbleSort<T>(ref T[] elements) where T : System.IComparable<T>
    {
        bool swapped = false;

        do
        {
            swapped = false;
            for (int i = 0; i < elements.Length - 1; i++)
            {
                if (elements[i].CompareTo(elements[i+1]) > 0)
                {
                    T swap = elements[i];
                    elements[i] = elements[i + 1];
                    elements[i + 1] = swap;
                    swapped = true;
                }
            }

        } while (swapped == true);
    }

}

