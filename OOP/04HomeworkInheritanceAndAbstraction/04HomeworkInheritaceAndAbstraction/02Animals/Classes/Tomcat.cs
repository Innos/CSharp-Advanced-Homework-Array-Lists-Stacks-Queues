using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Classes
{
    class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age,"male")
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("{0} says MRRRRRR!", this.Name);
        }
    }
}
