using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Person
{
    private int age;
    private string name;

    public string Email { get; set; }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if(value == null || value.Trim() == "")
            {
                throw new ArgumentNullException("Name cannot be empty!");
            }
            this.name = value;
        }
    }
    public int Age
    {
        get 
        {
            return this.age;
        }
        set
        {
            if (value < 1 || value > 100)
            {
                throw new ArgumentOutOfRangeException("Age must be between 1 and 100");
            }
            this.age = value;
        }
    }

    public Person(string name, int age) : this(name,age,null)
    {
    }
    public Person(string name, int age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public override string ToString()
    {
        return String.Format("Name: {0}, Age: {1}, Email: {2}",
            this.Name, this.Age, this.Email);
    }
}

