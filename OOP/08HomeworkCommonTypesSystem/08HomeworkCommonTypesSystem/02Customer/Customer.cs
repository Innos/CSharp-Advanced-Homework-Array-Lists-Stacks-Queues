using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02Customer
{
    class Customer : ICloneable,IComparable<Customer>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string id;
        private string permanentAdress;
        private string mobilePhone;
        private string email;
        private List<Payment> payments;
        private CustomerType customerType;

        public Customer(string firstName, string middleName, string lastName, string id, string permanentAdress, string mobilePhone, string email, CustomerType type, List<Payment> payments) : this(firstName,middleName,lastName,id,permanentAdress,mobilePhone,email,type)
        {
            this.Payments = payments;
        }
        public Customer(string firstName, string middleName, string lastName, string id, string permanentAdress, string mobilePhone, string email, CustomerType type, params Payment[]payments)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.ID = id;
            this.PermanentAdress = permanentAdress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.CustomerType = type;
            this.Payments = new List<Payment>(payments);
        }

        public string FirstName
        {
            get
            {
                return this.firstName;

            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("firstName", "Name cannot be empty.");
                }
                this.firstName = value;
            }
        }
        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("middleName", "Name cannot be empty.");
                }
                this.middleName = value;
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
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("lastName", "Name cannot be empty.");
                }
                this.lastName = value;
            }
        }
        public string FullName
        {
            get
            {
                return string.Format("{0} {1} {2}", this.firstName, this.middleName, this.lastName);
            }
        }

        //ID(EGN) must be a positive 10 digit number
        public string ID
        {
            get
            {
                return this.id;

            }
            set
            {
                if (!Regex.IsMatch(value,@"^\d{10}$"))
                {
                    throw new ArgumentException("id", "ID must be a 10 digit positive number.");
                }
                this.id = value;
            }
        }

        public string PermanentAdress
        {
            get
            {
                return this.permanentAdress;

            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("permanentAdress", "Adress cannot be empty.");
                }
                this.permanentAdress = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;

            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("mobilePhone", "Phone cannot be empty.");
                }
                this.mobilePhone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;

            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !value.Contains("@"))
                {
                    throw new ArgumentException("email", "Email must be a non-empty valid e-mail adress.");
                }
                this.email = value;
            }
        }

        //We're leaving the list open for mutation, but that's because payments should be something that is modifiable, i.e. adding new payments or fixing old ones, however it's setter should be private
        public List<Payment> Payments
        {
            get
            {
                return this.payments;
            }
            private set
            {
                this.payments = value;
            }
        }

        public CustomerType CustomerType
        {
            get
            {
                return this.customerType;

            }
            set
            {
                this.customerType = value;

            }
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.MiddleName.GetHashCode() ^ this.LastName.GetHashCode();
        }

        public object Clone()
        {
            return new Customer(this.firstName, this.middleName, this.lastName, this.id, this.permanentAdress, this.mobilePhone, this.email, this.customerType, new List<Payment>(this.Payments));
        }

        public int CompareTo(Customer other)
        {
            int result = this.FirstName.CompareTo(other.FirstName);
            if (result == 0)
            {
                result = this.ID.CompareTo(other.ID);
            }
            return result;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Name: {0}{1}", this.FullName, Environment.NewLine);
            result.AppendFormat("ID: {0}{1}", this.ID, Environment.NewLine);
            result.AppendFormat("Adress: {0}{1}", this.PermanentAdress, Environment.NewLine);
            result.AppendFormat("Mobile Phone: {0}{1}", this.MobilePhone, Environment.NewLine);
            result.AppendFormat("Email: {0}{1}", this.Email, Environment.NewLine);
            result.AppendFormat("Customer Type: {0}{1}", this.CustomerType, Environment.NewLine);
            result.AppendLine("Payments:");
            foreach (var payment in this.Payments)
            {
                result.AppendLine(payment.ToString());
            }

            return result.ToString();
        }

        public static bool operator ==(Customer customerA, Customer customerB)
        {
            if (Object.Equals(customerA, null))
            {
                return false;
            }
            return customerA.Equals(customerB);
        }
        public static bool operator !=(Customer customerA, Customer customerB)
        {
            if (Object.Equals(customerA, null))
            {
                return false;
            }
            return !customerA.Equals(customerB);
        }

        public override bool Equals(object other)
        {
            if (other == null || Object.Equals(this, null) || other is Customer == false)
            {
                return false;
            }
            var otherCustomer = other as Customer;
            return this.FullName.Equals(otherCustomer.FullName);
        }
    }
}
