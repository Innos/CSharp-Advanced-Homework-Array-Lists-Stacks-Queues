using System;



class Program
{
    public static int findGCF(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public static int findLCM(int a, int b)
    {
        return ((a * b) / (findGCF(a, b)));
    }

    static void Main()
    {
        int number1, number2;
        Console.Write("Enter 1st number: ");
        number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter 2nd Number: ");
        number2 = int.Parse(Console.ReadLine());
        int result = findLCM(number1, number2);
        Console.WriteLine("LCM = {0}", result);
    }
}

