using System;
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

        public DateChooser(BookingController booking)
        {
            InitializeComponent();
            myBooking = booking;
        }

        public DateChooser(CustomerController custController)
        {
            InitializeComponent();
            customerController = custController;
        }

        private void checkAvailabilityButton_Click(object sender, EventArgs e)
        {
            DateTime arrivalDate = arrivalDatePicker.Value;
            DateTime departureDate = departurelDatePicker.Value;
            int numberOfRooms = (int)numRoomsUpDown.Value;

            bool canIbook = myBooking.CanIBook(arrivalDate, departureDate,numberOfRooms);

            if (canIbook)
            {
                canIBookLable.Text = "Rooms Available";
                if(personal == null) {
                    CreatePersonalForm();
                }
                if(personal.form1Closed) {
                    CreatePersonalForm();
                }

                personal.Show();
            }
            else
            {
                canIBookLable.Text = "Not Enough Rooms Available";
                //Let's add ui refresh
            }
        }

        #region Launch other forms
        private void CreatePersonalForm()
        {
            personal = new Form1(customerController);
            personal.StartPosition = FormStartPosition.CenterParent;
            dateChooserFormClosed = true;  
        }

        private void CreateHomePageForm() {
            goHome = new Homepage(customerController);
            goHome.StartPosition = FormStartPosition.CenterParent;
            dateChooserFormClosed = true;
        }
        #endregion

        private void CancelB_Click(object sender, EventArgs e)
        {
            if(goHome ==null) {
                CreateHomePageForm();
            }
            if(goHome.HomepageFormClosed) {
                CreateHomePageForm();
            }

            goHome.Show();
        }
    }
}
