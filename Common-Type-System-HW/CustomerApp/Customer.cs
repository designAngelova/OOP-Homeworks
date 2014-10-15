using System;
using System.Collections.Generic;

namespace CustomerApp
{
    public class Customer : ICloneable, IComparable<Customer>
    {
        public Customer(string firstName,
            string middleName,
            string lastName,
            string id,
            string address,
            string phone,
            string email,
            CustomerType customerType)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Id = id;
            Address = address;
            Phone = phone;
            Email = email;
            Payments = new List<Payment>();
            CustomerType = customerType;
        }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Id { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public List<Payment> Payments { get; set; }

        public CustomerType CustomerType { get; set; }

        private string FullName
        {
            get
            {
                return this.FirstName + this.MiddleName + this.LastName;
            }
        }

        public override bool Equals(object obj)
        {
            Customer customer = obj as Customer;

            if (customer == null)
            {
                return false;
            }

            if (!Object.Equals(this.Id, customer.Id))
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode() ^ this.Email.GetHashCode();
        }

        public static bool operator ==(Customer c1, Customer c2)
        {
            if (ReferenceEquals(c1, c2))
            {
                return true;
            }

            if (((object) c1 == null) || ((object) c2 == null))
            {
                return false;
            }

            return c1.Equals(c2);
        }

        public static bool operator !=(Customer c1, Customer c2)
        {
            return !(c1 == c2);
        }

        public override string ToString()
        {
            return string.Format("First Name: {0}\n" +
                                 "Middle Name: {1}\n" +
                                 "Last Name: {2}\n " +
                                 "Id: {3}\n " +
                                 "Address: {4}\n " +
                                 "Phone: {5}\n " +
                                 "Email: {6}\n " +
                                 "Customer Type: {7}\n " +
                                 "Payments: {8}",
                FirstName, MiddleName, LastName, Id, Address, Phone, Email, CustomerType,
                String.Join("\n  - ", Payments));
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public Customer Clone()
        {
            Customer customerCopy = new Customer(this.FirstName, this.MiddleName, this.LastName,
                this.Id, this.Address, this.Phone, this.Email, this.CustomerType);

            customerCopy.Payments = new List<Payment>();

            foreach (var payment in this.Payments)
            {
                customerCopy.Payments.Add(new Payment(payment.ProductName, payment.Price));
            }
            
            return customerCopy;
        }

        public int CompareTo(Customer other)
        {
            int firstNameEquality = this.FullName.CompareTo(other.FullName);
            int idEquality = this.Id.CompareTo(other.Id);

            return firstNameEquality == 0 ? idEquality : firstNameEquality;
        }
    }
}
