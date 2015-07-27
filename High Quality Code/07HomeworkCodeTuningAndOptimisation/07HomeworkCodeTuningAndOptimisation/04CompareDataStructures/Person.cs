using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04CompareDataStructures
{
    public class Person
    {
        public Person(string name, string phone)
        {
            this.Name = name;
            this.Phone = phone;
        }

        public string Name { get; set; }

        public string Phone { get; set; }
    }
}
