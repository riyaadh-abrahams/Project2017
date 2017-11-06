using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using Project2017.BusinessLayer.Entities;
using Project2017.BusinessLayer.Controllers;
using Project2017.DatabaseLayer;

namespace Project2017.PresentationLayer
{
    public partial class SummaryPage : Form
    {
        public bool SummaryFormClosed = false;
        private CustomerController customerController;
        private Customer customer;
        private Collection<Customer> customers;
        Overview overView;

        public SummaryPage(Overview overview)
        {
            InitializeComponent();
            overView = overview;
            customerController = overView.customerController;
            customers = customerController.AllCustomers;

            //Come back later for this
        }
        #region events
        #endregion

        #region button click region

        private void CancelB_Click(object sender, EventArgs e)
        {

            SummaryFormClosed = true;
            this.Close();
        }

        private void ContinueB_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Utility
       /* private void ClearAll()
        {
            Identity.Text = "";
            FirstTBox.Text = "";
            LastTBox.Text = "";
            phoneTBox.Text = "";
            AddressTBox.Text = "";
            CountryTBox.Text = "";
            PostalTBox.Text = "";
            EmailTBox.Text = "";
        }*/

        public void setUpCustomerListView()
        {
            ListViewItem customerDetails;

            CustomerListView.Clear();

            CustomerListView.Columns.Insert(0, "CustomerID", 120, HorizontalAlignment.Left);
            CustomerListView.Columns.Insert(1, "Name", 150, HorizontalAlignment.Left);
            CustomerListView.Columns.Insert(2, "EmailAddress", 120, HorizontalAlignment.Left);
            CustomerListView.Columns.Insert(3, "NumberOfRooms", 120, HorizontalAlignment.Left);

            foreach (Customer customer in customers)
            {
                customerDetails = new ListViewItem();
                customerDetails.Text = customer.CustomerID.ToString();
                customerDetails.SubItems.Add(customer.Name);
                customerDetails.SubItems.Add(customer.Surname);
                customerDetails.SubItems.Add(customer.EmailAddress);

                CustomerListView.Items.Add(customerDetails);
            }

            CustomerListView.Refresh();
            CustomerListView.GridLines = false;
        }

        private void CustomerListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerListView.SelectedItems.Count > 0)
            {
                customer = customerController.Find(CustomerListView.SelectedItems[0].Text);
            }
        }
        #endregion

        private void SummaryPage_Load(object sender, EventArgs e)
        {
            nameL.Text = overView.myCustomer.Name;
            snameL.Text = overView.myCustomer.Surname;
            eAddL.Text = overView.myCustomer.EmailAddress;
            addL.Text = overView.myCustomer.Address;
            phoneL.Text = overView.myCustomer.Phone;

            ArrivalL.Text = overView.myBooking.ArrivalDate.ToString("dd/MM/yyyy");
            DepartureL.Text = overView.myBooking.DepartureDate.ToString("dd/MM/yyyy");
            NRoomL.Text = overView.myBooking.NumberOfRooms.ToString();
            TchargeL.Text = (overView.myBooking.DepositAmount * 10).ToString();
            DepAmountL.Text = overView.myBooking.DepositAmount.ToString();

            if (overView.myBooking.DepositPaid)
            {
                paidL.Text = "Yes (CC No. ends with: ..." + overView.myPaymentDetail.CreditCardNumber.Substring(overView.myPaymentDetail.CreditCardNumber.Length - 4) + ")";
            }
            else
            {
                paidL.Text = "Pay Later";
            }

            

        }

        private void ConfirmB_Click(object sender, EventArgs e)
        {
            //DATABASE STUFF
            overView.customerController.DataMaintenance(overView.myCustomer, overView.personal.dbState);
            overView.bookingController.DataMaintenance(overView.myBooking, DB.DBOperation.Add);

           
            if (overView.myPaymentDetail != null)
            {
                overView.paymentDetailController.DataMaintenance(overView.myPaymentDetail, DB.DBOperation.Add);
            }

            overView.customerController.FinalizeChanges(overView.myCustomer);
            overView.bookingController.FinalizeChanges(overView.myBooking);
            if (overView.myPaymentDetail != null)
            {
                overView.paymentDetailController.FinalizeChanges(overView.myPaymentDetail);
            }


            //RESET EVERYTHING
            overView.myBooking = null;
            overView.myCustomer = null;
            overView.myPaymentDetail = null;

            //close forms
            overView.CreateHomepage();
            overView.goHome.Show();
            

            MessageBox.Show("YOU WIN");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void buttonManage()
        {
            closeButton.Visible = true;
            ConfirmB.Visible = false;
            CancelB.Visible = false;
        }

        private void CancelB_Click_1(object sender, EventArgs e)
        {
            SummaryFormClosed = true;
            this.Hide();
        }
    }
}
