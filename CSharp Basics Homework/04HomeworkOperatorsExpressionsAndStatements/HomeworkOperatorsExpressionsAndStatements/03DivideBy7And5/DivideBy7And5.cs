using System;

class DivideBy7And5
{
    static void Main(string[] args)
    {
        Console.Write("Input an Integer: ");
        int number = int.Parse(Console.ReadLine());
        bool isDivisible = ((number % 35) == 0);
        Console.WriteLine(isDivisible);
    }
}

