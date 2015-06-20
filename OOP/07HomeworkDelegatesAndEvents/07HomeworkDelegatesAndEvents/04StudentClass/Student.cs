using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04StudentClass
{
    public delegate void OnStudentChangeEventHandler(Student sender, StudentChangedEventArgs args);

    public class Student
    {
        public event OnStudentChangeEventHandler StudentChanged;

        private string name;
        private int age;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("name","Name cannot be empty.");
                }
                if (this.StudentChanged != null)
                {
                    this.StudentChanged(this,new StudentChangedEventArgs("Name",this.Name,value));
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
                if (value < 0)
                {
                    throw new ArgumentNullException("age","Age cannot be negative.");
                }
                if (this.StudentChanged != null)
                {
                    this.StudentChanged(this, new StudentChangedEventArgs("Age", this.Age.ToString(), value.ToString()));
                }
                this.age = value;
            }
        }

    }
}
