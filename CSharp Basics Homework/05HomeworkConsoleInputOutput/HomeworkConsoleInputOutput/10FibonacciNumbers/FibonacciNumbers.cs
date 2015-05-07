using System;

class FibonacciNumbers
{
    static void Main(string[] args)
    {
        int[] fNumbers = new int[2] { 0, 1 };
        Console.Write("Input how many members of the Fibonacci sequence you want to print: ");
        int numbers = int.Parse(Console.ReadLine());
        for (int i = 0; i < numbers; i++)
        {
            Console.Write("{0} ",fNumbers[i]);
            Array.Resize(ref fNumbers, fNumbers.Length + 1);
            fNumbers[i + 2] = fNumbers[i] + fNumbers[i + 1];
        }
        Console.WriteLine();
    }
}

