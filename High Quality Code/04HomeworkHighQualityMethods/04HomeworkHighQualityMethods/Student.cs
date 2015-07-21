namespace Methods
{
    using System;

    public class Student
    {
        private string firstName;

        private string lastName;

        private string otherInfo;

        public Student(string firstName,string lastName,DateTime birthdate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthdate;
            this.OtherInfo = string.Empty;
        }

        public Student(string firstName, string lastName, DateTime birthdate,string otherInfo) : this(firstName,lastName,birthdate)
        {
            this.OtherInfo = otherInfo;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be empty.");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be empty.");
                }

                this.lastName = value;
            }
        }

        public DateTime BirthDate { get; set; }

        public string OtherInfo
        {
            get
            {
                return this.otherInfo;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Other info cannot be null.");
                }

                this.otherInfo = value;
            }
        }

        public bool IsOlderThan(Student other)
        {
            return this.BirthDate < other.BirthDate;
        }
    }
}
