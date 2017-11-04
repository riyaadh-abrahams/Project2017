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

namespace Project2017.PresentationLayer
{
    public partial class paymentform : Form
    {
        private PaymentDetail.paymentType paytype;
        private SummaryPage summary;
        private Customer customer;
        private CustomerController customerController;
        public paymentform(CustomerController custController)
        {
            InitializeComponent();
            customerController = custController;
            ShowAll(true, PaymentDetail.paymentType.CreditCard);
        }
        #region Radio Buttons
        private void CardPaymentRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton cardPayment = sender as RadioButton;

            if(cardPayment != null)
            {
                if (cardPayment.Checked)
                {
                    this.Text = "CardPayment";
                    paytype = PaymentDetail.paymentType.CreditCard;
                    ShowAll(true, paytype);
                }
            }
        }

        private void PayLaterRadio_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "pay Later";
            paytype = PaymentDetail.paymentType.Paylater;

            ShowAll(false, paytype);
        }

        #endregion

        #region Form events Click

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void ContinueB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Confirmation box");
            customerController.DataMaintenance(customer, DatabaseLayer.DB.DBOperation.Add);
            customerController.FinalizeChanges(customer);

            if(summary ==null) {
                CreateSummaryForm();
            }
            if(summary.SummaryFormClosed) {
                CreateSummaryForm();
            }

            summary.Show();

            
        }

        private void CreateSummaryForm()
        {
            summary = new SummaryPage(customerController);
            summary.StartPosition = FormStartPosition.CenterParent;
        }
        #endregion

        #region utility methods

        private void ShowAll(bool value, PaymentDetail.paymentType paytype)
        {
            

            if (!(value))
            {
                CardPaymentRadio.Checked = false;
                PayLaterRadio.Checked = false;
            }
            if ((paytype == PaymentDetail.paymentType.CreditCard))
            {
                CardLabel.Visible = value;
                CardTypeLabel.Visible = value;
                CVSLabel.Visible = value;
                ExpiryLabel.Visible = value;

                CardNumberTBox.Visible = value;
                CardTypeComboBox.Visible = value;
                CVSTBox.Visible = value;
                ExpiryDatePicker.Visible = value;
            }
            else
            {
                CardLabel.Visible = false;
                CardTypeLabel.Visible = false;
                CVSLabel.Visible = false;
                ExpiryLabel.Visible = false;

                CardNumberTBox.Visible = false;
                CardTypeComboBox.Visible = false;
                CVSTBox.Visible = false;
                ExpiryDatePicker.Visible = false;
            }

        }

        private void ClearAll()
        {
            CardNumberTBox.Text = "";
            CVSTBox.Text = "";
            CardTypeComboBox.Items.Clear();
            //piryDatePicker.
            // I am not sure of the date time picker

        }

        #endregion

        
    }
}
