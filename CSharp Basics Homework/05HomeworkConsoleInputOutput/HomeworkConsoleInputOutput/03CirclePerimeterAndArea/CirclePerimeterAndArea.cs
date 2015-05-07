using System;

class CirclePerimeterAndArea
{
    static void Main(string[] args)
    {
        Console.Write("Input radius: ");
        double radius = double.Parse(Console.ReadLine());
        Console.WriteLine("Perimeter is {0:F2}; Area is {1:F2};",((2*Math.PI)*radius),Math.PI*(Math.Pow(radius,2)));
    }
}

