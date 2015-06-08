using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentAndWorker.Humans
{
    class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary,int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Week salary cannot be negative.");
                }
                this.weekSalary = value;
            }
        }
        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Work Hours per day cannot be negative.");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / this.WorkHoursPerDay;
        }
        public override string ToString()
        {
            return String.Format("{0} Week Salary: {1}, Work Hours Per Day: {2}, Money Per hour: {3}", base.ToString(), this.WeekSalary,this.WorkHoursPerDay,this.MoneyPerHour());
        }
    }
}
