
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NumberCalculations
{
    static void Main(string[] args)
    {
        //Uncoment to check the null tests

        //double [] test1 =  {124.12, 0.12, 111.4444444, 1.23456789};
        //decimal[] test2 = { 11.22222222222222222222222222m, 565656565.5656565656565m };
        //Console.WriteLine("Examples:");
        //Console.WriteLine("[{0}]",String.Join(", ",test1));
        //Console.WriteLine();
        //Console.WriteLine("Min -> {0}, Max -> {1}, Average -> {2}, Sum -> {3}, Product -> {4}", CalculateMin(test1), CalculateMax(test1), CalculateAverage(test1), CalculateSum(test1), CalculateProduct(test1));
        //Console.WriteLine();
        //Console.WriteLine("[{0}]", String.Join(", ", test2));
        //Console.WriteLine();
        //Console.WriteLine("Min -> {0}, Max -> {1}, Average -> {2} Sum -> {3}, Product -> {4}", CalculateMin(test2), CalculateMax(test2), CalculateAverage(test2), CalculateSum(test2), CalculateProduct(test2));
        //Console.WriteLine();

        Console.WriteLine("Input a sequence, all numbers on a single line seperated by a whitespace:");
        double[] input = (Console.ReadLine().Split()).Select(double.Parse).ToArray();
        Console.WriteLine("Min -> {0}, Max -> {1}, Average -> {2} Sum -> {3}, Product -> {4}", CalculateMin(input), CalculateMax(input), CalculateAverage(input), CalculateSum(input), CalculateProduct(input));
       
    }

    static double CalculateMin(double[] num)
    {
        double min = double.MaxValue;
        for (int i = 0; i < num.Length; i++)
        {
            if(num[i] < min)
            {
                min = num[i];
            }
        }
        return min;
    }
    static double CalculateMax(double[] num)
    {
        double max = double.MinValue;
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] > max)
            {
                max = num[i];
            }
        }
        return max;
    }
    static double CalculateSum(double[] num)
    {
        double sum = 0;
        for (int i = 0; i < num.Length; i++)
        {
            sum += num[i];
        }
        return sum;
    }
    static double CalculateAverage(double[] num)
    {
        double average = CalculateSum(num) / num.Length;
        return average;
    }
    static double CalculateProduct(double[] num)
    {
        double product = 1;
        for (int i = 0; i < num.Length; i++)
        {
               product = product * num[i];
        }
        return product;
    }
    static decimal CalculateMin(decimal[] num)
    {
        decimal min = decimal.MaxValue;
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] < min)
            {
                min = num[i];
            }
        }
        return min;
    }
    static decimal CalculateMax(decimal[] num)
    {
        decimal max = decimal.MinValue;
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] > max)
            {
                max = num[i];
            }
        }
        return max;
    }
    static decimal CalculateSum(decimal[] num)
    {
        decimal sum = 0;
        for (int i = 0; i < num.Length; i++)
        {
            sum += num[i];
        }
        return sum;
    }
    static decimal CalculateAverage(decimal[] num)
    {
        decimal average = CalculateSum(num) / num.Length;
        return average;
    }
    static decimal CalculateProduct(decimal[] num)
    {
        decimal product = 1;
        for (int i = 0; i < num.Length; i++)
        {
            product = product * num[i];
        }
        return product;
    }
}

