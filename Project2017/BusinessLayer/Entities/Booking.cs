using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2017.BusinessLayer.Entities
{
    public class Booking
    {
        public string BookingID      { get; set; }
        public Customer CustomerID   { get; set; }
        public int NumberOfRooms     { get; set; }
        public DateTime ArrivalDate  { get; set; }
        public int DaysDuration      { get; set; }
        public decimal DepositAmount { get; set; }
        public bool DepositPaid      { get; set; }

    }
}
