using System;

class Rectangle
{
    static void Main(string[] args)
    {
        Console.Write("Input width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Input hight: ");
        double height = double.Parse(Console.ReadLine());
        double perimeter = (2 * width) + (2 * height);
        double area = width * height;
        Console.WriteLine("Width = {0}; Height = {1}; Perimeter = {2}; Area = {3};",width ,height ,perimeter ,area);
    }
}

