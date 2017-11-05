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
using Project2017.PresentationLayer;

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

        public bool form1Closed = false;
        private Customer customer;
        private CustomerController customerController;
        private Overview overView;
        private FormStates state;

        public Form1(Overview overView)
        {
            InitializeComponent();
            this.overView = overView;
            customerController = overView.customerController;
            state = FormStates.Add;
            ContinueB.Enabled = false;


        }
        #region button click region

        private void Check_Click(object sender, EventArgs e)
        {
            customer = new Customer();
            customer = customerController.Find(Identity.Text);
            if (customerController.Contains(Identity.Text))
            {
                label1.Text = "Guest Found";
                PopulateTextBoxes(customer);
                state = FormStates.Edit;
                ContinueB.Enabled = true;
            }
            else
            {
                label1.Text = "Guest Not Found! Add new Guest";
                ContinueB.Enabled = true;
            }
            
        }

        private void CancelB_Click(object sender, EventArgs e)
        {
            ClearAll();
            form1Closed = true;
            ShowAll(false);
            this.Close();
        }

        private void ContinueB_Click(object sender, EventArgs e)
        {

            ClearAll();

            overView.CreatePaymentForm();
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
            CountryTBox.Text = "";
            EmailTBox.Text = "";
        }
        private void ShowAll(bool value)
        {
            IDLabel.Visible = value;
            NameLabel.Visible = value;
            SurnameLabel.Visible = value;
            EmailLabel.Visible = value;
            AddressLabel.Visible = value;
            PhoneLabel.Visible = value;
            CountryLabel.Visible = value;

            Identity.Visible = value;
            FirstTBox.Visible = value;
            LastTBox.Visible = value;
            AddressTBox.Visible = value;
            EmailTBox.Visible = value;
            phoneTBox.Visible = value;
            CountryTBox.Visible = value;
        }

        private void PopulateTextBoxes(Customer myCustomer)
        {
            FirstTBox.Text = myCustomer.Name;
            LastTBox.Text = myCustomer.Surname;
            EmailTBox.Text = myCustomer.EmailAddress;
            AddressTBox.Text = myCustomer.Address;


        }
            #endregion
        }
}
