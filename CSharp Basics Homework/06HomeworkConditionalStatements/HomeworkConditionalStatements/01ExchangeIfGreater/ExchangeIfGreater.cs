using System;


class ExchangeIfGreater
{
    static void Main(string[] args)
    {
        Console.Write("Input first number: ");
        double number1 = double.Parse(Console.ReadLine());
        Console.Write("Input second number: ");
        double number2 = double.Parse(Console.ReadLine());
        if (number1 > number2)
        {
            double temp = number2;
            number2 = number1;
            number1 = temp;
        }
        Console.WriteLine("{0} {1}", number1, number2);
    }
}

