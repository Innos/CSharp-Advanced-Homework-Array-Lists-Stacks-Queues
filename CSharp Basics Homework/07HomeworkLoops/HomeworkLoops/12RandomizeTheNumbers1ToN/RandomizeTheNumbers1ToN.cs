using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RandomizeTheNumbers1ToN
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            numbers[i] = i + 1;
        }
        for (int i = numbers.Length - 1; i > 0; i--)
        {
            int element = rnd.Next(i + 1);
            int temp = numbers[i];
            numbers[i] = numbers[element];
            numbers[element] = temp;
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }
}

