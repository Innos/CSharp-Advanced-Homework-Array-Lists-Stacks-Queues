using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSoftware.Interfaces;
using BankSoftware.Customers;
using System.Globalization;

namespace BankSoftware.Accounts
{
    class MortgageAccount : Account
    {
        public MortgageAccount(ICustomer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override string CalculateInterest(int months)
        {
            decimal interest = this.Balance * (1 + this.InterestRate * months);
            if (this.Customer is Individual)
            {
                if (months <= 6)
                {
                    interest = 0;
                }
                else
                {
                    months = months - 6;
                    interest = this.Balance * (1 + this.InterestRate * months);
                }
            }
            else if (this.Customer is Company)
            {
                if (months <= 12)
                {
                    interest = interest / 2;
                }
                else
                {
                    months = months - 6;
                    interest = this.Balance * (1 + this.InterestRate * months);
                }
            }
            return Math.Abs(interest).ToString("C2", CultureInfo.CreateSpecificCulture("bg-BG"));
        }
    }
}
