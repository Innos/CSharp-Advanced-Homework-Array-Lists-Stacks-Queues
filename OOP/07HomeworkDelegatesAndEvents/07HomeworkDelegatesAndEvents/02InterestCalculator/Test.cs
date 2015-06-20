using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02InterestCalculator
{
    public class Test
    {
        public const int MonthsInYear = 12;
        static void Main(string[] args)
        {
            CalculateInterest simple = new CalculateInterest(GetSimpleInterest);
            CalculateInterest compound = new CalculateInterest(GetCompoundInterest);

            InterestCalculator calc1 = new InterestCalculator(500,5.6m,10,compound);
            InterestCalculator calc2 = new InterestCalculator(2500, 7.2m, 15, simple);
            Console.WriteLine(calc1.CalculateInterest());
            Console.WriteLine(calc2.CalculateInterest());
            
        }

        public static decimal GetSimpleInterest(decimal sum, decimal interest, int years)
        {
            return sum * (1 + interest * years);
        }
        public static decimal GetCompoundInterest(decimal sum, decimal interest, int years)
        {
            return sum*(decimal)(Math.Pow((double) (1 + interest/MonthsInYear),years*MonthsInYear));
        }
    }
}
