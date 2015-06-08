using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Hierarchy.Employees
{
    class RegularEmployee : Employee, IRegularEmployee
    {
        public RegularEmployee(string firstName, string lastName, int id, decimal salary, string department)
            : base(firstName, lastName, id, salary, department)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
