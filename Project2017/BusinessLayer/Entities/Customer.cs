using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2017.BusinessLayer.Entities
{
    public class Customer
    {

        public string CustomerID    { get; set; }
        public string Name          { get; set; }
        public string Surname       { get; set; }
        public string Address       { get; set; }
        public string EmailAddress  { get; set; }
        public string Phone { get; set; }

        public Customer(string customerID, string name, string surname, string address, string emailAddress, string phone)
        {
            CustomerID = customerID;
            Name = name;
            Surname = surname;
            Address = address;
            EmailAddress = emailAddress;
            Phone = phone;
        }

        public Customer()
        {
            
        }

    }
}
