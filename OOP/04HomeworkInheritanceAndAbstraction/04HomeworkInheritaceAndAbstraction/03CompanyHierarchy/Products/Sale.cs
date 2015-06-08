using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Products
{
    class Sale : ISale
    {
        private string name;
        private DateTime date;
        private decimal price;

        public Sale(string name,DateTime date, decimal price)
        {
            this.Name = name;
            this.Date = date;
            this.Price = price;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "Name cannot be empty.");
                }
                this.name = value;
            }
        }
        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Price cannot be negative.");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("Sale Name: {0}, Date: {1}, Price: {2}", this.Name, this.Date, this.Price.ToString("C2",CultureInfo.CreateSpecificCulture("bg-BG"))));
            return sb.ToString();
        }
    }
}
