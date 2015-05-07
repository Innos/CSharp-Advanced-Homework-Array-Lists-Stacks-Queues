using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;


class DifferenceBetweenDates
{
    static void Main(string[] args)
    {
        DateTime start = DateTime.Parse(Console.ReadLine(),CultureInfo.CreateSpecificCulture("bg-BG"));
        DateTime end = DateTime.Parse(Console.ReadLine(), CultureInfo.CreateSpecificCulture("bg-BG"));
        TimeSpan difference = end.Subtract(start);
        Console.WriteLine(difference.Days);
    }
}

