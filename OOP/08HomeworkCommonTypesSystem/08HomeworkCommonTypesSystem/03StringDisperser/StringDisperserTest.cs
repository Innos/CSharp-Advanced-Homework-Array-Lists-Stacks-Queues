using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03StringDisperser
{
    class StringDisperserTest
    {
        static void Main(string[] args)
        {
            //Object and Cloning check
            StringDisperser stringDisperser = new StringDisperser("gosho", "pesho", "tanio");
            var disperserClone = stringDisperser.Clone() as StringDisperser;

            //Iterator Check
            Console.WriteLine("Iterator Check:\n");
            foreach (var ch in stringDisperser)
            {
                Console.Write(ch + " ");
            }
            Console.WriteLine();
            foreach (var ch in disperserClone)
            {
                Console.Write(ch + " ");
            }

            //Foreach on an empty object to test if the Iterator will work correctly
            StringDisperser empty = new StringDisperser();
            foreach (var ch in empty)
            {
                Console.Write(ch + " ");
            }
          
            Console.WriteLine();

            //String Check
            var disperser2 = new StringDisperser("apples","bananas","pears");
            Console.WriteLine("\nToString() Check:\n");
            Console.WriteLine(disperserClone.ToString());
            Console.WriteLine(disperser2.ToString());

            //HashCode Check
            Console.WriteLine("\nHashCode Check:\n");
            Console.WriteLine(disperserClone.GetHashCode());
            Console.WriteLine(disperser2.GetHashCode());

            //Equals and == and != operators check
            Console.WriteLine("\nEquals Check:\n");
            Console.WriteLine(disperser2 == disperserClone);
            Console.WriteLine(disperserClone == stringDisperser);
            Console.WriteLine(disperser2 != disperserClone);
            Console.WriteLine(disperserClone != stringDisperser);
            Console.WriteLine(disperserClone.Equals(stringDisperser));
            Console.WriteLine(disperser2.Equals(stringDisperser));

            //CompareTo Check
            StringDisperser disperser3 = new StringDisperser("Gosho", "pesho", "tanio");
            Console.WriteLine("\nCompareTo Check:\n");
            Console.WriteLine("Before Sort:\n");
            List<StringDisperser> list = new List<StringDisperser>(){disperser3,disperser2,stringDisperser};
            Console.WriteLine(string.Join(Environment.NewLine,list));
            Console.WriteLine("\nAfter Sort:\n");
            list.Sort();
            Console.WriteLine(string.Join(Environment.NewLine, list));
        }
    }
}
