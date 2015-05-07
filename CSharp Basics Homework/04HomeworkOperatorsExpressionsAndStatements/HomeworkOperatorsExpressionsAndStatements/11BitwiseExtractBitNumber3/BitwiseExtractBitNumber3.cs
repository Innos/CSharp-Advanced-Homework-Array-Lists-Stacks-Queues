using System;

class BitwiseExtractBitNumber3
{
    static void Main(string[] args)
    {
        Console.Write("Input an unsigned Integer: ");
        uint number = uint.Parse(Console.ReadLine());
        uint bit = (number >> 3) & 1;
        Console.WriteLine(bit);
    }
}
