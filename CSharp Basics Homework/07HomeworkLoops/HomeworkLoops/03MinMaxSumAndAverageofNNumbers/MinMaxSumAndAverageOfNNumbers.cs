using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MinMaxAndAverageOfNNumbers
{
    static void Main(string[] args)
    {
        int min = int.MaxValue;
        int max = int.MinValue;
        int sum = 0;
        double average = 0;
        int amount = int.Parse(Console.ReadLine());
        int[] numbers = new int[amount];
        for (int i = 0; i < amount; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
            if(numbers[i] > max)
            {
                max = numbers[i];
            }
            sum = sum + numbers[i];
        }
        average = ((double)sum / numbers.Length); 
        Console.WriteLine("Min = {0}; Max = {1}; Sum = {2}; Average = {3:0.00};",min,max,sum,average);
    }
}

