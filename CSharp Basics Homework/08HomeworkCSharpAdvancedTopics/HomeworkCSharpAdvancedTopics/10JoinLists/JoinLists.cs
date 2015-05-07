using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class JoinLists
{
    static void Main(string[] args)
    {
        List<int> list1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse).ToList();
        List<int> list2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse).ToList();
        var result = list1.Concat(list2).ToList();
        result.Sort();
        foreach(var num in result.Distinct())
        {
            Console.Write(num + " ");
        }
    }
}

