using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');    //input on the same line seperated by a space
            int rows = int.Parse(input[0]);
            int cols = int.Parse(input[1]);
            for (int i = 'a'; i < 'a'+rows; i++)
            {
                for (int i2 = i; i2 < i+cols; i2++)
                {
                    Console.Write("{0}{1}{0} ",(char)i,(char)i2);
                }
                Console.WriteLine();
            }
        }
    }
}
