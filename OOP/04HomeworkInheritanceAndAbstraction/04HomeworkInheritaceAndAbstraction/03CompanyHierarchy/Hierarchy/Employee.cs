using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Hierarchy
{
    class Employee : Person, IEmployee
    {
        private decimal salary;
        private string department;

        public Employee(string firstName, string lastName, int id, decimal salary, string department)
            : base(firstName, lastName, id)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Salary cannot be negative.");
                }
                this.salary = value;
            }
        }
        public string Department
        {
            get { return this.department; }
            set
            {
                if (value != "Production" && value != "Accounting" && value != "Sales" && value != "Marketing")
                {
                    throw new ArgumentException("value", "Department can only be \"Productions\",\"Marketing\",\"Accounting\" and \"Sales\"");
                }
                this.department = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("{0}, Salary: {1}, Department: {2}", base.ToString(), this.Salary.ToString("C2", CultureInfo.CreateSpecificCulture("bg-BG")), this.Department));
            return sb.ToString();
        }
    }
}
