using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Persons
{
    static void Main(string[] args)
    {
        Person person1 = new Person("Pesho", 23);
        Person person2 = new Person("Gosho", 30, "vechniqtergen@abv.bg");
        Console.WriteLine(person1);
        Console.WriteLine(person2);
    }
}

