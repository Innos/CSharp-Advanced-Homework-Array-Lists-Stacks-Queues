using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Hierarchy
{
    class Customer : Person, ICustomer
    {
        private decimal netPurchaseAmount;

        public Customer(string firstName, string lastName, int id, decimal netPurchaseAmount)
            : base(firstName, lastName, id)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        public decimal NetPurchaseAmount
        {
            get { return this.netPurchaseAmount; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Net Purchase Amount cannot be negative.");
                }
                this.netPurchaseAmount = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}, Net Purchase Amount: {1}", base.ToString(), this.NetPurchaseAmount);
        }
    }
}
