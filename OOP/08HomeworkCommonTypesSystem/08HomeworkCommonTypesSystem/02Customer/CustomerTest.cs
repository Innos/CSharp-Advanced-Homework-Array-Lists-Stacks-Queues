using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Customer
{
    class CustomerTest
    {
        static void Main(string[] args)
        {
            //ID(EGN) must be a positive 10 digit number
            Payment payment1 = new Payment("Banichka", 1m);
            Payment payment2 = new Payment("BMW", 15999.99m);
            Payment payment3 = new Payment("Dunki", 30m);

            Customer customer = new Customer("Pesho", "Peshkov", "Peshev", "0123456789", "Sofia,V edna kofa", "0999 999 999", "pesho@abv.bg", CustomerType.OneTime);
            Customer customer2 = new Customer("Pesho", "Peshkov", "Peshev", "1122334455", "Sofia,Sheraton Penthaus", "0111 222 333", "pesho@pesho.com", CustomerType.Diamond);
            Customer customer3 = new Customer("Gosho", "Hubaveca", "Vechniqt Ergen", "9999900000", "Sofia,Kazichene", "0444 444 444", "goshkohubaveca@yahoo.com", CustomerType.Regular);


            customer.Payments.Add(payment1);
            customer2.Payments.Add(payment2);
            customer3.Payments.Add(payment3);


            var customer4 = customer3.Clone() as Customer;
            customer4.FirstName = "Ivan";
            customer4.Payments.Add(payment1);

            Console.WriteLine(customer);
            Console.WriteLine(customer2);
            Console.WriteLine(customer3);
            Console.WriteLine(customer4);

            Console.WriteLine(customer == customer2);
            Console.WriteLine(customer2 == customer3);
            Console.WriteLine(customer != customer2);
            Console.WriteLine(customer != customer3);

            var customers = new List<Customer> { customer,customer2,customer3,customer4 };
            customers.Sort();

            Console.WriteLine(
                string.Join(Environment.NewLine, customers
                    .Select(c => new { c.FullName, c.ID, })));
        }
    }
}
