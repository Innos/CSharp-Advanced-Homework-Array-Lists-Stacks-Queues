using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Products;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Hierarchy.Employees.RegularEmployees
{
    class Developer : RegularEmployee, IDeveloper
    {
        private List<Project> projects;

        public Developer(string firstName, string lastName, int id, decimal salary, string department,params Project[] projects)
            : base(firstName, lastName, id, salary, department)
        {
            this.Projects = new List<Project>(projects);
        }

        public List<Project> Projects
        {
            get { return this.projects; }
            set { this.projects = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine("Projects:");
            foreach (var project in projects)
            {
<<<<<<< HEAD
                sb.AppendLine(project.ToString());
=======
                sb.AppendLine(project.Name);
>>>>>>> f02ab2c1a63cdc24ebe1799da94118864915696c
            }
            sb.AppendLine(new string('-', 75));
            return sb.ToString();
        }
    }
}
