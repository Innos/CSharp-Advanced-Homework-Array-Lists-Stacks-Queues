using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Classes
{
    class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age,"female")
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("{0} says Miauuuu Miauuuu!", this.Name);
        }
    }
}
