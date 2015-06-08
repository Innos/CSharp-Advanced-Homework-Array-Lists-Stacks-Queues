using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SULS.Persons.Trainer
{
    class JuniorTrainer : Trainer
    {
        public JuniorTrainer(string firstName,string lastName,int age) : base(firstName,lastName,age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
    }
}
