using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _02Customer
{
    class Payment
    {
        private string productName;
        private decimal price;

        public Payment(string name,decimal price)
        {
            this.ProductName = name;
            this.Price = price;
        }

        public string ProductName
        {
            get
            {
                return this.productName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("ProductName","Product Name cannot be empty");
                }
                this.productName = value;
            }
        }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price", "Price cannot be negative");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Product Name: {0}; Price:{1}", this.ProductName, this.Price.ToString("C2",new CultureInfo("bg-BG")));
        }
    }
}
