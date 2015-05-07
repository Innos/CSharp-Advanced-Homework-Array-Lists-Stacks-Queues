using System;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input A: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Input B: ");
        int b = int.Parse(Console.ReadLine());
        double c = 0;
        c = Math.Sqrt((a * a) + (b * b));
        Console.WriteLine("C = {0}", c);
    }
}

