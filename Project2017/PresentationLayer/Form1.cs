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
using Project2017.PresentationLayer;
using Project2017.DatabaseLayer;

namespace Project2017
{
    public partial class Form1 : Form
    {
        public enum FormStates
        {
            View = 0,
            Add = 1,
            Edit = 2,
            Delete = 3
        }
        public FormStates state { get; set; }
        public bool form1Closed = false;
        private Customer customer;
        private CustomerController customerController;
        private Overview overView;
        
        public DB.DBOperation dbState;
        public string idEdit;

        public Form1(Overview overView)
        {
            InitializeComponent();
            this.overView = overView;
            customerController = overView.customerController;
            state = FormStates.Add;
            dbState = DB.DBOperation.Add;
            ContinueB.Enabled = false;


        }
        #region button click region

        private void Check_Click(object sender, EventArgs e)
        {
            ShowAll(true);
            customer = new Customer();
            customer = customerController.Find(Identity.Text);
            if (customerController.Contains(Identity.Text))
            {
                idEdit=customer.CustomerID;
                label1.Text = "Guest Found";
                overView.myCustomer = new Customer();
                overView.myCustomer.CustomerID = Identity.Text;
                PopulateTextBoxes(customer);
                state = FormStates.Edit;
                dbState = DB.DBOperation.Edit;
                
                ContinueB.Enabled = true;
            }
            else
            {
                label1.Text = "Guest Not Found! Add new Guest";
                overView.myCustomer = new Customer();
                state = FormStates.Add;
                dbState = DB.DBOperation.Add;
                //PopulateObject();
                ContinueB.Enabled = true;
                
            }
            
        }

        private void CancelB_Click(object sender, EventArgs e)
        {
            form1Closed = true;
            this.Hide();
        }

        private void ContinueB_Click(object sender, EventArgs e)
        {
            PopulateObject();
            //ClearAll();
            overView.myBooking.CustomerID = overView.myCustomer.CustomerID;
            if (overView.payinglaunch == null)
            {
                overView.CreatePaymentForm();
            }
            if (overView.payinglaunch.formClose)
            {
                overView.payinglaunch.Show();
            }
            
            overView.payinglaunch.Show();


        }
        #endregion
        #region Utility
        private void ClearAll()
        {
            Identity.Text = "";
            FirstTBox.Text = "";
            LastTBox.Text = "";
            phoneTBox.Text = "";
            AddressTBox.Text = "";
            EmailTBox.Text = "";
        }
        private void ShowAll(bool value)
        {
            //IDLabel.Visible = value;
            NameLabel.Visible = value;
            SurnameLabel.Visible = value;
            EmailLabel.Visible = value;
            AddressLabel.Visible = value;
            PhoneLabel.Visible = value;

            //Identity.Visible = value;
            FirstTBox.Visible = value;
            LastTBox.Visible = value;
            AddressTBox.Visible = value;
            EmailTBox.Visible = value;
            phoneTBox.Visible = value;
        }

        private void PopulateTextBoxes(Customer myCustomer)
        {
            FirstTBox.Text = myCustomer.Name;
            LastTBox.Text = myCustomer.Surname;
            EmailTBox.Text = myCustomer.EmailAddress;
            AddressTBox.Text = myCustomer.Address;
            phoneTBox.Text = myCustomer.Phone;

        }

        private void PopulateObject()
        {
            if (state == FormStates.Add)
            {
                overView.myCustomer.CustomerID = Identity.Text;
            }
            overView.myCustomer.Name = FirstTBox.Text;
            overView.myCustomer.Surname = LastTBox.Text;
            overView.myCustomer.EmailAddress = EmailTBox.Text;
            overView.myCustomer.Address = AddressTBox.Text;
            overView.myCustomer.Phone = phoneTBox.Text;

        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowAll(false);
        }
    }
}
