using System;

class ThirdDigitIs7
{
    static void Main(string[] args)
    {
        Console.Write("Input number to be checked: ");
        int number = int.Parse(Console.ReadLine());
        bool isSeven = ((number / 100) % 10) == 7;
        Console.WriteLine(isSeven);
    }
}

