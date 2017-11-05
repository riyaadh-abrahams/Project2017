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
        public bool listFormClosed = false;
        private CustomerController customerController;
        private Customer customer;
        private Collection<Customer> customers;
        private Homepage goHome;

        public reservationList(CustomerController custController)
        {
            InitializeComponent();
            customerController = custController;
            customers = customerController.AllCustomers;

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
            ShowAll(false);
        }

        private void ReservationList_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        #region List view

        public void setUpReservationListView()
        {
            ListViewItem customerDetails;

            Customer customerGuest;

            ReservationListview.Clear();

            ReservationListview.Columns.Insert(0, "ID", 120, HorizontalAlignment.Left);
            ReservationListview.Columns.Insert(1, "Name", 120, HorizontalAlignment.Left);
            ReservationListview.Columns.Insert(2, "Surname", 120, HorizontalAlignment.Left);
            ReservationListview.Columns.Insert(3, "Phone", 120, HorizontalAlignment.Left);

            //addd more after consulatations

            foreach (Customer cust in customers)
            {
                customerDetails = new ListViewItem();
                customerDetails.Text = cust.CustomerID.ToString();

                customerDetails.SubItems.Add(cust.Name);
                customerDetails.SubItems.Add(cust.Surname);
                customerDetails.SubItems.Add(cust.EmailAddress);

                //add more

                ReservationListview.Items.Add(customerDetails);
            }

            ReservationListview.Refresh();
            ReservationListview.GridLines = true;
        }
        #endregion

        #region Utility Methods
        private void ShowAll(bool value)
        {
            BookingIDLabel.Visible = value;
            IDTBox.Visible = value;
            EditB.Visible = value;
            DeleteB.Visible = value;
            CancelB.Visible = value;
            HomepageB.Visible = value;
        }

        private void ClearAll()
        {
            IDTBox.Text = "";
        }
        #endregion


        #region Button click
        private void EditB_Click(object sender, EventArgs e)
        {
            DeleteB.Visible = false;
            ShowAll(true);
        }

        private void DeleteB_Click(object sender, EventArgs e)
        {
            EditB.Visible = false;
            ShowAll(false);

            MessageBox.Show("This booking will be permanently deleted");
        }

        private void CancelB_Click(object sender, EventArgs e)
        {
            ClearAll();
            ShowAll(false);
            setUpReservationListView();
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
            goHome = new Homepage(customerController);
            //reservationList.
            goHome.StartPosition = FormStartPosition.CenterParent;
            listFormClosed = true;


        }*/

        #endregion
    }
}
