using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2017.BusinessLayer.Entities
{
    class Customer
    {
        public string CustomerID    { get; set; }
        public string Name          { get; set; }
        public string Surname       { get; set; }
        public string Address       { get; set; }
        public string EmailAddress  { get; set; }
        public int NumberOfGuests   { get; set; }

    }
}
