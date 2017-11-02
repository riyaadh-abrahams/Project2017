using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2017.BusinessLayer.Entities
{
    public class Booking
    {

        public string BookingID       { get; set; }
        public string CustomerID      { get; set; }
        public int NumberOfRooms      { get; set; }
        public DateTime ArrivalDate   { get; set; }
        public DateTime DepartureDate { get; set; }
        public decimal DepositAmount  { get; set; }
        public bool DepositPaid       { get; set; }
        public string PaymentID       { get; set; }

        public Booking(string bookingID, string customerID, int numberOfRooms, DateTime arrivalDate, DateTime departureDate, decimal depositAmount, bool depositPaid, string paymentID)
        {
            BookingID = bookingID;
            CustomerID = customerID;
            NumberOfRooms = numberOfRooms;
            ArrivalDate = arrivalDate;
            DepartureDate = departureDate;
            DepositAmount = depositAmount;
            DepositPaid = depositPaid;
            PaymentID = paymentID;
        }

        public Booking()
        {

        }


    }
}
