﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project2017.BusinessLayer.Controllers;
using Project2017.BusinessLayer.Entities;

namespace Project2017.PresentationLayer
{
    public partial class DateChooser : Form
    {
        public bool dateChooserFormClosed = false;
        private BookingController myBooking;
        private CustomerController customerController;
        private Form1 personal;
        private Homepage goHome;
        private Overview overView;


        public DateChooser(Overview overview)
        {
            InitializeComponent();
            this.overView = overview;
            customerController = overview.customerController;
            myBooking = overView.bookingController;

            ContinueB.Enabled = false;
            
        }

        private void checkAvailabilityButton_Click(object sender, EventArgs e)
        {
            DateTime arrivalDate = arrivalDatePicker.Value;
            DateTime departureDate = departurelDatePicker.Value;
            int numberOfRooms = (int)numRoomsUpDown.Value;

            bool canIbook = myBooking.CanIBook(arrivalDate, departureDate,numberOfRooms);

            if (canIbook)
            {
                if (departureDate > arrivalDate)
                {
                    decimal charge = overView.bookingController.CalculateCharge(arrivalDatePicker.Value, departurelDatePicker.Value);
                    canIBookLable.Text = "Rooms Available. Charge = " + charge;
                    ContinueB.Enabled = true;
                }
                else
                {
                    canIBookLable.Text = "Invaid Dates!";
                    ContinueB.Enabled = false;
                }
                
            }
            else
            {
                canIBookLable.Text = "Not Enough Rooms Available";
                ContinueB.Enabled = false;
                //Let's add ui refresh
            }
        }

        #region Launch other forms


        private void ContinueB_Click(object sender, EventArgs e)
        {
            if (overView.personal == null)
            {
                overView.CreatePersonalForm();
            }
            if (overView.personal.form1Closed)
            {
                overView.CreatePersonalForm();
            }

            //Create Booking
            overView.myBooking = new Booking();
            overView.myBooking.ArrivalDate = arrivalDatePicker.Value;
            overView.myBooking.DepartureDate = departurelDatePicker.Value;
            overView.myBooking.NumberOfRooms = (int)numRoomsUpDown.Value;

            overView.personal.Show();
        }

        private void CancelB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        /*private void CreateHomePageForm() {
            goHome = new Homepage(customerController, );
            goHome.StartPosition = FormStartPosition.CenterParent;
            dateChooserFormClosed = true;
        }
        

        private void CancelB_Click(object sender, EventArgs e)
        {
            if(goHome ==null) {
                CreateHomePageForm();
            }
            if(goHome.HomepageFormClosed) {
                CreateHomePageForm();
            }

            goHome.Show();
        }*/
    }
}
