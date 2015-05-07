using System;

class TheBiggestOf3Numbers
{
    static void Main(string[] args)
    {
        Console.Write("Input first number: ");
        double number1 = double.Parse(Console.ReadLine());
        Console.Write("Input second number: ");
        double number2 = double.Parse(Console.ReadLine());
        Console.Write("Input third number: ");
        double number3 = double.Parse(Console.ReadLine());
        Console.WriteLine(Math.Max(Math.Max(number1,number2),number3));
    }
}

