using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Products
{
    class Project : IProject
    {
        private string name;
        private DateTime date;
        private string details;
        private bool state;

        public Project(string name, DateTime date, string state) : this(name,date,null,state)
        {
        }

        public Project(string name,DateTime date, string details, string state)
        {
            this.Name = name;
            this.Date = date;
            this.Details = details;
            this.State = state;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "Name cannot be empty.");
                }
                this.name = value;
            }
        }
        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        public string Details
        {
            get { return this.details; }
            set { this.details = value; }
        }
        public string State
        {
            get { return this.state == false ? "closed" : "open"; }
            set
            {
                if(value != "open" && value != "closed")
                {
                    throw new ArgumentException("value", "State can only be \"open\" and \"closed\"");
                }
                this.state = (value == "open" ? true : false);
            }
        }

        public void CloseProject()
        {
            this.state = false;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("Project Name: {0}, Date: {1}, State: {2}", this.Name, this.Date, this.State));
            sb.Append(String.Format("Details: {0}", this.Details));
            return sb.ToString();
        }
    }
}
