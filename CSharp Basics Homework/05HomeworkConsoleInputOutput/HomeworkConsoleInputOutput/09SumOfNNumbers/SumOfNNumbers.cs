using System;

class SumOfNNumbers
{
    static void Main(string[] args)
    {
        double sum = 0;
        Console.Write("Input amount of numbers you would like to sum: ");
        int numbers = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter {0} numbers each on a seperate line:",numbers);
        for (int i = 1; i <= numbers; i++)
        {
            double currentNumber = double.Parse(Console.ReadLine());
            sum += currentNumber;
        }
        Console.WriteLine("Sum of the numbers is {0};",sum);
    }
}

