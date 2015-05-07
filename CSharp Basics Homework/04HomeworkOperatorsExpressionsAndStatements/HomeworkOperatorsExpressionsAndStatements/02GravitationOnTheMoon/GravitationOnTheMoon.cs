using System;

class GravitationOnTheMoon
{
    static void Main(string[] args)
    {
        Console.Write("Input weight on Earth: ");
        double weight = double.Parse(Console.ReadLine());
        Console.WriteLine("The weight on the Moon would be {0}.", weight * 0.17);
    }
}

