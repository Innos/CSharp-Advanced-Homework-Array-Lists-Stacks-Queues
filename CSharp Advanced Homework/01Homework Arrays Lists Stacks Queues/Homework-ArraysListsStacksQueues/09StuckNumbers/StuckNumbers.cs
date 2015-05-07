using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StuckNumbers
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = input.Select(int.Parse).ToArray();
        GenerateFourDigitSubsets(numbers, input);

    }

    static void GenerateFourDigitSubsets(int[] numbers, string[] input)
    {
        bool hasSolution = false;
        List<List<int>> subsets = new List<List<int>>();
        for (int i1 = 0; i1 < numbers.Length; i1++)
        {
            for (int i2 = 0; i2 < numbers.Length; i2++)
            {
                if (i1 != i2)
                {
                    for (int i3 = 0; i3 < numbers.Length; i3++)
                    {
                        for (int i4 = 0; i4 < numbers.Length; i4++)
                        {
                            int a = numbers[i1];
                            int b = numbers[i2];
                            int c = numbers[i3];
                            int d = numbers[i4];
                            if (AreDifferent4(a, b, c, d) &&
                            AreEqual((input[i1] + input[i2]), (input[i3] + input[i4])))
                            {
                                Console.WriteLine("{0}|{1}=={2}|{3}", a, b, c, d);
                                hasSolution = true;
                            }
                        }
                    }
                }

            }
        }
        if (hasSolution == false)
        {
            Console.WriteLine("No");

        }
    }


    private static bool AreDifferent4(int a, int b, int c, int d)
    {
        bool isValid = (a != b
                     && a != c
                     && a != d
                     && b != c
                     && b != d
                     && c != d);
        return isValid;
    }
    static bool AreEqual(string a, string b)
    {
        bool isValid = (a.Equals(b));
        return isValid;
    }
}

