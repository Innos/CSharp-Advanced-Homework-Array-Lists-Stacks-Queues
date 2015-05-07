using System;



class OddOrEvenIntegers
{
    static void Main(string[] args)
    {
        Console.Write("Input a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(number % 2 == 0 ? "Even" : "Odd");
    }
}

