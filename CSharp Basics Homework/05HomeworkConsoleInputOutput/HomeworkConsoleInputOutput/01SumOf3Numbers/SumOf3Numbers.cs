using System;

class SumOf3Numbers
{
    static void Main(string[] args)
    {
        double number1, number2, number3;
        Console.WriteLine("Input 3 real numbers, each on a seperate line: ");
        double.TryParse(Console.ReadLine(), out number1);
        double.TryParse(Console.ReadLine(), out number2);
        double.TryParse(Console.ReadLine(), out number3);
        Console.WriteLine("Sum of {0}, {1} and {2} = {3};", number1, number2, number3, (number1 + number2 + number3));
    }
}

