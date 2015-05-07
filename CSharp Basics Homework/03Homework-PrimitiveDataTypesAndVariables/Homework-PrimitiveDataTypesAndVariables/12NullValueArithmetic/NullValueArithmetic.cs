using System;

class NullValueArithmetic
{
    static void Main(string[] args)
    {
        int? number1 = null;
        double? number2 = null;
        Console.WriteLine("Number1 = {0}; Number2 = {1};",number1, number2);
        number1 = number1 + null;
        number2 = number2 + null;
        Console.WriteLine("Number1 = {0}; Number2 = {1};", number1, number2);
        number1 = number1 + 30;
        number2 = number2 + 55.5;
        Console.WriteLine("Number1 = {0}; Number2 = {1};", number1, number2);
    }
}

