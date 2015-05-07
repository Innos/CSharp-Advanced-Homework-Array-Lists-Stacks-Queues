using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RemoveNames
{
    static void Main(string[] args)
    {
        List<string> list1 = Console.ReadLine().Split(' ').ToList();
        List<string> list2 = Console.ReadLine().Split(' ').ToList();
        foreach (var entry in list1)
        {
            if(!list2.Contains(entry))
            {
                Console.Write(entry + " ");
            }
        }
    }
}

