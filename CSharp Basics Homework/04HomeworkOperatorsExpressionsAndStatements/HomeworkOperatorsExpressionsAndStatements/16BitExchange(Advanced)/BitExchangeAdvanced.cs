using System;

class BitExchangeAdvanced
{
    static void Main(string[] args)
    {
        Console.Write("Input an unsigned 32bit Integer: ");
        uint number = uint.Parse(Console.ReadLine());
        Console.Write("Input position of first bit: ");
        int firstPosition = int.Parse(Console.ReadLine());
        Console.Write("Input position of second bit: ");
        int secondPosition = int.Parse(Console.ReadLine());
        Console.Write("Input length of sequence of bits to exchange: ");
        int length = int.Parse(Console.ReadLine());
        if ((firstPosition > secondPosition && secondPosition + length >= firstPosition) ||(secondPosition > firstPosition && firstPosition + length >= secondPosition) || (firstPosition == secondPosition))
        {
            Console.WriteLine("overlapping");
        }
        else if (firstPosition < 0 || secondPosition < 0 || length < 1 || firstPosition + (length-1) > 31 || secondPosition + (length-1) > 31)
        {
            Console.WriteLine("out of range");
        }
        else
        {
            uint extractionMask = 0;
            for (int i = 0; i < length; i++)
            {
                extractionMask += (uint)Math.Pow(2, i);
            }
            uint tempbytes1 = (number >> firstPosition) & extractionMask;
            uint tempbytes2 = (number >> secondPosition) & extractionMask;
            uint mask = (tempbytes1 << firstPosition) | (tempbytes2 << secondPosition);
            uint modifiedNumber = number ^ mask;
            mask = (tempbytes1 << secondPosition) | (tempbytes2 << firstPosition);
            modifiedNumber = modifiedNumber | mask;
            Console.WriteLine(modifiedNumber);
        }
    }
}

