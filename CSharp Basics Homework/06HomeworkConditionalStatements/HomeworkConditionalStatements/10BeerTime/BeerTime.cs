using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BeerTime
{
    static void Main(string[] args)
    {
        Console.Write("Input time in \"hh:mm tt\" format: ");
        DateTime time = DateTime.Parse(Console.ReadLine());
        DateTime beerBottom = DateTime.Parse("01:00 PM");
        DateTime beerTop = DateTime.Parse("03:00 AM");
        if(DateTime.Compare(time,beerBottom)>= 0 || DateTime.Compare(time,beerTop) < 0)
        {
            Console.WriteLine("beer time");
        }
        else
        {
            Console.WriteLine("non-beer time");
        }
    }
}

