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

namespace Project2017
{
    public partial class Form1 : Form
    {
        public bool form1Closed = false;
        private Customer customer;
        private CustomerController customerController;
        private paymentform payinglaunch;
        public Form1(CustomerController custCont)
        {
            InitializeComponent();
            customerController = custCont;

        }
        #region button click region

        private void Check_Click(object sender, EventArgs e)
        {

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
            MessageBox.Show("Payment Page");
            customerController.DataMaintenance(customer, DatabaseLayer.DB.DBOperation.Add);
            customerController.FinalizeChanges(customer);

            payinglaunch = CreatePaymentForm(customerController);
            payinglaunch.Show();
            

        }

        private void CreatePaymentForm()
        {
            payinglaunch = new paymentform(customerController);
            payinglaunch.StartPosition = FormStartPosition.CenterParent;
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
            PostalTBox.Text = "";
            EmailTBox.Text = "";
        }
        private void ShowAll(bool value)
        {
            IDLabel.Visible = value;
            NameLabel.Visible = value;
            SurnameLabel.Visible = value;
            EmailLabel.Visible = value;
            AddressLabel.Visible = value;
            PostalLabel.Visible = value;
            PhoneLabel.Visible = value;
            CountryLabel.Visible = value;

            Identity.Visible = value;
            FirstTBox.Visible = value;
            LastTBox.Visible = value;
            AddressTBox.Visible = value;
            EmailTBox.Visible = value;
            PostalTBox.Visible = value;
            phoneTBox.Visible = value;
            CountryTBox.Visible = value;
        }
        #endregion
    }
}
