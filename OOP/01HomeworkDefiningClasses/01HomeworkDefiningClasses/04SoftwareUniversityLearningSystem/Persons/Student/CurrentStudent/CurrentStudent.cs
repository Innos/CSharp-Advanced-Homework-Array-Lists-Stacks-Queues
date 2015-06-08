using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SULS.Persons.Student.CurrentStudent
{
    class CurrentStudent : Student
    {
        private string currentCourse;
        
        public string CurrentCourse
        {
            get { return this.currentCourse; }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Current Course cannot be empty.");
                }
                this.currentCourse = value;
            }
        }
        public CurrentStudent(string firstName,string lastName,int age,string studentNumber,double averageGrade,string currentCourse) : base(firstName,lastName,age,studentNumber,averageGrade)
        {
            this.CurrentCourse = currentCourse;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} Age: {2}, Student Number: {3}, Average Grade: {4}, Current Course: {5}",this.FirstName,this.LastName,this.Age,this.StudentNumber,this.AverageGrade,this.CurrentCourse);
        }
    }
}
