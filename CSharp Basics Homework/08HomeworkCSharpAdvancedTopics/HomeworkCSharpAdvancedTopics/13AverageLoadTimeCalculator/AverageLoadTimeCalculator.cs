using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class AverageLoadTimeCalculator
{
    static void Main(string[] args)
    {
        Dictionary<string,List<double>> LoadTimes = new Dictionary<string,List<double>>();
        string input = Console.ReadLine();
        while(input != "")
        {
            string key1 = input.Split(' ')[2];
            double average = double.Parse(input.Split(' ')[3]);
            if(!LoadTimes.ContainsKey(key1))
            {
                LoadTimes.Add(key1, new List<double>{average});
            }
            else
            {
                LoadTimes[key1].Add(average);
            }
            input = Console.ReadLine();
        }
        foreach (var key in LoadTimes.Keys)
        {
            Console.WriteLine("{0} -> {1}",key,LoadTimes[key].Average());
        }
    }
}

