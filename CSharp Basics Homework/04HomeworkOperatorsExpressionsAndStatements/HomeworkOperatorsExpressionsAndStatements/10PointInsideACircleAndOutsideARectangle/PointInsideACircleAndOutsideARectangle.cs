using System;

class PointInsideACircleAndOutsideARectangle
{
    static void Main(string[] args)
    {
        Console.Write("Input x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Input y: ");
        double y = double.Parse(Console.ReadLine());
        if (isInCircle(x,y) == true && isInRectangle(x,y) == false)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }

    private static bool isInRectangle(double x, double y)
    {
        if (x >= -1 && x <= 5 && y <= 1 && y >= -1)
        {
            return true;
        }
        return false;
    }

    private static bool isInCircle(double x, double y)
    {
        if(Math.Pow((x-1),2) + Math.Pow((y-1),2) <= Math.Pow(1.5,2))
        {
            return true;
        }
        return false;
    }
}

