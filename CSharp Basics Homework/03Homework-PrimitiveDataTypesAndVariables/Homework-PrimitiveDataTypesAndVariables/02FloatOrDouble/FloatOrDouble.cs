using System;


class FloatOrDouble
{
    static void Main()
    {
        Console.Write("Write number:");
        string inputNumber = Console.ReadLine();
        double number = double.Parse(inputNumber);
        if(inputNumber.Length  <= 7 || (inputNumber.Length == 8 && number % 1 != 0))
        {
            number = float.Parse(inputNumber);
            Console.WriteLine("{0} is a float type number",(float)number);
        }
        else
        {
            number = double.Parse(inputNumber);
            Console.WriteLine("{0} is a double type number",number);
        }
    }
}

