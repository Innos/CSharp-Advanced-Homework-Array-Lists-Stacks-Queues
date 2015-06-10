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
    class DepositAccount : Account, IWithdrawable
    {
        public DepositAccount(ICustomer customer, decimal balance, decimal interestRate) : base(customer,balance,interestRate)
        {
            CheckBalance(balance);
        }

        public override string CalculateInterest(int months)
        {      
            decimal interest = 0;
            if (this.Balance >= 1000)
            {
                interest = this.Balance * (1 + this.InterestRate * months);
            }
            return interest.ToString("C2", CultureInfo.CreateSpecificCulture("bg-BG"));
            
        }
       
        private void CheckBalance(decimal balance)
        {
            if(balance < 0)
            {
                throw new ArgumentOutOfRangeException("balance", "Deposit balance cannot be negative.");
            }
        }
        public void Withdraw(decimal ammount)
        {
            if (ammount < 0)
            {
                throw new ArgumentOutOfRangeException("ammount", "Withdraw amount cannot be negative.");
            }
            else if(this.Balance - ammount < 0)
            {
                throw new ArgumentOutOfRangeException("ammount", "Cannot withdraw more than current Balance.");
            }
            this.Balance = this.Balance - ammount;
        }
    }
}
