using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Hierarchy.Employees
{
    class Manager : Employee, IManager
    {
        private List<Employee> employees = new List<Employee>();

        public Manager(string firstName, string lastName, int id,decimal salary,string department, params Employee[] employees)
            : base(firstName, lastName, id,salary,department)
        {
            this.Employees = new List<Employee>(employees);
        }

        public List<Employee> Employees
        {
            get { return this.employees; }
            set { this.employees = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine("Employees:");
            foreach (var employee in employees)
            {
                sb.AppendLine(String.Format("{0} {1}",employee.FirstName,employee.LastName));
            }
            sb.AppendLine(new string('-', 75));
            return sb.ToString();
        }
    }
}
