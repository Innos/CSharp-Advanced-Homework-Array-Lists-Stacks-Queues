using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02InterestCalculator
{
    public delegate decimal CalculateInterest(decimal sumOfMoney, decimal interestRate, int years);

    public class InterestCalculator
    {
        public InterestCalculator(decimal money, decimal interest, int years, CalculateInterest type )
        {
            this.SumOfMoney = money;
            this.InterestRate = interest/ 100;
            this.Years = years;
            this.InterestType = type;
        }

        public decimal SumOfMoney { get; set; }
        public decimal InterestRate { get; set; }
        public int Years { get; set; }
        public CalculateInterest InterestType { get; set; }

        public string CalculateInterest()
        {
            return InterestType(this.SumOfMoney, this.InterestRate, this.Years).ToString("0.0000");
        }


    }
}
