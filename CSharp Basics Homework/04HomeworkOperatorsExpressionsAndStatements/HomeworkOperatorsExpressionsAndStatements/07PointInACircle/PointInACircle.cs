using System;

class PointInACircle
{
    static void Main(string[] args)
    {
        Console.Write("Input x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Input y: ");
        double y = double.Parse(Console.ReadLine());
        double radius = (double)2;
        if (Math.Pow(x,2) + Math.Pow(y,2) <= Math.Pow(radius,2))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}

