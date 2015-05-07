using System;

class Trapezoids
{
    static void Main(string[] args)
    {
        Console.Write("Input Side A: ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Input Side B: ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Input height: ");
        double height = double.Parse(Console.ReadLine());
        double area = (sideA + sideB) * (height / 2);
        Console.WriteLine("Area = {0};", area);
    }
}

