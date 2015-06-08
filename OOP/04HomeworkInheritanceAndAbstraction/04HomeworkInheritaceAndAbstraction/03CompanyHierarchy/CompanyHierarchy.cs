using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Hierarchy;
using CompanyHierarchy.Hierarchy.Employees;
using CompanyHierarchy.Hierarchy.Employees.RegularEmployees;
using CompanyHierarchy.Products;

namespace CompanyHierarchy
{
    class CompanyHierarchy
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            Project project1 = new Project("Web site",DateTime.Now,"Create a site for a construction company","open");
            Project project2 = new Project("Company software",new DateTime(2000,12,12),"closed");

            Sale sale1 = new Sale("T Shirt",DateTime.Now,35m);
            Sale sale2 = new Sale("Jacket",new DateTime(2010,1,1),65m);
            Sale sale3 = new Sale("Blouse",new DateTime(2014,5,10),40m);

            SalesEmployee seller1 = new SalesEmployee("Adam", "Merkel", 11, 800m, "Sales", sale1, sale2);
            SalesEmployee seller2 = new SalesEmployee("Alexander", "Mishev", 12, 825m, "Sales", sale1, sale2, sale3);
            SalesEmployee seller3 = new SalesEmployee("Duma", "Krautzer", 13, 900m, "Marketing", sale2, sale3);

            Developer developer1 = new Developer("Brock", "Palms", 101, 1025m, "Production", project1);
            Developer developer2 = new Developer("James", "Mitchell", 102, 1050m, "Production", project2);
            Developer developer3 = new Developer("Mira", "Kramer", 103, 1100m, "Production", project1, project2);

            Manager manager1 = new Manager("John", "Smith", 1, 1050m, "Production",developer1,developer3);
            Manager manager2 = new Manager("Patrick", "Lehmer", 2, 1200m, "Production", developer1, developer2, developer3);
            Manager manager3 = new Manager("Laura", "Stewart", 3, 1350m, "Accounting");
            Manager manager4 = new Manager("Sandra", "Pelts", 4, 1250m, "Sales", seller1, seller2, seller3);

            List<Person> people = new List<Person>()
            {
                seller1,
                seller2,
                seller3,
                developer1,
                developer2,
                developer3,
                manager1,
                manager2,
                manager3,
                manager4
            };

            var orderedPeople = people.OrderBy(person => person.ID);
            foreach (var person in orderedPeople)
            {
                Console.Write(person.ToString());
            }
        }
    }
}
