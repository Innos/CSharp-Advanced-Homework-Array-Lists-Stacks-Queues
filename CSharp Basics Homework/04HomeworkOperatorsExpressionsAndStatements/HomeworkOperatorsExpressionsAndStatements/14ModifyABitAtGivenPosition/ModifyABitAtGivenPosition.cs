using System;

class ModifyABitAtGivenPosition
{
    static void Main(string[] args)
    {
        Console.Write("Input a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Input a bit value: ");
        byte bitValue = byte.Parse(Console.ReadLine());
        Console.Write("Input position: ");
        int position = int.Parse(Console.ReadLine());
        int modifiedNumber = 0;
        if(bitValue == 1)
        {
            int mask = 1 << position;
            modifiedNumber = number | mask;
        }
        else if(bitValue == 0)
        {
            int mask = ~(1 << position);
            modifiedNumber = number & mask;
        }
        Console.WriteLine(modifiedNumber);
    }
}

