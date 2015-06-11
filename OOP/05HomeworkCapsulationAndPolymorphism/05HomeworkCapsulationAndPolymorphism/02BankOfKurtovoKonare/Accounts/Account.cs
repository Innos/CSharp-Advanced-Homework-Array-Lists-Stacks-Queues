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
    abstract class Account : IAccount
    {
        private ICustomer customer;
        private decimal balance;
        private decimal interestRate;

        protected Account(ICustomer customer,decimal balance,decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public ICustomer Customer
        {
            get
            {
                return this.customer;
            }
            set
            {
                this.customer = value;
            }
        }
        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                this.balance = value;
            }
        }
        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            protected set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Interest cannot be negative.");
                }
                this.interestRate = value;
            }
        }

        public abstract string CalculateInterest(int months);
        public virtual void Deposit(decimal ammount)
        {
            if (ammount < 0)
            {
                throw new ArgumentOutOfRangeException("ammount", "Deposit amount cannot be negative.");
            }
            this.Balance = this.Balance + ammount;
        }
        public override string ToString()
        {
            return String.Format("Account Type: {0}\nAccount Holder: {2} - {1}\nBalance: {3}\nInterest Rate: {4}%\n",
                this.GetType().Name,
                this.Customer.GetType().Name,
                this.Customer.Name,
                this.Balance.ToString("C2",CultureInfo.CreateSpecificCulture("bg-BG")),
                this.InterestRate * 100 );
        }
    }
}
