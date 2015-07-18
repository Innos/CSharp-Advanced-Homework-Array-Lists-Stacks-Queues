using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Original code
class Program
{
    static void Main()
    {
        Console.Write("How many Prime numbers would you like to find: ");
        int findPNumber = int.Parse(Console.ReadLine());
        int[] searchPNumber = new int[findPNumber];
        for (int i = 1; i <= findPNumber; i++)
        {
            Console.Write("Input position you're looking for number {0}:", i);
            searchPNumber[i - 1] = int.Parse(Console.ReadLine());
        }
        int highestP = searchPNumber.Max();
        FindPrime(highestP, searchPNumber, findPNumber);


    }
    public static void FindPrime(int highestP, int[] searchPNumber, int findPNumber)
    {
        int[] pNumbers = new int[1] { 2 };
        int pCount = 1;
        int roof = highestP * highestP;
        for (int prime = 3; prime < roof; prime++)
        {
            int checkEl = (int)Math.Ceiling(Math.Sqrt(prime));
            int[] pNumbersCheck = Array.FindAll(pNumbers, x => x <= checkEl);
            foreach (int element in pNumbersCheck)
            {
                int check = 0;
                check = (prime % element);
                if (check != 0 && element == pNumbersCheck[pNumbersCheck.Length - 1])
                {
                    Array.Resize(ref pNumbers, pNumbers.Length + 1);
                    pNumbers[pCount] = prime;
                    pCount++;
                    if (highestP == pCount)
                    {
                        goto Found;

                    }
                }
                else if (check != 0)
                {
                }
                else if (check == 0)
                {
                    break;
                }


            }
        }
    Found:
        int fRoof = pNumbers[highestP - 1];
        for (int i = 1; i <= searchPNumber.Length; i++)
        {
            int[] result = new int[findPNumber];
            int ease = searchPNumber[i - 1];
            result[i - 1] = pNumbers[ease - 1];
            int[] resultF = FindFibonacci(result, fRoof, highestP);
            int check2 = Array.FindIndex(resultF, item => item == result[i - 1]);
            if (check2 > 0)
            {
                Console.WriteLine("\nPrime number #{0} = {1} and is in position {2} in the Fibonacci sequence", ease, result[i - 1], resultF[check2 - 1]);
            }
            else
            {
                Console.WriteLine("\nPrime number #{0} = {1} and is not part of the Fibonacci sequence", ease, result[i - 1]);
            }
        }
    }

    private static int[] FindFibonacci(int[] result, int fRoof, int highestP)
    {
        int[] positionF = new int[0];
        int resultFCount = 0;
        int fCount = 1;
        int[] fNumbers = new int[2] { 0, 1 };
        for (int i = 2; i < highestP; i++)
        {
            Array.Resize(ref fNumbers, fNumbers.Length + 1);
            fNumbers[i] = fNumbers[i - 2] + fNumbers[i - 1];
            fCount++;
            if (fNumbers[i] > fRoof)
            {
                break;
            }
            else
            {
                int checkF = Array.Find(result, item => item == fNumbers[i]);
                if (checkF > 0)
                {
                    Array.Resize(ref positionF, positionF.Length + 2);
                    positionF[resultFCount] = fCount;
                    positionF[resultFCount + 1] = fNumbers[i];
                    resultFCount++;
                    resultFCount++;
                }
            }

        }
        return positionF;
    }
}


