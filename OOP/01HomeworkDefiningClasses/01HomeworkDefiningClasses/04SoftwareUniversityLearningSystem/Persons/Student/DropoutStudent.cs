using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SULS.Persons.Student
{
    class DropoutStudent : Student
    {
        private string dropoutReason;

        public string DropoutReason
        {
            get { return this.dropoutReason; }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Dropout Reason cannot be empty.");
                }
                this.dropoutReason = value;
            }
        }

        public DropoutStudent(string firstName,string lastName,int age,string studentNumber,double averageGrade,string dropoutReason) : base(firstName,lastName,age,studentNumber,averageGrade)
        {
            this.DropoutReason = dropoutReason;
        }

        public void Reapply()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return String.Format("{0} {1} Age:{2}, Student Number: {3}, Average Grade: {4}, Dropout Reason: {5}"
                , FirstName, LastName, Age, StudentNumber, AverageGrade, DropoutReason);
                    
        }
    }
}
