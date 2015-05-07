using System;

class NumbersFrom1ToN
{
    static void Main(string[] args)
    {
        Console.Write("Input an integer: ");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine("Numbers from 1 to {0}:",length);
        for (int i = 1; i <= length; i++)
        {
            Console.WriteLine(i);
        }
    }
}

