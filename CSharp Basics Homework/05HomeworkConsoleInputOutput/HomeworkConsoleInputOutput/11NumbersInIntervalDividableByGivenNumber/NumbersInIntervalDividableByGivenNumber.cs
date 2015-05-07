using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main(string[] args)
    {
        Console.Write("Input starting number: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Input ending number: ");
        int end = int.Parse(Console.ReadLine());
        int divisibleNumbers = 0;
        if (start < 0 || end < 0)
        {
            Console.WriteLine("Wrong input");
        }
        else if (start >= end)
        {
            for (int i = start; i >= end; i--)
            {
                if (i % 5 == 0)
                {
                    divisibleNumbers++;
                }
            }
            Console.WriteLine("Numbers divisible by 5 without a remainder between {0} and {1} : {2}", start, end, divisibleNumbers);
        }
        else
        {
            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    divisibleNumbers++;
                }
            }
            Console.WriteLine("Numbers divisible by 5 without a remainder between {0} and {1} : {2}", start, end, divisibleNumbers);
        }
    }
}

