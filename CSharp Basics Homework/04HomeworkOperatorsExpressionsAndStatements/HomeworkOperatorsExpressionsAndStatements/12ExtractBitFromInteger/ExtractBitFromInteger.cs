using System;

class ExtractBitFromInteger
{
    static void Main(string[] args)
    {
        Console.Write("Input an unsigned Integer: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Input an index: ");
        int index = int.Parse(Console.ReadLine());
        int bit = (number >> index) & 1;
        Console.WriteLine(bit);
    }
}

