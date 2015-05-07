using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class SortArrayOfNumbers
{
    static void Main(string[] args)
    {
        List<int> numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse).ToList();
        List<int> result = new List<int>();
        //numbers.Sort();
        while(numbers.Count > 0)
        {
            int min = numbers[0];
            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            result.Add(min);
            numbers.Remove(min);
        }
        Console.WriteLine(String.Join(" ",result));
        
    }
}

