using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Products;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Hierarchy.Employees.RegularEmployees
{
    class SalesEmployee : RegularEmployee,ISalesEmployee
    {
        private List<Sale> sales;

        public SalesEmployee(string firstName, string lastName, int id, decimal salary, string department, params Sale[] sales)
            : base(firstName, lastName, id, salary, department)
        {
            this.Sales = new List<Sale>(sales);
        }

        public List<Sale> Sales
        {
            get { return this.sales; }
            set { this.sales = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine("Sales:");
            foreach (var sale in sales)
            {
                sb.AppendLine(sale.Name);
            }
            sb.AppendLine(new string('-', 75));
            return sb.ToString();
        }

    }
}
