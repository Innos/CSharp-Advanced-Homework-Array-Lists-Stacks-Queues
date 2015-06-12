using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Test
    {
        static void Main(string[] args)
        {
            CustomGenericList<int> newList = new CustomGenericList<int>();
            newList.Add(10);
            newList.Add(15);
            newList.Add(8);
            newList.Add(250);
            newList.Remove(250);
            newList.Remove(10);
            newList.Add(157);
            newList.InsertAt(2, 33);

            Console.WriteLine("Count: {0}", newList.Count);
            Console.WriteLine("Min: {0}", newList.Min());
            Console.WriteLine("Max: {0}", newList.Max());
            Console.WriteLine("List: {0}", newList);
            Console.WriteLine("Index of \"{0}\": {1}", 8, newList.IndexOf(8));
            Console.WriteLine("Index #2: {0}", newList[2]);
            Console.WriteLine(newList.Contains(157));
            newList.Clear();
            Console.WriteLine(newList.Contains(157));

            Console.WriteLine();
            CustomGenericList<string> newList2 = new CustomGenericList<string>();
            newList2.Add("orange");
            newList2.Add("slgew");
            newList2.Add("bsdg");
            newList2.Add("apple");
            newList2.Remove("apple");
            //newList2.Remove("banana");
            newList2.Add("pear");
            Console.WriteLine("Count: {0}", newList2.Count);
            Console.WriteLine("Min: {0}", newList2.Min());
            Console.WriteLine("Max: {0}", newList2.Max());
            Console.WriteLine("List: {0}", newList2);
            Console.WriteLine("Index of \"{0}\": {1}", "pear", newList2.IndexOf("pear"));
            Console.WriteLine("Index #2: {0}", newList2[2]);
            Console.WriteLine(newList2.Contains("orange"));
            newList2.Clear();
            Console.WriteLine(newList2.Contains("orange"));

            Console.WriteLine();
            Type type = typeof(CustomGenericList<>);
            object[] allAttributes = type.GetCustomAttributes(typeof(VersionAttribute), false);
            foreach (VersionAttribute attr in allAttributes)
            {
                Console.WriteLine("This class's version is {0}.", attr.Version);
            }
        }
    }
}
