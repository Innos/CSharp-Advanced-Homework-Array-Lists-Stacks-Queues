using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortingNumbers
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            numbers.Add(int.Parse(Console.ReadLine()));
        }
        numbers.Sort();
        foreach(var entry in numbers)
        {
            Console.WriteLine(entry);
        }
    }
}

