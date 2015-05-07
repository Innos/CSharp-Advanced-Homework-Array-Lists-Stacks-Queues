using System;

class BitsExchange
{
    static void Main(string[] args)
    {
        Console.Write("Input an unsigned Integer: ");
        uint number = uint.Parse(Console.ReadLine());
        uint tempbytes1 = (number >> 3) & 7;
        uint tempbytes2 = (number >> 24) & 7;
        uint mask = (tempbytes2 << 24) | (tempbytes1 << 3);
        uint modifiedNumber = number ^ mask;
        mask = (tempbytes1 << 24) | (tempbytes2 << 3);
        modifiedNumber = modifiedNumber | mask;
        Console.WriteLine(modifiedNumber);
    }
}

