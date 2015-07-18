namespace FindPrimeNumbersAndFibonacciSequenceMatch
{
    using System;

    // Reformatted code, keep in mind both .cs files are mains so they have a main method.
    public class PrimeAndFibonacciFinder
    {
        public static void Main()
        {
            Console.Write("Input prime member you're searching for and would like to check if it's a fibonacci number: ");
            int searchedMember = int.Parse(Console.ReadLine());
            int result = FindPrime(searchedMember);
            bool isFibonacci = FindIfNumberIsAFibonacciNumber(result);
            Console.WriteLine("The #{0} prime number is {1} and is {2}a Fibonacci number", searchedMember, result, isFibonacci ? string.Empty : "not ");
        }

        public static int FindPrime(int searchedMember)
        {
            int primeMember = 0;
            int number = 1;
            bool isPrime = true;
            while (primeMember < searchedMember)
            {
                number++;
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    primeMember++;
                }
                isPrime = true;
            }

            return number;
        }

        private static bool FindIfNumberIsAFibonacciNumber(int result)
        {
            int fibonacciOne = 0;
            int fibonacciTwo = 1;
            int fibonacciNext = 0;
            while (fibonacciNext <= result)
            {
                fibonacciNext = fibonacciOne + fibonacciTwo;
                if (result == fibonacciNext)
                {
                    return true;
                }

                fibonacciOne = fibonacciTwo;
                fibonacciTwo = fibonacciNext;
            }

            return false;
        }
    }
}


