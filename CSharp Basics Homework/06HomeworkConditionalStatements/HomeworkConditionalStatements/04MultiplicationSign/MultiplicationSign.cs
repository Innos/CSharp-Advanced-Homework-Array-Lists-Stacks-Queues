using System;

class MultiplicationSign
{
    static void Main(string[] args)
    {
        Console.Write("Input number 1: ");
        double number1 = double.Parse(Console.ReadLine());
        Console.Write("Input number 2: ");
        double number2 = double.Parse(Console.ReadLine());
        Console.Write("Input number 3: ");
        double number3 = double.Parse(Console.ReadLine());
        if (number1 == 0 || number2 == 0 || number3 == 0)
        {
            Console.WriteLine("0");
        }
        else if (number1 > 0)
        {
            if (number2 > 0)
            {
                if (number3 > 0)
                {
                    Console.WriteLine("+");
                }
                else if (number3 < 0)
                {
                    Console.WriteLine("-");
                }
            }
            else if (number2 < 0)
            {
                if (number3 > 0)
                {
                    Console.WriteLine("-");
                }
                else if (number3 < 0)
                {
                    Console.WriteLine("+");
                }
            }
        }
        else if (number1 < 0)
        {
            if (number2 > 0)
            {
                if (number3 > 0)
                {
                    Console.WriteLine("-");
                }
                else if (number3 < 0)
                {
                    Console.WriteLine("+");
                }
            }
            else if (number2 < 0)
            {
                if (number3 > 0)
                {
                    Console.WriteLine("+");
                }
                else if (number3 < 0)
                {
                    Console.WriteLine("-");
                }
            }
        }
    }
}

