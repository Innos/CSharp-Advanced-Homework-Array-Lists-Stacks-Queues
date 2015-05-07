using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MatrixOfNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int l = i; l < i+n; l++)
            {
                Console.Write(l + " ");
            }
            Console.WriteLine();
        }
    }
}

