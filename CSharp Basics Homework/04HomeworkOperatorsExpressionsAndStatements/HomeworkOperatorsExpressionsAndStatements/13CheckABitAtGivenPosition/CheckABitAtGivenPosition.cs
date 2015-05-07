using System;

class CheckABitAtGivenPosition
{
    static void Main(string[] args)
    {
        Console.Write("Input an unsigned Integer: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Input an index: ");
        int index = int.Parse(Console.ReadLine());
        bool isOne = ((number >> index) & 1) == 1;
        Console.WriteLine(isOne);
    }
}

