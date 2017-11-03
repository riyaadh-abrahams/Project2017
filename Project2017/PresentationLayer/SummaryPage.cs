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

namespace Project2017.PresentationLayer
{
    public partial class SummaryPage : Form
    {
        public bool form1Closed = false;
        private CustomerController customerController;
        private Customer customer;
        private Collection<Customer> customers;

        public SummaryPage(CustomerController custCont)
        {
            InitializeComponent();
            customerController = custCont;
            customers = customerController.AllCustomers;

            //Come back later for this
        }
        #region events
        #endregion

        #region button click region

        private void CancelB_Click(object sender, EventArgs e)
        {
            
            form1Closed = true;
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
            Customer cust;

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
    }
}
