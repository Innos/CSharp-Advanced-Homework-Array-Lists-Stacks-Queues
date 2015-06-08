using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentAndWorker.Humans
{
    abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName,string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
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
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "Last name cannot be empty.");
                }
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}
