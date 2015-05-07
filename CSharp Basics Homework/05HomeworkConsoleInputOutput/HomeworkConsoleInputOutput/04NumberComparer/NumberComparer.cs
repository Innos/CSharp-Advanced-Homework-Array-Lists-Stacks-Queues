using System;

class NumberComparer
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input 2 numbers on 2 seperate lines: ");
        double number1 = double.Parse(Console.ReadLine());
        double number2 = double.Parse(Console.ReadLine());
        Console.WriteLine(Math.Max(number1,number2));
    }
}

