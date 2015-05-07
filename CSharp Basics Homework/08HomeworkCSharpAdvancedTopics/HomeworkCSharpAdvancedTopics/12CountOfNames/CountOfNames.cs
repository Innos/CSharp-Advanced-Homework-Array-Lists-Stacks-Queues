using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CountOfNames
{
    static void Main(string[] args)
    {
        List<string> names = Console.ReadLine().Split(' ').ToList();
        names.Sort();
        foreach (var name in names.Distinct())
        {
            Console.WriteLine("{0} -> {1}",name,names.Count(x=> x == name));
        }
    }
}

