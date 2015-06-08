using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals.Interfaces;

namespace Animals.Classes
{
    abstract class Animal : ISoundProducible
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name,int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "Name cannot be empty.");
                }
                this.name = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Age cannot be negative.");
                }
                this.age = value;
            }
        }
        public string Gender
        {
            get { return this.gender; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "Gender cannot be empty.");
                }
                if(value != "male" && value != "female")
                {
                    throw new ArgumentException("value", "Gender must be \"male\" or \"female\"");
                }
                this.gender = value;
            }
        }

        public abstract void ProduceSound();
    }
}
