using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SULS.Persons
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be empty.");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName;}
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be enoty.");
                }
                this.lastName = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be negative.");
                }
                this.age = value;
            }
        }

        public Person(string firstName,string lastName,int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
    }
}
