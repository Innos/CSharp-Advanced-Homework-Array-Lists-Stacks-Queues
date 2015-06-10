using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSoftware.Interfaces;

namespace BankSoftware.Customers
{
    class Customer : ICustomer
    {
        private string name;

        public Customer(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value", "Name cannot be empty.");
                }
                this.name = value;
            }
        }
        public virtual string GetName()
        {
            return this.Name;
        }

    }
}
