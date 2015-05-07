using System;



class ComparingFloats
{
    static void Main(string[] args)
    {
        bool isEqual = false;
        double eps = 0.000001;
        Console.Write("Enter first Number:");
        double number1 = double.Parse(Console.ReadLine());
        Console.Write("Enter second Number:");
        double number2 = double.Parse(Console.ReadLine());
        double result = Math.Abs(number1 - number2);
        if (result < eps)
        {
            isEqual = true;
        }
        Console.WriteLine("Is Equal = {0} \nNumber 1 = {1}; Number 2 = {2}; Difference = {3};", isEqual, number1, number2, result);
    }
}

