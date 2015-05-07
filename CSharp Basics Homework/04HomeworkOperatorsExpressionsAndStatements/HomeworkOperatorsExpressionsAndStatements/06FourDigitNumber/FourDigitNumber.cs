using System;

class FourDigitNumber
{
    static void Main(string[] args)
    {
        Console.Write("Input a four digit number: ");
        int number = int.Parse(Console.ReadLine());
        if (number < 1000 || number > 9999)
        {
            Console.WriteLine("Wrong Input");
        }
        else
        {
            Console.WriteLine("Sum of Digits = {0}; ",SumOfDigits(number));
            Console.WriteLine("Reversed = {0}; ",Reversed(number));
            Console.WriteLine("Last Digit in front = {0}; ",LastDigitInFront(number));
            Console.WriteLine("Second and Third Digits exchanged = {0}; ",SecondAndThird(number));

        }
    }

    private static int SumOfDigits(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += (num % 10);
            num = num / 10;
        }
        return sum;
    }

    private static int Reversed(int num)
    {
        int reversed = 0;
        for (int i = 3; i >=0; i--)
        {
            reversed += ((num % 10) * (int)(Math.Pow(10,i)));
            num = num / 10;
        }
        return reversed;
    }

    private static int LastDigitInFront(int num)
    {
        int lastDigit = num % 10;
        int digitInFront = (num / 10) + (lastDigit * 1000);
        return digitInFront;
    }

    private static int SecondAndThird(int num)
    {
        int firstDigit = (num / 1000);
        int secondDigit = (num / 100) % 10;
        int thirdDigit = (num/10) % 10;
        int fourthDigit = num % 10;
        int exchangedNumber = (firstDigit * 1000) + (thirdDigit * 100) + (secondDigit * 10) + (fourthDigit);
        return exchangedNumber;
    }
}

