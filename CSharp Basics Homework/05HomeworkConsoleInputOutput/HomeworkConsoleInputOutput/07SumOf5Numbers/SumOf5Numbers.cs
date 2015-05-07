using System;

class SumOf5Numbers
{
    static void Main(string[] args)
    {
        Console.Write("Write 5 numbers on a single line seperated only by spaces: ");
        string input = Console.ReadLine();
        double sum = 0;
        double [] numberInDouble = new double[5];
        string[] numbers = input.Split(' ');
        for (int i = 0; i < 5; i++)
        {
            numberInDouble[i] = Convert.ToDouble(numbers[i]);
            sum += numberInDouble[i];
        }
        Console.WriteLine("Sum of the numbers = {0};",sum);
    }
}

