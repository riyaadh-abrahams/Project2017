using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project2017.DatabaseLayer;
using Project2017.BusinessLayer.Entities;
using System.Globalization;

namespace Project2017.BusinessLayer.Controllers
{
    public class BookingController
    {
        BookingDB BookingDB;
        Collection<Booking> Bookings;   //***W3

        #region Properties
        public Collection<Booking> AllBookings
        {
            get
            {
                return Bookings;
            }
        }
        #endregion

        public BookingController()
        {
            //***instantiate the BookingDB object to communicate with the database
            BookingDB = new BookingDB();
            Bookings = BookingDB.AllBookings;
        }

        #region Database Communication
        public void DataMaintenance(Booking myBooking, DB.DBOperation operation)
        {
            int index = 0;
            //perform a given database operation to the dataset in meory; 
            BookingDB.DataSetChange(myBooking, operation);
            //perform operations on the collection
            switch (operation)
            {
                case DB.DBOperation.Add:
                    //*** Add the Booking to the Collection
                    Bookings.Add(myBooking);
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(myBooking);
                    Bookings[index] = myBooking;  // replace Booking at this index with the updated Booking
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(myBooking);  // find the index of the specific Booking in collection
                    Bookings.RemoveAt(index);  // remove that Booking form the collection
                    break;
            }
        }

        //***Commit the changes to the database
        public bool FinalizeChanges(Booking Booking)
        {
            //***call the BookingDB method that will commit the changes to the database
            return BookingDB.UpdateDataSource(Booking);
        }
        #endregion

        #region Search Methods
        //This method  (function) searched through all the employess to finds onlly those with the required role

        //This method receives a Booking BookingID as a parameter; finds the Booking object in the collection of Bookings and then returns this object
        public Booking Find(string BookingID)
        {
            int index = 0;
            bool found = (Bookings[index].BookingID == BookingID);  //check if it is the first student
            int count = Bookings.Count;
            while (!(found) && (index < Bookings.Count - 1))  //if not "this" student and you are not at the end of the list 
            {
                index = index + 1;
                found = (Bookings[index].BookingID == BookingID);   // this will be TRUE if found
            }
            return Bookings[index];  // this is the one!  
        }

        public int FindIndex(Booking myBooking)
        {
            int counter = 0;
            bool found = false;
            found = (myBooking.BookingID == Bookings[counter].BookingID);   //using a Boolean Expression to initialise found
            while (!(found) & counter < Bookings.Count - 1)
            {
                counter += 1;
                found = (myBooking.BookingID == Bookings[counter].BookingID);
            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        }


        #endregion

        #region Utility Methods

        public bool CanIBook(DateTime arrivalDate, DateTime departureDate, int numberOfRooms)
        {
            return BookingDB.roomsAV(arrivalDate, departureDate, 3 ,numberOfRooms);
        }

        public int inclusiveDays(DateTime s1, DateTime e1, DateTime s2, DateTime e2)
        {
            // If they don't intersect return 0.
            if (!(s1 <= e2 && e1 >= s2))
            {
                return 0;
            }

            // Take the highest start date and the lowest end date.
            DateTime start = s1 > s2 ? s1 : s2;
            DateTime end = e1 > e2 ? e2 : e1;

            // Add one to the time range since its inclusive.
            return (int)(end - start).TotalDays ;
        }

        public decimal CalculateCharge(DateTime s, DateTime e, int numRooms)
        {
            int low = inclusiveDays(DateTime.ParseExact("01/12/2017", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        DateTime.ParseExact("07/12/2017", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        s, e);

            int mid = inclusiveDays(DateTime.ParseExact("08/12/2017", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        DateTime.ParseExact("15/12/2017", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        s, e);

            int high = inclusiveDays(DateTime.ParseExact("16/12/2017", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        DateTime.ParseExact("31/12/2017", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        s, e);

            return (low * 500)*numRooms + (mid * 750)*numRooms + (high * 995)*numRooms;
        }

        #endregion

    }
}
