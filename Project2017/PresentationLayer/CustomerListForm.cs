using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using Project2017.BusinessLayer.Controllers;
using Project2017.BusinessLayer.Entities;

namespace Project2017.PresentationLayer
{
    public partial class CustomerListForm : Form
    {
        public enum FormStates
        {
            View = 0,
            Add = 1,
            Edit = 2,
            Delete = 3
        }
        public bool listFormClosed = false;
        private CustomerController customerController;
        private Collection<Customer> customers;
        private FormStates state;

        public CustomerListForm(CustomerController aController)
        {
            InitializeComponent();
            customerController = aController;
            customers = customerController.AllCustomers;
            //Set up Event Handlers for some form events in code rather than trhough the designer
            this.Load += CustomerListForm_Load;
            this.Activated += CustomerListForm_Activated;
            this.FormClosed += CustomerListForm_FormClosed;
            state = FormStates.View;
        }

        private void CustomerListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.listFormClosed = true;
        }

        private void CustomerListForm_Activated(object sender, EventArgs e)
        {
            customerListView.View = View.Details;
            setUpCustomerListView();
        }


        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            
        }

        public void setUpCustomerListView()
        {
            ListViewItem customerDetails;
            customerListView.Clear();
            customerListView.Columns.Insert(0, "CustomerID", 120, HorizontalAlignment.Left);
            customerListView.Columns.Insert(1, "Name", 120, HorizontalAlignment.Left);
            customerListView.Columns.Insert(2, "Surname", 150, HorizontalAlignment.Left);
            customerListView.Columns.Insert(3, "Address", 100, HorizontalAlignment.Left);
            customerListView.Columns.Insert(4, "EmailAddress", 100, HorizontalAlignment.Left);

            foreach (Customer customer in customers)
            {
                customerDetails = new ListViewItem();
                customerDetails.Text = customer.CustomerID;

                customerDetails.SubItems.Add(customer.Name);
                customerDetails.SubItems.Add(customer.Surname);
                customerDetails.SubItems.Add(customer.Address);
                customerDetails.SubItems.Add(customer.EmailAddress);

                customerListView.Items.Add(customerDetails);
            }

            customerListView.Columns[3].Width = -2;
            customerListView.Columns[4].Width = -2;

            customerListView.Refresh();
            customerListView.GridLines = true;



            for (int ix = 0; ix < customerListView.Items.Count; ++ix)
            {
                var item = customerListView.Items[ix];
                item.BackColor = (ix % 2 == 0) ? Color.Beige : Color.White;
            }
        
    }

    }

 }
