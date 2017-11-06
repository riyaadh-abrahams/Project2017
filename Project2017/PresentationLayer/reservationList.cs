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
using Project2017.PresentationLayer;
using Project2017.BusinessLayer.Entities;
using System.Collections.ObjectModel;

namespace Project2017.PresentationLayer
{
    public partial class reservationList : Form
    {
        public enum FormStates
        {
            View = 0,
            Clicked = 1,
            Edit = 2,
            Delete = 3
        }
        public FormStates state { get; set; }
        public bool listFormClosed = false;
        private Collection<Booking> bookings;
        Overview overView;
        private decimal charge;
        private decimal deposit;

        public reservationList(Overview overview)
        {
            InitializeComponent();
            overView = overview;
            bookings = overview.bookingController.AllBookings;
            this.Load += ReservationList_Load;
            this.Activated += ReservationList_Activated;
            this.FormClosed += ReservationList_FormClosed;
        }

        #region Form Events
        private void ReservationList_FormClosed(object sender, FormClosedEventArgs e)
        {
            listFormClosed = true;
        }

        private void ReservationList_Activated(object sender, EventArgs e)
        {
            ReservationListview.View = View.Details;
            setUpReservationListView();
            state = FormStates.View;
            ShowAll();
        }

        private void ReservationList_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        #region List view

        public void setUpReservationListView()
        {
            ListViewItem bookingDetails;
            ReservationListview.Clear();

            ReservationListview.Columns.Insert(0, "BookingID", 120, HorizontalAlignment.Left);
            ReservationListview.Columns.Insert(1, "CustomerID", 120, HorizontalAlignment.Left);
            ReservationListview.Columns.Insert(2, "NumberOfRooms", 120, HorizontalAlignment.Left);
            ReservationListview.Columns.Insert(3, "ArrivalDate", 120, HorizontalAlignment.Left);
            ReservationListview.Columns.Insert(4, "DepartureDate", 120, HorizontalAlignment.Left);
            ReservationListview.Columns.Insert(5, "DepositAmount", 120, HorizontalAlignment.Left);
            ReservationListview.Columns.Insert(6, "DepositPaid", 120, HorizontalAlignment.Left);
            ReservationListview.Columns.Insert(7, "PaymentID", 120, HorizontalAlignment.Left);

            //addd more after consulatations

            foreach (Booking cust in bookings)
            {
                bookingDetails = new ListViewItem();
                bookingDetails.Text = cust.BookingID.ToString();

                bookingDetails.SubItems.Add(cust.CustomerID);
                bookingDetails.SubItems.Add(cust.NumberOfRooms.ToString());
                bookingDetails.SubItems.Add(cust.ArrivalDate.ToString("dd/MM/yyyy"));
                bookingDetails.SubItems.Add(cust.DepartureDate.ToString("dd/MM/yyyy"));
                bookingDetails.SubItems.Add(cust.DepositAmount.ToString());
                bookingDetails.SubItems.Add(cust.DepositPaid.ToString());
                bookingDetails.SubItems.Add(cust.PaymentID);


                //add more

                ReservationListview.Items.Add(bookingDetails);
            }

            ReservationListview.Refresh();
            ReservationListview.GridLines = true;

            for (int ix = 0; ix < ReservationListview.Items.Count; ++ix)
            {
                var item = ReservationListview.Items[ix];
                item.BackColor = (ix % 2 == 0) ? Color.Beige : Color.White;
            }

        }
        #endregion

        private void ShowAll()
        {
            if (state == FormStates.View)
            {
                EditB.Visible = false;
                DeleteB.Visible = false;
                cancelButton.Visible = false;
                submitButton.Visible = false;
                arrivalDatePicker.Visible = false;
                departureDatePicker.Visible = false;
                numRoomsUpDown.Visible = false;
                arrL.Visible = false;
                depL.Visible = false;
                numL.Visible = false;
                button1.Visible = false;
                ReservationListview.Enabled = true;
                idL.Visible = false;
            }

            if (state == FormStates.Clicked)
            {
                EditB.Visible = true;
                DeleteB.Visible = true;
                cancelButton.Visible = false;
                submitButton.Visible = false;
                arrivalDatePicker.Visible = false;
                departureDatePicker.Visible = false;
                numRoomsUpDown.Visible = false;
                arrL.Visible = false;
                depL.Visible = false;
                numL.Visible = false;
                button1.Visible = false;
                ReservationListview.Enabled = true;
                idL.Visible = false;
            }
            if (state == FormStates.Edit)
            {
                EditB.Visible = false;
                DeleteB.Visible = false;
                cancelButton.Visible = true;
                submitButton.Visible = true;
                submitButton.Enabled = false;
                arrivalDatePicker.Visible = true;
                departureDatePicker.Visible = true;
                numRoomsUpDown.Visible = true;
                arrL.Visible = true;
                depL.Visible = true;
                numL.Visible = true;
                button1.Visible = true;
                ReservationListview.Enabled = false;
                idL.Visible = true;
                idL.Text = "Edit Booking: "+overView.myBooking.BookingID;
            }

        }

        #region Button click
        private void EditB_Click(object sender, EventArgs e)
        {
            state = FormStates.Edit;
            if (ReservationListview.SelectedItems.Count > 0)   // if you selected an item 
            {
                overView.myBooking = overView.bookingController.Find(ReservationListview.SelectedItems[0].Text);
                arrivalDatePicker.Value = overView.myBooking.ArrivalDate;
                departureDatePicker.Value = overView.myBooking.DepartureDate;
                numRoomsUpDown.Value = overView.myBooking.NumberOfRooms;
            }
            ShowAll();
        }

        private void DeleteB_Click(object sender, EventArgs e)
        {
            EditB.Visible = false;
            ShowAll();

            MessageBox.Show("This booking will be permanently deleted");
        }
        /*private void ContinueB_Click(object sender, EventArgs e)
        {
            if(goHome==null) {
                CreateHomepae();
            }
            if(goHome.HomepageFormClosed) {
                CreateHomepae();
            }

            goHome.Show();
        }*/

        /*private void CreateHomepae()
        {
            goHome = new Homepage(bookingController);
            //reservationList.
            goHome.StartPosition = FormStartPosition.CenterParent;
            listFormClosed = true;


        }*/

        #endregion

        private void ReservationListview_SelectedIndexChanged(object sender, EventArgs e)
        {
            state = FormStates.Clicked;
            ShowAll();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            state = FormStates.View;
            overView.myBooking = null;
            ShowAll();
            setUpReservationListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime arrivalDate = arrivalDatePicker.Value;
            DateTime departureDate = departureDatePicker.Value;
            int numberOfRooms = (int)numRoomsUpDown.Value;

            bool canIbook = overView.bookingController.CanIBook(arrivalDate, departureDate, numberOfRooms-overView.myBooking.NumberOfRooms);

            if (canIbook)
            {
                if (departureDate > arrivalDate)
                {
                    charge = overView.bookingController.CalculateCharge(arrivalDatePicker.Value, departureDatePicker.Value, (int)numRoomsUpDown.Value);
                    deposit = charge * 0.1m;
                    canIBookLable.Text = "Rooms Available. Charge = R" + charge;
                    depositLabel.Text = "Deposit (10%): R" + deposit;
                    submitButton.Enabled = true;
                }
                else
                {
                    canIBookLable.Text = "Invaid Dates!";
                    submitButton.Enabled = false;
                    depositLabel.Text = "";
                }

            }
            else
            {
                canIBookLable.Text = "Not Enough Rooms Available";
                submitButton.Enabled = false;
                depositLabel.Text = "";
                //Let's add ui refresh
            }
        }

        private void numRoomsUpDown_Click(object sender, EventArgs e)
        {
            
        }

        private void numRoomsUpDown_ValueChanged(object sender, EventArgs e)
        {
            submitButton.Enabled = false;
        }

        private void departureDatePicker_ValueChanged(object sender, EventArgs e)
        {
            submitButton.Enabled = false;
        }

        private void arrivalDatePicker_ValueChanged(object sender, EventArgs e)
        {
            submitButton.Enabled = false;
        }
    }
}
