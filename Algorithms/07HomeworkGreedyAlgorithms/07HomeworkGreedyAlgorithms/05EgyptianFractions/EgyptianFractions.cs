namespace _05EgyptianFractions
{
    using System;
    using System.Collections.Generic;

    public class EgyptianFractions
    {
        public static void Main(string[] args)
        {
            string[] parameters = Console.ReadLine().Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            long numerator = long.Parse(parameters[0]);
            long denominator = long.Parse(parameters[1]);

            if (numerator / denominator >= 1)
            {
                Console.WriteLine("Error (fraction is equal to or greater than 1)");
                return;
            }

            // just for completion sake here's a solution based on the hint, with more complex fractions completion times become so big, it's not even worth considering though
            //GreedySolution(numerator, denominator);

            OptimizedSolution(numerator,denominator);
        }

        private static void OptimizedSolution(long numerator, long denominator)
        {
            long currentNumerator = numerator;
            long currentDenominator = denominator;
            List<EgyptianFraction> fractions = new List<EgyptianFraction>();

            // it is still greedy just smart greedy, we can reduce number size by increasing the denominator to the LCM instead of multiplying it
            // but unless we need to account for number size, there is no need to waste the extra operations
            while (currentNumerator > 0)
            {
                long currentFraction = (long)Math.Ceiling(currentDenominator / (double)currentNumerator);
                fractions.Add(new EgyptianFraction(currentFraction));
                currentNumerator = currentNumerator * currentFraction;
                currentNumerator = currentNumerator - (1 * currentDenominator);
                currentDenominator = currentDenominator * currentFraction;
            }

            Console.WriteLine("{0}/{1} = {2}", numerator, denominator, string.Join(" + ", fractions));
        }

        private static void GreedySolution(long numerator, long denominator)
        {
            long currentNumerator = numerator;
            long currentDenominator = denominator;
            List<EgyptianFraction> fractions = new List<EgyptianFraction>();
            long currentFraction = 2;

            while (currentNumerator > 0)
            {
                long fractionNumerator = 1 * currentDenominator;
                long tempNumerator = currentNumerator * currentFraction;

                if (fractionNumerator > tempNumerator)
                {
                    currentFraction++;
                    continue;
                }

                fractions.Add(new EgyptianFraction(currentFraction));
                currentNumerator = tempNumerator - fractionNumerator;
                currentDenominator = currentDenominator * currentFraction;
            }

            Console.WriteLine("{0}/{1} = {2}", numerator, denominator, string.Join(" + ", fractions));
        }
    }
}
