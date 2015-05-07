using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class OddAndEvenProduct
{
    static void Main(string[] args)
    {
        int odd_product = 1;
        int even_product = 1;
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        for (int i = 0; i < numbers.Length; i++)
        {
            if(i % 2 == 0)
            {
                odd_product = odd_product * numbers[i];
            }
            else
            {
                even_product = even_product * numbers[i];
            }
        }
        if(odd_product == even_product)
        {
            Console.WriteLine("yes product = {0}",odd_product);
        }
        else
        {
            Console.WriteLine("no \nodd_product = {0}\neven_product = {1}", odd_product, even_product);
        }
    }
}

