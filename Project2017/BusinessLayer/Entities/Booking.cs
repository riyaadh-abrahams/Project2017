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

        public Booking(string bookingID, Customer customerID, int numberOfRooms, DateTime arrivalDate, int daysDuration, decimal depositAmount, bool depositPaid)
        {
            BookingID = bookingID;
            CustomerID = customerID;
            NumberOfRooms = numberOfRooms;
            ArrivalDate = arrivalDate;
            DaysDuration = daysDuration;
            DepositAmount = depositAmount;
            DepositPaid = depositPaid;
        }

        public Booking()
        {

        }

        private static int GetOverlappingDays(DateTime firstStart, DateTime firstEnd, DateTime secondStart, DateTime secondEnd)
        {
            DateTime maxStart = firstStart > secondStart ? firstStart : secondStart;
            DateTime minEnd = firstEnd < secondEnd ? firstEnd : secondEnd;
            TimeSpan interval = minEnd - maxStart;
            double returnValue = interval > TimeSpan.FromSeconds(0) ? interval.TotalDays : 0;
            return (int)returnValue;
        }

    }
}
