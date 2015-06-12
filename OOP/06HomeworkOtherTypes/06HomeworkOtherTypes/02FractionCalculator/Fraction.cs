using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02FractionCalculator
{
    struct Fraction
    {
        private long denominator;

        public Fraction(long numerator,long denominator) : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator { get; set; }

        public long Denominator
        {
            get { return this.denominator; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentOutOfRangeException("value","Denominator cannot be 0.");
                }
                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction first, Fraction second)
        {
            long newNumerator = first.Numerator*second.Denominator + second.Numerator*first.Denominator;
            long newDenominator = first.Denominator*second.Denominator;
            Fraction result = new Fraction(newNumerator,newDenominator);

            return result;
        }
        public static Fraction operator -(Fraction first, Fraction second)
        {
            long newNumerator = first.Numerator * second.Denominator - second.Numerator * first.Denominator;
            long newDenominator = first.Denominator * second.Denominator;
            Fraction result = new Fraction(newNumerator, newDenominator);

            return result;
        }
        public override string ToString()
        {
            return (this.Numerator/(decimal) this.Denominator).ToString();
        }
    }
}
