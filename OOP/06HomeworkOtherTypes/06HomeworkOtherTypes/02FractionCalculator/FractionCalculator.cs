using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02FractionCalculator
{
    class FractionCalculator
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(22, 7);
            Fraction fraction2 = new Fraction(40, 4);
            Fraction result = fraction1 + fraction2;
            Fraction result2 = fraction1 - fraction2;

            Console.WriteLine(result.Numerator);
            Console.WriteLine(result.Denominator);
            Console.WriteLine(result);
            Console.WriteLine(result2.Numerator);
            Console.WriteLine(result2.Denominator);
            Console.WriteLine(result2);

        }
    }
}
