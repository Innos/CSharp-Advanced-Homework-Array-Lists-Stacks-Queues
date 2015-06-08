using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Hierarchy
{
    abstract class Person : IPerson
    {
        private int id;
        private string firstName;
        private string lastName;

        public Person(string firstName,string lastName,int id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ID = id;
        }

        public int ID
        {
            get { return this.id; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("ID cannot be negative.");
                }
                this.id = value;
            }
        }
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "First Name cannot be empty.");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "Last Name cannot be empty.");
                }
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Name: {0} {1}, ID: {2}", this.FirstName, this.LastName, this.ID);
        }

    }
}
