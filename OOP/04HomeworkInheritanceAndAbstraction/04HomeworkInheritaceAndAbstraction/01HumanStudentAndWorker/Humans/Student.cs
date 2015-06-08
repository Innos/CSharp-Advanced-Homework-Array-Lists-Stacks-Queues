using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentAndWorker.Humans
{
    class Student : Human
    {
        private string studentNumber;

        public Student(string firstName, string lastName,string studentNumber) : base(firstName,lastName)
        {
            this.StudentNumber = studentNumber;
        }
        public string StudentNumber
        {
            get { return this.studentNumber; }
            set
            {
                if(value.Length < 5 || value.Length > 10 || value.Any(ch=>!Char.IsLetterOrDigit(ch)))
                {
                    throw new ArgumentException("value", "Student number length must be between [5...10] and must be only digitst or letters.");
                }
                this.studentNumber = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0} Student Number: {1}",base.ToString(),this.StudentNumber);
        }
    }
}
