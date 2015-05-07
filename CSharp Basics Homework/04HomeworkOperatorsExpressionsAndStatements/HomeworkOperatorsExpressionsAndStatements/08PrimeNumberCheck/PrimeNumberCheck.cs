using System;

class PrimeNumberCheck
{
    static void Main(string[] args)
    {
        Console.Write("Input a positive integer: ");
        int number = int.Parse(Console.ReadLine());
        if (number <= 1)
        {
            Console.WriteLine("False");
        }
        else
        {
            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); i++)
            {
                if (number % i == 0 && number != i)
                {
                    Console.WriteLine("False");
                    break;
                }
                else if (i == Math.Ceiling(Math.Sqrt(number)))
                {
                    Console.WriteLine("True");
                }
            }
        }
    }
}

